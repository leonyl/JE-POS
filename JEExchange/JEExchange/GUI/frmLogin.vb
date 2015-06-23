'Imports Encrypt
'Imports iCam
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmLogin
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim cns As New SqlConnection(ConfigurationManager.ConnectionStrings("databaseConnectionString").ToString())
    Dim pass, user As String
    Dim myCommand, myCommand2 As Data.SqlClient.SqlCommand
    Dim myData, myData2 As Data.SqlClient.SqlDataReader
    Dim adap As Data.SqlClient.SqlDataAdapter

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        End
    End Sub

    Private Sub frmLogin_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True 'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub frmLogin_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub frmLogin_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim decryptme As New Encrypt
        pass = decryptme.Encrypt(txtbxPassword.Text)
        user = txtbxUsername.Text

        Try
            cns.Open()
            myCommand = New Data.SqlClient.SqlCommand("SELECT USER_ID FROM USER_LOGIN_TBL WHERE USER_NAME = '" & user & "' AND PASSWORD = '" & pass & "'", cns)
            myData = myCommand.ExecuteReader()
            If myData.Read() = True Then
                PublicVariables.UserID = myData("USER_ID")
                Me.Hide()
                frmSplash.Show()
            Else
                myData.Close()
                MessageBox.Show("Username and password do not match.")
                Exit Try
            End If
        Catch ex As Exception
            'MessageBox.Show("Error in processing request.")
            MessageBox.Show(ex.Message)
        Finally
            cns.Close()
        End Try
    End Sub
End Class
