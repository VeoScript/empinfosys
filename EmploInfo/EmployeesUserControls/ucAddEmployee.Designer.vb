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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMiddlename = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtFirstname = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtEmployeeNo = New Bunifu.Framework.UI.BunifuMetroTextbox()
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
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Righteous", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 43)
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
        Me.Label4.Location = New System.Drawing.Point(135, 286)
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
        Me.Label3.Location = New System.Drawing.Point(134, 230)
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
        Me.Label1.Location = New System.Drawing.Point(8, 10)
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
        Me.Label5.Location = New System.Drawing.Point(342, 92)
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
        Me.txtMiddlename.Location = New System.Drawing.Point(136, 305)
        Me.txtMiddlename.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMiddlename.Name = "txtMiddlename"
        Me.txtMiddlename.Size = New System.Drawing.Size(302, 34)
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
        Me.txtFirstname.Location = New System.Drawing.Point(135, 248)
        Me.txtFirstname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(302, 34)
        Me.txtFirstname.TabIndex = 22
        Me.txtFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtEmployeeNo
        '
        Me.txtEmployeeNo.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtEmployeeNo.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtEmployeeNo.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtEmployeeNo.BorderThickness = 2
        Me.txtEmployeeNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmployeeNo.Font = New System.Drawing.Font("Nunito", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeNo.ForeColor = System.Drawing.Color.White
        Me.txtEmployeeNo.isPassword = False
        Me.txtEmployeeNo.Location = New System.Drawing.Point(161, 1)
        Me.txtEmployeeNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmployeeNo.Name = "txtEmployeeNo"
        Me.txtEmployeeNo.Size = New System.Drawing.Size(177, 34)
        Me.txtEmployeeNo.TabIndex = 20
        Me.txtEmployeeNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.txtDateHired.Location = New System.Drawing.Point(334, 81)
        Me.txtDateHired.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDateHired.Name = "txtDateHired"
        Me.txtDateHired.Size = New System.Drawing.Size(244, 38)
        Me.txtDateHired.TabIndex = 21
        Me.txtDateHired.Text = "9/13/2020"
        Me.txtDateHired.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BunifuSeparator2)
        Me.Panel1.Controls.Add(Me.txtEmployeeNo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(338, 36)
        Me.Panel1.TabIndex = 49
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 3
        Me.BunifuSeparator2.Location = New System.Drawing.Point(153, 0)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(10, 36)
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
        Me.txtLastname.Location = New System.Drawing.Point(135, 192)
        Me.txtLastname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(302, 34)
        Me.txtLastname.TabIndex = 22
        Me.txtLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(134, 174)
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
        Me.cmbEmploymentStatus.Location = New System.Drawing.Point(445, 193)
        Me.cmbEmploymentStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbEmploymentStatus.Name = "cmbEmploymentStatus"
        Me.cmbEmploymentStatus.NomalColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.cmbEmploymentStatus.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.cmbEmploymentStatus.selectedIndex = -1
        Me.cmbEmploymentStatus.Size = New System.Drawing.Size(295, 33)
        Me.cmbEmploymentStatus.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(440, 173)
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
        Me.Label8.Location = New System.Drawing.Point(441, 229)
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
        Me.txtPosition.Location = New System.Drawing.Point(443, 248)
        Me.txtPosition.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(297, 34)
        Me.txtPosition.TabIndex = 22
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
        Me.txtSalary.Location = New System.Drawing.Point(443, 305)
        Me.txtSalary.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(297, 34)
        Me.txtSalary.TabIndex = 22
        Me.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(441, 286)
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
        Me.btnAdd.Location = New System.Drawing.Point(576, 82)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(162, 36)
        Me.btnAdd.TabIndex = 47
        Me.btnAdd.Text = "ADD"
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
        Me.btnCancel.Location = New System.Drawing.Point(741, 82)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(135, 36)
        Me.btnCancel.TabIndex = 47
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 3
        Me.BunifuSeparator1.Location = New System.Drawing.Point(734, 82)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(10, 36)
        Me.BunifuSeparator1.TabIndex = 50
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = True
        '
        'ucAddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbEmploymentStatus)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMiddlename)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.txtDateHired)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Name = "ucAddEmployee"
        Me.Size = New System.Drawing.Size(876, 436)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents txtEmployeeNo As Bunifu.Framework.UI.BunifuMetroTextbox
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
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator

End Class
