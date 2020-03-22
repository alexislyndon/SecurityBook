Public Class adminManageUsers
    Dim id As Integer
    Public Sub New(id As Integer)
        Me.id = id
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub adminManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db1DS.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter1.ManageUser(Me.Db1DS.users, id)
        Dim a = Me.Db1DS.users.Rows.Item(0).Item("active")
        If a = 1 Then
            Button2.Text = "Active"
            Button2.BackColor = Color.LightGreen
        Else
            Button2.Text = "Deactivated"
            Button2.BackColor = Color.IndianRed
        End If
        'MsgBox(a)
    End Sub

    Public Sub theformwasclosed() Handles Me.Closed
        ADMIN.AdminUsers1.refresher()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Active" Then
            Try

                Button2.Text = "Deactivated"
                Button2.BackColor = Color.IndianRed
                Me.UsersTableAdapter1.DeactivateUser(id)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        ElseIf Button2.Text = "Deactivated" Then

            Try
                Button2.Text = "Active"
                Button2.BackColor = Color.LightGreen
                Me.UsersTableAdapter1.ActivateUser(id)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each ctrls In Me.Controls
            ctrls.Text = byeSpace(ctrls.Text)
        Next

        Try
            Me.UsersTableAdapter1.UpdateUser(usernamebx.Text, passwordbx.Text, ComboBox1.Text, namebx.Text, id)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class