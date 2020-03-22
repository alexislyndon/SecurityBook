Public Class addCompany

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.CompanyTableAdapter1.AddCompany(companyname.Text.Trim, address.Text.Trim, super.Text.Trim, phone.Text.Trim)
        MsgBox("Successfully added Company.")
        ADMIN.AdminVIP1.refresher()
        Me.Close()
    End Sub

    Private Sub closelbl_Click(sender As Object, e As EventArgs) 
        Me.Close()
    End Sub

    Private Sub addCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class