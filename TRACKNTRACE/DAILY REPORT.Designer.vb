<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DAILY_REPORT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DAILY_REPORT))
        Me.Label11 = New System.Windows.Forms.Label
        Me.CMBINAME = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CMBRTYPE = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CMBBARCODE = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.DTTO = New System.Windows.Forms.DateTimePicker
        Me.DTFROM = New System.Windows.Forms.DateTimePicker
        Me.Grid2 = New FlexCell.Grid
        Me.BTNEXCEL = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Grid1 = New FlexCell.Grid
        Me.RBDET = New System.Windows.Forms.RadioButton
        Me.RBCON = New System.Windows.Forms.RadioButton
        Me.CMBLINE = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.CMBICODE = New System.Windows.Forms.ComboBox
        Me.CMBSRNO = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        CType(Me.BTNEXCEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(442, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 29)
        Me.Label11.TabIndex = 203
        Me.Label11.Text = "Reports"
        '
        'CMBINAME
        '
        Me.CMBINAME.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBINAME.FormattingEnabled = True
        Me.CMBINAME.Location = New System.Drawing.Point(124, 88)
        Me.CMBINAME.Name = "CMBINAME"
        Me.CMBINAME.Size = New System.Drawing.Size(180, 21)
        Me.CMBINAME.TabIndex = 206
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(11, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 205
        Me.Label2.Text = "Item Name :"
        '
        'CMBRTYPE
        '
        Me.CMBRTYPE.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBRTYPE.FormattingEnabled = True
        Me.CMBRTYPE.Items.AddRange(New Object() {"Product Generation", "Master Shipper", "Master Pallet", "Order Logged", "Dispatch", "Inspection", "Stock Transfer"})
        Me.CMBRTYPE.Location = New System.Drawing.Point(723, 117)
        Me.CMBRTYPE.Name = "CMBRTYPE"
        Me.CMBRTYPE.Size = New System.Drawing.Size(164, 21)
        Me.CMBRTYPE.TabIndex = 208
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(591, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 207
        Me.Label1.Text = "R.Type   :"
        '
        'CMBBARCODE
        '
        Me.CMBBARCODE.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBBARCODE.FormattingEnabled = True
        Me.CMBBARCODE.Location = New System.Drawing.Point(413, 117)
        Me.CMBBARCODE.Name = "CMBBARCODE"
        Me.CMBBARCODE.Size = New System.Drawing.Size(173, 21)
        Me.CMBBARCODE.TabIndex = 211
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(308, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 19)
        Me.Label3.TabIndex = 210
        Me.Label3.Text = "BarcodeNo :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(218, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 19)
        Me.Label4.TabIndex = 215
        Me.Label4.Text = "Date To"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 19)
        Me.Label5.TabIndex = 214
        Me.Label5.Text = "Date From :"
        '
        'DTTO
        '
        Me.DTTO.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTTO.Location = New System.Drawing.Point(301, 56)
        Me.DTTO.Name = "DTTO"
        Me.DTTO.Size = New System.Drawing.Size(92, 21)
        Me.DTTO.TabIndex = 213
        '
        'DTFROM
        '
        Me.DTFROM.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTFROM.Location = New System.Drawing.Point(125, 56)
        Me.DTFROM.Name = "DTFROM"
        Me.DTFROM.Size = New System.Drawing.Size(85, 21)
        Me.DTFROM.TabIndex = 212
        '
        'Grid2
        '
        Me.Grid2.BackColor2 = System.Drawing.Color.Gainsboro
        Me.Grid2.BackColorFixed = System.Drawing.Color.Gainsboro
        Me.Grid2.BackColorSel = System.Drawing.Color.Black
        Me.Grid2.CheckedImage = CType(resources.GetObject("Grid2.CheckedImage"), System.Drawing.Bitmap)
        Me.Grid2.Cols = 7
        Me.Grid2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid2.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Grid2.Location = New System.Drawing.Point(12, 144)
        Me.Grid2.Name = "Grid2"
        Me.Grid2.Rows = 2
        Me.Grid2.Size = New System.Drawing.Size(1013, 449)
        Me.Grid2.TabIndex = 217
        Me.Grid2.UncheckedImage = CType(resources.GetObject("Grid2.UncheckedImage"), System.Drawing.Bitmap)
        '
        'BTNEXCEL
        '
        Me.BTNEXCEL.Image = CType(resources.GetObject("BTNEXCEL.Image"), System.Drawing.Image)
        Me.BTNEXCEL.Location = New System.Drawing.Point(906, 65)
        Me.BTNEXCEL.Name = "BTNEXCEL"
        Me.BTNEXCEL.Size = New System.Drawing.Size(105, 33)
        Me.BTNEXCEL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNEXCEL.TabIndex = 222
        Me.BTNEXCEL.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(906, 104)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 221
        Me.PictureBox1.TabStop = False
        '
        'Grid1
        '
        Me.Grid1.BackColor2 = System.Drawing.Color.Gainsboro
        Me.Grid1.BackColorFixed = System.Drawing.Color.Gainsboro
        Me.Grid1.BackColorSel = System.Drawing.Color.Black
        Me.Grid1.CheckedImage = CType(resources.GetObject("Grid1.CheckedImage"), System.Drawing.Bitmap)
        Me.Grid1.Cols = 7
        Me.Grid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Grid1.Location = New System.Drawing.Point(12, 599)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Rows = 2
        Me.Grid1.Size = New System.Drawing.Size(1013, 22)
        Me.Grid1.TabIndex = 223
        Me.Grid1.UncheckedImage = CType(resources.GetObject("Grid1.UncheckedImage"), System.Drawing.Bitmap)
        '
        'RBDET
        '
        Me.RBDET.AutoSize = True
        Me.RBDET.Location = New System.Drawing.Point(702, 58)
        Me.RBDET.Name = "RBDET"
        Me.RBDET.Size = New System.Drawing.Size(70, 17)
        Me.RBDET.TabIndex = 224
        Me.RBDET.TabStop = True
        Me.RBDET.Text = "DETAILS"
        Me.RBDET.UseVisualStyleBackColor = True
        '
        'RBCON
        '
        Me.RBCON.AutoSize = True
        Me.RBCON.Location = New System.Drawing.Point(785, 58)
        Me.RBCON.Name = "RBCON"
        Me.RBCON.Size = New System.Drawing.Size(101, 17)
        Me.RBCON.TabIndex = 225
        Me.RBCON.TabStop = True
        Me.RBCON.Text = "CONSOLIDATE"
        Me.RBCON.UseVisualStyleBackColor = True
        '
        'CMBLINE
        '
        Me.CMBLINE.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBLINE.FormattingEnabled = True
        Me.CMBLINE.Location = New System.Drawing.Point(124, 117)
        Me.CMBLINE.Name = "CMBLINE"
        Me.CMBLINE.Size = New System.Drawing.Size(180, 21)
        Me.CMBLINE.TabIndex = 227
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 19)
        Me.Label7.TabIndex = 226
        Me.Label7.Text = "Line :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(307, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 19)
        Me.Label6.TabIndex = 228
        Me.Label6.Text = "Item Code :"
        '
        'CMBICODE
        '
        Me.CMBICODE.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBICODE.FormattingEnabled = True
        Me.CMBICODE.Location = New System.Drawing.Point(413, 88)
        Me.CMBICODE.Name = "CMBICODE"
        Me.CMBICODE.Size = New System.Drawing.Size(173, 21)
        Me.CMBICODE.TabIndex = 229
        '
        'CMBSRNO
        '
        Me.CMBSRNO.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBSRNO.FormattingEnabled = True
        Me.CMBSRNO.Location = New System.Drawing.Point(723, 88)
        Me.CMBSRNO.Name = "CMBSRNO"
        Me.CMBSRNO.Size = New System.Drawing.Size(164, 21)
        Me.CMBSRNO.TabIndex = 231
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(591, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 19)
        Me.Label8.TabIndex = 230
        Me.Label8.Text = "SrNo :"
        '
        'DAILY_REPORT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1032, 627)
        Me.Controls.Add(Me.CMBSRNO)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CMBICODE)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CMBLINE)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RBCON)
        Me.Controls.Add(Me.RBDET)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.BTNEXCEL)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Grid2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DTTO)
        Me.Controls.Add(Me.DTFROM)
        Me.Controls.Add(Me.CMBBARCODE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CMBRTYPE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CMBINAME)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Name = "DAILY_REPORT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "  Reports"
        CType(Me.BTNEXCEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CMBINAME As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CMBRTYPE As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CMBBARCODE As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DTTO As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTFROM As System.Windows.Forms.DateTimePicker
    Friend WithEvents Grid2 As FlexCell.Grid
    Friend WithEvents BTNEXCEL As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Grid1 As FlexCell.Grid
    Friend WithEvents RBDET As System.Windows.Forms.RadioButton
    Friend WithEvents RBCON As System.Windows.Forms.RadioButton
    Friend WithEvents CMBLINE As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CMBICODE As System.Windows.Forms.ComboBox
    Friend WithEvents CMBSRNO As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
