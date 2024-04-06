Imports System.Data.SqlClient
Imports System.Data
Public Class USER_PERMISSION
    Dim STRSQL As String
    Dim OBJSQLCOMMAND As New SqlCommand
    Dim TRANS As SqlTransaction
    Dim OBJSQLCMD As New SqlCommand
    Dim OBJDATAREADER As SqlDataReader
    Dim OBJDATAREADER1 As SqlDataReader
    Dim APPCON As New CNNCLASS
    Dim usercode As String = ""
    Dim userpassword As String = ""
    Dim STAGE As String = ""
    Dim con As New CNNCLASS

    Private Sub USER_PERMISSION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.KeyPreview = True
            APPCON.connection()
            con.connection()

            Call FORMATGRID()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "USERPERMISSION")
        End Try
    End Sub
    Public Sub FORMATGRID()
        Try
            Grid1.Cols = 6
            Grid1.Rows = 1
            Grid1.Column(0).Locked = True
            Grid1.DisplayRowNumber = True
            Grid1.Column(1).Locked = True

            'ToolStripStatusLabel1.Text = "PRESS F3 FOR REFRESH"
            Grid1.Cell(0, 0).Text = "No"
            Grid1.Column(0).Alignment = FlexCell.AlignmentEnum.CenterCenter
            Grid1.Cell(0, 1).Text = "Particulars"
            Grid1.Column(1).Alignment = FlexCell.AlignmentEnum.LeftCenter
            Grid1.Column(1).Width = 230

            Grid1.Cell(0, 2).Text = "View"
            Grid1.Column(2).Alignment = FlexCell.AlignmentEnum.CenterCenter
            Grid1.Column(2).CellType = FlexCell.CellTypeEnum.CheckBox
            Grid1.Column(2).Width = 80

            Grid1.Cell(0, 3).Text = "Add"
            Grid1.Column(3).Alignment = FlexCell.AlignmentEnum.CenterCenter
            Grid1.Column(3).CellType = FlexCell.CellTypeEnum.CheckBox
            Grid1.Column(3).Width = 80

            Grid1.Cell(0, 4).Text = "Edit"
            Grid1.Column(4).Alignment = FlexCell.AlignmentEnum.CenterCenter
            Grid1.Column(4).CellType = FlexCell.CellTypeEnum.CheckBox
            Grid1.Column(4).Width = 80

            Grid1.Cell(0, 5).Text = "Delete"
            Grid1.Column(5).Alignment = FlexCell.AlignmentEnum.CenterCenter
            Grid1.Column(5).CellType = FlexCell.CellTypeEnum.CheckBox
            Grid1.Column(5).Width = 80

            Grid1.DrawMode = FlexCell.DrawModeEnum.OwnerDraw
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            STRSQL = "Select USERNAME FROM USERPERMISSION GROUP by USERNAME"
            OBJSQLCMD = New SqlCommand(STRSQL, APPCON.CNN)
            OBJDATAREADER = OBJSQLCMD.ExecuteReader
            While OBJDATAREADER.Read()
                CMBUSER.Items.Add(OBJDATAREADER("USERNAME"))
            End While
            OBJSQLCMD.Dispose()
            OBJDATAREADER.Close()
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
        Catch ex As Exception
            Dim msgtype As String = MessageBox.Show(ex.Message, "FORMATGRID", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Public Sub TEXTTODB()
        Try
            If Trim(CMBUSER.Text) <> "" Then
                If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
                APPCON.CNN.Open()
                STRSQL = "Select USERCODE, USERPASSWORD,VCODE FROM USERPERMISSION where USERNAME='" & Trim(CMBUSER.Text) & "' GROUP BY USERCODE,USERPASSWORD,VCODE"
                OBJSQLCMD = New SqlCommand(STRSQL, APPCON.CNN)
                OBJDATAREADER = OBJSQLCMD.ExecuteReader
                While OBJDATAREADER.Read()
                    usercode = CNULLS(OBJDATAREADER("USERCODE"))
                    userpassword = CNULLS(OBJDATAREADER("USERPASSWORD"))
                    STAGE = CNULLS(OBJDATAREADER("VCODE"))
                End While
                OBJSQLCMD.Dispose()
                OBJDATAREADER.Close()
                If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
                If Trim(usercode) = "" Then
                    MsgBox("DATA NOT VALID")
                End If
                If Trim(userpassword) = "" Then
                    MsgBox("DATA NOT VALID")
                End If
                If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
                APPCON.CNN.Open()
                OBJSQLCOMMAND = New SqlCommand()
                TRANS = APPCON.CNN.BeginTransaction
                OBJSQLCOMMAND.Connection = APPCON.CNN
                OBJSQLCOMMAND.Transaction = TRANS
                Call GENFUNCTION.DeleteRecord("USERPERMISSION", "USERCODE", Trim(usercode), "", , "")
                For IROW As Integer = 1 To Grid1.Rows - 1
                    If Trim(Grid1.Cell(IROW, 1).Text) <> "" Then
                        STRSQL = "insert into USERPERMISSION(USERCODE,USERNAME,FORMNAME,PVIEW,PADD,PEDIT,PDELETE,VCODE,USERPASSWORD)" _
                                    & " values (" _
                                    & " '" & Trim(usercode) & "'," _
                                    & " '" & Trim(CMBUSER.Text) & "'," _
                                    & " '" & Trim(Grid1.Cell(IROW, 1).Text) & "'," _
                                    & " '" & Val(Grid1.Cell(IROW, 2).Text) & "'," _
                                    & " '" & Val(Grid1.Cell(IROW, 3).Text) & "'," _
                                    & " '" & Val(Grid1.Cell(IROW, 4).Text) & "'," _
                                    & " '" & Val(Grid1.Cell(IROW, 5).Text) & "'," _
                                    & " '" & Trim(STAGE) & "'," _
                                    & " '" & Trim(userpassword) & "')"
                        OBJSQLCOMMAND.CommandText = STRSQL
                        OBJSQLCOMMAND.CommandType = CommandType.Text
                        OBJSQLCOMMAND.ExecuteNonQuery()
                    End If
                Next IROW
                TRANS.Commit()
                OBJSQLCOMMAND.Dispose()
                If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            End If
        Catch ex As Exception
            Dim msgtype As String = MessageBox.Show(ex.Message, "TEXTTODB", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Public Sub getval(ByVal a As String, ByVal b As Integer)
        Try
            If con.CNN.State = ConnectionState.Open Then con.CNN.Close()
            con.CNN.Open()
            STRSQL = "Select * FROM USERPERMISSION WHERE USERNAME ='" & Trim(CMBUSER.Text) & "' AND FORMNAME='" & a & "'"
            OBJSQLCOMMAND = New SqlCommand(STRSQL, con.CNN)
            OBJDATAREADER1 = OBJSQLCOMMAND.ExecuteReader
            While OBJDATAREADER1.Read()
                With Grid1
                    .Cell(b, 2).Text = CNULL(OBJDATAREADER1("PVIEW"))
                    .Cell(b, 3).Text = CNULL(OBJDATAREADER1("PADD"))
                    .Cell(b, 4).Text = CNULL(OBJDATAREADER1("PEDIT"))
                    .Cell(b, 5).Text = CNULL(OBJDATAREADER1("PDELETE"))
                End With
            End While
            OBJSQLCOMMAND.Dispose()
            OBJDATAREADER1.Close()
            If con.CNN.State = ConnectionState.Open Then con.CNN.Close()
        Catch ex As Exception
            Dim msgtype As String = MessageBox.Show(ex.Message, "GETVAL", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Public Sub DBTOTEXT()
        Try
            Grid1.Rows = 1
            Dim ITRUE As Boolean = False
            Dim iRow As Integer = 1
            Dim STRVAL As String = ""
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            STRSQL = "Select * FROM FORMNAME order by idno1"
            OBJSQLCMD = New SqlCommand(STRSQL, APPCON.CNN)
            OBJDATAREADER = OBJSQLCMD.ExecuteReader
            While OBJDATAREADER.Read()
                ITRUE = True
                With Grid1
                    If STRVAL <> CNULLS(OBJDATAREADER("TYPE")) And iRow > 1 Then
                        .AddItem("")
                        iRow = iRow + 1
                    End If
                    .AddItem("")
                    STRVAL = CNULLS(OBJDATAREADER("TYPE"))
                    .Cell(iRow, 1).Text = CNULLS(OBJDATAREADER("FORMNAME"))
                    Call getval(CNULLS(OBJDATAREADER("formname")), iRow)
                    iRow = iRow + 1
                End With
            End While
            OBJSQLCMD.Dispose()
            OBJDATAREADER.Close()
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
        Catch ex As Exception
            Dim msgtype As String = MessageBox.Show(ex.Message, "TEXTTODB", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub CMDUPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub USER_PERMISSION_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Keys.F3 = e.KeyCode Then
            If Trim(CMBUSER.Text) <> "" Then
                Call DBTOTEXT()
            Else
                Grid1.Rows = 1
            End If
        End If
    End Sub

    Private Sub CMBUSER_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBUSER.Leave
        If Trim(CMBUSER.Text) <> "" Then
            Call DBTOTEXT()
        Else
            Grid1.Rows = 1
        End If
    End Sub

    Private Sub Chkall_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chkall.CheckedChanged
        Try
            If Chkall.Checked = True Then
                For i As Integer = 1 To Grid1.Rows - 1
                    Grid1.Cell(i, 2).Text = 1
                Next i
            Else
                For i As Integer = 1 To Grid1.Rows - 1
                    Grid1.Cell(i, 2).Text = 0
                Next i
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Try
            If CheckBox1.Checked = True Then
                For i As Integer = 1 To Grid1.Rows - 1
                    Grid1.Cell(i, 3).Text = 1
                Next i
            Else
                For i As Integer = 1 To Grid1.Rows - 1
                    Grid1.Cell(i, 3).Text = 0

                Next i
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Try
            If CheckBox2.Checked = True Then
                For i As Integer = 1 To Grid1.Rows - 1
                    Grid1.Cell(i, 4).Text = 1
                Next i
            Else
                For i As Integer = 1 To Grid1.Rows - 1
                    Grid1.Cell(i, 4).Text = 0

                Next i
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        Try
            If CheckBox3.Checked = True Then
                For i As Integer = 1 To Grid1.Rows - 1
                    Grid1.Cell(i, 5).Text = 1
                Next i
            Else
                For i As Integer = 1 To Grid1.Rows - 1
                    Grid1.Cell(i, 5).Text = 0

                Next i
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CMDUPDATE_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDUPDATE.Click
        If UserRight("USER PERMISSION", "EDIT", SysTemUserName) = True Then
            If Trim(CMBUSER.Text) <> "" Then
                Call TEXTTODB()
                MsgBox("UPDATE SUCCESSFULLY")
            End If
        Else
            MsgBox("UPDATE", MsgBoxStyle.Critical, "NO RIGHT")
        End If
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class