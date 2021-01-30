Public Class TextEditor

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
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Hide()
        Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Hide()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.ResizeRedraw, True)
        MaximumSize = Screen.FromRectangle(Bounds).WorkingArea.Size
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        e.Graphics.FillRectangle(Brushes.Gray, Topborder)
        e.Graphics.FillRectangle(Brushes.Gray, Leftborder)
        e.Graphics.FillRectangle(Brushes.Gray, Rightborder)
        e.Graphics.FillRectangle(Brushes.Gray, Bottomborder)
    End Sub


    Private Const HTLEFT As Integer = 10, HTRIGHT As Integer = 11, HTTOP As Integer = 12, HTTOPLEFT As Integer = 13, HTTOPRIGHT As Integer = 14, HTBOTTOM As Integer = 15, HTBOTTOMLEFT As Integer = 16, HTBOTTOMRIGHT As Integer = 17

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)
        If m.Msg = &H84 Then
            Dim mp = Me.PointToClient(Cursor.Position)

            If TopLeftborder.Contains(mp) Then
                m.Result = CType(HTTOPLEFT, IntPtr)
            ElseIf TopRightborder.Contains(mp) Then
                m.Result = CType(HTTOPRIGHT, IntPtr)
            ElseIf BottomLeftborder.Contains(mp) Then
                m.Result = CType(HTBOTTOMLEFT, IntPtr)
            ElseIf BottomRightborder.Contains(mp) Then
                m.Result = CType(HTBOTTOMRIGHT, IntPtr)
            ElseIf Topborder.Contains(mp) Then
                m.Result = CType(HTTOP, IntPtr)
            ElseIf Leftborder.Contains(mp) Then
                m.Result = CType(HTLEFT, IntPtr)
            ElseIf Rightborder.Contains(mp) Then
                m.Result = CType(HTRIGHT, IntPtr)
            ElseIf Bottomborder.Contains(mp) Then
                m.Result = CType(HTBOTTOM, IntPtr)
            End If
        End If
    End Sub

    Private Const ImaginaryBorderSize As Integer = 16

    Public Function Topborder() As Rectangle
        Return New Rectangle(0, 0, Me.ClientSize.Width, ImaginaryBorderSize)
    End Function

    Public Function Leftborder() As Rectangle
        Return New Rectangle(0, 0, ImaginaryBorderSize, Me.ClientSize.Height)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If WindowState <> FormWindowState.Maximized Then
            WindowState = FormWindowState.Maximized
            Button1.Text = "2"
            pnlTopBorder.Width = Width
            TextBox1.Width = Width
            TextBox1.Height = Height - 30
            TextBox1.Location = New Point(0, 30)
            pnlTopBorder.Location = New Point(0, 0)
            pnlTopBorder.Height = 30
        Else
            WindowState = FormWindowState.Normal
            Button1.Text = "1"
            pnlTopBorder.Width = Width - 4
            TextBox1.Width = Width - 4
            TextBox1.Height = Height - 32
            TextBox1.Location = New Point(2, 30)
            pnlTopBorder.Location = New Point(2, 2)
            pnlTopBorder.Height = 28
        End If
    End Sub

    Public Function Bottomborder() As Rectangle
        Return New Rectangle(0, Me.ClientSize.Height - ImaginaryBorderSize, Me.ClientSize.Width, ImaginaryBorderSize)
    End Function

    Public Function Rightborder() As Rectangle
        Return New Rectangle(Me.ClientSize.Width - ImaginaryBorderSize, 0, ImaginaryBorderSize, Me.ClientSize.Height)
    End Function

    Public Function TopLeftborder() As Rectangle
        Return New Rectangle(0, 0, ImaginaryBorderSize, ImaginaryBorderSize)
    End Function

    Public Function TopRightborder() As Rectangle
        Return New Rectangle(Me.ClientSize.Width - ImaginaryBorderSize, 0, ImaginaryBorderSize, ImaginaryBorderSize)
    End Function

    Public Function BottomLeftborder() As Rectangle
        Return New Rectangle(0, Me.ClientSize.Height - ImaginaryBorderSize, ImaginaryBorderSize, ImaginaryBorderSize)
    End Function

    Public Function BottomRightborder() As Rectangle
        Return New Rectangle(Me.ClientSize.Width - ImaginaryBorderSize, Me.ClientSize.Height - ImaginaryBorderSize, ImaginaryBorderSize, ImaginaryBorderSize)
    End Function

    Private Sub Main_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        pnlTopBorder.Width = Width - 4
        TextBox1.Width = Width - 4
        TextBox1.Height = Height - 32
        If WindowState = FormWindowState.Maximized Then
            pnlTopBorder.Width = Width
            TextBox1.Width = Width
            TextBox1.Height = Height
        End If
    End Sub
End Class