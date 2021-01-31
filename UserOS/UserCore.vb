Public Class UserCore
    Public Function IsFormOpen(frm As Form) As Boolean
        Return Application.OpenForms.OfType(Of Form).Contains(frm)
    End Function

    Private newpoint As Point
    Private xpos1 As Integer
    Private ypos1 As Integer

    Private Sub PnlTopBorder_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTopBorder.MouseDown
        xpos1 = MousePosition.X - Location.X
        ypos1 = MousePosition.Y - Location.Y
    End Sub

    Private Sub PnlTopBorder_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlTopBorder.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = MousePosition
            newpoint.X -= xpos1
            newpoint.Y -= ypos1
            Location = newpoint
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "startdesk" Then
            GUIDesktop.Show()
            Hide()
            Close()
        End If
        If TextBox1.Text = "shellhelp" Then
            UserCoreShell.Show()
        End If
        If TextBox1.Text = "gfxpanel" Then
            Settingspanel.Show()
        End If
        If TextBox1.Text = "gfxnote" Then
            TextEditor.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AboutUserOS.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Hide()
        Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Hide()
    End Sub
End Class
