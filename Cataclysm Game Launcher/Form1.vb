Imports System.IO
Imports System.Net
Imports System.Management
Imports System.Text.RegularExpressions
Imports System.Runtime.InteropServices
Imports System.Xml
Imports System.Net.Sockets

' Cataclysm Game Launcher (c) by Northstrider
'
' This launcher source code is an powerful software
' to setup a Cataclysm game client within a few seconds
'
' Requirements:
' - Dropbox
'
' Todo:
' - implement delete system to remove outdated launcher
' - move the launcher news loading to asynch downloads (increases startup speed)
' - make the locale detection more dynamic

Public Class Launcher

    Public locale As String
    Public realmlist As String
    Public realm_adress As String
    Public local_version As String
    Public remote_version As String
    Public realmlist_enabled As Boolean
    Public launcher_update As Boolean
    Public started As Boolean

    Public WithEvents downloader As WebClient

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetLocalization()
        GetRealmlist()
        local_version = "1.0.0" 'Change this if you wan't to use the update system.
        remote_version = "0.0.0" 'Do not touch this!
        LauncherVersion.Text = "Cataclysm Game Launcher Version " + local_version
        started = False
        DownloadNews()
        CheckVersion()
    End Sub

    ' Launcher Move Mechanics
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Form_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Layer.MouseDown
        drag = True 'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub Form_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Layer.MouseMove
        'If drag is set to true then move the form accordingly.
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Layer.MouseUp
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub

    ' Launcher Mechanics (Update System)

    Public Sub CheckVersion()
        Dim loader = New WebClient
        remote_version = loader.DownloadString("https://dl.dropboxusercontent.com/s/gxcf3dpm64k0jwn/Version.txt?dl=1&token_hash=AAEsn8mFcdtH6rdjvwLN1hSgUofSvkuFOMxia7YWOjB6iA")
        If remote_version = "0.0.0" Then
        ElseIf remote_version = local_version Then
            UpdateLabel.Text = "Launcher is up to date."
            launcher_update = False
        Else
            UpdateLabel.Text = "Launcher update aviable!"
            launcher_update = True
            If File.Exists("Cataclysm Game Launcher " + remote_version + ".exe") Then
                My.Computer.FileSystem.DeleteFile("Cataclysm Game Launcher " + remote_version + ".exe")
                DownloadLauncher()
            Else
                DownloadLauncher()
            End If
        End If
        If launcher_update = False Then
            GetWoWExe()
        End If
    End Sub

    Public Sub GetLocalization()
        ' Read the first line of Config.wtf to get the current selected client language
        If File.Exists("WTF/Config.wtf") Then
            Dim reader As New System.IO.StreamReader("WTF/Config.wtf")
            locale = reader.ReadLine().Replace("SET locale ", "").Replace("""", "")
            reader.Close()
            WarningLabel2.Text = ""
            realmlist_enabled = True
        Else
            realmlist_enabled = False
            WarningLabel2.Text = "Couldn't detect client language. Realmlist patching disabled."
        End If
    End Sub

    Public Sub GetRealmlist()
        ' Use the language path to select the correct reamlist.wtf
        If realmlist_enabled = True Then
            realmlist = "Data/" + locale + "/realmlist.wtf"
        End If
    End Sub

    Public Sub GetWoWExe()
        ' Check for an WoW 4.3.4 Patched.exe file. If it doesn't exist, download new file
        If File.Exists("Wow 4.3.4 Patched.exe") Then
            PlayDisabled.Visible = False
            WarningLabel.Text = ""
        Else
            PlayDisabled.Visible = True
            DownloadWoWExe()
        End If
    End Sub

    Public Sub DownloadRealmlist()
        ' Download realmlist text from online text document. Prevents manipulation by users
        If realmlist_enabled = True Then
            Dim loader As New Net.WebClient
            realm_adress = loader.DownloadString("https://dl.dropboxusercontent.com/s/hqnxoo29xbnn2u1/Realmlist.txt?dl=1&token_hash=AAHuku2mV9MiSxXMSADJRgF0TioPW0DjGqWWk_TnkHyz2w")
            SetRealmlist()
        End If
    End Sub

    Public Sub DownloadNews()
        ' Downloading server and launcher news files
        Dim loader As New Net.WebClient
        ServerNews.Text = loader.DownloadString("https://dl.dropboxusercontent.com/s/8qv1w7h1k1myq8c/ServerNews.txt?dl=1&token_hash=AAHCWvN8eI4wR7ey6VdodoWkRk22jjdp7SWWL7DC-qOYug")
        LauncherNews.Text = loader.DownloadString("https://dl.dropboxusercontent.com/s/2c45fjyn222ib0j/LauncherNews.txt?dl=1&token_hash=AAFgiOfjQeriCOb7kXvQpWR-xk50FA-gCt1spGea_lc5_A")
    End Sub

    Public Sub DownloadWoWExe()
        ' Downloading WoW file
        downloader = New WebClient
        downloader.DownloadFileAsync(New Uri("https://dl.dropboxusercontent.com/s/wxkdphvkus3bkg4/Wow%204.3.4%20patched.exe?dl=1&token_hash=AAEZITYfWfFr1ONOq26Nhu7LphYVrdSnFppTJxwQD46gQQ"), "Wow 4.3.4 Patched.exe")
        WarningLabel.Text = "Couldn't find 'Wow 4.3.4 Patched.exe'. Downloading file."
        DownloadBar.Width = 0
    End Sub

    Public Sub DownloadLauncher()
        ' Downloading latest launcher version. (Always the same link at dropbox)
        downloader = New WebClient
        downloader.DownloadFileAsync(New Uri("https://dl.dropboxusercontent.com/s/ugfdwuha7xc1iuz/Cataclysm%20Game%20Launcher.exe?dl=1&token_hash=AAF2QjAIRUOajxdC3phueXWnPpwZBksXBLZFYgkQjfPXKA"), "Cataclysm Game Launcher " + remote_version + ".exe")
        WarningLabel.Text = "Updating Game Launcher. Downloading file."
        DownloadBar.Width = 0
    End Sub

    Private Sub downloader_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles downloader.DownloadProgressChanged
        DownloadBar.Width = 585 * e.ProgressPercentage / 100
        If e.ProgressPercentage < 33 Then
            PatcherBackground.Image = My.Resources.dbar_setup
            DownloadBar.BackgroundImage = My.Resources.dl_bar_red
        ElseIf e.ProgressPercentage < 66 Then
            DownloadBar.BackgroundImage = My.Resources.dl_bar_yellow
            PatcherBackground.Image = My.Resources.dbar_available
        ElseIf e.ProgressPercentage < 100 Then
            DownloadBar.BackgroundImage = My.Resources.dl_bar_green
            PatcherBackground.Image = My.Resources.dbar_playable
        ElseIf e.ProgressPercentage = 100 Then
            If launcher_update = True Then
                If started = False Then
                    If File.Exists("Cataclysm Game Launcher " + remote_version + ".exe") Then
                        Dim launcher As New Process()
                        launcher.StartInfo.FileName = "Cataclysm Game Launcher " + remote_version + ".exe"
                        launcher.Start()
                        Me.Close()
                    End If
                    started = True
                End If
            End If
            WarningLabel.Text = "Download finished."
            PlayDisabled.Visible = False
            End If
    End Sub

    Public Sub SetRealmlist()
        ' Before we start the game, we set the realmlist
        If File.Exists(realmlist) Then
            File.WriteAllText(realmlist, realm_adress)
        End If
    End Sub

    '----- Button System -----'

    Private Sub PlayButton_MouseEnter(sender As Object, e As EventArgs) Handles PlayButton.MouseEnter
        PlayButton.BackgroundImage = My.Resources.play1
    End Sub

    Private Sub PlayButton_MouseLeave(sender As Object, e As EventArgs) Handles PlayButton.MouseLeave
        PlayButton.BackgroundImage = My.Resources.play0
    End Sub

    Private Sub PlayButton_MouseDown(sender As Object, e As MouseEventArgs) Handles PlayButton.MouseDown
        PlayButton.BackgroundImage = My.Resources.play2
    End Sub

    Private Sub PlayButton_MouseUp(sender As Object, e As MouseEventArgs) Handles PlayButton.MouseUp
        PlayButton.BackgroundImage = My.Resources.play1
    End Sub

    Private Sub CloseButton_MouseEnter(sender As Object, e As EventArgs) Handles CloseButton.MouseEnter
        CloseButton.Image = My.Resources.exit1
    End Sub

    Private Sub CloseButton_MouseLeave(sender As Object, e As EventArgs) Handles CloseButton.MouseLeave
        CloseButton.Image = My.Resources.exit0
    End Sub

    Private Sub CloseButton_MouseDown(sender As Object, e As MouseEventArgs) Handles CloseButton.MouseDown
        CloseButton.Image = My.Resources.exit2
    End Sub

    Private Sub CloseButton_MouseUp(sender As Object, e As MouseEventArgs) Handles CloseButton.MouseUp
        CloseButton.Image = My.Resources.exit1
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub MinimizeButton_MouseEnter(sender As Object, e As EventArgs) Handles MinimizeButton.MouseEnter
        MinimizeButton.Image = My.Resources.mini1
    End Sub

    Private Sub MinimizeButton_MouseLeave(sender As Object, e As EventArgs) Handles MinimizeButton.MouseLeave
        MinimizeButton.Image = My.Resources.mini0
    End Sub

    Private Sub MinimizeButton_MouseDown(sender As Object, e As MouseEventArgs) Handles MinimizeButton.MouseDown
        MinimizeButton.Image = My.Resources.mini2
    End Sub

    Private Sub MinimizeButton_MouseUp(sender As Object, e As MouseEventArgs) Handles MinimizeButton.MouseUp
        MinimizeButton.Image = My.Resources.mini1
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        DownloadRealmlist()
        If File.Exists("Wow 4.3.4 patched.exe") Then
            Dim game As New Process()
            game.StartInfo.FileName = "Wow 4.3.4 patched.exe"
            game.Start()
            Me.Close()
        End If
    End Sub
End Class
