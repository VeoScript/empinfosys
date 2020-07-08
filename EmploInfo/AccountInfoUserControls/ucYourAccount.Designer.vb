<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucYourAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucYourAccount))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAccountName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(394, 172)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(219, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(412, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Specialty Pulp Manufacturing Inc."
        '
        'lblAccountName
        '
        Me.lblAccountName.Font = New System.Drawing.Font("Nunito", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblAccountName.Location = New System.Drawing.Point(106, 269)
        Me.lblAccountName.Name = "lblAccountName"
        Me.lblAccountName.Size = New System.Drawing.Size(804, 34)
        Me.lblAccountName.TabIndex = 12
        Me.lblAccountName.Text = "JEROME VILLARUEL"
        Me.lblAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Nunito", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(106, 334)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(804, 22)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "IT COORDINATOR"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(480, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "NAME"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nunito", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(473, 357)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "POSITION"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucYourAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblAccountName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ucYourAccount"
        Me.Size = New System.Drawing.Size(1016, 578)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAccountName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
