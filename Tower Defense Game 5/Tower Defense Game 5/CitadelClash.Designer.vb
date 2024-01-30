<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GameLogic = New System.Windows.Forms.Timer(Me.components)
        Me.LblLives = New System.Windows.Forms.Label()
        Me.LblCoins = New System.Windows.Forms.Label()
        Me.LblWave = New System.Windows.Forms.Label()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.LblGameOver = New System.Windows.Forms.Label()
        Me.WaveCompletionUI = New System.Windows.Forms.Timer(Me.components)
        Me.LblWaveCompleted = New System.Windows.Forms.Label()
        Me.NextWaveButton = New System.Windows.Forms.Button()
        Me.TowerShooting = New System.Windows.Forms.Timer(Me.components)
        Me.LblTower1Cost = New System.Windows.Forms.Label()
        Me.LblTowerCapacity = New System.Windows.Forms.Label()
        Me.CancelPlacing = New System.Windows.Forms.Button()
        Me.TowerIndicator = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.TowerBuy1 = New System.Windows.Forms.PictureBox()
        Me.TurretPanel = New System.Windows.Forms.PictureBox()
        Me.PicBase = New System.Windows.Forms.PictureBox()
        Me.EnemyBase = New System.Windows.Forms.PictureBox()
        Me.Path1 = New System.Windows.Forms.PictureBox()
        Me.Path2 = New System.Windows.Forms.PictureBox()
        Me.Path3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.LeaderBoardPanel = New System.Windows.Forms.Panel()
        Me.LblWavesReachedHeading = New System.Windows.Forms.Label()
        Me.LblPlayerNamesHeading = New System.Windows.Forms.Label()
        Me.UpdateTableButton = New System.Windows.Forms.Button()
        Me.LblWaveReached5 = New System.Windows.Forms.Label()
        Me.LblName5 = New System.Windows.Forms.Label()
        Me.LblWaveReached4 = New System.Windows.Forms.Label()
        Me.LblName4 = New System.Windows.Forms.Label()
        Me.LblWaveReached3 = New System.Windows.Forms.Label()
        Me.LblName3 = New System.Windows.Forms.Label()
        Me.LblWaveReached2 = New System.Windows.Forms.Label()
        Me.LblName2 = New System.Windows.Forms.Label()
        Me.LblWaveReached1 = New System.Windows.Forms.Label()
        Me.LblName1 = New System.Windows.Forms.Label()
        Me.RetryButton = New System.Windows.Forms.Button()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblEnterUsername = New System.Windows.Forms.Label()
        Me.EnterName = New System.Windows.Forms.TextBox()
        Me.DamageBuffButton = New System.Windows.Forms.Button()
        Me.SellButton = New System.Windows.Forms.Button()
        Me.LeaderBoardDelay = New System.Windows.Forms.Timer(Me.components)
        Me.NextSpawnDelay = New System.Windows.Forms.Timer(Me.components)
        CType(Me.TowerIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TowerBuy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurretPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Path1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Path2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Path3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LeaderBoardPanel.SuspendLayout()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GameLogic
        '
        Me.GameLogic.Interval = 1
        '
        'LblLives
        '
        Me.LblLives.BackColor = System.Drawing.Color.SaddleBrown
        Me.LblLives.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLives.Location = New System.Drawing.Point(8, 23)
        Me.LblLives.Name = "LblLives"
        Me.LblLives.Size = New System.Drawing.Size(190, 23)
        Me.LblLives.TabIndex = 10
        Me.LblLives.Text = "LIVES 0"
        Me.LblLives.Visible = False
        '
        'LblCoins
        '
        Me.LblCoins.BackColor = System.Drawing.Color.SaddleBrown
        Me.LblCoins.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCoins.Location = New System.Drawing.Point(96, 23)
        Me.LblCoins.Name = "LblCoins"
        Me.LblCoins.Size = New System.Drawing.Size(102, 23)
        Me.LblCoins.TabIndex = 11
        Me.LblCoins.Text = "COINS 0"
        Me.LblCoins.Visible = False
        '
        'LblWave
        '
        Me.LblWave.BackColor = System.Drawing.Color.SaddleBrown
        Me.LblWave.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWave.Location = New System.Drawing.Point(8, 59)
        Me.LblWave.Name = "LblWave"
        Me.LblWave.Size = New System.Drawing.Size(91, 25)
        Me.LblWave.TabIndex = 12
        Me.LblWave.Text = "WAVE 0"
        Me.LblWave.Visible = False
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.SaddleBrown
        Me.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartButton.Font = New System.Drawing.Font("Agency FB", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButton.Location = New System.Drawing.Point(334, 38)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(200, 112)
        Me.StartButton.TabIndex = 14
        Me.StartButton.Text = "START"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'QuitButton
        '
        Me.QuitButton.BackColor = System.Drawing.Color.SaddleBrown
        Me.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QuitButton.Font = New System.Drawing.Font("Agency FB", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitButton.Location = New System.Drawing.Point(334, 236)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(200, 112)
        Me.QuitButton.TabIndex = 15
        Me.QuitButton.Text = "QUIT"
        Me.QuitButton.UseVisualStyleBackColor = False
        '
        'LblGameOver
        '
        Me.LblGameOver.AutoSize = True
        Me.LblGameOver.BackColor = System.Drawing.Color.SaddleBrown
        Me.LblGameOver.Font = New System.Drawing.Font("Agency FB", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGameOver.Location = New System.Drawing.Point(256, 87)
        Me.LblGameOver.Name = "LblGameOver"
        Me.LblGameOver.Size = New System.Drawing.Size(389, 115)
        Me.LblGameOver.TabIndex = 17
        Me.LblGameOver.Text = "GAMEOVER"
        Me.LblGameOver.Visible = False
        '
        'WaveCompletionUI
        '
        Me.WaveCompletionUI.Interval = 2000
        '
        'LblWaveCompleted
        '
        Me.LblWaveCompleted.AutoSize = True
        Me.LblWaveCompleted.BackColor = System.Drawing.Color.SaddleBrown
        Me.LblWaveCompleted.Font = New System.Drawing.Font("Agency FB", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWaveCompleted.Location = New System.Drawing.Point(151, 103)
        Me.LblWaveCompleted.Name = "LblWaveCompleted"
        Me.LblWaveCompleted.Size = New System.Drawing.Size(599, 115)
        Me.LblWaveCompleted.TabIndex = 18
        Me.LblWaveCompleted.Text = "WAVECOMPLETED"
        Me.LblWaveCompleted.Visible = False
        '
        'NextWaveButton
        '
        Me.NextWaveButton.BackColor = System.Drawing.Color.SaddleBrown
        Me.NextWaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NextWaveButton.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextWaveButton.Location = New System.Drawing.Point(16, 192)
        Me.NextWaveButton.Name = "NextWaveButton"
        Me.NextWaveButton.Size = New System.Drawing.Size(95, 32)
        Me.NextWaveButton.TabIndex = 21
        Me.NextWaveButton.Text = "NEXTWAVE"
        Me.NextWaveButton.UseVisualStyleBackColor = False
        Me.NextWaveButton.Visible = False
        '
        'TowerShooting
        '
        Me.TowerShooting.Interval = 1000
        '
        'LblTower1Cost
        '
        Me.LblTower1Cost.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblTower1Cost.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTower1Cost.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblTower1Cost.Location = New System.Drawing.Point(567, 336)
        Me.LblTower1Cost.Name = "LblTower1Cost"
        Me.LblTower1Cost.Size = New System.Drawing.Size(53, 17)
        Me.LblTower1Cost.TabIndex = 37
        Me.LblTower1Cost.Text = " 30 COINS"
        Me.LblTower1Cost.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.LblTower1Cost.Visible = False
        '
        'LblTowerCapacity
        '
        Me.LblTowerCapacity.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblTowerCapacity.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTowerCapacity.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblTowerCapacity.Location = New System.Drawing.Point(498, 336)
        Me.LblTowerCapacity.Name = "LblTowerCapacity"
        Me.LblTowerCapacity.Size = New System.Drawing.Size(53, 57)
        Me.LblTowerCapacity.TabIndex = 44
        Me.LblTowerCapacity.Text = "Tower Capacity 0/25" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LblTowerCapacity.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LblTowerCapacity.Visible = False
        '
        'CancelPlacing
        '
        Me.CancelPlacing.BackColor = System.Drawing.Color.SaddleBrown
        Me.CancelPlacing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelPlacing.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelPlacing.ForeColor = System.Drawing.Color.Black
        Me.CancelPlacing.Location = New System.Drawing.Point(781, 297)
        Me.CancelPlacing.Name = "CancelPlacing"
        Me.CancelPlacing.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CancelPlacing.Size = New System.Drawing.Size(72, 30)
        Me.CancelPlacing.TabIndex = 45
        Me.CancelPlacing.Text = "CANCEL"
        Me.CancelPlacing.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CancelPlacing.UseVisualStyleBackColor = False
        Me.CancelPlacing.Visible = False
        '
        'TowerIndicator
        '
        Me.TowerIndicator.BackColor = System.Drawing.Color.CadetBlue
        Me.TowerIndicator.Location = New System.Drawing.Point(816, 259)
        Me.TowerIndicator.Name = "TowerIndicator"
        Me.TowerIndicator.Size = New System.Drawing.Size(37, 32)
        Me.TowerIndicator.TabIndex = 35
        Me.TowerIndicator.TabStop = False
        Me.TowerIndicator.Visible = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox8.Location = New System.Drawing.Point(0, 401)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(880, 10)
        Me.PictureBox8.TabIndex = 27
        Me.PictureBox8.TabStop = False
        '
        'TowerBuy1
        '
        Me.TowerBuy1.BackColor = System.Drawing.Color.CadetBlue
        Me.TowerBuy1.Location = New System.Drawing.Point(574, 353)
        Me.TowerBuy1.Name = "TowerBuy1"
        Me.TowerBuy1.Size = New System.Drawing.Size(41, 36)
        Me.TowerBuy1.TabIndex = 20
        Me.TowerBuy1.TabStop = False
        Me.TowerBuy1.Visible = False
        '
        'TurretPanel
        '
        Me.TurretPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TurretPanel.Location = New System.Drawing.Point(489, 333)
        Me.TurretPanel.Name = "TurretPanel"
        Me.TurretPanel.Size = New System.Drawing.Size(364, 62)
        Me.TurretPanel.TabIndex = 19
        Me.TurretPanel.TabStop = False
        Me.TurretPanel.Visible = False
        '
        'PicBase
        '
        Me.PicBase.BackColor = System.Drawing.Color.Cyan
        Me.PicBase.Location = New System.Drawing.Point(868, 84)
        Me.PicBase.Name = "PicBase"
        Me.PicBase.Size = New System.Drawing.Size(24, 104)
        Me.PicBase.TabIndex = 9
        Me.PicBase.TabStop = False
        '
        'EnemyBase
        '
        Me.EnemyBase.BackColor = System.Drawing.Color.Red
        Me.EnemyBase.Location = New System.Drawing.Point(-3, 236)
        Me.EnemyBase.Name = "EnemyBase"
        Me.EnemyBase.Size = New System.Drawing.Size(18, 104)
        Me.EnemyBase.TabIndex = 5
        Me.EnemyBase.TabStop = False
        '
        'Path1
        '
        Me.Path1.BackColor = System.Drawing.Color.SandyBrown
        Me.Path1.Location = New System.Drawing.Point(-3, 236)
        Me.Path1.Name = "Path1"
        Me.Path1.Size = New System.Drawing.Size(476, 104)
        Me.Path1.TabIndex = 0
        Me.Path1.TabStop = False
        Me.Path1.Tag = "Invalid Tower Spawn"
        '
        'Path2
        '
        Me.Path2.BackColor = System.Drawing.Color.SandyBrown
        Me.Path2.Location = New System.Drawing.Point(369, 84)
        Me.Path2.Name = "Path2"
        Me.Path2.Size = New System.Drawing.Size(104, 256)
        Me.Path2.TabIndex = 7
        Me.Path2.TabStop = False
        '
        'Path3
        '
        Me.Path3.BackColor = System.Drawing.Color.SandyBrown
        Me.Path3.Location = New System.Drawing.Point(392, 84)
        Me.Path3.Name = "Path3"
        Me.Path3.Size = New System.Drawing.Size(500, 104)
        Me.Path3.TabIndex = 8
        Me.Path3.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(-3, -2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(217, 102)
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(479, 324)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(404, 81)
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox4.Location = New System.Drawing.Point(870, 10)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(10, 391)
        Me.PictureBox4.TabIndex = 24
        Me.PictureBox4.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox6.Location = New System.Drawing.Point(10, 0)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(870, 10)
        Me.PictureBox6.TabIndex = 25
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox7.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(10, 401)
        Me.PictureBox7.TabIndex = 26
        Me.PictureBox7.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Location = New System.Drawing.Point(-6, 339)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(479, 10)
        Me.PictureBox9.TabIndex = 38
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Location = New System.Drawing.Point(-6, 230)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(379, 10)
        Me.PictureBox10.TabIndex = 39
        Me.PictureBox10.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.Location = New System.Drawing.Point(473, 184)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(10, 165)
        Me.PictureBox12.TabIndex = 40
        Me.PictureBox12.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.Location = New System.Drawing.Point(479, 188)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(408, 10)
        Me.PictureBox13.TabIndex = 41
        Me.PictureBox13.TabStop = False
        '
        'PictureBox14
        '
        Me.PictureBox14.Location = New System.Drawing.Point(369, 74)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(523, 10)
        Me.PictureBox14.TabIndex = 42
        Me.PictureBox14.TabStop = False
        '
        'PictureBox15
        '
        Me.PictureBox15.Location = New System.Drawing.Point(358, 74)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(10, 171)
        Me.PictureBox15.TabIndex = 43
        Me.PictureBox15.TabStop = False
        '
        'LeaderBoardPanel
        '
        Me.LeaderBoardPanel.BackColor = System.Drawing.Color.DarkKhaki
        Me.LeaderBoardPanel.Controls.Add(Me.LblWavesReachedHeading)
        Me.LeaderBoardPanel.Controls.Add(Me.LblPlayerNamesHeading)
        Me.LeaderBoardPanel.Controls.Add(Me.UpdateTableButton)
        Me.LeaderBoardPanel.Controls.Add(Me.LblWaveReached5)
        Me.LeaderBoardPanel.Controls.Add(Me.LblName5)
        Me.LeaderBoardPanel.Controls.Add(Me.LblWaveReached4)
        Me.LeaderBoardPanel.Controls.Add(Me.LblName4)
        Me.LeaderBoardPanel.Controls.Add(Me.LblWaveReached3)
        Me.LeaderBoardPanel.Controls.Add(Me.LblName3)
        Me.LeaderBoardPanel.Controls.Add(Me.LblWaveReached2)
        Me.LeaderBoardPanel.Controls.Add(Me.LblName2)
        Me.LeaderBoardPanel.Controls.Add(Me.LblWaveReached1)
        Me.LeaderBoardPanel.Controls.Add(Me.LblName1)
        Me.LeaderBoardPanel.Controls.Add(Me.RetryButton)
        Me.LeaderBoardPanel.Controls.Add(Me.PictureBox16)
        Me.LeaderBoardPanel.Controls.Add(Me.PictureBox11)
        Me.LeaderBoardPanel.Controls.Add(Me.PictureBox5)
        Me.LeaderBoardPanel.Controls.Add(Me.PictureBox1)
        Me.LeaderBoardPanel.Controls.Add(Me.LblEnterUsername)
        Me.LeaderBoardPanel.Controls.Add(Me.EnterName)
        Me.LeaderBoardPanel.Location = New System.Drawing.Point(868, 0)
        Me.LeaderBoardPanel.Name = "LeaderBoardPanel"
        Me.LeaderBoardPanel.Size = New System.Drawing.Size(887, 414)
        Me.LeaderBoardPanel.TabIndex = 46
        Me.LeaderBoardPanel.Visible = False
        '
        'LblWavesReachedHeading
        '
        Me.LblWavesReachedHeading.AutoSize = True
        Me.LblWavesReachedHeading.Font = New System.Drawing.Font("Agency FB", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWavesReachedHeading.Location = New System.Drawing.Point(489, 64)
        Me.LblWavesReachedHeading.Name = "LblWavesReachedHeading"
        Me.LblWavesReachedHeading.Size = New System.Drawing.Size(156, 35)
        Me.LblWavesReachedHeading.TabIndex = 34
        Me.LblWavesReachedHeading.Text = "WAVES REACHED"
        Me.LblWavesReachedHeading.Visible = False
        '
        'LblPlayerNamesHeading
        '
        Me.LblPlayerNamesHeading.AutoSize = True
        Me.LblPlayerNamesHeading.Font = New System.Drawing.Font("Agency FB", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPlayerNamesHeading.Location = New System.Drawing.Point(237, 64)
        Me.LblPlayerNamesHeading.Name = "LblPlayerNamesHeading"
        Me.LblPlayerNamesHeading.Size = New System.Drawing.Size(131, 35)
        Me.LblPlayerNamesHeading.TabIndex = 33
        Me.LblPlayerNamesHeading.Text = "PLAYER NAME"
        Me.LblPlayerNamesHeading.Visible = False
        '
        'UpdateTableButton
        '
        Me.UpdateTableButton.BackColor = System.Drawing.Color.SaddleBrown
        Me.UpdateTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateTableButton.Font = New System.Drawing.Font("Agency FB", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateTableButton.Location = New System.Drawing.Point(703, 345)
        Me.UpdateTableButton.Name = "UpdateTableButton"
        Me.UpdateTableButton.Size = New System.Drawing.Size(154, 39)
        Me.UpdateTableButton.TabIndex = 32
        Me.UpdateTableButton.Text = "UPDATE TABLE"
        Me.UpdateTableButton.UseVisualStyleBackColor = False
        Me.UpdateTableButton.Visible = False
        '
        'LblWaveReached5
        '
        Me.LblWaveReached5.AutoSize = True
        Me.LblWaveReached5.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWaveReached5.Location = New System.Drawing.Point(541, 265)
        Me.LblWaveReached5.Name = "LblWaveReached5"
        Me.LblWaveReached5.Size = New System.Drawing.Size(109, 25)
        Me.LblWaveReached5.TabIndex = 31
        Me.LblWaveReached5.Text = "WaveReached5"
        Me.LblWaveReached5.Visible = False
        '
        'LblName5
        '
        Me.LblName5.AutoSize = True
        Me.LblName5.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName5.Location = New System.Drawing.Point(275, 265)
        Me.LblName5.Name = "LblName5"
        Me.LblName5.Size = New System.Drawing.Size(55, 25)
        Me.LblName5.TabIndex = 30
        Me.LblName5.Text = "Name5"
        Me.LblName5.Visible = False
        '
        'LblWaveReached4
        '
        Me.LblWaveReached4.AutoSize = True
        Me.LblWaveReached4.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWaveReached4.Location = New System.Drawing.Point(541, 230)
        Me.LblWaveReached4.Name = "LblWaveReached4"
        Me.LblWaveReached4.Size = New System.Drawing.Size(110, 25)
        Me.LblWaveReached4.TabIndex = 29
        Me.LblWaveReached4.Text = "WaveReached4"
        Me.LblWaveReached4.Visible = False
        '
        'LblName4
        '
        Me.LblName4.AutoSize = True
        Me.LblName4.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName4.Location = New System.Drawing.Point(275, 230)
        Me.LblName4.Name = "LblName4"
        Me.LblName4.Size = New System.Drawing.Size(56, 25)
        Me.LblName4.TabIndex = 28
        Me.LblName4.Text = "Name4"
        Me.LblName4.Visible = False
        '
        'LblWaveReached3
        '
        Me.LblWaveReached3.AutoSize = True
        Me.LblWaveReached3.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWaveReached3.Location = New System.Drawing.Point(541, 195)
        Me.LblWaveReached3.Name = "LblWaveReached3"
        Me.LblWaveReached3.Size = New System.Drawing.Size(109, 25)
        Me.LblWaveReached3.TabIndex = 27
        Me.LblWaveReached3.Text = "WaveReached3"
        Me.LblWaveReached3.Visible = False
        '
        'LblName3
        '
        Me.LblName3.AutoSize = True
        Me.LblName3.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName3.Location = New System.Drawing.Point(275, 195)
        Me.LblName3.Name = "LblName3"
        Me.LblName3.Size = New System.Drawing.Size(55, 25)
        Me.LblName3.TabIndex = 26
        Me.LblName3.Text = "Name3"
        Me.LblName3.Visible = False
        '
        'LblWaveReached2
        '
        Me.LblWaveReached2.AutoSize = True
        Me.LblWaveReached2.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWaveReached2.Location = New System.Drawing.Point(541, 160)
        Me.LblWaveReached2.Name = "LblWaveReached2"
        Me.LblWaveReached2.Size = New System.Drawing.Size(109, 25)
        Me.LblWaveReached2.TabIndex = 25
        Me.LblWaveReached2.Text = "WaveReached2"
        Me.LblWaveReached2.Visible = False
        '
        'LblName2
        '
        Me.LblName2.AutoSize = True
        Me.LblName2.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName2.Location = New System.Drawing.Point(275, 160)
        Me.LblName2.Name = "LblName2"
        Me.LblName2.Size = New System.Drawing.Size(55, 25)
        Me.LblName2.TabIndex = 24
        Me.LblName2.Text = "Name2"
        Me.LblName2.Visible = False
        '
        'LblWaveReached1
        '
        Me.LblWaveReached1.AutoSize = True
        Me.LblWaveReached1.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWaveReached1.Location = New System.Drawing.Point(541, 125)
        Me.LblWaveReached1.Name = "LblWaveReached1"
        Me.LblWaveReached1.Size = New System.Drawing.Size(104, 25)
        Me.LblWaveReached1.TabIndex = 23
        Me.LblWaveReached1.Text = "WaveReached1"
        Me.LblWaveReached1.Visible = False
        '
        'LblName1
        '
        Me.LblName1.AutoSize = True
        Me.LblName1.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName1.Location = New System.Drawing.Point(275, 125)
        Me.LblName1.Name = "LblName1"
        Me.LblName1.Size = New System.Drawing.Size(50, 25)
        Me.LblName1.TabIndex = 22
        Me.LblName1.Text = "Name1"
        Me.LblName1.Visible = False
        '
        'RetryButton
        '
        Me.RetryButton.BackColor = System.Drawing.Color.SaddleBrown
        Me.RetryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RetryButton.Font = New System.Drawing.Font("Agency FB", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetryButton.Location = New System.Drawing.Point(369, 339)
        Me.RetryButton.Name = "RetryButton"
        Me.RetryButton.Size = New System.Drawing.Size(162, 45)
        Me.RetryButton.TabIndex = 21
        Me.RetryButton.Text = "RETRY"
        Me.RetryButton.UseVisualStyleBackColor = False
        '
        'PictureBox16
        '
        Me.PictureBox16.BackColor = System.Drawing.Color.SaddleBrown
        Me.PictureBox16.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox16.Location = New System.Drawing.Point(863, 24)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(24, 366)
        Me.PictureBox16.TabIndex = 20
        Me.PictureBox16.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.SaddleBrown
        Me.PictureBox11.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox11.Location = New System.Drawing.Point(24, 0)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(863, 24)
        Me.PictureBox11.TabIndex = 19
        Me.PictureBox11.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.SaddleBrown
        Me.PictureBox5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox5.Location = New System.Drawing.Point(24, 390)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(863, 24)
        Me.PictureBox5.TabIndex = 18
        Me.PictureBox5.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.SaddleBrown
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 414)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'LblEnterUsername
        '
        Me.LblEnterUsername.AutoSize = True
        Me.LblEnterUsername.Font = New System.Drawing.Font("Agency FB", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEnterUsername.Location = New System.Drawing.Point(273, 27)
        Me.LblEnterUsername.Name = "LblEnterUsername"
        Me.LblEnterUsername.Size = New System.Drawing.Size(354, 70)
        Me.LblEnterUsername.TabIndex = 1
        Me.LblEnterUsername.Text = "Enter Username (3 Characters Long)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PRESS ENTER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LblEnterUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'newName
        '
        Me.EnterName.Font = New System.Drawing.Font("Agency FB", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnterName.Location = New System.Drawing.Point(362, 160)
        Me.EnterName.Name = "newName"
        Me.EnterName.Size = New System.Drawing.Size(178, 42)
        Me.EnterName.TabIndex = 0
        '
        'DamageBuffButton
        '
        Me.DamageBuffButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DamageBuffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DamageBuffButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DamageBuffButton.Location = New System.Drawing.Point(-1000, -100)
        Me.DamageBuffButton.Name = "DamageBuffButton"
        Me.DamageBuffButton.Size = New System.Drawing.Size(82, 23)
        Me.DamageBuffButton.TabIndex = 57
        Me.DamageBuffButton.Text = "Damage +1"
        Me.DamageBuffButton.UseVisualStyleBackColor = False
        Me.DamageBuffButton.Visible = False
        '
        'SellButton
        '
        Me.SellButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SellButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SellButton.Location = New System.Drawing.Point(-1000, -100)
        Me.SellButton.Name = "SellButton"
        Me.SellButton.Size = New System.Drawing.Size(82, 23)
        Me.SellButton.TabIndex = 60
        Me.SellButton.Text = "SELL"
        Me.SellButton.UseVisualStyleBackColor = False
        '
        'LeaderBoardDelay
        '
        Me.LeaderBoardDelay.Interval = 2500
        '
        'NextSpawnDelay
        '
        Me.NextSpawnDelay.Interval = 2000
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(880, 411)
        Me.Controls.Add(Me.SellButton)
        Me.Controls.Add(Me.DamageBuffButton)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.LeaderBoardPanel)
        Me.Controls.Add(Me.NextWaveButton)
        Me.Controls.Add(Me.LblCoins)
        Me.Controls.Add(Me.TowerIndicator)
        Me.Controls.Add(Me.CancelPlacing)
        Me.Controls.Add(Me.TowerBuy1)
        Me.Controls.Add(Me.LblTowerCapacity)
        Me.Controls.Add(Me.LblTower1Cost)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.LblWaveCompleted)
        Me.Controls.Add(Me.LblGameOver)
        Me.Controls.Add(Me.TurretPanel)
        Me.Controls.Add(Me.LblWave)
        Me.Controls.Add(Me.LblLives)
        Me.Controls.Add(Me.PicBase)
        Me.Controls.Add(Me.EnemyBase)
        Me.Controls.Add(Me.Path1)
        Me.Controls.Add(Me.Path2)
        Me.Controls.Add(Me.Path3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.PictureBox15)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox3)
        Me.Name = "Game"
        Me.Text = "Citadel Clash"
        CType(Me.TowerIndicator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TowerBuy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurretPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Path1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Path2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Path3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LeaderBoardPanel.ResumeLayout(False)
        Me.LeaderBoardPanel.PerformLayout()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GameLogic As Timer
    Friend WithEvents Path1 As PictureBox
    Friend WithEvents EnemyBase As PictureBox
    Friend WithEvents Path2 As PictureBox
    Friend WithEvents Path3 As PictureBox
    Friend WithEvents PicBase As PictureBox
    Friend WithEvents LblLives As Label
    Friend WithEvents LblCoins As Label
    Friend WithEvents LblWave As Label
    Friend WithEvents StartButton As Button
    Friend WithEvents QuitButton As Button
    Friend WithEvents LblGameOver As Label
    Friend WithEvents WaveCompletionUI As Timer
    Friend WithEvents LblWaveCompleted As Label
    Friend WithEvents TurretPanel As PictureBox
    Friend WithEvents TowerBuy1 As PictureBox
    Friend WithEvents NextWaveButton As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents TowerIndicator As PictureBox
    Friend WithEvents TowerShooting As Timer
    Friend WithEvents LblTower1Cost As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents LblTowerCapacity As Label
    Friend WithEvents CancelPlacing As Button
    Friend WithEvents LeaderBoardPanel As Panel
    Friend WithEvents EnterName As TextBox
    Friend WithEvents LblEnterUsername As Label
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RetryButton As Button
    Friend WithEvents LblWaveReached5 As Label
    Friend WithEvents LblName5 As Label
    Friend WithEvents LblWaveReached4 As Label
    Friend WithEvents LblName4 As Label
    Friend WithEvents LblWaveReached3 As Label
    Friend WithEvents LblName3 As Label
    Friend WithEvents LblWaveReached2 As Label
    Friend WithEvents LblName2 As Label
    Friend WithEvents LblWaveReached1 As Label
    Friend WithEvents LblName1 As Label
    Friend WithEvents UpdateTableButton As Button
    Friend WithEvents LblWavesReachedHeading As Label
    Friend WithEvents LblPlayerNamesHeading As Label
    Friend WithEvents DamageBuffButton As Button
    Friend WithEvents SellButton As Button
    Friend WithEvents LeaderBoardDelay As Timer
    Friend WithEvents NextSpawnDelay As Timer
End Class
