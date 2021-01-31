Public Class Openlist

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
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Hide()
        Close()
    End Sub

    Private Sub WindowRefresh_Click(sender As Object, e As EventArgs) Handles WindowRefresh.Click
        Dim Prog As FormCollection = Application.OpenForms
        WindowList.Items.Clear()
        WindowSwitch.Enabled = True
        WindowEnd.Enabled = True

        For Each notprog As Form In Prog
            WindowList.Items.Add(notprog.Name.ToString)
        Next
    End Sub

    Private Sub WindowSwitch_Click(sender As Object, e As EventArgs) Handles WindowSwitch.Click
        Dim Openprog As Form = Application.OpenForms(WindowList.Text)
        If Not WindowList.SelectedIndex = -1 Then
            If IsFormOpen(Openprog) Then
                Openprog.Show()
                Openprog.BringToFront()
            Else
                OpenListErr.Show()
                WindowSwitch.Enabled = False
                WindowEnd.Enabled = False
            End If
        End If
    End Sub

    Private Sub WindowEnd_Click(sender As Object, e As EventArgs) Handles WindowEnd.Click
        Dim Openprog As Form = Application.OpenForms(WindowList.Text)
        If Not WindowList.SelectedIndex = -1 Then
            If IsFormOpen(Openprog) Then
                Openprog.Hide()
                Openprog.Close()
                WindowList.Items.Remove(Openprog.Name)
            Else
                OpenListErr.Show()
                WindowSwitch.Enabled = False
                WindowEnd.Enabled = False
            End If
        End If
    End Sub
    Private Sub WindowList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WindowList.SelectedIndexChanged
        If WindowList.SelectedItem = GUIDesktop.Name Or WindowList.SelectedItem = Name Then
            WindowSwitch.Enabled = False
            WindowEnd.Enabled = False
        Else
            WindowSwitch.Enabled = True
            WindowEnd.Enabled = True
        End If
    End Sub
End Class