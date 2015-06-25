Public Class frmNonStocked

    Private Sub frmNonStocked_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtProdCost.Clear()
        txtProdName.Clear()
        txtSaleAmount.Clear()
    End Sub
End Class