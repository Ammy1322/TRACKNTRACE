Imports System.Data.SqlClient
Imports System.Data
Public Class ORDER_FEEDING
    Dim APPCON As New CNNCLASS
    Dim APPCON1 As New CNNCLASS

    Dim savetype As String
    Dim OBJSQLCOMMAND As SqlCommand
    Dim OBJCOMMAND As SqlCommand
    Dim OBJCOMMANDNEW As SqlCommand
    Dim OBJDATAREADER As SqlDataReader
    Dim OBJDATAREADERNEW As SqlDataReader
    Dim TRANS As SqlTransaction
    Dim STRSQL As String = ""
    Dim OBJSQLCOMMANDGETDESC As SqlCommand
    Dim OBJDATAREADERGETDESC As SqlDataReader
    Dim SRNOBARCODE As String
    Dim OBJSQLCOMMANDNEW As SqlCommand
    Dim OBJSQLCOMMANDNEWGETDESC As SqlCommand
    Dim OBJDATAREADER1 As SqlDataReader
    Dim OBJDATAREADER2 As SqlDataReader
    Dim StrSql1 As String = ""
    Public FRMTYPE As String
    Dim TRANTYPE As String = ""
    Dim Iyear As Integer = DateTime.Now.Year.ToString()
    Dim MNTH As String = DateTime.Now.Month.ToString()
    Dim BARCODENO As String = ""
    Dim BILLFIRSTWORD As String = ""
    Dim BILLNO As String
    Dim TNAME As String = ""
    Dim TNAMESUB As String = ""
    Dim GNO As Integer = 0
    Dim STRSQLGETDESC As String = ""
    Dim L As String = ""
    Dim SHOWTIME As String = ""
    Dim ENDTIME As String = ""
    Private Sub ORDER_FEEDING_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            APPCON.connection()
            APPCON1.connection()
            Me.KeyPreview = True
            Call FORMATGRID()
            '  Call CLEARTEXT()
            'Call BINDGRID()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub FORMATGRID()
        'mgbox.Text = "Alt+D For DELETE      Alt+N For NEW      PAGEUP FOR NEXT      PAGEDOWN FOR PREVIOUS"
        Grid1.Cols = 4
        Grid1.Cell(0, 1).Text = "Product Name"
        Grid1.Column(1).CellType = FlexCell.CellTypeEnum.ComboBox
        Grid1.Column(1).Width = 350
        Grid1.Cell(0, 2).Text = "Product Code"
        Grid1.Column(2).CellType = FlexCell.CellTypeEnum.ComboBox
        Grid1.Column(2).Width = 200
        Grid1.Cell(0, 3).Text = "Qty"
        Grid1.Column(3).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid1.Column(3).Width = 130


    End Sub

    Private Sub Grid2_ComboDropDown(ByVal Sender As System.Object, ByVal e As FlexCell.Grid.ComboDropDownEventArgs) Handles Grid1.ComboDropDown
        Try

            Select Case e.Col
                Case 1
                    If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
                    APPCON.CNN.Open()
                    Grid1.ComboBox(1).Items.Clear()
                    Dim StrSql As String = "Select ITEMNAME AS A FROM PRODUCTMASTER WHERE ACTIVE ='YES'"
                    Dim cmd1 As New SqlCommand(StrSql, APPCON.CNN)
                    Dim OBJDATAREADERNEW1 As SqlDataReader = cmd1.ExecuteReader()
                    Dim i As Integer = 0
                    While OBJDATAREADERNEW1.Read()
                        Grid1.ComboBox(1).Items.Add(OBJDATAREADERNEW1("A").ToString)
                    End While
                    OBJDATAREADERNEW1.Close()
            End Select

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Grid1_LeaveCell(ByVal Sender As System.Object, ByVal e As FlexCell.Grid.LeaveCellEventArgs) Handles Grid1.LeaveCell
        Dim L As String = ""
        If Grid1.Cell(Grid1.ActiveCell.Row, 1).Text = "" Then
            Exit Sub
        End If
        Select Case e.Col
            Case 1
                L = Grid1.Cell(Grid1.ActiveCell.Row, 1).Text
                For i As Integer = 1 To Grid1.Rows - 1
                    If i = Grid1.ActiveCell.Row Then
                    Else
                        If Trim(Grid1.Cell(i, 1).Text) <> "" Then
                            If LCase(Trim(Grid1.Cell(i, 1).Text)) = LCase(Trim(L)) And UCase(Trim(Grid1.Cell(i, 1).Text)) = UCase(Trim(L)) Then
                                MsgBox("ITEM NAME ALREADY SELECTED")
                                Grid1.Cell(Grid1.ActiveCell.Row, 1).Text = ""
                                Exit Sub
                            End If
                        End If
                    End If
                Next
                If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
                APPCON.CNN.Open()
                STRSQL = "Select ITEMCODE AS A FROM PRODUCTMASTER WHERE ITEMNAME ='" & Trim(Grid1.Cell(Grid1.ActiveCell.Row, 1).Text) & "'"
                OBJSQLCOMMANDGETDESC = New SqlCommand(STRSQL, APPCON.CNN)
                OBJDATAREADERGETDESC = OBJSQLCOMMANDGETDESC.ExecuteReader
                If OBJDATAREADERGETDESC.Read Then
                    Grid1.Cell(Grid1.ActiveCell.Row, 2).Text = Trim(CNULLS(OBJDATAREADERGETDESC!A))
                End If
                OBJDATAREADERGETDESC.Close()
                Grid1.AddItem("", True)
        End Select
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
            STRSQL = "TRUNCATE TABLE orderfeed_TEMP"
            OBJSQLCOMMAND = New SqlCommand(STRSQL, APPCON.CNN)
            OBJSQLCOMMAND.ExecuteNonQuery()
            OBJSQLCOMMAND.Dispose()

            OBJSQLCOMMAND = New SqlCommand("SELECT MAX(ID) as PKGID FROM [orderfeed] ", APPCON.CNN)
            OBJDATAREADERGETDESC = OBJSQLCOMMAND.ExecuteReader()
            If OBJDATAREADERGETDESC.Read() Then
                PKGID = CNULL(OBJDATAREADERGETDESC("PKGID")) + 1
            End If
            OBJDATAREADERGETDESC.Close()
            Dim I1 As Double
            STRSQL = ""
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            For I1 = 1 To Grid1.Rows - 1
                If Trim(Grid1.Cell(I1, 1).Text) <> "" Then
                    STRSQL = STRSQL & "INSERT INTO [orderfeed]([ITEMNAME],qty,ITEMCODE,date,time,USERNAME,PARTYNAME,MOBILENO,id,[ORDERNO])" _
                             & " values (" _
                             & " '" & Trim(Grid1.Cell(I1, 1).Text) & "'," _
                             & " '" & Trim(Grid1.Cell(I1, 3).Text) & "'," _
                             & " '" & Trim(Grid1.Cell(I1, 2).Text) & "'," _
                             & " '" & Format(TXTDATE.Value, "yyyyMMdd") & "', " _
                             & " '" & Convert.ToString(Format(curtime2, "hmmsstt")) & "', " _
                             & " '" & Trim(SysTemUserName) & "'," _
                             & " '" & Trim(TXTCUST.Text) & "'," _
                             & " '" & Trim(TXTMOB.Text) & "'," _
                             & " '" & PKGID & "'," _
                             & " '" & BILLNO & "')"
                    'STRSQL = STRSQL & "INSERT INTO [orderfeed_TEMP]([ITEMNAME],qty,date,time,id,[TRNO])" _
                    ' & " values (" _
                    ' & " '" & Trim(Grid1.Cell(I1, 1).Text) & "'," _
                    ' & " '" & Trim(Grid1.Cell(I1, 2).Text) & "'," _
                    ' & " '" & Format(TXTDATE.Value, "yyyyMMdd") & "', " _
                    ' & " '" & Convert.ToString(Format(curtime2, "hmmsstt")) & "', " _
                    ' & " '" & PKGID & "'," _
                    ' & " '" & BILLNO & "')"
                End If
            Next I1
            If APPCON1.CNN.State = ConnectionState.Open Then APPCON1.CNN.Close()
            APPCON1.CNN.Open()
            OBJSQLCOMMAND = New SqlCommand(STRSQL, APPCON.CNN)
            OBJSQLCOMMAND.ExecuteNonQuery()
            OBJSQLCOMMAND.Dispose()
            MsgBox("SAVED")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub BTNSEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub
    Private Sub BTNNEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BTNNEW_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNEW.Click
        Grid1.Rows = 2
        For i As Integer = 1 To Grid1.Cols - 1
            Grid1.Cell(1, i).Text = ""
        Next i

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Try
            Dim SRNOO As String = ""
            If TXTCUST.Text = "" Then
                MsgBox("MUST ENTER CUSTOMER NAME")
                Exit Sub
            End If

            If TXTMOB.Text = "" Then
                MsgBox("MUST ENTER MOBILE NO")
                Exit Sub
            End If
            BILLFIRSTWORD = GENFUNCTION.GETFIRSTWORDCAPTION("orderfeed", PmStoreDESC, pmFinYear)
            BILLNO = GENFUNCTION.AutoCodeGen("orderfeed", "ORDERNO", BILLFIRSTWORD, "", "10", "")
            TextBox1.Text = BILLNO
            Call INSERTDATA()
            Grid1.Rows = 2
            For i As Integer = 1 To Grid1.Cols - 1
                Grid1.Cell(1, i).Text = ""
            Next i
            TextBox1.Text = ""
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub
End Class