<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LINEMASTER
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LINEMASTER))
        Me.Label1 = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.mgbox = New System.Windows.Forms.ToolStripStatusLabel
        Me.TxtSearchNAME = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BTNSEARCH = New System.Windows.Forms.PictureBox
        Me.TXTSCODE = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Grid1 = New FlexCell.Grid
        Me.Label3 = New System.Windows.Forms.Label
        Me.TXTLINENO = New System.Windows.Forms.TextBox
        Me.TXTLINENAME = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.BTNDEL = New System.Windows.Forms.PictureBox
        Me.BTNNEW = New System.Windows.Forms.PictureBox
        Me.BtnSave = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.LblClassNm = New System.Windows.Forms.Label
        Me.TxtColorCode = New System.Windows.Forms.TextBox
        Me.LblClassId = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BTNSEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNDEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNNEW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(169, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Line Name"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mgbox})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 380)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(598, 22)
        Me.StatusStrip1.TabIndex = 136
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'mgbox
        '
        Me.mgbox.BackColor = System.Drawing.Color.Black
        Me.mgbox.Name = "mgbox"
        Me.mgbox.Size = New System.Drawing.Size(52, 17)
        Me.mgbox.Text = "THANKS"
        '
        'TxtSearchNAME
        '
        Me.TxtSearchNAME.Location = New System.Drawing.Point(241, 15)
        Me.TxtSearchNAME.MaxLength = 200
        Me.TxtSearchNAME.Name = "TxtSearchNAME"
        Me.TxtSearchNAME.Size = New System.Drawing.Size(210, 21)
        Me.TxtSearchNAME.TabIndex = 127
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.BTNSEARCH)
        Me.GroupBox1.Controls.Add(Me.TXTSCODE)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtSearchNAME)
        Me.GroupBox1.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(2, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(591, 42)
        Me.GroupBox1.TabIndex = 137
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'BTNSEARCH
        '
        Me.BTNSEARCH.Image = CType(resources.GetObject("BTNSEARCH.Image"), System.Drawing.Image)
        Me.BTNSEARCH.Location = New System.Drawing.Point(471, 9)
        Me.BTNSEARCH.Name = "BTNSEARCH"
        Me.BTNSEARCH.Size = New System.Drawing.Size(107, 33)
        Me.BTNSEARCH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNSEARCH.TabIndex = 216
        Me.BTNSEARCH.TabStop = False
        '
        'TXTSCODE
        '
        Me.TXTSCODE.Location = New System.Drawing.Point(79, 15)
        Me.TXTSCODE.Name = "TXTSCODE"
        Me.TXTSCODE.Size = New System.Drawing.Size(85, 21)
        Me.TXTSCODE.TabIndex = 193
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 192
        Me.Label4.Text = "Line No"
        '
        'Grid1
        '
        Me.Grid1.BackColor2 = System.Drawing.Color.Gainsboro
        Me.Grid1.BackColorFixed = System.Drawing.Color.Gainsboro
        Me.Grid1.CheckedImage = CType(resources.GetObject("Grid1.CheckedImage"), System.Drawing.Bitmap)
        Me.Grid1.Cols = 4
        Me.Grid1.DefaultFont = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!)
        Me.Grid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Grid1.Location = New System.Drawing.Point(3, 184)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Rows = 2
        Me.Grid1.Size = New System.Drawing.Size(588, 193)
        Me.Grid1.TabIndex = 135
        Me.Grid1.UncheckedImage = CType(resources.GetObject("Grid1.UncheckedImage"), System.Drawing.Bitmap)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 130
        Me.Label3.Text = "Creation"
        '
        'TXTLINENO
        '
        Me.TXTLINENO.Location = New System.Drawing.Point(199, 16)
        Me.TXTLINENO.Name = "TXTLINENO"
        Me.TXTLINENO.Size = New System.Drawing.Size(217, 20)
        Me.TXTLINENO.TabIndex = 129
        '
        'TXTLINENAME
        '
        Me.TXTLINENAME.Location = New System.Drawing.Point(375, 16)
        Me.TXTLINENAME.MaxLength = 200
        Me.TXTLINENAME.Name = "TXTLINENAME"
        Me.TXTLINENAME.Size = New System.Drawing.Size(201, 20)
        Me.TXTLINENAME.TabIndex = 123
        Me.TXTLINENAME.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.BTNDEL)
        Me.Panel1.Controls.Add(Me.BTNNEW)
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TXTLINENO)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TXTLINENAME)
        Me.Panel1.Controls.Add(Me.LblClassNm)
        Me.Panel1.Controls.Add(Me.TxtColorCode)
        Me.Panel1.Controls.Add(Me.LblClassId)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Location = New System.Drawing.Point(2, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(590, 90)
        Me.Panel1.TabIndex = 134
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(500, 50)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(83, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 215
        Me.PictureBox2.TabStop = False
        '
        'BTNDEL
        '
        Me.BTNDEL.Image = CType(resources.GetObject("BTNDEL.Image"), System.Drawing.Image)
        Me.BTNDEL.Location = New System.Drawing.Point(418, 50)
        Me.BTNDEL.Name = "BTNDEL"
        Me.BTNDEL.Size = New System.Drawing.Size(80, 33)
        Me.BTNDEL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNDEL.TabIndex = 214
        Me.BTNDEL.TabStop = False
        '
        'BTNNEW
        '
        Me.BTNNEW.Image = CType(resources.GetObject("BTNNEW.Image"), System.Drawing.Image)
        Me.BTNNEW.Location = New System.Drawing.Point(250, 50)
        Me.BTNNEW.Name = "BTNNEW"
        Me.BTNNEW.Size = New System.Drawing.Size(84, 33)
        Me.BTNNEW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNNEW.TabIndex = 213
        Me.BTNNEW.TabStop = False
        '
        'BtnSave
        '
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(336, 50)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(80, 33)
        Me.BtnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnSave.TabIndex = 212
        Me.BtnSave.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(130, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "Line Name"
        '
        'LblClassNm
        '
        Me.LblClassNm.AutoSize = True
        Me.LblClassNm.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClassNm.ForeColor = System.Drawing.Color.Black
        Me.LblClassNm.Location = New System.Drawing.Point(302, 19)
        Me.LblClassNm.Name = "LblClassNm"
        Me.LblClassNm.Size = New System.Drawing.Size(67, 13)
        Me.LblClassNm.TabIndex = 122
        Me.LblClassNm.Text = "LINE NAME"
        Me.LblClassNm.Visible = False
        '
        'TxtColorCode
        '
        Me.TxtColorCode.Location = New System.Drawing.Point(42, 16)
        Me.TxtColorCode.Name = "TxtColorCode"
        Me.TxtColorCode.ReadOnly = True
        Me.TxtColorCode.Size = New System.Drawing.Size(85, 20)
        Me.TxtColorCode.TabIndex = 124
        '
        'LblClassId
        '
        Me.LblClassId.AutoSize = True
        Me.LblClassId.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClassId.ForeColor = System.Drawing.Color.Black
        Me.LblClassId.Location = New System.Drawing.Point(4, 19)
        Me.LblClassId.Name = "LblClassId"
        Me.LblClassId.Size = New System.Drawing.Size(35, 13)
        Me.LblClassId.TabIndex = 121
        Me.LblClassId.Text = "Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(226, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 29)
        Me.Label6.TabIndex = 138
        Me.Label6.Text = "Line Master"
        '
        'LINEMASTER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(598, 402)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "LINEMASTER"
        Me.Text = "Line Master"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BTNSEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNDEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNNEW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents mgbox As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TxtSearchNAME As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TXTSCODE As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Grid1 As FlexCell.Grid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXTLINENO As System.Windows.Forms.TextBox
    Friend WithEvents TXTLINENAME As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblClassNm As System.Windows.Forms.Label
    Friend WithEvents TxtColorCode As System.Windows.Forms.TextBox
    Friend WithEvents LblClassId As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BTNDEL As System.Windows.Forms.PictureBox
    Friend WithEvents BTNNEW As System.Windows.Forms.PictureBox
    Friend WithEvents BtnSave As System.Windows.Forms.PictureBox
    Friend WithEvents BTNSEARCH As System.Windows.Forms.PictureBox
End Class
