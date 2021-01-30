Public Class setup

    Private newpoint As Point
    Private xpos1 As Integer
    Private ypos1 As Integer

    Private Sub PnlTopBorder_MouseDown(sender As Object, e As MouseEventArgs) Handles PnlTopBorder.MouseDown
        xpos1 = MousePosition.X - Location.X
        ypos1 = MousePosition.Y - Location.Y
    End Sub

    Private Sub PnlTopBorder_MouseMove(sender As Object, e As MouseEventArgs) Handles PnlTopBorder.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = MousePosition
            newpoint.X -= xpos1
            newpoint.Y -= ypos1
            Location = newpoint
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Settingspanel.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        UserCore.Show()
        My.Settings.FirstTime = False
        My.Settings.Save()
        Hide()
        Close()
    End Sub

    Private Sub setup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PnlTopBorder_Paint(sender As Object, e As PaintEventArgs) Handles PnlTopBorder.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class