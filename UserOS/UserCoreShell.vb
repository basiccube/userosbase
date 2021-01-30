Public Class UserCoreShell

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
        Hide()
        Close()
    End Sub

    Private Sub pnlTopBorder_Paint(sender As Object, e As PaintEventArgs) Handles pnlTopBorder.Paint

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Hide()
        Close()
    End Sub
End Class