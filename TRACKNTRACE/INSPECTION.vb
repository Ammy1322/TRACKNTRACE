Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Public Class INSPECTION
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
    Private Sub INSPECTION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            APPCON.connection()
            APPCON1.connection()
            '    BINDGRID()
            CLEARTEXT()
            FORMATGRID()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub FORMATGRID()
        'mgbox.Text = "Alt+D For DELETE      Alt+N For NEW      PAGEUP FOR NEXT      PAGEDOWN FOR PREVIOUS"
        Dim QTY As Double = -1
        Try
            With Grid2
                Grid2.Cols = 7
                .Cell(0, 1).Text = "Date"
                .Cell(0, 2).Text = "Trno"
                .Cell(0, 3).Text = "Item Name"
                .Cell(0, 4).Text = "Item Code"
                .Cell(0, 5).Text = "Qrcode"
                .Cell(0, 6).Text = "Inspection"
                .Column(1).Width = 80
                .Column(2).Width = 100
                .Column(3).Width = 200
                .Column(4).Width = 100
                .Column(5).Width = 100
                .Column(6).CellType = FlexCell.CellTypeEnum.CheckBox
                Grid2.DisplayRowNumber = True
                .Column(1).Locked = True
                .Column(2).Locked = True
                .Column(3).Locked = True
                .Column(4).Locked = True
                .Column(5).Locked = True
            End With
            With Grid2.Range(0, 1, 0, 6)
                .FontBold = True
                .ForeColor = Color.Black
                .Alignment = FlexCell.AlignmentEnum.LeftGeneral
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "FORMAT GRID")
        End Try
    End Sub
    Private Sub BINDGRID()
        'Try
        '    CMBINAME.Items.Clear()
        '    If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
        '    APPCON.CNN.Open()
        '    STRSQL = "Select ITEMNAME AS A FROM PRODUCTMASTER WHERE ACTIVE ='YES'"
        '    OBJSQLCOMMANDGETDESC = New SqlCommand(STRSQL, APPCON.CNN)
        '    OBJDATAREADERGETDESC = OBJSQLCOMMANDGETDESC.ExecuteReader
        '    While OBJDATAREADERGETDESC.Read
        '        CMBINAME.Items.Add(Trim(CNULLS(OBJDATAREADERGETDESC!A)))
        '    End While
        '    OBJDATAREADERGETDESC.Close()
        'Catch ex As Exception
        '    MsgBox("BINDGRID")
        'End Try
    End Sub
    Private Sub CLEARTEXT()
        Grid2.Rows = 2
        For i As Integer = 1 To Grid2.Cols - 1
            Grid2.Cell(1, i).Text = ""
        Next i
    End Sub

    Private Sub TXTBARCODE_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXTBARCODE.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If TXTBARCODE.Text <> "" Then
                    L = TXTBARCODE.Text
                    For i As Integer = 1 To Grid2.Rows - 1
                        If Trim(Grid2.Cell(i, 5).Text) <> "" Then
                            If LCase(Trim(Grid2.Cell(i, 5).Text)) = LCase(Trim(L)) And UCase(Trim(Grid2.Cell(i, 5).Text)) = UCase(Trim(L)) Then
                                MsgBox("ALREDY SELECTED")
                                TXTBARCODE.Text = ""
                                Exit Sub
                            End If
                        End If
                    Next
                    Call GRIDDATABIND()
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
            STRSQL = "SELECT * FROM PACKING WHERE barcode='" & Trim(L) & "' AND BARCODE NOT IN (SELECT BARCODE FROM INSPECTION WHERE BARCODE ='" & Trim(L) & "')"
            Dim OBJCOMMAND As New SqlCommand(STRSQL, APPCON.CNN)
            Dim OBJREADER = OBJCOMMAND.ExecuteReader()
            If OBJREADER.Read() Then
                Grid2.AddItem("", True)
                Dim I As Integer = Grid2.Rows - 2
                Grid2.Cell(I, 1).Text = Trim(CNULLS(OBJREADER("DATE")))
                Grid2.Cell(I, 2).Text = Trim(CNULLS(OBJREADER("TRNO")))
                Grid2.Cell(I, 3).Text = Trim(CNULLS(OBJREADER("ITEMNAME")))
                Grid2.Cell(I, 4).Text = Trim(CNULLS(OBJREADER("ITEMCODE")))
                Grid2.Cell(I, 5).Text = Trim(CNULLS(OBJREADER("BARCODE")))
                TXTCOUNTER.Text = Val(Trim(TXTCOUNTER.Text)) + 1
            Else
                MsgBox("Not Scanned or Already Packed")
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
            Dim I1 As Double
            For I1 = 1 To Grid2.Rows - 1
                If Trim(Grid2.Cell(I1, 5).Text) <> "" Then
                    If Trim(Grid2.Cell(I1, 6).Text) = "1" Then
                        StrSql = StrSql & "EXEC [PR_INSPECTION] @BARCODE ='" & Trim(Grid2.Cell(I1, 5).Text) & "',@DATE='" & Format(TXTDATE.Value, "yyyyMMdd") & "',@TIME='" & Convert.ToString(Format(curtime2, "hmmsstt")) & "'"
                        TXTCOUNTER.Text += 1
                    End If
                End If
            Next I1
            If APPCON1.CNN.State = ConnectionState.Open Then APPCON1.CNN.Close()
            APPCON1.CNN.Open()
            OBJSQLCOMMAND = New SqlCommand(StrSql, APPCON.CNN)
            OBJSQLCOMMAND.ExecuteNonQuery()
            OBJSQLCOMMAND.Dispose()
            TXTCOUNTER.Text = 0
            Grid2.Rows = 2

            MsgBox("SAVED")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTNNEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNEW.Click
        Try
            CLEARTEXT()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Try
            BILLFIRSTWORD = GENFUNCTION.GETFIRSTWORDCAPTION("INSPECTION", PmStoreDESC, pmFinYear)
            BILLNO = GENFUNCTION.AutoCodeGen("INSPECTION", "TRNO", BILLFIRSTWORD, "", "10", "")
            TextBox1.Text = BILLNO
            Call INSERTDATA()
            Grid2.Rows = 2
            For i As Integer = 1 To Grid2.Cols - 1
                Grid2.Cell(1, i).Text = ""
            Next i
            TXTBARCODE.Text = ""
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class