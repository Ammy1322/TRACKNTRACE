Imports System.Data.SqlClient
Public Class PRODUCT_MASTER
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
    Private Sub PRODUCT_MASTER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

            OBJSQLCOMMAND = New SqlCommand("Select *  from PRODUCTMASTER where CODE ='" & Trim(VAL) & "'", APPCON.CNN)
            OBJDATAREADER1 = OBJSQLCOMMAND.ExecuteReader()
            While OBJDATAREADER1.Read()
                TXTGPCODE.Text = Trim(CNULLS(OBJDATAREADER1("CODE")))
                TXTDESCRIPTION.Text = Trim(CNULLS(OBJDATAREADER1("ITEMNAME")))
                MCODE.Text = Trim(CNULLS(OBJDATAREADER1("ITEMCODE")))
                CMBWEIGHT.Text = Trim(CNULLS(OBJDATAREADER1("WEIGHT")))
                TXTMRP.Text = Trim(CNULLS(OBJDATAREADER1("MRP")))
                CMBACTIVE.Text = Trim(CNULLS(OBJDATAREADER1("ACTIVE")))
                CMBDIMENSION.Text = Trim(CNULLS(OBJDATAREADER1("DIMENSION")))
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
                TXTGPCODE.Text = GENFUNCTION.AutoCodeGen("PRODUCTMASTER", "CODE", "I", "", "5", "")
                If TXTGPCODE.Text = "" Then
                    MsgBox("SERIAL NO NOT TO BE GENERATED")
                    Exit Sub
                End If
            End If
            OBJSQLCOMMAND = New SqlCommand()
            TRANS = APPCON.CNN.BeginTransaction
            OBJSQLCOMMAND.Connection = APPCON.CNN
            OBJSQLCOMMAND.Transaction = TRANS
            If SAVETYPE = "ADD" Then
                StrSql = "INSERT INTO [PRODUCTMASTER]([CODE],[ITEMNAME],[ITEMCODE],[WEIGHT],[MRP],[ACTIVE],[DIMENSION])" _
                        & " values (" _
                        & " '" & Trim(TXTGPCODE.Text) & "'," _
                        & " '" & Trim(TXTDESCRIPTION.Text) & "'," _
                        & " '" & Trim(MCODE.Text) & "'," _
                        & " '" & Trim(CMBWEIGHT.Text) & "'," _
                        & " '" & Trim(TXTMRP.Text) & "'," _
                        & " '" & Trim(CMBACTIVE.Text) & "'," _
                        & " '" & Trim(CMBDIMENSION.Text) & "')"
                OBJSQLCOMMAND.CommandText = StrSql
                OBJSQLCOMMAND.CommandType = CommandType.Text
                OBJSQLCOMMAND.ExecuteNonQuery()
            ElseIf SAVETYPE = "EDIT" Then
                StrSql = "UPDATE PRODUCTMASTER SET " _
                       & " ITEMNAME= '" & Trim(TXTDESCRIPTION.Text) & "', " _
                       & " ITEMCODE= '" & Trim(MCODE.Text) & "', " _
                       & " WEIGHT= '" & Trim(CMBWEIGHT.Text) & "', " _
                       & " MRP= '" & Trim(TXTMRP.Text) & "' ," _
                       & " ACTIVE= '" & Trim(CMBACTIVE.Text) & "' ," _
                       & " DIMENSION= '" & Trim(CMBDIMENSION.Text) & "' " _
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
            TXTDESCRIPTION.Text = ""
            TXTMRP.Text = ""
            TxtSearch.Text = ""
            CMBACTIVE.Text = ""
            CMBDIMENSION.Text = ""
            CMBWEIGHT.Text = ""
            MCODE.Text = ""
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
        Grid2.Cols = 13
        Grid2.Cell(0, 1).Text = "CODE"
        Grid2.Column(1).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid2.Column(1).Width = 70
        Grid2.Cell(0, 2).Text = "PRODUCT NAME"
        Grid2.Column(2).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid2.Column(2).Width = 200
        Grid2.Cell(0, 3).Text = "PRODUCT CODE"
        Grid2.Column(3).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid2.Column(3).Width = 100
        Grid2.Cell(0, 4).Text = "WARRANTY"
        Grid2.Column(4).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid2.Column(4).Width = 0
        Grid2.Cell(0, 5).Text = "VENDOR"
        Grid2.Column(5).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid2.Column(5).Width = 0
        Grid2.Cell(0, 6).Text = "WEIGHT"
        Grid2.Column(6).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid2.Column(6).Width = 100
        Grid2.Cell(0, 7).Text = "GROSS WEIGHT"
        Grid2.Column(7).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid2.Column(7).Width = 0
        Grid2.Cell(0, 8).Text = "BRAND"
        Grid2.Column(8).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid2.Column(8).Width = 0
        Grid2.Cell(0, 9).Text = "MRP"
        Grid2.Column(9).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid2.Column(9).Width = 50
        Grid2.Cell(0, 10).Text = "SEGMENT"
        Grid2.Column(10).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid2.Column(10).Width = 0
        Grid2.Cell(0, 11).Text = "ACTIVE"
        Grid2.Column(11).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid2.Column(11).Width = 50
        Grid2.Cell(0, 12).Text = "DIMENSIONS"
        Grid2.Column(12).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid2.Column(12).Width = 100
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
            STRSQL = "SELECT * FROM PRODUCTMASTER WHERE CODE IS NOT NULL"
            If TXTGCODE.Text <> "" Then
                STRSQL = STRSQL & " AND CODE  like '%" & TXTGCODE.Text & "%'"
            End If
            If TxtSearch.Text <> "" Then
                STRSQL = STRSQL & " AND ITEMNAME  like '%" & TxtSearch.Text & "%'"
            End If
            Dim OBJCOMMAND As New SqlCommand(STRSQL, APPCON.CNN)
            Dim OBJREADER = OBJCOMMAND.ExecuteReader()
            While OBJREADER.Read()
                Grid2.Cell(I, 1).Text = Trim(OBJREADER("CODE"))
                Grid2.Cell(I, 2).Text = Trim(OBJREADER("ITEMNAME"))
                Grid2.Cell(I, 3).Text = Trim(OBJREADER("ITEMCODE"))
                Grid2.Cell(I, 6).Text = Trim(OBJREADER("WEIGHT"))
                Grid2.Cell(I, 9).Text = Trim(OBJREADER("MRP"))
                Grid2.Cell(I, 11).Text = Trim(OBJREADER("ACTIVE"))
                Grid2.Cell(I, 12).Text = Trim(OBJREADER("DIMENSION"))
                Grid2.AddItem("", True)
                I = I + 1
            End While
            OBJREADER.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "SEARCHRECORD")
        End Try
    End Sub
    Private Sub BTNSEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSEARCH.Click
        SEARCHRECORD()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CLEARTEXT()

    End Sub

    Public Function CHECKDATA() As Boolean
        Try
            CHECKDATA = False
            If Trim(TXTDESCRIPTION.Text) = "" Then
                MsgBox("PRODUCT NAME IS BLANK")
                TXTDESCRIPTION.Focus()
                CHECKDATA = True
                Exit Function
            End If
            If Trim(MCODE.Text) = "" Then
                MsgBox("PRODUCT CODE IS BLANK")
                MCODE.Focus()
                CHECKDATA = True
                Exit Function
            End If
            If Trim(CMBDIMENSION.Text) = "" Then
                MsgBox("DIMENSION IS BLANK")
                CMBDIMENSION.Focus()
                CHECKDATA = True
                Exit Function
            End If
            If Trim(CMBWEIGHT.Text) = "" Then
                MsgBox("WEIGHT IS BLANK")
                CMBWEIGHT.Focus()
                CHECKDATA = True
                Exit Function
            End If
            If Trim(TXTMRP.Text) = "" Then
                MsgBox("MRP IS BLANK")
                TXTMRP.Focus()
                CHECKDATA = True
                Exit Function
            End If
            If Trim(CMBACTIVE.Text) = "" Then
                MsgBox("TYPE IS BLANK")
                CMBACTIVE.Focus()
                CHECKDATA = True
                Exit Function
            End If
            If SAVETYPE = "ADD" Then
                If Trim(TXTDESCRIPTION.Text) <> "" Then
                    If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
                    APPCON.CNN.Open()
                    OBJSQLCOMMAND = New SqlCommand("select ITEMNAME from PRODUCTMASTER where ITEMNAME='" & Trim(TXTDESCRIPTION.Text) & "'", APPCON.CNN)
                    OBJDATAREADER1 = OBJSQLCOMMAND.ExecuteReader()
                    If OBJDATAREADER1.Read = True Then
                        MsgBox("PRODUCT NAME CAN NOT BE DUPLICATE.MUST GIVE UNIQUE PRODUCT NAME")
                        CHECKDATA = True
                        Exit Function
                    End If
                End If
                If Trim(MCODE.Text) <> "" Then
                    If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
                    APPCON.CNN.Open()
                    OBJSQLCOMMAND = New SqlCommand("select ITEMCODE from PRODUCTMASTER where ITEMCODE='" & Trim(MCODE.Text) & "'", APPCON.CNN)
                    OBJDATAREADER1 = OBJSQLCOMMAND.ExecuteReader()
                    If OBJDATAREADER1.Read = True Then
                        MsgBox("PRODUCT CODE CAN NOT BE DUPLICATE.MUST GIVE UNIQUE PRODUCT CODE")
                        CHECKDATA = True
                        Exit Function
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.SystemModal, "CHECK DATA")
        End Try
    End Function
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

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BTNDEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNDEL.Click
        Try
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            OBJSQLCOMMAND = New SqlCommand("DELETE  FROM PRODUCTMASTER WHERE CODE='" & Trim(TXTGPCODE.Text) & "'", APPCON.CNN)
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
End Class