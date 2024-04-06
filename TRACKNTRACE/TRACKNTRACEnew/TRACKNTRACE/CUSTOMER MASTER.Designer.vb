<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CUSTOMER_MASTER
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CUSTOMER_MASTER))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TXTNAME = New System.Windows.Forms.TextBox
        Me.TXTPINCODE = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TXTADDRESS = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TXTEMAIL = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.TXTPHNNO = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BTNDEL = New System.Windows.Forms.Button
        Me.TXTGPCODE = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TXTGCODE = New System.Windows.Forms.TextBox
        Me.BTNSEARCH = New System.Windows.Forms.Button
        Me.Grid2 = New FlexCell.Grid
        Me.FORMNAME = New System.Windows.Forms.Label
        Me.TxtSearch = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.TXTNAME)
        Me.GroupBox2.Controls.Add(Me.TXTPINCODE)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TXTADDRESS)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TXTEMAIL)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.BtnExit)
        Me.GroupBox2.Controls.Add(Me.TXTPHNNO)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.BtnSave)
        Me.GroupBox2.Controls.Add(Me.BTNDEL)
        Me.GroupBox2.Controls.Add(Me.TXTGPCODE)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(878, 97)
        Me.GroupBox2.TabIndex = 201
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CREATION"
        '
        'TXTNAME
        '
        Me.TXTNAME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTNAME.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNAME.Location = New System.Drawing.Point(254, 19)
        Me.TXTNAME.MaxLength = 50
        Me.TXTNAME.Name = "TXTNAME"
        Me.TXTNAME.Size = New System.Drawing.Size(213, 22)
        Me.TXTNAME.TabIndex = 196
        '
        'TXTPINCODE
        '
        Me.TXTPINCODE.FormattingEnabled = True
        Me.TXTPINCODE.Location = New System.Drawing.Point(575, 55)
        Me.TXTPINCODE.Name = "TXTPINCODE"
        Me.TXTPINCODE.Size = New System.Drawing.Size(161, 21)
        Me.TXTPINCODE.TabIndex = 195
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(479, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 15)
        Me.Label10.TabIndex = 194
        Me.Label10.Text = "PINCODE :"
        '
        'TXTADDRESS
        '
        Me.TXTADDRESS.FormattingEnabled = True
        Me.TXTADDRESS.Location = New System.Drawing.Point(254, 55)
        Me.TXTADDRESS.Name = "TXTADDRESS"
        Me.TXTADDRESS.Size = New System.Drawing.Size(213, 21)
        Me.TXTADDRESS.TabIndex = 193
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(164, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 15)
        Me.Label9.TabIndex = 192
        Me.Label9.Text = "ADDRESS     :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(4, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 15)
        Me.Label8.TabIndex = 191
        Me.Label8.Text = "PHN.NO"
        '
        'TXTEMAIL
        '
        Me.TXTEMAIL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTEMAIL.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTEMAIL.Location = New System.Drawing.Point(575, 19)
        Me.TXTEMAIL.MaxLength = 50
        Me.TXTEMAIL.Name = "TXTEMAIL"
        Me.TXTEMAIL.Size = New System.Drawing.Size(161, 22)
        Me.TXTEMAIL.TabIndex = 190
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(4, 23)
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
        Me.Label1.Location = New System.Drawing.Point(479, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "E_MAIL :"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(743, 10)
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
        Me.BtnExit.Location = New System.Drawing.Point(811, 51)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(61, 33)
        Me.BtnExit.TabIndex = 97
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'TXTPHNNO
        '
        Me.TXTPHNNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTPHNNO.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPHNNO.Location = New System.Drawing.Point(67, 55)
        Me.TXTPHNNO.MaxLength = 50
        Me.TXTPHNNO.Name = "TXTPHNNO"
        Me.TXTPHNNO.Size = New System.Drawing.Size(87, 22)
        Me.TXTPHNNO.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(164, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = " NAME          :"
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnSave.Location = New System.Drawing.Point(811, 10)
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
        Me.BTNDEL.Location = New System.Drawing.Point(743, 51)
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
        Me.TXTGPCODE.Location = New System.Drawing.Point(68, 19)
        Me.TXTGPCODE.MaxLength = 6
        Me.TXTGPCODE.Name = "TXTGPCODE"
        Me.TXTGPCODE.ReadOnly = True
        Me.TXTGPCODE.Size = New System.Drawing.Size(87, 22)
        Me.TXTGPCODE.TabIndex = 1
        Me.TXTGPCODE.Text = "*****"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = " CODE :"
        '
        'TXTGCODE
        '
        Me.TXTGCODE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTGCODE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTGCODE.Location = New System.Drawing.Point(69, 19)
        Me.TXTGCODE.MaxLength = 50
        Me.TXTGCODE.Name = "TXTGCODE"
        Me.TXTGCODE.Size = New System.Drawing.Size(148, 26)
        Me.TXTGCODE.TabIndex = 52
        '
        'BTNSEARCH
        '
        Me.BTNSEARCH.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTNSEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTNSEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSEARCH.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSEARCH.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNSEARCH.Location = New System.Drawing.Point(729, 15)
        Me.BTNSEARCH.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BTNSEARCH.Name = "BTNSEARCH"
        Me.BTNSEARCH.Size = New System.Drawing.Size(141, 30)
        Me.BTNSEARCH.TabIndex = 186
        Me.BTNSEARCH.Text = "SEARCH"
        Me.BTNSEARCH.UseVisualStyleBackColor = False
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
        Me.Grid2.Size = New System.Drawing.Size(869, 187)
        Me.Grid2.TabIndex = 188
        Me.Grid2.UncheckedImage = CType(resources.GetObject("Grid2.UncheckedImage"), System.Drawing.Bitmap)
        '
        'FORMNAME
        '
        Me.FORMNAME.AutoSize = True
        Me.FORMNAME.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FORMNAME.ForeColor = System.Drawing.Color.Black
        Me.FORMNAME.Location = New System.Drawing.Point(253, 11)
        Me.FORMNAME.Name = "FORMNAME"
        Me.FORMNAME.Size = New System.Drawing.Size(0, 25)
        Me.FORMNAME.TabIndex = 199
        '
        'TxtSearch
        '
        Me.TxtSearch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.Location = New System.Drawing.Point(340, 17)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(199, 26)
        Me.TxtSearch.TabIndex = 94
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(239, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 15)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "ITEM NAME :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtSearch)
        Me.GroupBox1.Controls.Add(Me.Grid2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXTGCODE)
        Me.GroupBox1.Controls.Add(Me.BTNSEARCH)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(878, 244)
        Me.GroupBox1.TabIndex = 200
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SEARCH"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(328, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(217, 29)
        Me.Label11.TabIndex = 202
        Me.Label11.Text = "CUSTOMER MASTER"
        '
        'CUSTOMER_MASTER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(889, 391)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.FORMNAME)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label11)
        Me.Name = "CUSTOMER_MASTER"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CUSTOMER MASTER"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TXTPINCODE As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TXTADDRESS As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXTEMAIL As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents TXTPHNNO As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BTNDEL As System.Windows.Forms.Button
    Friend WithEvents TXTGPCODE As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXTGCODE As System.Windows.Forms.TextBox
    Friend WithEvents BTNSEARCH As System.Windows.Forms.Button
    Friend WithEvents Grid2 As FlexCell.Grid
    Friend WithEvents FORMNAME As System.Windows.Forms.Label
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TXTNAME As System.Windows.Forms.TextBox
End Class
