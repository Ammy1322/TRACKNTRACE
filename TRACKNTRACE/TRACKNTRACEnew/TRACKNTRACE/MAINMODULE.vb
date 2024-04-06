Imports System.IO
Imports System.Text
Imports System.Math
Imports System.Security.Cryptography
Imports System.Data.SqlClient
Imports System.Data
Module MAINMODULE
    Public Function UserRight(ByVal formname As String, ByVal PType As String, ByVal username As String) As Boolean
        Try
            Dim UserCon As New CNNCLASS
            UserCon.connection()
            If UserCon.CNN.State = ConnectionState.Open Then UserCon.CNN.Close()
            UserCon.CNN.Open()
            Dim StrSql As String = "select * FROM USERPERMISSION WHERE USERNAME='" & username & "' AND FORMNAME='" & formname & "'"
            Dim CMD As SqlCommand = New SqlCommand(StrSql, UserCon.CNN)
            Dim RED As SqlDataReader = CMD.ExecuteReader
            UserRight = False
            If RED.Read = True Then
                Select Case PType
                    Case "ADD"
                        If CNULL(RED("PADD")) = 1 Then
                            UserRight = True
                            Exit Function
                        End If
                    Case "EDIT"
                        If CNULL(RED("PEDIT")) = 1 Then
                            UserRight = True
                            Exit Function
                        End If
                    Case "DELETE"
                        If CNULL(RED("PDELETE")) = 1 Then
                            UserRight = True
                            Exit Function
                        End If
                    Case "VIEW"
                        If CNULL(RED("PVIEW")) = 1 Then
                            UserRight = True
                            Exit Function
                        End If
                End Select
            End If
            CMD.Dispose()
            RED.Close()
            If UserCon.CNN.State = ConnectionState.Open Then UserCon.CNN.Close()
            Return UserRight
        Catch ex As Exception
            MsgBox("User Right")
        End Try

    End Function
    Public Function RoundOff(ByVal mAmount As Single) As Single

        Dim mDec As Single
        mAmount = Round(mAmount, 3)
        mDec = mAmount - Int(mAmount)
        If mDec = 0 Then
            RoundOff = mAmount
            Exit Function
        End If

        If mDec = 0.5 Then
            mAmount = mAmount + 0.1
        End If
        RoundOff = Round(mAmount, 0)
    End Function

    ' Return 0 if object is null, else decimal value
    Public Function CNULL(ByVal o As Object) As Decimal
        If IsDBNull(o) Then
            Return 0
        Else
            Return CType(o, Decimal)
        End If
    End Function

    ''' Return String if object is not null, else return empty.string
    Public Function CNULLS(ByVal s As Object) As String
        If IsDBNull(s) Then
            Return String.Empty
        Else
            Return CType(s, String)
        End If
    End Function
    Public Function CNULLDATE(ByVal o As Object) As Date
        If IsDBNull(o) Then
            Return DateTime.Now
        Else
            Return CType(o, Date)
        End If
    End Function
    Public Function CNULLDATE2(ByVal o As Object) As Integer
        If IsDBNull(o) Then
            Return Format(DateTime.Now, "yyyyMMdd")
        Else
            Return CType(o, Integer)
        End If
    End Function
End Module
