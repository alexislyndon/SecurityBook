Public Class adminUsers

    Private Sub adminUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UsersTableAdapter.Fill(Db1DS.users)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.UsersTableAdapter.CreateUser(user.Text.Trim, pass.Text.Trim, des.Text.Trim, personname.Text.Trim, 1)
        refresher()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.UsersTableAdapter.Update(Db1DS.users)
        refresher()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As Integer = Db1DS.users.Rows(0).Item(0)
        Me.UsersTableAdapter.DeactivateUser(i)
        refresher()
    End Sub

    Public Sub refresher()
        Me.UsersTableAdapter.Fill(Db1DS.users)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim i As Integer = Db1DS.users.Rows(0).Item(0)
        Me.UsersTableAdapter.ActivateUser(i)
        refresher()
    End Sub
End Class
