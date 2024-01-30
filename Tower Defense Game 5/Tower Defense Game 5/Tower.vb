
Public Class Tower

    Private TowerGraphic As PictureBox
    Private Target As Enemy
    Private Damage As Integer
    Private TowerUI As Panel
    Private LblUpgradePrice As Label
    Private UpgradeSlots(2) As PictureBox
    Private UpgradePrice As Integer
    Private CurrentUpgrade As Integer

    Public Sub New(Graphic As PictureBox, TowerUI As Panel, LblUpgradePrice As Label, UpgradeSlots1 As PictureBox, upgradeSlots2 As PictureBox, UpgradeSlots3 As PictureBox, Damage As Integer, UpgradePrice As Integer)

        TowerGraphic = Graphic
        Target = Nothing

        UpgradeSlots(0) = UpgradeSlots1
        UpgradeSlots(1) = upgradeSlots2
        UpgradeSlots(2) = UpgradeSlots3


        With Me

            .Damage = Damage
            .TowerUI = TowerUI
            .UpgradePrice = UpgradePrice
            .LblUpgradePrice = LblUpgradePrice
            .LblUpgradePrice.Text = UpgradePrice & " COINS"

        End With

    End Sub

    'Method used to find the next target for a tower
    'First if statement is used to check the towers who already have a target, and if this target is no longer in range, then it should no longer be its target
    'Second if statement is used to assign targets to towers which currently don't have one, it checks every enemy to the given tower from the for loop to check if one is in range
    'As soon as it finds one it assigns it as its target, exits for since it is no longer necessary

    Public Sub FindTarget()

        If Target IsNot Nothing AndAlso EnemyIsInRange(Me, Target) = False Then
            Console.WriteLine("Enemy Left Range")
            Target = Nothing
        End If

        If Target Is Nothing Then

            For Each Enemy As Enemy In Game.getEnemies


                If EnemyIsInRange(Me, Enemy) Then

                    Console.WriteLine("Enemy In Range")
                    Target = Enemy
                    Exit For

                End If

            Next

        End If

    End Sub

    'Method used to shoot the towers target
    'First if statement checks if this towers targets health is already 0, if so it sets its target to nothing, this prevents the enemy death condition from running for an enemy that is already dead
    'If statement is used to check if the tower has a target, if so it then reduces the targets health by 1,
    'then if the targets health reaches 0 it incerases the enemieskilledinwave and totalenemieskilled by 1,
    'increases the players coins by the amount recieved from the enemy and increases total coins earned by the amount recieved from the enemy
    'targetenemies associated enemy object isdead attribute is set to false
    'target enemy is set to nothing

    Public Sub shootTarget()

        With Game

            If Target IsNot Nothing AndAlso Target.getHealth <= 0 Then

                Target = Nothing

            End If


            If Target IsNot Nothing Then

                Target.setHealth(Damage)


                If Target.getHealth <= 0 And Target.getIsDead = False Then

                    Target.getEnemyGraphic.Top -= 1000
                    .setEnemiesKilledInWave()
                    .setTotalEnemiesKilled()

                    .setCoins(Target.getCoinsDropped)
                    .setTotalCoinsEarned(Target.getCoinsDropped)

                    Target.setIsdead(True)
                    Target = Nothing


                End If
            End If

        End With

    End Sub

    'Towers will shoot any enemy that is in an area of a circle that surrounds the tower
    'the radius of this circle is equal to the towers range
    'Therefore if the distance is less than the range it must be in this valid area to be shot if it is a target
    'Function used to calculate the distance between a given tower and enemy

    Public Function EnemyIsInRange(Tower As Tower, Enemy As Enemy) As Boolean

        Dim p As New Point(18, 16)

        Dim towerCenterX As Integer = Tower.TowerGraphic.Location.X - p.X
        Dim towerCenterY As Integer = Tower.TowerGraphic.Location.Y - p.Y
        Dim enemyCenterX As Integer = Enemy.getEnemyGraphic.Location.X - Enemy.getEnemyGraphic.Width \ 2
        Dim enemyCenterY As Integer = Enemy.getEnemyGraphic.Location.Y - Enemy.getEnemyGraphic.Height \ 2

        Dim distance As Double = Math.Sqrt((towerCenterX - enemyCenterX) ^ 2 + (towerCenterY - enemyCenterY) ^ 2)


        Return Enemy.getEnemyGraphic.Location.X >= 20 And
    distance <= 160

    End Function


    Public Function getTowerGraphic()

        Return TowerGraphic

    End Function

    Public Function getTowerUI()

        Return TowerUI

    End Function

    Public Sub setLblBuffPrice(Index As Integer)

        LblUpgradePrice.Text = UpgradePrice & " COINS"

        If Index = 3 Then
            LblUpgradePrice.Text = "MAXED"
        End If

    End Sub

    Public Function getUpgradeSlots(Index As Integer)

        Return UpgradeSlots(Index)

    End Function

    Public Sub setDamage(Newdamage As Integer)

        Damage = Newdamage

    End Sub

    Public Sub setBuffPrice(NewPrice As Integer)

        UpgradePrice = NewPrice

    End Sub

    Public Function getBuffprice()

        Return UpgradePrice

    End Function

    Public Sub setcurrentUpgrade(NewIndex)

        CurrentUpgrade += NewIndex

    End Sub

    Public Function getcurrentUpgrade()

        Return CurrentUpgrade

    End Function

End Class
