<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class setup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(setup))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PnlTopBorder = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PnlTopBorder.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hi! This seems to be the first time you have started userOS." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This screen allows " &
    "you to configure userOS instantly."
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(11, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Open Settings"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Gainsboro
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(234, 98)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(133, 23)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Start userOS"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'PnlTopBorder
        '
        Me.PnlTopBorder.Controls.Add(Me.Label2)
        Me.PnlTopBorder.Location = New System.Drawing.Point(-1, -1)
        Me.PnlTopBorder.Name = "PnlTopBorder"
        Me.PnlTopBorder.Size = New System.Drawing.Size(380, 31)
        Me.PnlTopBorder.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "userOS Setup"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PnlTopBorder)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 127)
        Me.Panel1.TabIndex = 9
        '
        'setup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(380, 127)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "setup"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "userOS Setup"
        Me.TopMost = True
        Me.PnlTopBorder.ResumeLayout(False)
        Me.PnlTopBorder.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents PnlTopBorder As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
End Class
