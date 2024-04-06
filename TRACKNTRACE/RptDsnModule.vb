Imports System.Drawing.Printing
Imports System.Drawing.Printing.PaperSize
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.Net.Mail
Module RptDsnModule
    Dim printDoc As New Printing.PrintDocument
    Dim getPrinterName As New PrinterSettings
    Dim crtableLogoninfos As New TableLogOnInfos()
    Dim crtableLogoninfo As New TableLogOnInfo()
    Dim crConnectionInfo As New ConnectionInfo()
    Dim CrTables As Tables
    Dim CrTable As Table
    Dim TableCounter
    Dim doctoprint As New System.Drawing.Printing.PrintDocument()
    Dim objReport As New ReportDocument()
    Dim APPCON As New CNNCLASS
    Dim OBJSQLCOMMAND As New SqlCommand
    Dim OBJDATAREADER As SqlDataReader
    Dim strsql As String = ""
    Dim printer_Name As String = ""
    Dim paper_Size As String = ""
    Dim paper_orient As Integer
    Dim pro As Process
    Friend Function DownloadReport(ByVal sReportName As String)
        Try
            Dim strPath As String = ""
            If Main.EX5 = "ON" Then
                strPath = "E:\TRACKNTRACEnew\TRACKNTRACE\REPORT\" & sReportName
            Else
                strPath = Application.StartupPath & "\REPORT\" & sReportName
            End If
            Return strPath
        Catch ex As Exception
            Dim msgtype As String = MessageBox.Show(ex.Message, "REPORT LOAD", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Function

    Public Function getDefaultPrinter() As String
        Try
            Dim printer As String
            getPrinterName = New PrinterSettings()
            For Each printer In PrinterSettings.InstalledPrinters
                getPrinterName.PrinterName = printer
                If getPrinterName.IsDefaultPrinter Then
                    Main.getDefaultPrinterName = printer
                    Exit For
                Else
                    Main.getDefaultPrinterName = String.Empty
                End If
            Next
        Catch ex As Exception
            MsgBox("Error on Accessing Default Printer...", MsgBoxStyle.Critical)
        End Try
    End Function
    Public Sub reportSetting(Optional ByVal sReportName As String = "")
        APPCON.connection()
        APPCON.machineinfo()
        If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
        APPCON.CNN.Open()
        strsql = "Select printername, papersize, orient FROM REPORT_SETTING_MASTER WHERE ReportName_Show='" & Trim(sReportName) & "' and storecode='" & PmStoreName & "' and HostName='" & APPCON.HsName & "'"
        OBJSQLCOMMAND = New SqlCommand(strsql, APPCON.CNN)
        OBJDATAREADER = OBJSQLCOMMAND.ExecuteReader
        If OBJDATAREADER.HasRows Then
            While OBJDATAREADER.Read
                printer_Name = CNULLS(OBJDATAREADER("printername"))
                paper_Size = CNULLS(OBJDATAREADER("papersize"))
                paper_orient = CNULL(OBJDATAREADER("orient"))
            End While
        Else
            Call getDefaultPrinter()
            printer_Name = Main.getDefaultPrinterName
            paper_Size = "A4"
            paper_orient = 1
        End If

        OBJDATAREADER.Close()
    End Sub

    Friend Function ViewReportDSN(ByVal sReportName As String, Optional ByVal sSelectionFormula As String = "", Optional ByVal param As String = "", Optional ByVal strFormula As String = "", Optional ByVal PRINTYN As String = "", Optional ByVal NOCOP As Integer = 0, Optional ByVal PRINTTYPE As String = "", Optional ByVal PAPERSIZE As String = "") As Boolean
        Try
            PRINTTYPE = Main.PRINTAS
            Dim strPath As String

            Dim strFileName As String
            Dim objReportsParametersDSN As New frmReportViewer
            objReportsParametersDSN.MdiParent = MMDI

            Dim sFileName As String = DownloadReport(sReportName)
            objReport.Load(sFileName)


            objReportsParametersDSN.Refresh()
            objReport.Refresh()

            '=========setting paper size and printer name dyanamically============'

            Call reportSetting(sReportName) 'function call for intilizing printer name, paper size and orientation
            Dim rawKind As Integer = 0
            For i As Integer = 0 To printDoc.PrinterSettings.PaperSizes.Count - 1
                If printDoc.PrinterSettings.PaperSizes(i).PaperName = paper_Size Then
                    rawKind = CInt(printDoc.PrinterSettings.PaperSizes(i).GetType().GetField("kind", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic).GetValue(printDoc.PrinterSettings.PaperSizes(i)))
                    Exit For
                End If
            Next i


            objReport.PrintOptions.PaperSize = rawKind
            objReport.PrintOptions.PrinterName = printer_Name
            'objReport.PrintOptions.PaperOrientation = paper_orient
            '====================================================================='



            objReportsParametersDSN.CrystalReportViewer1.ReportSource = objReport
            'for parametere
            If Trim(param) <> "" Then
                Dim strindex As String = ""
                Dim StrPValue As String = ""

                Dim strBparam As String = ""
                ' Split the string on the backslash character
                Dim parts As String() = param.Split(New Char() {"\"c})
                Dim part As String
                For Each part In parts
                    strBparam = part
                    Dim parts1 As String() = strBparam.Split(New Char() {"&"c})
                    Dim part1 As String
                    Dim iParamcout As Integer = 1
                    For Each part1 In parts1
                        If iParamcout = 1 Then
                            strindex = part1
                        Else
                            StrPValue = part1
                        End If
                        iParamcout = iParamcout + 1
                    Next
                    objReport.SetParameterValue(strindex, StrPValue)
                Next
            End If

            'for formula
            If Trim(strFormula) <> "" Then
                Dim strindex As String = ""
                Dim StrPValue As String = ""
                Dim strBparam As String = ""
                ' Split the string on the backslash character
                Dim parts As String() = strFormula.Split(New Char() {"\"c})
                Dim part As String
                For Each part In parts
                    strBparam = part
                    Dim parts1 As String() = strBparam.Split(New Char() {"&"c})
                    Dim part1 As String
                    Dim iParamcout As Integer = 1
                    For Each part1 In parts1
                        If iParamcout = 1 Then
                            strindex = part1
                        Else
                            StrPValue = part1
                        End If
                        iParamcout = iParamcout + 1
                    Next
                    objReport.DataDefinition.FormulaFields(strindex).Text = "'" & StrPValue & "'"
                Next
            End If

            With crConnectionInfo
                .ServerName = Main.pmDSNNAME
                'If you are connecting to Oracle there is no DatabaseName. Use an empty string. For example, .DatabaseName = ""
                .DatabaseName = Main.pmDSNNAME
                .UserID = pmDbUser
                .Password = pmDbPassWord
            End With


            CrTables = objReport.Database.Tables

            'Loop through each table in the report and apply the LogonInfo information
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)

                'If your DatabaseName is changing at runtime, specify the table location.
                'For example, when you are reporting off of a Northwind database on SQL server you should have the following line of code:
                CrTable.Location = Main.pmDatabase & ".dbo." & CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
            Next


            If sSelectionFormula <> "" Then
                objReport.RecordSelectionFormula = sSelectionFormula
            End If

            Dim fname As String() = sReportName.Split(".")
            If (Not System.IO.Directory.Exists(dirPath)) Then
                System.IO.Directory.CreateDirectory(dirPath)
                fPath = dirPath & "\" & fname(0)
                If PRINTTYPE = "EXCEL" Then
                    objReport.ExportToDisk(ExportFormatType.Excel, fPath & ".xls")
                    Process.Start(fPath & ".xls")
                ElseIf PRINTTYPE = "PDF" Then
                    objReport.ExportToDisk(ExportFormatType.PortableDocFormat, fPath & ".pdf")
                    Process.Start(fPath & ".pdf")
                Else
                    If NOCOP = 0 Then NOCOP = 1
                    objReportsParametersDSN.Show()
                    Application.DoEvents()
                    objReportsParametersDSN.Text = sReportName
                End If
            Else
                fPath = dirPath & "\" & fname(0)
                If PRINTTYPE = "EXCEL" Then
                    objReport.ExportToDisk(ExportFormatType.Excel, fPath & ".xls")
                    Process.Start(fPath & ".xls")
                ElseIf PRINTTYPE = "PDF" Then
                    objReport.ExportToDisk(ExportFormatType.PortableDocFormat, fPath & ".pdf")
                    Process.Start(fPath & ".pdf")
                Else
                    If PRINTYN = "P" Then
                        If NOCOP = 0 Then NOCOP = 1
                        objReportsParametersDSN.Hide()
                        Application.DoEvents()
                        objReportsParametersDSN.Text = sReportName
                    Else
                        If NOCOP = 0 Then NOCOP = 1
                        objReportsParametersDSN.Show()
                        Application.DoEvents()
                        objReportsParametersDSN.Text = sReportName
                    End If
                End If
            End If

            If PRINTYN = "P" Then
                'objReport.ReportOptions.
                objReportsParametersDSN.Visible = False
                objReport.PrintToPrinter(NOCOP, False, 0, 0)
                objReportsParametersDSN.Close()
            Else
                objReportsParametersDSN.BringToFront()
            End If

        Catch ex As Exception
            Dim msgtype As String = MessageBox.Show(ex.Message, "VIEW REPORT", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Function
    Friend Function ViewReportDSN_MAIL(ByVal sReportName As String, Optional ByVal sSelectionFormula As String = "", Optional ByVal param As String = "", Optional ByVal strFormula As String = "", Optional ByVal PRINTYN As String = "", Optional ByVal NOCOP As Integer = 0, Optional ByVal PRINTTYPE As String = "", Optional ByVal PAPERSIZE As String = "", Optional ByVal custEmail As String = "", Optional ByVal BillNO As String = "") As Boolean
        Try
            PRINTTYPE = Main.PRINTAS
            Dim strPath As String

            Dim strFileName As String
            Dim objReportsParametersDSN As New frmReportViewer
            objReportsParametersDSN.MdiParent = MMDI

            Dim sFileName As String = DownloadReport(sReportName)
            objReport.Load(sFileName)


            objReportsParametersDSN.Refresh()
            objReport.Refresh()

            '=========setting paper size and printer name dyanamically============'

            Call reportSetting(sReportName) 'function call for intilizing printer name, paper size and orientation
            Dim rawKind As Integer = 0
            For i As Integer = 0 To printDoc.PrinterSettings.PaperSizes.Count - 1
                If printDoc.PrinterSettings.PaperSizes(i).PaperName = paper_Size Then
                    rawKind = CInt(printDoc.PrinterSettings.PaperSizes(i).GetType().GetField("kind", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic).GetValue(printDoc.PrinterSettings.PaperSizes(i)))
                    Exit For
                End If
            Next i


            objReport.PrintOptions.PaperSize = rawKind
            objReport.PrintOptions.PrinterName = printer_Name
            objReport.PrintOptions.PaperOrientation = paper_orient
            '====================================================================='



            objReportsParametersDSN.CrystalReportViewer1.ReportSource = objReport
            'for parametere
            If Trim(param) <> "" Then
                Dim strindex As String = ""
                Dim StrPValue As String = ""

                Dim strBparam As String = ""
                ' Split the string on the backslash character
                Dim parts As String() = param.Split(New Char() {"\"c})
                Dim part As String
                For Each part In parts
                    strBparam = part
                    Dim parts1 As String() = strBparam.Split(New Char() {"&"c})
                    Dim part1 As String
                    Dim iParamcout As Integer = 1
                    For Each part1 In parts1
                        If iParamcout = 1 Then
                            strindex = part1
                        Else
                            StrPValue = part1
                        End If
                        iParamcout = iParamcout + 1
                    Next
                    objReport.SetParameterValue(strindex, StrPValue)
                Next
            End If

            'for formula
            If Trim(strFormula) <> "" Then
                Dim strindex As String = ""
                Dim StrPValue As String = ""
                Dim strBparam As String = ""
                ' Split the string on the backslash character
                Dim parts As String() = strFormula.Split(New Char() {"\"c})
                Dim part As String
                For Each part In parts
                    strBparam = part
                    Dim parts1 As String() = strBparam.Split(New Char() {"&"c})
                    Dim part1 As String
                    Dim iParamcout As Integer = 1
                    For Each part1 In parts1
                        If iParamcout = 1 Then
                            strindex = part1
                        Else
                            StrPValue = part1
                        End If
                        iParamcout = iParamcout + 1
                    Next
                    objReport.DataDefinition.FormulaFields(strindex).Text = "'" & StrPValue & "'"
                Next
            End If

            With crConnectionInfo
                .ServerName = Main.pmDSNNAME
                'If you are connecting to Oracle there is no DatabaseName. Use an empty string. For example, .DatabaseName = ""
                .DatabaseName = Main.pmDSNNAME
                .UserID = pmDbUser
                .Password = pmDbPassWord
            End With


            CrTables = objReport.Database.Tables

            'Loop through each table in the report and apply the LogonInfo information
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)

                'If your DatabaseName is changing at runtime, specify the table location.
                'For example, when you are reporting off of a Northwind database on SQL server you should have the following line of code:
                CrTable.Location = Main.pmDatabase & ".dbo." & CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
            Next


            If sSelectionFormula <> "" Then
                objReport.RecordSelectionFormula = sSelectionFormula
            End If
            'distfile_path = dirPath & "\" & fname(0) & "_" & rollno & ".pdf"
            'distbakfile_path = dirPath & "\" & fname(0) & "_bak_" & rollno & ".pdf"
            Dim fname As String() = sReportName.Split(".")
            If (Not System.IO.Directory.Exists(dirPath)) Then
                System.IO.Directory.CreateDirectory(dirPath)
                fPath = dirPath & "\" & fname(0) & ".pdf"
                For Each pro In Process.GetProcesses()
                    If pro.ProcessName = "chrome" Then
                        pro.Kill()
                    End If
                Next
                Dim sourcefile_path, distfile_path, distbakfile_path As String
                sourcefile_path = fPath
                objReport.ExportToDisk(ExportFormatType.PortableDocFormat, sourcefile_path)
                distfile_path = dirPath & "\" & fname(0) & "_" & BillNO & ".pdf"
                distbakfile_path = dirPath & "\" & fname(0) & "_bak_" & BillNO & ".pdf"
                If System.IO.File.Exists(distfile_path) Then
                    System.IO.File.Replace(sourcefile_path, distfile_path, distbakfile_path)
                Else
                    System.IO.File.Copy(sourcefile_path, distfile_path)
                End If
                Call sentmail("client@wayinfotechsolutions.com", Main.EX7, "Mail from " & Main.PmCompanyName, distfile_path, "Pradeep")

                'Process.Start(fPath)
            Else
                fPath = dirPath & "\" & fname(0) & ".pdf"
                For Each pro In Process.GetProcesses()
                    If pro.ProcessName = "chrome" Then
                        pro.Kill()
                    End If
                Next
                Dim sourcefile_path, distfile_path, distbakfile_path As String
                sourcefile_path = fPath
                objReport.ExportToDisk(ExportFormatType.PortableDocFormat, sourcefile_path)
                distfile_path = dirPath & "\" & fname(0) & "_" & BillNO & ".pdf"
                distbakfile_path = dirPath & "\" & fname(0) & "_bak_" & BillNO & ".pdf"
                If System.IO.File.Exists(distfile_path) Then
                    System.IO.File.Replace(sourcefile_path, distfile_path, distbakfile_path)
                Else
                    System.IO.File.Copy(sourcefile_path, distfile_path)
                End If
                If Main.EX7 <> "" Then
                    Call sentmail("client@wayinfotechsolutions.com", Main.EX7, "Mail from " & Main.PmCompanyName, distfile_path, "Pradeep")
                End If

            End If
            'If PRINTYN = "P" Then
            '    'objReport.ReportOptions.
            '    objReportsParametersDSN.Visible = False
            '    objReport.PrintToPrinter(NOCOP, False, 0, 0)
            '    objReportsParametersDSN.Close()
            'Else
            '    objReportsParametersDSN.BringToFront()
            'End If

        Catch ex As Exception
            Dim msgtype As String = MessageBox.Show(ex.Message, "VIEW REPORT", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Function
    Private Function sentmail(ByVal fromemail As String, ByVal toemail As String, ByVal subj As String, ByVal Attachments As String, Optional ByVal body As String = "")
        Try
            Dim Smtp_Server As New SmtpClient("smtp.gmail.com")
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("client@wayinfotechsolutions.com", "way1@10#1")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"
            e_mail = New MailMessage()
            e_mail.From = New MailAddress(fromemail)
            e_mail.To.Add(toemail)
            e_mail.Subject = subj
            e_mail.IsBodyHtml = False
            e_mail.Body = body
            'Smtp_Server.Port = 25
            Dim attachment As System.Net.Mail.Attachment
            attachment = New System.Net.Mail.Attachment(Attachments)
            e_mail.Attachments.Add(attachment)
            Smtp_Server.Send(e_mail)
            MsgBox("Mail Sent")
        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try
    End Function
    Public Sub formail()
        ' Try

        '    Dim mailids As String = GETDESC(24, TxtCustCode.Text)

        '    If Trim(mailids) = "" Then
        '        str1mail = "  mail id is not exist" & Environment.NewLine
        '    End If

        '    If mailids = "" Then mailids = "vibhore@ashokafoam.com"

        '    If Trim(mailids) = "" Then Exit Sub

        '    mailids = mailids & ",vibhore@ashokafoam.com,yogesh@ashokafoam.com"


        '    str1mail = "  " & Environment.NewLine
        '    str1mail = str1mail & "  " & Environment.NewLine
        '    str1mail = str1mail & " Dear Sir" & Environment.NewLine
        '    str1mail = str1mail & Environment.NewLine
        '    str1mail = str1mail & "   Pls Find The Enclosed Order" & Environment.NewLine

        '    str1mail = str1mail & "  " & Environment.NewLine


        '    If CMBMODETRANS.Text <> "" Then
        '        str1mail = str1mail & " And Transport Mode is " & CMBMODETRANS.Text
        '    End If

        '    str1mail = str1mail & Environment.NewLine
        '    str1mail = str1mail & Environment.NewLine
        '    str1mail = str1mail & Environment.NewLine

        '    For i As Integer = 1 To Grid1.Rows - 1
        '        If Trim(Grid1.Cell(i, 2).Text) <> "" Then

        '            If Trim(Grid1.Cell(i, 6).Text) <> "" Then
        '                str1mail = str1mail & Space(10) & "NAME - " & Trim(Grid1.Cell(i, 6).Text)
        '            End If

        '            If Trim(Grid1.Cell(i, 7).Text) <> "" Then
        '                str1mail = str1mail & ",  DESIGN NO - " & Trim(Grid1.Cell(i, 7).Text)
        '            End If

        '            If Trim(Grid1.Cell(i, 8).Text) <> "" Then
        '                str1mail = str1mail & ",  SHADE NO - " & Trim(Grid1.Cell(i, 8).Text)
        '            End If

        '            If Trim(Grid1.Cell(i, 9).Text) <> "" Then
        '                str1mail = str1mail & ",  SRNO - " & Trim(Grid1.Cell(i, 9).Text)
        '            End If

        '            str1mail = str1mail & ",  QTY - " & Trim(Grid1.Cell(i, 15).Text) & " " & Trim(Grid1.Cell(i, 16).Text)

        '            str1mail = str1mail & Environment.NewLine
        '        End If
        '    Next i

        '    str1mail = str1mail & Environment.NewLine
        '    str1mail = str1mail & Environment.NewLine
        '    str1mail = str1mail & "   Please send the Material by " & CMDCOURIER.Text & " "
        '    str1mail = str1mail & Environment.NewLine
        '    str1mail = str1mail & Environment.NewLine
        '    str1mail = str1mail & Environment.NewLine
        '    str1mail = str1mail & "Note-: " & TxtCashAmt.Text & Environment.NewLine
        '    str1mail = str1mail & Environment.NewLine
        '    str1mail = str1mail & Environment.NewLine
        '    str1mail = str1mail & " Thanks And Regards" & Environment.NewLine
        '    str1mail = str1mail & " " & SysTemUserName & Environment.NewLine
        '    str1mail = str1mail & "Mob : 8006001112,9720031000,0581-2575764"
        '    str1mail = str1mail & Environment.NewLine
        '    str1mail = str1mail & "ASHOKA FOAM" & Environment.NewLine
        '    str1mail = str1mail & "106/8, Opp -Mission Hospital" & Environment.NewLine
        '    str1mail = str1mail & "Bareilly (UP)-243001" & Environment.NewLine

        '    Dim SmtpServer As New SmtpClient()
        '    Dim mail As New MailMessage()
        '    SmtpServer.Credentials = New Net.NetworkCredential("warehouse@ashokafoam.com", "ashoka123")
        '    SmtpServer.EnableSsl = True
        '    SmtpServer.Port = 587
        '    SmtpServer.Host = "smtp.gmail.com"
        '    mail = New MailMessage()
        '    mail.From = New MailAddress("warehouse@ashokafoam.com")
        '    mail.To.Add(mailids)
        '    mail.Subject = "ORDER NO. " & TxtBillNo.Text
        '    mail.Body = str1mail
        '    SmtpServer.Send(mail)
        '    MsgBox("Your Mail has been Sent Successfully")

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Send Mail Error")
        'End Try
    End Sub
End Module
