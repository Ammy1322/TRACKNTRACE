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
    Private Sub BTNSEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSEARCH.Click
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
    Private Sub SEARCHPALLET()
        Try
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            Grid2.Rows = 2
            For J As Integer = 0 To Grid2.Cols - 1
                Grid2.Cell(1, J).Text = ""
            Next
            Dim I As Int32 = 1
            STRSQL = "SELECT RIGHT(DATE,2)+'-'+LEFT(RIGHT(DATE,4),2)+'-'+LEFT(DATE,4) AS date, [time] AS TIME,trno,[ITEMNAME],[ITEMCODE],[BARCODE],USERNAME FROM [PALLET] WHERE BARCODE  IS  NOT NULL "
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
            STRSQL = "SELECT RIGHT(DATE,2)+'-'+LEFT(RIGHT(DATE,4),2)+'-'+LEFT(DATE,4) AS date, [time] AS TIME,[ITEMNAME],[ITEMCODE],[BARCODE],TYPE,LINE,USERNAME FROM [SCANNED] WHERE BARCODE  IS  NOT NULL "
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
            STRSQL = "SELECT RIGHT(DATE,2)+'-'+LEFT(RIGHT(DATE,4),2)+'-'+LEFT(DATE,4) AS date, [time] AS TIME,[ITEMNAME],BARCODE,PARTYNAME,VECHNO,ORDERNO,[ITEMCODE],USERNAME,TRNO FROM DISPATCH WHERE BARCODE  IS  NOT NULL"
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
            STRSQL = "SELECT RIGHT(DATE,2)+'-'+LEFT(RIGHT(DATE,4),2)+'-'+LEFT(DATE,4) AS date,[time],TRNO ,[ITEMNAME],[ITEMCODE],LINE,USERNAME,[BARCODE] FROM [PACKING] WHERE BARCODE  IS  NOT NULL "
            If Trim(DTFROM.Text) <> "" And Trim(DTTO.Text) <> "" Then
                STRSQL = STRSQL & " and DATE  between  " & " '" & Format(DTFROM.Value, "yyyyMMdd") & "' and '" & Format(DTTO.Value, "yyyyMMdd") & "'"
            End If
            If Trim(CMBINAME.Text) <> "" Then
                STRSQL = STRSQL & " AND LTRIM(RTRIM(ITEMNAME))='" & Trim(CMBINAME.Text) & "'"
            End If
            If Trim(CMBBARCODE.Text) <> "" Then
                STRSQL = STRSQL & " AND LTRIM(RTRIM(barcode)) ='" & Trim(CMBBARCODE.Text) & "'"
            End If
            Dim OBJCOMMAND As New SqlCommand(STRSQL, APPCON.CNN)
            Dim OBJREADER = OBJCOMMAND.ExecuteReader()
            While OBJREADER.Read()
                Grid2.Cell(I, 1).Text = Trim(CNULLS(OBJREADER("DATE")))
                Grid2.Cell(I, 2).Text = Trim(CNULLS(OBJREADER("TIME")))
                Grid2.Cell(I, 3).Text = Trim(CNULLS(OBJREADER("TRNO")))
                Grid2.Cell(I, 4).Text = Trim(CNULLS(OBJREADER("ITEMNAME")))
                Grid2.Cell(I, 5).Text = Trim(CNULLS(OBJREADER("ITEMCODE")))
                Grid2.Cell(I, 6).Text = Trim(CNULLS(OBJREADER("BARCODE")))
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
    Private Sub FORMATGRID1()

        Dim QTY As Double = -1
        Try
            With Grid2
                Grid2.Cols = 9
                .Cell(0, 1).Text = "DATE"
                .Cell(0, 2).Text = "TIME"
                .Cell(0, 3).Text = "TRNO"
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
                .Cell(0, 3).Text = "TRNO"
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
                .Cell(0, 3).Text = "TRNO"
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
                .Cell(0, 3).Text = "TR NO"
                .Cell(0, 4).Text = "CARTON NO"
                .Cell(0, 5).Text = "ITEM NAME"
                .Cell(0, 6).Text = "ITEM CODE"
                .Cell(0, 7).Text = "BARCODE"
                .Cell(0, 8).Text = "USER NAME"
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
                .Cell(0, 1).Text = "DATE"
                .Cell(0, 2).Text = "TIME"
                .Cell(0, 3).Text = "ITEM NAME"
                .Cell(0, 4).Text = "ITEM CODE"
                .Cell(0, 5).Text = "BARCODE"
                .Cell(0, 6).Text = "TYPE"
                .Cell(0, 7).Text = "LINE"
                .Cell(0, 8).Text = "USER NAME"
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
                .ForeColor = Color.Blue
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
                .Cell(0, 3).Text = "TRNO"
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
                .Column(7).Width = 80
                .Column(8).Width = 80
                .Column(9).Width = 80
                .Column(10).Width = 80

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
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim katu As String = ""
            Grid2.ExportToExcel(katu, True)
            MsgBox("Export to excel Complete")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Grid2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid2.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class