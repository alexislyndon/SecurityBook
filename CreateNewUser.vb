Public Class CreateNewUser
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each ctrls In Me.Controls
            ctrls.Text = byeSpace(ctrls.Text)
        Next
        Try
            Me.UsersTableAdapter1.CreateUser(usernamebx.Text, passwordbx.Text, ComboBox1.Text, namebx.Text, 1)
            MsgBox("Create User: Success!")
            ADMIN.AdminUsers1.refresher()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class