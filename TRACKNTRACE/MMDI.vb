Imports System.Data
Public Class MMDI
    Dim APPCON As New CNNCLASS
    Public RETHELPCODE As Object
    Public RETHELPDESC As Object
    Public SRNO As Object
    Public RETQTY As Object
    Public RETSP As Object
    Public FRMTRANTYPE As String
    Public FRMSTRANSFER As String
    Public FRMTABLETYPE As String
    Public FRMTYPE As String
    Public RPTNAME As String = ""
    Public RPTSELFORMULA As String = ""
    Public SearchItemFrom As Boolean = True
    Public PACKTYPE As String = ""
    Public FRMTYPEPAC As String
    Public SaleSerchType As String
    Public DATEFROM As String = ""
    Public DATETO As String = ""
    Public PACKAGENAME As String = "BARCODE PRINTING"
    Private OldWidth As UInteger
    Private OldHeight As UInteger
    Dim PrintOpt As String = "S"
    Dim NOCOP As Integer = 0
    Private Sub USERCREATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USERCREATIONToolStripMenuItem.Click
        USER_CREATION.MdiParent = Me
        USER_CREATION.Show()
    End Sub
    Private Sub USERCREATIONToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USERCREATIONToolStripMenuItem1.Click
        USER_PERMISSION.MdiParent = Me
        USER_PERMISSION.Show()
    End Sub
    Private Sub PRODUCTMASTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRODUCTMASTERToolStripMenuItem.Click
        PRODUCT_MASTER.MdiParent = Me
        PRODUCT_MASTER.Show()
    End Sub
    Private Sub SCANNINGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SCANNINGToolStripMenuItem.Click
        SCANNING.MdiParent = Me
        SCANNING.Show()
    End Sub
    Private Sub SCANNINGREPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SCANNINGREPORTToolStripMenuItem.Click
        DAILY_REPORT.MdiParent = Me
        DAILY_REPORT.Show()
    End Sub
    Private Sub MMDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            OldHeight = CUInt(Screen.PrimaryScreen.Bounds.Height)
            OldWidth = CUInt(Screen.PrimaryScreen.Bounds.Width)
            APPCON.connection()
            If APPCON.CNN.State = ConnectionState.Open Then APPCON.CNN.Close()
            APPCON.CNN.Open()
            APPCON.machineinfo()
            If SysTemUserName <> "ADMIN" Then
                MASTERToolStripMenuItem.Visible = UserRight("Master", "VIEW", SysTemUserName)
                TRANSACTIONToolStripMenuItem.Visible = UserRight("Transaction", "VIEW", SysTemUserName)
                REPORTToolStripMenuItem.Visible = UserRight("Report", "VIEW", SysTemUserName)
            End If
            If SysTemUserName = "ADMIN" Then
                ABCDToolStripMenuItem.Visible = UserRight("Admin", "VIEW", SysTemUserName)
            Else
                ABCDToolStripMenuItem.Visible = False
            End If
            Me.Text = PmCompanyName & "   COMPANY: " & PmStoreDESC & "    System User: " & MAIN.SysTemUserName & "         FINYEAR:   " & pmFinYear & "      Date: " & Format(Date.Now, "dd/MM/yyyy")
        Catch ex As Exception
            MsgBox("MDI LOAD")
        End Try
    End Sub
    Private Sub BOXPACKINGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOXPACKINGToolStripMenuItem.Click
        PACKING.MdiParent = Me
        PACKING.Show()
    End Sub
    Private Sub ORDERFEEDINGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ORDERFEEDINGToolStripMenuItem.Click
        ORDER_FEEDING.MdiParent = Me
        ORDER_FEEDING.Show()
    End Sub
    Private Sub LINEMASTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LINEMASTERToolStripMenuItem.Click
        LINEMASTER.MdiParent = Me
        LINEMASTER.Show()
    End Sub
    Private Sub CUSTOMERMASTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUSTOMERMASTERToolStripMenuItem.Click
        CUSTOMER_MASTER.MdiParent = Me
        CUSTOMER_MASTER.Show()
    End Sub

    Private Sub PALLETCREATEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PALLETCREATEToolStripMenuItem.Click
        PALLET_CREATE.MdiParent = Me
        PALLET_CREATE.Show()
    End Sub
    Private Sub DISPATCHToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DISPATCHToolStripMenuItem.Click
        DISPATCH.MdiParent = Me
        DISPATCH.Show()
    End Sub
    Private Sub INSPECTIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INSPECTIONToolStripMenuItem.Click
        INSPECTION.MdiParent = Me
        INSPECTION.Show()
    End Sub
    Private Sub REPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTToolStripMenuItem.Click
    End Sub
    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
    End Sub
    Private Sub StockTransferToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockTransferToolStripMenuItem.Click
        StockTransfer.MdiParent = Me
        StockTransfer.Show()
    End Sub
    Private Sub MMDI_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class