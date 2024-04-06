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
        Me.BTNSEARCH = New System.Windows.Forms.Button
        Me.CMBBARCODE = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.DTTO = New System.Windows.Forms.DateTimePicker
        Me.DTFROM = New System.Windows.Forms.DateTimePicker
        Me.Button1 = New System.Windows.Forms.Button
        Me.Grid2 = New FlexCell.Grid
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(442, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 29)
        Me.Label11.TabIndex = 203
        Me.Label11.Text = "REPORTS"
        '
        'CMBINAME
        '
        Me.CMBINAME.FormattingEnabled = True
        Me.CMBINAME.Location = New System.Drawing.Point(127, 75)
        Me.CMBINAME.Name = "CMBINAME"
        Me.CMBINAME.Size = New System.Drawing.Size(194, 21)
        Me.CMBINAME.TabIndex = 206
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(17, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 19)
        Me.Label2.TabIndex = 205
        Me.Label2.Text = "ITEM NAME :"
        '
        'CMBRTYPE
        '
        Me.CMBRTYPE.FormattingEnabled = True
        Me.CMBRTYPE.Items.AddRange(New Object() {"SCANNED", "MASTER CARTON", "PALLET CRATE", "ORDER FEEDING", "DISPATCH", "INSPECTION"})
        Me.CMBRTYPE.Location = New System.Drawing.Point(447, 75)
        Me.CMBRTYPE.Name = "CMBRTYPE"
        Me.CMBRTYPE.Size = New System.Drawing.Size(179, 21)
        Me.CMBRTYPE.TabIndex = 208
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(332, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 19)
        Me.Label1.TabIndex = 207
        Me.Label1.Text = "REP _TYPE  :"
        '
        'BTNSEARCH
        '
        Me.BTNSEARCH.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTNSEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTNSEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSEARCH.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSEARCH.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNSEARCH.Location = New System.Drawing.Point(927, 65)
        Me.BTNSEARCH.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BTNSEARCH.Name = "BTNSEARCH"
        Me.BTNSEARCH.Size = New System.Drawing.Size(99, 30)
        Me.BTNSEARCH.TabIndex = 209
        Me.BTNSEARCH.Text = "SEARCH"
        Me.BTNSEARCH.UseVisualStyleBackColor = False
        '
        'CMBBARCODE
        '
        Me.CMBBARCODE.FormattingEnabled = True
        Me.CMBBARCODE.Location = New System.Drawing.Point(756, 74)
        Me.CMBBARCODE.Name = "CMBBARCODE"
        Me.CMBBARCODE.Size = New System.Drawing.Size(160, 21)
        Me.CMBBARCODE.TabIndex = 211
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(629, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 19)
        Me.Label3.TabIndex = 210
        Me.Label3.Text = "BARCODENO :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(210, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 19)
        Me.Label4.TabIndex = 215
        Me.Label4.Text = "DATE TO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(12, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 19)
        Me.Label5.TabIndex = 214
        Me.Label5.Text = "DATE FROM:"
        '
        'DTTO
        '
        Me.DTTO.Location = New System.Drawing.Point(297, 40)
        Me.DTTO.Name = "DTTO"
        Me.DTTO.Size = New System.Drawing.Size(92, 20)
        Me.DTTO.TabIndex = 213
        '
        'DTFROM
        '
        Me.DTFROM.Location = New System.Drawing.Point(127, 40)
        Me.DTFROM.Name = "DTFROM"
        Me.DTFROM.Size = New System.Drawing.Size(85, 20)
        Me.DTFROM.TabIndex = 212
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(927, 29)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 30)
        Me.Button1.TabIndex = 216
        Me.Button1.Text = "EXCEL"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Grid2
        '
        Me.Grid2.CheckedImage = CType(resources.GetObject("Grid2.CheckedImage"), System.Drawing.Bitmap)
        Me.Grid2.Cols = 7
        Me.Grid2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid2.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Grid2.Location = New System.Drawing.Point(12, 115)
        Me.Grid2.Name = "Grid2"
        Me.Grid2.Rows = 2
        Me.Grid2.Size = New System.Drawing.Size(1014, 365)
        Me.Grid2.TabIndex = 217
        Me.Grid2.UncheckedImage = CType(resources.GetObject("Grid2.UncheckedImage"), System.Drawing.Bitmap)
        '
        'DAILY_REPORT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1039, 492)
        Me.Controls.Add(Me.Grid2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DTTO)
        Me.Controls.Add(Me.DTFROM)
        Me.Controls.Add(Me.CMBBARCODE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BTNSEARCH)
        Me.Controls.Add(Me.CMBRTYPE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CMBINAME)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Name = "DAILY_REPORT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DAILY REPORT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CMBINAME As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CMBRTYPE As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTNSEARCH As System.Windows.Forms.Button
    Friend WithEvents CMBBARCODE As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DTTO As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTFROM As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Grid2 As FlexCell.Grid
End Class
