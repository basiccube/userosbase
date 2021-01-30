<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class openlist
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(openlist))
        Me.pnlTopBorder = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.WindowSwitch = New System.Windows.Forms.Button()
        Me.WindowRefresh = New System.Windows.Forms.Button()
        Me.WindowList = New System.Windows.Forms.ListBox()
        Me.pnlTopBorder.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTopBorder
        '
        Me.pnlTopBorder.Controls.Add(Me.Button3)
        Me.pnlTopBorder.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopBorder.Name = "pnlTopBorder"
        Me.pnlTopBorder.Size = New System.Drawing.Size(246, 35)
        Me.pnlTopBorder.TabIndex = 10
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(181, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(65, 35)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "X"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.WindowSwitch)
        Me.Panel1.Controls.Add(Me.WindowRefresh)
        Me.Panel1.Controls.Add(Me.WindowList)
        Me.Panel1.Controls.Add(Me.pnlTopBorder)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(245, 207)
        Me.Panel1.TabIndex = 11
        '
        'WindowSwitch
        '
        Me.WindowSwitch.BackColor = System.Drawing.Color.Gray
        Me.WindowSwitch.Cursor = System.Windows.Forms.Cursors.Default
        Me.WindowSwitch.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.WindowSwitch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.WindowSwitch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.WindowSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WindowSwitch.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.WindowSwitch.ForeColor = System.Drawing.Color.White
        Me.WindowSwitch.Location = New System.Drawing.Point(11, 171)
        Me.WindowSwitch.Name = "WindowSwitch"
        Me.WindowSwitch.Size = New System.Drawing.Size(75, 23)
        Me.WindowSwitch.TabIndex = 15
        Me.WindowSwitch.Text = "Switch"
        Me.WindowSwitch.UseVisualStyleBackColor = False
        '
        'WindowRefresh
        '
        Me.WindowRefresh.BackColor = System.Drawing.Color.Gray
        Me.WindowRefresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.WindowRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.WindowRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.WindowRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.WindowRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WindowRefresh.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.WindowRefresh.ForeColor = System.Drawing.Color.White
        Me.WindowRefresh.Location = New System.Drawing.Point(157, 171)
        Me.WindowRefresh.Name = "WindowRefresh"
        Me.WindowRefresh.Size = New System.Drawing.Size(75, 23)
        Me.WindowRefresh.TabIndex = 14
        Me.WindowRefresh.Text = "Refresh"
        Me.WindowRefresh.UseVisualStyleBackColor = False
        '
        'WindowList
        '
        Me.WindowList.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.WindowList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WindowList.Cursor = System.Windows.Forms.Cursors.Default
        Me.WindowList.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.WindowList.ForeColor = System.Drawing.Color.White
        Me.WindowList.FormattingEnabled = True
        Me.WindowList.ItemHeight = 17
        Me.WindowList.Location = New System.Drawing.Point(11, 41)
        Me.WindowList.Name = "WindowList"
        Me.WindowList.Size = New System.Drawing.Size(221, 121)
        Me.WindowList.TabIndex = 12
        '
        'openlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(245, 207)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "openlist"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Open Window List"
        Me.TopMost = True
        Me.pnlTopBorder.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTopBorder As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents WindowList As ListBox
    Friend WithEvents WindowRefresh As Button
    Friend WithEvents WindowSwitch As Button
End Class
