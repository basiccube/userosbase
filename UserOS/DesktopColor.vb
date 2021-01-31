Public Class DesktopColor

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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Label2.Text = "Red" Then
            My.Settings.GUIDeskColor = Color.DarkRed
            My.Settings.Save()
            GUIDesktop.BackColor = My.Settings.GUIDeskColor
            Hide()
            Close()
        End If
        If Label2.Text = "Black" Then
            My.Settings.GUIDeskColor = Color.Black
            My.Settings.Save()
            GUIDesktop.BackColor = My.Settings.GUIDeskColor
            Hide()
            Close()
        End If
        If Label2.Text = "Gray" Then
            My.Settings.GUIDeskColor = Color.DimGray
            My.Settings.Save()
            GUIDesktop.BackColor = My.Settings.GUIDeskColor
            Hide()
            Close()
        End If
        If Label2.Text = "Green" Then
            My.Settings.GUIDeskColor = Color.Green
            My.Settings.Save()
            GUIDesktop.BackColor = My.Settings.GUIDeskColor
            Hide()
            Close()
        End If
        If Label2.Text = "Teal" Then
            My.Settings.GUIDeskColor = Color.Teal
            My.Settings.Save()
            GUIDesktop.BackColor = My.Settings.GUIDeskColor
            Hide()
            Close()
        End If
        If Label2.Text = "Blue" Then
            My.Settings.GUIDeskColor = Color.SteelBlue
            My.Settings.Save()
            GUIDesktop.BackColor = My.Settings.GUIDeskColor
            Hide()
            Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = "Red"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Text = "Black"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label2.Text = "Gray"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Label2.Text = "Green"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label2.Text = "Teal"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label2.Text = "Blue"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Hide()
        Close()
    End Sub
End Class