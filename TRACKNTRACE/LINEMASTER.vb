Imports System.Data
Imports System.Data.SqlClient
Public Class LINEMASTER
    Dim APPCON As New CNNCLASS
    Dim savetype As String
    Dim OBJSQLCOMMAND As SqlCommand
    Dim OBJCOMMAND As SqlCommand
    Dim OBJCOMMANDNEW As SqlCommand
    Dim OBJDATAREADER As SqlDataReader
    Dim OBJDATAREADERNEW As SqlDataReader
    Dim TRANS As SqlTransaction
    Dim StrSql As String

    Private Sub LINEMASTER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Top = 100
            Me.Left = 300
            'colorfrontsetting.fontsetting()
            savetype = "ADD"

            APPCON.connection()
            Me.KeyPreview = True

            Call FORMATGRID()
            BINDGRID()
            Call CLEARTEXT()
        Catch ex As Exception
            Dim msgtype As String = MessageBox.Show(ex.Message, "FrmClass_Load()", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub CLEARTEXT()
        Try
            savetype = "ADD"
            TxtColorCode.Text = "*****"
            TXTLINENAME.Text = ""
            TxtSearchNAME.Text = ""
            TXTLINENO.Text = ""
        Catch ex As Exception
            Dim msgtype As String = MessageBox.Show(ex.Message, "CLEARTEXT()", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
 
    Private Sub TEXTTODB()
        Try
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            If savetype = "ADD" Then
                TxtColorCode.Text = GENFUNCTION.AutoCodeGen("KEN_LINEMASTER", "COLOR_CODE", "C", "", "5", "")
                If TxtColorCode.Text = "" Then
                    MsgBox("SERIAL NO NOT TO BE GENERATED")
                    Exit Sub
                End If
            End If
            OBJSQLCOMMAND = New SqlCommand()
            TRANS = APPCON.CNN.BeginTransaction
            OBJSQLCOMMAND.Connection = APPCON.CNN
            OBJSQLCOMMAND.Transaction = TRANS
            If savetype = "ADD" Then
                StrSql = "insert into KEN_LINEMASTER(COLOR_CODE,MCOLORCODE,COLOR_DESC )" _
                        & " values (" _
                        & " '" & Trim(TxtColorCode.Text) & "'," _
                        & " '" & Trim(TXTLINENO.Text) & "'," _
                        & " '" & Trim(TXTLINENAME.Text) & "')"
                OBJSQLCOMMAND.CommandText = StrSql
                OBJSQLCOMMAND.CommandType = CommandType.Text
                OBJSQLCOMMAND.ExecuteNonQuery()
            ElseIf savetype = "EDIT" Then
                StrSql = "UPDATE KEN_LINEMASTER SET " _
                      & " COLOR_DESC= '" & Trim(TXTLINENAME.Text) & "' " _
                      & " WHERE COLOR_CODE='" & Trim(TxtColorCode.Text) & "'"
                OBJSQLCOMMAND.CommandText = StrSql
                OBJSQLCOMMAND.CommandType = CommandType.Text
                OBJSQLCOMMAND.ExecuteNonQuery()
            End If
            TRANS.Commit()
            Call CLEARTEXT()
            MsgBox("SAVED")
            TXTLINENAME.Focus()
        Catch ex As Exception
            TRANS.Rollback()
            Dim msgtype As String = MessageBox.Show(ex.Message, "TEXTTODB()", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub DBTOTEXT(ByVal VRNO As String)
        Try
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            OBJCOMMAND = New SqlCommand("SELECT * FROM KEN_LINEMASTER WHERE COLOR_CODE='" & VRNO & "'", APPCON.CNN)
            OBJDATAREADER = OBJCOMMAND.ExecuteReader()
            While OBJDATAREADER.Read
                TxtColorCode.Text = Trim(OBJDATAREADER("COLOR_CODE"))
                TXTLINENO.Text = Trim(OBJDATAREADER("MCOLORCODE"))
                TXTLINENAME.Text = Trim(OBJDATAREADER("COLOR_DESC"))
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
            OBJCOMMAND = New SqlCommand("SELECT * FROM KEN_LINEMASTER ORDER BY COLOR_CODE ", APPCON.CNN)
            OBJDATAREADER = OBJCOMMAND.ExecuteReader()
            While OBJDATAREADER.Read
                Grid1.Cell(I, 1).Text = Trim(OBJDATAREADER("COLOR_CODE"))
                Grid1.Cell(I, 2).Text = Trim(OBJDATAREADER("MCOLORCODE"))
                Grid1.Cell(I, 3).Text = Trim(OBJDATAREADER("COLOR_DESC"))
                Grid1.AddItem("", True)
                I = I + 1
            End While
            OBJCOMMAND.Dispose()
            OBJDATAREADER.Close()
        Catch ex As Exception
            Dim msgtype As String = MessageBox.Show(ex.Message, "BINDGRID()", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub SEARCHRECORD()
        Try
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            Grid1.Rows = 2
            For J As Integer = 0 To Grid1.Cols - 1
                Grid1.Cell(1, J).Text = ""
            Next
            Dim STRSQL As String
            Dim I As Int32 = 1
            STRSQL = "SELECT *  FROM KEN_LINEMASTER  where  COLOR_DESC  <>''"

            If TxtSearchNAME.Text <> "" Then
                STRSQL = STRSQL & " AND COLOR_DESC  like '%" & TxtSearchNAME.Text & "%'"
            End If
            If TXTSCODE.Text <> "" Then
                STRSQL = STRSQL & " AND MCOLORCODE  like '%" & TXTSCODE.Text & "%'"
            End If
            STRSQL = STRSQL & " ORDER BY COLOR_CODE"

            Dim OBJCOMMAND As New SqlCommand(STRSQL, APPCON.CNN)
            Dim OBJREADER = OBJCOMMAND.ExecuteReader()
            While OBJREADER.Read()
                Grid1.Cell(I, 1).Text = Trim(OBJREADER("COLOR_CODE"))
                Grid1.Cell(I, 2).Text = Trim(OBJREADER("MCOLORCODE"))
                Grid1.Cell(I, 3).Text = Trim(OBJREADER("COLOR_DESC"))
                Grid1.AddItem("", True)
                I = I + 1
            End While
            OBJCOMMAND.Dispose()
            OBJREADER.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "SEARCHRECORD")
        End Try
    End Sub

    Public Sub FORMATGRID()
        Grid1.Cell(0, 1).Text = "Code"
        Grid1.Column(1).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid1.Column(1).Width = 330
        Grid1.Cell(0, 2).Text = "Line No"
        Grid1.Column(2).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid1.Column(2).Width = 330
        Grid1.Cell(0, 3).Text = "Line Name"
        Grid1.Column(3).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid1.Column(3).Width = 0
        Grid1.Locked = True
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If Trim(TXTLINENO.Text) = "" Then
                MsgBox("INVALID LINE NO")
                Exit Sub
            End If
            If Trim(TXTLINENAME.Text) = "" Then
                MsgBox("MUST GIVE LINE NAME")
                Exit Sub
            End If

            If Trim(TxtColorCode.Text) <> "" Then
                If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
                APPCON.CNN.Open()
                OBJCOMMAND = New SqlCommand("select MCOLORCODE from KEN_LINEMASTER where MCOLORCODE='" & Trim(TXTLINENO.Text) & "'", APPCON.CNN)
                OBJDATAREADER = OBJCOMMAND.ExecuteReader()
                If OBJDATAREADER.Read <> True Then
                    If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
                    APPCON.CNN.Open()
                    OBJCOMMANDNEW = New SqlCommand("select COLOR_DESC from KEN_LINEMASTER where COLOR_DESC='" & Trim(TXTLINENAME.Text) & "'", APPCON.CNN)
                    OBJDATAREADERNEW = OBJCOMMANDNEW.ExecuteReader()
                    If OBJDATAREADERNEW.Read = True Then
                        MsgBox("LINE DESCRIPTION CAN NOT BE DUPLICATE.MUST GIVE UNIQUE LINE DESCRIPTION")
                        Exit Sub
                    End If
                End If
                If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
                APPCON.CNN.Open()
                OBJCOMMAND = New SqlCommand("SELECT COLOR_DESC FROM KEN_LINEMASTER WHERE COLOR_DESC='" & Trim(TXTLINENAME.Text) & "' AND MCOLORCODE<>'" & Trim(TXTLINENO.Text) & "' ", APPCON.CNN)
                OBJDATAREADERNEW = OBJCOMMAND.ExecuteReader()
                If OBJDATAREADERNEW.Read = True Then
                    MsgBox("LINE DESCRIPTION CAN NOT BE DUPLICATE.MUST GIVE UNIQUE LINE DESCRIPTION")
                    Exit Sub
                End If
            End If
            TEXTTODB()
            Me.CLEARTEXT()
            If FormDisplay = 1 Then
                If Me.Created = True Then
                    Me.Dispose()
                End If
            End If
        Catch ex As Exception
            Dim msgtype As String = MessageBox.Show(ex.Message, "BtnSave_Click()", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub TXTLINENO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTLINENO.TextChanged
        TXTLINENAME.Text = TXTLINENO.Text
    End Sub

    Private Sub Grid1_Click(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles Grid1.Click
        Try
            savetype = "EDIT"
            If Grid1.Cell(Grid1.ActiveCell.Row, 1).Text <> "" Then
                TxtColorCode.Text = Trim(Grid1.Cell(Grid1.ActiveCell.Row, 1).Text)
                TXTLINENO.Text = Trim(Grid1.Cell(Grid1.ActiveCell.Row, 2).Text)
                TXTLINENAME.Text = Trim(Grid1.Cell(Grid1.ActiveCell.Row, 3).Text)
            End If
        Catch ex As Exception
            Dim msgtype As String = MessageBox.Show(ex.Message, "Grid1_Click()", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub BTNNEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNEW.Click
        CLEARTEXT()
    End Sub

    Private Sub BTNDEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNDEL.Click
        Try
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            OBJSQLCOMMAND = New SqlCommand("DELETE  FROM KEN_LINEMASTER WHERE COLOR_CODE='" & Trim(TxtColorCode.Text) & "'", APPCON.CNN)
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

    Private Sub BTNSEARCH_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSEARCH.Click
        Call SEARCHRECORD()
        TxtSearchNAME.Focus()
    End Sub
End Class