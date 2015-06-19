Public Class frmMain

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        End
    End Sub

    Private Sub timerDate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerDate.Tick
        statlblTime.Text = Format(Now, "Long Date") & "  " & TimeOfDay & ""
    End Sub

    Private Sub btnHideUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideUser.Click
        PanelUser.Visible = False
        btnShowUser.Visible = True
    End Sub

    Private Sub btnShowUser_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnShowUser.Click
        PanelUser.Visible = True
        btnShowUser.Visible = False
    End Sub

    Private Sub frmMain_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        PanelUser.Visible = False
        btnShowUser.Visible = True
    End Sub

    Private Sub btnCloseBuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseBuy.Click
        panelBuy.Visible = False
        toolSidebar.Visible = False
    End Sub


    Private Sub btnSBBuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSBBuy.Click
        panelBuy.Visible = True
        panelBuy.Dock = DockStyle.Fill
        panelBuy.BringToFront()
    End Sub

    Private Sub btnSBSell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSBSell.Click
        panelSell.Visible = True
        panelSell.Dock = DockStyle.Fill
        panelSell.BringToFront()
    End Sub

    Private Sub btnCloseSell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseSell.Click
        panelSell.Visible = False
    End Sub

    Private Sub btnCloseTrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseTrade.Click
        panelTrade.Visible = False
    End Sub

    Private Sub btnSBTrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSBTrade.Click
        panelTrade.Visible = True
        panelTrade.Dock = DockStyle.Fill
        panelTrade.BringToFront()
    End Sub

    Private Sub btnSBLayaway_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSBLayaway.Click
        panelLayaway.Visible = True
        panelLayaway.Dock = DockStyle.Fill
        panelLayaway.BringToFront()
    End Sub

    Private Sub btnCloseLayaway_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseLayaway.Click
        panelLayaway.Visible = False
    End Sub

    Private Sub btnHSBuy_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHSBuy.MouseHover
        btnHSBuy.Visible = False
    End Sub

    Private Sub btnHSBuy2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHSBuy2.Click
        toolSidebar.BringToFront()
        toolSidebar.Visible = True
        panelBuy.Visible = True
        panelBuy.Dock = DockStyle.Fill
        panelBuy.BringToFront()
    End Sub

    Private Sub btnHSBuy2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHSBuy2.MouseLeave
        btnHSBuy.Visible = True
    End Sub

    Private Sub btnHSSell_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHSSell.MouseHover
        btnHSSell.Visible = False
    End Sub

    Private Sub btnHSSell2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHSSell2.MouseLeave
        btnHSSell.Visible = True
    End Sub

    Private Sub btnHSTrade_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHSTrade.MouseHover
        btnHSTrade.Visible = False
    End Sub

    Private Sub btnHSTrade2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHSTrade2.MouseLeave
        btnHSTrade.Visible = True
    End Sub

    Private Sub btnHSLayaway_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHSLayaway.MouseHover
        btnHSLayaway.Visible = False
    End Sub

    Private Sub btnHSLayaway2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHSLayaway2.MouseLeave
        btnHSLayaway.Visible = True
    End Sub

    Private Sub btnHSSearch_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHSSearch.MouseHover
        btnHSSearch.Visible = False
    End Sub

    Private Sub btnHSSearch2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHSSearch2.MouseLeave
        btnHSSearch.Visible = True
    End Sub

    Private Sub btnHSOrder_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHSOrder.MouseHover
        btnHSOrder.Visible = False
    End Sub

    Private Sub btnHSOrder2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHSOrder2.MouseLeave
        btnHSOrder.Visible = True
    End Sub

    Private Sub btnHSQuote_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHSQuote.MouseHover
        btnHSQuote.Visible = False
    End Sub

    Private Sub btnHSQuote2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHSQuote2.MouseLeave
        btnHSQuote.Visible = True
    End Sub

    Private Sub btnHSWishlist_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHSWishlist.MouseHover
        btnHSWishlist.Visible = False
    End Sub

    Private Sub btnHSWishlist2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHSWishlist2.MouseLeave
        btnHSWishlist.Visible = True
    End Sub

    Private Sub txtSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.Click
        txtSearch.Text = ""
    End Sub

    Private Sub txtSearch_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.LostFocus
        txtSearch.Text = "SEARCH"
    End Sub

    Private Sub btnCustomerDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomerDetails.Click
        panelBuySearch.Visible = True
        btnCustomerDetails.Visible = False
    End Sub

    Private Sub txtSearchBuy_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchBuy.Click
        txtSearchBuy.Text = ""
    End Sub

    Private Sub panelBuy_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles panelBuy.Click
        txtSearchBuy.Text = "Search Customer"
        panelBuySearch.Visible = False
        btnCustomerDetails.Visible = True
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class