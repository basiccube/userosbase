Friend Module startup
    Public Sub Main()
        Application.EnableVisualStyles()
        If My.Settings.FirstTime = True Then
            UserCore.Hide()
            GUIDesktop.Hide()
            setup.Show()
        End If
        If My.Settings.FirstTime = False Then
            setup.Hide()
            If My.Settings.StartGUI = True Then
                GUIDesktop.Show()
                UserCore.Hide()
            End If
            If My.Settings.StartGUI = False Then
                GUIDesktop.Hide()
                UserCore.Show()
            End If
        End If
        GUIDesktop.BackColor = My.Settings.GUIDeskColor
        Application.Run()
        Application.DoEvents()
    End Sub


End Module
