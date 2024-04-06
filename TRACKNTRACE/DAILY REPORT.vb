Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Public Class DAILY_REPORT
    Dim APPCON As New CNNCLASS
    Dim APPCON1 As New CNNCLASS
    Dim newcon As New CNNCLASS
    Dim STRSQL As String = ""
    Dim STRSQLGETDESC As String = ""
    Dim OBJSQLCOMMAND As SqlCommand
    Dim OBJSQLCOMMANDNEW As SqlCommand
    Dim OBJSQLCOMMANDGETDESC As SqlCommand
    Dim OBJDATAREADER As SqlDataReader
    Dim OBJDATAREADERNEW As SqlDataReader
    Dim OBJDATAREADERGETDESC As SqlDataReader
    Dim savetype As String = ""
    Dim OBJDATASET As DataSet
    Dim OBJSQLDATAADAPTER As SqlDataAdapter
    Dim TNAMESUB As String = ""
    Dim PrintOpt As String = "S"
    Dim NOCOP As Integer = 0
    Private Sub BTNSEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Grid2.Rows = 2
            For J As Integer = 0 To Grid2.Cols - 1
                Grid2.Cell(0, J).Text = ""
            Next
            If CMBRTYPE.Text = "MASTER CARTON" Then
                Call FORMATGRID1()
                Call SEARCHPACK()
            ElseIf CMBRTYPE.Text = "SCANNED" Then
                Call FORMATGRID()
                Call SEARCHSCANNED()
            ElseIf CMBRTYPE.Text = "PALLET CRATE" Then
                Call FORMATPALLET()
                Call SEARCHPALLET()
            ElseIf CMBRTYPE.Text = "ORDER FEEDING" Then
                Call FORMATORDER()
                Call SEARCHORDER()
            ElseIf CMBRTYPE.Text = "DISPATCH" Then
                Call FORMATDISPATCH()
                Call SEARCHDISPATCH()
            ElseIf CMBRTYPE.Text = "INSPECTION" Then
                Call FORMATINSPECTION()
                Call SEARCHINSPECTION()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SEARCHORDER()
        Try
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            Grid2.Rows = 2
            For J As Integer = 0 To Grid2.Cols - 1
                Grid2.Cell(1, J).Text = ""
            Next
            Dim I As Int32 = 1
            STRSQL = "SELECT RIGHT(DATE,2)+'-'+LEFT(RIGHT(DATE,4),2)+'-'+LEFT(DATE,4) AS date, [time] AS TIME,[ITEMNAME],[ITEMCODE],QTY,USERNAME,ORDERNO FROM orderfeed WHERE ORDERNO  IS  NOT NULL "
            If Trim(DTFROM.Text) <> "" And Trim(DTTO.Text) <> "" Then
                STRSQL = STRSQL & " and DATE  between  " & " '" & Format(DTFROM.Value, "yyyyMMdd") & "' and '" & Format(DTTO.Value, "yyyyMMdd") & "'"
            End If
            If Trim(CMBINAME.Text) <> "" Then
                STRSQL = STRSQL & " AND LTRIM(RTRIM(ITEMNAME))='" & Trim(CMBINAME.Text) & "'"
            End If
            If Trim(CMBICODE.Text) <> "" Then
                STRSQL = STRSQL & " AND LTRIM(RTRIM(ITEMCODE))='" & Trim(CMBICODE.Text) & "'"
            End If
            Dim OBJCOMMAND As New SqlCommand(STRSQL, APPCON.CNN)
            Dim OBJREADER = OBJCOMMAND.ExecuteReader()
            While OBJREADER.Read()
                Grid2.Cell(I, 1).Text = Trim(CNULLS(OBJREADER("DATE")))
                Grid2.Cell(I, 2).Text = Trim(CNULLS(OBJREADER("TIME")))
                Grid2.Cell(I, 3).Text = Trim(CNULLS(OBJREADER("ORDERNO")))
                Grid2.Cell(I, 4).Text = Trim(CNULLS(OBJREADER("ITEMNAME")))
                Grid2.Cell(I, 5).Text = Trim(CNULLS(OBJREADER("ITEMCODE")))
                Grid2.Cell(I, 6).Text = Trim(CNULLS(OBJREADER("QTY")))
                Grid2.Cell(I, 8).Text = Trim(CNULLS(OBJREADER("USERNAME")))
                Grid2.AddItem("", True)
                I = I + 1
            End While
            OBJREADER.Close()
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "SEARCHRECORD")
        End Try
    End Sub
    Private Sub WH1()
        Try
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            Grid2.Rows = 2
            For J As Integer = 0 To Grid2.Cols - 1
                Grid2.Cell(1, J).Text = ""
            Next
            Dim I As Int32 = 1

            If RBDET.Checked = True Then
                STRSQL = "SELECT RIGHT(DATE,2)+'-'+LEFT(RIGHT(DATE,4),2)+'-'+LEFT(DATE,4) AS date, [time] AS TIME,trno,[ITEMNAME],[ITEMCODE],[BARCODE],USERNAME FROM [WH1] WHERE BARCODE  IS  NOT NULL "
            ElseIf RBCON.Checked = True Then
                STRSQL = "SELECT RIGHT(DATE,2)+'-'+LEFT(RIGHT(DATE,4),2)+'-'+LEFT(DATE,4) AS date,TRNO ,[ITEMNAME],[ITEMCODE],USERNAME,COUNT([BARCODE]) AS BARCODE FROM [WH1] WHERE BARCODE  IS  NOT NULL "
            End If
            If Trim(DTFROM.Text) <> "" And Trim(DTTO.Text) <> "" Then
                STRSQL = STRSQL & " and DATE  between  " & " '" & Format(DTFROM.Value, "yyyyMMdd") & "' and '" & Format(DTTO.Value, "yyyyMMdd") & "'"
            End If
            If Trim(CMBINAME.Text) <> "" Then
                STRSQL = STRSQL & " AND LTRIM(RTRIM(ITEMNAME))='" & Trim(CMBINAME.Text) & "'"
            End If
            If Trim(CMBBARCODE.Text) <> "" Then
                STRSQL = STRSQL & " AND LTRIM(RTRIM(barcodeno)) ='" & Trim(CMBBARCODE.Text) & "'"
            End If
            If Trim(CMBICODE.Text) <> "" Then
                STRSQL = STRSQL & " AND LTRIM(RTRIM(ITEMCODE))='" & Trim(CMBICODE.Text) & "'"
            End If
            If Trim(CMBSRNO.Text) <> "" Then
                STRSQL = STRSQL & " AND LTRIM(RTRIM(TRNO))='" & Trim(CMBSRNO.Text) & "'"
            End If
            If RBCON.Checked = True Then
                STRSQL = STRSQL & " GROUP BY TRNO, ITEMCODE,ITEMNAME,DATE,USERNAME "
            End If
            Dim OBJCOMMAND As New SqlCommand(STRSQL, APPCON.CNN)
            Dim OBJREADER = OBJCOMMAND.ExecuteReader()
            While OBJREADER.Read()
                Grid2.Cell(I, 1).Text = Trim(CNULLS(OBJREADER("DATE")))
                If RBDET.Checked = True Then
                    Grid2.Cell(I, 2).Text = Trim(CNULLS(OBJREADER("TIME")))
                End If
                Grid2.Cell(I, 3).Text = Trim(CNULLS(OBJREADER("TRNO")))
                Grid2.Cell(I, 4).Text = Trim(CNULLS(OBJREADER("ITEMNAME")))
                Grid2.Cell(I, 5).Text = Trim(CNULLS(OBJREADER("ITEMCODE")))
                Grid2.Cell(I, 6).Text = Trim(CNULLS(OBJREADER("BARCODE")))
                Grid2.Cell(I, 8).Text = Trim(CNULLS(OBJREADER("USERNAME")))
                Grid2.AddItem("", True)
                I = I + 1
            End While
            OBJREADER.Close()
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "SEARCHRECORD")
        End Try
    End Sub
    Private Sub SEARCHPALLET()
        Try
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            Grid2.Rows = 2
            For J As Integer = 0 To Grid2.Cols - 1
                Grid2.Cell(1, J).Text = ""
            Next
            Dim I As Int32 = 1

            If RBDET.Checked = True Then
                STRSQL = "SELECT RIGHT(DATE,2)+'-'+LEFT(RIGHT(DATE,4),2)+'-'+LEFT(DATE,4) AS date, [time] AS TIME,trno,[ITEMNAME],[ITEMCODE],[BARCODE],USERNAME FROM [PALLET] WHERE BARCODE  IS  NOT NULL "
            ElseIf RBCON.Checked = True Then
                STRSQL = "SELECT RIGHT(DATE,2)+'-'+LEFT(RIGHT(DATE,4),2)+'-'+LEFT(DATE,4) AS date,TRNO ,[ITEMNAME],[ITEMCODE],USERNAME,COUNT([BARCODE]) AS BARCODE FROM [PALLET] WHERE BARCODE  IS  NOT NULL "
            End If
            If Trim(DTFROM.Text) <> "" And Trim(DTTO.Text) <> "" Then
                STRSQL = STRSQL & " and DATE  between  " & " '" & Format(DTFROM.Value, "yyyyMMdd") & "' and '" & Format(DTTO.Value, "yyyyMMdd") & "'"
            End If
            If Trim(CMBINAME.Text) <> "" Then
                STRSQL = STRSQL & " AND LTRIM(RTRIM(ITEMNAME))='" & Trim(CMBINAME.Text) & "'"
            End If
            If Trim(CMBBARCODE.Text) <> "" Then
                STRSQL = STRSQL & " AND LTRIM(RTRIM(barcodeno)) ='" & Trim(CMBBARCODE.Text) & "'"
            End If
            If Trim(CMBICODE.Text) <> "" Then
                STRSQL = STRSQL & " AND LTRIM(RTRIM(ITEMCODE))='" & Trim(CMBICODE.Text) & "'"
            End If
            If Trim(CMBSRNO.Text) <> "" Then
                STRSQL = STRSQL & " AND LTRIM(RTRIM(TRNO))='" & Trim(CMBSRNO.Text) & "'"
            End If
            If RBCON.Checked = True Then
                STRSQL = STRSQL & " GROUP BY TRNO, ITEMCODE,ITEMNAME,DATE,USERNAME "
            End If
            Dim OBJCOMMAND As New SqlCommand(STRSQL, APPCON.CNN)
            Dim OBJREADER = OBJCOMMAND.ExecuteReader()
            While OBJREADER.Read()
                Grid2.Cell(I, 1).Text = Trim(CNULLS(OBJREADER("DATE")))
                If RBDET.Checked = True Then
                    Grid2.Cell(I, 2).Text = Trim(CNULLS(OBJREADER("TIME")))
                End If
                Grid2.Cell(I, 3).Text = Trim(CNULLS(OBJREADER("TRNO")))
                Grid2.Cell(I, 4).Text = Trim(CNULLS(OBJREADER("ITEMNAME")))
                Grid2.Cell(I, 5).Text = Trim(CNULLS(OBJREADER("ITEMCODE")))
                Grid2.Cell(I, 6).Text = Trim(CNULLS(OBJREADER("BARCODE")))
                Grid2.Cell(I, 8).Text = Trim(CNULLS(OBJREADER("USERNAME")))
                Grid2.AddItem("", True)
                I = I + 1
            End While
            OBJREADER.Close()
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "SEARCHRECORD")
        End Try
    End Sub
    Private Sub SEARCHSCANNED()
        Try
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            Grid2.Rows = 2
            For J As Integer = 0 To Grid2.Cols - 1
                Grid2.Cell(1, J).Text = ""
            Next
            Dim I As Int32 = 1
            STRSQL = "SELECT RIGHT(DATE,2)+'-'+LEFT(RIGHT(DATE,4),2)+'-'+LEFT(DATE,4) AS date, [time] AS TIME,[ITEMNAME],[ITEMCODE],left(right(barcode,17),15) as BARCODE,TYPE,LINE,USERNAME FROM [SCANNED] WHERE BARCODE  IS  NOT NULL "
            If Trim(DTFROM.Text) <> "" And Trim(DTTO.Text) <> "" Then
                STRSQL = STRSQL & " and DATE  between  " & " '" & Format(DTFROM.Value, "yyyyMMdd") & "' and '" & Format(DTTO.Value, "yyyyMMdd") & "'"
            End If
            If Trim(CMBINAME.Text) <> "" Then
                STRSQL = STRSQL & " AND LTRIM(RTRIM(ITEMNAME))='" & Trim(CMBINAME.Text) & "'"
            End If
            If Trim(CMBICODE.Text) <> "" Then
                STRSQL = STRSQL & " AND LTRIM(RTRIM(ITEMCODE))='" & Trim(CMBINAME.Text) & "'"
            End If
            If Trim(CMBLINE.Text) <> "" Then
                STRSQL = STRSQL & " AND LTRIM(RTRIM(LINE))='" & Trim(CMBINAME.Text) & "'"
            End If
            If Trim(CMBBARCODE.Text) <> "" Then
                STRSQL = STRSQL & " AND LTRIM(RTRIM(barcodeno)) ='" & Trim(CMBBARCODE.Text) & "'"
            End If
            Dim OBJCOMMAND As New SqlCommand(STRSQL, APPCON.CNN)
            Dim OBJREADER = OBJCOMMAND.ExecuteReader()
            While OBJREADER.Read()
                Grid2.Cell(I, 1).Text = Trim(CNULLS(OBJREADER("DATE")))
                Grid2.Cell(I, 2).Text = Trim(CNULLS(OBJREADER("TIME")))
                Grid2.Cell(I, 3).Text = Trim(CNULLS(OBJREADER("ITEMNAME")))
                Grid2.Cell(I, 4).Text = Trim(CNULLS(OBJREADER("ITEMCODE")))
                Grid2.Cell(I, 5).Text = Trim(CNULLS(OBJREADER("BARCODE")))
                Grid2.Cell(I, 6).Text = Trim(CNULLS(OBJREADER("TYPE")))
                Grid2.Cell(I, 7).Text = Trim(CNULLS(OBJREADER("LINE")))
                Grid2.Cell(I, 8).Text = Trim(CNULLS(OBJREADER("USERNAME")))
                Grid2.AddItem("", True)
                I = I + 1
            End While
            OBJREADER.Close()
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "SEARCHRECORD")
        End Try
    End Sub
    Private Sub SEARCHINSPECTION()
        Try
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            Grid2.Rows = 2
            For J As Integer = 0 To Grid2.Cols - 1
                Grid2.Cell(1, J).Text = ""
            Next
            Dim I As Int32 = 1
            STRSQL = "SELECT RIGHT(DATE,2)+'-'+LEFT(RIGHT(DATE,4),2)+'-'+LEFT(DATE,4) AS date, [time] AS TIME,[ITEMNAME],BARCODE,[ITEMCODE],TRNO,CARTONNO  ,USERNAME FROM INSPECTION WHERE BARCODE  IS  NOT NULL"
            If Trim(DTFROM.Text) <> "" And Trim(DTTO.Text) <> "" Then
                STRSQL = STRSQL & " and DATE  between  " & " '" & Format(DTFROM.Value, "yyyyMMdd") & "' and '" & Format(DTTO.Value, "yyyyMMdd") & "'"
            End If
            If Trim(CMBINAME.Text) <> "" Then
                STRSQL = STRSQL & " AND LTRIM(RTRIM(ITEMNAME))='" & Trim(CMBINAME.Text) & "'"
            End If
            If Trim(CMBBARCODE.Text) <> "" Then
                STRSQL = STRSQL & " AND LTRIM(RTRIM(barcodeno)) ='" & Trim(CMBBARCODE.Text) & "'"
            End If
            Dim OBJCOMMAND As New SqlCommand(STRSQL, APPCON.CNN)
            Dim OBJREADER = OBJCOMMAND.ExecuteReader()
            While OBJREADER.Read()
                Grid2.Cell(I, 1).Text = Trim(CNULLS(OBJREADER("DATE")))
                Grid2.Cell(I, 2).Text = Trim(CNULLS(OBJREADER("TIME")))
                Grid2.Cell(I, 3).Text = Trim(CNULLS(OBJREADER("TRNO")))
                Grid2.Cell(I, 4).Text = Trim(CNULLS(OBJREADER("CARTONNO")))
                Grid2.Cell(I, 5).Text = Trim(CNULLS(OBJREADER("ITEMNAME")))
                Grid2.Cell(I, 6).Text = Trim(CNULLS(OBJREADER("ITEMCODE")))
                Grid2.Cell(I, 7).Text = Trim(CNULLS(OBJREADER("BARCODE")))
                Grid2.Cell(I, 8).Text = Trim(CNULLS(OBJREADER("USERNAME")))
                Grid2.AddItem("", True)
                I = I + 1
            End While
            OBJREADER.Close()
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "SEARCHRECORD")
        End Try
    End Sub
    Private Sub SEARCHDISPATCH()
        Try
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            Grid2.Rows = 2
            For J As Integer = 0 To Grid2.Cols - 1
                Grid2.Cell(1, J).Text = ""
            Next
            Dim I As Int32 = 1
            If RBDET.Checked = True Then
                STRSQL = "SELECT RIGHT(DATE,2)+'-'+LEFT(RIGHT(DATE,4),2)+'-'+LEFT(DATE,4) AS date, [time] AS TIME,[ITEMNAME],BARCODE,PARTYNAME,VECHNO,ORDERNO,[ITEMCODE],USERNAME,TRNO FROM DISPATCH WHERE BARCODE  IS  NOT NULL"
            ElseIf RBCON.Checked = True Then
                STRSQL = "SELECT RIGHT(DATE,2)+'-'+LEFT(RIGHT(DATE,4),2)+'-'+LEFT(DATE,4) AS date,[ITEMNAME],PARTYNAME,VECHNO,ORDERNO,[ITEMCODE],USERNAME,TRNO,COUNT([BARCODE]) AS BARCODE FROM [DISPATCH] WHERE BARCODE  IS  NOT NULL "
            End If
            If Trim(DTFROM.Text) <> "" And Trim(DTTO.Text) <> "" Then
                STRSQL = STRSQL & " and DATE  between  " & " '" & Format(DTFROM.Value, "yyyyMMdd") & "' and '" & Format(DTTO.Value, "yyyyMMdd") & "'"
            End If
            If Trim(CMBINAME.Text) <> "" Then
                STRSQL = STRSQL & " AND LTRIM(RTRIM(ITEMNAME))='" & Trim(CMBINAME.Text) & "'"
            End If
            If Trim(CMBBARCODE.Text) <> "" Then
                STRSQL = STRSQL & " AND LTRIM(RTRIM(barcodeno)) ='" & Trim(CMBBARCODE.Text) & "'"
            End If
            If RBCON.Checked = True Then
                STRSQL = STRSQL & " GROUP BY DATE,[ITEMNAME],PARTYNAME,VECHNO,ORDERNO,[ITEMCODE],USERNAME,TRNO "
            End If
            Dim OBJCOMMAND As New SqlCommand(STRSQL, APPCON.CNN)
            Dim OBJREADER = OBJCOMMAND.ExecuteReader()
            While OBJREADER.Read()
                Grid2.Cell(I, 1).Text = Trim(CNULLS(OBJREADER("DATE")))
                If RBDET.Checked = True Then
                    Grid2.Cell(I, 2).Text = Trim(CNULLS(OBJREADER("TIME")))
                End If
                Grid2.Cell(I, 3).Text = Trim(CNULLS(OBJREADER("TRNO")))
                Grid2.Cell(I, 4).Text = Trim(CNULLS(OBJREADER("ORDERNO")))
                Grid2.Cell(I, 5).Text = Trim(CNULLS(OBJREADER("ITEMNAME")))
                Grid2.Cell(I, 6).Text = Trim(CNULLS(OBJREADER("ITEMCODE")))
                Grid2.Cell(I, 7).Text = Trim(CNULLS(OBJREADER("BARCODE")))
                Grid2.Cell(I, 8).Text = Trim(CNULLS(OBJREADER("VECHNO")))
                Grid2.Cell(I, 9).Text = Trim(CNULLS(OBJREADER("PARTYNAME")))
                Grid2.Cell(I, 10).Text = Trim(CNULLS(OBJREADER("USERNAME")))
                Grid2.AddItem("", True)
                I = I + 1
            End While
            OBJREADER.Close()
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "SEARCHRECORD")
        End Try
    End Sub
    Private Sub SEARCHPACK()
        Try
            Dim ObjDataSet As New DataSet
            Dim ObjDataAdap As SqlDataAdapter
            Dim STRSQL As String = ""
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            Grid2.Rows = 2
            For J As Integer = 0 To Grid2.Cols - 1
                Grid2.Cell(1, J).Text = ""
            Next
            Dim I As Int32 = 1
            If RBDET.Checked = True Then
                STRSQL = "SELECT RIGHT(DATE,2)+'-'+LEFT(RIGHT(DATE,4),2)+'-'+LEFT(DATE,4) AS date,[time],TRNO ,[ITEMNAME],[ITEMCODE],LINE,USERNAME,[BARCODE] FROM [PACKING] WHERE BARCODE  IS  NOT NULL "
            ElseIf RBCON.Checked = True Then
                STRSQL = "SELECT RIGHT(DATE,2)+'-'+LEFT(RIGHT(DATE,4),2)+'-'+LEFT(DATE,4) AS date,TRNO ,[ITEMNAME],[ITEMCODE],USERNAME,COUNT([BARCODE]) AS BARCODE FROM [PACKING] WHERE BARCODE  IS  NOT NULL "
            End If
            If Trim(DTFROM.Text) <> "" And Trim(DTTO.Text) <> "" Then
                STRSQL = STRSQL & " and DATE  between  " & " '" & Format(DTFROM.Value, "yyyyMMdd") & "' and '" & Format(DTTO.Value, "yyyyMMdd") & "'"
            End If
            If Trim(CMBINAME.Text) <> "" Then
                STRSQL = STRSQL & " AND LTRIM(RTRIM(ITEMNAME))='" & Trim(CMBINAME.Text) & "'"
            End If
            If Trim(CMBBARCODE.Text) <> "" Then
                STRSQL = STRSQL & " AND LTRIM(RTRIM(barcode)) ='" & Trim(CMBBARCODE.Text) & "'"
            End If
            If Trim(CMBICODE.Text) <> "" Then
                STRSQL = STRSQL & " AND LTRIM(RTRIM(ITEMCODE))='" & Trim(CMBICODE.Text) & "'"
            End If
            If Trim(CMBSRNO.Text) <> "" Then
                STRSQL = STRSQL & " AND LTRIM(RTRIM(TRNO))='" & Trim(CMBSRNO.Text) & "'"
            End If
            If Trim(CMBLINE.Text) <> "" Then
                STRSQL = STRSQL & " AND LTRIM(RTRIM(LINE))='" & Trim(CMBLINE.Text) & "'"
            End If
            If RBCON.Checked = True Then
                STRSQL = STRSQL & " GROUP BY TRNO, ITEMCODE,ITEMNAME,DATE,USERNAME "
            End If
            Dim OBJCOMMAND As New SqlCommand(STRSQL, APPCON.CNN)
            Dim OBJREADER = OBJCOMMAND.ExecuteReader()
            While OBJREADER.Read()
                Grid2.Cell(I, 1).Text = Trim(CNULLS(OBJREADER("DATE")))
                If RBDET.Checked = True Then
                    Grid2.Cell(I, 2).Text = Trim(CNULLS(OBJREADER("TIME")))
                    Grid2.Cell(I, 7).Text = Trim(CNULLS(OBJREADER("LINE")))
                End If
                Grid2.Cell(I, 3).Text = Trim(CNULLS(OBJREADER("TRNO")))
                Grid2.Cell(I, 4).Text = Trim(CNULLS(OBJREADER("ITEMNAME")))
                Grid2.Cell(I, 5).Text = Trim(CNULLS(OBJREADER("ITEMCODE")))
                Grid2.Cell(I, 6).Text = Trim(CNULLS(OBJREADER("BARCODE")))
                Grid2.Cell(I, 8).Text = Trim(CNULLS(OBJREADER("USERNAME")))
                Grid2.AddItem("", True)
                I = I + 1
            End While
            OBJREADER.Close()
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "SEARCHRECORD")
        End Try
    End Sub
    Private Sub FORMATGRID1()

        Dim QTY As Double = -1
        Try
            With Grid2
                Grid2.Cols = 9
                .Cell(0, 1).Text = "DATE"
                .Cell(0, 2).Text = "TIME"
                .Cell(0, 3).Text = "SHIPPER NO"
                .Cell(0, 4).Text = "ITEM NAME"
                .Cell(0, 5).Text = "ITEM CODE"
                .Cell(0, 6).Text = "BARCODE"
                .Cell(0, 7).Text = "LINE"
                .Cell(0, 8).Text = "USERNAME"

                .Column(1).Width = 80
                .Column(2).Width = 80
                .Column(3).Width = 100
                .Column(4).Width = 200
                .Column(5).Width = 100
                .Column(6).Width = 100
                .Column(7).Width = 90
                .Column(8).Width = 90
                If RBCON.Checked = True Then
                    .Column(2).Width = 0
                    .Column(7).Width = 0
                    .Cell(0, 6).Text = "QTY"
                End If
                Grid2.DisplayRowNumber = True
                .Column(1).Locked = True
                .Column(2).Locked = True
                .Column(3).Locked = True
                .Column(4).Locked = True
                .Column(5).Locked = True
                .Column(6).Locked = True
                .Column(7).Locked = True
                .Column(8).Locked = True

            End With
            With Grid2.Range(0, 1, 0, 8)
                .FontBold = True
                .ForeColor = Color.Blue
                .Alignment = FlexCell.AlignmentEnum.LeftGeneral
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "FORMAT GRID")
        End Try
    End Sub
    Private Sub FORMATORDER()

        Dim QTY As Double = -1
        Try
            With Grid2
                Grid2.Cols = 9
                .Cell(0, 1).Text = "DATE"
                .Cell(0, 2).Text = "TIME"
                .Cell(0, 3).Text = "ORDERNO"
                .Cell(0, 4).Text = "ITEM NAME"
                .Cell(0, 5).Text = "ITEM CODE"
                .Cell(0, 6).Text = "QTY"
                .Cell(0, 7).Text = "LINE"
                .Cell(0, 8).Text = "USERNAME"

                .Column(1).Width = 80
                .Column(2).Width = 80
                .Column(3).Width = 100
                .Column(4).Width = 200
                .Column(5).Width = 100
                .Column(6).Width = 100
                .Column(7).Width = 0
                .Column(8).Width = 90


                Grid2.DisplayRowNumber = True
                .Column(1).Locked = True
                .Column(2).Locked = True
                .Column(3).Locked = True
                .Column(4).Locked = True
                .Column(5).Locked = True
                .Column(6).Locked = True
                .Column(7).Locked = True
                .Column(8).Locked = True

            End With
            With Grid2.Range(0, 1, 0, 8)
                .FontBold = True
                .ForeColor = Color.Blue
                .Alignment = FlexCell.AlignmentEnum.LeftGeneral
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "FORMAT GRID")
        End Try
    End Sub
    Private Sub FORMATPALLET()

        Dim QTY As Double = -1
        Try
            With Grid2
                Grid2.Cols = 9
                .Cell(0, 1).Text = "DATE"
                .Cell(0, 2).Text = "TIME"
                .Cell(0, 3).Text = "PALLET NO"
                .Cell(0, 4).Text = "ITEM NAME"
                .Cell(0, 5).Text = "ITEM CODE"
                .Cell(0, 6).Text = "BARCODE"
                .Cell(0, 7).Text = "LINE"
                .Cell(0, 8).Text = "USERNAME"

                .Column(1).Width = 80
                .Column(2).Width = 80
                .Column(3).Width = 100
                .Column(4).Width = 200
                .Column(5).Width = 100
                .Column(6).Width = 100
                .Column(7).Width = 0
                .Column(8).Width = 90
                If RBCON.Checked = True Then
                    .Column(2).Width = 0
                    .Cell(0, 6).Text = "QTY"
                End If
                Grid2.DisplayRowNumber = True
                .Column(1).Locked = True
                .Column(2).Locked = True
                .Column(3).Locked = True
                .Column(4).Locked = True
                .Column(5).Locked = True
                .Column(6).Locked = True
                .Column(7).Locked = True
                .Column(8).Locked = True

            End With
            With Grid2.Range(0, 1, 0, 8)
                .FontBold = True
                .ForeColor = Color.Blue
                .Alignment = FlexCell.AlignmentEnum.LeftGeneral
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "FORMAT GRID")
        End Try
    End Sub
    Private Sub FORMATINSPECTION()
        'Dim QTY As Double = -1
        Try
            With Grid2
                .Cols = 9
                .Cell(0, 1).Text = "DATE"
                .Cell(0, 2).Text = "TIME"
                .Cell(0, 3).Text = "INSPECTION NO"
                .Cell(0, 4).Text = "CARTON NO"
                .Cell(0, 5).Text = "ITEM NAME"
                .Cell(0, 6).Text = "ITEM CODE"
                .Cell(0, 7).Text = "BARCODE"
                .Cell(0, 8).Text = "USER NAME"
                .Column(1).Width = 100
                .Column(2).Width = 100
                .Column(3).Width = 100
                .Column(4).Width = 150
                .Column(5).Width = 100
                .Column(6).Width = 80
                .Column(7).Width = 150
                .Column(8).Width = 80

                Grid2.AutoRedraw = True
                Grid2.DisplayRowNumber = True

                .Column(1).Locked = True
                .Column(2).Locked = True
                .Column(3).Locked = True
                .Column(4).Locked = True
                .Column(5).Locked = True
                .Column(6).Locked = True
                .Column(7).Locked = True
                .Column(8).Locked = True

            End With
            With Grid2.Range(0, 1, 0, 8)
                .FontBold = True
                .ForeColor = Color.Blue
                .Alignment = FlexCell.AlignmentEnum.LeftGeneral
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "FORMAT GRID")
        End Try
    End Sub
    Private Sub FORMATGRID()
        'Dim QTY As Double = -1
        Try
            With Grid2
                .Cols = 9
                .Cell(0, 1).Text = "Date"
                .Cell(0, 2).Text = "Time"
                .Cell(0, 3).Text = "Item Name"
                .Cell(0, 4).Text = "Item Code"
                .Cell(0, 5).Text = "Qrcode"
                .Cell(0, 6).Text = "Type"
                .Cell(0, 7).Text = "Line"
                .Cell(0, 8).Text = "User Name"
                .Column(1).Width = 100
                .Column(2).Width = 100
                .Column(3).Width = 250
                .Column(4).Width = 150
                .Column(5).Width = 100
                .Column(6).Width = 80
                .Column(7).Width = 80
                .Column(8).Width = 80

                Grid2.AutoRedraw = True
                Grid2.DisplayRowNumber = True

                .Column(1).Locked = True
                .Column(2).Locked = True
                .Column(3).Locked = True
                .Column(4).Locked = True
                .Column(5).Locked = True
                .Column(6).Locked = True
                .Column(7).Locked = True
                .Column(8).Locked = True

            End With
            With Grid2.Range(0, 1, 0, 8)
                .FontBold = True
                .ForeColor = Color.Black
                .Alignment = FlexCell.AlignmentEnum.LeftGeneral
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "FORMAT GRID")
        End Try
    End Sub
    Private Sub FORMATDISPATCH()
        'Dim QTY As Double = -1
        Try
            With Grid2
                .Cols = 11
                .Cell(0, 1).Text = "DATE"
                .Cell(0, 2).Text = "TIME"
                .Cell(0, 3).Text = "DISPATCH NO"
                .Cell(0, 4).Text = "ORDER NO"
                .Cell(0, 5).Text = "ITEM NAME"
                .Cell(0, 6).Text = "ITEM CODE"
                .Cell(0, 7).Text = "BARCODE"
                .Cell(0, 8).Text = "PARTY NAME"
                .Cell(0, 9).Text = "VECHILE NO"
                .Cell(0, 10).Text = "USER NAME"
                .Column(1).Width = 70
                .Column(2).Width = 70
                .Column(3).Width = 100
                .Column(4).Width = 100
                .Column(5).Width = 200
                .Column(6).Width = 150
                .Column(7).Width = 130
                .Column(8).Width = 80
                .Column(9).Width = 80
                .Column(10).Width = 80

                If RBCON.Checked = True Then
                    .Column(2).Width = 0
                    .Cell(0, 7).Text = "QTY"
                End If
                Grid2.AutoRedraw = True
                Grid2.DisplayRowNumber = True
                .Column(1).Locked = True
                .Column(2).Locked = True
                .Column(3).Locked = True
                .Column(4).Locked = True
                .Column(5).Locked = True
                .Column(6).Locked = True
                .Column(7).Locked = True
                .Column(8).Locked = True
                .Column(9).Locked = True
                .Column(10).Locked = True

            End With
            With Grid2.Range(0, 1, 0, 10)
                .FontBold = True
                .ForeColor = Color.Blue
                .Alignment = FlexCell.AlignmentEnum.LeftGeneral
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "FORMAT GRID")
        End Try
    End Sub
    Private Sub DAILY_REPORT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            APPCON.connection()
            APPCON1.connection()
            newcon.connection()
            Call FORMATGRID()
            RBCON.Checked = True
        Catch ex As Exception

        End Try
    End Sub
    Private Sub BTNEXCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEXCEL.Click
        Try
            Dim katu As String = ""
            Grid2.ExportToExcel(katu, True)
            MsgBox("Export to excel Complete")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub FORMATWH1()

        Dim QTY As Double = -1
        Try
            With Grid2
                Grid2.Cols = 9
                .Cell(0, 1).Text = "DATE"
                .Cell(0, 2).Text = "TIME"
                .Cell(0, 3).Text = "ORDER NO"
                .Cell(0, 4).Text = "ITEM NAME"
                .Cell(0, 5).Text = "ITEM CODE"
                .Cell(0, 6).Text = "BARCODE"
                .Cell(0, 7).Text = "LINE"
                .Cell(0, 8).Text = "USERNAME"

                .Column(1).Width = 80
                .Column(2).Width = 80
                .Column(3).Width = 100
                .Column(4).Width = 200
                .Column(5).Width = 100
                .Column(6).Width = 100
                .Column(7).Width = 0
                .Column(8).Width = 90
                If RBCON.Checked = True Then
                    .Column(2).Width = 0
                    .Cell(0, 6).Text = "QTY"
                End If
                Grid2.DisplayRowNumber = True
                .Column(1).Locked = True
                .Column(2).Locked = True
                .Column(3).Locked = True
                .Column(4).Locked = True
                .Column(5).Locked = True
                .Column(6).Locked = True
                .Column(7).Locked = True
                .Column(8).Locked = True

            End With
            With Grid2.Range(0, 1, 0, 8)
                .FontBold = True
                .ForeColor = Color.Blue
                .Alignment = FlexCell.AlignmentEnum.LeftGeneral
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "FORMAT GRID")
        End Try
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Try
            If CMBRTYPE.Text <> "" Then

                Grid2.Rows = 2
                For J As Integer = 0 To Grid2.Cols - 1
                    Grid2.Cell(0, J).Text = ""
                Next
                If CMBRTYPE.Text = "Master Shipper" Then
                    Call FORMATGRID1()
                    Call SEARCHPACK()
                ElseIf CMBRTYPE.Text = "Product Generation" Then
                    Call FORMATGRID()
                    Call SEARCHSCANNED()
                ElseIf CMBRTYPE.Text = "Master Pallet" Then
                    Call FORMATPALLET()
                    Call SEARCHPALLET()
                ElseIf CMBRTYPE.Text = "Order Logged" Then
                    Call FORMATORDER()
                    Call SEARCHORDER()
                ElseIf CMBRTYPE.Text = "Dispatch" Then
                    Call FORMATDISPATCH()
                    Call SEARCHDISPATCH()
                ElseIf CMBRTYPE.Text = "Inspection" Then
                    Call FORMATINSPECTION()
                    Call SEARCHINSPECTION()
                ElseIf CMBRTYPE.Text = "Stock Transfer" Then
                    Call FORMATWH1()
                    Call WH1()
                End If
            Else
                MsgBox("Must Choose Report Type")
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub CMBRTYPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBRTYPE.SelectedIndexChanged
        Try
            If CMBRTYPE.Text = "Master Shipper" Then
                Label8.Text = "Shipper No"
            ElseIf CMBRTYPE.Text = "Product Generation" Then
                Label8.Text = "Qrcode No"
            ElseIf CMBRTYPE.Text = "Master Pallet" Then
                Label8.Text = "Pallet No"
            ElseIf CMBRTYPE.Text = "Order Logged" Then
                Label8.Text = "Order No"
            ElseIf CMBRTYPE.Text = "Dispatch" Then
                Label8.Text = "Dispatch No"
            ElseIf CMBRTYPE.Text = "Inspection" Then
                Label8.Text = "Inspection No"
            ElseIf CMBRTYPE.Text = "Stock Transfer" Then
                Label8.Text = "Pallet No"
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
    Public Sub GENREPORT(ByVal A As String)
        Try
            Dim TMPQRY As String = ""
            Dim strpram As String = ""
            Dim strFormula As String = ""
            Dim party1 As String = ""
            Dim I As Integer = 0
            'Call GetTnC()
            strpram = ("compname" & "&" & Main.PmCompanyName)
            strpram = strpram & "\" & ("formname" & "&" & "CHALLAN")
            strpram = strpram & "\" & ("ADD1" & "&" & Main.ADD1)
            strpram = strpram & "\" & ("ADD2" & "&" & Main.ADD2)
            strpram = strpram & "\" & ("PH1" & "&" & Main.PH1)
            strpram = strpram & "\" & ("PH2" & "&" & Main.PH2)
            strpram = strpram & "\" & ("TINNO" & "&" & Main.TINNO)
            strpram = strpram & "\" & ("SERVICENO" & "&" & "")
            strpram = strpram & "\" & ("PANNO" & "&" & Main.EX5)
            strpram = strpram & "\" & ("EX1" & "&" & Main.EX1)
            strpram = strpram & "\" & ("vat1" & "&" & Main.GVATCAP2)
            strpram = strpram & "\" & ("vat2" & "&" & Main.GVATCAP3)

            strpram = strpram & "\" & ("TNC1" & "&" & Main.TNC1)
            strpram = strpram & "\" & ("TNC2" & "&" & Main.TNC2)
            strpram = strpram & "\" & ("TNC3" & "&" & Main.TNC3)
            strpram = strpram & "\" & ("TNC4" & "&" & Main.TNC4)
            strpram = strpram & "\" & ("TNC5" & "&" & Main.TNC5)
            strpram = strpram & "\" & ("TNC6" & "&" & Main.TNC6)
            'strpram = strpram & "\" & ("TNC7" & "&" & Main.TNC7) 
            If CMBRTYPE.Text = "Dispatch" Then
                Call ViewReportDSN("rptCHALLAN.rpt", "{DISPATCH.Trno}='" & Trim(A) & "'", strpram, strFormula, PrintOpt, NOCOP)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "GENREPORT")
        End Try
    End Sub
    Private Sub Grid2_DoubleClick(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles Grid2.DoubleClick
        If CMBRTYPE.Text = "Dispatch" Then
            If Grid2.Cell(Grid2.ActiveCell.Row, 3).Text <> "" Then
                NOCOP = 1
                PrintOpt = "S"
                Call GENREPORT(Grid2.Cell(Grid2.ActiveCell.Row, 3).Text)
            End If
        End If
    End Sub
End Class