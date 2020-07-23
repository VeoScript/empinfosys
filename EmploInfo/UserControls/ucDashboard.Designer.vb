<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucDashboard))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.panelNoEmployee = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblCountRegularEmployees = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblCountProbationary = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblCountAgency = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lblCountUnion = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblCountNonUnion = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.lblCountTotalEmployees = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.lblAccountName = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.panelNoEmployee.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nunito", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(68, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "DASHBOARD"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 3
        Me.BunifuSeparator1.Location = New System.Drawing.Point(72, 59)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(47, 10)
        Me.BunifuSeparator1.TabIndex = 5
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 3
        Me.BunifuSeparator2.Location = New System.Drawing.Point(119, 59)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(63, 10)
        Me.BunifuSeparator2.TabIndex = 5
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'panelNoEmployee
        '
        Me.panelNoEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelNoEmployee.Controls.Add(Me.PictureBox1)
        Me.panelNoEmployee.Controls.Add(Me.lblCountRegularEmployees)
        Me.panelNoEmployee.Controls.Add(Me.Label4)
        Me.panelNoEmployee.Controls.Add(Me.Label1)
        Me.panelNoEmployee.Location = New System.Drawing.Point(110, 120)
        Me.panelNoEmployee.Name = "panelNoEmployee"
        Me.panelNoEmployee.Size = New System.Drawing.Size(237, 126)
        Me.panelNoEmployee.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(195, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'lblCountRegularEmployees
        '
        Me.lblCountRegularEmployees.Font = New System.Drawing.Font("Righteous", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountRegularEmployees.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblCountRegularEmployees.Location = New System.Drawing.Point(0, 46)
        Me.lblCountRegularEmployees.Name = "lblCountRegularEmployees"
        Me.lblCountRegularEmployees.Size = New System.Drawing.Size(236, 52)
        Me.lblCountRegularEmployees.TabIndex = 4
        Me.lblCountRegularEmployees.Text = "0"
        Me.lblCountRegularEmployees.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Font = New System.Drawing.Font("Nunito", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(0, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(235, 10)
        Me.Label4.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nunito", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Regular Employees"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.lblCountProbationary)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(382, 120)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(237, 126)
        Me.Panel1.TabIndex = 6
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(195, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'lblCountProbationary
        '
        Me.lblCountProbationary.Font = New System.Drawing.Font("Righteous", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountProbationary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblCountProbationary.Location = New System.Drawing.Point(0, 46)
        Me.lblCountProbationary.Name = "lblCountProbationary"
        Me.lblCountProbationary.Size = New System.Drawing.Size(236, 52)
        Me.lblCountProbationary.TabIndex = 4
        Me.lblCountProbationary.Text = "0"
        Me.lblCountProbationary.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label6.Font = New System.Drawing.Font("Nunito", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(0, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(235, 10)
        Me.Label6.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nunito", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(8, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 21)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Probationary"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.lblCountAgency)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(655, 120)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(237, 126)
        Me.Panel2.TabIndex = 6
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(195, 11)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 27)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'lblCountAgency
        '
        Me.lblCountAgency.Font = New System.Drawing.Font("Righteous", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountAgency.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblCountAgency.Location = New System.Drawing.Point(0, 46)
        Me.lblCountAgency.Name = "lblCountAgency"
        Me.lblCountAgency.Size = New System.Drawing.Size(236, 52)
        Me.lblCountAgency.TabIndex = 4
        Me.lblCountAgency.Text = "0"
        Me.lblCountAgency.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label9.Font = New System.Drawing.Font("Nunito", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(0, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(235, 10)
        Me.Label9.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Nunito", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(12, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 21)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Agency"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Controls.Add(Me.lblCountUnion)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Location = New System.Drawing.Point(110, 280)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(237, 126)
        Me.Panel3.TabIndex = 6
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(194, 11)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 27)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'lblCountUnion
        '
        Me.lblCountUnion.Font = New System.Drawing.Font("Righteous", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountUnion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblCountUnion.Location = New System.Drawing.Point(-1, 46)
        Me.lblCountUnion.Name = "lblCountUnion"
        Me.lblCountUnion.Size = New System.Drawing.Size(236, 52)
        Me.lblCountUnion.TabIndex = 4
        Me.lblCountUnion.Text = "0"
        Me.lblCountUnion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label12.Font = New System.Drawing.Font("Nunito", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(0, 114)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(235, 10)
        Me.Label12.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Nunito", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(8, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 21)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "UNION"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.PictureBox5)
        Me.Panel4.Controls.Add(Me.lblCountNonUnion)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Location = New System.Drawing.Point(382, 279)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(237, 126)
        Me.Panel4.TabIndex = 6
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(194, 11)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(30, 27)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        '
        'lblCountNonUnion
        '
        Me.lblCountNonUnion.Font = New System.Drawing.Font("Righteous", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountNonUnion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblCountNonUnion.Location = New System.Drawing.Point(0, 46)
        Me.lblCountNonUnion.Name = "lblCountNonUnion"
        Me.lblCountNonUnion.Size = New System.Drawing.Size(236, 52)
        Me.lblCountNonUnion.TabIndex = 4
        Me.lblCountNonUnion.Text = "0"
        Me.lblCountNonUnion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label15.Font = New System.Drawing.Font("Nunito", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(0, 114)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(235, 10)
        Me.Label15.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Nunito", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(8, 13)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 21)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "NON-UNION"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.PictureBox6)
        Me.Panel5.Controls.Add(Me.lblCountTotalEmployees)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Controls.Add(Me.Label19)
        Me.Panel5.Location = New System.Drawing.Point(654, 279)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(237, 126)
        Me.Panel5.TabIndex = 6
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(194, 11)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(30, 27)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        '
        'lblCountTotalEmployees
        '
        Me.lblCountTotalEmployees.Font = New System.Drawing.Font("Righteous", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountTotalEmployees.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblCountTotalEmployees.Location = New System.Drawing.Point(0, 46)
        Me.lblCountTotalEmployees.Name = "lblCountTotalEmployees"
        Me.lblCountTotalEmployees.Size = New System.Drawing.Size(236, 52)
        Me.lblCountTotalEmployees.TabIndex = 4
        Me.lblCountTotalEmployees.Text = "0"
        Me.lblCountTotalEmployees.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label18.Font = New System.Drawing.Font("Nunito", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(0, 114)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(235, 10)
        Me.Label18.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Nunito", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(8, 13)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(131, 21)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Total Employees"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(269, 457)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(465, 38)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = """Corporate culture matters. How management chooses to treat its people" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "impacts e" & _
    "verything for better and for worse."""
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Nunito", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(450, 501)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 19)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "-Simon Sinek"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 2
        Me.BunifuSeparator3.Location = New System.Drawing.Point(231, 439)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(548, 10)
        Me.BunifuSeparator3.TabIndex = 5
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = False
        '
        'lblAccountName
        '
        Me.lblAccountName.Font = New System.Drawing.Font("Nunito", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblAccountName.Location = New System.Drawing.Point(454, 43)
        Me.lblAccountName.Name = "lblAccountName"
        Me.lblAccountName.Size = New System.Drawing.Size(437, 19)
        Me.lblAccountName.TabIndex = 4
        Me.lblAccountName.Text = "ACCOUNT NAME"
        Me.lblAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPosition
        '
        Me.lblPosition.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblPosition.Location = New System.Drawing.Point(454, 57)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(437, 19)
        Me.lblPosition.TabIndex = 4
        Me.lblPosition.Text = "POSITION"
        Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ucDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.panelNoEmployee)
        Me.Controls.Add(Me.BunifuSeparator3)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.lblAccountName)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPosition)
        Me.Name = "ucDashboard"
        Me.Size = New System.Drawing.Size(1016, 620)
        Me.panelNoEmployee.ResumeLayout(False)
        Me.panelNoEmployee.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents panelNoEmployee As System.Windows.Forms.Panel
    Friend WithEvents lblCountRegularEmployees As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCountProbationary As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblCountAgency As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents lblCountUnion As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents lblCountNonUnion As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents lblCountTotalEmployees As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents lblAccountName As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label

End Class
