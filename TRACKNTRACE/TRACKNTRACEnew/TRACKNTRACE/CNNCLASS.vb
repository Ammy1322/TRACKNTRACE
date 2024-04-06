Imports System.Data.SqlClient
Public Class CNNCLASS
    Public CNN As SqlConnection = New SqlConnection()
    Public HsName, Uname, DbName As String
    Public WARECNN As SqlConnection = New SqlConnection()
    Public REMOTECNN As SqlConnection = New SqlConnection()
    Public LogRemoteCNN As SqlConnection = New SqlConnection()

    Public Sub connection()
        Try
            Dim sFileName As String
            Dim srFileReader As System.IO.StreamReader
            Dim a As String = ""
            Dim servername As String = ""
            Dim database As String = ""
            sFileName = Application.StartupPath & "\Config.txt"
            srFileReader = System.IO.File.OpenText(sFileName)
            Main.DBCOMPNAME = srFileReader.ReadLine
            servername = srFileReader.ReadLine()
            Main.pmServer = servername
            Main.pmServer_New = servername
            database = srFileReader.ReadLine()
            Main.pmDatabase = database

            'FRMMAIN.PACKTYPE = srFileReader.ReadLine()
            Main.pmDbUser = srFileReader.ReadLine()
            Main.pmDbPassWord = srFileReader.ReadLine()
            Main.pmDSNNAME = srFileReader.ReadLine()
            'For ADDRESS PURPOSE
            Main.ADD1 = srFileReader.ReadLine()
            Main.ADD2 = srFileReader.ReadLine()
            Main.ADD3 = srFileReader.ReadLine()
            Main.PH1 = srFileReader.ReadLine()
            Main.PH2 = srFileReader.ReadLine()
            Main.TINNO = srFileReader.ReadLine()
            Main.COMPANYNO = srFileReader.ReadLine()
            Main.EX1 = srFileReader.ReadLine()
            Main.EX2 = srFileReader.ReadLine()
            Main.EX3 = srFileReader.ReadLine()
            Main.EX4 = srFileReader.ReadLine()
            Main.EX5 = srFileReader.ReadLine()
            Main.EX6 = srFileReader.ReadLine()
            Main.customercode = srFileReader.ReadLine()
            Main.EX7 = srFileReader.ReadLine()
            Main.bottomLine = srFileReader.ReadLine()
            Main.compremark = srFileReader.ReadLine()
            'End PURPOSE
            CNN = New SqlConnection
            CNN.ConnectionString = "Data Source=" & servername & ";user id=" & pmDbUser & ";pwd=" & pmDbPassWord & ";INITIAL CATALOG =" & database & ";Persist Security Info=TRUE"
            If CNN.State = 1 Then
                CNN.Close()
            End If
        Catch ex As Exception
            MsgBox("Database connection Error")
        End Try
    End Sub

    Public Sub WARECONNECTION()
        Try
            WARECNN = New SqlConnection
            WARECNN.ConnectionString = "Data Source=" & Main.pmServer & ";user id=" & Main.pmDbUser & ";pwd=" & Main.pmDbPassWord & ";INITIAL CATALOG =FLOOR2012;Persist Security Info=True"
            If WARECNN.State = 1 Then
                WARECNN.Close()
            End If
        Catch ex As Exception
            MsgBox("Database connection Error")
        End Try
    End Sub
    Public Sub machineinfo()
        Try
            Me.connection()
            CNN.Open()
            Dim cmd As SqlCommand = New SqlCommand("Select  host_name()as hs,suser_name() as sern,db_name() as databas ", CNN)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                HsName = reader("hs").ToString()
                DbName = reader("databas").ToString()
                serverDateTime = DateAndTime.Now().ToString()
            End If
            reader.Close()
            CNN.Close()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub LOGREMOTECONNECTION()
        Try
            LogRemoteCNN.ConnectionString = "Data Source=164.52.214.53,1232;user id=sa;password=Yu6SBA5s4u#zcT6%e;INITIAL CATALOG =CUSTOMER_VALIDITY;Persist Security Info=true"
            If LogRemoteCNN.State = 1 Then
                LogRemoteCNN.Close()
            End If
        Catch ex As Exception
            MsgBox("Database Remote Connection Error.....", MsgBoxStyle.Information)
        End Try
    End Sub
End Class
