Public Class frmUserMgt
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub frmUserMgt_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True 'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub frmUserMgt_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub frmUserMgt_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub btnAddDis_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddDis.MouseHover
        btnAddDis.Visible = False
    End Sub

    Private Sub btnAddEn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddEn.Click
        panelAddUser.Visible = True
        lvUsers.Visible = False
    End Sub

    Private Sub btnAddEn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddEn.MouseLeave
        btnAddDis.Visible = True
    End Sub

    Private Sub btnCloseDis_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCloseDis.MouseHover
        btnCloseDis.Visible = False
    End Sub

    Private Sub btnCloseEn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCloseEn.Click
        Me.Hide()
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

    Private Sub btnCloseTop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseTop.Click
        Me.Hide()
    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        lvUsers.Visible = True
        panelAddUser.Visible = False
    End Sub

    Private Sub frmUserMgt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lvUsers.Location = New Point(334, 75)
    End Sub
End Class