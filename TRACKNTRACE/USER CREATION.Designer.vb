<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USER_CREATION
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(USER_CREATION))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CMBSTAGE = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtSearch = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtBrandNm = New System.Windows.Forms.TextBox
        Me.LblClassNm = New System.Windows.Forms.Label
        Me.TxtBrandCode = New System.Windows.Forms.TextBox
        Me.LblClassId = New System.Windows.Forms.Label
        Me.Grid1 = New FlexCell.Grid
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.Label6 = New System.Windows.Forms.Label
        Me.BtnExit = New System.Windows.Forms.PictureBox
        Me.BtnSave = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        CType(Me.BtnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.CMBSTAGE)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtpassword)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtSearch)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtBrandNm)
        Me.Panel1.Controls.Add(Me.LblClassNm)
        Me.Panel1.Controls.Add(Me.TxtBrandCode)
        Me.Panel1.Controls.Add(Me.LblClassId)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Location = New System.Drawing.Point(5, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(622, 122)
        Me.Panel1.TabIndex = 126
        '
        'CMBSTAGE
        '
        Me.CMBSTAGE.FormattingEnabled = True
        Me.CMBSTAGE.Location = New System.Drawing.Point(99, 61)
        Me.CMBSTAGE.Name = "CMBSTAGE"
        Me.CMBSTAGE.Size = New System.Drawing.Size(508, 21)
        Me.CMBSTAGE.TabIndex = 221
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 220
        Me.Label3.Text = "Vendor Name"
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(384, 33)
        Me.txtpassword.MaxLength = 200
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(219, 20)
        Me.txtpassword.TabIndex = 218
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(316, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 219
        Me.Label2.Text = "Password"
        '
        'TxtSearch
        '
        Me.TxtSearch.Location = New System.Drawing.Point(99, 93)
        Me.TxtSearch.MaxLength = 200
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(508, 20)
        Me.TxtSearch.TabIndex = 217
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 215
        Me.Label1.Text = "Search"
        '
        'TxtBrandNm
        '
        Me.TxtBrandNm.Location = New System.Drawing.Point(99, 32)
        Me.TxtBrandNm.MaxLength = 200
        Me.TxtBrandNm.Name = "TxtBrandNm"
        Me.TxtBrandNm.Size = New System.Drawing.Size(213, 20)
        Me.TxtBrandNm.TabIndex = 212
        '
        'LblClassNm
        '
        Me.LblClassNm.AutoSize = True
        Me.LblClassNm.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClassNm.ForeColor = System.Drawing.Color.Black
        Me.LblClassNm.Location = New System.Drawing.Point(12, 35)
        Me.LblClassNm.Name = "LblClassNm"
        Me.LblClassNm.Size = New System.Drawing.Size(73, 16)
        Me.LblClassNm.TabIndex = 214
        Me.LblClassNm.Text = "User Name"
        '
        'TxtBrandCode
        '
        Me.TxtBrandCode.Location = New System.Drawing.Point(100, 4)
        Me.TxtBrandCode.Name = "TxtBrandCode"
        Me.TxtBrandCode.ReadOnly = True
        Me.TxtBrandCode.Size = New System.Drawing.Size(85, 20)
        Me.TxtBrandCode.TabIndex = 216
        '
        'LblClassId
        '
        Me.LblClassId.AutoSize = True
        Me.LblClassId.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClassId.ForeColor = System.Drawing.Color.Black
        Me.LblClassId.Location = New System.Drawing.Point(12, 6)
        Me.LblClassId.Name = "LblClassId"
        Me.LblClassId.Size = New System.Drawing.Size(70, 16)
        Me.LblClassId.TabIndex = 213
        Me.LblClassId.Text = "User Code"
        '
        'Grid1
        '
        Me.Grid1.BackColor2 = System.Drawing.Color.Gainsboro
        Me.Grid1.BackColorFixed = System.Drawing.Color.Gainsboro
        Me.Grid1.BackColorFixedSel = System.Drawing.Color.Gainsboro
        Me.Grid1.CheckedImage = CType(resources.GetObject("Grid1.CheckedImage"), System.Drawing.Bitmap)
        Me.Grid1.DefaultFont = New System.Drawing.Font("Avenir LT Std 45 Book", 8.249999!)
        Me.Grid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Grid1.Location = New System.Drawing.Point(5, 166)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(622, 182)
        Me.Grid1.TabIndex = 127
        Me.Grid1.UncheckedImage = CType(resources.GetObject("Grid1.UncheckedImage"), System.Drawing.Bitmap)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 394)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(634, 22)
        Me.StatusStrip1.TabIndex = 128
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Avenir LT Std 45 Book", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(218, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 29)
        Me.Label6.TabIndex = 129
        Me.Label6.Text = "User Creation"
        '
        'BtnExit
        '
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.Location = New System.Drawing.Point(523, 348)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(104, 43)
        Me.BtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnExit.TabIndex = 205
        Me.BtnExit.TabStop = False
        '
        'BtnSave
        '
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(415, 348)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(102, 43)
        Me.BtnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnSave.TabIndex = 204
        Me.BtnSave.TabStop = False
        '
        'USER_CREATION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(634, 416)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "USER_CREATION"
        Me.Text = "User Creation"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BtnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Grid1 As FlexCell.Grid
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CMBSTAGE As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtBrandNm As System.Windows.Forms.TextBox
    Friend WithEvents LblClassNm As System.Windows.Forms.Label
    Friend WithEvents TxtBrandCode As System.Windows.Forms.TextBox
    Friend WithEvents LblClassId As System.Windows.Forms.Label
    Friend WithEvents BtnExit As System.Windows.Forms.PictureBox
    Friend WithEvents BtnSave As System.Windows.Forms.PictureBox
End Class
