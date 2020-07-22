<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAddEmployee
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
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMiddlename = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtFirstname = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtSearch = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtDateHired = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.txtLastname = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbEmploymentStatus = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPosition = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtSalary = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtGender = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtIdNumber = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblEmploymentStatus = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Righteous", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(397, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 24)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "ADD NEW EMPLOYEE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(27, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Middle Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(25, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(209, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 16)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Search Employee Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(823, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Date Hired"
        '
        'txtMiddlename
        '
        Me.txtMiddlename.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtMiddlename.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtMiddlename.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtMiddlename.BorderThickness = 2
        Me.txtMiddlename.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMiddlename.Enabled = False
        Me.txtMiddlename.Font = New System.Drawing.Font("Nunito", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddlename.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtMiddlename.isPassword = False
        Me.txtMiddlename.Location = New System.Drawing.Point(26, 320)
        Me.txtMiddlename.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMiddlename.Name = "txtMiddlename"
        Me.txtMiddlename.Size = New System.Drawing.Size(319, 34)
        Me.txtMiddlename.TabIndex = 23
        Me.txtMiddlename.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtFirstname
        '
        Me.txtFirstname.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtFirstname.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtFirstname.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtFirstname.BorderThickness = 2
        Me.txtFirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstname.Enabled = False
        Me.txtFirstname.Font = New System.Drawing.Font("Nunito", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtFirstname.isPassword = False
        Me.txtFirstname.Location = New System.Drawing.Point(26, 263)
        Me.txtFirstname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(319, 34)
        Me.txtFirstname.TabIndex = 22
        Me.txtFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtSearch
        '
        Me.txtSearch.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtSearch.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtSearch.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtSearch.BorderThickness = 2
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.Font = New System.Drawing.Font("Nunito", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.White
        Me.txtSearch.isPassword = False
        Me.txtSearch.Location = New System.Drawing.Point(374, 1)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(443, 34)
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtDateHired
        '
        Me.txtDateHired.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtDateHired.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtDateHired.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtDateHired.BorderThickness = 2
        Me.txtDateHired.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDateHired.Enabled = False
        Me.txtDateHired.Font = New System.Drawing.Font("Nunito", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateHired.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtDateHired.isPassword = False
        Me.txtDateHired.Location = New System.Drawing.Point(810, -1)
        Me.txtDateHired.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDateHired.Name = "txtDateHired"
        Me.txtDateHired.Size = New System.Drawing.Size(206, 38)
        Me.txtDateHired.TabIndex = 21
        Me.txtDateHired.Text = "9/13/2020"
        Me.txtDateHired.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BunifuSeparator2)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(818, 36)
        Me.Panel1.TabIndex = 49
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 3
        Me.BunifuSeparator2.Location = New System.Drawing.Point(367, -1)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(10, 37)
        Me.BunifuSeparator2.TabIndex = 50
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = True
        '
        'txtLastname
        '
        Me.txtLastname.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtLastname.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtLastname.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtLastname.BorderThickness = 2
        Me.txtLastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastname.Enabled = False
        Me.txtLastname.Font = New System.Drawing.Font("Nunito", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtLastname.isPassword = False
        Me.txtLastname.Location = New System.Drawing.Point(26, 205)
        Me.txtLastname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(319, 34)
        Me.txtLastname.TabIndex = 22
        Me.txtLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(25, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Last Name"
        '
        'cmbEmploymentStatus
        '
        Me.cmbEmploymentStatus.BackColor = System.Drawing.Color.Transparent
        Me.cmbEmploymentStatus.BorderRadius = 0
        Me.cmbEmploymentStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbEmploymentStatus.DisabledColor = System.Drawing.Color.Gray
        Me.cmbEmploymentStatus.Font = New System.Drawing.Font("Nunito", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmploymentStatus.ForeColor = System.Drawing.Color.White
        Me.cmbEmploymentStatus.Items = New String() {"", "PROBATIONARY", "REGULAR/UNION", "REGULAR/NON-UNION", "AGENCY"}
        Me.cmbEmploymentStatus.Location = New System.Drawing.Point(400, 184)
        Me.cmbEmploymentStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbEmploymentStatus.Name = "cmbEmploymentStatus"
        Me.cmbEmploymentStatus.NomalColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.cmbEmploymentStatus.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.cmbEmploymentStatus.selectedIndex = -1
        Me.cmbEmploymentStatus.Size = New System.Drawing.Size(398, 33)
        Me.cmbEmploymentStatus.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(398, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 16)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Employment Status"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(398, 222)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 16)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Position"
        '
        'txtPosition
        '
        Me.txtPosition.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtPosition.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtPosition.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtPosition.BorderThickness = 2
        Me.txtPosition.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPosition.Font = New System.Drawing.Font("Nunito", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtPosition.isPassword = False
        Me.txtPosition.Location = New System.Drawing.Point(398, 241)
        Me.txtPosition.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(397, 34)
        Me.txtPosition.TabIndex = 3
        Me.txtPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtSalary
        '
        Me.txtSalary.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtSalary.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtSalary.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtSalary.BorderThickness = 2
        Me.txtSalary.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSalary.Font = New System.Drawing.Font("Nunito", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtSalary.isPassword = False
        Me.txtSalary.Location = New System.Drawing.Point(398, 299)
        Me.txtSalary.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(397, 34)
        Me.txtSalary.TabIndex = 4
        Me.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(396, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Salary Details"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(400, 349)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(76, 30)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.ToolTip1.SetToolTip(Me.btnAdd, "For New Employee.")
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(477, 349)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(73, 30)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtGender)
        Me.Panel2.Controls.Add(Me.txtIdNumber)
        Me.Panel2.Controls.Add(Me.lblEmploymentStatus)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txtLastname)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtFirstname)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txtMiddlename)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(0, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(373, 546)
        Me.Panel2.TabIndex = 52
        '
        'txtGender
        '
        Me.txtGender.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtGender.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtGender.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtGender.BorderThickness = 2
        Me.txtGender.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGender.Enabled = False
        Me.txtGender.Font = New System.Drawing.Font("Nunito", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtGender.isPassword = False
        Me.txtGender.Location = New System.Drawing.Point(208, 148)
        Me.txtGender.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(137, 34)
        Me.txtGender.TabIndex = 22
        Me.txtGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtIdNumber
        '
        Me.txtIdNumber.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtIdNumber.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtIdNumber.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtIdNumber.BorderThickness = 2
        Me.txtIdNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdNumber.Enabled = False
        Me.txtIdNumber.Font = New System.Drawing.Font("Nunito", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtIdNumber.isPassword = False
        Me.txtIdNumber.Location = New System.Drawing.Point(26, 148)
        Me.txtIdNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdNumber.Name = "txtIdNumber"
        Me.txtIdNumber.Size = New System.Drawing.Size(179, 34)
        Me.txtIdNumber.TabIndex = 22
        Me.txtIdNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(209, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 16)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Gender"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(27, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 16)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "ID Number"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Righteous", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(26, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(171, 24)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "SEARCH RESULT"
        '
        'Timer1
        '
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(707, 349)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(88, 30)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.ToolTip1.SetToolTip(Me.btnUpdate, "For Promotions Update Only.")
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'lblEmploymentStatus
        '
        Me.lblEmploymentStatus.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmploymentStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.lblEmploymentStatus.Location = New System.Drawing.Point(203, 66)
        Me.lblEmploymentStatus.Name = "lblEmploymentStatus"
        Me.lblEmploymentStatus.Size = New System.Drawing.Size(150, 16)
        Me.lblEmploymentStatus.TabIndex = 36
        Me.lblEmploymentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ucAddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbEmploymentStatus)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.txtDateHired)
        Me.Name = "ucAddEmployee"
        Me.Size = New System.Drawing.Size(1016, 582)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMiddlename As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtFirstname As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtSearch As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtDateHired As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents txtLastname As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbEmploymentStatus As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPosition As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtSalary As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtGender As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtIdNumber As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lblEmploymentStatus As System.Windows.Forms.Label

End Class
