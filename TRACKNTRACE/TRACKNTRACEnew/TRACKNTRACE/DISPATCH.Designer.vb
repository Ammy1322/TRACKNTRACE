<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DISPATCH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DISPATCH))
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.CMBQTY = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Grid1 = New FlexCell.Grid
        Me.Label11 = New System.Windows.Forms.Label
        Me.TXTBARCODE = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CMBPARTYNAME = New System.Windows.Forms.ComboBox
        Me.CMBVECHNO = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CMBORDERNO = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TN = New System.Windows.Forms.Label
        Me.TXTCOUNTER = New System.Windows.Forms.Label
        Me.FORMNAME = New System.Windows.Forms.Label
        Me.TXTDATE = New System.Windows.Forms.DateTimePicker
        Me.MCODE = New System.Windows.Forms.ComboBox
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(72, 18)
        Me.TextBox1.MaxLength = 50
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(83, 22)
        Me.TextBox1.TabIndex = 214
        Me.TextBox1.Text = "*****"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(13, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 15)
        Me.Label6.TabIndex = 213
        Me.Label6.Text = "TRNO :"
        '
        'CMBQTY
        '
        Me.CMBQTY.FormattingEnabled = True
        Me.CMBQTY.Location = New System.Drawing.Point(72, 50)
        Me.CMBQTY.Name = "CMBQTY"
        Me.CMBQTY.Size = New System.Drawing.Size(83, 21)
        Me.CMBQTY.TabIndex = 212
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(13, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 15)
        Me.Label5.TabIndex = 211
        Me.Label5.Text = "QTY    :"
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnSave.Location = New System.Drawing.Point(581, 50)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(73, 22)
        Me.BtnSave.TabIndex = 210
        Me.BtnSave.Text = "SAVE"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(469, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 19)
        Me.Label4.TabIndex = 199
        Me.Label4.Text = "BARCODE"
        '
        'Grid1
        '
        Me.Grid1.CheckedImage = CType(resources.GetObject("Grid1.CheckedImage"), System.Drawing.Bitmap)
        Me.Grid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Grid1.Location = New System.Drawing.Point(7, 120)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Rows = 2
        Me.Grid1.Size = New System.Drawing.Size(647, 277)
        Me.Grid1.TabIndex = 198
        Me.Grid1.UncheckedImage = CType(resources.GetObject("Grid1.UncheckedImage"), System.Drawing.Bitmap)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label11.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(286, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 29)
        Me.Label11.TabIndex = 219
        Me.Label11.Text = "DISPATCH"
        '
        'TXTBARCODE
        '
        Me.TXTBARCODE.BackColor = System.Drawing.Color.Yellow
        Me.TXTBARCODE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTBARCODE.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBARCODE.Location = New System.Drawing.Point(130, 81)
        Me.TXTBARCODE.MaxLength = 50
        Me.TXTBARCODE.Name = "TXTBARCODE"
        Me.TXTBARCODE.Size = New System.Drawing.Size(524, 22)
        Me.TXTBARCODE.TabIndex = 197
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(11, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 19)
        Me.Label3.TabIndex = 196
        Me.Label3.Text = "PALLET NO  :"
        '
        'CMBPARTYNAME
        '
        Me.CMBPARTYNAME.Enabled = False
        Me.CMBPARTYNAME.FormattingEnabled = True
        Me.CMBPARTYNAME.Location = New System.Drawing.Point(256, 49)
        Me.CMBPARTYNAME.Name = "CMBPARTYNAME"
        Me.CMBPARTYNAME.Size = New System.Drawing.Size(154, 21)
        Me.CMBPARTYNAME.TabIndex = 195
        '
        'CMBVECHNO
        '
        Me.CMBVECHNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CMBVECHNO.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBVECHNO.Location = New System.Drawing.Point(490, 18)
        Me.CMBVECHNO.MaxLength = 50
        Me.CMBVECHNO.Name = "CMBVECHNO"
        Me.CMBVECHNO.Size = New System.Drawing.Size(165, 22)
        Me.CMBVECHNO.TabIndex = 190
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(412, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "VECHNO :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.CMBORDERNO)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.CMBQTY)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.BtnSave)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Grid1)
        Me.GroupBox2.Controls.Add(Me.TXTBARCODE)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.CMBPARTYNAME)
        Me.GroupBox2.Controls.Add(Me.CMBVECHNO)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(662, 408)
        Me.GroupBox2.TabIndex = 218
        Me.GroupBox2.TabStop = False
        '
        'CMBORDERNO
        '
        Me.CMBORDERNO.FormattingEnabled = True
        Me.CMBORDERNO.Location = New System.Drawing.Point(256, 18)
        Me.CMBORDERNO.Name = "CMBORDERNO"
        Me.CMBORDERNO.Size = New System.Drawing.Size(154, 21)
        Me.CMBORDERNO.TabIndex = 216
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(161, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 15)
        Me.Label7.TabIndex = 215
        Me.Label7.Text = "ORDER NO       :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(161, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 15)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "PARTY NAME :"
        '
        'TN
        '
        Me.TN.AutoSize = True
        Me.TN.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TN.ForeColor = System.Drawing.SystemColors.Control
        Me.TN.Location = New System.Drawing.Point(612, 9)
        Me.TN.Name = "TN"
        Me.TN.Size = New System.Drawing.Size(25, 29)
        Me.TN.TabIndex = 221
        Me.TN.Text = "0"
        '
        'TXTCOUNTER
        '
        Me.TXTCOUNTER.AutoSize = True
        Me.TXTCOUNTER.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCOUNTER.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTCOUNTER.Location = New System.Drawing.Point(643, 9)
        Me.TXTCOUNTER.Name = "TXTCOUNTER"
        Me.TXTCOUNTER.Size = New System.Drawing.Size(25, 29)
        Me.TXTCOUNTER.TabIndex = 220
        Me.TXTCOUNTER.Text = "0"
        '
        'FORMNAME
        '
        Me.FORMNAME.AutoSize = True
        Me.FORMNAME.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FORMNAME.ForeColor = System.Drawing.Color.Black
        Me.FORMNAME.Location = New System.Drawing.Point(253, 18)
        Me.FORMNAME.Name = "FORMNAME"
        Me.FORMNAME.Size = New System.Drawing.Size(0, 25)
        Me.FORMNAME.TabIndex = 217
        '
        'TXTDATE
        '
        Me.TXTDATE.Enabled = False
        Me.TXTDATE.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDATE.Location = New System.Drawing.Point(13, 13)
        Me.TXTDATE.Name = "TXTDATE"
        Me.TXTDATE.Size = New System.Drawing.Size(110, 25)
        Me.TXTDATE.TabIndex = 222
        '
        'MCODE
        '
        Me.MCODE.FormattingEnabled = True
        Me.MCODE.Location = New System.Drawing.Point(568, 18)
        Me.MCODE.Name = "MCODE"
        Me.MCODE.Size = New System.Drawing.Size(25, 21)
        Me.MCODE.TabIndex = 217
        Me.MCODE.Visible = False
        '
        'DISPATCH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(676, 460)
        Me.Controls.Add(Me.MCODE)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TN)
        Me.Controls.Add(Me.TXTCOUNTER)
        Me.Controls.Add(Me.FORMNAME)
        Me.Controls.Add(Me.TXTDATE)
        Me.Name = "DISPATCH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DISPATCH"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CMBQTY As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Grid1 As FlexCell.Grid
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TXTBARCODE As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CMBPARTYNAME As System.Windows.Forms.ComboBox
    Friend WithEvents CMBVECHNO As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TN As System.Windows.Forms.Label
    Friend WithEvents TXTCOUNTER As System.Windows.Forms.Label
    Friend WithEvents FORMNAME As System.Windows.Forms.Label
    Friend WithEvents TXTDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents CMBORDERNO As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MCODE As System.Windows.Forms.ComboBox
End Class
