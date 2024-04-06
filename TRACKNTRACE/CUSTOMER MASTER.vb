Imports System.Data.SqlClient
Public Class CUSTOMER_MASTER
    Dim OBJSQLCOMMAND As SqlCommand
    Dim OBJSQLCOMMANDNEW As SqlCommand
    Dim OBJSQLCOMMANDNEWGETDESC As SqlCommand
    Dim OBJDATAREADERNEW As SqlDataReader
    Dim OBJDATAREADERGETDESC As SqlDataReader
    Dim OBJDATAREADER1 As SqlDataReader
    Dim StrSql As String = ""
    Dim StrSql1 As String = ""
    Dim TRANS As SqlTransaction
    Dim APPCON As New CNNCLASS
    Dim TRANTYPE As String = ""
    Dim SAVETYPE As String = ""
    Public Function CHECKDATA() As Boolean
        Try
            CHECKDATA = False
            If Trim(TXTNAME.Text) = "" Then
                MsgBox("NAME IS BLANK")
                TXTNAME.Focus()
                CHECKDATA = True
                Exit Function
            End If
            If Trim(TXTEMAIL.Text) = "" Then
                MsgBox("EMAIL IS BLANK")
                TXTEMAIL.Focus()
                CHECKDATA = True
                Exit Function
            End If
            If Trim(TXTADDRESS.Text) = "" Then
                MsgBox("ADDRESS IS BLANK")
                TXTADDRESS.Focus()
                CHECKDATA = True
                Exit Function
            End If
            If Trim(TXTPINCODE.Text) = "" Then
                MsgBox("PINCODE IS BLANK")
                TXTPINCODE.Focus()
                CHECKDATA = True
                Exit Function
            End If
            If Trim(TXTPHNNO.Text) = "" Then
                MsgBox("PHN NO IS BLANK")
                TXTPHNNO.Focus()
                CHECKDATA = True
                Exit Function
            End If
            If SAVETYPE = "ADD" Then
                If Trim(TXTNAME.Text) <> "" Then
                    If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
                    APPCON.CNN.Open()
                    OBJSQLCOMMAND = New SqlCommand("select NAME from CUSTOMERMASTER where NAME='" & Trim(TXTNAME.Text) & "'", APPCON.CNN)
                    OBJDATAREADER1 = OBJSQLCOMMAND.ExecuteReader()
                    If OBJDATAREADER1.Read = True Then
                        MsgBox("CUSTOMER NAME CAN NOT BE DUPLICATE.MUST GIVE UNIQUE CUSTOMER NAME")
                        CHECKDATA = True
                        Exit Function
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.SystemModal, "CHECK DATA")
        End Try
    End Function
    Private Sub BINDGRID()
        'If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
        'APPCON.CNN.Open()
        'CMBWARRANTY.Items.Clear()
        'StrSql = "SELECT [desc] as a  FROM WARRANTYMASTER  where  [DESC]  <>''"
        'OBJSQLCOMMAND = New SqlCommand(StrSql, APPCON.CNN)
        'OBJDATAREADERNEW = OBJSQLCOMMAND.ExecuteReader()
        'While OBJDATAREADERNEW.Read
        '    CMBWARRANTY.Items.Add(OBJDATAREADERNEW("a").ToString)
        'End While
        'OBJSQLCOMMAND.Dispose()
        'OBJDATAREADERNEW.Close()
    End Sub
    Public Sub DBTOTEXT(ByVal VAL As String)
        Try
            'Call CLEARTEXT()
            SAVETYPE = "EDIT"
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()

            OBJSQLCOMMAND = New SqlCommand("Select *  from CUSTOMERMASTER where CODE ='" & Trim(VAL) & "'", APPCON.CNN)
            OBJDATAREADER1 = OBJSQLCOMMAND.ExecuteReader()
            While OBJDATAREADER1.Read()
                TXTGPCODE.Text = Trim(CNULLS(OBJDATAREADER1("CODE")))
                TXTNAME.Text = Trim(CNULLS(OBJDATAREADER1("NAME")))
                TXTEMAIL.Text = Trim(CNULLS(OBJDATAREADER1("EMAIL")))
                TXTPINCODE.Text = Trim(CNULLS(OBJDATAREADER1("PINCODE")))
                TXTPHNNO.Text = Trim(CNULLS(OBJDATAREADER1("PHNNO")))
                TXTADDRESS.Text = Trim(CNULLS(OBJDATAREADER1("ADDRESS")))
            End While
            OBJDATAREADER1.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "DBTOTEXT")
        End Try
    End Sub
    Public Sub TEXTTODB()
        Try
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()

            If SAVETYPE = "ADD" Then
                TXTGPCODE.Text = GENFUNCTION.AutoCodeGen("CUSTOMERMASTER", "CODE", "C", "", "5", "")
                If TXTGPCODE.Text = "*****" Then
                    MsgBox("SERIAL NO NOT TO BE GENERATED")
                    Exit Sub
                End If
            End If
            OBJSQLCOMMAND = New SqlCommand()
            TRANS = APPCON.CNN.BeginTransaction
            OBJSQLCOMMAND.Connection = APPCON.CNN
            OBJSQLCOMMAND.Transaction = TRANS
            If SAVETYPE = "ADD" Then
                StrSql = "INSERT INTO [CUSTOMERMASTER]([CODE],[NAME],[EMAIL],[PHNNO],[ADDRESS],[PINCODE])" _
                        & " values (" _
                        & " '" & Trim(TXTGPCODE.Text) & "'," _
                        & " '" & Trim(TXTNAME.Text) & "'," _
                        & " '" & Trim(TXTEMAIL.Text) & "'," _
                        & " '" & Trim(TXTPHNNO.Text) & "'," _
                        & " '" & Trim(TXTADDRESS.Text) & "'," _
                        & " '" & Trim(TXTPINCODE.Text) & "')"
                OBJSQLCOMMAND.CommandText = StrSql
                OBJSQLCOMMAND.CommandType = CommandType.Text
                OBJSQLCOMMAND.ExecuteNonQuery()
            ElseIf SAVETYPE = "EDIT" Then
                StrSql = "UPDATE CUSTOMERMASTER SET " _
                       & " NAME= '" & Trim(TXTNAME.Text) & "', " _
                       & " EMAIL= '" & Trim(TXTEMAIL.Text) & "', " _
                       & " PHNNO= '" & Trim(TXTPHNNO.Text) & "', " _
                       & " ADDRESS= '" & Trim(TXTADDRESS.Text) & "' ," _
                       & " PINCODE= '" & Trim(TXTPINCODE.Text) & "' ," _
                       & " WHERE CODE='" & Trim(TXTGPCODE.Text) & "'"
                OBJSQLCOMMAND.CommandText = StrSql
                OBJSQLCOMMAND.CommandType = CommandType.Text
                OBJSQLCOMMAND.ExecuteNonQuery()
            End If
            TRANS.Commit()
            Call CLEARTEXT()
            MsgBox("SAVED")
        Catch ex As Exception
            TRANS.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "TEXTTODB")
        End Try
    End Sub
    Public Sub CLEARTEXT()
        Try
            SAVETYPE = "ADD"
            TXTGCODE.Text = ""
            TXTNAME.Text = ""
            TXTPHNNO.Text = ""
            TxtSearch.Text = ""
            TXTADDRESS.Text = ""
            TXTPINCODE.Text = ""
            TXTEMAIL.Text = ""
            Grid2.Rows = 2
            For i As Integer = 1 To Grid2.Cols - 1
                Grid2.Cell(1, i).Text = ""
            Next i
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "CLEARTEXT")
        End Try
    End Sub
    Public Sub FORMATGRID()
        'mgbox.Text = "Alt+D For DELETE      Alt+N For NEW      PAGEUP FOR NEXT      PAGEDOWN FOR PREVIOUS"
        Grid2.Cols = 7
        Grid2.Cell(0, 1).Text = "Code"
        Grid2.Column(1).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid2.Column(1).Width = 70
        Grid2.Cell(0, 2).Text = "Name"
        Grid2.Column(2).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid2.Column(2).Width = 200
        Grid2.Cell(0, 3).Text = "Email"
        Grid2.Column(3).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid2.Column(3).Width = 140
        Grid2.Cell(0, 4).Text = "PhnNo"
        Grid2.Column(4).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid2.Column(4).Width = 100
        Grid2.Cell(0, 5).Text = "Address""
        Grid2.Column(5).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid2.Column(5).Width = 200
        Grid2.Cell(0, 6).Text = "Pincode"
        Grid2.Column(6).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid2.Column(6).Width = 100
        Grid2.Locked = True
    End Sub
    Private Sub SEARCHRECORD()
        Dim APPCON As New CNNCLASS
        Try
            APPCON.connection()
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            Grid2.Rows = 2
            For J As Integer = 0 To Grid2.Cols - 1
                Grid2.Cell(1, J).Text = ""
            Next
            Dim STRSQL As String
            Dim I As Int32 = 1
            STRSQL = "SELECT * FROM CUSTOMERMASTER WHERE CODE IS NOT NULL"
            If TXTGCODE.Text <> "" Then
                STRSQL = STRSQL & " AND CODE  like '%" & TXTGCODE.Text & "%'"
            End If
            If TxtSearch.Text <> "" Then
                STRSQL = STRSQL & " AND NAME  like '%" & TxtSearch.Text & "%'"
            End If
            Dim OBJCOMMAND As New SqlCommand(STRSQL, APPCON.CNN)
            Dim OBJREADER = OBJCOMMAND.ExecuteReader()
            While OBJREADER.Read()
                Grid2.Cell(I, 1).Text = Trim(OBJREADER("CODE"))
                Grid2.Cell(I, 2).Text = Trim(OBJREADER("NAME"))
                Grid2.Cell(I, 3).Text = Trim(OBJREADER("EMAIL"))
                Grid2.Cell(I, 4).Text = Trim(OBJREADER("PHNNO"))
                Grid2.Cell(I, 5).Text = Trim(OBJREADER("ADDRESS"))
                Grid2.Cell(I, 6).Text = Trim(OBJREADER("PINCODE"))
                Grid2.AddItem("", True)
                I = I + 1
            End While
            OBJREADER.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "SEARCHRECORD")
        End Try
    End Sub
    Private Sub CUSTOMER_MASTER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Top = 10
            Me.Left = 50
            Me.KeyPreview = True
            Call FORMATGRID()
            APPCON.connection()
            Call CLEARTEXT()
            Call BINDGRID()
            SAVETYPE = "ADD"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "FRMCATEGORY_Load")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CLEARTEXT()

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            If CHECKDATA() = True Then
                Exit Sub
            End If
            Call TEXTTODB()
            If FormDisplay = 1 Then
                If Me.Created = True Then
                    Me.Dispose()
                End If
            End If
            Call SEARCHRECORD()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.SystemModal, "BtnSave_Click")
        End Try
    End Sub

    Private Sub BTNDEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNDEL.Click
        Try
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            OBJSQLCOMMAND = New SqlCommand("DELETE  FROM CUSTOMERMASTER WHERE CODE='" & Trim(TXTGPCODE.Text) & "'", APPCON.CNN)
            OBJSQLCOMMAND.ExecuteNonQuery()
            MsgBox("RECORD DELETED")
            Call CLEARTEXT()
            Me.SEARCHRECORD()
            If APPCON.CNN.State = ConnectionState.Closed Then APPCON.CNN.Open()
            APPCON.CNN.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.SystemModal, "BTNDEL_Click")
        End Try
    End Sub

    Private Sub Grid2_DoubleClick(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles Grid2.DoubleClick
        Try
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            Dim CODE As String = ""
            If Grid2.Cell(Grid2.ActiveCell.Row, 1).Text <> "" Then
                CODE = Trim(Grid2.Cell(Grid2.ActiveCell.Row, 1).Text)

            End If
            Call DBTOTEXT(CODE)
            SAVETYPE = "EDIT"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.SystemModal, "BtnSave_Click")
        End Try
    End Sub

    Private Sub BTNSEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSEARCH.Click
        SEARCHRECORD()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub
End Class