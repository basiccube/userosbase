Friend Module startup
    Public Sub Main()
        Application.EnableVisualStyles()
        If My.Settings.FirstTime = True Then
            GUIDesktop.Hide()
            setup.Show()
        End If
        If My.Settings.FirstTime = False Then
            setup.Hide()
            GUIDesktop.Show()
        End If
        GUIDesktop.BackColor = My.Settings.GUIDeskColor
        Application.Run()
        Application.DoEvents()
    End Sub


End Module
