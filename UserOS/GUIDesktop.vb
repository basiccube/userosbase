Public Class GUIDesktop
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        UserCore.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Settingspanel.Show()
    End Sub
    Private Sub SettingsPanelToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SettingsPanelToolStripMenuItem1.Click
        Settingspanel.Show()
    End Sub

    Private Sub MiniNoteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MiniNoteToolStripMenuItem1.Click
        TextEditor.Show()
    End Sub

    Private Sub AboutUserOSToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutUserOSToolStripMenuItem1.Click
        AboutUserOS.Show()
    End Sub

    Private Sub UserCoreShellToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UserCoreShellToolStripMenuItem1.Click
        UserCore.Show()
    End Sub

    Private Sub GUIDesktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = My.Settings.GUIDeskColor
    End Sub

    Private Sub AppGetMenu_Click(sender As Object, e As EventArgs) Handles AppGetMenu.Click
        userAppGet.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Openlist.Show()
    End Sub

    Private Sub RestartUserOSToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RestartUserOSToolStripMenuItem1.Click
        Application.Restart()
    End Sub

    Private Sub ExitUserOSToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles ExitUserOSToolStripMenuItem1.Click
        My.Settings.Save()
        Application.Exit()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Protected Overrides Sub WndProc(ByRef m As Message)
        Dim org As FormWindowState = WindowState
        MyBase.WndProc(m)
        If WindowState <> org Then OnFormWindowStateChanged(EventArgs.Empty)
    End Sub

    Protected Overridable Sub OnFormWindowStateChanged(e As EventArgs)
        Dim minform As FormCollection = Application.OpenForms
        If WindowState = FormWindowState.Minimized Then
            For Each minformed As Form In minform
                If minformed.Name <> Name Then
                    minformed.Hide()
                End If
            Next
        End If
        If WindowState = FormWindowState.Maximized Then
            For Each minformed As Form In minform
                If minformed.Name <> Name Then
                    minformed.Show()
                End If
            Next
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Openlist.Show()
    End Sub
End Class