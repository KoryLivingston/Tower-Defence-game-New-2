Public Class TowerController

    'List to hold every tower object to allow towers to be sold and to be removed from the list without affecting the logic of the code
    'Arrays of Tower and pictureboxes for each tower

    Private currentTowers As New List(Of Tower)
    Private Towers() As Tower
    Private PicTower() As PictureBox

    'Arrays of Panel, Label and pictureboxes for the UI for each tower

    Private TowerUI() As Panel
    Private LblBuffPrice() As Label
    Private UpgradeSlots1() As PictureBox
    Private UpgradeSlots2() As PictureBox
    Private UpgradeSlots3() As PictureBox


    'Towercount is used to redclare the arrays to hold the new position of the next tower to be created
    'Towerplacing is used to determine whether the player is placing a tower and to run certain code while doing so

    Private TowerCount As Integer
    Private TowerPlacing As Boolean

    'ClickedTower holds the tower object that has been clicked, this will then be used in the code involving the tower UI
    'Index holds the position of this tower in the list, so if it is sold it can be removed from the list

    Private clickedTower As Tower
    Private Index As Integer


    'Updates Tower Cap Label
    Public Sub updateCapLabel()


        Game.LblTowerCapacity.Text = "Tower Capacity" & " " & TowerCount & "/25"

    End Sub

    'For every tower find its next target 
    Public Sub FindAllTargets()


        For counter = 0 To TowerCount - 1

            currentTowers(counter).FindTarget()

        Next

    End Sub

    Public Sub updateUpgradePriceLables()

        For counter = 0 To TowerCount - 1

            currentTowers(counter).setLblBuffPrice(currentTowers(counter).getcurrentUpgrade)

        Next

    End Sub

    'Adjust the tower indicators position so that its center is at the cursors position
    Public Sub moveTowerIndicator()

        If TowerPlacing = True Then

            Dim p As New Point(18, 16)
            Game.TowerIndicator.Location = New Point(Game.PointToClient(Cursor.Position) - p)

        End If

    End Sub

    'If they have enough coins and are currently not placing a tower as well as the total towers placed has yet to reach 25 and the game hasn't ended
    'Then set towerplacing to true and show the cancel button
    Public Sub buyNewTower()

        If Game.getCoins >= 30 And TowerPlacing = False AndAlso TowerCount < 25 AndAlso Game.getLives > 0 Then

            TowerPlacing = True
            Game.CancelPlacing.Show()

            Game.TowerIndicator.Show()
            Game.TowerIndicator.BringToFront()
            Game.TowerIndicator.BackColor = Color.FromArgb(200, Game.TowerIndicator.BackColor)

        End If

    End Sub


    'Checks if the tower indicator is not in collision with any picturebox to ensure that the spawn location is valid
    'If the location is valid then it will hide the UI used during tower placing and create a tower to be placed at this new set position

    Public Sub placeNewTower()

        Dim p As New Point(18, 16)

        For Each PictureBox As PictureBox In Game.Controls.OfType(Of PictureBox)

            If PictureBox IsNot Game.TowerIndicator AndAlso Game.TowerIndicator.Bounds.IntersectsWith(PictureBox.Bounds) Then
                Exit Sub
            End If

        Next

        Game.TowerIndicator.Hide()
        Game.CancelPlacing.Hide()

        'Redeclares PicTower to towercount to allow a new tower picturebox to be created

        ReDim Preserve PicTower(TowerCount)


        PicTower(TowerCount) = New PictureBox With {
    .Size = New Size(37, 33),
    .BackColor = Color.CadetBlue,
    .Name = "PicTower" & TowerCount.ToString,
    .Location = Game.PointToClient(Cursor.Position) - p
                    }

        'Adds it to the forms controls so that it can be used

        Game.Controls.Add(PicTower(TowerCount))
        PicTower(TowerCount).BringToFront()


        'Adds this picturebox click event as a handler of the tower_click sub routine

        AddHandler PicTower(TowerCount).Click, AddressOf Game.PicTower_Click

        'Redeclares TowerUI to towercount to allow a new tower UI to be created

        ReDim Preserve TowerUI(TowerCount)

        TowerUI(TowerCount) = New Panel With {
    .Size = New Size(108, 164),
    .BackColor = Color.FromArgb(130, Game.TurretPanel.BackColor),
    .Location = New Point(-1000, 100)
                }

        Game.Controls.Add(TowerUI(TowerCount))

        'Redeclares LBlBuffPrice to allow a new tower buff price label to be created

        ReDim Preserve LblBuffPrice(TowerCount)

        LblBuffPrice(TowerCount) = New Label With {
    .Font = New Font("Agency FB", 10, FontStyle.Bold),
    .ForeColor = Color.White,
    .TextAlign = 2,
    .Size = New Size(82, 17),
    .BackColor = Color.FromArgb(130, Game.TurretPanel.BackColor),
    .Location = New Point(14, 50)
            }

        'Added to the towerUI Controls as it will be used in this panel

        TowerUI(TowerCount).Controls.Add(LblBuffPrice(TowerCount))

        'Redcalres every upgradeslot array before use

        ReDim Preserve UpgradeSlots1(TowerCount)
        ReDim Preserve UpgradeSlots2(TowerCount)
        ReDim Preserve UpgradeSlots3(TowerCount)

        'Creates every upgrade slot for this tower

        CreateUpgradeSlots(UpgradeSlots1, 14, 5)
        CreateUpgradeSlots(UpgradeSlots2, 45, 5)
        CreateUpgradeSlots(UpgradeSlots3, 75, 5)

        'New Tower is created

        ReDim Preserve Towers(TowerCount)
        Towers(TowerCount) = New Tower(PicTower(TowerCount), TowerUI(TowerCount), LblBuffPrice(TowerCount), UpgradeSlots1(TowerCount), UpgradeSlots2(TowerCount), UpgradeSlots3(TowerCount), 1, 100)
        currentTowers.Add(Towers(TowerCount))

        Game.setCoins(-30)
        TowerCount += 1
        TowerPlacing = False

    End Sub

    Public Sub CreateUpgradeSlots(Slot() As PictureBox, LocationX As Integer, LocationY As Integer)

        Slot(TowerCount) = New PictureBox With {
    .Size = New Size(21, 11),
    .BackColor = Color.White,
    .Location = New Point(LocationX, LocationY)
            }

        TowerUI(TowerCount).Controls.Add(Slot(TowerCount))

    End Sub

    Public Sub cancelPlacingTower()

        TowerPlacing = False
        Game.TowerIndicator.Hide()
        Game.CancelPlacing.Hide()

    End Sub

    Public Sub startShooting()

        For counter = 0 To TowerCount - 1
            currentTowers(counter).shootTarget()
        Next

    End Sub


    Public Sub enableTowerUI(TowerSender As PictureBox)


        'If clickedTower has already been declared then this must be the second time that the same tower was clicked
        'First time brings up the UI, and this second time will remove it

        If clickedTower IsNot Nothing Then

            clickedTower.getTowerUI.Hide()
            clickedTower = Nothing

            Exit Sub

        End If

        'Find the tower object that has been clicked and set it to clickedtower

        For counter = 0 To TowerCount - 1

            If TowerSender Is currentTowers(counter).getTowerGraphic Then
                clickedTower = currentTowers(counter)
                Index = counter
                Exit For
            End If

        Next


        'Once clickedtower has been assigned a value then show the towers UI

        If clickedTower IsNot Nothing Then

            With clickedTower

                .getTowerUI.Show()
                .getTowerUI.bringtofront()
                .getTowerGraphic.bringtofront()

                .getTowerUI.Location = New Point(clickedTower.getTowerGraphic.location.x - 36, clickedTower.getTowerGraphic.location.y - 80)
                .getTowerUI.controls.add(Game.SellButton)
                .getTowerUI.controls.add(Game.DamageBuffButton)
                Game.SellButton.Location = New Point(14, 130)
                Game.DamageBuffButton.Location = New Point(14, 22)

            End With

        End If

    End Sub

    Public Sub sellTower()

        'Increases the players coins by 20 and delete the tower and hide the towers UI

        Game.setCoins(20)


        Game.Controls.Remove(currentTowers(Index).getTowerGraphic)
        currentTowers.RemoveAt((Index))
        TowerCount -= 1

        clickedTower.getTowerUI.Hide()
        clickedTower = Nothing

    End Sub


    Public Sub upgradeTower()

        'Then upgrade the tower to the next availble upgrading, increasing its damage by 1 with every succesive one, changing the upgradeslot of the associated upgrade to green to indicate it has been bought
        'deduct the buffprice from the coins and set the new buffprice for the next upgrade as well increasing currentUpgrade by 1 so that the next upgrade can be bought


        With clickedTower
            If Game.getCoins >= .getBuffprice And .getcurrentUpgrade <= 2 Then


                .setDamage(2 + .getcurrentUpgrade)

                .getUpgradeSlots(.getcurrentUpgrade).BackColor = Color.Green
                Game.setCoins(- .getBuffprice)
                .setBuffPrice(250 + (.getcurrentUpgrade * 250))
                .setcurrentUpgrade(1)

            End If
        End With

    End Sub

    Public Sub resetTowers()


        For counter = 0 To TowerCount - 1
            Game.Controls.Remove(currentTowers(counter).getTowerGraphic)
        Next

        Towers = Nothing
        PicTower = Nothing
        TowerUI = Nothing
        LblBuffPrice = Nothing
        UpgradeSlots1 = Nothing
        UpgradeSlots2 = Nothing
        UpgradeSlots3 = Nothing
        currentTowers.Clear()
        TowerCount = 0
        TowerPlacing = False

    End Sub

End Class
