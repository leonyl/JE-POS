Public Class frmCustomers

    Private Sub btnAddDis_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddDis.MouseHover
        btnAddDis.Visible = False
    End Sub

    Private Sub btnAddEn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddEn.MouseLeave
        btnAddDis.Visible = True
    End Sub

    Private Sub btnCloseDis_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCloseDis.MouseHover
        btnCloseDis.Visible = False
    End Sub

    Private Sub btnCloseEn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCloseEn.MouseLeave
        btnCloseDis.Visible = True
    End Sub

    Private Sub btnEditDis_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditDis.MouseHover
        btnEditDis.Visible = False
    End Sub

    Private Sub btnEditEn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditEn.MouseLeave
        btnEditDis.Visible = True
    End Sub

    Private Sub btnDeleteDis_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDeleteDis.MouseHover
        btnDeleteDis.Visible = False
    End Sub

    Private Sub btnDeleteEn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDeleteEn.MouseLeave
        btnDeleteDis.Visible = True
    End Sub
End Class