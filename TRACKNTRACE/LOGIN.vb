Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports vs = Microsoft.VisualBasic
Imports System.Net.NetworkInformation
Public Class LOGIN
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
    Public Class Crypto
        Private Shared DES As New TripleDESCryptoServiceProvider
        Private Shared MD5 As New MD5CryptoServiceProvider

        Public Shared Function MD5Hash(ByVal value As String) As Byte()
            Return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))
        End Function

        Public Shared Function Encrypt(ByVal stringToEncrypt As String, ByVal key As String) As String
            DES.Key = Crypto.MD5Hash(key)
            DES.Mode = CipherMode.ECB
            Dim Buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(stringToEncrypt)
            Return Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
        End Function

        Public Shared Function Decrypt(ByVal encryptedString As String, ByVal key As String) As String
            Try
                DES.Key = Crypto.MD5Hash(key)
                DES.Mode = CipherMode.ECB
                Dim Buffer As Byte() = Convert.FromBase64String(encryptedString)
                Return ASCIIEncoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
            Catch ex As Exception
                MessageBox.Show("Invalid Key", "Decryption Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Function
    End Class
    Function getMacAddress()
        Dim nics() As NetworkInterface = _
              NetworkInterface.GetAllNetworkInterfaces
        Return nics(0).GetPhysicalAddress.ToString
    End Function
    Private Sub LABELFONT(ByVal LBL As Label)
        LBL.Font = New Font("Avenir", 14)
    End Sub
    Private Sub RoundButtondem(ByVal btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.ForeColor = Color.Black
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
    Private Sub RoundButton(ByVal btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
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
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            APPCON.connection()
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\CONTROL PANEL\INTERNATIONAL", "sSHORTDATE", "dd/MM/yyyy")
            Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\CONTROL PANEL\INTERNATIONAL", "sLONGDATE", "dd/MM/yyyy")
            Dim mmt As New Crypto
            Dim sFileName As String
            Dim srFileReader As System.IO.StreamReader
            Dim a As String = ""
            Dim servername As String = ""
            Dim database As String = ""
            TXTUSER.Focus()
            sFileName = Application.StartupPath & "\Config.txt"
            srFileReader = System.IO.File.OpenText(sFileName)
            Call COMPANYBIND()
            CMBCOMP.Text = GETDESC(2, MAIN.COMPANYNO)
            Me.KeyPreview = True
            Dim Iyear As Integer = DateTime.Now.Year.ToString()
            For Iyr As Integer = 2021 To Iyear
                CMBYEAR.Items.Add(Iyr)
            Next
            If Format(DateTime.Now, "yyyyMMdd") > Iyear & "0331" Then
                CMBYEAR.Text = Iyear
            Else
                CMBYEAR.Text = Iyear - 1
            End If

            TXTUSER.Focus()
        Catch ex As Exception
            MsgBox("Database Connection Error", MsgBoxStyle.ApplicationModal)
            Exit Sub
        End Try

    End Sub
    Public Sub COMPANYBIND()
        CMBCOMP.Items.Clear()
        If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
        APPCON.CNN.Open()
        STRSQL = "Select ACTDESC FROM KEN_VENDORMASTER"
        OBJSQLCOMMANDGETDESC = New SqlCommand(STRSQL, APPCON.CNN)
        OBJDATAREADERGETDESC = OBJSQLCOMMANDGETDESC.ExecuteReader
        While OBJDATAREADERGETDESC.Read
            CMBCOMP.Items.Add(Trim(CNULLS(OBJDATAREADERGETDESC!ACTDESC)))
        End While
        OBJDATAREADERGETDESC.Close()
    End Sub
    Public Function GETDESC(ByVal MOPT As Integer, ByVal FORMNAME As String, Optional ByVal FUNNAME As String = "") As String
        Try
            APPCON1.connection()
            GETDESC = ""

            If APPCON1.CNN.State = ConnectionState.Open Then APPCON1.CNN.Close()
            APPCON1.CNN.Open()
            Select Case (MOPT)
                Case 1
                    STRSQL = "Select ACTCODE1 FROM KEN_VENDORMASTER WHERE ACTDESC='" & Trim(FORMNAME) & "'"
                    OBJSQLCOMMANDGETDESC = New SqlCommand(STRSQL, APPCON1.CNN)
                    OBJDATAREADERGETDESC = OBJSQLCOMMANDGETDESC.ExecuteReader
                    While OBJDATAREADERGETDESC.Read
                        GETDESC = Trim(CNULLS(OBJDATAREADERGETDESC!ACTCODE1))
                    End While
                    OBJDATAREADERGETDESC.Close()

                Case 2
                    STRSQL = "Select ACTDESC FROM KEN_VENDORMASTER WHERE ACTCODE1='" & Trim(FORMNAME) & "'"
                    OBJSQLCOMMANDGETDESC = New SqlCommand(STRSQL, APPCON1.CNN)
                    OBJDATAREADERGETDESC = OBJSQLCOMMANDGETDESC.ExecuteReader
                    While OBJDATAREADERGETDESC.Read
                        GETDESC = Trim(CNULLS(OBJDATAREADERGETDESC!ACTDESC))
                    End While
                    OBJDATAREADERGETDESC.Close()

            End Select
            If APPCON1.CNN.State = ConnectionState.Open Then APPCON1.CNN.Close()
        Catch ex As Exception
            Dim msgtype As String = MessageBox.Show(ex.Message, "GETDESC", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Function
   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub
    Private Sub TXTUSER_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXTUSER.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXTPASS.Focus()
        End If
    End Sub
    Private Sub TXTPASS_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXTPASS.KeyDown
        If e.KeyCode = Keys.Enter Then
            BTNLOGIN.Focus()
        End If
    End Sub
    Private Sub CMBCOMP_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CMBCOMP.KeyDown
        If e.KeyCode = Keys.Enter Then
            CMBYEAR.Focus()
        End If
    End Sub
    Private Sub CMBYEAR_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CMBYEAR.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXTUSER.Focus()
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub BTNLOGIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNLOGIN.Click
        Try
            If CMBCOMP.Text = "" Then
                MsgBox("COMPANY NAME CAN'T BE BLANK")
                CMBCOMP.Focus()
                Exit Sub
            End If
            If CMBYEAR.Text = "" Then
                MsgBox("YEAR CAN'T BE BLANK")
                CMBYEAR.Focus()
                Exit Sub
            End If
            CMBYEAR.Text = "2023"
            If TXTUSER.Text = "" Then
                MsgBox("USER CAN'T BE BLANK")
                TXTUSER.Focus()
                Exit Sub
            End If
            If TXTPASS.Text = "" Then
                MsgBox("PASSWORD CAN'T BE BLANK")
                TXTPASS.Focus()
                Exit Sub
            End If
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            STRSQL = "SELECT VCODE FROM USERPERMISSION WHERE USERNAME='" & Trim(TXTUSER.Text) & "' AND USERPASSWORD='" & Trim(TXTPASS.Text) & "' AND VCODE='" & GETDESC(1, Trim(CMBCOMP.Text)) & "'"
            CMD = New SqlCommand(STRSQL, APPCON.CNN)
            READ = CMD.ExecuteReader
            If READ.Read = True Then
                PmStoreDESC = CNULLS(READ("VCODE"))
            Else
                MsgBox("INVALID USER AND PASSWORD")
                Me.TXTUSER.Focus()
                Exit Sub
            End If
            CMD.Dispose()
            READ.Close()
            MAIN.PmCompanyName = CMBCOMP.Text
            pmFinYear = CMBYEAR.Text
            SysTemUserName = Trim(TXTUSER.Text)
            PmStoreDESC = "A1"
            MMDI.Show()
            Me.Hide()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.SystemModal, "LOGIN BUTTON")
        End Try
    End Sub

    Private Sub BTNEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEXIT.Click
        Me.Dispose()
    End Sub
End Class
