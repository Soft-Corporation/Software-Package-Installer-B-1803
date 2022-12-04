Imports MaterialSkin
Imports System.Net
Imports System.IO

Public Class Form1

    Dim NuovP As System.Drawing.Point
    Dim x, y As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Vsc.Show()
    End Sub

    Private Sub Panel8_MouseEnter(sender As Object, e As EventArgs) Handles Panel8.MouseEnter
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Visual_Studio.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Libreoffice.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Edge.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Chrome.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Firefox.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Iobit_Driver_Booster.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        IObit_Unistaller.Show()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Hwmonitor.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        _7zip.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)
        If Panel1.Visible = True Then

            Panel2.Show()
        Else
            Panel1.Show()
            Panel2.Hide()
        End If


    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        If Panel2.Visible = True Then
            Panel2.Hide()
        Else
            Panel1.Hide()

        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)
        Notepad__.Show()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)
        Discord.Show()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs)
        Steam.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)
        Virtualbox.Show()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs)
        Vmware.Show()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs)
        Sky_Go.Show()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs)
        Ccleaner.Show()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs)
        Google_Drive.Show()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs)
        Obs.Show()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs)
        Flowgorithm.Show()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs)
        Teamviewer.Show()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs)
        Soft_Optimizer.Show()

    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs)
        Gimp.Show()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs)
        Abobe_Acrobat_Reader.Show()
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs)
        Audacity.Show()
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs)
        Install_Creator.Show()
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs)
        Shotcut.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Informazioni_di_Software_Package_Installer.Show()
    End Sub

    Private Sub MaterialLabel1_Click(sender As Object, e As EventArgs)
        Teamviewer.Show()
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        Teamviewer.Show()
    End Sub

    Private Sub MaterialLabel2_Click(sender As Object, e As EventArgs)
        Soft_Optimizer.Show()
    End Sub

    Private Sub MaterialLabel3_Click(sender As Object, e As EventArgs)
        Gimp.Show()
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        Gimp.Show()
    End Sub

    Private Sub MaterialLabel4_Click(sender As Object, e As EventArgs)
        Abobe_Acrobat_Reader.Show()
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        Abobe_Acrobat_Reader.Show()
    End Sub

    Private Sub MaterialLabel5_Click(sender As Object, e As EventArgs)
        Audacity.Show()
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        Audacity.Show()
    End Sub

    Private Sub MaterialButton3_Click(sender As Object, e As EventArgs)
        Informazioni_di_Software_Package_Installer.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Blue") Then
            Timer5.Start()
            Timer6.Stop()
            Timer7.Stop()
            Timer8.Stop()
            Timer9.Stop()
            Timer10.Stop()

        End If


        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Red") Then
            Timer5.Stop()
            Timer6.Start()
            Timer7.Stop()
            Timer8.Stop()
            Timer9.Stop()
            Timer10.Stop()

        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Green") Then
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Start()
            Timer8.Stop()
            Timer9.Stop()
            Timer10.Stop()

        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Orange") Then
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Stop()
            Timer8.Start()
            Timer9.Stop()
            Timer10.Stop()

        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Purple") Then
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Stop()
            Timer8.Stop()
            Timer9.Start()
            Timer10.Stop()

        End If


        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Gold") Then
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Stop()
            Timer8.Stop()
            Timer9.Stop()
            Timer10.Start()


        End If


        Panel21.Show()
        Panel22.Hide()
        Panel23.Hide()
        Panel24.Hide()
        Panel25.Hide()
        Panel26.Hide()
        Panel27.Hide()
        Panel28.Hide()
        Panel29.Hide()

        Timer1.Start()


        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Up") Then
            Download.DownloadFileAsync(New Uri("Server Ftp Url"), Application.StartupPath & "\Updater.txt")

            Timer2.Start()
            Timer3.Start()
            Timer4.Start()
        End If





    End Sub

    Public WithEvents Download As New WebClient
    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs)
        Panel2.Hide()
        Panel1.Hide()
        Panel3.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()



        szp.Show()
    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs)
        Panel1.Show()
        Panel2.Hide()
        Panel3.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()

    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        Soft_Optimizer.Show()
    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        Install_Creator.Show()
    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        Shotcut.Show()
    End Sub

    Private Sub MaterialLabel7_Click(sender As Object, e As EventArgs)
        Shotcut.Show()
    End Sub

    Private Sub MaterialLabel6_Click(sender As Object, e As EventArgs)
        Install_Creator.Show()
    End Sub

    Private Sub MaterialLabel9_Click(sender As Object, e As EventArgs)
        Notepad__.Show()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Notepad__.Show()
    End Sub

    Private Sub MaterialLabel10_Click(sender As Object, e As EventArgs)
        Discord.Show()

    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Discord.Show()
    End Sub

    Private Sub MaterialLabel11_Click(sender As Object, e As EventArgs)
        Steam.Show()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Steam.Show()
    End Sub

    Private Sub MaterialLabel12_Click(sender As Object, e As EventArgs)
        Virtualbox.Show()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Virtualbox.Show()
    End Sub

    Private Sub MaterialLabel13_Click(sender As Object, e As EventArgs)
        Vmware.Show()
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Vmware.Show()
    End Sub

    Private Sub MaterialLabel14_Click(sender As Object, e As EventArgs)
        Sky_Go.Show()
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Sky_Go.Show()
    End Sub

    Private Sub MaterialLabel15_Click(sender As Object, e As EventArgs)
        Ccleaner.Show()
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        Ccleaner.Show()
    End Sub

    Private Sub MaterialLabel16_Click(sender As Object, e As EventArgs)
        Google_Drive.Show()
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        Google_Drive.Show()
    End Sub

    Private Sub MaterialLabel17_Click(sender As Object, e As EventArgs)
        Obs.Show()
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        Obs.Show()
    End Sub

    Private Sub MaterialLabel18_Click(sender As Object, e As EventArgs)
        Flowgorithm.Show()
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        Flowgorithm.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub MaterialButton4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub MaterialButton4_Click_1(sender As Object, e As EventArgs)
        Panel2.Show()
        Panel1.Hide()
        Panel3.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()

        szp.Hide()

    End Sub

    Private Sub MaterialLabel19_Click(sender As Object, e As EventArgs)
        Vsc.Show()
    End Sub



    Private Sub MaterialLabel20_Click(sender As Object, e As EventArgs)
        Visual_Studio.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles vsp.Click
        Visual_Studio.Show()
    End Sub

    Private Sub MaterialLabel21_Click(sender As Object, e As EventArgs)
        Firefox.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles fip.Click
        Firefox.Show()
    End Sub

    Private Sub MaterialLabel22_Click(sender As Object, e As EventArgs)
        Iobit_Driver_Booster.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles bdp.Click
        Iobit_Driver_Booster.Show()
    End Sub

    Private Sub MaterialLabel23_Click(sender As Object, e As EventArgs)
        Libreoffice.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles lbp.Click
        Libreoffice.Show()
    End Sub

    Private Sub MaterialLabel24_Click(sender As Object, e As EventArgs)
        Edge.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles edp.Click
        Edge.Show()
    End Sub

    Private Sub MaterialLabel25_Click(sender As Object, e As EventArgs)
        Chrome.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles chp.Click
        Chrome.Show()
    End Sub

    Private Sub MaterialLabel26_Click(sender As Object, e As EventArgs)
        IObit_Unistaller.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles up.Click
        IObit_Unistaller.Show()
    End Sub

    Private Sub MaterialLabel27_Click(sender As Object, e As EventArgs)
        Hwmonitor.Show()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles hwp.Click
        Hwmonitor.Show()
    End Sub

    Private Sub MaterialLabel28_Click(sender As Object, e As EventArgs)
        _7zip.Show()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles szp.Click
        _7zip.Show()
    End Sub

    Private Sub MaterialLabel29_Click(sender As Object, e As EventArgs)
        Trading_View.Show()
    End Sub

    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PictureBox28.Click
        Trading_View.Show()
    End Sub

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.Click
        Logitech_G_Hub.Show()
    End Sub

    Private Sub MaterialLabel30_Click(sender As Object, e As EventArgs)
        Logitech_G_Hub.Show()
    End Sub

    Private Sub PictureBox30_Click(sender As Object, e As EventArgs) Handles PictureBox30.Click
        Anydesk.Show()
    End Sub

    Private Sub MaterialLabel31_Click(sender As Object, e As EventArgs)
        Anydesk.Show()
    End Sub

    Private Sub PictureBox40_Click(sender As Object, e As EventArgs) Handles PictureBox40.Click
        Opera.Show()

    End Sub

    Private Sub MaterialLabel41_Click(sender As Object, e As EventArgs)
        Opera.Show()
    End Sub

    Private Sub PictureBox39_Click(sender As Object, e As EventArgs) Handles PictureBox39.Click
        Opera_Gx.Show()
    End Sub

    Private Sub MaterialLabel40_Click(sender As Object, e As EventArgs)
        Opera_Gx.Show()
    End Sub

    Private Sub PictureBox38_Click(sender As Object, e As EventArgs) Handles PictureBox38.Click
        Vivaldi.Show()

    End Sub

    Private Sub MaterialLabel39_Click(sender As Object, e As EventArgs)
        Vivaldi.Show()

    End Sub

    Private Sub PictureBox37_Click(sender As Object, e As EventArgs) Handles PictureBox37.Click
        OperaCB.Show()
    End Sub

    Private Sub MaterialLabel38_Click(sender As Object, e As EventArgs)
        OperaCB.Show()
    End Sub

    Private Sub PictureBox36_Click(sender As Object, e As EventArgs) Handles PictureBox36.Click
        OnlyOffice.Show()
    End Sub

    Private Sub MaterialLabel37_Click(sender As Object, e As EventArgs)
        OnlyOffice.Show()
    End Sub

    Private Sub PictureBox35_Click(sender As Object, e As EventArgs) Handles PictureBox35.Click
        Rufus.Show()

    End Sub

    Private Sub MaterialLabel36_Click(sender As Object, e As EventArgs)
        Rufus.Show()

    End Sub

    Private Sub PictureBox34_Click(sender As Object, e As EventArgs) Handles PictureBox34.Click
        Python.Show()
    End Sub

    Private Sub MaterialLabel35_Click(sender As Object, e As EventArgs)
        Python.Show()
    End Sub

    Private Sub PictureBox33_Click(sender As Object, e As EventArgs) Handles PictureBox33.Click
        Davinci_Resolve.Show()
    End Sub

    Private Sub MaterialLabel34_Click(sender As Object, e As EventArgs)
        Davinci_Resolve.Show()
    End Sub

    Private Sub PictureBox32_Click(sender As Object, e As EventArgs) Handles PictureBox32.Click
        Openshot.Show()

    End Sub

    Private Sub MaterialLabel33_Click(sender As Object, e As EventArgs)
        Openshot.Show()
    End Sub

    Private Sub PictureBox31_Click(sender As Object, e As EventArgs) Handles PictureBox31.Click
        Driver_Easy.Show()
    End Sub

    Private Sub MaterialLabel32_Click(sender As Object, e As EventArgs)
        Driver_Easy.Show()

    End Sub

    Private Sub PictureBox50_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialLabel51_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox49_Click(sender As Object, e As EventArgs) Handles PictureBox49.Click
        Iobit_Malware_Fighter.Show()

    End Sub

    Private Sub MaterialLabel50_Click(sender As Object, e As EventArgs)
        Iobit_Malware_Fighter.Show()
    End Sub

    Private Sub MaterialButton5_Click(sender As Object, e As EventArgs)
        Panel3.Show()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()

    End Sub

    Private Sub MaterialButton6_Click(sender As Object, e As EventArgs)
        Panel3.Hide()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Show()
        Panel5.Hide()
        Panel6.Hide()


    End Sub

    Private Sub MaterialButton7_Click(sender As Object, e As EventArgs)
        Impostazioni.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Conf") Then


        Else

            Configurazione.Show()

        End If

    End Sub

    Private Sub PictureBox41_Click(sender As Object, e As EventArgs) Handles PictureBox41.Click
        IObit_Software_Updater.Show()
    End Sub

    Private Sub MaterialLabel42_Click(sender As Object, e As EventArgs)
        IObit_Software_Updater.Show()

    End Sub

    Private Sub PictureBox42_Click(sender As Object, e As EventArgs) Handles PictureBox42.Click
        Soft_Usb_Passwords.Show()
    End Sub

    Private Sub MaterialLabel43_Click(sender As Object, e As EventArgs)
        Soft_Usb_Passwords.Show()
    End Sub

    Private Sub PictureBox43_Click(sender As Object, e As EventArgs) Handles PictureBox43.Click
        Soft_Launcher.Show()

    End Sub

    Private Sub MaterialLabel44_Click(sender As Object, e As EventArgs)
        Soft_Launcher.Show()
    End Sub

    Private Sub PictureBox44_Click(sender As Object, e As EventArgs) Handles PictureBox44.Click
        Nox_Player.Show()

    End Sub

    Private Sub MaterialLabel45_Click(sender As Object, e As EventArgs)
        Nox_Player.Show()
    End Sub

    Private Sub PictureBox45_Click(sender As Object, e As EventArgs) Handles PictureBox45.Click
        Telegram.Show()

    End Sub

    Private Sub MaterialLabel46_Click(sender As Object, e As EventArgs)
        Telegram.Show()

    End Sub

    Private Sub PictureBox46_Click(sender As Object, e As EventArgs) Handles PictureBox46.Click
        Dev_C__.Show()
    End Sub

    Private Sub MaterialLabel47_Click(sender As Object, e As EventArgs)
        Dev_C__.Show()
    End Sub

    Private Sub PictureBox47_Click(sender As Object, e As EventArgs) Handles PictureBox47.Click
        AlgoBuild.Show()

    End Sub

    Private Sub MaterialLabel48_Click(sender As Object, e As EventArgs)
        AlgoBuild.Show()
    End Sub

    Private Sub PictureBox48_Click(sender As Object, e As EventArgs) Handles PictureBox48.Click
        Crystaldiskmark.Show()

    End Sub

    Private Sub MaterialLabel49_Click(sender As Object, e As EventArgs)
        Crystaldiskmark.Show()

    End Sub

    Private Sub PictureBox50_Click_1(sender As Object, e As EventArgs) Handles PictureBox50.Click
        Crystaldiskinfo.Show()
    End Sub

    Private Sub MaterialLabel51_Click_1(sender As Object, e As EventArgs)
        Crystaldiskinfo.Show()

    End Sub

    Private Sub PictureBox60_Click(sender As Object, e As EventArgs) Handles PictureBox60.Click
        Zoom.Show()
    End Sub

    Private Sub MaterialLabel61_Click(sender As Object, e As EventArgs)
        Zoom.Show()
    End Sub

    Private Sub PictureBox59_Click(sender As Object, e As EventArgs) Handles PictureBox59.Click
        Vlc.Show()

    End Sub

    Private Sub MaterialLabel60_Click(sender As Object, e As EventArgs)
        Vlc.Show()

    End Sub

    Private Sub PictureBox58_Click(sender As Object, e As EventArgs) Handles PictureBox58.Click
        Epic_Games_Launcher.Show()
    End Sub

    Private Sub MaterialLabel59_Click(sender As Object, e As EventArgs)
        Epic_Games_Launcher.Show()
    End Sub

    Private Sub PictureBox57_Click(sender As Object, e As EventArgs) Handles PictureBox57.Click
        Battlenet.Show()
    End Sub

    Private Sub MaterialLabel58_Click(sender As Object, e As EventArgs)
        Battlenet.Show()
    End Sub

    Private Sub PictureBox56_Click(sender As Object, e As EventArgs) Handles PictureBox56.Click
        Chrome_Canary.Show()
    End Sub

    Private Sub MaterialLabel57_Click(sender As Object, e As EventArgs)
        Chrome_Canary.Show()
    End Sub

    Private Sub PictureBox55_Click(sender As Object, e As EventArgs) Handles PictureBox55.Click
        Notion.Show()

    End Sub

    Private Sub MaterialLabel56_Click(sender As Object, e As EventArgs)
        Notion.Show()
    End Sub

    Private Sub PictureBox54_Click(sender As Object, e As EventArgs) Handles PictureBox54.Click
        Nvidia_Geforce_Experience.Show()
    End Sub

    Private Sub MaterialLabel55_Click(sender As Object, e As EventArgs)
        Nvidia_Geforce_Experience.Show()
    End Sub

    Private Sub MaterialButton8_Click(sender As Object, e As EventArgs)
        Panel3.Hide()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Hide()
        Panel5.Show()
        Panel6.Hide()



    End Sub

    Private Sub CircularProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        On Error Resume Next

        Dim apri As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Updater.txt")
        b.Text = apri

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        If a.Text < b.Text Then
            Process.Start("https://grammaticosamuele4.wixsite.com/ilmiosito/soft-optimizer-1-01")
        Else


        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Timer3.Stop()
    End Sub

    Private Sub PictureBox51_Click(sender As Object, e As EventArgs) Handles PictureBox51.Click
        Filezilla_Server.Show()

    End Sub

    Private Sub MaterialLabel52_Click(sender As Object, e As EventArgs)
        Filezilla_Server.Show()
    End Sub

    Private Sub PictureBox52_Click(sender As Object, e As EventArgs) Handles PictureBox52.Click
        Filezilla_Ser.Show()
    End Sub

    Private Sub MaterialLabel53_Click(sender As Object, e As EventArgs)
        Filezilla_Ser.Show()

    End Sub

    Private Sub PictureBox53_Click(sender As Object, e As EventArgs) Handles PictureBox53.Click
        Advanced_Systemcare.Show()
    End Sub

    Private Sub MaterialLabel54_Click(sender As Object, e As EventArgs)
        Advanced_Systemcare.Show()
    End Sub

    Private Sub PictureBox70_Click(sender As Object, e As EventArgs) Handles PictureBox70.Click
        Smart_Defrag.Show()
    End Sub

    Private Sub MaterialLabel71_Click(sender As Object, e As EventArgs)
        Smart_Defrag.Show()
    End Sub

    Private Sub PictureBox69_Click(sender As Object, e As EventArgs) Handles PictureBox69.Click
        Iobit_Protected_Folder.Show()
    End Sub

    Private Sub MaterialLabel70_Click(sender As Object, e As EventArgs)
        Iobit_Protected_Folder.Show()
    End Sub

    Private Sub PictureBox68_Click(sender As Object, e As EventArgs) Handles PictureBox68.Click
        Itop_Vpn.Show()

    End Sub

    Private Sub MaterialLabel69_Click(sender As Object, e As EventArgs)
        Itop_Vpn.Show()
    End Sub

    Private Sub PictureBox67_Click(sender As Object, e As EventArgs) Handles PictureBox67.Click
        Droidcam.Show()
    End Sub

    Private Sub MaterialLabel68_Click(sender As Object, e As EventArgs)
        Droidcam.Show()
    End Sub

    Private Sub PictureBox66_Click(sender As Object, e As EventArgs) Handles PictureBox66.Click
        OpenOffice.Show()
    End Sub

    Private Sub MaterialLabel67_Click(sender As Object, e As EventArgs)
        OpenOffice.Show()
    End Sub

    Private Sub PictureBox65_Click(sender As Object, e As EventArgs) Handles PictureBox65.Click
        Ps_Remote_Play.Show()

    End Sub

    Private Sub MaterialLabel66_Click(sender As Object, e As EventArgs)
        Ps_Remote_Play.Show()
    End Sub

    Private Sub PictureBox64_Click(sender As Object, e As EventArgs) Handles PictureBox64.Click
        Itunes.Show()
    End Sub

    Private Sub MaterialLabel65_Click(sender As Object, e As EventArgs)
        Itunes.Show()

    End Sub

    Private Sub MaterialButton3_Click_1(sender As Object, e As EventArgs)
        Panel3.Hide()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Show()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Impostazioni.Show()
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles vsp.Click
        Vsc.Show()
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Panel30.Hide()
        Panel31.Hide()
        Panel2.Hide()
        Panel1.Hide()
        Panel3.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()
        Vsc.Show()
        Vs.Show()
        Ed.Show()
        Ch.Show()
        Fi.Show()
        Bd.Show()
        u.Show()
        sz.Show()
        hw.Show()

        szp.Show()

        vscp.Show()
        vsp.Show()
        lbp.Show()
        edp.Show()
        chp.Show()
        fip.Show()
        bdp.Show()
        up.Show()
        hwp.Show()
        szp.Show()
        Lb.Show()
        Panel17.Hide()
        Panel18.Hide()
        Panel21.Show()
        Panel22.Hide()
        Panel23.Hide()
        Panel24.Hide()
        Panel25.Hide()
        Panel26.Hide()
        Panel27.Hide()
        Panel28.Hide()
        Panel29.Hide()

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Panel30.Hide()
        Panel31.Hide()
        Panel1.Show()
        Panel2.Hide()
        Panel3.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()
        Vsc.Hide()
        Vs.Hide()
        Ed.Hide()
        Ch.Hide()
        Fi.Hide()
        Bd.Hide()
        u.Hide()
        sz.Hide()
        hw.Hide()
        tv.Hide()
        so.Hide()
        gi.Hide()
        ac.Hide()
        au.Hide()
        ic.Hide()
        sh.Hide()
        tr.Hide()
        lh.Hide()
        an.Hide()
        Lb.Hide()
        Panel17.Hide()
        Panel18.Hide()
        Panel21.Hide()
        Panel22.Show()
        Panel23.Hide()
        Panel24.Hide()
        Panel25.Hide()
        Panel26.Hide()
        Panel27.Hide()
        Panel28.Hide()
        Panel29.Hide()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Panel30.Hide()
        Panel31.Hide()
        Panel2.Show()
        Panel1.Hide()
        Panel3.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()
        tv.Show()
        so.Show()
        gi.Show()
        ac.Show()
        au.Show()
        ic.Show()
        sh.Show()
        tr.Show()
        lh.Show()
        an.Show()
        Vsc.Hide()
        Vs.Hide()
        Ed.Hide()
        Ch.Hide()
        Fi.Hide()
        Bd.Hide()
        u.Hide()
        sz.Hide()
        hw.Hide()
        szp.Hide()
        Lb.Hide()
        Panel17.Hide()
        Panel18.Hide()
        Panel21.Hide()
        Panel22.Hide()
        Panel23.Show()
        Panel24.Hide()
        Panel25.Hide()
        Panel26.Hide()
        Panel27.Hide()
        Panel28.Hide()
        Panel29.Hide()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Panel30.Hide()
        Panel31.Hide()
        Panel3.Show()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()
        Panel17.Hide()
        Panel18.Hide()
        Vsc.Hide()
        Vs.Hide()
        Ed.Hide()
        Ch.Hide()
        Fi.Hide()
        Bd.Hide()
        u.Hide()
        sz.Hide()
        hw.Hide()

        tv.Hide()
        so.Hide()
        gi.Hide()
        ac.Hide()
        au.Hide()
        ic.Hide()
        sh.Hide()
        tr.Hide()
        lh.Hide()
        an.Hide()
        vscp.Hide()
        vsp.Hide()
        lbp.Hide()
        edp.Hide()
        chp.Hide()
        fip.Hide()
        bdp.Hide()
        up.Hide()
        hwp.Hide()
        szp.Hide()
        Lb.Hide()
        Panel21.Hide()
        Panel22.Hide()
        Panel23.Hide()
        Panel24.Show()
        Panel25.Hide()
        Panel26.Hide()
        Panel27.Hide()
        Panel28.Hide()
        Panel29.Hide()

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Panel30.Hide()
        Panel31.Hide()
        Panel3.Hide()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Show()
        Panel5.Hide()
        Panel6.Hide()
        Panel17.Hide()
        Panel18.Hide()
        Vsc.Hide()
        Vs.Hide()
        Ed.Hide()
        Ch.Hide()
        Fi.Hide()
        Bd.Hide()
        u.Hide()
        sz.Hide()
        hw.Hide()

        tv.Hide()
        so.Hide()
        gi.Hide()
        ac.Hide()
        au.Hide()
        ic.Hide()
        sh.Hide()
        tr.Hide()
        lh.Hide()
        Lb.Hide()

        an.Hide()
        vscp.Hide()
        vsp.Hide()
        lbp.Hide()
        edp.Hide()
        chp.Hide()
        fip.Hide()
        bdp.Hide()
        up.Hide()
        hwp.Hide()
        szp.Hide()
        Panel21.Hide()
        Panel22.Hide()
        Panel23.Hide()
        Panel24.Hide()
        Panel25.Show()
        Panel26.Hide()
        Panel27.Hide()
        Panel28.Hide()
        Panel29.Hide()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Panel30.Hide()
        Panel31.Hide()
        Panel3.Hide()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Hide()
        Panel5.Show()
        Panel6.Hide()
        Vsc.Hide()
        Vs.Hide()
        Ed.Hide()
        Ch.Hide()
        Fi.Hide()
        Bd.Hide()
        u.Hide()
        sz.Hide()
        hw.Hide()
        tv.Hide()
        so.Hide()
        gi.Hide()
        ac.Hide()
        au.Hide()
        ic.Hide()
        sh.Hide()
        tr.Hide()
        lh.Hide()
        an.Hide()
        vscp.Hide()
        vsp.Hide()
        lbp.Hide()
        edp.Hide()
        chp.Hide()
        fip.Hide()
        bdp.Hide()
        up.Hide()
        hwp.Hide()
        szp.Hide()
        Lb.Hide()
        Panel17.Hide()
        Panel18.Hide()
        Panel21.Hide()
        Panel22.Hide()
        Panel23.Hide()
        Panel24.Hide()
        Panel25.Hide()
        Panel26.Show()
        Panel27.Hide()
        Panel28.Hide()
        Panel29.Hide()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Panel30.Hide()
        Panel31.Hide()
        Panel3.Hide()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Show()
        Panel17.Hide()
        Panel18.Hide()
        Vsc.Hide()
        Vs.Hide()
        Ed.Hide()
        Ch.Hide()
        Fi.Hide()
        Bd.Hide()
        u.Hide()
        sz.Hide()
        hw.Hide()
        tv.Hide()
        so.Hide()
        gi.Hide()
        ac.Hide()
        au.Hide()
        ic.Hide()
        sh.Hide()
        tr.Hide()
        lh.Hide()
        an.Hide()
        vscp.Hide()
        vsp.Hide()
        lbp.Hide()
        edp.Hide()
        chp.Hide()
        fip.Hide()
        bdp.Hide()
        up.Hide()
        hwp.Hide()
        szp.Hide()
        Lb.Hide()
        Panel21.Hide()
        Panel22.Hide()
        Panel23.Hide()
        Panel24.Hide()
        Panel25.Hide()
        Panel26.Hide()
        Panel27.Show()
        Panel28.Hide()
        Panel29.Hide()
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.RoyalBlue)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Red)
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Green)
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Orange)
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Purple)
    End Sub

    Private Sub Panel8_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel8.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NuovP = Control.MousePosition
            NuovP.X -= (x)
            NuovP.Y -= (y)
            Me.Location = NuovP
        End If
    End Sub

    Private Sub vscp_Click(sender As Object, e As EventArgs) Handles vscp.Click
        Visual.Show()
    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick
        Panel8.BackColor = Color.FromArgb(TrackBar1.Value, Color.Gold)
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Docker.Show()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Avast.Show()
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        MalwareBytes.Show()
    End Sub

    Private Sub PictureBox71_Click(sender As Object, e As EventArgs) Handles PictureBox71.Click
        Avg.Show()
    End Sub

    Private Sub PictureBox63_Click(sender As Object, e As EventArgs) Handles PictureBox63.Click
        Tunnelbear.Show()
    End Sub

    Private Sub PictureBox62_Click(sender As Object, e As EventArgs) Handles PictureBox62.Click
        Vim.Show()
    End Sub

    Private Sub PictureBox10_Click_1(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Node_Js.Show()
    End Sub

    Private Sub PictureBox9_Click_1(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Mega_Sync.Show()
    End Sub

    Private Sub PictureBox8_Click_1(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Smart_Game_Booster.Show()
    End Sub

    Private Sub PictureBox7_Click_1(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Balena_Etcher.Show()
    End Sub

    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Deskreen.Show()
    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Vera_Crypt.Show()
    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Greenshot.Show()
    End Sub

    Private Sub PictureBox81_Click(sender As Object, e As EventArgs) Handles PictureBox81.Click
        File_Converter.Show()
    End Sub

    Private Sub PictureBox80_Click(sender As Object, e As EventArgs) Handles PictureBox80.Click
        Edge_Dev.Show()
    End Sub

    Private Sub PictureBox79_Click(sender As Object, e As EventArgs) Handles PictureBox79.Click
        Edge_Beta.Show()
    End Sub

    Private Sub Label73_Click(sender As Object, e As EventArgs) Handles Label73.Click
        Panel30.Hide()
        Panel31.Hide()
        Panel17.Show()
        Panel3.Hide()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()
        Panel18.Hide()
        Vsc.Hide()
        Vs.Hide()
        Ed.Hide()
        Ch.Hide()
        Fi.Hide()
        Bd.Hide()
        u.Hide()
        sz.Hide()
        hw.Hide()
        tv.Hide()
        so.Hide()
        gi.Hide()
        ac.Hide()
        au.Hide()
        ic.Hide()
        sh.Hide()
        tr.Hide()
        lh.Hide()
        an.Hide()
        Lb.Hide()
        Panel21.Hide()
        Panel22.Hide()
        Panel23.Hide()
        Panel24.Hide()
        Panel25.Hide()
        Panel26.Hide()
        Panel27.Hide()
        Panel28.Show()
        Panel29.Hide()
    End Sub

    Private Sub Label74_Click(sender As Object, e As EventArgs) Handles Label74.Click
        Panel30.Hide()
        Panel31.Hide()
        Panel3.Hide()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()
        Panel18.Show()
        Panel17.Hide()
        Vsc.Hide()
        Vs.Hide()
        Ed.Hide()
        Ch.Hide()
        Fi.Hide()
        Bd.Hide()
        u.Hide()
        sz.Hide()
        hw.Hide()
        tv.Hide()
        so.Hide()
        gi.Hide()
        ac.Hide()
        au.Hide()
        ic.Hide()
        sh.Hide()
        tr.Hide()
        lh.Hide()
        an.Hide()
        Lb.Hide()
        Panel21.Hide()
        Panel22.Hide()
        Panel23.Hide()
        Panel24.Hide()
        Panel25.Hide()
        Panel26.Hide()
        Panel27.Hide()
        Panel28.Hide()
        Panel29.Show()
    End Sub

    Private Sub PictureBox72_Click(sender As Object, e As EventArgs) Handles PictureBox72.Click
        Cpu_Z.Show()
    End Sub

    Private Sub Label80_Click(sender As Object, e As EventArgs) Handles Label80.Click

    End Sub

    Private Sub PictureBox73_Click(sender As Object, e As EventArgs) Handles PictureBox73.Click
        GeekBench.Show()
    End Sub

    Private Sub PictureBox74_Click(sender As Object, e As EventArgs) Handles PictureBox74.Click
        Soft_Files_Encrypted.Show()
    End Sub

    Private Sub PictureBox75_Click(sender As Object, e As EventArgs) Handles PictureBox75.Click
        Uttorent.Show()
    End Sub

    Private Sub PictureBox76_Click(sender As Object, e As EventArgs) Handles PictureBox76.Click
        BlueStacks.Show()
    End Sub

    Private Sub PictureBox77_Click(sender As Object, e As EventArgs) Handles PictureBox77.Click
        Proton_Vpn.Show()
    End Sub

    Private Sub PictureBox78_Click(sender As Object, e As EventArgs) Handles PictureBox78.Click
        Everything.Show()
    End Sub

    Private Sub PictureBox91_Click(sender As Object, e As EventArgs) Handles PictureBox91.Click
        Patch_my_pc.Show()
    End Sub

    Private Sub PictureBox90_Click(sender As Object, e As EventArgs) Handles PictureBox90.Click
        Revo_Uninstaller.Show()
    End Sub

    Private Sub PictureBox89_Click(sender As Object, e As EventArgs) Handles PictureBox89.Click
        Share_X.Show()
    End Sub

    Private Sub PictureBox88_Click(sender As Object, e As EventArgs) Handles PictureBox88.Click
        Wiztree.Show()
    End Sub

    Private Sub PictureBox87_Click(sender As Object, e As EventArgs) Handles PictureBox87.Click
        Bitwarden.Show()
    End Sub

    Private Sub PictureBox86_Click(sender As Object, e As EventArgs) Handles PictureBox86.Click
        Encrypto.Show()
    End Sub

    Private Sub PictureBox85_Click(sender As Object, e As EventArgs) Handles PictureBox85.Click
        Capcut.Show()
    End Sub

    Private Sub PictureBox84_Click(sender As Object, e As EventArgs) Handles PictureBox84.Click
        Brave.Show()
    End Sub

    Private Sub Label85_Click(sender As Object, e As EventArgs) Handles Label85.Click
        Panel30.Show()
        Panel3.Hide()
        Panel2.Hide()
        Panel1.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()
        Panel18.Hide()
        Panel17.Hide()
        Vsc.Hide()
        Vs.Hide()
        Ed.Hide()
        Ch.Hide()
        Fi.Hide()
        Bd.Hide()
        u.Hide()
        sz.Hide()
        hw.Hide()
        tv.Hide()
        so.Hide()
        gi.Hide()
        ac.Hide()
        au.Hide()
        ic.Hide()
        sh.Hide()
        tr.Hide()
        lh.Hide()
        an.Hide()
        Lb.Hide()
        Panel21.Hide()
        Panel22.Hide()
        Panel23.Hide()
        Panel24.Hide()
        Panel25.Hide()
        Panel26.Hide()
        Panel27.Hide()
        Panel28.Hide()
        Panel29.Hide()
        Panel31.Show()
    End Sub

    Private Sub Panel18_Paint(sender As Object, e As PaintEventArgs) Handles Panel18.Paint

    End Sub

    Private Sub Label86_Click(sender As Object, e As EventArgs) Handles Label86.Click
        If TextBox1.Text = "Visual Studio Code" Then
            Visual.Show()
        ElseIf TextBox1.Text = "visual studio code" Then
            Visual.Show
        ElseIf TextBox1.Text = "Visual Studio" Then
            Visual_Studio.Show()
        ElseIf TextBox1.Text = "visual studio" Then
            Visual_Studio.Show()
        ElseIf TextBox1.Text = "Libreoffice" Then
            Libreoffice.Show
        ElseIf TextBox1.Text = "libreoffice" Then
            Libreoffice.Show()
        ElseIf TextBox1.Text = "Edge" Then
            Edge.Show
        ElseIf TextBox1.Text = "edge" Then
            Edge.Show
        ElseIf TextBox1.Text = "Chrome" Then
            Chrome.Show
        ElseIf TextBox1.Text = "chrome" Then
            Chrome.Show
        ElseIf TextBox1.Text = "Firefox" Then
            Firefox.Show
        ElseIf TextBox1.Text = "firefox" Then
            Firefox.Show
        ElseIf TextBox1.Text = "Driver Booster" Then
            Iobit_Driver_Booster.Show
        ElseIf TextBox1.Text = "driver booster" Then
            Iobit_Driver_Booster.Show
        ElseIf TextBox1.Text = "Iobit Uninstaller" Then
            IObit_Unistaller.Show
        ElseIf TextBox1.Text = "iobit uninstaller" Then
            IObit_Unistaller.Show
        ElseIf TextBox1.Text = "Hwmonitor" Then
            Hwmonitor.Show
        ElseIf TextBox1.Text = "hwmonitor" Then
            Hwmonitor.Show
        ElseIf TextBox1.Text = "7Zip" Then
            _7zip.Show
        ElseIf TextBox1.Text = "7zip" Then
            _7zip.Show
        ElseIf TextBox1.Text = "Notepad++" Then
            Notepad__.Show
        ElseIf TextBox1.Text = "notepad++" Then
            Notepad__.Show()
        ElseIf TextBox1.Text = "Discord" Then
            Discord.Show
        ElseIf TextBox1.Text = "discord" Then
            Discord.Show
        ElseIf TextBox1.Text = "Steam" Then
            Steam.Show
        ElseIf TextBox1.Text = "steam" Then
            Steam.Show
        ElseIf TextBox1.Text = "Virtualbox" Then
            Virtualbox.Show
        ElseIf TextBox1.Text = "virtualbox" Then
            Virtualbox.Show
        ElseIf TextBox1.Text = "Vmware Player" Then
            Vmware.Show
        ElseIf TextBox1.Text = "vmware player" Then
            Vmware.Show
        ElseIf TextBox1.Text = "Sky Go" Then
            Sky_Go.Show
        ElseIf TextBox1.Text = "sky go" Then
            Sky_Go.Show
        ElseIf TextBox1.Text = "Ccleaner" Then
            Ccleaner.Show
        ElseIf TextBox1.Text = "ccleaner" Then
            Ccleaner.Show
        ElseIf TextBox1.Text = "Google Drive" Then
            Google_Drive.Show
        ElseIf TextBox1.Text = "google drive" Then
            Google_Drive.Show
        ElseIf TextBox1.Text = "Obs" Then
            Obs.Show
        ElseIf TextBox1.Text = "obs" Then
            Obs.Show
        ElseIf TextBox1.Text = "Flowgorithm" Then
            Flowgorithm.Show()
        ElseIf TextBox1.Text = "flowgorithm" Then
            Flowgorithm.Show()
        ElseIf TextBox1.Text = "Teamviewer" Then
            Teamviewer.Show
        ElseIf TextBox1.Text = "teamviewer" Then
            Teamviewer.Show
        ElseIf TextBox1.Text = "Soft Optimizer" Then
            Soft_Optimizer.Show
        ElseIf TextBox1.Text = "soft optimizer" Then
            Soft_Optimizer.Show
        ElseIf TextBox1.Text = "Gimp" Then
            Gimp.Show()
        ElseIf TextBox1.Text = "gimp" Then
            Gimp.Show
        ElseIf TextBox1.Text = "Adobe Acrobat Reader" Then
            Abobe_Acrobat_Reader.Show
        ElseIf TextBox1.Text = "adobe acrobat reader" Then
            Abobe_Acrobat_Reader.Show
        ElseIf TextBox1.Text = "Audacity" Then
            Audacity.Show
        ElseIf TextBox1.Text = "audacity" Then
            Audacity.Show
        ElseIf TextBox1.Text = "Install Creator" Then
            Install_Creator.Show
        ElseIf TextBox1.Text = "install creator" Then
            Install_Creator.Show
        ElseIf TextBox1.Text = "Shotcut" Then
            Shotcut.Show
        ElseIf TextBox1.Text = "shotcut" Then
            Shotcut.Show
        ElseIf TextBox1.Text = "Trading View" Then
            Trading_View.Show
        ElseIf TextBox1.Text = "trading view" Then
            Trading_View.Show
        ElseIf TextBox1.Text = "Logitech G Hub" Then
            Logitech_G_Hub.Show
        ElseIf TextBox1.Text = "logitech g hub" Then
            Logitech_G_Hub.Show
        ElseIf TextBox1.Text = "Anydesk" Then
            Anydesk.Show
        ElseIf TextBox1.Text = "anydesk" Then
            Anydesk.Show()
        ElseIf TextBox1.Text = "Opera" Then
            Opera.Show
        ElseIf TextBox1.Text = "opera" Then
            Opera.Show
        ElseIf TextBox1.Text = "Opera Gx" Then
            Opera_Gx.Show
        ElseIf TextBox1.Text = "opera gx" Then
            Opera_Gx.Show
        ElseIf TextBox1.Text = "Vivaldi" Then
            Vivaldi.Show
        ElseIf TextBox1.Text = "vivaldi" Then
            Vivaldi.Show
        ElseIf TextBox1.Text = "Opera Crypto Browser" Then
            OperaCB.Show
        ElseIf TextBox1.Text = "opera crypto browser" Then
            OperaCB.Show
        ElseIf TextBox1.Text = "Onlyoffice" Then
            OnlyOffice.Show
        ElseIf TextBox1.Text = "onlyoffice" Then
            OnlyOffice.Show
        ElseIf TextBox1.Text = "Rufus" Then
            Rufus.Show
        ElseIf TextBox1.Text = "rufus" Then
            Rufus.Show()
        ElseIf TextBox1.Text = "Python" Then
            Python.Show
        ElseIf TextBox1.Text = "python" Then
            Python.Show
        ElseIf TextBox1.Text = "Davinci Resolve" Then
            Davinci_Resolve.Show
        ElseIf TextBox1.Text = "davinci resolve" Then
            Davinci_Resolve.Show
        ElseIf TextBox1.Text = "Openshot" Then
            Openshot.Show
        ElseIf TextBox1.Text = "openshot" Then
            Openshot.Show
        ElseIf TextBox1.Text = "Driver Easy" Then
            Driver_Easy.Show
        ElseIf TextBox1.Text = "driver easy" Then
            Driver_Easy.Show
        ElseIf TextBox1.Text = "Iobit Malware Fighter" Then
            Iobit_Malware_Fighter.Show()
        ElseIf TextBox1.Text = "iobit malware fighter" Then
            Iobit_Malware_Fighter.Show
        ElseIf TextBox1.Text = "Iobit Software Updater" Then
            IObit_Software_Updater.Show()
        ElseIf textbox1.Text = "iobit software updater" Then
            IObit_Software_Updater.Show()
        ElseIf TextBox1.Text = "Soft Usb Passwords" Then
            Soft_Usb_Passwords.Show
        ElseIf TextBox1.Text = "soft usb passwords" Then
            Soft_Usb_Passwords.Show()
        ElseIf TextBox1.Text = "Nox" Then
            Nox_Player.Show
        ElseIf TextBox1.Text = "nox" Then
            Nox_Player.Show
        ElseIf TextBox1.Text = "Telegram" Then
            Telegram.Show
        ElseIf TextBox1.Text = "telegram" Then
            Telegram.Show
        ElseIf TextBox1.Text = "Dev C++" Then
            Dev_C__.Show
        ElseIf TextBox1.Text = "dev c++" Then
            Dev_C__.Show
        ElseIf TextBox1.Text = "Algobuild" Then
            AlgoBuild.Show
        ElseIf TextBox1.Text = "algobuild" Then
            AlgoBuild.Show
        ElseIf TextBox1.Text = "Crystaldiskmark" Then
            Crystaldiskmark.Show
        ElseIf TextBox1.Text = "crystaldiskmark" Then
            Crystaldiskmark.Show
        ElseIf TextBox1.Text = "Crystaldiskinfo" Then
            Crystaldiskinfo.Show
        ElseIf TextBox1.Text = "crystaldiskinfo" Then
            Crystaldiskinfo.Show()
        ElseIf TextBox1.Text = "Obs Streamlabs" Then
            Zoom.Show()
        ElseIf TextBox1.Text = "obs streamlabs" Then
            Zoom.Show
        ElseIf TextBox1.Text = "Vlc" Then
            Vlc.Show
        ElseIf TextBox1.Text = "vlc" Then
            Vlc.Show
        ElseIf TextBox1.Text = "Epic Games Launcher" Then
            Epic_Games_Launcher.Show

        ElseIf TextBox1.Text = "epic games launcher" Then
            Epic_Games_Launcher.Show
        ElseIf TextBox1.Text = "Discord Canary" Then
            Battlenet.Show()
        ElseIf TextBox1.Text = "discord canary" Then
            Battlenet.Show
        ElseIf TextBox1.Text = "Chrome Canary" Then
            Chrome_Canary.Show()
        ElseIf TextBox1.Text = "chrome canary" Then
            Chrome_Canary.Show
        ElseIf TextBox1.Text = "Notion" Then
            Notion.Show()
        ElseIf TextBox1.Text = "notion" Then
            Notion.Show()
        ElseIf TextBox1.Text = "Nvidia Geforce Experience" Then
            Nvidia_Geforce_Experience.Show
        ElseIf TextBox1.Text = "nvidia geforce experience" Then
            Nvidia_Geforce_Experience.Show
        ElseIf TextBox1.Text = "Filezilla Client" Then
            Filezilla_Server.Show
        ElseIf TextBox1.Text = "filezilla client" Then
            Filezilla_Server.Show
        ElseIf TextBox1.Text = "Filezilla Server" Then
            Filezilla_Ser.Show
        ElseIf TextBox1.Text = "filezilla server" Then
            Filezilla_Ser.Show
        ElseIf TextBox1.Text = "Iobit Advanced System Care" Then
            Advanced_Systemcare.Show()
        ElseIf TextBox1.Text = "iobit advanced system care" Then
            Advanced_Systemcare.Show
        ElseIf TextBox1.Text = "Iobit Smart Defrag" Then
            Smart_Defrag.Show()
        ElseIf TextBox1.Text = "iobit smart defrag" Then
            Smart_Defrag.Show
        ElseIf TextBox1.Text = "Iobit Protected Folder" Then
            Iobit_Protected_Folder.Show
        ElseIf TextBox1.Text = "iobit protected folder" Then
            Iobit_Protected_Folder.Show
        ElseIf TextBox1.Text = "Itop Vpn" Then
            Itop_Vpn.Show
        ElseIf TextBox1.Text = "itop vpn" Then
            Itop_Vpn.Show
        ElseIf TextBox1.Text = "Droidcam" Then
            Droidcam.Show
        ElseIf TextBox1.Text = "droidcam" Then
            Droidcam.Show
        ElseIf TextBox1.Text = "Openoffice" Then
            OpenOffice.Show
        ElseIf TextBox1.Text = "openoffice" Then
            OpenOffice.Show
        ElseIf TextBox1.Text = "Ps Remote Play" Then
            Ps_Remote_Play.Show()
        ElseIf TextBox1.Text = "ps remote play" Then
            Ps_Remote_Play.Show
        ElseIf TextBox1.Text = "Itunes" Then
            Itunes.Show
        ElseIf TextBox1.Text = "itunes" Then
            Itunes.Show
        ElseIf TextBox1.Text = "Docker" Then
            Docker.Show
        ElseIf TextBox1.Text = "docker" Then
            Docker.Show
        ElseIf TextBox1.Text = "Avast" Then
            Avast.Show
        ElseIf TextBox1.Text = "avast" Then
            Avast.Show
        ElseIf TextBox1.Text = "Malwarebytes" Then
            MalwareBytes.Show
        ElseIf TextBox1.Text = "malwarebytes" Then
            MalwareBytes.Show()
        ElseIf TextBox1.Text = "Avg" Then
            Avg.Show()
        ElseIf TextBox1.Text = "avg" Then
            Avg.Show
        ElseIf TextBox1.Text = "Tunnel Bear" Then
            Tunnelbear.Show()
        ElseIf TextBox1.Text = "tunnel bear" Then
            Tunnelbear.Show
        ElseIf TextBox1.Text = "Vim" Then
            Vim.Show
        ElseIf TextBox1.Text = "vim" Then
            Vim.Show
        ElseIf TextBox1.Text = "Node Js" Then
            Node_Js.Show
        ElseIf TextBox1.Text = "node js" Then
            Node_Js.Show
        ElseIf TextBox1.Text = "Mega Sync" Then
            Mega_Sync.Show
        ElseIf TextBox1.text = "mega sync" Then
            Mega_Sync.Show()
        ElseIf TextBox1.Text = "Smart Game Booster" Then
            Smart_Game_Booster.Show
        ElseIf TextBox1.Text = "smart game booster" Then
            Smart_Game_Booster.Show
        ElseIf Textbox1.Text = "Balena Etcher" Then
            Balena_Etcher.Show
        ElseIf TextBox1.Text = "balena etcher" Then
            Balena_Etcher.Show
        ElseIf TextBox1.Text = "Deskreen" Then
            Deskreen.Show
        ElseIf Textbox1.Text = "deskreen" Then
            Deskreen.Show
        ElseIf TextBox1.Text = "Vera Crypt" Then
            Vera_Crypt.Show
        ElseIf TextBox1.Text = "vera crypt" Then
            Vera_Crypt.Show
        ElseIf TextBox1.Text = "Greenshot" Then
            Greenshot.Show
        ElseIf TextBox1.Text = "greenshot" Then
            Greenshot.Show
        ElseIf TextBox1.Text = "File Converter" Then
            File_Converter.Show()
        ElseIf TextBox1.Text = "file converter" Then
            File_Converter.Show
        ElseIf TextBox1.Text = "Edge Dev" Then
            Edge_Dev.Show
        ElseIf TextBox1.Text = "edge dev" Then
            Edge_Dev.Show
        ElseIf TextBox1.Text = "Edge Beta" Then
            Edge_Beta.Show
        ElseIf TextBox1.Text = "edge beta" Then
            Edge_Beta.Show()
        ElseIf TextBox1.Text = "Cpu Z" Then
            Cpu_Z.Show
        ElseIf TextBox1.Text = "cpu z" Then
            Cpu_Z.Show
        ElseIf TextBox1.Text = "Geekbench" Then
            GeekBench.Show
        ElseIf TextBox1.Text = "geekbench" Then
            GeekBench.Show
        ElseIf TextBox1.Text = "Soft Files Encrypted" Then
            Soft_Files_Encrypted.Show
        ElseIf TextBox1.Text = "soft files encrypted" Then
            Soft_Files_Encrypted.Show
        ElseIf TextBox1.Text = "Utorrent" Then
            Uttorent.Show
        ElseIf TextBox1.Text = "utorrent" Then
            Uttorent.Show
        ElseIf TextBox1.Text = "Bluestacks" Then
            BlueStacks.Show
        ElseIf TextBox1.Text = "bluestacks" Then
            BlueStacks.Show
        ElseIf TextBox1.Text = "Proton Vpn" Then
            Proton_Vpn.Show
        ElseIf TextBox1.Text = "proton vpn" Then
            Proton_Vpn.Show
        ElseIf TextBox1.Text = "Everything" Then
            Everything.Show
        ElseIf TextBox1.Text = "everything" Then
            Everything.Show
        ElseIf TextBox1.Text = "Patch My Pc" Then
            Patch_my_pc.Show()
        ElseIf TextBox1.Text = "patch my pc" Then
            Patch_my_pc.Show
        ElseIf TextBox1.Text = "Revo Uninstaller" Then
            Revo_Uninstaller.Show
        ElseIf TextBox1.Text = "revo uninstaller" Then
            Revo_Uninstaller.Show()
        ElseIf TextBox1.Text = "Share X" Then
            Share_X.Show
        ElseIf TextBox1.Text = "share x" Then
            Share_X.Show
        ElseIf TextBox1.Text = "Wiztree" Then
            Wiztree.Show
        ElseIf TextBox1.Text = "wiztree" Then
            Wiztree.Show()
        ElseIf TextBox1.Text = "Bit Warden" Then
            Bitwarden.Show
        ElseIf TextBox1.Text = "bit warden" Then
            Bitwarden.Show()
        ElseIf TextBox1.Text = "Encrypto" Then
            Encrypto.Show
        ElseIf TextBox1.Text = "encrypto" Then
            Encrypto.Show
        ElseIf TextBox1.Text = "Capcut" Then
            Capcut.Show
        ElseIf TextBox1.Text = "capcut" Then
            Capcut.Show()
        ElseIf TextBox1.Text = "Brave" Then
            Brave.Show()
        ElseIf TextBox1.Text = "brave" Then
            Brave.Show


        Else
            MsgBox("L'elemento inserito da tastiera non corrisponde a nessun pacchetto")
        End If
    End Sub

    Private Sub Vsc_Click(sender As Object, e As EventArgs) Handles Vsc.Click

    End Sub
End Class
