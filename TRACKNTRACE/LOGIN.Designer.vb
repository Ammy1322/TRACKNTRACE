<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TXTUSER = New System.Windows.Forms.TextBox
        Me.TXTPASS = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.CMBCOMP = New System.Windows.Forms.ComboBox
        Me.CMBYEAR = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.BTNLOGIN = New System.Windows.Forms.PictureBox
        Me.BTNEXIT = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNLOGIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNEXIT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(273, 338)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TXTUSER
        '
        Me.TXTUSER.BackColor = System.Drawing.Color.LightGray
        Me.TXTUSER.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTUSER.ForeColor = System.Drawing.Color.Black
        Me.TXTUSER.Location = New System.Drawing.Point(451, 190)
        Me.TXTUSER.Name = "TXTUSER"
        Me.TXTUSER.Size = New System.Drawing.Size(191, 27)
        Me.TXTUSER.TabIndex = 4
        '
        'TXTPASS
        '
        Me.TXTPASS.BackColor = System.Drawing.Color.LightGray
        Me.TXTPASS.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPASS.ForeColor = System.Drawing.Color.Black
        Me.TXTPASS.Location = New System.Drawing.Point(451, 224)
        Me.TXTPASS.Name = "TXTPASS"
        Me.TXTPASS.Size = New System.Drawing.Size(191, 27)
        Me.TXTPASS.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(298, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "User Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(298, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(415, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Login"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(298, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Company Name"
        '
        'CMBCOMP
        '
        Me.CMBCOMP.BackColor = System.Drawing.Color.LightGray
        Me.CMBCOMP.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CMBCOMP.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBCOMP.ForeColor = System.Drawing.Color.Black
        Me.CMBCOMP.FormattingEnabled = True
        Me.CMBCOMP.Location = New System.Drawing.Point(451, 124)
        Me.CMBCOMP.Name = "CMBCOMP"
        Me.CMBCOMP.Size = New System.Drawing.Size(191, 27)
        Me.CMBCOMP.TabIndex = 11
        '
        'CMBYEAR
        '
        Me.CMBYEAR.BackColor = System.Drawing.Color.LightGray
        Me.CMBYEAR.Enabled = False
        Me.CMBYEAR.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CMBYEAR.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBYEAR.ForeColor = System.Drawing.Color.Black
        Me.CMBYEAR.FormattingEnabled = True
        Me.CMBYEAR.Location = New System.Drawing.Point(451, 157)
        Me.CMBYEAR.Name = "CMBYEAR"
        Me.CMBYEAR.Size = New System.Drawing.Size(191, 27)
        Me.CMBYEAR.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(298, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 23)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Financial Year"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(514, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 58)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "هيا نبدأ"
        '
        'BTNLOGIN
        '
        Me.BTNLOGIN.Image = CType(resources.GetObject("BTNLOGIN.Image"), System.Drawing.Image)
        Me.BTNLOGIN.Location = New System.Drawing.Point(421, 271)
        Me.BTNLOGIN.Name = "BTNLOGIN"
        Me.BTNLOGIN.Size = New System.Drawing.Size(102, 43)
        Me.BTNLOGIN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNLOGIN.TabIndex = 18
        Me.BTNLOGIN.TabStop = False
        '
        'BTNEXIT
        '
        Me.BTNEXIT.Image = CType(resources.GetObject("BTNEXIT.Image"), System.Drawing.Image)
        Me.BTNEXIT.Location = New System.Drawing.Point(529, 271)
        Me.BTNEXIT.Name = "BTNEXIT"
        Me.BTNEXIT.Size = New System.Drawing.Size(104, 43)
        Me.BTNEXIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNEXIT.TabIndex = 19
        Me.BTNEXIT.TabStop = False
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(662, 356)
        Me.Controls.Add(Me.BTNEXIT)
        Me.Controls.Add(Me.BTNLOGIN)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CMBYEAR)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CMBCOMP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTPASS)
        Me.Controls.Add(Me.TXTUSER)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Name = "LOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNLOGIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNEXIT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TXTUSER As System.Windows.Forms.TextBox
    Friend WithEvents TXTPASS As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CMBCOMP As System.Windows.Forms.ComboBox
    Friend WithEvents CMBYEAR As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BTNLOGIN As System.Windows.Forms.PictureBox
    Friend WithEvents BTNEXIT As System.Windows.Forms.PictureBox

End Class
