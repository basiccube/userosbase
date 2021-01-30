<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GUIDesktop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUIDesktop))
        Me.Useraccessbar = New System.Windows.Forms.MenuStrip()
        Me.ApplicationsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiniNoteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppGetMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsPanelToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserCoreShellToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUserOSToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartUserOSToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitUserOSToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplicationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiniNoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuickOpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserCoreShellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutUserOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RestartUserOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToShellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitUserOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Useraccessbar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Useraccessbar
        '
        Me.Useraccessbar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Useraccessbar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Useraccessbar.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Useraccessbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplicationsToolStripMenuItem1, Me.SystemToolStripMenuItem1})
        Me.Useraccessbar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.Useraccessbar.Location = New System.Drawing.Point(0, 349)
        Me.Useraccessbar.Name = "Useraccessbar"
        Me.Useraccessbar.Size = New System.Drawing.Size(650, 40)
        Me.Useraccessbar.TabIndex = 0
        Me.Useraccessbar.Text = "User Access Bar"
        '
        'ApplicationsToolStripMenuItem1
        '
        Me.ApplicationsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MiniNoteToolStripMenuItem1, Me.AppGetMenu})
        Me.ApplicationsToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.ApplicationsToolStripMenuItem1.Image = Global.userOS.My.Resources.Resources.menu_app1
        Me.ApplicationsToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ApplicationsToolStripMenuItem1.Name = "ApplicationsToolStripMenuItem1"
        Me.ApplicationsToolStripMenuItem1.Padding = New System.Windows.Forms.Padding(0)
        Me.ApplicationsToolStripMenuItem1.Size = New System.Drawing.Size(131, 36)
        Me.ApplicationsToolStripMenuItem1.Text = "Applications"
        Me.ApplicationsToolStripMenuItem1.ToolTipText = "Contains your applications."
        '
        'MiniNoteToolStripMenuItem1
        '
        Me.MiniNoteToolStripMenuItem1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MiniNoteToolStripMenuItem1.Image = Global.userOS.My.Resources.Resources.texteditor_menu1
        Me.MiniNoteToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MiniNoteToolStripMenuItem1.Name = "MiniNoteToolStripMenuItem1"
        Me.MiniNoteToolStripMenuItem1.Size = New System.Drawing.Size(201, 38)
        Me.MiniNoteToolStripMenuItem1.Text = "userEdit"
        '
        'AppGetMenu
        '
        Me.AppGetMenu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.AppGetMenu.Image = Global.userOS.My.Resources.Resources.appget_menu2
        Me.AppGetMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AppGetMenu.Name = "AppGetMenu"
        Me.AppGetMenu.Size = New System.Drawing.Size(201, 38)
        Me.AppGetMenu.Text = "userOS AppGet"
        '
        'SystemToolStripMenuItem1
        '
        Me.SystemToolStripMenuItem1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SystemToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsPanelToolStripMenuItem1, Me.UserCoreShellToolStripMenuItem1, Me.AboutUserOSToolStripMenuItem1, Me.ExitMenu})
        Me.SystemToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.SystemToolStripMenuItem1.Image = Global.userOS.My.Resources.Resources.menu_sys
        Me.SystemToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SystemToolStripMenuItem1.Name = "SystemToolStripMenuItem1"
        Me.SystemToolStripMenuItem1.Padding = New System.Windows.Forms.Padding(0)
        Me.SystemToolStripMenuItem1.Size = New System.Drawing.Size(94, 36)
        Me.SystemToolStripMenuItem1.Text = "System"
        Me.SystemToolStripMenuItem1.ToolTipText = "Contains various system functions."
        '
        'SettingsPanelToolStripMenuItem1
        '
        Me.SettingsPanelToolStripMenuItem1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SettingsPanelToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.SettingsPanelToolStripMenuItem1.Image = Global.userOS.My.Resources.Resources.settingspanel_menu
        Me.SettingsPanelToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SettingsPanelToolStripMenuItem1.Name = "SettingsPanelToolStripMenuItem1"
        Me.SettingsPanelToolStripMenuItem1.Padding = New System.Windows.Forms.Padding(0)
        Me.SettingsPanelToolStripMenuItem1.Size = New System.Drawing.Size(196, 36)
        Me.SettingsPanelToolStripMenuItem1.Text = "Settings"
        '
        'UserCoreShellToolStripMenuItem1
        '
        Me.UserCoreShellToolStripMenuItem1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.UserCoreShellToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.UserCoreShellToolStripMenuItem1.Image = Global.userOS.My.Resources.Resources.usercore_menu
        Me.UserCoreShellToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UserCoreShellToolStripMenuItem1.Name = "UserCoreShellToolStripMenuItem1"
        Me.UserCoreShellToolStripMenuItem1.Padding = New System.Windows.Forms.Padding(0)
        Me.UserCoreShellToolStripMenuItem1.Size = New System.Drawing.Size(196, 36)
        Me.UserCoreShellToolStripMenuItem1.Text = "userCore Shell"
        '
        'AboutUserOSToolStripMenuItem1
        '
        Me.AboutUserOSToolStripMenuItem1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.AboutUserOSToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.AboutUserOSToolStripMenuItem1.Image = Global.userOS.My.Resources.Resources.menu_sys
        Me.AboutUserOSToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AboutUserOSToolStripMenuItem1.Name = "AboutUserOSToolStripMenuItem1"
        Me.AboutUserOSToolStripMenuItem1.Padding = New System.Windows.Forms.Padding(0)
        Me.AboutUserOSToolStripMenuItem1.Size = New System.Drawing.Size(196, 36)
        Me.AboutUserOSToolStripMenuItem1.Text = "About userOS"
        '
        'ExitMenu
        '
        Me.ExitMenu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ExitMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestartUserOSToolStripMenuItem1, Me.ToolStripMenuItem1, Me.ExitUserOSToolStripMenuItem1})
        Me.ExitMenu.ForeColor = System.Drawing.Color.Black
        Me.ExitMenu.Image = Global.userOS.My.Resources.Resources.exit_menu
        Me.ExitMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExitMenu.Name = "ExitMenu"
        Me.ExitMenu.Padding = New System.Windows.Forms.Padding(0)
        Me.ExitMenu.Size = New System.Drawing.Size(196, 36)
        Me.ExitMenu.Text = "Exit"
        '
        'RestartUserOSToolStripMenuItem1
        '
        Me.RestartUserOSToolStripMenuItem1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RestartUserOSToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.RestartUserOSToolStripMenuItem1.Image = Global.userOS.My.Resources.Resources.restart_menu
        Me.RestartUserOSToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RestartUserOSToolStripMenuItem1.Name = "RestartUserOSToolStripMenuItem1"
        Me.RestartUserOSToolStripMenuItem1.Padding = New System.Windows.Forms.Padding(0)
        Me.RestartUserOSToolStripMenuItem1.Size = New System.Drawing.Size(196, 36)
        Me.RestartUserOSToolStripMenuItem1.Text = "Restart"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem1.Image = Global.userOS.My.Resources.Resources.exit_menu
        Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(196, 36)
        Me.ToolStripMenuItem1.Text = "Minimize"
        '
        'ExitUserOSToolStripMenuItem1
        '
        Me.ExitUserOSToolStripMenuItem1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ExitUserOSToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.ExitUserOSToolStripMenuItem1.Image = Global.userOS.My.Resources.Resources.exit_menu
        Me.ExitUserOSToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExitUserOSToolStripMenuItem1.Name = "ExitUserOSToolStripMenuItem1"
        Me.ExitUserOSToolStripMenuItem1.Padding = New System.Windows.Forms.Padding(0)
        Me.ExitUserOSToolStripMenuItem1.Size = New System.Drawing.Size(196, 36)
        Me.ExitUserOSToolStripMenuItem1.Text = "Quit"
        '
        'ApplicationsToolStripMenuItem
        '
        Me.ApplicationsToolStripMenuItem.Name = "ApplicationsToolStripMenuItem"
        Me.ApplicationsToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.ApplicationsToolStripMenuItem.Text = "Applications"
        '
        'MiniNoteToolStripMenuItem
        '
        Me.MiniNoteToolStripMenuItem.Name = "MiniNoteToolStripMenuItem"
        Me.MiniNoteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MiniNoteToolStripMenuItem.Text = "MiniNote"
        '
        'QuickOpenToolStripMenuItem
        '
        Me.QuickOpenToolStripMenuItem.Name = "QuickOpenToolStripMenuItem"
        Me.QuickOpenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.QuickOpenToolStripMenuItem.Text = "QuickOpen"
        '
        'SystemToolStripMenuItem
        '
        Me.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem"
        Me.SystemToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.SystemToolStripMenuItem.Text = "System"
        '
        'SettingsPanelToolStripMenuItem
        '
        Me.SettingsPanelToolStripMenuItem.Name = "SettingsPanelToolStripMenuItem"
        Me.SettingsPanelToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SettingsPanelToolStripMenuItem.Text = "Settings Panel"
        '
        'UserCoreShellToolStripMenuItem
        '
        Me.UserCoreShellToolStripMenuItem.Name = "UserCoreShellToolStripMenuItem"
        Me.UserCoreShellToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UserCoreShellToolStripMenuItem.Text = "UserCore Shell"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'AboutUserOSToolStripMenuItem
        '
        Me.AboutUserOSToolStripMenuItem.Name = "AboutUserOSToolStripMenuItem"
        Me.AboutUserOSToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutUserOSToolStripMenuItem.Text = "About UserOS"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(177, 6)
        '
        'RestartUserOSToolStripMenuItem
        '
        Me.RestartUserOSToolStripMenuItem.Name = "RestartUserOSToolStripMenuItem"
        Me.RestartUserOSToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RestartUserOSToolStripMenuItem.Text = "Restart UserOS"
        '
        'ExitToShellToolStripMenuItem
        '
        Me.ExitToShellToolStripMenuItem.Name = "ExitToShellToolStripMenuItem"
        Me.ExitToShellToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToShellToolStripMenuItem.Text = "Exit to Shell"
        '
        'ExitUserOSToolStripMenuItem
        '
        Me.ExitUserOSToolStripMenuItem.Name = "ExitUserOSToolStripMenuItem"
        Me.ExitUserOSToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitUserOSToolStripMenuItem.Text = "Exit UserOS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.userOS.My.Resources.Resources.openlist
        Me.PictureBox1.Location = New System.Drawing.Point(574, 273)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Image = Global.userOS.My.Resources.Resources.settingspanel
        Me.PictureBox3.Location = New System.Drawing.Point(12, 273)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.userOS.My.Resources.Resources.usercore
        Me.PictureBox2.Location = New System.Drawing.Point(82, 273)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'GUIDesktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(650, 389)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Useraccessbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.Useraccessbar
        Me.MaximizeBox = False
        Me.Name = "GUIDesktop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "userOS Graphical Desktop"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Useraccessbar.ResumeLayout(False)
        Me.Useraccessbar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Useraccessbar As MenuStrip
    Friend WithEvents ApplicationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MiniNoteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuickOpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsPanelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserCoreShellToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents AboutUserOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ExitToShellToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitUserOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents RestartUserOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApplicationsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MiniNoteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SystemToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SettingsPanelToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutUserOSToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UserCoreShellToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AppGetMenu As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ExitMenu As ToolStripMenuItem
    Friend WithEvents ExitUserOSToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RestartUserOSToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
