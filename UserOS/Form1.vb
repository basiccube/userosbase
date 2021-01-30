Public Class Form1

    Private newpoint As System.Drawing.Point
    Private xpos1 As Integer
    Private ypos1 As Integer

    Private Sub pnlTopBorder_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles pnlTopBorder.MouseDown
        xpos1 = MousePosition.X - Location.X
        ypos1 = MousePosition.Y - Location.Y
    End Sub

    Private Sub pnlTopBorder_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles pnlTopBorder.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = MousePosition
            newpoint.X -= xpos1
            newpoint.Y -= ypos1
            Location = newpoint
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Hide()
        Close()
    End Sub

    Private Sub windborder_Paint(sender As Object, e As PaintEventArgs) Handles windborder.Paint

    End Sub
End Class