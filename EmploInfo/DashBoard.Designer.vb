<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashBoard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashBoard))
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnAccountInfo = New System.Windows.Forms.Button()
        Me.btnRecords = New System.Windows.Forms.Button()
        Me.btnEmployees = New System.Windows.Forms.Button()
        Me.btnRegistration = New System.Windows.Forms.Button()
        Me.btnDashBoard = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelTopbar = New System.Windows.Forms.Panel()
        Me.btnMinimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.panelBottombar = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.linkAboutSystem = New System.Windows.Forms.LinkLabel()
        Me.copyrights = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.panelUserControlContainer = New System.Windows.Forms.Panel()
        Me.UcDashboard1 = New EmploInfo.ucDashboard()
        Me.UcEmployees1 = New EmploInfo.ucEmployees()
        Me.UcRegistration1 = New EmploInfo.ucRegistration()
        Me.UcRecords1 = New EmploInfo.ucRecords()
        Me.UcAccountInfo1 = New EmploInfo.ucAccountInfo()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.panelMenu.SuspendLayout()
        Me.panelTopbar.SuspendLayout()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBottombar.SuspendLayout()
        Me.panelUserControlContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.btnLogout)
        Me.panelMenu.Controls.Add(Me.btnSettings)
        Me.panelMenu.Controls.Add(Me.btnAccountInfo)
        Me.panelMenu.Controls.Add(Me.btnRecords)
        Me.panelMenu.Controls.Add(Me.btnEmployees)
        Me.panelMenu.Controls.Add(Me.btnRegistration)
        Me.panelMenu.Controls.Add(Me.btnDashBoard)
        Me.panelMenu.Controls.Add(Me.Label4)
        Me.panelMenu.Controls.Add(Me.Label3)
        Me.panelMenu.Controls.Add(Me.Label2)
        Me.panelMenu.Controls.Add(Me.Label1)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(255, 671)
        Me.panelMenu.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Nunito", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(0, 388)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(255, 36)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "     Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Nunito", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Location = New System.Drawing.Point(0, 351)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(255, 36)
        Me.btnSettings.TabIndex = 3
        Me.btnSettings.Text = "     Settings"
        Me.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'btnAccountInfo
        '
        Me.btnAccountInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnAccountInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAccountInfo.FlatAppearance.BorderSize = 0
        Me.btnAccountInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnAccountInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnAccountInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccountInfo.Font = New System.Drawing.Font("Nunito", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccountInfo.ForeColor = System.Drawing.Color.White
        Me.btnAccountInfo.Location = New System.Drawing.Point(0, 314)
        Me.btnAccountInfo.Name = "btnAccountInfo"
        Me.btnAccountInfo.Size = New System.Drawing.Size(255, 36)
        Me.btnAccountInfo.TabIndex = 3
        Me.btnAccountInfo.Text = "     Account Information"
        Me.btnAccountInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btnAccountInfo, "Your Account Information.")
        Me.btnAccountInfo.UseVisualStyleBackColor = False
        '
        'btnRecords
        '
        Me.btnRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnRecords.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecords.FlatAppearance.BorderSize = 0
        Me.btnRecords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnRecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecords.Font = New System.Drawing.Font("Nunito", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecords.ForeColor = System.Drawing.Color.White
        Me.btnRecords.Location = New System.Drawing.Point(0, 252)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.Size = New System.Drawing.Size(255, 36)
        Me.btnRecords.TabIndex = 3
        Me.btnRecords.Text = "     Records"
        Me.btnRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btnRecords, "List of Records.")
        Me.btnRecords.UseVisualStyleBackColor = False
        '
        'btnEmployees
        '
        Me.btnEmployees.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnEmployees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmployees.FlatAppearance.BorderSize = 0
        Me.btnEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmployees.Font = New System.Drawing.Font("Nunito", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployees.ForeColor = System.Drawing.Color.White
        Me.btnEmployees.Location = New System.Drawing.Point(0, 215)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Size = New System.Drawing.Size(255, 36)
        Me.btnEmployees.TabIndex = 3
        Me.btnEmployees.Text = "     Employees"
        Me.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btnEmployees, "Add Employees.")
        Me.btnEmployees.UseVisualStyleBackColor = False
        '
        'btnRegistration
        '
        Me.btnRegistration.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnRegistration.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistration.FlatAppearance.BorderSize = 0
        Me.btnRegistration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnRegistration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistration.Font = New System.Drawing.Font("Nunito", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistration.ForeColor = System.Drawing.Color.White
        Me.btnRegistration.Location = New System.Drawing.Point(0, 178)
        Me.btnRegistration.Name = "btnRegistration"
        Me.btnRegistration.Size = New System.Drawing.Size(255, 36)
        Me.btnRegistration.TabIndex = 3
        Me.btnRegistration.Text = "     Registration"
        Me.btnRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btnRegistration, "Registration of Employees.")
        Me.btnRegistration.UseVisualStyleBackColor = False
        '
        'btnDashBoard
        '
        Me.btnDashBoard.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnDashBoard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashBoard.FlatAppearance.BorderSize = 0
        Me.btnDashBoard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnDashBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashBoard.Font = New System.Drawing.Font("Nunito", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashBoard.ForeColor = System.Drawing.Color.White
        Me.btnDashBoard.Location = New System.Drawing.Point(0, 141)
        Me.btnDashBoard.Name = "btnDashBoard"
        Me.btnDashBoard.Size = New System.Drawing.Size(255, 36)
        Me.btnDashBoard.TabIndex = 3
        Me.btnDashBoard.Text = "     Dashboard"
        Me.btnDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btnDashBoard, "See the overall records.")
        Me.btnDashBoard.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(10, 293)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Account Settings"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(10, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Management"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(26, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Employees Information System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Righteous", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 34)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "EmpInfoSys"
        '
        'panelTopbar
        '
        Me.panelTopbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.panelTopbar.Controls.Add(Me.btnMinimize)
        Me.panelTopbar.Controls.Add(Me.btnClose)
        Me.panelTopbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTopbar.Location = New System.Drawing.Point(255, 0)
        Me.panelTopbar.Name = "panelTopbar"
        Me.panelTopbar.Size = New System.Drawing.Size(1016, 17)
        Me.panelTopbar.TabIndex = 1
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.ImageActive = CType(resources.GetObject("btnMinimize.ImageActive"), System.Drawing.Image)
        Me.btnMinimize.Location = New System.Drawing.Point(979, 6)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(14, 14)
        Me.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimize.TabIndex = 13
        Me.btnMinimize.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnMinimize, "Minimize")
        Me.btnMinimize.Zoom = 10
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageActive = CType(resources.GetObject("btnClose.ImageActive"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(997, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(14, 14)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 13
        Me.btnClose.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnClose, "Close")
        Me.btnClose.Zoom = 10
        '
        'panelBottombar
        '
        Me.panelBottombar.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.panelBottombar.Controls.Add(Me.Label6)
        Me.panelBottombar.Controls.Add(Me.LinkLabel1)
        Me.panelBottombar.Controls.Add(Me.linkAboutSystem)
        Me.panelBottombar.Controls.Add(Me.copyrights)
        Me.panelBottombar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBottombar.Location = New System.Drawing.Point(255, 637)
        Me.panelBottombar.Name = "panelBottombar"
        Me.panelBottombar.Size = New System.Drawing.Size(1016, 34)
        Me.panelBottombar.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(98, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(9, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "|"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(110, 9)
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
        Me.linkAboutSystem.LinkColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.linkAboutSystem.Location = New System.Drawing.Point(11, 9)
        Me.linkAboutSystem.Name = "linkAboutSystem"
        Me.linkAboutSystem.Size = New System.Drawing.Size(85, 16)
        Me.linkAboutSystem.TabIndex = 4
        Me.linkAboutSystem.TabStop = True
        Me.linkAboutSystem.Text = "About System"
        Me.linkAboutSystem.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        '
        'copyrights
        '
        Me.copyrights.AutoSize = True
        Me.copyrights.Font = New System.Drawing.Font("Nunito", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copyrights.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.copyrights.Location = New System.Drawing.Point(522, 10)
        Me.copyrights.Name = "copyrights"
        Me.copyrights.Size = New System.Drawing.Size(491, 14)
        Me.copyrights.TabIndex = 3
        Me.copyrights.Text = "©2020. EmpInfoSys, SPMI Software Origin. Designed and Developed by Jerome Villaru" & _
    "el (VEOSCRIPT)."
        '
        'panelUserControlContainer
        '
        Me.panelUserControlContainer.Controls.Add(Me.UcDashboard1)
        Me.panelUserControlContainer.Controls.Add(Me.UcEmployees1)
        Me.panelUserControlContainer.Controls.Add(Me.UcRegistration1)
        Me.panelUserControlContainer.Controls.Add(Me.UcRecords1)
        Me.panelUserControlContainer.Controls.Add(Me.UcAccountInfo1)
        Me.panelUserControlContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelUserControlContainer.Location = New System.Drawing.Point(255, 17)
        Me.panelUserControlContainer.Name = "panelUserControlContainer"
        Me.panelUserControlContainer.Size = New System.Drawing.Size(1016, 620)
        Me.panelUserControlContainer.TabIndex = 3
        '
        'UcDashboard1
        '
        Me.UcDashboard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UcDashboard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDashboard1.Location = New System.Drawing.Point(0, 0)
        Me.UcDashboard1.Name = "UcDashboard1"
        Me.UcDashboard1.Size = New System.Drawing.Size(1016, 620)
        Me.UcDashboard1.TabIndex = 0
        '
        'UcEmployees1
        '
        Me.UcEmployees1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UcEmployees1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcEmployees1.Location = New System.Drawing.Point(0, 0)
        Me.UcEmployees1.Name = "UcEmployees1"
        Me.UcEmployees1.Size = New System.Drawing.Size(1016, 620)
        Me.UcEmployees1.TabIndex = 2
        '
        'UcRegistration1
        '
        Me.UcRegistration1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UcRegistration1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcRegistration1.Location = New System.Drawing.Point(0, 0)
        Me.UcRegistration1.Name = "UcRegistration1"
        Me.UcRegistration1.Size = New System.Drawing.Size(1016, 620)
        Me.UcRegistration1.TabIndex = 1
        Me.UcRegistration1.Visible = False
        '
        'UcRecords1
        '
        Me.UcRecords1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UcRecords1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcRecords1.Location = New System.Drawing.Point(0, 0)
        Me.UcRecords1.Name = "UcRecords1"
        Me.UcRecords1.Size = New System.Drawing.Size(1016, 620)
        Me.UcRecords1.TabIndex = 3
        Me.UcRecords1.Visible = False
        '
        'UcAccountInfo1
        '
        Me.UcAccountInfo1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UcAccountInfo1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcAccountInfo1.Location = New System.Drawing.Point(0, 0)
        Me.UcAccountInfo1.Name = "UcAccountInfo1"
        Me.UcAccountInfo1.Size = New System.Drawing.Size(1016, 620)
        Me.UcAccountInfo1.TabIndex = 4
        Me.UcAccountInfo1.Visible = False
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.panelMenu
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me.panelTopbar
        Me.BunifuDragControl2.Vertical = True
        '
        'DashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1271, 671)
        Me.Controls.Add(Me.panelUserControlContainer)
        Me.Controls.Add(Me.panelBottombar)
        Me.Controls.Add(Me.panelTopbar)
        Me.Controls.Add(Me.panelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DashBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EIS"
        Me.panelMenu.ResumeLayout(False)
        Me.panelMenu.PerformLayout()
        Me.panelTopbar.ResumeLayout(False)
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBottombar.ResumeLayout(False)
        Me.panelBottombar.PerformLayout()
        Me.panelUserControlContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelMenu As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panelTopbar As System.Windows.Forms.Panel
    Friend WithEvents panelBottombar As System.Windows.Forms.Panel
    Friend WithEvents btnDashBoard As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnAccountInfo As System.Windows.Forms.Button
    Friend WithEvents btnRecords As System.Windows.Forms.Button
    Friend WithEvents btnEmployees As System.Windows.Forms.Button
    Friend WithEvents btnRegistration As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnMinimize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents copyrights As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents linkAboutSystem As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents panelUserControlContainer As System.Windows.Forms.Panel
    Friend WithEvents UcDashboard1 As EmploInfo.ucDashboard
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents UcRegistration1 As EmploInfo.ucRegistration
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents UcEmployees1 As EmploInfo.ucEmployees
    Friend WithEvents UcRecords1 As EmploInfo.ucRecords
    Friend WithEvents UcAccountInfo1 As EmploInfo.ucAccountInfo
End Class
