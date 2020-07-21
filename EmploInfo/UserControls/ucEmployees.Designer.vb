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
        Me.panelUserControlContainer = New System.Windows.Forms.Panel()
        Me.btnAddEmployee = New System.Windows.Forms.Button()
        Me.btnListEmployees = New System.Windows.Forms.Button()
        Me.UcAddEmployee1 = New EmploInfo.ucAddEmployee()
        Me.UcListEmployee1 = New EmploInfo.ucListEmployee()
        Me.panelUserControlContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelUserControlContainer
        '
        Me.panelUserControlContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.panelUserControlContainer.Controls.Add(Me.UcAddEmployee1)
        Me.panelUserControlContainer.Controls.Add(Me.UcListEmployee1)
        Me.panelUserControlContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelUserControlContainer.Location = New System.Drawing.Point(0, 38)
        Me.panelUserControlContainer.Name = "panelUserControlContainer"
        Me.panelUserControlContainer.Size = New System.Drawing.Size(1016, 582)
        Me.panelUserControlContainer.TabIndex = 15
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddEmployee.FlatAppearance.BorderSize = 0
        Me.btnAddEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddEmployee.Font = New System.Drawing.Font("Nunito", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEmployee.ForeColor = System.Drawing.Color.White
        Me.btnAddEmployee.Location = New System.Drawing.Point(0, 0)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Size = New System.Drawing.Size(373, 36)
        Me.btnAddEmployee.TabIndex = 16
        Me.btnAddEmployee.Text = "Add New Employee"
        Me.btnAddEmployee.UseVisualStyleBackColor = False
        '
        'btnListEmployees
        '
        Me.btnListEmployees.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnListEmployees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListEmployees.FlatAppearance.BorderSize = 0
        Me.btnListEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnListEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListEmployees.Font = New System.Drawing.Font("Nunito", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListEmployees.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnListEmployees.Location = New System.Drawing.Point(373, 0)
        Me.btnListEmployees.Name = "btnListEmployees"
        Me.btnListEmployees.Size = New System.Drawing.Size(647, 36)
        Me.btnListEmployees.TabIndex = 17
        Me.btnListEmployees.Text = "List of Employees"
        Me.btnListEmployees.UseVisualStyleBackColor = False
        '
        'UcAddEmployee1
        '
        Me.UcAddEmployee1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.UcAddEmployee1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcAddEmployee1.Location = New System.Drawing.Point(0, 0)
        Me.UcAddEmployee1.Name = "UcAddEmployee1"
        Me.UcAddEmployee1.Size = New System.Drawing.Size(1016, 582)
        Me.UcAddEmployee1.TabIndex = 0
        '
        'UcListEmployee1
        '
        Me.UcListEmployee1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.UcListEmployee1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListEmployee1.Location = New System.Drawing.Point(0, 0)
        Me.UcListEmployee1.Name = "UcListEmployee1"
        Me.UcListEmployee1.Size = New System.Drawing.Size(1016, 582)
        Me.UcListEmployee1.TabIndex = 1
        '
        'ucEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.btnAddEmployee)
        Me.Controls.Add(Me.btnListEmployees)
        Me.Controls.Add(Me.panelUserControlContainer)
        Me.Name = "ucEmployees"
        Me.Size = New System.Drawing.Size(1016, 620)
        Me.panelUserControlContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelUserControlContainer As System.Windows.Forms.Panel
    Friend WithEvents UcAddEmployee1 As EmploInfo.ucAddEmployee
    Friend WithEvents UcListEmployee1 As EmploInfo.ucListEmployee
    Friend WithEvents btnAddEmployee As System.Windows.Forms.Button
    Friend WithEvents btnListEmployees As System.Windows.Forms.Button

End Class
