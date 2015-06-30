Public Class frmMain

    'Dim buyItemCounter, buySellCounter As Integer

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


    Private Sub btnHSBuy_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHSBuy.MouseHover
        btnHSBuy.Visible = False
    End Sub

    Private Sub btnHSBuy2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHSBuy2.Click
        frmBuyPanel.Show()
    End Sub

    Private Sub btnHSBuy2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHSBuy2.MouseLeave
        btnHSBuy.Visible = True
    End Sub

    Private Sub btnHSSell_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHSSell.MouseHover
        btnHSSell.Visible = False
    End Sub

    Private Sub btnHSSell2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHSSell2.Click
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
    End Sub

    Private Sub txtSearchBuy_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub panelBuy_Click(ByVal sender As Object, ByVal e As System.EventArgs)
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

    Private Sub toolCustomers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolCustomers.Click
        frmCustomers.Show()
    End Sub

#Region "Live Search Filter"
#Region "Accessories Button"
    Private Sub onACC_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles onACC.MouseHover
        onACC.Location = New Point(348, 72)
    End Sub

    Private Sub onACC_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles onACC.MouseLeave
        onACC.Location = New Point(348, 71)
    End Sub

    Private Sub offACC_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles offACC.MouseHover
        offACC.Location = New Point(348, 72)
    End Sub

    Private Sub offACC_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles offACC.MouseLeave
        offACC.Location = New Point(348, 71)
    End Sub
#End Region
#Region "MPC Button"
    Private Sub onMPC_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles onMPC.MouseHover
        onMPC.Location = New Point(495, 72)
    End Sub

    Private Sub onMPC_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles onMPC.MouseLeave
        onMPC.Location = New Point(495, 71)
    End Sub

    Private Sub offMPC_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles offMPC.MouseHover
        offMPC.Location = New Point(495, 72)
    End Sub

    Private Sub offMPC_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles offMPC.MouseLeave
        offMPC.Location = New Point(495, 71)
    End Sub
#End Region
#Region "OPC Button"
    Private Sub onOPC_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles onOPC.MouseHover
        onOPC.Location = New Point(629, 72)
    End Sub

    Private Sub onOPC_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles onOPC.MouseLeave
        onOPC.Location = New Point(629, 71)
    End Sub

    Private Sub offOPC_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles offOPC.MouseHover
        offOPC.Location = New Point(629, 72)
    End Sub

    Private Sub ooffOPC_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles offOPC.MouseLeave
        offOPC.Location = New Point(629, 71)
    End Sub
#End Region
#End Region


    Private Sub btnHSBuy_Click(sender As System.Object, e As System.EventArgs) Handles btnHSBuy.Click

        PublicVariables.buyCounter += 1

        If (PublicVariables.buyCounter = 1) Then
            Dim buyItem1 As New frmBuyPanel
            buyItem1.TopMost = True
            buyItem1.Show()
        ElseIf (PublicVariables.buyCounter = 2) Then
            Dim buyItem2 As New frmBuyPanel
            buyItem2.TopMost = True
            buyItem2.Show()
        ElseIf (PublicVariables.buyCounter = 3) Then
            Dim buyItem3 As New frmBuyPanel
            buyItem3.TopMost = True
            buyItem3.Show()
        ElseIf (PublicVariables.buyCounter = 4) Then
            Dim buyItem4 As New frmBuyPanel
            buyItem4.TopMost = True
            buyItem4.Show()
        ElseIf (PublicVariables.buyCounter = 5) Then
            Dim buyItem5 As New frmBuyPanel
            buyItem5.TopMost = True
            buyItem5.Show()
        Else
            PublicVariables.buyCounter -= 1
        End If
           
    End Sub

    Private Sub btnHSSell_Click(sender As System.Object, e As System.EventArgs) Handles btnHSSell.Click

        PublicVariables.sellCounter += 1

        If (PublicVariables.sellCounter = 1) Then
            Dim sellItem1 As New frmSellPanel
            sellItem1.TopMost = True
            sellItem1.Show()
        ElseIf (PublicVariables.sellCounter = 2) Then
            Dim sellItem2 As New frmSellPanel
            sellItem2.TopMost = True
            sellItem2.Show()
        ElseIf (PublicVariables.sellCounter = 3) Then
            Dim sellItem3 As New frmSellPanel
            sellItem3.TopMost = True
            sellItem3.Show()
        ElseIf (PublicVariables.sellCounter = 4) Then
            Dim sellItem4 As New frmSellPanel
            sellItem4.TopMost = True
            sellItem4.Show()
        ElseIf (PublicVariables.sellCounter = 5) Then
            Dim sellItem5 As New frmSellPanel
            sellItem5.TopMost = True
            sellItem5.Show()
        Else
            PublicVariables.sellCounter -= 1
        End If

    End Sub

    Private Sub menuUserMgt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuUserMgt.Click
        frmUserMgt.Show()
    End Sub
End Class