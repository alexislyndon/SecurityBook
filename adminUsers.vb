Public Class adminUsers

    Private Sub adminUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UsersTableAdapter.Fill(Db1DS.users)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'Me.UsersTableAdapter.CreateUser(user.Text.Trim, pass.Text.Trim, des.Text.Trim, personname.Text.Trim, 1)
        refresher()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim i As Integer = Db1DS.users.Rows(0).Item(0)
        Me.UsersTableAdapter.DeactivateUser(i)
        refresher()
    End Sub

    Public Sub refresher()
        Me.UsersTableAdapter.Fill(Db1DS.users)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Dim i As Integer = Db1DS.users.Rows(0).Item(0)
        Me.UsersTableAdapter.ActivateUser(i)
        refresher()
    End Sub

    Private Sub UsersDataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsersDataGridView.CellDoubleClick
        If UsersDataGridView.SelectedCells.Item(0).Value < 1 Then
            Return
        End If

        If UsersDataGridView.RowCount > 0 Then
            Dim id = UsersDataGridView.SelectedCells.Item(0).Value
            Dim amu As New adminManageUsers(id)
            amu.Show()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        CreateNewUser.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If UsersDataGridView.SelectedCells.Item(0).Value < 1 Then
            Return
        End If

        If UsersDataGridView.RowCount > 0 Then
            Dim id = UsersDataGridView.SelectedCells.Item(0).Value
            Dim amu As New adminManageUsers(id)
            amu.Show()
        End If
    End Sub
End Class
