<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockTransfer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockTransfer))
        Me.BtnSave = New System.Windows.Forms.PictureBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.FORMNAME = New System.Windows.Forms.Label
        Me.TXTDATE = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Grid1 = New FlexCell.Grid
        Me.TXTBARCODE = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CMBINAME = New System.Windows.Forms.ComboBox
        Me.MCODE = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BTNNEW = New System.Windows.Forms.PictureBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TN = New System.Windows.Forms.Label
        Me.TXTCOUNTER = New System.Windows.Forms.Label
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BTNNEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(580, 427)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(89, 33)
        Me.BtnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnSave.TabIndex = 225
        Me.BtnSave.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(66, 18)
        Me.TextBox1.MaxLength = 50
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(102, 22)
        Me.TextBox1.TabIndex = 214
        Me.TextBox1.Text = "*****"
        '
        'FORMNAME
        '
        Me.FORMNAME.AutoSize = True
        Me.FORMNAME.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FORMNAME.ForeColor = System.Drawing.Color.Black
        Me.FORMNAME.Location = New System.Drawing.Point(254, 18)
        Me.FORMNAME.Name = "FORMNAME"
        Me.FORMNAME.Size = New System.Drawing.Size(0, 25)
        Me.FORMNAME.TabIndex = 219
        '
        'TXTDATE
        '
        Me.TXTDATE.Enabled = False
        Me.TXTDATE.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDATE.Location = New System.Drawing.Point(14, 13)
        Me.TXTDATE.Name = "TXTDATE"
        Me.TXTDATE.Size = New System.Drawing.Size(110, 26)
        Me.TXTDATE.TabIndex = 224
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Grid1)
        Me.GroupBox2.Controls.Add(Me.TXTBARCODE)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.CMBINAME)
        Me.GroupBox2.Controls.Add(Me.MCODE)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(662, 378)
        Me.GroupBox2.TabIndex = 220
        Me.GroupBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(11, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 213
        Me.Label6.Text = "Trno :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(569, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 19)
        Me.Label4.TabIndex = 199
        Me.Label4.Text = "--------------"
        '
        'Grid1
        '
        Me.Grid1.BackColor2 = System.Drawing.Color.Gainsboro
        Me.Grid1.BackColorFixed = System.Drawing.Color.Gainsboro
        Me.Grid1.CheckedImage = CType(resources.GetObject("Grid1.CheckedImage"), System.Drawing.Bitmap)
        Me.Grid1.DefaultFont = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!)
        Me.Grid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Grid1.Location = New System.Drawing.Point(5, 93)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Rows = 2
        Me.Grid1.Size = New System.Drawing.Size(647, 277)
        Me.Grid1.TabIndex = 198
        Me.Grid1.UncheckedImage = CType(resources.GetObject("Grid1.UncheckedImage"), System.Drawing.Bitmap)
        '
        'TXTBARCODE
        '
        Me.TXTBARCODE.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TXTBARCODE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTBARCODE.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBARCODE.Location = New System.Drawing.Point(130, 56)
        Me.TXTBARCODE.MaxLength = 50
        Me.TXTBARCODE.Name = "TXTBARCODE"
        Me.TXTBARCODE.Size = New System.Drawing.Size(393, 22)
        Me.TXTBARCODE.TabIndex = 197
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(10, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 19)
        Me.Label3.TabIndex = 196
        Me.Label3.Text = "PalletNo :"
        '
        'CMBINAME
        '
        Me.CMBINAME.FormattingEnabled = True
        Me.CMBINAME.Location = New System.Drawing.Point(259, 19)
        Me.CMBINAME.Name = "CMBINAME"
        Me.CMBINAME.Size = New System.Drawing.Size(154, 21)
        Me.CMBINAME.TabIndex = 195
        '
        'MCODE
        '
        Me.MCODE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MCODE.Enabled = False
        Me.MCODE.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MCODE.Location = New System.Drawing.Point(499, 18)
        Me.MCODE.MaxLength = 50
        Me.MCODE.Name = "MCODE"
        Me.MCODE.Size = New System.Drawing.Size(155, 22)
        Me.MCODE.TabIndex = 190
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(416, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Item Code :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(174, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Item Name :"
        '
        'BTNNEW
        '
        Me.BTNNEW.Image = CType(resources.GetObject("BTNNEW.Image"), System.Drawing.Image)
        Me.BTNNEW.Location = New System.Drawing.Point(490, 427)
        Me.BTNNEW.Name = "BTNNEW"
        Me.BTNNEW.Size = New System.Drawing.Size(84, 33)
        Me.BTNNEW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNNEW.TabIndex = 226
        Me.BTNNEW.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Gainsboro
        Me.Label11.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(260, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(162, 29)
        Me.Label11.TabIndex = 221
        Me.Label11.Text = "Stock Transfer"
        '
        'TN
        '
        Me.TN.AutoSize = True
        Me.TN.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TN.ForeColor = System.Drawing.Color.Black
        Me.TN.Location = New System.Drawing.Point(583, 10)
        Me.TN.Name = "TN"
        Me.TN.Size = New System.Drawing.Size(26, 29)
        Me.TN.TabIndex = 223
        Me.TN.Text = "0"
        '
        'TXTCOUNTER
        '
        Me.TXTCOUNTER.AutoSize = True
        Me.TXTCOUNTER.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCOUNTER.ForeColor = System.Drawing.Color.Black
        Me.TXTCOUNTER.Location = New System.Drawing.Point(614, 10)
        Me.TXTCOUNTER.Name = "TXTCOUNTER"
        Me.TXTCOUNTER.Size = New System.Drawing.Size(26, 29)
        Me.TXTCOUNTER.TabIndex = 222
        Me.TXTCOUNTER.Text = "0"
        '
        'StockTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(677, 462)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.FORMNAME)
        Me.Controls.Add(Me.TXTDATE)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BTNNEW)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TN)
        Me.Controls.Add(Me.TXTCOUNTER)
        Me.Name = "StockTransfer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StockTransfer"
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BTNNEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSave As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents FORMNAME As System.Windows.Forms.Label
    Friend WithEvents TXTDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Grid1 As FlexCell.Grid
    Friend WithEvents TXTBARCODE As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CMBINAME As System.Windows.Forms.ComboBox
    Friend WithEvents MCODE As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BTNNEW As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TN As System.Windows.Forms.Label
    Friend WithEvents TXTCOUNTER As System.Windows.Forms.Label
End Class
