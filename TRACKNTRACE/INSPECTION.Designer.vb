﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INSPECTION
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(INSPECTION))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BTNNEW = New System.Windows.Forms.PictureBox
        Me.CheckAll = New System.Windows.Forms.CheckBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Grid2 = New FlexCell.Grid
        Me.TXTBARCODE = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TN = New System.Windows.Forms.Label
        Me.TXTDATE = New System.Windows.Forms.DateTimePicker
        Me.FORMNAME = New System.Windows.Forms.Label
        Me.TXTCOUNTER = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        CType(Me.BTNNEW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.BTNNEW)
        Me.GroupBox2.Controls.Add(Me.CheckAll)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Grid2)
        Me.GroupBox2.Controls.Add(Me.TXTBARCODE)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(810, 380)
        Me.GroupBox2.TabIndex = 212
        Me.GroupBox2.TabStop = False
        '
        'BTNNEW
        '
        Me.BTNNEW.Image = CType(resources.GetObject("BTNNEW.Image"), System.Drawing.Image)
        Me.BTNNEW.Location = New System.Drawing.Point(634, 345)
        Me.BTNNEW.Name = "BTNNEW"
        Me.BTNNEW.Size = New System.Drawing.Size(84, 33)
        Me.BTNNEW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNNEW.TabIndex = 220
        Me.BTNNEW.TabStop = False
        '
        'CheckAll
        '
        Me.CheckAll.AutoSize = True
        Me.CheckAll.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckAll.Location = New System.Drawing.Point(732, 19)
        Me.CheckAll.Name = "CheckAll"
        Me.CheckAll.Size = New System.Drawing.Size(70, 17)
        Me.CheckAll.TabIndex = 218
        Me.CheckAll.Text = "CheckAll"
        Me.CheckAll.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(69, 9)
        Me.TextBox1.MaxLength = 50
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(78, 23)
        Me.TextBox1.TabIndex = 214
        Me.TextBox1.Text = "*****"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(720, 345)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 219
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 213
        Me.Label6.Text = "Trno :"
        '
        'Grid2
        '
        Me.Grid2.BackColor2 = System.Drawing.Color.Gainsboro
        Me.Grid2.BackColorFixed = System.Drawing.Color.Gainsboro
        Me.Grid2.BackColorSel = System.Drawing.Color.Black
        Me.Grid2.CheckedImage = CType(resources.GetObject("Grid2.CheckedImage"), System.Drawing.Bitmap)
        Me.Grid2.DefaultFont = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!)
        Me.Grid2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid2.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Grid2.Location = New System.Drawing.Point(8, 41)
        Me.Grid2.Name = "Grid2"
        Me.Grid2.Rows = 2
        Me.Grid2.Size = New System.Drawing.Size(796, 303)
        Me.Grid2.TabIndex = 198
        Me.Grid2.UncheckedImage = CType(resources.GetObject("Grid2.UncheckedImage"), System.Drawing.Bitmap)
        '
        'TXTBARCODE
        '
        Me.TXTBARCODE.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TXTBARCODE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTBARCODE.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBARCODE.Location = New System.Drawing.Point(252, 10)
        Me.TXTBARCODE.MaxLength = 50
        Me.TXTBARCODE.Name = "TXTBARCODE"
        Me.TXTBARCODE.Size = New System.Drawing.Size(271, 23)
        Me.TXTBARCODE.TabIndex = 197
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(158, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 19)
        Me.Label3.TabIndex = 196
        Me.Label3.Text = "Qrcode  :"
        '
        'TN
        '
        Me.TN.AutoSize = True
        Me.TN.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TN.ForeColor = System.Drawing.Color.Black
        Me.TN.Location = New System.Drawing.Point(732, 9)
        Me.TN.Name = "TN"
        Me.TN.Size = New System.Drawing.Size(26, 29)
        Me.TN.TabIndex = 215
        Me.TN.Text = "0"
        '
        'TXTDATE
        '
        Me.TXTDATE.Enabled = False
        Me.TXTDATE.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDATE.Location = New System.Drawing.Point(12, 12)
        Me.TXTDATE.Name = "TXTDATE"
        Me.TXTDATE.Size = New System.Drawing.Size(110, 26)
        Me.TXTDATE.TabIndex = 216
        '
        'FORMNAME
        '
        Me.FORMNAME.AutoSize = True
        Me.FORMNAME.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FORMNAME.ForeColor = System.Drawing.Color.Black
        Me.FORMNAME.Location = New System.Drawing.Point(252, 17)
        Me.FORMNAME.Name = "FORMNAME"
        Me.FORMNAME.Size = New System.Drawing.Size(0, 25)
        Me.FORMNAME.TabIndex = 211
        '
        'TXTCOUNTER
        '
        Me.TXTCOUNTER.AutoSize = True
        Me.TXTCOUNTER.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCOUNTER.ForeColor = System.Drawing.Color.Black
        Me.TXTCOUNTER.Location = New System.Drawing.Point(785, 9)
        Me.TXTCOUNTER.Name = "TXTCOUNTER"
        Me.TXTCOUNTER.Size = New System.Drawing.Size(26, 29)
        Me.TXTCOUNTER.TabIndex = 214
        Me.TXTCOUNTER.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Gainsboro
        Me.Label11.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(339, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 29)
        Me.Label11.TabIndex = 213
        Me.Label11.Text = "Inspection"
        '
        'INSPECTION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(818, 436)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TN)
        Me.Controls.Add(Me.TXTDATE)
        Me.Controls.Add(Me.FORMNAME)
        Me.Controls.Add(Me.TXTCOUNTER)
        Me.Controls.Add(Me.Label11)
        Me.Name = "INSPECTION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inspection"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BTNNEW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Grid2 As FlexCell.Grid
    Friend WithEvents TXTBARCODE As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TN As System.Windows.Forms.Label
    Friend WithEvents TXTDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents FORMNAME As System.Windows.Forms.Label
    Friend WithEvents TXTCOUNTER As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CheckAll As System.Windows.Forms.CheckBox
    Friend WithEvents BTNNEW As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
