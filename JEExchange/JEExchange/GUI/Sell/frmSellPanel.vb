Public Class frmSellPanel

    Private Sub btnCloseSell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
    End Sub

    Private Sub btnSearchCus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchCus.Click
        panelSearch.Visible = True
    End Sub

    Private Sub frmSellPanel_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        frmMain.panelHSMenus.Visible = True
        frmMain.panelHSLiveSearch.Visible = True
    End Sub

    Private Sub frmSellPanel_MinimumSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MinimumSizeChanged
        frmMain.panelHSMenus.Visible = True
        frmMain.panelHSLiveSearch.Visible = True
    End Sub
End Class