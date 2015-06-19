Public Class frmSplash

    Private Sub frmSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        timerLOGIN.Start()
        timerLOAD.Start()
    End Sub

    Private Sub timerLOGIN_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerLOGIN.Tick
        ProgressBar1.Visible = True
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            timerLOGIN.Stop()
            frmMain.Show()
            Me.Close()
        End If
    End Sub

    Private Sub timerLOAD_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerLOAD.Tick
        If Me.Opacity <> 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            timerLOAD.Stop()
        End If
    End Sub

End Class