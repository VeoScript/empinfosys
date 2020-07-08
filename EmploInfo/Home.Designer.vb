<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.linkAboutSystem = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.iconImage = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl3 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUsername = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPassword = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panelBottombar = New System.Windows.Forms.Panel()
        Me.copyrights = New System.Windows.Forms.Label()
        Me.pnlLeft.SuspendLayout()
        CType(Me.iconImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBottombar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.pnlLeft.Controls.Add(Me.Label6)
        Me.pnlLeft.Controls.Add(Me.Label2)
        Me.pnlLeft.Controls.Add(Me.LinkLabel1)
        Me.pnlLeft.Controls.Add(Me.linkAboutSystem)
        Me.pnlLeft.Controls.Add(Me.Label1)
        Me.pnlLeft.Controls.Add(Me.iconImage)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(248, 431)
        Me.pnlLeft.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(127, 403)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(9, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "|"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Employees Information System"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(139, 401)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(63, 16)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Developer"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        '
        'linkAboutSystem
        '
        Me.linkAboutSystem.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.linkAboutSystem.AutoSize = True
        Me.linkAboutSystem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linkAboutSystem.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkAboutSystem.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkAboutSystem.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.linkAboutSystem.Location = New System.Drawing.Point(40, 401)
        Me.linkAboutSystem.Name = "linkAboutSystem"
        Me.linkAboutSystem.Size = New System.Drawing.Size(85, 16)
        Me.linkAboutSystem.TabIndex = 4
        Me.linkAboutSystem.TabStop = True
        Me.linkAboutSystem.Text = "About System"
        Me.linkAboutSystem.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Righteous", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "EmpInfoSys"
        '
        'iconImage
        '
        Me.iconImage.Image = CType(resources.GetObject("iconImage.Image"), System.Drawing.Image)
        Me.iconImage.Location = New System.Drawing.Point(-1, 96)
        Me.iconImage.Name = "iconImage"
        Me.iconImage.Size = New System.Drawing.Size(248, 288)
        Me.iconImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.iconImage.TabIndex = 1
        Me.iconImage.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(262, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Enter your login details below."
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me.pnlLeft
        Me.BunifuDragControl2.Vertical = True
        '
        'BunifuDragControl3
        '
        Me.BunifuDragControl3.Fixed = True
        Me.BunifuDragControl3.Horizontal = True
        Me.BunifuDragControl3.TargetControl = Me.iconImage
        Me.BunifuDragControl3.Vertical = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(262, 283)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(114, 30)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(261, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtUsername.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtUsername.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtUsername.BorderThickness = 2
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtUsername.isPassword = False
        Me.txtUsername.Location = New System.Drawing.Point(261, 190)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(370, 32)
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(261, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtPassword.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtPassword.BorderThickness = 2
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtPassword.isPassword = True
        Me.txtPassword.Location = New System.Drawing.Point(261, 245)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(370, 32)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageActive = CType(resources.GetObject("btnClose.ImageActive"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(621, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(14, 14)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 12
        Me.btnClose.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnClose, "Close")
        Me.btnClose.Zoom = 10
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 3
        Me.BunifuSeparator2.Location = New System.Drawing.Point(373, 111)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(86, 10)
        Me.BunifuSeparator2.TabIndex = 15
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 3
        Me.BunifuSeparator1.Location = New System.Drawing.Point(264, 111)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(119, 10)
        Me.BunifuSeparator1.TabIndex = 14
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Righteous", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(261, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 24)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "SPMI Administrator"
        '
        'panelBottombar
        '
        Me.panelBottombar.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.panelBottombar.Controls.Add(Me.copyrights)
        Me.panelBottombar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBottombar.Location = New System.Drawing.Point(248, 401)
        Me.panelBottombar.Name = "panelBottombar"
        Me.panelBottombar.Size = New System.Drawing.Size(399, 30)
        Me.panelBottombar.TabIndex = 16
        '
        'copyrights
        '
        Me.copyrights.AutoSize = True
        Me.copyrights.Font = New System.Drawing.Font("Nunito", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copyrights.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.copyrights.Location = New System.Drawing.Point(185, 9)
        Me.copyrights.Name = "copyrights"
        Me.copyrights.Size = New System.Drawing.Size(210, 14)
        Me.copyrights.TabIndex = 3
        Me.copyrights.Text = "©2020. EmpInfoSys, SPMI Software Origin."
        '
        'Home
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(647, 431)
        Me.Controls.Add(Me.panelBottombar)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pnlLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EIS"
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        CType(Me.iconImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBottombar.ResumeLayout(False)
        Me.panelBottombar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents iconImage As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl3 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtUsername As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents linkAboutSystem As System.Windows.Forms.LinkLabel
    Friend WithEvents panelBottombar As System.Windows.Forms.Panel
    Friend WithEvents copyrights As System.Windows.Forms.Label

End Class
