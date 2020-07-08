<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAccountInfo
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
        Me.UcYourAccount1 = New EmploInfo.ucYourAccount()
        Me.UcAccountsRegistered1 = New EmploInfo.ucAccountsRegistered()
        Me.lineUserAccount = New Bunifu.Framework.UI.BunifuSeparator()
        Me.lineEmployee = New Bunifu.Framework.UI.BunifuSeparator()
        Me.btnYourAccount = New System.Windows.Forms.Button()
        Me.btnAccountsRegistered = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelUserControlContainer.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelUserControlContainer
        '
        Me.panelUserControlContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.panelUserControlContainer.Controls.Add(Me.UcYourAccount1)
        Me.panelUserControlContainer.Controls.Add(Me.UcAccountsRegistered1)
        Me.panelUserControlContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelUserControlContainer.Location = New System.Drawing.Point(0, 42)
        Me.panelUserControlContainer.Name = "panelUserControlContainer"
        Me.panelUserControlContainer.Size = New System.Drawing.Size(1016, 578)
        Me.panelUserControlContainer.TabIndex = 20
        '
        'UcYourAccount1
        '
        Me.UcYourAccount1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.UcYourAccount1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcYourAccount1.Location = New System.Drawing.Point(0, 0)
        Me.UcYourAccount1.Name = "UcYourAccount1"
        Me.UcYourAccount1.Size = New System.Drawing.Size(1016, 578)
        Me.UcYourAccount1.TabIndex = 0
        '
        'UcAccountsRegistered1
        '
        Me.UcAccountsRegistered1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.UcAccountsRegistered1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcAccountsRegistered1.Location = New System.Drawing.Point(0, 0)
        Me.UcAccountsRegistered1.Name = "UcAccountsRegistered1"
        Me.UcAccountsRegistered1.Size = New System.Drawing.Size(1016, 578)
        Me.UcAccountsRegistered1.TabIndex = 1
        '
        'lineUserAccount
        '
        Me.lineUserAccount.BackColor = System.Drawing.Color.Transparent
        Me.lineUserAccount.LineColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lineUserAccount.LineThickness = 3
        Me.lineUserAccount.Location = New System.Drawing.Point(500, 33)
        Me.lineUserAccount.Name = "lineUserAccount"
        Me.lineUserAccount.Size = New System.Drawing.Size(518, 10)
        Me.lineUserAccount.TabIndex = 18
        Me.lineUserAccount.Transparency = 255
        Me.lineUserAccount.Vertical = False
        Me.lineUserAccount.Visible = False
        '
        'lineEmployee
        '
        Me.lineEmployee.BackColor = System.Drawing.Color.Transparent
        Me.lineEmployee.LineColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lineEmployee.LineThickness = 3
        Me.lineEmployee.Location = New System.Drawing.Point(-18, 33)
        Me.lineEmployee.Name = "lineEmployee"
        Me.lineEmployee.Size = New System.Drawing.Size(518, 10)
        Me.lineEmployee.TabIndex = 19
        Me.lineEmployee.Transparency = 255
        Me.lineEmployee.Vertical = False
        '
        'btnYourAccount
        '
        Me.btnYourAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnYourAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnYourAccount.FlatAppearance.BorderSize = 0
        Me.btnYourAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnYourAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.btnYourAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYourAccount.Font = New System.Drawing.Font("Nunito", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYourAccount.ForeColor = System.Drawing.Color.White
        Me.btnYourAccount.Location = New System.Drawing.Point(-18, 1)
        Me.btnYourAccount.Name = "btnYourAccount"
        Me.btnYourAccount.Size = New System.Drawing.Size(518, 36)
        Me.btnYourAccount.TabIndex = 17
        Me.btnYourAccount.Text = "Your Account"
        Me.btnYourAccount.UseVisualStyleBackColor = False
        '
        'btnAccountsRegistered
        '
        Me.btnAccountsRegistered.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnAccountsRegistered.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAccountsRegistered.FlatAppearance.BorderSize = 0
        Me.btnAccountsRegistered.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnAccountsRegistered.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.btnAccountsRegistered.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccountsRegistered.Font = New System.Drawing.Font("Nunito", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccountsRegistered.ForeColor = System.Drawing.Color.White
        Me.btnAccountsRegistered.Location = New System.Drawing.Point(500, 1)
        Me.btnAccountsRegistered.Name = "btnAccountsRegistered"
        Me.btnAccountsRegistered.Size = New System.Drawing.Size(518, 36)
        Me.btnAccountsRegistered.TabIndex = 16
        Me.btnAccountsRegistered.Text = "Accounts Registered"
        Me.btnAccountsRegistered.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnAccountsRegistered)
        Me.Panel1.Controls.Add(Me.btnYourAccount)
        Me.Panel1.Controls.Add(Me.lineEmployee)
        Me.Panel1.Controls.Add(Me.lineUserAccount)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 76)
        Me.Panel1.TabIndex = 21
        '
        'ucAccountInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.panelUserControlContainer)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ucAccountInfo"
        Me.Size = New System.Drawing.Size(1016, 620)
        Me.panelUserControlContainer.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelUserControlContainer As System.Windows.Forms.Panel
    Friend WithEvents UcYourAccount1 As EmploInfo.ucYourAccount
    Friend WithEvents UcAccountsRegistered1 As EmploInfo.ucAccountsRegistered
    Friend WithEvents lineUserAccount As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents lineEmployee As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents btnYourAccount As System.Windows.Forms.Button
    Friend WithEvents btnAccountsRegistered As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
