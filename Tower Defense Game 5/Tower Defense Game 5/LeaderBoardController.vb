Public Class LeaderBoardController

    Private PlayerNames() As String = {"QSD", "BMV", "AJS", "123", "HJT", Nothing}
    Private WavesReached() As Integer = {"13", "10", "8", "12", "5", Nothing}
    Private NameLabels(4) As Label
    Private WaveReachedLabels(4) As Label
    Private UserName As String
    Private TotalEnemiesKilled As Integer
    Private TotalCoinsEarned As Integer

    Public Sub InitializeLabels()

        With Game
            NameLabels(0) = .LblName1
            NameLabels(1) = .LblName2
            NameLabels(2) = .LblName3
            NameLabels(3) = .LblName4
            NameLabels(4) = .LblName5

            WaveReachedLabels(0) = .LblWaveReached1
            WaveReachedLabels(1) = .LblWaveReached2
            WaveReachedLabels(2) = .LblWaveReached3
            WaveReachedLabels(3) = .LblWaveReached4
            WaveReachedLabels(4) = .LblWaveReached5
        End With

        For counter = 0 To 4

            NameLabels(counter).Text = PlayerNames(counter)
            WaveReachedLabels(counter).Text = WavesReached(counter)

        Next

    End Sub

    Public Sub CreateleaderBoard()

        'If the key was enter and the name entered is valid then it hides the previous leaderbaord UI
        'Declares the new name and waves reached to be held in the 6th position of the arrays for playernames and waves reached

        Game.EnterName.Hide()
        Game.LblEnterUsername.Hide()

        UserName = Game.EnterName.Text

        PlayerNames(5) = UserName
        WavesReached(5) = Game.getWave

        For counter = 1 To 5

            Dim tempName = PlayerNames(counter)
            Dim tempWave = WavesReached(counter)
            Dim index = counter

            While index > 0 AndAlso tempWave > WavesReached(index - 1)

                WavesReached(index) = WavesReached(index - 1)
                PlayerNames(index) = PlayerNames(index - 1)

                index = index - 1
            End While

            WavesReached(index) = tempWave
            PlayerNames(index) = tempName

        Next

        'Sets each label to their associated playerName and waves reached for the first 5 positions and shows the leaderboard

        For counter = 0 To 4

            NameLabels(counter).Text = PlayerNames(counter)
            WaveReachedLabels(counter).Text = WavesReached(counter)

            NameLabels(counter).Show()
            WaveReachedLabels(counter).Show()

        Next
        'Displays leaderbaord UI

        Game.UpdateTableButton.Show()
        Game.LblPlayerNamesHeading.Show()
        Game.LblWavesReachedHeading.Show()

    End Sub

    Public Sub resetStats()

        TotalEnemiesKilled = 0
        TotalCoinsEarned = 0

    End Sub

    Public Sub hideLabels()

        For counter = 0 To 4
            NameLabels(counter).Hide()
            WaveReachedLabels(counter).Hide()
        Next

    End Sub

    Public Sub IncreaseTotalEnemiesKilled()

        TotalEnemiesKilled += 1

    End Sub

    Public Sub IncreaseTotalCoinsEarned(CoinsEarned As Integer)

        TotalCoinsEarned += CoinsEarned

    End Sub

End Class
