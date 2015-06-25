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

    Private Sub btnSBBuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        panelBuy.Visible = True
        panelBuy.Dock = DockStyle.Fill
        panelBuy.BringToFront()
    End Sub

    Private Sub btnSBSell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub btnSBTrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        panelTrade.Visible = True
        panelTrade.Dock = DockStyle.Fill
        panelTrade.BringToFront()
    End Sub

    Private Sub btnSBLayaway_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub btnHSSell2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHSSell2.Click
        panelHSMenus.Visible = False
        panelHSLiveSearch.Visible = False
        frmSellPanel.MdiParent = Me
        frmSellPanel.Show()
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

    Private Sub btnHSQuote2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHSQuote2.Click
        panelQuote.Visible = True
        panelQuote.Dock = DockStyle.Fill
        panelQuote.BringToFront()
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

    Private Sub btnCustomerDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        panelBuySearch.Visible = True
        btnCusBuyPanel.Visible = False
        boxBuyForm.Location = New Point(306, 51)
    End Sub

    Private Sub txtSearchBuy_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        txtSearchBuy.Text = ""
    End Sub

    Private Sub panelBuy_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        txtSearchBuy.Text = "Search Customer"
        panelBuySearch.Visible = False
        btnCusBuyPanel.Visible = True
        boxBuyForm.Location = New Point(79, 51)
    End Sub

    Private Sub onMPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles onMPC.Click
        onMPC.Visible = False
        offMPC.Visible = True
    End Sub

    Private Sub offMPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles offMPC.Click
        onMPC.Visible = True
        offMPC.Visible = False
    End Sub

    Private Sub onOPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles onOPC.Click
        onOPC.Visible = False
        offOPC.Visible = True
    End Sub

    Private Sub offOPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles offOPC.Click
        onOPC.Visible = True
        offOPC.Visible = False
    End Sub

    Private Sub onACC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles onACC.Click
        onACC.Visible = False
        offACC.Visible = True
    End Sub

    Private Sub offACC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles offACC.Click
        onACC.Visible = True
        offACC.Visible = False
    End Sub

    Private Sub btnShowCusSell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowCusSell.Click
        panelSearchSell.Visible = True
        btnShowCusSell.Visible = False
        boxSellForm.Location = New Point(306, 51)
    End Sub

    Private Sub panelSell_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles panelSell.Click
        txtSearchBuy.Text = "Search Customer"
        panelSearchSell.Visible = False
        btnShowCusSell.Visible = True
        boxSellForm.Location = New Point(79, 51)
    End Sub

    Private Sub onSellSO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles onSellSO.Click
        offSellSO.Visible = True
        onSellSO.Visible = False
    End Sub

    Private Sub offSellSO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles offSellSO.Click
        offSellSO.Visible = False
        onSellSO.Visible = True
    End Sub

    Private Sub onSellDiscounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles onSellDiscounts.Click
        offSellDiscounts.Visible = True
        onSellDiscounts.Visible = False
    End Sub

    Private Sub offSellDiscounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles offSellDiscounts.Click
        offSellDiscounts.Visible = False
        onSellDiscounts.Visible = True
    End Sub

    Private Sub onSellCoupons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles onSellCoupons.Click
        offSellCoupons.Visible = True
        onSellCoupons.Visible = False
    End Sub

    Private Sub offSellCoupons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles offSellCoupons.Click
        offSellCoupons.Visible = False
        onSellCoupons.Visible = True
    End Sub

    Private Sub txtSearchSell_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        txtSearchSell.Text = ""
    End Sub

    Private Sub txtTotal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotal.Click
        If MessageBox.Show("Are you sure you want to edit the price?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            txtTotal.ReadOnly = False
            txtTotal.Focus()
        Else
            txtTotal.ReadOnly = True
            btnSell.Focus()
        End If
    End Sub


    Private Sub onSellReminders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles onSellReminders.Click
        offSellReminders.Visible = True
        onSellReminders.Visible = False
    End Sub

    Private Sub offSellReminders_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles offSellReminders.Click
        offSellReminders.Visible = False
        onSellReminders.Visible = True
    End Sub

    Private Sub btnNonStocked_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNonStocked.Click
        frmNonStocked.ShowDialog()
    End Sub

    Private Sub btnCloseQuote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseQuote.Click
        panelQuote.Visible = False
    End Sub

    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        panelQuote.Visible = True
        panelQuote.Dock = DockStyle.Fill
        panelQuote.BringToFront()
    End Sub

    Private Sub btnCloseBuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseBuy.Click
        panelBuy.Visible = False
    End Sub

    Private Sub btnCusBuyPanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCusBuyPanel.Click
        panelBuySearch.Visible = True
        btnCusBuyPanel.Visible = False
        boxBuyForm.Location = New Point(306, 51)
    End Sub

    Private Sub boxBuyForm_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles boxBuyForm.Click
        panelBuySearch.Visible = False
        btnCusBuyPanel.Visible = True
        boxBuyForm.Location = New Point(79, 51)
    End Sub

    Private Sub btnHideCusDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideCusDetails.Click
        panelSellCusDetails.Visible = False
        btnShowCusSell.Visible = True
        boxSellForm.Location = New Point(79, 51)
    End Sub

    Private Sub btnVDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVDetails.Click
        panelSellCusDetails.Visible = True
        panelSearchSell.Visible = False
        boxSellForm.Location = New Point(-142, 51)
    End Sub

End Class