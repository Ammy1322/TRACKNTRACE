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
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
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
        Me.GroupBox2.Location = New System.Drawing.Point(3, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(662, 370)
        Me.GroupBox2.TabIndex = 201
        Me.GroupBox2.TabStop = False
        '
        'CMBTYPE
        '
        Me.CMBTYPE.FormattingEnabled = True
        Me.CMBTYPE.Items.AddRange(New Object() {"PRODUCTION", "SAMPLING", "TESTING"})
        Me.CMBTYPE.Location = New System.Drawing.Point(409, 19)
        Me.CMBTYPE.Name = "CMBTYPE"
        Me.CMBTYPE.Size = New System.Drawing.Size(245, 21)
        Me.CMBTYPE.TabIndex = 203
        Me.CMBTYPE.Text = "PRODUCTION"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(363, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 15)
        Me.Label6.TabIndex = 202
        Me.Label6.Text = "TYPE"
        '
        'CMBLINE
        '
        Me.CMBLINE.FormattingEnabled = True
        Me.CMBLINE.Location = New System.Drawing.Point(409, 48)
        Me.CMBLINE.Name = "CMBLINE"
        Me.CMBLINE.Size = New System.Drawing.Size(245, 21)
        Me.CMBLINE.TabIndex = 201
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(363, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 15)
        Me.Label5.TabIndex = 200
        Me.Label5.Text = "LINE :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(455, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 19)
        Me.Label4.TabIndex = 199
        Me.Label4.Text = "---------------------"
        '
        'Grid2
        '
        Me.Grid2.CheckedImage = CType(resources.GetObject("Grid2.CheckedImage"), System.Drawing.Bitmap)
        Me.Grid2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid2.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Grid2.Location = New System.Drawing.Point(7, 117)
        Me.Grid2.Name = "Grid2"
        Me.Grid2.Size = New System.Drawing.Size(647, 247)
        Me.Grid2.TabIndex = 198
        Me.Grid2.UncheckedImage = CType(resources.GetObject("Grid2.UncheckedImage"), System.Drawing.Bitmap)
        '
        'TXTBARCODE
        '
        Me.TXTBARCODE.BackColor = System.Drawing.Color.Yellow
        Me.TXTBARCODE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTBARCODE.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBARCODE.Location = New System.Drawing.Point(105, 77)
        Me.TXTBARCODE.MaxLength = 50
        Me.TXTBARCODE.Name = "TXTBARCODE"
        Me.TXTBARCODE.Size = New System.Drawing.Size(254, 22)
        Me.TXTBARCODE.TabIndex = 197
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(9, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 19)
        Me.Label3.TabIndex = 196
        Me.Label3.Text = "BARCODE"
        '
        'CMBINAME
        '
        Me.CMBINAME.FormattingEnabled = True
        Me.CMBINAME.Location = New System.Drawing.Point(104, 19)
        Me.CMBINAME.Name = "CMBINAME"
        Me.CMBINAME.Size = New System.Drawing.Size(255, 21)
        Me.CMBINAME.TabIndex = 195
        '
        'MCODE
        '
        Me.MCODE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MCODE.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MCODE.Location = New System.Drawing.Point(104, 48)
        Me.MCODE.MaxLength = 50
        Me.MCODE.Name = "MCODE"
        Me.MCODE.Size = New System.Drawing.Size(255, 22)
        Me.MCODE.TabIndex = 190
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(43, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "I CODE :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 15)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "ITEM NAME :"
        '
        'FORMNAME
        '
        Me.FORMNAME.AutoSize = True
        Me.FORMNAME.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FORMNAME.ForeColor = System.Drawing.Color.Black
        Me.FORMNAME.Location = New System.Drawing.Point(252, 11)
        Me.FORMNAME.Name = "FORMNAME"
        Me.FORMNAME.Size = New System.Drawing.Size(0, 25)
        Me.FORMNAME.TabIndex = 199
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(267, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 33)
        Me.Label11.TabIndex = 202
        Me.Label11.Text = "SCANNING"
        '
        'TXTCOUNTER
        '
        Me.TXTCOUNTER.AutoSize = True
        Me.TXTCOUNTER.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCOUNTER.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTCOUNTER.Location = New System.Drawing.Point(597, 6)
        Me.TXTCOUNTER.Name = "TXTCOUNTER"
        Me.TXTCOUNTER.Size = New System.Drawing.Size(25, 29)
        Me.TXTCOUNTER.TabIndex = 203
        Me.TXTCOUNTER.Text = "0"
        '
        'TN
        '
        Me.TN.AutoSize = True
        Me.TN.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TN.ForeColor = System.Drawing.SystemColors.Control
        Me.TN.Location = New System.Drawing.Point(141, 3)
        Me.TN.Name = "TN"
        Me.TN.Size = New System.Drawing.Size(25, 29)
        Me.TN.TabIndex = 204
        Me.TN.Text = "0"
        Me.TN.Visible = False
        '
        'TXTDATE
        '
        Me.TXTDATE.Enabled = False
        Me.TXTDATE.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDATE.Location = New System.Drawing.Point(12, 7)
        Me.TXTDATE.Name = "TXTDATE"
        Me.TXTDATE.Size = New System.Drawing.Size(123, 25)
        Me.TXTDATE.TabIndex = 200
        '
        'TXTREJECT
        '
        Me.TXTREJECT.AutoSize = True
        Me.TXTREJECT.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTREJECT.ForeColor = System.Drawing.SystemColors.Control
        Me.TXTREJECT.Location = New System.Drawing.Point(598, 36)
        Me.TXTREJECT.Name = "TXTREJECT"
        Me.TXTREJECT.Size = New System.Drawing.Size(25, 29)
        Me.TXTREJECT.TabIndex = 205
        Me.TXTREJECT.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(482, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 24)
        Me.Label7.TabIndex = 206
        Me.Label7.Text = "APPROVED :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(482, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 24)
        Me.Label8.TabIndex = 207
        Me.Label8.Text = "REJECTED   :"
        '
        'WsmbtControl1
        '
        Me.WsmbtControl1.ConnectTimeout = 1000
        Me.WsmbtControl1.Mode = WSMBT.Mode.TCP_IP
        Me.WsmbtControl1.ResponseTimeout = 1000
        '
        'SCANNING
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(671, 451)
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
        Me.Text = "SCANNING"
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
End Class
