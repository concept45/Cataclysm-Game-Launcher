<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Launcher
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.WarningLabel = New System.Windows.Forms.Label()
        Me.WarningLabel2 = New System.Windows.Forms.Label()
        Me.UpdateLabel = New System.Windows.Forms.Label()
        Me.Autor = New System.Windows.Forms.Label()
        Me.LauncherVersion = New System.Windows.Forms.Label()
        Me.ServerNewsHeader = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ServerNews = New System.Windows.Forms.Label()
        Me.LauncherNews = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuBar = New System.Windows.Forms.PictureBox()
        Me.PlayDisabled = New System.Windows.Forms.PictureBox()
        Me.DownloadBar = New System.Windows.Forms.PictureBox()
        Me.PatcherBackground = New System.Windows.Forms.PictureBox()
        Me.MinimizeButton = New System.Windows.Forms.PictureBox()
        Me.CloseButton = New System.Windows.Forms.PictureBox()
        Me.PlayButton = New System.Windows.Forms.PictureBox()
        Me.NewsLayer = New System.Windows.Forms.PictureBox()
        Me.Layer = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayDisabled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DownloadBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatcherBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinimizeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewsLayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Layer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WarningLabel
        '
        Me.WarningLabel.AutoSize = True
        Me.WarningLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WarningLabel.ForeColor = System.Drawing.Color.DarkOrange
        Me.WarningLabel.Location = New System.Drawing.Point(243, 567)
        Me.WarningLabel.Name = "WarningLabel"
        Me.WarningLabel.Size = New System.Drawing.Size(98, 16)
        Me.WarningLabel.TabIndex = 5
        Me.WarningLabel.Text = "WarningLabel"
        '
        'WarningLabel2
        '
        Me.WarningLabel2.AutoSize = True
        Me.WarningLabel2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WarningLabel2.ForeColor = System.Drawing.Color.DarkOrange
        Me.WarningLabel2.Location = New System.Drawing.Point(243, 549)
        Me.WarningLabel2.Name = "WarningLabel2"
        Me.WarningLabel2.Size = New System.Drawing.Size(105, 16)
        Me.WarningLabel2.TabIndex = 9
        Me.WarningLabel2.Text = "WarningLabel2"
        '
        'UpdateLabel
        '
        Me.UpdateLabel.AutoSize = True
        Me.UpdateLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateLabel.ForeColor = System.Drawing.Color.DarkOrange
        Me.UpdateLabel.Location = New System.Drawing.Point(625, 513)
        Me.UpdateLabel.Name = "UpdateLabel"
        Me.UpdateLabel.Size = New System.Drawing.Size(161, 14)
        Me.UpdateLabel.TabIndex = 12
        Me.UpdateLabel.Text = "Unable to check server version."
        '
        'Autor
        '
        Me.Autor.AutoSize = True
        Me.Autor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Autor.ForeColor = System.Drawing.Color.DarkOrange
        Me.Autor.Location = New System.Drawing.Point(8, 31)
        Me.Autor.Name = "Autor"
        Me.Autor.Size = New System.Drawing.Size(113, 14)
        Me.Autor.TabIndex = 13
        Me.Autor.Text = "Coded by Northstrider"
        '
        'LauncherVersion
        '
        Me.LauncherVersion.AutoSize = True
        Me.LauncherVersion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LauncherVersion.ForeColor = System.Drawing.Color.White
        Me.LauncherVersion.Location = New System.Drawing.Point(32, 10)
        Me.LauncherVersion.Name = "LauncherVersion"
        Me.LauncherVersion.Size = New System.Drawing.Size(90, 14)
        Me.LauncherVersion.TabIndex = 14
        Me.LauncherVersion.Text = "LauncherVersion"
        '
        'ServerNewsHeader
        '
        Me.ServerNewsHeader.AutoSize = True
        Me.ServerNewsHeader.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServerNewsHeader.ForeColor = System.Drawing.Color.DarkOrange
        Me.ServerNewsHeader.Location = New System.Drawing.Point(84, 111)
        Me.ServerNewsHeader.Name = "ServerNewsHeader"
        Me.ServerNewsHeader.Size = New System.Drawing.Size(106, 19)
        Me.ServerNewsHeader.TabIndex = 15
        Me.ServerNewsHeader.Text = "Server News"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label1.Location = New System.Drawing.Point(573, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 19)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Launcher News"
        '
        'ServerNews
        '
        Me.ServerNews.AutoSize = True
        Me.ServerNews.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServerNews.ForeColor = System.Drawing.Color.DarkOrange
        Me.ServerNews.Location = New System.Drawing.Point(20, 140)
        Me.ServerNews.Name = "ServerNews"
        Me.ServerNews.Size = New System.Drawing.Size(138, 15)
        Me.ServerNews.TabIndex = 17
        Me.ServerNews.Text = "- There are no news yet!"
        '
        'LauncherNews
        '
        Me.LauncherNews.AutoSize = True
        Me.LauncherNews.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LauncherNews.ForeColor = System.Drawing.Color.DarkOrange
        Me.LauncherNews.Location = New System.Drawing.Point(502, 140)
        Me.LauncherNews.Name = "LauncherNews"
        Me.LauncherNews.Size = New System.Drawing.Size(138, 15)
        Me.LauncherNews.TabIndex = 18
        Me.LauncherNews.Text = "- There are no news yet!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(31, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 15)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(11, 31)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(782, 15)
        Me.MenuBar.TabIndex = 10
        Me.MenuBar.TabStop = False
        '
        'PlayDisabled
        '
        Me.PlayDisabled.BackgroundImage = Global.Cataclysm_Game_Launcher.My.Resources.Resources.play3
        Me.PlayDisabled.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlayDisabled.Location = New System.Drawing.Point(645, 549)
        Me.PlayDisabled.Name = "PlayDisabled"
        Me.PlayDisabled.Size = New System.Drawing.Size(144, 88)
        Me.PlayDisabled.TabIndex = 8
        Me.PlayDisabled.TabStop = False
        '
        'DownloadBar
        '
        Me.DownloadBar.BackgroundImage = Global.Cataclysm_Game_Launcher.My.Resources.Resources.dl_bar_green
        Me.DownloadBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DownloadBar.Location = New System.Drawing.Point(39, 627)
        Me.DownloadBar.Name = "DownloadBar"
        Me.DownloadBar.Size = New System.Drawing.Size(0, 10)
        Me.DownloadBar.TabIndex = 7
        Me.DownloadBar.TabStop = False
        '
        'PatcherBackground
        '
        Me.PatcherBackground.BackColor = System.Drawing.Color.Transparent
        Me.PatcherBackground.BackgroundImage = Global.Cataclysm_Game_Launcher.My.Resources.Resources.dbar_playable
        Me.PatcherBackground.Location = New System.Drawing.Point(31, 589)
        Me.PatcherBackground.Name = "PatcherBackground"
        Me.PatcherBackground.Size = New System.Drawing.Size(602, 48)
        Me.PatcherBackground.TabIndex = 6
        Me.PatcherBackground.TabStop = False
        '
        'MinimizeButton
        '
        Me.MinimizeButton.Image = Global.Cataclysm_Game_Launcher.My.Resources.Resources.mini0
        Me.MinimizeButton.Location = New System.Drawing.Point(755, 4)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(21, 21)
        Me.MinimizeButton.TabIndex = 4
        Me.MinimizeButton.TabStop = False
        '
        'CloseButton
        '
        Me.CloseButton.Image = Global.Cataclysm_Game_Launcher.My.Resources.Resources.exit0
        Me.CloseButton.Location = New System.Drawing.Point(779, 4)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(21, 21)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.TabStop = False
        '
        'PlayButton
        '
        Me.PlayButton.BackgroundImage = Global.Cataclysm_Game_Launcher.My.Resources.Resources.play0
        Me.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlayButton.Location = New System.Drawing.Point(645, 549)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(144, 88)
        Me.PlayButton.TabIndex = 2
        Me.PlayButton.TabStop = False
        '
        'NewsLayer
        '
        Me.NewsLayer.Image = Global.Cataclysm_Game_Launcher.My.Resources.Resources.NewsImage
        Me.NewsLayer.Location = New System.Drawing.Point(0, 52)
        Me.NewsLayer.Name = "NewsLayer"
        Me.NewsLayer.Size = New System.Drawing.Size(806, 653)
        Me.NewsLayer.TabIndex = 1
        Me.NewsLayer.TabStop = False
        '
        'Layer
        '
        Me.Layer.Image = Global.Cataclysm_Game_Launcher.My.Resources.Resources.FormImage
        Me.Layer.Location = New System.Drawing.Point(0, 0)
        Me.Layer.Name = "Layer"
        Me.Layer.Size = New System.Drawing.Size(806, 653)
        Me.Layer.TabIndex = 0
        Me.Layer.TabStop = False
        '
        'Launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(806, 653)
        Me.Controls.Add(Me.LauncherNews)
        Me.Controls.Add(Me.ServerNews)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ServerNewsHeader)
        Me.Controls.Add(Me.LauncherVersion)
        Me.Controls.Add(Me.Autor)
        Me.Controls.Add(Me.UpdateLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuBar)
        Me.Controls.Add(Me.WarningLabel2)
        Me.Controls.Add(Me.PlayDisabled)
        Me.Controls.Add(Me.DownloadBar)
        Me.Controls.Add(Me.PatcherBackground)
        Me.Controls.Add(Me.WarningLabel)
        Me.Controls.Add(Me.MinimizeButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.NewsLayer)
        Me.Controls.Add(Me.Layer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Launcher"
        Me.Text = "Cataclysm Game Launcher"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayDisabled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DownloadBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatcherBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinimizeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewsLayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Layer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Layer As System.Windows.Forms.PictureBox
    Friend WithEvents NewsLayer As System.Windows.Forms.PictureBox
    Friend WithEvents PlayButton As System.Windows.Forms.PictureBox
    Friend WithEvents CloseButton As System.Windows.Forms.PictureBox
    Friend WithEvents MinimizeButton As System.Windows.Forms.PictureBox
    Friend WithEvents WarningLabel As System.Windows.Forms.Label
    Friend WithEvents PatcherBackground As System.Windows.Forms.PictureBox
    Friend WithEvents DownloadBar As System.Windows.Forms.PictureBox
    Friend WithEvents PlayDisabled As System.Windows.Forms.PictureBox
    Friend WithEvents WarningLabel2 As System.Windows.Forms.Label
    Friend WithEvents MenuBar As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents UpdateLabel As System.Windows.Forms.Label
    Friend WithEvents Autor As System.Windows.Forms.Label
    Friend WithEvents LauncherVersion As System.Windows.Forms.Label
    Friend WithEvents ServerNewsHeader As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ServerNews As System.Windows.Forms.Label
    Friend WithEvents LauncherNews As System.Windows.Forms.Label

End Class
