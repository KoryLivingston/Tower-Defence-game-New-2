Public Class WaveController

    'Arrays of Enemy and PictureBox for every enemy
    'Totalenemiesinwave will be assigned to the value equal to the number of enemies created for that wave
    'EnemiesKilledInWave will be incremented from 0 for every enemy that has been killed
    'These variables are used to check if a wave has ended

    'additionalEnemies is increased by 2 after a wave has ended, used to increase the amount of enemies spawned for the next wave
    'Enemynum is used to hold the index of the next enemy to be spawned as well is to check if every enemy has been spawned
    'LastEnemy holds the last enemy object to be spawned, used to check if this enemy has died and to then spawn the next group of enemies for that wave 2 seconds later if possible

    Private Enemies() As Enemy
    Private PicEnemies() As PictureBox
    Private TotalEnemiesInWave As Integer
    Private EnemiesKilledInWave As Integer
    Private WaveEnded As Boolean
    Private additionalEnemies As Integer
    Private EnemyNum As Integer
    Private LastEnemy As Enemy


    Public Sub CheckWaveEnded()


        If WaveEnded = False And EnemiesKilledInWave = TotalEnemiesInWave Then

            With Game
                .LblWaveCompleted.Show()
                .WaveCompletionUI.Start()
                WaveEnded = True
            End With

        End If

    End Sub

    Public Sub EnemyLogic()

        For counter = 0 To TotalEnemiesInWave - 1

            Enemies(counter).MoveEnemy()
            Enemies(counter).EnemyReachedBase()

        Next

    End Sub

    Public Sub CheckToSpawnMore()

        If LastEnemy IsNot Nothing AndAlso LastEnemy.getIsDead = True Then
            LastEnemy = Nothing
            Game.NextSpawnDelay.Start()
        End If

    End Sub

    'Used to create each enemy with their associated picturebox attributes and enemy attributes of that wave

    Public Sub CreateEnemies(NumberOfEnemies As Integer, EnemySizeX As Integer, EnemySizeY As Integer, EnemyColor As Color, movementSpeed As Integer, Health As Integer, CoinsDropped As Integer)

        'Redeclares the arrays to hold the amount of enemies needed for that wave

        ReDim Enemies(NumberOfEnemies - 1)
        ReDim PicEnemies(NumberOfEnemies - 1)

        'For every enemy a picturebox is created with its associated attributes, and then an enemy object is instantiated to hold this new enemy with its picturebox
        'TotalEnemeisInWave is increased to be used in conditions throught the pogram

        For counter = 0 To NumberOfEnemies - 1

            PicEnemies(counter) = New PictureBox With {
    .Location = New Point(-1000, -100),
    .Size = New Size(EnemySizeX, EnemySizeY),
    .BackColor = EnemyColor
            }

            Game.Controls.Add(PicEnemies(counter))
            PicEnemies(counter).BringToFront()

            Console.WriteLine("Picturebox created")

            Enemies(counter) = New Enemy(PicEnemies(counter), movementSpeed, Health, CoinsDropped)
            TotalEnemiesInWave += 1

            Console.WriteLine("Enemy Object Created " & TotalEnemiesInWave)


        Next

    End Sub

    Public Sub StartNextWave()


        With Game
            .setWave()
            If .getWave = 8 Or .getWave = 16 Or .getWave = 26 Or .getWave = 36 Or .getWave = 46 Then
                additionalEnemies = 0
            End If
        End With
        additionalEnemies += 2

    End Sub

    'If else if statements checks which wave it currently is and to create its associated enemies
    'Each time the game is initialized to reset the arrays and logic variables used during each wave

    Public Sub WaveSpawn()

        With Game

            If .getWave = 1 Then

                CreateEnemies(3, 30, 30, Color.Green, 1, 4, 5)


                For counter = 0 To TotalEnemiesInWave - 1
                    Enemies(counter).getEnemyGraphic.Location = New Point(-650 - (counter * 50), 275)
                Next

            ElseIf .getWave >= 2 And .getWave <= 7 Then

                InitializeEnemies()
                CreateEnemies(3 + additionalEnemies, 30, 30, Color.Green, 1, 4, 5)

            ElseIf .getWave >= 8 And .getWave <= 15 Then

                InitializeEnemies()
                CreateEnemies(10 + additionalEnemies, 30, 30, Color.DarkRed, 2, 6, 6)

            ElseIf .getWave >= 16 And .getWave <= 25 Then

                InitializeEnemies()
                CreateEnemies(15 + additionalEnemies, 30, 30, Color.Gray, 3, 8, 7)

            End If

            'If the wave is no longer wave 1 then for the first ten enemies adjust their positions to be closer to the enemybase so that they get into the game faster
            'At any point if all the enemies have already been brought into the game, exit sub


            For counter = 0 To 9

                If .getWave <> 1 AndAlso EnemyNum < TotalEnemiesInWave Then
                    Enemies(EnemyNum).getEnemyGraphic.Location = New Point(.EnemyBase.Location.X - 100 - (counter * 50), 278)
                    EnemyNum += 1
                Else
                    Exit Sub
                End If

            Next
        End With

        'Reaches this line if there are more than 10 enemies in the wave
        'Sets the lastenemy to the last enemy to be brought into the game to be used in the condition to bring the next group of enemies in

        LastEnemy = Enemies(EnemyNum - 1)

    End Sub

    'Used to reset the game to a state to allow the next wave to use the games logic

    Public Sub SpawnNextGroup()


        For counter = 0 To 9
            If EnemyNum < TotalEnemiesInWave Then
                Enemies(EnemyNum).getEnemyGraphic.Location = New Point(Game.EnemyBase.Location.X - 100 - (counter * 50), 278)
                EnemyNum += 1
            Else
                Game.NextSpawnDelay.Stop()
            End If
        Next


        'Reaches this line if there are more than 20 enemies in the wave
        'LastEnemy is assigned to the last enemy to be brought in
        'This allows the timer to be recalled for the next 10 enemies to be brought into the game once the last enemy has died


        LastEnemy = Enemies(EnemyNum - 1)
        Game.NextSpawnDelay.Stop()

    End Sub

    Public Sub InitializeEnemies()

        'Remoevs pictureboxes of previous wave

        For counter = 0 To TotalEnemiesInWave - 1
            Game.Controls.Remove(Enemies(counter).getEnemyGraphic)
            Enemies(counter).getEnemyGraphic.Dispose()
        Next

        'Sets arrays to nothing, logic variables to 0 or false and stops the nextspawndelay timer

        Enemies = Nothing
        PicEnemies = Nothing
        TotalEnemiesInWave = 0
        EnemiesKilledInWave = 0
        WaveEnded = False
        EnemyNum = 0
        LastEnemy = Nothing
        Game.NextSpawnDelay.Stop()

    End Sub

    Public Function getAllEnemies()

        Return Enemies

    End Function


    Public Sub setadditionalEnemies(Value)

        additionalEnemies += Value

        If Value = Nothing Then

            additionalEnemies = Value

        End If


    End Sub

    Public Sub IncreaseEnemiesKilledInWave()

        EnemiesKilledInWave += 1

    End Sub


End Class
