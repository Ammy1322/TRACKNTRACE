<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SCANNING
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SCANNING))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CMBTYPE = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.CMBLINE = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Grid2 = New FlexCell.Grid
        Me.TXTBARCODE = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CMBINAME = New System.Windows.Forms.ComboBox
        Me.MCODE = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.FORMNAME = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.TXTCOUNTER = New System.Windows.Forms.Label
        Me.TN = New System.Windows.Forms.Label
        Me.TXTDATE = New System.Windows.Forms.DateTimePicker
        Me.TXTREJECT = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.WsmbtControl1 = New WSMBT.WSMBTControl(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.CMBTYPE)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.CMBLINE)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Grid2)
        Me.GroupBox2.Controls.Add(Me.TXTBARCODE)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.CMBINAME)
        Me.GroupBox2.Controls.Add(Me.MCODE)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 109)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(662, 349)
        Me.GroupBox2.TabIndex = 201
        Me.GroupBox2.TabStop = False
        '
        'CMBTYPE
        '
        Me.CMBTYPE.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBTYPE.FormattingEnabled = True
        Me.CMBTYPE.Items.AddRange(New Object() {"PRODUCTION", "SAMPLING", "TESTING"})
        Me.CMBTYPE.Location = New System.Drawing.Point(409, 13)
        Me.CMBTYPE.Name = "CMBTYPE"
        Me.CMBTYPE.Size = New System.Drawing.Size(245, 21)
        Me.CMBTYPE.TabIndex = 203
        Me.CMBTYPE.Text = "PRODUCTION"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(352, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 202
        Me.Label6.Text = "Type :"
        '
        'CMBLINE
        '
        Me.CMBLINE.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBLINE.FormattingEnabled = True
        Me.CMBLINE.Location = New System.Drawing.Point(409, 42)
        Me.CMBLINE.Name = "CMBLINE"
        Me.CMBLINE.Size = New System.Drawing.Size(245, 21)
        Me.CMBLINE.TabIndex = 201
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(352, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 200
        Me.Label5.Text = "Line   :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(455, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 19)
        Me.Label4.TabIndex = 199
        Me.Label4.Text = "---------------------"
        '
        'Grid2
        '
        Me.Grid2.BackColor2 = System.Drawing.Color.Gainsboro
        Me.Grid2.BackColorFixed = System.Drawing.Color.Gainsboro
        Me.Grid2.CheckedImage = CType(resources.GetObject("Grid2.CheckedImage"), System.Drawing.Bitmap)
        Me.Grid2.DefaultFont = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!)
        Me.Grid2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid2.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Grid2.Location = New System.Drawing.Point(7, 99)
        Me.Grid2.Name = "Grid2"
        Me.Grid2.Size = New System.Drawing.Size(647, 247)
        Me.Grid2.TabIndex = 198
        Me.Grid2.UncheckedImage = CType(resources.GetObject("Grid2.UncheckedImage"), System.Drawing.Bitmap)
        '
        'TXTBARCODE
        '
        Me.TXTBARCODE.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TXTBARCODE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTBARCODE.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBARCODE.Location = New System.Drawing.Point(94, 71)
        Me.TXTBARCODE.MaxLength = 50
        Me.TXTBARCODE.Name = "TXTBARCODE"
        Me.TXTBARCODE.Size = New System.Drawing.Size(254, 21)
        Me.TXTBARCODE.TabIndex = 197
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 196
        Me.Label3.Text = "Qrcode"
        '
        'CMBINAME
        '
        Me.CMBINAME.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBINAME.FormattingEnabled = True
        Me.CMBINAME.Location = New System.Drawing.Point(93, 13)
        Me.CMBINAME.Name = "CMBINAME"
        Me.CMBINAME.Size = New System.Drawing.Size(255, 21)
        Me.CMBINAME.TabIndex = 195
        '
        'MCODE
        '
        Me.MCODE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MCODE.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MCODE.Location = New System.Drawing.Point(93, 42)
        Me.MCODE.MaxLength = 50
        Me.MCODE.Name = "MCODE"
        Me.MCODE.Size = New System.Drawing.Size(255, 21)
        Me.MCODE.TabIndex = 190
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Item Code :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Item Name :"
        '
        'FORMNAME
        '
        Me.FORMNAME.AutoSize = True
        Me.FORMNAME.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FORMNAME.ForeColor = System.Drawing.Color.Black
        Me.FORMNAME.Location = New System.Drawing.Point(252, 11)
        Me.FORMNAME.Name = "FORMNAME"
        Me.FORMNAME.Size = New System.Drawing.Size(0, 29)
        Me.FORMNAME.TabIndex = 199
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(199, 5)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(223, 29)
        Me.Label11.TabIndex = 202
        Me.Label11.Text = "Product Generation"
        '
        'TXTCOUNTER
        '
        Me.TXTCOUNTER.AutoSize = True
        Me.TXTCOUNTER.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 18.0!)
        Me.TXTCOUNTER.ForeColor = System.Drawing.Color.Black
        Me.TXTCOUNTER.Location = New System.Drawing.Point(598, 48)
        Me.TXTCOUNTER.Name = "TXTCOUNTER"
        Me.TXTCOUNTER.Size = New System.Drawing.Size(26, 29)
        Me.TXTCOUNTER.TabIndex = 203
        Me.TXTCOUNTER.Text = "0"
        '
        'TN
        '
        Me.TN.AutoSize = True
        Me.TN.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TN.ForeColor = System.Drawing.Color.Black
        Me.TN.Location = New System.Drawing.Point(141, 3)
        Me.TN.Name = "TN"
        Me.TN.Size = New System.Drawing.Size(26, 29)
        Me.TN.TabIndex = 204
        Me.TN.Text = "0"
        Me.TN.Visible = False
        '
        'TXTDATE
        '
        Me.TXTDATE.Enabled = False
        Me.TXTDATE.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDATE.Location = New System.Drawing.Point(12, 7)
        Me.TXTDATE.Name = "TXTDATE"
        Me.TXTDATE.Size = New System.Drawing.Size(123, 26)
        Me.TXTDATE.TabIndex = 200
        '
        'TXTREJECT
        '
        Me.TXTREJECT.AutoSize = True
        Me.TXTREJECT.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 18.0!)
        Me.TXTREJECT.ForeColor = System.Drawing.Color.Black
        Me.TXTREJECT.Location = New System.Drawing.Point(597, 77)
        Me.TXTREJECT.Name = "TXTREJECT"
        Me.TXTREJECT.Size = New System.Drawing.Size(26, 29)
        Me.TXTREJECT.TabIndex = 205
        Me.TXTREJECT.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(457, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 29)
        Me.Label7.TabIndex = 206
        Me.Label7.Text = "Approved :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(457, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 29)
        Me.Label8.TabIndex = 207
        Me.Label8.Text = "Rejected  :"
        '
        'WsmbtControl1
        '
        Me.WsmbtControl1.ConnectTimeout = 1000
        Me.WsmbtControl1.Mode = WSMBT.Mode.TCP_IP
        Me.WsmbtControl1.ResponseTimeout = 1000
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(680, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 208
        Me.Button1.Text = "reject"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(798, 46)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 209
        Me.Button2.Text = "accept"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(697, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 29)
        Me.Label9.TabIndex = 210
        Me.Label9.Text = "0"
        '
        'SCANNING
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(674, 459)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TXTREJECT)
        Me.Controls.Add(Me.TXTDATE)
        Me.Controls.Add(Me.TN)
        Me.Controls.Add(Me.TXTCOUNTER)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.FORMNAME)
        Me.Controls.Add(Me.Label11)
        Me.Name = "SCANNING"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Generation"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CMBINAME As System.Windows.Forms.ComboBox
    Friend WithEvents MCODE As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FORMNAME As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TXTBARCODE As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Grid2 As FlexCell.Grid
    Friend WithEvents TXTCOUNTER As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TN As System.Windows.Forms.Label
    Friend WithEvents TXTDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents CMBLINE As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CMBTYPE As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXTREJECT As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents WsmbtControl1 As WSMBT.WSMBTControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
