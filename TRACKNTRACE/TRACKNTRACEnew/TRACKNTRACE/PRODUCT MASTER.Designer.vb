<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRODUCT_MASTER
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PRODUCT_MASTER))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CMBWEIGHT = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.CMBDIMENSION = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.MCODE = New System.Windows.Forms.TextBox
        Me.CMBACTIVE = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.TXTDESCRIPTION = New System.Windows.Forms.TextBox
        Me.TXTMRP = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BTNDEL = New System.Windows.Forms.Button
        Me.TXTGPCODE = New System.Windows.Forms.TextBox
        Me.CMBACSEARCH = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtSearch = New System.Windows.Forms.TextBox
        Me.Grid2 = New FlexCell.Grid
        Me.Label4 = New System.Windows.Forms.Label
        Me.TXTGCODE = New System.Windows.Forms.TextBox
        Me.BTNSEARCH = New System.Windows.Forms.Button
        Me.FORMNAME = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Grid1 = New FlexCell.Grid
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.CMBWEIGHT)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.CMBDIMENSION)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.MCODE)
        Me.GroupBox2.Controls.Add(Me.CMBACTIVE)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.BtnExit)
        Me.GroupBox2.Controls.Add(Me.TXTDESCRIPTION)
        Me.GroupBox2.Controls.Add(Me.TXTMRP)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.BtnSave)
        Me.GroupBox2.Controls.Add(Me.BTNDEL)
        Me.GroupBox2.Controls.Add(Me.TXTGPCODE)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(746, 129)
        Me.GroupBox2.TabIndex = 195
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CREATION"
        '
        'CMBWEIGHT
        '
        Me.CMBWEIGHT.FormattingEnabled = True
        Me.CMBWEIGHT.Location = New System.Drawing.Point(575, 51)
        Me.CMBWEIGHT.Name = "CMBWEIGHT"
        Me.CMBWEIGHT.Size = New System.Drawing.Size(161, 21)
        Me.CMBWEIGHT.TabIndex = 195
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(479, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 15)
        Me.Label10.TabIndex = 194
        Me.Label10.Text = "WEIGHT :"
        '
        'CMBDIMENSION
        '
        Me.CMBDIMENSION.FormattingEnabled = True
        Me.CMBDIMENSION.Location = New System.Drawing.Point(254, 51)
        Me.CMBDIMENSION.Name = "CMBDIMENSION"
        Me.CMBDIMENSION.Size = New System.Drawing.Size(213, 21)
        Me.CMBDIMENSION.TabIndex = 193
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(164, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 15)
        Me.Label9.TabIndex = 192
        Me.Label9.Text = "DIMENSION :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(4, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 15)
        Me.Label8.TabIndex = 191
        Me.Label8.Text = "MRP"
        '
        'MCODE
        '
        Me.MCODE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MCODE.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MCODE.Location = New System.Drawing.Point(575, 15)
        Me.MCODE.MaxLength = 50
        Me.MCODE.Name = "MCODE"
        Me.MCODE.Size = New System.Drawing.Size(161, 22)
        Me.MCODE.TabIndex = 190
        '
        'CMBACTIVE
        '
        Me.CMBACTIVE.FormattingEnabled = True
        Me.CMBACTIVE.Items.AddRange(New Object() {"YES", "NO"})
        Me.CMBACTIVE.Location = New System.Drawing.Point(66, 88)
        Me.CMBACTIVE.Name = "CMBACTIVE"
        Me.CMBACTIVE.Size = New System.Drawing.Size(88, 21)
        Me.CMBACTIVE.TabIndex = 189
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(2, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 188
        Me.Label6.Text = "ACTIVE :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(4, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "SR NO :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(479, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "ITEM CODE :"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(477, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 33)
        Me.Button1.TabIndex = 187
        Me.Button1.Text = "NEW"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnExit.Location = New System.Drawing.Point(678, 85)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(61, 33)
        Me.BtnExit.TabIndex = 97
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'TXTDESCRIPTION
        '
        Me.TXTDESCRIPTION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTDESCRIPTION.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDESCRIPTION.Location = New System.Drawing.Point(254, 15)
        Me.TXTDESCRIPTION.MaxLength = 50
        Me.TXTDESCRIPTION.Name = "TXTDESCRIPTION"
        Me.TXTDESCRIPTION.Size = New System.Drawing.Size(213, 22)
        Me.TXTDESCRIPTION.TabIndex = 0
        '
        'TXTMRP
        '
        Me.TXTMRP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTMRP.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMRP.Location = New System.Drawing.Point(67, 51)
        Me.TXTMRP.MaxLength = 50
        Me.TXTMRP.Name = "TXTMRP"
        Me.TXTMRP.Size = New System.Drawing.Size(87, 22)
        Me.TXTMRP.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(164, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 15)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "ITEM NAME :"
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnSave.Location = New System.Drawing.Point(544, 85)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(61, 33)
        Me.BtnSave.TabIndex = 96
        Me.BtnSave.Text = "SAVE"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BTNDEL
        '
        Me.BTNDEL.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTNDEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNDEL.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNDEL.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNDEL.Location = New System.Drawing.Point(611, 85)
        Me.BTNDEL.Name = "BTNDEL"
        Me.BTNDEL.Size = New System.Drawing.Size(61, 33)
        Me.BTNDEL.TabIndex = 98
        Me.BTNDEL.Text = "DELETE"
        Me.BTNDEL.UseVisualStyleBackColor = False
        '
        'TXTGPCODE
        '
        Me.TXTGPCODE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTGPCODE.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTGPCODE.Location = New System.Drawing.Point(68, 15)
        Me.TXTGPCODE.MaxLength = 6
        Me.TXTGPCODE.Name = "TXTGPCODE"
        Me.TXTGPCODE.ReadOnly = True
        Me.TXTGPCODE.Size = New System.Drawing.Size(87, 22)
        Me.TXTGPCODE.TabIndex = 1
        '
        'CMBACSEARCH
        '
        Me.CMBACSEARCH.FormattingEnabled = True
        Me.CMBACSEARCH.Items.AddRange(New Object() {"YES", "NO"})
        Me.CMBACSEARCH.Location = New System.Drawing.Point(457, 22)
        Me.CMBACSEARCH.Name = "CMBACSEARCH"
        Me.CMBACSEARCH.Size = New System.Drawing.Size(74, 21)
        Me.CMBACSEARCH.TabIndex = 190
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(393, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 15)
        Me.Label7.TabIndex = 189
        Me.Label7.Text = "ACTIVE :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.CMBACSEARCH)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtSearch)
        Me.GroupBox1.Controls.Add(Me.Grid2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXTGCODE)
        Me.GroupBox1.Controls.Add(Me.BTNSEARCH)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 179)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(744, 244)
        Me.GroupBox1.TabIndex = 194
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SEARCH"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(128, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 15)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "ITEM NAME :"
        '
        'TxtSearch
        '
        Me.TxtSearch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.Location = New System.Drawing.Point(245, 19)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(142, 26)
        Me.TxtSearch.TabIndex = 94
        '
        'Grid2
        '
        Me.Grid2.CheckedImage = CType(resources.GetObject("Grid2.CheckedImage"), System.Drawing.Bitmap)
        Me.Grid2.Cols = 7
        Me.Grid2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid2.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Grid2.Location = New System.Drawing.Point(3, 53)
        Me.Grid2.Name = "Grid2"
        Me.Grid2.Rows = 2
        Me.Grid2.Size = New System.Drawing.Size(735, 187)
        Me.Grid2.TabIndex = 188
        Me.Grid2.UncheckedImage = CType(resources.GetObject("Grid2.UncheckedImage"), System.Drawing.Bitmap)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "I CODE :"
        '
        'TXTGCODE
        '
        Me.TXTGCODE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTGCODE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTGCODE.Location = New System.Drawing.Point(69, 19)
        Me.TXTGCODE.MaxLength = 50
        Me.TXTGCODE.Name = "TXTGCODE"
        Me.TXTGCODE.Size = New System.Drawing.Size(59, 26)
        Me.TXTGCODE.TabIndex = 52
        '
        'BTNSEARCH
        '
        Me.BTNSEARCH.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTNSEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTNSEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSEARCH.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSEARCH.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNSEARCH.Location = New System.Drawing.Point(575, 17)
        Me.BTNSEARCH.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BTNSEARCH.Name = "BTNSEARCH"
        Me.BTNSEARCH.Size = New System.Drawing.Size(161, 30)
        Me.BTNSEARCH.TabIndex = 186
        Me.BTNSEARCH.Text = "SEARCH"
        Me.BTNSEARCH.UseVisualStyleBackColor = False
        '
        'FORMNAME
        '
        Me.FORMNAME.AutoSize = True
        Me.FORMNAME.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FORMNAME.ForeColor = System.Drawing.Color.Black
        Me.FORMNAME.Location = New System.Drawing.Point(254, 17)
        Me.FORMNAME.Name = "FORMNAME"
        Me.FORMNAME.Size = New System.Drawing.Size(0, 25)
        Me.FORMNAME.TabIndex = 193
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(188, 233)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 10)
        Me.Panel2.TabIndex = 192
        '
        'Grid1
        '
        Me.Grid1.CheckedImage = CType(resources.GetObject("Grid1.CheckedImage"), System.Drawing.Bitmap)
        Me.Grid1.Cols = 3
        Me.Grid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Grid1.Location = New System.Drawing.Point(136, 215)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Rows = 2
        Me.Grid1.Size = New System.Drawing.Size(10, 10)
        Me.Grid1.TabIndex = 191
        Me.Grid1.UncheckedImage = CType(resources.GetObject("Grid1.UncheckedImage"), System.Drawing.Bitmap)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(272, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(202, 29)
        Me.Label11.TabIndex = 196
        Me.Label11.Text = "PRODUCT MASTER"
        '
        'PRODUCT_MASTER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(756, 428)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FORMNAME)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Grid1)
        Me.Name = "PRODUCT_MASTER"
        Me.Text = "PRODUCT MASTER"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CMBWEIGHT As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CMBDIMENSION As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents MCODE As System.Windows.Forms.TextBox
    Friend WithEvents CMBACTIVE As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents TXTDESCRIPTION As System.Windows.Forms.TextBox
    Friend WithEvents TXTMRP As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BTNDEL As System.Windows.Forms.Button
    Friend WithEvents TXTGPCODE As System.Windows.Forms.TextBox
    Friend WithEvents CMBACSEARCH As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Grid2 As FlexCell.Grid
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXTGCODE As System.Windows.Forms.TextBox
    Friend WithEvents BTNSEARCH As System.Windows.Forms.Button
    Friend WithEvents FORMNAME As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Grid1 As FlexCell.Grid
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
