<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucRegistration
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelUserControlContainer = New System.Windows.Forms.Panel()
        Me.UcAccountRegistration1 = New EmploInfo.ucAccountRegistration()
        Me.UcRegistrationEmployee1 = New EmploInfo.ucRegistrationEmployee()
        Me.btnEmployeeRegistration = New System.Windows.Forms.Button()
        Me.btnAccountRegistration = New System.Windows.Forms.Button()
        Me.lineEmployee = New Bunifu.Framework.UI.BunifuSeparator()
        Me.lineUserAccount = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Panel1.SuspendLayout()
        Me.panelUserControlContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nunito", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(68, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "REGISTRATION"
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 3
        Me.BunifuSeparator2.Location = New System.Drawing.Point(119, 59)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(77, 10)
        Me.BunifuSeparator2.TabIndex = 7
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 3
        Me.BunifuSeparator1.Location = New System.Drawing.Point(72, 59)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(47, 10)
        Me.BunifuSeparator1.TabIndex = 8
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel1.Controls.Add(Me.panelUserControlContainer)
        Me.Panel1.Location = New System.Drawing.Point(72, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(876, 436)
        Me.Panel1.TabIndex = 9
        '
        'panelUserControlContainer
        '
        Me.panelUserControlContainer.Controls.Add(Me.UcAccountRegistration1)
        Me.panelUserControlContainer.Controls.Add(Me.UcRegistrationEmployee1)
        Me.panelUserControlContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelUserControlContainer.Location = New System.Drawing.Point(0, 0)
        Me.panelUserControlContainer.Name = "panelUserControlContainer"
        Me.panelUserControlContainer.Size = New System.Drawing.Size(876, 436)
        Me.panelUserControlContainer.TabIndex = 0
        '
        'UcAccountRegistration1
        '
        Me.UcAccountRegistration1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.UcAccountRegistration1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcAccountRegistration1.Location = New System.Drawing.Point(0, 0)
        Me.UcAccountRegistration1.Name = "UcAccountRegistration1"
        Me.UcAccountRegistration1.Size = New System.Drawing.Size(876, 436)
        Me.UcAccountRegistration1.TabIndex = 1
        Me.UcAccountRegistration1.Visible = False
        '
        'UcRegistrationEmployee1
        '
        Me.UcRegistrationEmployee1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.UcRegistrationEmployee1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcRegistrationEmployee1.Location = New System.Drawing.Point(0, 0)
        Me.UcRegistrationEmployee1.Name = "UcRegistrationEmployee1"
        Me.UcRegistrationEmployee1.Size = New System.Drawing.Size(876, 436)
        Me.UcRegistrationEmployee1.TabIndex = 0
        '
        'btnEmployeeRegistration
        '
        Me.btnEmployeeRegistration.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEmployeeRegistration.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmployeeRegistration.FlatAppearance.BorderSize = 0
        Me.btnEmployeeRegistration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEmployeeRegistration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnEmployeeRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmployeeRegistration.Font = New System.Drawing.Font("Nunito", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployeeRegistration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnEmployeeRegistration.Location = New System.Drawing.Point(72, 83)
        Me.btnEmployeeRegistration.Name = "btnEmployeeRegistration"
        Me.btnEmployeeRegistration.Size = New System.Drawing.Size(437, 36)
        Me.btnEmployeeRegistration.TabIndex = 10
        Me.btnEmployeeRegistration.Text = "Employee"
        Me.btnEmployeeRegistration.UseVisualStyleBackColor = False
        '
        'btnAccountRegistration
        '
        Me.btnAccountRegistration.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAccountRegistration.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAccountRegistration.FlatAppearance.BorderSize = 0
        Me.btnAccountRegistration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAccountRegistration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnAccountRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccountRegistration.Font = New System.Drawing.Font("Nunito", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccountRegistration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnAccountRegistration.Location = New System.Drawing.Point(509, 83)
        Me.btnAccountRegistration.Name = "btnAccountRegistration"
        Me.btnAccountRegistration.Size = New System.Drawing.Size(439, 36)
        Me.btnAccountRegistration.TabIndex = 10
        Me.btnAccountRegistration.Text = "User Account"
        Me.btnAccountRegistration.UseVisualStyleBackColor = False
        '
        'lineEmployee
        '
        Me.lineEmployee.BackColor = System.Drawing.Color.Transparent
        Me.lineEmployee.LineColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lineEmployee.LineThickness = 3
        Me.lineEmployee.Location = New System.Drawing.Point(72, 115)
        Me.lineEmployee.Name = "lineEmployee"
        Me.lineEmployee.Size = New System.Drawing.Size(437, 10)
        Me.lineEmployee.TabIndex = 7
        Me.lineEmployee.Transparency = 255
        Me.lineEmployee.Vertical = False
        '
        'lineUserAccount
        '
        Me.lineUserAccount.BackColor = System.Drawing.Color.Transparent
        Me.lineUserAccount.LineColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lineUserAccount.LineThickness = 3
        Me.lineUserAccount.Location = New System.Drawing.Point(509, 115)
        Me.lineUserAccount.Name = "lineUserAccount"
        Me.lineUserAccount.Size = New System.Drawing.Size(439, 10)
        Me.lineUserAccount.TabIndex = 7
        Me.lineUserAccount.Transparency = 255
        Me.lineUserAccount.Vertical = False
        Me.lineUserAccount.Visible = False
        '
        'ucRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.btnAccountRegistration)
        Me.Controls.Add(Me.btnEmployeeRegistration)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lineUserAccount)
        Me.Controls.Add(Me.lineEmployee)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "ucRegistration"
        Me.Size = New System.Drawing.Size(1016, 620)
        Me.Panel1.ResumeLayout(False)
        Me.panelUserControlContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnEmployeeRegistration As System.Windows.Forms.Button
    Friend WithEvents btnAccountRegistration As System.Windows.Forms.Button
    Friend WithEvents lineEmployee As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents lineUserAccount As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents panelUserControlContainer As System.Windows.Forms.Panel
    Friend WithEvents UcRegistrationEmployee1 As EmploInfo.ucRegistrationEmployee
    Friend WithEvents UcAccountRegistration1 As EmploInfo.ucAccountRegistration

End Class
