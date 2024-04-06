Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Public Class PACKING
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
    Private Sub PACKING_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            APPCON.connection()
            APPCON1.connection()
            BINDGRID()
            CLEARTEXT()
            FORMATGRID()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub FORMATGRID()
        'mgbox.Text = "Alt+D For DELETE      Alt+N For NEW      PAGEUP FOR NEXT      PAGEDOWN FOR PREVIOUS"
        Grid1.Rows = 2
        Grid1.Cols = 4
        Grid1.Cell(0, 1).Text = "Product Code"
        Grid1.Column(1).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid1.Column(1).Width = 150
        Grid1.Cell(0, 2).Text = "Product Nme"
        Grid1.Column(2).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid1.Column(2).Width = 200
        Grid1.Cell(0, 3).Text = "Barcode"
        Grid1.Column(3).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid1.Column(3).Width = 200
        Grid1.Locked = True
    End Sub
    Private Sub CLEARTEXT()
        CMBINAME.Text = ""
        MCODE.Text = ""
        Grid1.Rows = 2
        For i As Integer = 1 To Grid1.Cols - 1
            Grid1.Cell(1, i).Text = ""
        Next i
    End Sub
    Private Sub BINDGRID()
        Try
            CMBINAME.Items.Clear()
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            STRSQL = "Select ITEMNAME AS A FROM PRODUCTMASTER WHERE ACTIVE ='YES'"
            OBJSQLCOMMANDGETDESC = New SqlCommand(STRSQL, APPCON.CNN)
            OBJDATAREADERGETDESC = OBJSQLCOMMANDGETDESC.ExecuteReader
            While OBJDATAREADERGETDESC.Read
                CMBINAME.Items.Add(Trim(CNULLS(OBJDATAREADERGETDESC!A)))
            End While
            OBJDATAREADERGETDESC.Close()
            CMBLINE.Items.Clear()

            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            StrSql = "Select MCOLORCODE AS A FROM KEN_LINEMASTER WHERE MCOLORCODE IS NOT NULL"
            OBJSQLCOMMANDGETDESC = New SqlCommand(StrSql, APPCON.CNN)
            OBJDATAREADERGETDESC = OBJSQLCOMMANDGETDESC.ExecuteReader
            While OBJDATAREADERGETDESC.Read
                CMBLINE.Items.Add(Trim(CNULLS(OBJDATAREADERGETDESC!A)))
            End While
            OBJDATAREADERGETDESC.Close()
        Catch ex As Exception
            MsgBox("BINDGRID")
        End Try
    End Sub

    Private Sub CMBINAME_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBINAME.SelectedIndexChanged
        Try
            MCODE.Text = ""
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            StrSql = "Select ITEMCODE AS A FROM PRODUCTMASTER WHERE ITEMNAME ='" & Trim(CMBINAME.Text) & "'"
            OBJSQLCOMMANDGETDESC = New SqlCommand(StrSql, APPCON.CNN)
            OBJDATAREADERGETDESC = OBJSQLCOMMANDGETDESC.ExecuteReader
            If OBJDATAREADERGETDESC.Read Then
                MCODE.Text = Trim(CNULLS(OBJDATAREADERGETDESC!A))
            End If
            OBJDATAREADERGETDESC.Close()
        Catch ex As Exception
            MsgBox("BINDGRID")
        End Try
    End Sub

    Private Sub TXTBARCODE_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXTBARCODE.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                L = TXTBARCODE.Text.Substring(63, 15)
                If CMBQTY.Text = "" Then
                    MsgBox("MUST ENTER QTY")
                    Exit Sub
                End If
                If CMBINAME.Text = "" Then
                    MsgBox("MUST ENTER ITEM NAME")
                    Exit Sub
                End If
                If CMBLINE.Text = "" Then
                    MsgBox("MUST SELECT LINE ")
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
            L = TXTBARCODE.Text.Substring(63, 15)
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            Dim STRSQL As String
            STRSQL = "SELECT * FROM SCANNED WHERE ITEMCODE ='" & Trim(MCODE.Text) & "' and  rtrim(ltrim(left(right(barcode,17) ,15  )))='" & Trim(L) & "'AND TYPE ='PRODUCTION' AND  rtrim(ltrim(left(right(barcode,17) ,15  ))) NOT IN (SELECT BARCODE FROM PACKING WHERE ITEMCODE ='" & Trim(MCODE.Text) & "' and barcode='" & Trim(L) & "')"
            Dim OBJCOMMAND As New SqlCommand(STRSQL, APPCON.CNN)
            Dim OBJREADER = OBJCOMMAND.ExecuteReader()
            If OBJREADER.Read() Then
                Grid1.AddItem("", True)
                Dim I As Integer = Grid1.Rows - 2
                Grid1.Cell(I, 3).Text = L
                Grid1.Cell(I, 2).Text = Trim(OBJREADER("itemname"))
                Grid1.Cell(I, 1).Text = Trim(OBJREADER("ITEMCODE"))
                TXTCOUNTER.Text = Val(Trim(TXTCOUNTER.Text)) + 1
                Label4.BackColor = Color.Green
            Else
                Label4.BackColor = Color.Red
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
            OBJSQLCOMMAND = New SqlCommand("SELECT MAX(ID) as PKGID FROM PACKING WHERE FINYEAR ='" & Trim(pmFinYear) & "'", APPCON.CNN)
            OBJDATAREADERGETDESC = OBJSQLCOMMAND.ExecuteReader()
            If OBJDATAREADERGETDESC.Read() Then
                PKGID = CNULL(OBJDATAREADERGETDESC("PKGID"))
            End If
            OBJDATAREADERGETDESC.Close()
            StrSql = ""
            Dim I1 As Double
            For I1 = 1 To Grid1.Rows - 1
                If Trim(Grid1.Cell(I1, 1).Text) <> "" Then
                    PKGID = PKGID + 1

                    StrSql = StrSql & "INSERT INTO [PACKING]([ITEMNAME],[ITEMCODE],[BARCODE],[date],[time],LINE,USERNAME,ID,FINYEAR,[TRNO])" _
                             & " values (" _
                             & " '" & Trim(Grid1.Cell(I1, 2).Text) & "'," _
                             & " '" & Trim(Grid1.Cell(I1, 1).Text) & "'," _
                             & " '" & Trim(Grid1.Cell(I1, 3).Text) & "'," _
                             & " '" & Format(TXTDATE.Value, "yyyyMMdd") & "', " _
                             & " '" & Convert.ToString(Format(curtime2, "hmmsstt")) & "', " _
                             & " '" & Trim(CMBLINE.Text) & "'," _
                             & " '" & Trim(SysTemUserName) & "'," _
                             & " '" & Trim(PKGID) & "'," _
                             & " '" & Trim(pmFinYear) & "'," _
                             & " '" & Trim(BILLNO) & "')"
                    TXTCOUNTER.Text += 1
                End If
            Next I1
            If Trim(Grid1.Cell(1, 1).Text) <> "" Then
                StrSql = StrSql & "truncate table temp_PACKING "
                StrSql = StrSql & "INSERT INTO [temp_PACKING]([ITEMNAME],[ITEMCODE],[BARCODE],[date],[time],LINE,USERNAME,ID,FINYEAR,[TRNO])" _
                        & " values (" _
                        & " '" & Trim(Grid1.Cell(1, 2).Text) & "'," _
                        & " '" & Trim(Grid1.Cell(1, 1).Text) & "'," _
                        & " '" & Trim(Grid1.Cell(1, 3).Text) & "'," _
                        & " '" & Format(TXTDATE.Value, "yyyyMMdd") & "', " _
                        & " '" & Convert.ToString(Format(curtime2, "hmmsstt")) & "', " _
                        & " '" & Trim(CMBLINE.Text) & "'," _
                        & " '" & Trim(SysTemUserName) & "'," _
                        & " '" & Trim(PKGID) & "'," _
                        & " '" & Trim(pmFinYear) & "'," _
                        & " '" & Trim(BILLNO) & "')"
            End If
            If APPCON1.CNN.State = ConnectionState.Open Then APPCON1.CNN.Close()
            APPCON1.CNN.Open()
            OBJSQLCOMMAND = New SqlCommand(StrSql, APPCON.CNN)
            OBJSQLCOMMAND.ExecuteNonQuery()
            OBJSQLCOMMAND.Dispose()
            TXTCOUNTER.Text = 0

            Grid1.Rows = 2

            System.Diagnostics.Process.Start(Application.StartupPath + "\PACK.bat")
            MsgBox("SAVED")
        Catch ex As Exception
            MsgBox("Error!")
        End Try
    End Sub

    Private Sub BtnSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try

            Dim SRNOO As String = ""
            If Val(CMBQTY.Text) = Val(TXTCOUNTER.Text) Then
                If CMBQTY.Text = "" Then
                    MsgBox("MUST ENTER QTY")
                    Exit Sub
                End If
                If CMBINAME.Text = "" Then
                    MsgBox("MUST ENTER ITEM NAME")
                    Exit Sub
                End If
                If CMBLINE.Text = "" Then
                    MsgBox("MUST SELECT LINE ")
                    Exit Sub
                End If
                BILLFIRSTWORD = GENFUNCTION.GETFIRSTWORDCAPTION("PACKING", PmStoreDESC, pmFinYear)
                BILLNO = GENFUNCTION.AutoCodeGen("PACKING", "TRNO", BILLFIRSTWORD, "", "10", "")
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

    Private Sub BTNNEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNEW.Click
        CLEARTEXT()
    End Sub
End Class