Imports System.Data
Imports System.IO
Imports System.Text
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Public Class USER_CREATION
    Dim APPCON As New CNNCLASS
    Dim savetype As String
    Dim OBJSQLCOMMAND As SqlCommand
    Dim OBJCOMMAND As SqlCommand
    Dim OBJCOMMANDNEW As SqlCommand
    Dim OBJDATAREADER As SqlDataReader
    Dim OBJDATAREADERNEW As SqlDataReader
    Dim TRANS As SqlTransaction
    Dim STRSQL As String = ""
    Dim MM As New Crypto
    Dim OBJSQLCOMMANDGETDESC As SqlCommand
    Dim OBJDATAREADERGETDESC As SqlDataReader
    Private Sub USER_CREATION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Top = 100
            Me.Left = 300
            savetype = "ADD"
            'Me.fontset()
            APPCON.connection()
            Me.KeyPreview = True
            Call FORMATGRID()
            Call COMPANYBIND()
            Call CLEARTEXT()
            Call SEARCHRECORD()
        Catch ex As Exception
            Dim msgtype As String = MessageBox.Show(ex.Message, "FrmClass_Load()", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Public Class Crypto
        Private Shared DES As New TripleDESCryptoServiceProvider
        Private Shared MD5 As New MD5CryptoServiceProvider

        Public Shared Function MD5Hash(ByVal value As String) As Byte()
            Return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))
        End Function

        Public Shared Function Encrypt(ByVal stringToEncrypt As String, ByVal key As String) As String
            DES.Key = Crypto.MD5Hash(key)
            DES.Mode = CipherMode.ECB
            Dim Buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(stringToEncrypt)
            Return Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
        End Function

        Public Shared Function Decrypt(ByVal encryptedString As String, ByVal key As String) As String
            Try
                DES.Key = Crypto.MD5Hash(key)
                DES.Mode = CipherMode.ECB
                Dim Buffer As Byte() = Convert.FromBase64String(encryptedString)
                Return ASCIIEncoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
            Catch ex As Exception
                MessageBox.Show("Invalid Key", "Decryption Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Function
    End Class
    Private Sub CLEARTEXT()
        Try
            savetype = "ADD"
            TxtBrandCode.Text = "*****"
            TxtBrandNm.Text = ""
            txtpassword.Text = ""
            TxtSearch.Text = ""
            TxtBrandNm.Focus()
        Catch ex As Exception
            Dim msgtype As String = MessageBox.Show(ex.Message, "CLEARTEXT()", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Public Sub COMPANYBIND()
        CMBSTAGE.Items.Clear()
        If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
        APPCON.CNN.Open()
        STRSQL = "Select ACTDESC FROM KEN_VENDORMASTER"
        OBJSQLCOMMANDGETDESC = New SqlCommand(STRSQL, APPCON.CNN)
        OBJDATAREADERGETDESC = OBJSQLCOMMANDGETDESC.ExecuteReader
        While OBJDATAREADERGETDESC.Read
            CMBSTAGE.Items.Add(Trim(CNULLS(OBJDATAREADERGETDESC!ACTDESC)))
        End While
        OBJDATAREADERGETDESC.Close()
    End Sub
    Public Function GETDESC(ByVal MOPT As Integer, ByVal FORMNAME As String, Optional ByVal FUNNAME As String = "") As String
        Try
            APPCON.connection()
            GETDESC = ""

            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            Select Case (MOPT)
                Case 1
                    STRSQL = "Select ACTCODE1 FROM KEN_VENDORMASTER WHERE ACTDESC='" & Trim(FORMNAME) & "'"
                    OBJSQLCOMMANDGETDESC = New SqlCommand(STRSQL, APPCON.CNN)
                    OBJDATAREADERGETDESC = OBJSQLCOMMANDGETDESC.ExecuteReader
                    While OBJDATAREADERGETDESC.Read
                        GETDESC = Trim(CNULLS(OBJDATAREADERGETDESC!ACTCODE1))
                    End While
                    OBJDATAREADERGETDESC.Close()

                Case 2
                    STRSQL = "Select ACTDESC FROM KEN_VENDORMASTER WHERE ACTCODE1='" & Trim(FORMNAME) & "'"
                    OBJSQLCOMMANDGETDESC = New SqlCommand(STRSQL, APPCON.CNN)
                    OBJDATAREADERGETDESC = OBJSQLCOMMANDGETDESC.ExecuteReader
                    While OBJDATAREADERGETDESC.Read
                        GETDESC = Trim(CNULLS(OBJDATAREADERGETDESC!ACTDESC))
                    End While
                    OBJDATAREADERGETDESC.Close()

            End Select
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
        Catch ex As Exception
            Dim msgtype As String = MessageBox.Show(ex.Message, "GETDESC", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Function
    'Public Sub fontset()
    '    Try
    '        TxtBrandCode.Font = New System.Drawing.Font(colorfrontsetting.fontname, colorfrontsetting.size, colorfrontsetting.style)
    '        TxtBrandNm.Font = New System.Drawing.Font(colorfrontsetting.fontname, colorfrontsetting.size, colorfrontsetting.style)
    '        txtpassword.Font = New System.Drawing.Font(colorfrontsetting.fontname, colorfrontsetting.size, colorfrontsetting.style)
    '        BtnSave.Font = New System.Drawing.Font(colorfrontsetting.fontname, colorfrontsetting.size, colorfrontsetting.style)
    '        BtnExit.Font = New System.Drawing.Font(colorfrontsetting.fontname, colorfrontsetting.size, colorfrontsetting.style)
    '        Grid1.GridColor = Color.FromName(colorfrontsetting.forecolor)
    '        Me.Font = New System.Drawing.Font(colorfrontsetting.fontname, colorfrontsetting.size, colorfrontsetting.style)
    '    Catch ex As Exception
    '        Dim msgtype As String = MessageBox.Show(ex.Message, "fontset()", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub
    Private Sub TEXTTODB()
        Try

            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()

            If savetype = "ADD" Then
                TxtBrandCode.Text = GENFUNCTION.AutoCodeGen("USERPERMISSION", "USERCODE", "U", "", "5", "")
                If TxtBrandCode.Text = "" Then
                    MsgBox("SERIAL NO NOT TO BE GENERATED")
                    Exit Sub
                End If
            End If

            OBJSQLCOMMAND = New SqlCommand()
            TRANS = APPCON.CNN.BeginTransaction
            OBJSQLCOMMAND.Connection = APPCON.CNN
            OBJSQLCOMMAND.Transaction = TRANS

            If savetype = "ADD" Then
                STRSQL = "insert into USERPERMISSION(USERCODE,USERNAME,VCODE,USERPASSWORD)" _
                        & " values (" _
                        & " '" & Trim(TxtBrandCode.Text) & "'," _
                        & " '" & Trim(TxtBrandNm.Text) & "'," _
                        & " '" & GETDESC(1, Trim(CMBSTAGE.Text)) & "'," _
                        & " '" & Trim(txtpassword.Text) & "')"
                OBJSQLCOMMAND.CommandText = StrSql
                OBJSQLCOMMAND.CommandType = CommandType.Text
                OBJSQLCOMMAND.ExecuteNonQuery()
            ElseIf savetype = "EDIT" Then
                STRSQL = "UPDATE USERPERMISSION SET " _
                        & " VCODE= '" & GETDESC(1, Trim(CMBSTAGE.Text)) & "'," _
                       & " USERPASSWORD= '" & Trim(txtpassword.Text) & "' " _
                      & " WHERE USERCODE='" & Trim(TxtBrandCode.Text) & "'"
                OBJSQLCOMMAND.CommandText = StrSql
                OBJSQLCOMMAND.CommandType = CommandType.Text
                OBJSQLCOMMAND.ExecuteNonQuery()
            End If
            TRANS.Commit()
            Call CLEARTEXT()
            MsgBox("SAVED")
        Catch ex As Exception
            TRANS.Rollback()
            Dim msgtype As String = MessageBox.Show(ex.Message, "TEXTTODB()", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub DBTOTEXT(ByVal VRNO As String)
        Try
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            OBJCOMMAND = New SqlCommand("SELECT USERCODE,USERNAME,USERPASSWORD,VCODE FROM USERPERMISSION WHERE USERCODE='" & VRNO & "' GROUP BY USERCODE,USERNAME,USERPASSWORD,VCODE", APPCON.CNN)
            OBJDATAREADER = OBJCOMMAND.ExecuteReader()
            While OBJDATAREADER.Read
                TxtBrandCode.Text = Trim(OBJDATAREADER("USERCODE"))
                TxtBrandNm.Text = Trim(OBJDATAREADER("USERNAME"))
                txtpassword.Text = Trim(OBJDATAREADER("USERPASSWORD"))
                CMBSTAGE.Text = GETDESC(2, Trim(OBJDATAREADER("VCODE")))
            End While
        Catch ex As Exception
            Dim msgtype As String = MessageBox.Show(ex.Message, "DBTOTEXT()", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub BINDGRID()
        Try
            Grid1.Rows = 2
            For J As Integer = 0 To Grid1.Cols - 1
                Grid1.Cell(1, J).Text = ""
            Next
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            Dim I As Integer = 1
            OBJCOMMAND = New SqlCommand("SELECT USERCODE,USERNAME,USERPASSWORD,VCODE FROM USERPERMISSION GROUP BY USERCODE,USERNAME,USERPASSWORD,VCODE ", APPCON.CNN)
            OBJDATAREADER = OBJCOMMAND.ExecuteReader()
            While OBJDATAREADER.Read
                Grid1.Cell(I, 1).Text = Trim(OBJDATAREADER("USERCODE"))
                Grid1.Cell(I, 2).Text = Trim(OBJDATAREADER("USERNAME"))
                Grid1.Cell(I, 3).Text = Trim(OBJDATAREADER("USERPASSWORD"))
                Grid1.Cell(I, 4).Text = GETDESC(2, Trim(OBJDATAREADER("VCODE")))
                Grid1.AddItem("", True)
                I = I + 1
            End While

        Catch ex As Exception
            Dim msgtype As String = MessageBox.Show(ex.Message, "BINDGRID()", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub SEARCHRECORD()
        Dim APPCON As New CNNCLASS
        Try
            APPCON.connection()
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            Grid1.Rows = 2
            For J As Integer = 0 To Grid1.Cols - 1
                Grid1.Cell(1, J).Text = ""
            Next
            Dim STRSQL As String
            Dim I As Int32 = 1
            STRSQL = "SELECT USERCODE,USERNAME,USERPASSWORD,VCODE FROM USERPERMISSION  where  USERNAME  like '%" & TxtSearch.Text & "%' GROUP BY USERCODE,USERNAME,USERPASSWORD,VCODE"
            Dim OBJCOMMAND As New SqlCommand(STRSQL, APPCON.CNN)
            Dim OBJREADER = OBJCOMMAND.ExecuteReader()
            While OBJREADER.Read()
                Grid1.Cell(I, 1).Text = Trim(OBJREADER("USERCODE"))
                Grid1.Cell(I, 2).Text = Trim(OBJREADER("USERNAME"))
                Grid1.Cell(I, 3).Text = Trim(OBJREADER("USERPASSWORD"))
                Grid1.Cell(I, 4).Text = GETDESC(2, Trim(OBJREADER("VCODE")))
                Grid1.AddItem("", True)
                I = I + 1
            End While
            OBJREADER.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "SEARCHRECORD")
        End Try
    End Sub
    Public Sub FORMATGRID()
        'mgbox.Text = "Alt+D For DELETE      Alt+N For NEW      PAGEUP FOR NEXT      PAGEDOWN FOR PREVIOUS"
        Grid1.Cols = 5
        Grid1.Cell(0, 1).Text = "USER CODE"
        Grid1.Column(1).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid1.Column(1).Width = 80
        Grid1.Cell(0, 2).Text = "USER NAME"
        Grid1.Column(2).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid1.Column(2).Width = 200
        Grid1.Column(3).Width = 0
        Grid1.Cell(0, 4).Text = "COMPANY NAME"
        Grid1.Column(4).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid1.Column(4).Width = 200
        Grid1.Locked = True
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            If UserRight("USER CREATION", savetype, SysTemUserName) = True Then
                If Trim(TxtBrandCode.Text) = "" Then
                    MsgBox("INVALID  CODE")
                    Exit Sub
                End If
                If Trim(TxtBrandNm.Text) = "" Then
                    MsgBox("MUST GIVE USER NAME")
                    Exit Sub
                End If

                If Trim(txtpassword.Text) = "" Then
                    MsgBox("MUST GIVE PASSWORD")
                    Exit Sub
                End If
                If Trim(CMBSTAGE.Text) = "" Then
                    MsgBox("MUST GIVE CMPY")
                    Exit Sub
                End If
                If savetype = "ADD" Then
                    If TxtBrandNm.Text <> "" Then
                        If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
                        APPCON.CNN.Open()
                        OBJCOMMAND = New SqlCommand("SELECT USERNAME FROM USERPERMISSION WHERE USERNAME='" & Trim(TxtBrandNm.Text) & "'", APPCON.CNN)
                        OBJDATAREADER = OBJCOMMAND.ExecuteReader()
                        If OBJDATAREADER.Read = True Then
                            MsgBox("NAME CAN NOT BE DUPLICATE")
                            Exit Sub
                        End If
                    End If
                End If

                TEXTTODB()
                Me.CLEARTEXT()
                If FormDisplay = 1 Then
                    If Me.Created = True Then
                        Me.Dispose()
                    End If
                End If
            Else
                MsgBox(savetype, MsgBoxStyle.Critical, "NO RIGHT")
            End If
        Catch ex As Exception
            Dim msgtype As String = MessageBox.Show(ex.Message, "BtnSave_Click()", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub Grid1_Click(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles Grid1.Click
        Try
            savetype = "EDIT"
            If Grid1.Cell(Grid1.ActiveCell.Row, 1).Text <> "" Then
                TxtBrandCode.Text = Trim(Grid1.Cell(Grid1.ActiveCell.Row, 1).Text)
                TxtBrandNm.Text = Trim(Grid1.Cell(Grid1.ActiveCell.Row, 2).Text)
                txtpassword.Text = Trim(Grid1.Cell(Grid1.ActiveCell.Row, 3).Text)
                CMBSTAGE.Text = Trim(Grid1.Cell(Grid1.ActiveCell.Row, 4).Text)
            End If
        Catch ex As Exception
            Dim msgtype As String = MessageBox.Show(ex.Message, "Grid1_Click()", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub TxtSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call SEARCHRECORD()
            TxtSearch.Focus()
        End If
    End Sub
End Class