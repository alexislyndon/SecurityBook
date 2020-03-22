Public Class adminManageUsers
    Dim id As Integer
    Private Sub adminManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db1DS.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter1.Fill(Me.Db1DS.users)

    End Sub

    Public Sub New(id As Integer)
        Me.id = id
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub TextBox1_DoubleClick(sender As Object, e As EventArgs) Handles TextBox1.DoubleClick
        If TextBox1.Text = "Active" Then
            Try
                Me.UsersTableAdapter1.DeactivateUser(id)
                TextBox1.Text = "Deactivated"
                TextBox1.BackColor = Color.IndianRed
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        If TextBox1.Text = "Deactivated" Then
            Try
                Me.UsersTableAdapter1.ActivateUser(id)
                TextBox1.Text = "Active"
                TextBox1.BackColor = Color.LightGreen
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