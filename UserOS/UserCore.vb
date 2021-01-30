Public Class UserCore
    Public Function IsFormOpen(ByVal frm As Form) As Boolean
        If Application.OpenForms.OfType(Of Form).Contains(frm) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private newpoint As System.Drawing.Point
    Private xpos1 As Integer
    Private ypos1 As Integer

    Private Sub pnlTopBorder_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles pnlTopBorder.MouseDown
        xpos1 = Control.MousePosition.X - Me.Location.X
        ypos1 = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub pnlTopBorder_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles pnlTopBorder.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (xpos1)
            newpoint.Y -= (ypos1)
            Me.Location = newpoint
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

    Private Sub UserCore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Hide()
        Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Hide()
    End Sub
End Class
