<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucEmployees
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
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnListEmployees = New System.Windows.Forms.Button()
        Me.btnAddEmployee = New System.Windows.Forms.Button()
        Me.lineUserAccount = New Bunifu.Framework.UI.BunifuSeparator()
        Me.lineEmployee = New Bunifu.Framework.UI.BunifuSeparator()
        Me.panelUserControlContainer = New System.Windows.Forms.Panel()
        Me.UcAddEmployee1 = New EmploInfo.ucAddEmployee()
        Me.UcListEmployee1 = New EmploInfo.ucListEmployee()
        Me.panelUserControlContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 3
        Me.BunifuSeparator2.Location = New System.Drawing.Point(101, 59)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(63, 10)
        Me.BunifuSeparator2.TabIndex = 8
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
        Me.BunifuSeparator1.Size = New System.Drawing.Size(56, 10)
        Me.BunifuSeparator1.TabIndex = 7
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nunito", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(68, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "EMPLOYEES"
        '
        'btnListEmployees
        '
        Me.btnListEmployees.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnListEmployees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListEmployees.FlatAppearance.BorderSize = 0
        Me.btnListEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnListEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.btnListEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListEmployees.Font = New System.Drawing.Font("Nunito", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListEmployees.ForeColor = System.Drawing.Color.White
        Me.btnListEmployees.Location = New System.Drawing.Point(507, 83)
        Me.btnListEmployees.Name = "btnListEmployees"
        Me.btnListEmployees.Size = New System.Drawing.Size(439, 36)
        Me.btnListEmployees.TabIndex = 11
        Me.btnListEmployees.Text = "List of Employees"
        Me.btnListEmployees.UseVisualStyleBackColor = False
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddEmployee.FlatAppearance.BorderSize = 0
        Me.btnAddEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnAddEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddEmployee.Font = New System.Drawing.Font("Nunito", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEmployee.ForeColor = System.Drawing.Color.White
        Me.btnAddEmployee.Location = New System.Drawing.Point(70, 83)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Size = New System.Drawing.Size(437, 36)
        Me.btnAddEmployee.TabIndex = 12
        Me.btnAddEmployee.Text = "Add Employee"
        Me.btnAddEmployee.UseVisualStyleBackColor = False
        '
        'lineUserAccount
        '
        Me.lineUserAccount.BackColor = System.Drawing.Color.Transparent
        Me.lineUserAccount.LineColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lineUserAccount.LineThickness = 3
        Me.lineUserAccount.Location = New System.Drawing.Point(507, 115)
        Me.lineUserAccount.Name = "lineUserAccount"
        Me.lineUserAccount.Size = New System.Drawing.Size(439, 10)
        Me.lineUserAccount.TabIndex = 13
        Me.lineUserAccount.Transparency = 255
        Me.lineUserAccount.Vertical = False
        Me.lineUserAccount.Visible = False
        '
        'lineEmployee
        '
        Me.lineEmployee.BackColor = System.Drawing.Color.Transparent
        Me.lineEmployee.LineColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lineEmployee.LineThickness = 3
        Me.lineEmployee.Location = New System.Drawing.Point(70, 115)
        Me.lineEmployee.Name = "lineEmployee"
        Me.lineEmployee.Size = New System.Drawing.Size(437, 10)
        Me.lineEmployee.TabIndex = 14
        Me.lineEmployee.Transparency = 255
        Me.lineEmployee.Vertical = False
        '
        'panelUserControlContainer
        '
        Me.panelUserControlContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.panelUserControlContainer.Controls.Add(Me.UcAddEmployee1)
        Me.panelUserControlContainer.Controls.Add(Me.UcListEmployee1)
        Me.panelUserControlContainer.Location = New System.Drawing.Point(70, 122)
        Me.panelUserControlContainer.Name = "panelUserControlContainer"
        Me.panelUserControlContainer.Size = New System.Drawing.Size(876, 436)
        Me.panelUserControlContainer.TabIndex = 15
        '
        'UcAddEmployee1
        '
        Me.UcAddEmployee1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.UcAddEmployee1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcAddEmployee1.Location = New System.Drawing.Point(0, 0)
        Me.UcAddEmployee1.Name = "UcAddEmployee1"
        Me.UcAddEmployee1.Size = New System.Drawing.Size(876, 436)
        Me.UcAddEmployee1.TabIndex = 0
        '
        'UcListEmployee1
        '
        Me.UcListEmployee1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.UcListEmployee1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListEmployee1.Location = New System.Drawing.Point(0, 0)
        Me.UcListEmployee1.Name = "UcListEmployee1"
        Me.UcListEmployee1.Size = New System.Drawing.Size(876, 436)
        Me.UcListEmployee1.TabIndex = 1
        '
        'ucEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.panelUserControlContainer)
        Me.Controls.Add(Me.btnListEmployees)
        Me.Controls.Add(Me.btnAddEmployee)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lineEmployee)
        Me.Controls.Add(Me.lineUserAccount)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Name = "ucEmployees"
        Me.Size = New System.Drawing.Size(1016, 620)
        Me.panelUserControlContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnListEmployees As System.Windows.Forms.Button
    Friend WithEvents btnAddEmployee As System.Windows.Forms.Button
    Friend WithEvents lineUserAccount As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents lineEmployee As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents panelUserControlContainer As System.Windows.Forms.Panel
    Friend WithEvents UcAddEmployee1 As EmploInfo.ucAddEmployee
    Friend WithEvents UcListEmployee1 As EmploInfo.ucListEmployee

End Class
