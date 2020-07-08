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
        Me.btnEmployeeRegistration = New System.Windows.Forms.Button()
        Me.btnAccountRegistration = New System.Windows.Forms.Button()
        Me.panelUserControlContainer = New System.Windows.Forms.Panel()
        Me.UcAccountRegistration1 = New EmploInfo.ucAccountRegistration()
        Me.UcRegistrationEmployee1 = New EmploInfo.ucRegistrationEmployee()
        Me.panelUserControlContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEmployeeRegistration
        '
        Me.btnEmployeeRegistration.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnEmployeeRegistration.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmployeeRegistration.FlatAppearance.BorderSize = 0
        Me.btnEmployeeRegistration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnEmployeeRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmployeeRegistration.Font = New System.Drawing.Font("Nunito", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployeeRegistration.ForeColor = System.Drawing.Color.White
        Me.btnEmployeeRegistration.Location = New System.Drawing.Point(0, 0)
        Me.btnEmployeeRegistration.Name = "btnEmployeeRegistration"
        Me.btnEmployeeRegistration.Size = New System.Drawing.Size(518, 36)
        Me.btnEmployeeRegistration.TabIndex = 10
        Me.btnEmployeeRegistration.Text = "Employee"
        Me.btnEmployeeRegistration.UseVisualStyleBackColor = False
        '
        'btnAccountRegistration
        '
        Me.btnAccountRegistration.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAccountRegistration.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAccountRegistration.FlatAppearance.BorderSize = 0
        Me.btnAccountRegistration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnAccountRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccountRegistration.Font = New System.Drawing.Font("Nunito", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccountRegistration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnAccountRegistration.Location = New System.Drawing.Point(518, 0)
        Me.btnAccountRegistration.Name = "btnAccountRegistration"
        Me.btnAccountRegistration.Size = New System.Drawing.Size(502, 36)
        Me.btnAccountRegistration.TabIndex = 10
        Me.btnAccountRegistration.Text = "User Account"
        Me.btnAccountRegistration.UseVisualStyleBackColor = False
        '
        'panelUserControlContainer
        '
        Me.panelUserControlContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.panelUserControlContainer.Controls.Add(Me.UcAccountRegistration1)
        Me.panelUserControlContainer.Controls.Add(Me.UcRegistrationEmployee1)
        Me.panelUserControlContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelUserControlContainer.Location = New System.Drawing.Point(0, 39)
        Me.panelUserControlContainer.Name = "panelUserControlContainer"
        Me.panelUserControlContainer.Size = New System.Drawing.Size(1016, 581)
        Me.panelUserControlContainer.TabIndex = 0
        '
        'UcAccountRegistration1
        '
        Me.UcAccountRegistration1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.UcAccountRegistration1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcAccountRegistration1.Location = New System.Drawing.Point(0, 0)
        Me.UcAccountRegistration1.Name = "UcAccountRegistration1"
        Me.UcAccountRegistration1.Size = New System.Drawing.Size(1016, 581)
        Me.UcAccountRegistration1.TabIndex = 1
        Me.UcAccountRegistration1.Visible = False
        '
        'UcRegistrationEmployee1
        '
        Me.UcRegistrationEmployee1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.UcRegistrationEmployee1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcRegistrationEmployee1.Location = New System.Drawing.Point(0, 0)
        Me.UcRegistrationEmployee1.Name = "UcRegistrationEmployee1"
        Me.UcRegistrationEmployee1.Size = New System.Drawing.Size(1016, 581)
        Me.UcRegistrationEmployee1.TabIndex = 0
        '
        'ucRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Controls.Add(Me.btnEmployeeRegistration)
        Me.Controls.Add(Me.panelUserControlContainer)
        Me.Controls.Add(Me.btnAccountRegistration)
        Me.Name = "ucRegistration"
        Me.Size = New System.Drawing.Size(1016, 620)
        Me.panelUserControlContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEmployeeRegistration As System.Windows.Forms.Button
    Friend WithEvents btnAccountRegistration As System.Windows.Forms.Button
    Friend WithEvents panelUserControlContainer As System.Windows.Forms.Panel
    Friend WithEvents UcAccountRegistration1 As EmploInfo.ucAccountRegistration
    Friend WithEvents UcRegistrationEmployee1 As EmploInfo.ucRegistrationEmployee

End Class
