<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAccountRegistration
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRePassword = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtPassword = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtName = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtUsername = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.cmbPosition = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Righteous", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(326, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(257, 24)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "ACCOUNT REGISTRATION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(327, 375)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Re-Enter Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(326, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(326, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(326, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Username"
        '
        'txtRePassword
        '
        Me.txtRePassword.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtRePassword.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtRePassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtRePassword.BorderThickness = 2
        Me.txtRePassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRePassword.Font = New System.Drawing.Font("Nunito", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRePassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtRePassword.isPassword = True
        Me.txtRePassword.Location = New System.Drawing.Point(328, 394)
        Me.txtRePassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRePassword.Name = "txtRePassword"
        Me.txtRePassword.Size = New System.Drawing.Size(370, 34)
        Me.txtRePassword.TabIndex = 19
        Me.txtRePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtPassword
        '
        Me.txtPassword.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtPassword.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtPassword.BorderThickness = 2
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Font = New System.Drawing.Font("Nunito", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtPassword.isPassword = True
        Me.txtPassword.Location = New System.Drawing.Point(327, 337)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(370, 34)
        Me.txtPassword.TabIndex = 18
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtName
        '
        Me.txtName.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtName.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtName.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtName.BorderThickness = 2
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.Font = New System.Drawing.Font("Nunito", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtName.isPassword = False
        Me.txtName.Location = New System.Drawing.Point(327, 222)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(370, 34)
        Me.txtName.TabIndex = 16
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtUsername
        '
        Me.txtUsername.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtUsername.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtUsername.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtUsername.BorderThickness = 2
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.Font = New System.Drawing.Font("Nunito", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtUsername.isPassword = False
        Me.txtUsername.Location = New System.Drawing.Point(327, 279)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(370, 34)
        Me.txtUsername.TabIndex = 17
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(330, 435)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(109, 30)
        Me.btnRegister.TabIndex = 24
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'cmbPosition
        '
        Me.cmbPosition.BackColor = System.Drawing.Color.Transparent
        Me.cmbPosition.BorderRadius = 0
        Me.cmbPosition.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbPosition.DisabledColor = System.Drawing.Color.Gray
        Me.cmbPosition.Font = New System.Drawing.Font("Nunito", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPosition.ForeColor = System.Drawing.Color.White
        Me.cmbPosition.Items = New String() {"", "HR ADMIN", "IT COORDINATOR", "SECRETARY"}
        Me.cmbPosition.Location = New System.Drawing.Point(328, 168)
        Me.cmbPosition.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.NomalColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.cmbPosition.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.cmbPosition.selectedIndex = -1
        Me.cmbPosition.Size = New System.Drawing.Size(367, 34)
        Me.cmbPosition.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(327, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 16)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Position"
        '
        'ucAccountRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Controls.Add(Me.cmbPosition)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRePassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Name = "ucAccountRegistration"
        Me.Size = New System.Drawing.Size(1016, 581)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRePassword As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtName As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtUsername As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents cmbPosition As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
