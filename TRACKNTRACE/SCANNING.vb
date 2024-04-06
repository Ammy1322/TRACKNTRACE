Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports System.Net.Sockets
Imports System.Text.UTF7Encoding
Imports System.Text
Imports System.Security.Cryptography
Imports vs = Microsoft.VisualBasic
Public Class SCANNING
    Dim APPCON As New CNNCLASS
    Dim APPCON1 As New CNNCLASS
    Dim STRSQL As String
    Dim READ As SqlDataReader
    Dim CMD As SqlCommand
    Dim USERNAME As String
    Dim PASSWORD As String
    Dim OBJCOMMAND As New SqlCommand
    Dim OBJDATAREADER As SqlDataReader
    Dim OBJSQLCOMMANDGETDESC As SqlCommand
    Dim OBJDATAREADERGETDESC As SqlDataReader
    Dim OBJSQLCOMMAND As SqlCommand
    Dim OBJDATAREADERNEW As SqlDataReader
    Dim open As TcpListener
    Dim server As TcpListener
    Dim client, host As TcpClient
    Dim dati, hdat As NetworkStream
    Dim ip As String = Nothing
    Dim updatedTime1 As DateTime
    Dim SRNOBARCODE As String
    Dim OBJSQLCOMMANDNEW As SqlCommand
    Dim OBJSQLCOMMANDNEWGETDESC As SqlCommand
    Dim OBJDATAREADER1 As SqlDataReader
    Dim OBJDATAREADER2 As SqlDataReader
    Dim StrSql1 As String = ""
    Dim TRANS As SqlTransaction
    Public FRMTYPE As String
    Dim TRANTYPE As String = ""
    Dim SAVETYPE As String = ""
    Dim Iyear As Integer = DateTime.Now.Year.ToString()
    Dim MNTH As String = DateTime.Now.Month.ToString()
    Dim BARCODENO As String = ""
    Dim BILLFIRSTWORD As String = ""
    Dim BILLNO As String
    Dim curdate As Date = Now.Today
    ' Dim curtime1 As String = Convert.ToString(Now.TimeOfDay)
    ' Dim curtime2 As Date = curtime1
    Dim TNAME As String = ""
    Dim TNAMESUB As String = ""
    Dim GNO As Integer = 0
    Dim STRSQLGETDESC As String = ""
    Dim L As String = ""
    Public dateTimePicker As DateTimePicker
    Dim OBJCOMMANDNEW As SqlCommand
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
            Call scannerconnect()
            checkk()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub LABELFONT()
        Label1.Font = New Font("Avenir", 14)
        Label2.Font = New Font("Avenir", 14)
        Label3.Font = New Font("Avenir", 14)
        Label4.Font = New Font("Avenir", 14)
        Label5.Font = New Font("Avenir", 14)
        Label6.Font = New Font("Avenir", 14)
        Label7.Font = New Font("Avenir", 14)
        Label8.Font = New Font("Avenir", 14)
        TXTCOUNTER.Font = New Font("Avenir", 14)
        TXTREJECT.Font = New Font("Avenir", 14)
        Label11.Font = New Font("Avenir", 14)
    End Sub
    Private Sub RoundButton(ByVal btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.DodgerBlue
        btn.ForeColor = Color.White
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Avenir", 14)
        Dim Raduis As New Drawing2D.GraphicsPath
        Raduis.StartFigure()
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Raduis.AddLine(btn.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Raduis.CloseFigure()
        btn.Region = New Region(Raduis)
    End Sub
    Private Sub scannerconnect()
        Try
            ip = "192.168.10.17"
            client = New TcpClient
            client.Connect(ip, 23)
            If client.Connected = True Then
                dati = client.GetStream
                ' MsgBox("Connected", MsgBoxStyle.Information)
                Label9.BackColor = Color.Green
                Timer1.Start()
            Else
                MsgBox("Error", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox("error")
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
        Grid2.Cell(0, 1).Text = "Product Code"
        Grid2.Column(1).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid2.Column(1).Width = 150
        Grid2.Cell(0, 2).Text = "Prouduct Name"
        Grid2.Column(2).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid2.Column(2).Width = 200
        Grid2.Cell(0, 3).Text = "Barcode"
        Grid2.Column(3).Alignment = FlexCell.AlignmentEnum.LeftCenter
        Grid2.Column(3).Width = 100
        Grid2.Cell(0, 4).Text = "Status"
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
    Private Sub check()
        Try

            'FOR AUTOMATION CONYEVER
            Dim Registers(10) As Short
            Dim Result As WSMBT.Result
            Registers(0) = 0
            Registers(1) = 0
            Registers(2) = 0
            Result = WsmbtControl1.WriteMultipleRegisters(1, 0, 10, Registers)
            Dim STA As String = ""
            Dim MSG As String = ""
            Dim curdate As Date = Now.Today
            Dim curtime1 As String = Now.TimeOfDay.ToString
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
            STRSQL = "EXEC SCANDATA @ITEMNAME='" & Trim(CMBINAME.Text) & "',@ITEMCODE='" & Trim(MCODE.Text) & "',@BARCODE='" & Trim(TXTBARCODE.Text) & "' ,@DATE ='" & Format(TXTDATE.Value, "yyyyMMdd") & "',@TIME ='" & (Format(curtime2, "hmmsstt")).ToString & "',@TYPE ='" & Trim(CMBTYPE.Text) & "' ,@LINE = '" & Trim(CMBLINE.Text) & "',@USERNAME ='" & Trim(SysTemUserName) & "',@FINYEAR ='" & Trim(pmFinYear) & "'"
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
        Catch ex As Exception
            MsgBox("DATA")
            TRANS.Rollback()
        End Try
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXTBARCODE.KeyDown
        'Try
        '    If e.KeyCode = Keys.Enter Then

        '        'FOR AUTOMATION CONYEVER
        '        Dim Registers(10) As Short
        '        Dim Result As WSMBT.Result
        '        Registers(0) = 0

        '        Registers(1) = 0
        '        Registers(2) = 0
        '        Result = WsmbtControl1.WriteMultipleRegisters(1, 0, 10, Registers)
        '        Dim STA As String = ""
        '        Dim MSG As String = ""
        '        Dim curdate As Date = Now.Today
        '        Dim curtime1 As String = Convert.ToString(Now.TimeOfDay)
        '        Dim curtime2 As Date = curtime1
        '        If CMBINAME.Text = "" Then
        '            MsgBox("MUST SELECT ITEM NAME")
        '            Exit Sub
        '        End If
        '        If MCODE.Text = "" Then
        '            MsgBox("MUST ENTER ITEM CODE")
        '            Exit Sub
        '        End If
        '        If CMBTYPE.Text = "" Then
        '            MsgBox("MUST SELECT TYPE")
        '            Exit Sub
        '        End If
        '        If CMBLINE.Text = "" Then
        '            MsgBox("MUST SELECT LINE ")
        '            Exit Sub
        '        End If
        '        STRSQL = "EXEC SCANDATA @ITEMNAME='" & Trim(CMBINAME.Text) & "',@ITEMCODE='" & Trim(MCODE.Text) & "',@BARCODE='" & Trim(TXTBARCODE.Text) & "' ,@DATE ='" & Format(TXTDATE.Value, "yyyyMMdd") & "',@TIME ='" & Convert.ToString(Format(curtime2, "hmmsstt")) & "',@TYPE ='" & Trim(CMBTYPE.Text) & "' ,@LINE = '" & Trim(CMBLINE.Text) & "',@USERNAME ='" & Trim(SysTemUserName) & "',@FINYEAR ='" & Trim(pmFinYear) & "'"
        '        If APPCON1.CNN.State = ConnectionState.Open Then APPCON1.CNN.Close()
        '        APPCON1.CNN.Open()
        '        OBJSQLCOMMAND = New SqlCommand(STRSQL, APPCON1.CNN)
        '        OBJDATAREADER1 = OBJSQLCOMMAND.ExecuteReader()
        '        If OBJDATAREADER1.Read Then
        '            MSG = Trim(OBJDATAREADER1("msg"))
        '            If MSG <> "SAVED" Then
        '                Label4.BackColor = Color.Red
        '                TXTREJECT.Text += 1
        '                STA = "REJECTED"
        '                Registers(1) = 0
        '                Registers(2) = 1
        '            Else
        '                Label4.BackColor = Color.Green
        '                TXTCOUNTER.Text += 1
        '                STA = "APPROVED"
        '                Registers(1) = 1
        '                Registers(2) = 0
        '            End If
        '            Result = WsmbtControl1.WriteMultipleRegisters(1, 0, 10, Registers)
        '        End If
        '        OBJDATAREADER1.Close()
        '        OBJSQLCOMMAND.Dispose()
        '        Call DBTOSEARCH(STA)
        '    End If
        'Catch ex As Exception
        '    MsgBox("DATA")
        '    TRANS.Rollback()
        'End Try
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

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If client.Available > 0 Then
            Dim t(client.Available - 1) As Byte
            dati.Read(t, 0, t.Length)
            TXTBARCODE.Text = UTF7.GetString(t)
            Call check()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Registers(10) As Short
        Dim Result As WSMBT.Result
        Registers(0) = 0
        Registers(1) = 0
        Registers(2) = 0
        Result = WsmbtControl1.WriteMultipleRegisters(1, 0, 10, Registers)
        Registers(1) = 0
        Registers(2) = 1
        Result = WsmbtControl1.WriteMultipleRegisters(1, 0, 10, Registers)
    End Sub
    Private Sub checkk()
        Dim Registers(10) As Short
        Dim Result As WSMBT.Result
        Registers(0) = 0
        Registers(1) = 0
        Registers(2) = 0
        Result = WsmbtControl1.WriteMultipleRegisters(1, 0, 10, Registers)
        Registers(1) = 1
        Registers(2) = 0
        Result = WsmbtControl1.WriteMultipleRegisters(1, 0, 10, Registers)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        checkk()
    End Sub
End Class