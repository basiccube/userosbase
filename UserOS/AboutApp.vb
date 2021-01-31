﻿Public Class AboutApp

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
        Hide()
        Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Hide()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
    End Sub
End Class