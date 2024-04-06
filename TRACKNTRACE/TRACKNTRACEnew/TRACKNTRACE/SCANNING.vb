Imports System.Data.SqlClient
Imports System.Data
Public Class SCANNING
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
    Private Sub SCANNING_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            APPCON.connection()
            APPCON1.connection()
            Me.KeyPreview = True
            Call FORMATGRID()
            Call CLEARTEXT()
            Call coneectd()
            'Call SEARCHRECORD()
            Call BINDGRID()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub coneectd()
        Dim Result As WSMBT.Result
        WsmbtControl1.Mode = WSMBT.Mode.TCP_IP
        WsmbtControl1.ResponseTimeout = 1000
        Result = WsmbtControl1.Connect("192.168.10.25", 502)
        If Result <> WSMBT.Result.SUCCESS Then
            MessageBox.Show(WsmbtControl1.GetLastErrorString())
        End If
    End Sub
    Public Sub FORMATGRID()
        'mgbox.Text = "Alt+D For DELETE      Alt+N For NEW      PAGEUP FOR NEXT      PAGEDOWN FOR PREVIOUS"
        Grid2.Cols = 5
        Grid2.Cell(0, 1).Text = "PRODUCT CODE"
        Grid2.Column(1).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid2.Column(1).Width = 150
        Grid2.Cell(0, 2).Text = "PRODUCT NAME"
        Grid2.Column(2).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid2.Column(2).Width = 200
        Grid2.Cell(0, 3).Text = "BARCODE"
        Grid2.Column(3).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid2.Column(3).Width = 100
        Grid2.Cell(0, 4).Text = "STATUS"
        Grid2.Column(4).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid2.Column(4).Width = 100
        Grid2.Locked = True
    End Sub
    Private Sub CLEARTEXT()
        CMBINAME.Text = ""
        MCODE.Text = ""
        Grid2.Rows = 2
        For i As Integer = 1 To Grid2.Cols - 1
            Grid2.Cell(1, i).Text = ""
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
            STRSQL = "Select MCOLORCODE AS A FROM KEN_LINEMASTER WHERE MCOLORCODE IS NOT NULL"
            OBJSQLCOMMANDGETDESC = New SqlCommand(STRSQL, APPCON.CNN)
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
            STRSQL = "Select ITEMCODE AS A FROM PRODUCTMASTER WHERE ITEMNAME ='" & Trim(CMBINAME.Text) & "'"
            OBJSQLCOMMANDGETDESC = New SqlCommand(STRSQL, APPCON.CNN)
            OBJDATAREADERGETDESC = OBJSQLCOMMANDGETDESC.ExecuteReader
            If OBJDATAREADERGETDESC.Read Then
                MCODE.Text = Trim(CNULLS(OBJDATAREADERGETDESC!A))
            End If
            OBJDATAREADERGETDESC.Close()
        Catch ex As Exception
            MsgBox("BINDGRID")
        End Try
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXTBARCODE.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then

                'FOR AUTOMATION CONYEVER
                Dim Registers(10) As Short
                Dim Result As WSMBT.Result
                ' Registers(0) = 1
                Registers(1) = 0
                Registers(2) = 0
                Result = WsmbtControl1.WriteMultipleRegisters(1, 0, 10, Registers)
                Dim STA As String = ""
                Dim MSG As String = ""
                Dim curdate As Date = Now.Today
                Dim curtime1 As String = Convert.ToString(Now.TimeOfDay)
                Dim curtime2 As Date = curtime1
                If CMBINAME.Text = "" Then
                    MsgBox("MUST SELECT ITEM NAME")
                    Exit Sub
                End If
                If MCODE.Text = "" Then
                    MsgBox("MUST ENTER ITEM CODE")
                    Exit Sub
                End If
                If CMBTYPE.Text = "" Then
                    MsgBox("MUST SELECT TYPE")
                    Exit Sub
                End If
                If CMBLINE.Text = "" Then
                    MsgBox("MUST SELECT LINE ")
                    Exit Sub
                End If
                STRSQL = "EXEC SCANDATA @ITEMNAME='" & Trim(CMBINAME.Text) & "',@ITEMCODE='" & Trim(MCODE.Text) & "',@BARCODE='" & Trim(TXTBARCODE.Text) & "' ,@DATE ='" & Format(TXTDATE.Value, "yyyyMMdd") & "',@TIME ='" & Convert.ToString(Format(curtime2, "hmmsstt")) & "',@TYPE ='" & Trim(CMBTYPE.Text) & "' ,@LINE = '" & Trim(CMBLINE.Text) & "',@USERNAME ='" & Trim(SysTemUserName) & "',@FINYEAR ='" & Trim(pmFinYear) & "'"
                If APPCON1.CNN.State = ConnectionState.Open Then APPCON1.CNN.Close()
                APPCON1.CNN.Open()
                OBJSQLCOMMAND = New SqlCommand(STRSQL, APPCON1.CNN)
                OBJDATAREADER1 = OBJSQLCOMMAND.ExecuteReader()
                If OBJDATAREADER1.Read Then
                    MSG = Trim(OBJDATAREADER1("msg"))
                    If MSG <> "SAVED" Then
                        Label4.BackColor = Color.Red
                        TXTREJECT.Text += 1
                        STA = "REJECTED"
                        Registers(1) = 0
                        Registers(2) = 1
                    Else
                        Label4.BackColor = Color.Green
                        TXTCOUNTER.Text += 1
                        STA = "APPROVED"
                        Registers(1) = 1
                        Registers(2) = 0
                    End If
                    Result = WsmbtControl1.WriteMultipleRegisters(1, 0, 10, Registers)
                End If
                OBJDATAREADER1.Close()
                OBJSQLCOMMAND.Dispose()
                Call DBTOSEARCH(STA)
            End If
        Catch ex As Exception
            MsgBox("DATA")
            TRANS.Rollback()
        End Try
    End Sub
    Private Sub DBTOSEARCH(ByVal ABC As String)
        Try
            'If Grid2.Rows = 10 Then
            '    TN.Text = 0
            '    Grid2.Rows = 2
            'End If
            TN.Text += 1
            Grid2.AddItem("", True)
            Grid2.Cell(TN.Text, 1).Text = Trim(CMBINAME.Text)
            Grid2.Cell(TN.Text, 2).Text = Trim(MCODE.Text)
            Grid2.Cell(TN.Text, 3).Text = Trim(TXTBARCODE.Text)
            Grid2.Cell(TN.Text, 4).Text = ABC
            TXTBARCODE.Text = ""
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBTYPE.SelectedIndexChanged

    End Sub
End Class