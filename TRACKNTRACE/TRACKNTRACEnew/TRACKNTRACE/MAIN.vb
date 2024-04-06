Option Explicit On
Imports System.Data.SqlClient
Module MAIN
    Public getDefaultPrinterName As String
    'Option Explicit on
    Public ORDNO As String
    Public FNAME As String
    Public CUSTEMAIL As String
    Public CUSTPWD As String
    Public ActivatePPcal As String
    Public SALES5 As String
    Public SALES14 As String
    Public getPrinted As String
    Public dirPath As String = Application.StartupPath & "\EXPORTED REPORTS"
    Public fPath As String = ""
    Public bottomLine As String
    Public ADD1 As String
    Public ADD2 As String
    Public ADD3 As String
    Public PH1 As String
    Public PH2 As String
    Public TINNO As String
    Public ISROLL As String
    Public COMPANYNO As String
    Public EX1 As String
    Public EX2 As String
    Public EX3 As String
    Public EX4 As String
    Public EX5 As String
    Public EX6 As String
    Public EX7 As String
    Public EX8 As String
    Public NOD As Integer
    Public startdate As Date
    Public customercode As String
    Public RefBillTRANno As String
    Public RefBillTRANTYPE As String
    Public pmstrsql As String
    Public pmfrmname As String
    Public PmCompanyName As String
    Public DBCOMPNAME As String
    Public FixedAssets11 As String
    Public RPTSELFORMULA As String
    Public RPTNAME As String
    Public APPNAME As String
    Public FixedAssetVr_no As String
    Public FormDisplay As String
    Public pmConnect As String
    Public g_YearStartDate As Date
    Public g_YearEndDate As Date
    Public pmHostName As String
    Public SystemUser As String
    Public AuthMsg As String
    Public pmDSNNAME As String
    Public sFinYear As String
    Public ICONDIR As String
    Public REPODIR As String
    Public FORMDIR As String
    Public ToolMaxButt As Integer
    Public PmStoreName As String
    Public PmStoreDESC As String
    Public LASTPURCHASE As String
    Public pmFinYear As String
    Public SysTemUserName As String
    Public EMP_Name As String
    Public EMP_ID As String
    Public pmCode As String
    Public pmParti As String
    Public income As Double = 0
    Public expe As Double = 0
    Public isGrpSelected As Boolean = False
    Public VR_NO As String
    Public JOURNALNO As String
    Public BANKRECNO As String
    Public CASHRECNO As String
    Public BANKPAYNO As String
    Public CASHPAYNO As String

    Public serverDateTime As String
    Public PRINTAS As String

    Public pmServer As String
    Public pmServer_New As String
    Public pmDatabase As String
    Public pmDatabaseFixedAsset As String
    Public ROLL As String
    Public pmReportCN As String
    Public pmDbUser As String
    Public pmDbPassWord As String
    Public FIXVRNO As String
    Public mButtClick As String
    Public MsgBoxCaption As String
    Public compremark As String
    Public GVAT1 As Decimal
    Public GVAT2 As Decimal
    Public GVAT3 As Decimal
    Public GVATCAP1 As String
    Public GVATCAP2 As String
    Public GVATCAP3 As String

    Public SGST As Decimal
    Public CGST As Decimal
    Public IGST As Decimal
    Public SGSTCAP As String
    Public CGSTCAP As String
    Public IGSTCAP As String

    Public TNC1 As String
    Public TNC2 As String
    Public TNC3 As String
    Public TNC4 As String
    Public TNC5 As String
    Public TNC6 As String
    Public TNC7 As String
    Public FrmAcc1 As String
    Public INWORD As String
    Public CST2DESC As String
    Public CST5DESC As String
    Public CST12DESC As String
    Public NToW As String
    Public SUBITEM As String
    Public expirydate As Date
End Module
