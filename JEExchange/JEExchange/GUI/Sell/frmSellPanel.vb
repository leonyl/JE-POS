Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmSellPanel
    Dim cns As New SqlConnection(ConfigurationManager.ConnectionStrings("databaseConnectionString").ToString())
    Dim pass, user As String
    Dim myCustomerCmd, myCustomerDetailCmd As Data.SqlClient.SqlCommand
    Dim myData, myData2 As Data.SqlClient.SqlDataReader
    Dim adap As Data.SqlClient.SqlDataAdapter

    Private Sub btnCloseSell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
    End Sub

    Private Sub frmSellPanel_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        frmMain.panelHSMenus.Visible = True
        frmMain.panelHSLiveSearch.Visible = True
    End Sub

    Private Sub frmSellPanel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        boxSellForm.Location = New Point(133, 50)
    End Sub

    Private Sub frmSellPanel_MinimumSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MinimumSizeChanged
        frmMain.panelHSMenus.Visible = True
        frmMain.panelHSLiveSearch.Visible = True
    End Sub

    Private Sub btnSellDisabled_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSellDisabled.MouseHover
        btnSellEnabled.Visible = True
        btnSellDisabled.Visible = False
    End Sub

    Private Sub btnSellEnabled_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSellEnabled.MouseLeave
        btnSellDisabled.Visible = True
        btnSellEnabled.Visible = False
    End Sub

    Private Sub btnAppCredDisabled_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAppCredDisabled.MouseHover
        btnAppCredEnabled.Visible = True
        btnAppCredDisabled.Visible = False
    End Sub

    Private Sub btnAppCredEnabled_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAppCredEnabled.MouseLeave
        btnAppCredDisabled.Visible = True
        btnAppCredEnabled.Visible = False
    End Sub


    Private Sub offSO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles offSO.Click
        onSO.Visible = True
        offSO.Visible = False
    End Sub

    Private Sub onSO_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles onSO.Click
        offSO.Visible = True
        onSO.Visible = False
    End Sub

    Private Sub offDis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles offDis.Click
        onDis.Visible = True
        offDis.Visible = False
    End Sub

    Private Sub onDis_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles onDis.Click
        offDis.Visible = True
        onDis.Visible = False
    End Sub

    Private Sub btnNSDisabled_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNSDisabled.MouseHover
        btnNSEnabled.Visible = True
        btnNSDisabled.Visible = False
    End Sub

    Private Sub btnNSEnabled_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNSEnabled.MouseLeave
        btnNSDisabled.Visible = True
        btnNSEnabled.Visible = False
    End Sub

    Private Sub boxSellForm_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles boxSellForm.Click
        btnSearchCus.Visible = True
        panelSearch.Visible = False
        panelAddCustomer.Visible = False
        boxSellForm.Location = New Point(133, 50)
    End Sub

    Private Sub btnSearchCus2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearchCus2.Click
        boxSellForm.Location = New Point(295, 50)
        panelSearch.Visible = True
        panelSearch.BringToFront()
        btnSearchCus2.Visible = False
        btnSearchCus.Visible = False
    End Sub

    Private Sub btnSearchCus_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearchCus.MouseHover
        btnSearchCus2.Visible = True
        btnSearchCus.Visible = False
    End Sub

    Private Sub btnSearchCus2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearchCus2.MouseLeave
        btnSearchCus2.Visible = False
        btnSearchCus.Visible = True
    End Sub

    Private Sub addcusDisabled_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles addcusDisabled.MouseHover
        addcusEnabled.Visible = True
        addcusDisabled.Visible = False
    End Sub

    Private Sub addcusEnabled_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles addcusEnabled.Click
        panelAddCustomer.Visible = True
        boxSellForm.Location = New Point(627, 45)
    End Sub

    Private Sub addcusEnabled_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles addcusEnabled.MouseLeave
        addcusDisabled.Visible = True
        addcusEnabled.Visible = False
    End Sub

    Private Sub btnCloseCusDisabled_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCloseCusDisabled.MouseHover
        btnCloseCusDisabled.Visible = False
    End Sub

    Private Sub btnCloseCusEnabled_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCloseCusEnabled.MouseLeave
        btnCloseCusDisabled.Visible = True
    End Sub

    Private Sub btnAddCusDisabled_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddCusDisabled.MouseHover
        btnAddCusDisabled.Visible = False
    End Sub

    Private Sub btnAddCusEnabled_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddCusEnabled.MouseLeave
        btnAddCusDisabled.Visible = True
    End Sub


    '06.29.15

    Private Sub frmSellPanel_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        PublicVariables.sellCounter -= 1
    End Sub


    Private Sub btnAddCusEnabled_Click(sender As System.Object, e As System.EventArgs) Handles btnAddCusEnabled.Click

        If TextBox9.Text <> "ID No" Then

            Dim userName = PublicVariables.userName
            Dim idNumber As String = TextBox9.Text
            Dim firstName As String = TextBox3.Text
            Dim lastName As String = TextBox4.Text
            Dim emailAddress As String = TextBox6.Text
            Dim phoneNumber As String = TextBox7.Text
            Dim homeAddress As String = TextBox8.Text
            Dim idCustomer As Integer

            Try
                cns.Open()

                myCustomerCmd = New Data.SqlClient.SqlCommand("INSERT INTO CUSTOMER_TBL (CUSTOMER_CODE, ENTERED_BY, ENTERED_DATE, IS_ACTIVE) VALUES (@CUSTOMER_CODE, @ENTERED_BY, @ENTERED_DATE, @IS_ACTIVE); SELECT CAST(SCOPE_IDENTITY() AS INT);", cns)
                myCustomerCmd.Parameters.Add("@CUSTOMER_CODE", Data.SqlDbType.VarChar, 50).Value = idNumber
                myCustomerCmd.Parameters.Add("@ENTERED_BY", Data.SqlDbType.VarChar, 50).Value = userName
                myCustomerCmd.Parameters.Add("@ENTERED_DATE", Data.SqlDbType.VarChar, 50).Value = DateTime.Now.ToString("yyyy-MM-dd")
                myCustomerCmd.Parameters.Add("@IS_ACTIVE", Data.SqlDbType.Bit).Value = "True"
                idCustomer = Convert.ToInt32(myCustomerCmd.ExecuteScalar())

                myCustomerDetailCmd = New Data.SqlClient.SqlCommand("INSERT INTO CUSTOMER_DETAIL_TBL (CUSTOMER_ID, FIRST_NAME, LAST_NAME, EMAIL, PHONE, ADDRESS) VALUES (@CUSTOMER_ID, @FIRST_NAME, @LAST_NAME, @EMAIL, @PHONE, @ADDRESS)", cns)
                myCustomerDetailCmd.Parameters.Add("@CUSTOMER_ID", Data.SqlDbType.Int).Value = idCustomer
                myCustomerDetailCmd.Parameters.Add("@FIRST_NAME", Data.SqlDbType.VarChar, 200).Value = firstName
                myCustomerDetailCmd.Parameters.Add("@LAST_NAME", Data.SqlDbType.VarChar, 200).Value = lastName
                myCustomerDetailCmd.Parameters.Add("@EMAIL", Data.SqlDbType.VarChar, 200).Value = emailAddress
                myCustomerDetailCmd.Parameters.Add("@PHONE", Data.SqlDbType.VarChar, 200).Value = phoneNumber
                myCustomerDetailCmd.Parameters.Add("@ADDRESS", Data.SqlDbType.VarChar, 200).Value = homeAddress
                myCustomerDetailCmd.ExecuteNonQuery()

                TextBox9.Text = "ID No"
                TextBox3.Text = "First Name"
                TextBox4.Text = "Last Name"
                TextBox6.Text = "Email"
                TextBox7.Text = "Phone"
                TextBox8.Text = "Address"

                addcusDisabled.Visible = True
                addcusEnabled.Visible = False

            Catch ex As Exception
                'MessageBox.Show("Error in processing request.")
                MessageBox.Show(ex.Message)
            Finally
                cns.Close()
            End Try

        End If

    End Sub

    Private Sub btnCloseCusEnabled_Click(sender As System.Object, e As System.EventArgs) Handles btnCloseCusEnabled.Click
        boxSellForm.Location = New Point(133, 50)
        panelSearch.Visible = False
        panelAddCustomer.Visible = False
    End Sub

    Private Sub btnAddCusDisabled_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCusDisabled.Click

    End Sub


End Class