
Public Class Game

    'Player stats

    Private Lives As Integer = 10
    Private Coins As Integer = 70
    Private Wave As Integer = 1

    'Objects of other class to be used in the main class

    Private WaveCon As New WaveController
    Private TowerCon As New TowerController
    Private LeaderBoardCon As New LeaderBoardController


    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click


        'Once the startbutton is clicked it:
        'Spawns the enemies for wave 1
        'Initializes the labels to be used in the leaderboard
        'Loads the game UI
        'Starts the games timers


        WaveCon.WaveSpawn()
        LeaderBoardCon.InitializeLabels()
        LoadUI()
        startTimers()


    End Sub

    Private Sub GameLogic_Tick(sender As Object, e As EventArgs) Handles GameLogic.Tick

        'Updates Player Stats Labels

        LblLives.Text = "LIVES " & Lives
        LblCoins.Text = "COINS " & Coins
        LblWave.Text = "WAVE " & Wave

        'Checks if a wave has ended by comparing the enemieskilled to the totalenemies for that wave
        'Waveended is used to prevent the condition from running again until the next wave has been called from pressing the next wave button
        'Starts the wavecompletionUI timer to simulate the label showing then dissapearing 2 seconds later and to show the nextwavebutton once this has been done

        'A condition used to check if a wave has ended by comparing the total enemies killed in a wave to the total enemies in the beginning of the wave
        'A boolean flag known as WaveEnded is used to prevent the condition from running again until the next wave started
        'A timer satrts known as WaveCompletionUI to simulate the wave completion UI appearing then dissapearing after 2 seconds, then the nextwavebutton is shown, which players can click to start the next wave

        WaveCon.CheckWaveEnded()

        'Once the player Lives reaches 0 or they complete the final wave it ends the game

        If Lives = 0 Or Wave = 26 Then
            Endgame()
        End If

        'A for loop which loops through every enemy and makes them move along the predefined path and checks if they have reached the player base

        WaveCon.EnemyLogic()

        'A condition used to check if the lastEnemy variable has been assigned to an enemy object and if it is dead, which would result in the next group of 10 enemies spawning.

        WaveCon.CheckToSpawnMore()

        'Updates Tower Cap Label

        TowerCon.updateCapLabel()
        TowerCon.FindAllTargets()
        TowerCon.updateUpgradePriceLables()
        TowerCon.moveTowerIndicator()

        'UI brought to the front when in use to prevent the tower indicator from overlapping it

        LblWaveCompleted.BringToFront()
        NextWaveButton.BringToFront()
        CancelPlacing.BringToFront()

    End Sub

    Private Sub WaveCompletionUI_Tick(sender As Object, e As EventArgs) Handles WaveCompletionUI.Tick

        LblWaveCompleted.Hide()
        WaveCompletionUI.Stop()
        NextWaveButton.Show()
        NextWaveButton.BringToFront()

    End Sub



    'If the nextwavebutton is pressed it hides it and increases the wave by one
    'Checks if the wave is now any of the waves that brings in a new type of enemy so that additionalenemies can be set to 0 for the new enemy type
    'additionalenemies is increased by 2 to allow a new total of enemies to be brought into the next wave
    'Wavespawn sub routine is called to spawn the next wave
    Private Sub NextWaveButton_Click(sender As Object, e As EventArgs) Handles NextWaveButton.Click

        NextWaveButton.Hide()

        WaveCon.StartNextWave()
        WaveCon.WaveSpawn()


    End Sub


    'If this timer starts it will then spawn in another 10 enemies, If at any point enemynum is no longer less than totalenemiesinwave then stop the timer
    Private Sub EnemySpawnTimer_Tick(sender As Object, e As EventArgs) Handles NextSpawnDelay.Tick

        WaveCon.SpawnNextGroup()

    End Sub

    Private Sub BuyTower_Click(sender As Object, e As EventArgs) Handles TowerBuy1.Click

        TowerCon.buyNewTower()

    End Sub

    Private Sub TowerIndicator_Click(sender As Object, e As EventArgs) Handles TowerIndicator.Click

        TowerCon.placeNewTower()

    End Sub


    'If the cancel Placing button is pressed then stop the player from placing a tower and hide the relevant UI
    Private Sub CancelPlacing_Click(sender As Object, e As EventArgs) Handles CancelPlacing.Click

        TowerCon.cancelPlacingTower()

    End Sub


    'Timer that runs every second to control fire rate of towers while shooting at a given target
    Private Sub TowerShooting_Tick(sender As Object, e As EventArgs) Handles TowerShooting.Tick

        TowerCon.startShooting()

    End Sub

    Public Sub PicTower_Click(sender As Object, e As EventArgs)

        TowerCon.enableTowerUI(sender)

    End Sub

    Private Sub SellButton_Click(sender As Object, e As EventArgs) Handles SellButton.Click

        TowerCon.sellTower()

    End Sub

    Private Sub UpgradeButton_Click(sender As Object, e As EventArgs) Handles DamageBuffButton.Click

        TowerCon.upgradeTower()

    End Sub


    'Runs if the player dies or completes the last wave
    'Stops the game from running by stopping the timers and displays the game over screen while starting the timer for the leaderboard to be shown 2.5 seconds later
    Public Sub Endgame()

        GameLogic.Stop()
        TowerShooting.Stop()

        LblGameOver.Show()
        LblGameOver.BringToFront()

        LeaderBoardDelay.Start()

    End Sub

    Private Sub LeaderBoardDelay_Tick(sender As Object, e As EventArgs) Handles LeaderBoardDelay.Tick

        'Hides Game over screen
        'Moves the leaderboard panel to cover the screen and stops the timer to prevent it from being shown once the next game has started

        LblGameOver.Hide()
        LeaderBoardPanel.Location = New Point(0, 0)
        LeaderBoardPanel.Show()
        LeaderBoardPanel.BringToFront()
        LeaderBoardDelay.Stop()


    End Sub


    'Runs if there is a key that is pressed down while using the newName text box
    Private Sub newName_KeyDown(sender As Object, e As KeyEventArgs) Handles EnterName.KeyDown


        If e.KeyCode = Keys.Enter And EnterName.Text.Length = 3 Then

            LeaderBoardCon.CreateleaderBoard()

        End If

    End Sub

    Private Sub RetryButton_Click(sender As Object, e As EventArgs) Handles RetryButton.Click

        'Resets player stats
        Lives = 10
        Coins = 70
        Wave = 1

        startTimers()

        LeaderBoardCon.hideLabels()
        LeaderBoardCon.resetStats()

        'Resets the game for enemies

        WaveCon.setadditionalEnemies(Nothing)
        WaveCon.InitializeEnemies()
        WaveCon.WaveSpawn()

        'Resets the game for towers

        TowerCon.resetTowers()

        'Hides Leaderboard UI and resets the text box and shows the tex box for next use

        EnterName.Show()
        LblEnterUsername.Show()
        LblPlayerNamesHeading.Hide()
        LblWavesReachedHeading.Hide()
        UpdateTableButton.Hide()
        LeaderBoardPanel.Hide()
        EnterName.Text = Nothing

    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click

        Close()

    End Sub


    Public Sub startTimers()

        GameLogic.Start()
        TowerShooting.Start()

    End Sub

    Public Sub LoadUI()

        StartButton.Hide()
        QuitButton.Hide()

        LblLives.Show()
        LblCoins.Show()
        LblWave.Show()

        TurretPanel.Show()
        LblTower1Cost.Show()
        TowerBuy1.Show()
        DamageBuffButton.Show()
        LblTowerCapacity.Show()
        TurretPanel.BackColor = Color.FromArgb(130, TurretPanel.BackColor)
        LblTower1Cost.BackColor = Color.FromArgb(130, TurretPanel.BackColor)
        LblTowerCapacity.BackColor = Color.FromArgb(130, TurretPanel.BackColor)

    End Sub

    Public Sub setLives(LivesLost As Integer)

        Lives -= LivesLost

    End Sub

    Public Function getLives()

        Return Lives

    End Function

    Public Sub setCoins(CoinsEarned As Integer)

        Coins += CoinsEarned

    End Sub

    Public Function getCoins()

        Return Coins

    End Function

    Public Sub setWave()

        Wave += 1

    End Sub

    Public Function getWave()

        Return Wave

    End Function

    Public Function getWaveCon()

        Return WaveCon

    End Function

    Public Sub setEnemiesKilledInWave()

        WaveCon.IncreaseEnemiesKilledInWave()

    End Sub

    Public Function getEnemies()

        Return WaveCon.getAllEnemies

    End Function

    Public Sub setTotalEnemiesKilled()

        LeaderBoardCon.IncreaseTotalEnemiesKilled()

    End Sub

    Public Sub setTotalCoinsEarned(CoinsEarned As Integer)

        LeaderBoardCon.IncreaseTotalCoinsEarned(CoinsEarned)

    End Sub

End Class




