Imports System.Data.SqlClient
Module GENFUNCTION
    Dim OBJCOMMAND As SqlCommand
    Dim OBJDATAREADER As SqlDataReader
    Dim STRSQL As String
    Public Function FINDATE(ByVal FDATE As Date) As Boolean
        Try
            FINDATE = False
            Dim APPCON As New CNNCLASS
            APPCON.connection()
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            STRSQL = "select * from FIN_YEAR where convert(datetime,'" & FDATE & "',103) between convert(datetime,sfinyear,103) and convert(datetime,efinyear,103)"
            OBJCOMMAND = New SqlCommand(STRSQL, APPCON.CNN)
            OBJDATAREADER = OBJCOMMAND.ExecuteReader
            If OBJDATAREADER.Read = False Then
                FINDATE = True
            End If
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "FIN YEAR CHECKING")
        End Try
    End Function

    Public Function GETFIRSTWORDCAPTION(ByVal formname As String, ByVal stcode As String, ByVal finyear As Integer) As String
        Try
            GETFIRSTWORDCAPTION = ""
            Dim APPCON As New CNNCLASS
            APPCON.connection()
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()

            STRSQL = "SELECT * FROM STORENAME where StoreDesc is not null "

            If Trim(formname) <> "" Then
                STRSQL = STRSQL & " and Ltrim(rtrim(StoreDesc))='" & Trim(formname) & "'"
            End If
            If Trim(stcode) <> "" Then
                STRSQL = STRSQL & " and Ltrim(rtrim(Store))='" & Trim(stcode) & "'"
            End If

            If Trim(finyear) > 0 Then
                STRSQL = STRSQL & " and finyear='" & Val(finyear) & "'"
            End If

            OBJCOMMAND = New SqlCommand(STRSQL, APPCON.CNN)
            OBJDATAREADER = OBJCOMMAND.ExecuteReader
            While OBJDATAREADER.Read
                GETFIRSTWORDCAPTION = CNULLS(OBJDATAREADER!StoreCode)
            End While
            OBJDATAREADER.Close()
            OBJCOMMAND.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "Firstword Caption")
        End Try
    End Function

    Public Function RightSpace(ByVal B As String, ByVal A As Integer) As String
        RightSpace = ""
        Select Case Len(B)

            Case 1
                RightSpace = Space(A - Len(B)) & B
            Case 2
                RightSpace = Space(A - Len(B)) & B
            Case 3
                RightSpace = Space(A - Len(B)) & B
            Case 4
                RightSpace = Space(A - Len(B)) & B
            Case 5
                RightSpace = Space(A - Len(B)) & B
            Case 6
                RightSpace = Space(A - Len(B)) & B
            Case 7
                RightSpace = Space(A - Len(B)) & B
            Case 8
                RightSpace = Space(A - Len(B)) & B
            Case 9
                RightSpace = Space(A - Len(B)) & B
            Case 10
                RightSpace = Space(A - Len(B)) & B
            Case 11
                RightSpace = Space(A - Len(B)) & B
            Case 12
                RightSpace = Space(A - Len(B)) & B
            Case 13
                RightSpace = Space(A - Len(B)) & B
            Case 14
                RightSpace = Space(A - Len(B)) & B
            Case 15
                RightSpace = Space(A - Len(B)) & B
        End Select
        Return RightSpace
    End Function

    Public Function AutoCodeGen(ByVal Tablename As String, ByVal AutoField As String, ByVal firstword As String, ByVal TNAME As String, ByVal filedLength As Integer, ByVal CNAME As String) As String
        Try
            Dim APPCON As New CNNCLASS
            Dim AutoStr As String = ""
            Dim AutoValue As String = ""
            Dim AutoLen As Integer = 0
            AutoCodeGen = ""
            APPCON.connection()
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            STRSQL = "SELECT max(right( " & AutoField & "," & Val(filedLength) & " )) as CODE FROM " & Tablename & ""

            If Trim(TNAME) <> "" Then
                STRSQL = STRSQL & " WHERE FINYEAR='" & pmFinYear & "'"
            End If
            If Trim(CNAME) <> "" Then
                STRSQL = STRSQL & " AND CMPYCODE='" & CNAME & "'"
            End If
            OBJCOMMAND = New SqlCommand(STRSQL, APPCON.CNN)
            OBJDATAREADER = OBJCOMMAND.ExecuteReader
            While OBJDATAREADER.Read
                AutoValue = CNULL(OBJDATAREADER!CODE)
            End While
            OBJDATAREADER.Close()

            AutoValue = AutoValue + 1
            AutoLen = Len(AutoValue)

            If Val(filedLength) = 10 Then
                If AutoLen = 1 Then
                    AutoCodeGen = "000000000" & AutoValue
                ElseIf AutoLen = 2 Then
                    AutoCodeGen = "00000000" & AutoValue
                ElseIf AutoLen = 3 Then
                    AutoCodeGen = "0000000" & AutoValue
                ElseIf AutoLen = 4 Then
                    AutoCodeGen = "000000" & AutoValue
                ElseIf AutoLen = 5 Then
                    AutoCodeGen = "00000" & AutoValue
                ElseIf AutoLen = 6 Then
                    AutoCodeGen = "0000" & AutoValue
                ElseIf AutoLen = 7 Then
                    AutoCodeGen = "000" & AutoValue
                ElseIf AutoLen = 8 Then
                    AutoCodeGen = "00" & AutoValue
                ElseIf AutoLen = 9 Then
                    AutoCodeGen = "0" & AutoValue
                ElseIf AutoLen = 10 Then
                    AutoCodeGen = AutoValue
                End If
            ElseIf Val(filedLength) = 5 Then
                If AutoLen = 1 Then
                    AutoCodeGen = "0000" & AutoValue
                ElseIf AutoLen = 2 Then
                    AutoCodeGen = "000" & AutoValue
                ElseIf AutoLen = 3 Then
                    AutoCodeGen = "00" & AutoValue
                ElseIf AutoLen = 4 Then
                    AutoCodeGen = "0" & AutoValue
                ElseIf AutoLen = 5 Then
                    AutoCodeGen = AutoValue
                End If
            Else
                AutoCodeGen = ""
            End If

            AutoCodeGen = firstword & AutoCodeGen




            APPCON.CNN.Close()
            OBJDATAREADER.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "AUTO CODE GENERATION")
        End Try
    End Function
    Public Function AutoCodeGenfin(ByVal Tablename As String, ByVal AutoField As String, ByVal firstword As String, ByVal FINYEAR As String, ByVal filedLength As Integer, ByVal StoreName As String, Optional ByVal TRANTYPE As String = "") As String

        Try
            Dim APPCON As New CNNCLASS
            Dim AutoStr As String = ""
            Dim AutoValue As String = ""
            Dim AutoLen As Integer = 0
            AutoCodeGenfin = ""
            APPCON.connection()
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()


            STRSQL = "SELECT max(right( " & AutoField & "," & Val(filedLength) & " )) as CODE FROM " & Tablename & ""

            STRSQL = STRSQL & " WHERE " & AutoField & " IS NOT NULL"

            If Trim(FINYEAR) <> "" Then
                STRSQL = STRSQL & " AND FINYEAR='" & FINYEAR & "'"
            End If

            If StoreName <> "" Then
                STRSQL = STRSQL & " AND STORE_CODE='" & StoreName & "'"
            End If

            If TRANTYPE <> "" Then
                STRSQL = STRSQL & " AND TRANTYPE='" & TRANTYPE & "'"
            End If

            OBJCOMMAND = New SqlCommand(STRSQL, APPCON.CNN)
            OBJDATAREADER = OBJCOMMAND.ExecuteReader
            While OBJDATAREADER.Read
                AutoValue = CNULL(OBJDATAREADER!CODE)
            End While
            OBJDATAREADER.Close()

            AutoValue = AutoValue + 1
            AutoLen = Len(AutoValue)

            If Val(filedLength) = 6 Then
                If AutoLen = 1 Then
                    AutoCodeGenfin = "00000" & AutoValue
                ElseIf AutoLen = 2 Then
                    AutoCodeGenfin = "0000" & AutoValue
                ElseIf AutoLen = 3 Then
                    AutoCodeGenfin = "000" & AutoValue
                ElseIf AutoLen = 4 Then
                    AutoCodeGenfin = "00" & AutoValue
                ElseIf AutoLen = 5 Then
                    AutoCodeGenfin = "0" & AutoValue
                ElseIf AutoLen = 6 Then
                    AutoCodeGenfin = AutoValue
                End If
            ElseIf Val(filedLength) = 5 Then
                If AutoLen = 1 Then
                    AutoCodeGenfin = "0000" & AutoValue
                ElseIf AutoLen = 2 Then
                    AutoCodeGenfin = "000" & AutoValue
                ElseIf AutoLen = 3 Then
                    AutoCodeGenfin = "00" & AutoValue
                ElseIf AutoLen = 4 Then
                    AutoCodeGenfin = "0" & AutoValue
                ElseIf AutoLen = 5 Then
                    AutoCodeGenfin = AutoValue
                End If
            Else
                AutoCodeGenfin = ""
            End If

            AutoCodeGenfin = firstword & AutoCodeGenfin
            APPCON.CNN.Close()
            OBJDATAREADER.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "AUTO CODE GENERATION")
        End Try
    End Function

    Public Function AutoCodeGenStore(ByVal Tablename As String, ByVal AutoField As String, ByVal firstword As String, ByVal FINYEAR As String, ByVal filedLength As Integer, ByVal StoreName As String, Optional ByVal TRANTYPE As String = "") As String

        Try
            Dim APPCON As New CNNCLASS
            Dim AutoStr As String = ""
            Dim AutoValue As String = ""
            Dim AutoLen As Integer = 0
            AutoCodeGenStore = ""
            APPCON.connection()
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            STRSQL = "SELECT max(right( " & AutoField & "," & Val(filedLength) & " )) as CODE FROM " & Tablename & ""
            STRSQL = STRSQL & " WHERE " & AutoField & " IS NOT NULL"
            If Trim(FINYEAR) <> "" Then
                STRSQL = STRSQL & " AND FINYEAR='" & FINYEAR & "'"
            End If

            If StoreName <> "" Then
                STRSQL = STRSQL & " AND STORE_CODE='" & StoreName & "'"
            End If

            If TRANTYPE <> "" Then
                STRSQL = STRSQL & " AND TRANTYPE='" & TRANTYPE & "'"
            End If

            OBJCOMMAND = New SqlCommand(STRSQL, APPCON.CNN)
            OBJDATAREADER = OBJCOMMAND.ExecuteReader
            While OBJDATAREADER.Read
                AutoValue = CNULL(OBJDATAREADER!CODE)
            End While
            OBJDATAREADER.Close()

            AutoValue = AutoValue + 1
            AutoLen = Len(AutoValue)

            If Val(filedLength) = 6 Then
                If AutoLen = 1 Then
                    AutoCodeGenStore = "00000" & AutoValue
                ElseIf AutoLen = 2 Then
                    AutoCodeGenStore = "0000" & AutoValue
                ElseIf AutoLen = 3 Then
                    AutoCodeGenStore = "000" & AutoValue
                ElseIf AutoLen = 4 Then
                    AutoCodeGenStore = "00" & AutoValue
                ElseIf AutoLen = 5 Then
                    AutoCodeGenStore = "0" & AutoValue
                ElseIf AutoLen = 6 Then
                    AutoCodeGenStore = AutoValue
                End If
            ElseIf Val(filedLength) = 5 Then
                If AutoLen = 1 Then
                    AutoCodeGenStore = "0000" & AutoValue
                ElseIf AutoLen = 2 Then
                    AutoCodeGenStore = "000" & AutoValue
                ElseIf AutoLen = 3 Then
                    AutoCodeGenStore = "00" & AutoValue
                ElseIf AutoLen = 4 Then
                    AutoCodeGenStore = "0" & AutoValue
                ElseIf AutoLen = 5 Then
                    AutoCodeGenStore = AutoValue
                End If
            Else
                AutoCodeGenStore = ""
            End If

            AutoCodeGenStore = firstword & AutoCodeGenStore
            APPCON.CNN.Close()
            OBJDATAREADER.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "AUTO CODE GENERATION")
        End Try
    End Function

    Public Function AutoSerchRec(ByVal SNO As String, ByVal filedLength As Integer, ByVal NP As String) As String

        Try
            Dim AutoStr As String = ""
            Dim AutoValue As String = ""
            Dim AutoLen As Integer = 0


            AutoStr = Mid(SNO, 1, 1)
            If NP = "N" Then
                AutoValue = Val(Mid(SNO, 2)) + 1
            Else
                AutoValue = Val(Mid(SNO, 2)) - 1

            End If
            AutoLen = Len(AutoValue)

            If Val(filedLength) = 7 Then
                If AutoLen = 1 Then
                    AutoSerchRec = AutoStr & "00000" & AutoValue
                ElseIf AutoLen = 2 Then
                    AutoSerchRec = AutoStr & "0000" & AutoValue
                ElseIf AutoLen = 3 Then
                    AutoSerchRec = AutoStr & "000" & AutoValue
                ElseIf AutoLen = 4 Then
                    AutoSerchRec = AutoStr & "00" & AutoValue
                ElseIf AutoLen = 5 Then
                    AutoSerchRec = AutoStr & "0" & AutoValue
                ElseIf AutoLen = 6 Then
                    AutoSerchRec = AutoStr & AutoValue
                End If
            ElseIf Val(filedLength) = 6 Then
                If AutoLen = 1 Then
                    AutoSerchRec = AutoStr & "0000" & AutoValue
                ElseIf AutoLen = 2 Then
                    AutoSerchRec = AutoStr & "000" & AutoValue
                ElseIf AutoLen = 3 Then
                    AutoSerchRec = AutoStr & "00" & AutoValue
                ElseIf AutoLen = 4 Then
                    AutoSerchRec = AutoStr & "0" & AutoValue
                ElseIf AutoLen = 5 Then
                    AutoSerchRec = AutoStr & AutoValue
                End If
            Else
                AutoSerchRec = ""
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "SEARCH RECORD")
        End Try
    End Function

    Public Sub DeleteRecord(ByVal TableName As String, ByVal ColName As String, ByVal RValue As String, ByVal TrType As String, Optional ByVal FINYR As Integer = 0, Optional ByVal StoreName As String = "")
        Try
            Dim APPCON5 As New CNNCLASS

            APPCON5.connection()
            If APPCON5.CNN.State = ConnectionState.Open Then APPCON5.CNN.Close()
            APPCON5.CNN.Open()

            Dim strsql1 = "delete from " & TableName & " where " & ColName & " ='" & RValue & "'"

            If Trim(TrType) <> "" Then
                strsql1 = strsql1 & " and TRANTYPE='" & TrType & "'"
            End If

            If Val(FINYR) > 0 Then
                strsql1 = strsql1 & " and FINYEAR='" & FINYR & "'"
            End If

            If Trim(StoreName) <> "" Then
                strsql1 = strsql1 & " and STORE_CODE='" & StoreName & "'"
            End If

            OBJCOMMAND = New SqlCommand(strsql1, APPCON5.CNN)
            OBJCOMMAND.ExecuteNonQuery()
            If APPCON5.CNN.State = ConnectionState.Open Then APPCON5.CNN.Close()

        Catch ex As Exception
            MsgBox(ex.Message, "deleterecode")
        End Try

    End Sub



    Public Function AutoCodeGenNumeric(ByVal Tablename As String, ByVal AutoField As String, ByVal TNAME As String) As Integer
        Dim APPCON As New CNNCLASS
        AutoCodeGenNumeric = 0
        Try
            APPCON.connection()
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            STRSQL = "SELECT max( " & AutoField & ") as CODE FROM " & Tablename & ""
            If Trim(TNAME) <> "" Then
                STRSQL = STRSQL & " where trantype='" & TNAME & "'"
            End If

            OBJCOMMAND = New SqlCommand(STRSQL, APPCON.CNN)
            OBJDATAREADER = OBJCOMMAND.ExecuteReader
            While OBJDATAREADER.Read
                AutoCodeGenNumeric = CNULL(OBJDATAREADER!CODE)
            End While
            OBJDATAREADER.Close()
            AutoCodeGenNumeric = AutoCodeGenNumeric + 1

            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            OBJDATAREADER.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.SystemModal, "AUTO CODE NUMERIC")
        End Try
    End Function
    Public Function GetFirstLastRec(ByVal Tablename As String, ByVal AutoField As String, ByVal filedLength As Integer, ByVal LF As String, Optional ByVal AutoStr As String = "", Optional ByVal TNAME As String = "", Optional ByVal fyear As Integer = 0, Optional ByVal storecode As String = "") As String
        Dim APPCON As New CNNCLASS
        Dim AutoLen As Integer = 0
        Dim AutoValue As Integer = 0

        Try
            APPCON.connection()
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            If Trim(LF) <> "" Then
                If Trim(LF) = "L" Then
                    STRSQL = "SELECT max(right( " & AutoField & "," & filedLength - 1 & ")) as CODE FROM " & Tablename & ""
                ElseIf Trim(LF) = "F" Then
                    STRSQL = "SELECT min(right( " & AutoField & "," & filedLength - 1 & ")) as CODE FROM " & Tablename & ""
                End If
            End If
            If Val(fyear) > 0 Then
                STRSQL = STRSQL & " where finyear='" & Val(fyear) & "'"
            End If
            If Trim(storecode) <> "" Then
                STRSQL = STRSQL & " and CMPYCODE='" & Trim(storecode) & "'"
            End If
            OBJCOMMAND = New SqlCommand(STRSQL, APPCON.CNN)
            OBJDATAREADER = OBJCOMMAND.ExecuteReader
            While OBJDATAREADER.Read
                AutoValue = CNULL(OBJDATAREADER!CODE)
            End While

            OBJDATAREADER.Close()
            AutoLen = AutoValue.ToString.Length
            If Val(filedLength) = 7 Then
                If AutoLen = 1 Then
                    GetFirstLastRec = AutoStr & "00000" & AutoValue
                ElseIf AutoLen = 2 Then
                    GetFirstLastRec = AutoStr & "0000" & AutoValue
                ElseIf AutoLen = 3 Then
                    GetFirstLastRec = AutoStr & "000" & AutoValue
                ElseIf AutoLen = 4 Then
                    GetFirstLastRec = AutoStr & "00" & AutoValue
                ElseIf AutoLen = 5 Then
                    GetFirstLastRec = AutoStr & "0" & AutoValue
                ElseIf AutoLen = 6 Then
                    GetFirstLastRec = AutoStr & AutoValue
                End If
            ElseIf Val(filedLength) = 6 Then
                If AutoLen = 1 Then
                    GetFirstLastRec = AutoStr & "0000" & AutoValue
                ElseIf AutoLen = 2 Then
                    GetFirstLastRec = AutoStr & "000" & AutoValue
                ElseIf AutoLen = 3 Then
                    GetFirstLastRec = AutoStr & "00" & AutoValue
                ElseIf AutoLen = 4 Then
                    GetFirstLastRec = AutoStr & "0" & AutoValue
                ElseIf AutoLen = 5 Then
                    GetFirstLastRec = AutoStr & AutoValue
                End If
            Else
                GetFirstLastRec = ""
            End If




            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            OBJDATAREADER.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.SystemModal, "AUTO CODE NUMERIC")
        End Try
    End Function

    Public Function TRAPKEY(ByVal KCODE As String) As Boolean
        Try
            If (KCODE >= 48 And KCODE <= 57 Or KCODE = 8 Or KCODE = 46) Then
                TRAPKEY = False
            Else
                TRAPKEY = True
            End If
        Catch ex As Exception
        End Try
    End Function
    Public Function TRAPKEYCHAR(ByVal KCODE As String) As Boolean
        Try
            If (KCODE >= 48 And KCODE <= 57) Then
                TRAPKEYCHAR = True
            Else
                TRAPKEYCHAR = False
            End If
        Catch ex As Exception

        End Try
    End Function
    Public Function TRAPKEYSINGLECOURSE(ByVal KCODE As String) As Boolean
        Try
            If (KCODE = 39) Then
                TRAPKEYSINGLECOURSE = True
            Else
                TRAPKEYSINGLECOURSE = False
            End If
        Catch ex As Exception

        End Try
    End Function
    Public Function LowerToUpper(ByVal kAsc As Integer) As Integer
        If kAsc > 96 And kAsc < 123 Then
            LowerToUpper = kAsc - 32
        Else
            LowerToUpper = kAsc
        End If
        Exit Function
    End Function

    Function strReplicate(ByVal str As String, ByVal intD As Integer) As String
        'This fucntion padded "0" after the number to evaluate hundred, thousand and on....
        'using this function you can replicate any Charactor with given string.
        Dim i As Integer
        strReplicate = ""
        For i = 1 To intD
            strReplicate = strReplicate + str
        Next
        Return strReplicate
    End Function
    Function AmtInWord(ByVal Num As Decimal) As String
        'I have created this function for converting amount in indian rupees (INR). 
        'You can manipulate as you wish like decimal setting, Doller (any currency) Prefix.

        Dim strNum As String
        Dim strNumDec As String
        Dim StrWord As String
        strNum = Num

        If InStr(1, strNum, ".") <> 0 Then
            strNumDec = Mid(strNum, InStr(1, strNum, ".") + 1)

            If Len(strNumDec) = 1 Then
                strNumDec = strNumDec + "0"
            End If
            If Len(strNumDec) > 2 Then
                strNumDec = Mid(strNumDec, 1, 2)
            End If

            strNum = Mid(strNum, 1, InStr(1, strNum, ".") - 1)
            StrWord = IIf(CDbl(strNum) = 1, " Rupee ", " Rupees ") + NumToWord(CDbl(strNum)) + IIf(CDbl(strNumDec) > 0, " and Paise" + cWord3(CDbl(strNumDec)), "")
        Else
            StrWord = IIf(CDbl(strNum) = 1, " Rupee ", " Rupees ") + NumToWord(CDbl(strNum))
        End If
        AmtInWord = StrWord & " Only"
        Return AmtInWord
    End Function
    Function NumToWord(ByVal Num As Decimal) As String
        'I divided this function in two part.
        '1. Three or less digit number.
        '2. more than three digit number.
        Dim strNum As String
        Dim StrWord As String
        strNum = Num

        If Len(strNum) <= 3 Then
            StrWord = cWord3(CDbl(strNum))
        Else
            StrWord = cWordG3(CDbl(Mid(strNum, 1, Len(strNum) - 3))) + " " + cWord3(CDbl(Mid(strNum, Len(strNum) - 2)))
        End If
        NumToWord = StrWord
    End Function
    Function cWordG3(ByVal Num As Decimal) As String
        '2. more than three digit number.
        Dim strNum As String = ""
        Dim StrWord As String = ""
        Dim readNum As String = ""
        strNum = Num
        If Len(strNum) Mod 2 <> 0 Then
            readNum = CDbl(Mid(strNum, 1, 1))
            If readNum <> "0" Then
                StrWord = retWord(readNum)
                readNum = CDbl("1" + strReplicate("0", Len(strNum) - 1) + "000")
                StrWord = StrWord + " " + retWord(readNum)
            End If
            strNum = Mid(strNum, 2)
        End If
        While Not Len(strNum) = 0
            readNum = CDbl(Mid(strNum, 1, 2))
            If readNum <> "0" Then
                StrWord = StrWord + " " + cWord3(readNum)
                readNum = CDbl("1" + strReplicate("0", Len(strNum) - 2) + "000")
                StrWord = StrWord + " " + retWord(readNum)
            End If
            strNum = Mid(strNum, 3)
        End While
        cWordG3 = StrWord
        Return cWordG3
    End Function
    Function cWord3(ByVal Num As Decimal) As String
        '1. Three or less digit number.
        Dim strNum As String = ""
        Dim StrWord As String = ""
        Dim readNum As String = ""
        If Num < 0 Then Num = Num * -1
        strNum = Num

        If Len(strNum) = 3 Then
            readNum = CDbl(Mid(strNum, 1, 1))
            StrWord = retWord(readNum) + " Hundred"
            strNum = Mid(strNum, 2, Len(strNum))
        End If

        If Len(strNum) <= 2 Then
            If CDbl(strNum) >= 0 And CDbl(strNum) <= 20 Then
                StrWord = StrWord + " " + retWord(CDbl(strNum))
            Else
                StrWord = StrWord + " " + retWord(CDbl(Mid(strNum, 1, 1) + "0")) + " " + retWord(CDbl(Mid(strNum, 2, 1)))
            End If
        End If

        strNum = CStr(Num)
        cWord3 = StrWord
        Return cWord3
    End Function

    Function retWord(ByVal Num As Decimal) As String
        'This two dimensional array store the primary word convertion of number.
        retWord = ""
        Dim ArrWordList(,) As Object = {{0, ""}, {1, "One"}, {2, "Two"}, {3, "Three"}, {4, "Four"}, _
                                        {5, "Five"}, {6, "Six"}, {7, "Seven"}, {8, "Eight"}, {9, "Nine"}, _
                                        {10, "Ten"}, {11, "Eleven"}, {12, "Twelve"}, {13, "Thirteen"}, {14, "Fourteen"}, _
                                        {15, "Fifteen"}, {16, "Sixteen"}, {17, "Seventeen"}, {18, "Eighteen"}, {19, "Nineteen"}, _
                                        {20, "Twenty"}, {30, "Thirty"}, {40, "Forty"}, {50, "Fifty"}, {60, "Sixty"}, _
                                        {70, "Seventy"}, {80, "Eighty"}, {90, "Ninety"}, {100, "Hundred"}, {1000, "Thousand"}, _
                                        {100000, "Lakh"}, {10000000, "Crore"}}

        Dim i As Integer
        For i = 0 To UBound(ArrWordList)
            If Num = ArrWordList(i, 0) Then
                retWord = ArrWordList(i, 1)
                Exit For
            End If
        Next
        Return retWord
    End Function
End Module
