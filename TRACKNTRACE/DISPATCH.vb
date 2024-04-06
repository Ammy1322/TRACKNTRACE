Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Public Class DISPATCH
    Dim SRNOBARCODE As String
    Dim OBJSQLCOMMAND As SqlCommand
    Dim OBJSQLCOMMANDNEW As SqlCommand
    Dim OBJSQLCOMMANDNEWGETDESC As SqlCommand
    Dim OBJDATAREADERNEW As SqlDataReader
    Dim OBJDATAREADERGETDESC As SqlDataReader
    Dim OBJDATAREADER1 As SqlDataReader
    Dim OBJDATAREADER2 As SqlDataReader
    Dim StrSql As String = ""
    Dim StrSql1 As String = ""
    Dim TRANS As SqlTransaction
    Public FRMTYPE As String
    Dim APPCON As New CNNCLASS
    Dim APPCON1 As New CNNCLASS
    Dim TRANTYPE As String = ""
    Dim SAVETYPE As String = ""
    Dim Iyear As Integer = DateTime.Now.Year.ToString()
    Dim MNTH As String = DateTime.Now.Month.ToString()
    Dim BARCODENO As String = ""
    Dim BILLFIRSTWORD As String = ""
    Dim BILLNO As String = ""
    Dim BILLNO1 As String = ""
    Dim TNAME As String = ""
    Dim TNAMESUB As String = ""
    Dim GNO As Integer = 0
    Dim STRSQLGETDESC As String = ""
    Dim OBJSQLCOMMANDGETDESC As SqlCommand
    Dim OBJDATAREADER As SqlDataReader
    Dim L As String = ""
    Dim SHOWTIME As String = ""
    Dim ENDTIME As String = ""
    Private Sub TXTBARCODE_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXTBARCODE.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                L = TXTBARCODE.Text
                If CMBQTY.Text = "" Then
                    MsgBox("MUST ENTER QTY")
                    Exit Sub
                End If
                If CMBORDERNO.Text = "" Then
                    MsgBox("MUST ENTER ITEM NAME")
                    Exit Sub
                End If
                If CMBVECHNO.Text = "" Then
                    MsgBox("MUST ENTER VECHILE NO")
                    Exit Sub
                End If
                If CMBPARTYNAME.Text = "" Then
                    MsgBox("MUST ENTER PARTY NAME")
                    Exit Sub
                End If

                For i As Integer = 1 To Grid1.Rows - 1
                    If Trim(Grid1.Cell(i, 1).Text) <> "" Then
                        If LCase(Trim(Grid1.Cell(i, 3).Text)) = LCase(Trim(L)) And UCase(Trim(Grid1.Cell(i, 3).Text)) = UCase(Trim(L)) Then
                            MsgBox("BARCODE EXIST")
                            TXTBARCODE.Text = ""
                            Exit Sub
                        End If
                    End If
                Next
                If Val(CMBQTY.Text) > Val(TXTCOUNTER.Text) Then
                    Call GRIDDATABIND()
                Else
                    MsgBox("NOT SCAN MORE THAN QTY")
                    TXTBARCODE.Text = ""
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GRIDDATABIND()
        Try
            L = TXTBARCODE.Text
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            Dim STRSQL As String
            STRSQL = "SELECT * FROM PALLET WHERE ITEMCODE ='" & Trim(CMBVECHNO.Text) & "' and TRNO='" & Trim(L) & "'AND TRNO NOT IN (SELECT BARCODE FROM DISPATCH WHERE ITEMCODE ='" & Trim(CMBVECHNO.Text) & "' and barcode='" & Trim(L) & "')"
            Dim OBJCOMMAND As New SqlCommand(STRSQL, APPCON.CNN)
            Dim OBJREADER = OBJCOMMAND.ExecuteReader()
            If OBJREADER.Read() Then
                Grid1.AddItem("", True)
                Dim I As Integer = Grid1.Rows - 2
                Grid1.Cell(I, 3).Text = Trim(OBJREADER("BARCODE"))
                Grid1.Cell(I, 2).Text = Trim(OBJREADER("itemname"))
                Grid1.Cell(I, 1).Text = Trim(OBJREADER("ITEMCODE"))
                TXTCOUNTER.Text = Val(Trim(TXTCOUNTER.Text)) + 1
            Else
                MsgBox("NOT COMPLETE PALLET or Already DISPATCHED")
                TXTBARCODE.Text = ""
            End If
            TXTBARCODE.Text = ""
            OBJREADER.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub INSERTDATA()
        Try
            Dim SRNOO As Double = 0
            Dim curdate As Date = Now.Today
            Dim curtime1 As String = Convert.ToString(Now.TimeOfDay)
            Dim curtime2 As Date = curtime1
            Dim PKGID As Double = 0
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            OBJSQLCOMMAND = New SqlCommand("SELECT MAX(ID) as PKGID FROM DISPATCH ", APPCON.CNN)
            OBJDATAREADERGETDESC = OBJSQLCOMMAND.ExecuteReader()
            If OBJDATAREADERGETDESC.Read() Then
                PKGID = CNULL(OBJDATAREADERGETDESC("PKGID")) + 1
            End If
            OBJDATAREADERGETDESC.Close()

            Dim I1 As Double
            For I1 = 1 To Grid1.Rows - 1
                If Trim(Grid1.Cell(I1, 1).Text) <> "" Then
                    StrSql = StrSql & "INSERT INTO [DISPATCH]([ITEMNAME],[ITEMCODE],[BARCODE],[date],[time],USERNAME,PARTYNAME,VECHNO,ID,FINYEAR,[TRNO])" _
                             & " values (" _
                             & " '" & Trim(Grid1.Cell(I1, 2).Text) & "'," _
                             & " '" & Trim(Grid1.Cell(I1, 1).Text) & "'," _
                             & " '" & Trim(Grid1.Cell(I1, 3).Text) & "'," _
                             & " '" & Format(TXTDATE.Value, "yyyyMMdd") & "', " _
                             & " '" & Convert.ToString(Format(curtime2, "hmmsstt")) & "', " _
                             & " '" & Trim(SysTemUserName) & "'," _
                             & " '" & Trim(CMBPARTYNAME.Text) & "' ," _
                             & " '" & Trim(CMBVECHNO.Text) & "' ," _
                            & " '" & Trim(PKGID) & "'," _
                             & " '" & Trim(pmFinYear) & "'," _
                             & " '" & Trim(BILLNO) & "')"
                    TXTCOUNTER.Text += 1
                End If
            Next I1

            If APPCON1.CNN.State = ConnectionState.Open Then APPCON1.CNN.Close()
            APPCON1.CNN.Open()
            OBJSQLCOMMAND = New SqlCommand(StrSql, APPCON.CNN)
            OBJSQLCOMMAND.ExecuteNonQuery()
            OBJSQLCOMMAND.Dispose()

            TXTCOUNTER.Text = 0
            ' TXTSRNO.Text = "MZXHNQR4022IN31" & "" & BILLNO
            Grid1.Rows = 2
            MsgBox("SAVED")
        Catch ex As Exception

        End Try
    End Sub
    Public Sub FORMATGRID()
        'mgbox.Text = "Alt+D For DELETE      Alt+N For NEW      PAGEUP FOR NEXT      PAGEDOWN FOR PREVIOUS"
        Grid1.Rows = 2
        Grid1.Cols = 4
        Grid1.Cell(0, 1).Text = "PRODUCT CODE"
        Grid1.Column(1).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid1.Column(1).Width = 70
        Grid1.Cell(0, 2).Text = "PRODUCT NAME"
        Grid1.Column(2).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid1.Column(2).Width = 200
        Grid1.Cell(0, 3).Text = "BARCODE"
        Grid1.Column(3).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid1.Column(3).Width = 100
        Grid1.Locked = True
    End Sub
    Private Sub CLEARTEXT()
        CMBPARTYNAME.Text = ""
        CMBVECHNO.Text = ""
        Grid1.Rows = 2
        CMBQTY.Text = ""
        For i As Integer = 1 To Grid1.Cols - 1
            Grid1.Cell(1, i).Text = ""
        Next i
    End Sub
    Private Sub DISPATCH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            APPCON.connection()
            APPCON1.connection()
            CLEARTEXT()
            FORMATGRID()
            BINDGRID()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            Dim SRNOO As String = ""
            If Val(CMBQTY.Text) = Val(TXTCOUNTER.Text) Then
                If CMBQTY.Text = "" Then
                    MsgBox("MUST ENTER QTY")
                    Exit Sub
                End If
                If CMBORDERNO.Text = "" Then
                    MsgBox("MUST ENTER ITEM NAME")
                    Exit Sub
                End If
                If CMBVECHNO.Text = "" Then
                    MsgBox("MUST ENTER VECHILE NO")
                    Exit Sub
                End If
                If CMBPARTYNAME.Text = "" Then
                    MsgBox("MUST ENTER PARTY NAME")
                    Exit Sub
                End If
                BILLFIRSTWORD = GENFUNCTION.GETFIRSTWORDCAPTION("DISPATCH", PmStoreDESC, pmFinYear)
                BILLNO = GENFUNCTION.AutoCodeGen("DISPATCH", "TRNO", BILLFIRSTWORD, "", "10", "")
                TextBox1.Text = BILLNO
                Call INSERTDATA()
                Grid1.Rows = 2
                For i As Integer = 1 To Grid1.Cols - 1
                    Grid1.Cell(1, i).Text = ""
                Next i
                TXTBARCODE.Text = ""
            Else
                MsgBox("NOT SCAN MORE OR LESS THAN QTY")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BINDGRID()
        Try
            CMBORDERNO.Items.Clear()
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            StrSql = "Select ORDERNO AS A FROM orderfeed"
            OBJSQLCOMMANDGETDESC = New SqlCommand(STRSQL, APPCON.CNN)
            OBJDATAREADERGETDESC = OBJSQLCOMMANDGETDESC.ExecuteReader
            While OBJDATAREADERGETDESC.Read
                CMBORDERNO.Items.Add(Trim(CNULLS(OBJDATAREADERGETDESC!A)))
            End While
            OBJDATAREADERGETDESC.Close()
        Catch ex As Exception
            MsgBox("BINDGRID")
        End Try
    End Sub
    Private Sub CMBINAME_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBORDERNO.SelectedIndexChanged
        Try
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            StrSql = "SELECT SUM(CAST( QTY AS INT))AS QTY , [PARTYNAME] AS PARTY FROM  [ORDERFEED] where ORDERNO ='" & CMBORDERNO.Text & "' GROUP BY PARTYNAME"
            If APPCON1.CNN.State = ConnectionState.Open Then APPCON1.CNN.Close()
            APPCON1.CNN.Open()
            OBJSQLCOMMAND = New SqlCommand(StrSql, APPCON1.CNN)
            OBJDATAREADER1 = OBJSQLCOMMAND.ExecuteReader()
            If OBJDATAREADER1.Read Then
                CMBQTY.Text = Trim(CNULLS(OBJDATAREADER1("QTY")))
                CMBPARTYNAME.Text = Trim(CNULLS(OBJDATAREADER1("PARTY")))
            End If
            OBJDATAREADER1.Close()
            OBJSQLCOMMAND.Dispose()
        Catch ex As Exception
            MsgBox("BINDGRID")
        End Try
    End Sub
End Class