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
        Me.BTNLOGIN = New System.Windows.Forms.Button
        Me.BTNEXIT = New System.Windows.Forms.Button
        Me.TXTUSER = New System.Windows.Forms.TextBox
        Me.TXTPASS = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.CMBCOMP = New System.Windows.Forms.ComboBox
        Me.CMBYEAR = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, -49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(273, 222)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BTNLOGIN
        '
        Me.BTNLOGIN.BackColor = System.Drawing.Color.Wheat
        Me.BTNLOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNLOGIN.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLOGIN.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BTNLOGIN.Location = New System.Drawing.Point(310, 212)
        Me.BTNLOGIN.Name = "BTNLOGIN"
        Me.BTNLOGIN.Size = New System.Drawing.Size(81, 37)
        Me.BTNLOGIN.TabIndex = 2
        Me.BTNLOGIN.Text = "LOGIN"
        Me.BTNLOGIN.UseVisualStyleBackColor = False
        '
        'BTNEXIT
        '
        Me.BTNEXIT.BackColor = System.Drawing.Color.Wheat
        Me.BTNEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNEXIT.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEXIT.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BTNEXIT.Location = New System.Drawing.Point(431, 212)
        Me.BTNEXIT.Name = "BTNEXIT"
        Me.BTNEXIT.Size = New System.Drawing.Size(81, 37)
        Me.BTNEXIT.TabIndex = 3
        Me.BTNEXIT.Text = "EXIT"
        Me.BTNEXIT.UseVisualStyleBackColor = False
        '
        'TXTUSER
        '
        Me.TXTUSER.BackColor = System.Drawing.Color.Wheat
        Me.TXTUSER.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTUSER.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TXTUSER.Location = New System.Drawing.Point(372, 124)
        Me.TXTUSER.Name = "TXTUSER"
        Me.TXTUSER.Size = New System.Drawing.Size(158, 23)
        Me.TXTUSER.TabIndex = 4
        '
        'TXTPASS
        '
        Me.TXTPASS.BackColor = System.Drawing.Color.Wheat
        Me.TXTPASS.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPASS.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TXTPASS.Location = New System.Drawing.Point(372, 153)
        Me.TXTPASS.Name = "TXTPASS"
        Me.TXTPASS.Size = New System.Drawing.Size(158, 23)
        Me.TXTPASS.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label2.Location = New System.Drawing.Point(295, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "USER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label3.Location = New System.Drawing.Point(295, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "PASS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label4.Location = New System.Drawing.Point(18, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(255, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Wayinfotech Solutions Pvt Ltd ."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label1.Location = New System.Drawing.Point(369, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LOGIN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label5.Location = New System.Drawing.Point(295, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "CNAME"
        '
        'CMBCOMP
        '
        Me.CMBCOMP.BackColor = System.Drawing.Color.Wheat
        Me.CMBCOMP.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CMBCOMP.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.CMBCOMP.FormattingEnabled = True
        Me.CMBCOMP.Location = New System.Drawing.Point(372, 66)
        Me.CMBCOMP.Name = "CMBCOMP"
        Me.CMBCOMP.Size = New System.Drawing.Size(158, 23)
        Me.CMBCOMP.TabIndex = 11
        '
        'CMBYEAR
        '
        Me.CMBYEAR.BackColor = System.Drawing.Color.Wheat
        Me.CMBYEAR.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CMBYEAR.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.CMBYEAR.FormattingEnabled = True
        Me.CMBYEAR.Location = New System.Drawing.Point(372, 95)
        Me.CMBYEAR.Name = "CMBYEAR"
        Me.CMBYEAR.Size = New System.Drawing.Size(158, 23)
        Me.CMBYEAR.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label6.Location = New System.Drawing.Point(295, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 23)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "YEAR"
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(542, 261)
        Me.Controls.Add(Me.CMBYEAR)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CMBCOMP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTPASS)
        Me.Controls.Add(Me.TXTUSER)
        Me.Controls.Add(Me.BTNEXIT)
        Me.Controls.Add(Me.BTNLOGIN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Name = "LOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BTNLOGIN As System.Windows.Forms.Button
    Friend WithEvents BTNEXIT As System.Windows.Forms.Button
    Friend WithEvents TXTUSER As System.Windows.Forms.TextBox
    Friend WithEvents TXTPASS As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CMBCOMP As System.Windows.Forms.ComboBox
    Friend WithEvents CMBYEAR As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
