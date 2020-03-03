Public Class adminVIP

    Private Sub adminVIP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CompanyTableAdapter.Fill(Db1DS.Company)
        'Me.Company_MembersTableAdapter.Fill(Db1DS.Company_Members)
        Me.CompanyloginsTableAdapter.Fill(Db1DS.companylogins)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer = CompanyDataGridView.SelectedRows.Item(0).Cells.Item("DataGridViewTextBoxColumn1").Value
        Me.Company_MembersTableAdapter.companymembers(Db1DS.Company_Members, i)
    End Sub

    Private Sub CompanyDataGridView_RowEnter(sender As Object, e As DataGridViewCellEventArgs)
        Dim i As Integer = CompanyDataGridView.SelectedRows.Item(0).Cells.Item("DataGridViewTextBoxColumn1").Value
        Me.Company_MembersTableAdapter.companymembers(Db1DS.Company_Members, i)
    End Sub

    Private Sub CompanyDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CompanyDataGridView.CellClick
        Dim i As Integer = CompanyDataGridView.SelectedRows.Item(0).Cells.Item("DataGridViewTextBoxColumn1").Value
        Me.Company_MembersTableAdapter.companymembers(Db1DS.Company_Members, i)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles addCompany.Click


    End Sub

    Private Sub addMembers_Click(sender As Object, e As EventArgs) Handles addMembers.Click
        Dim i As Integer = CompanyDataGridView.SelectedRows.Item(0).Cells.Item("DataGridViewTextBoxColumn1").Value
        Dim acm As New AddCompanyMembers(i)
        acm.Show()
    End Sub

    Public Sub refresher()
        Me.CompanyTableAdapter.Fill(Db1DS.Company)
    End Sub
End Class
