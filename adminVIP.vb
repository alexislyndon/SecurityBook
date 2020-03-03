Public Class adminVIP

    Private Sub adminVIP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CompanyTableAdapter.Fill(Db1DS.Company)
        'Me.Company_MembersTableAdapter.Fill(Db1DS.Company_Members)
        'Me.CompanyloginsTableAdapter.Fill(Db1DS.companylogins)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer = CompanyDataGridView.SelectedRows.Item(0).Cells.Item("DataGridViewTextBoxColumn1").Value
        Me.Company_MembersTableAdapter.companymembers(Db1DS.Company_Members, i)

    End Sub

    Private Sub CompanyDataGridView_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles CompanyDataGridView.RowEnter
        Dim i As Integer = CompanyDataGridView.SelectedRows.Item(0).Cells.Item("DataGridViewTextBoxColumn1").Value
        Me.Company_MembersTableAdapter.companymembers(Db1DS.Company_Members, i)
    End Sub
End Class
