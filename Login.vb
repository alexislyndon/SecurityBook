Public Class Login
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        'passwordbox
        TextBox2.Clear()
        TextBox2.PasswordChar = "*"
        TextBox2.ForeColor = Color.FromArgb(78, 184, 206)
        Panel2.BackColor = Color.FromArgb(78, 184, 206)
        'Label3.Visible = False
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        'username box
        TextBox1.Clear()
        TextBox1.ForeColor = Color.FromArgb(78, 184, 206)
        Panel1.BackColor = Color.FromArgb(78, 184, 206)
        'Label3.Visible = False
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        'USERNAME NO FOCUS box
        If TextBox1.Text = "" Then
            TextBox1.Text = "Username"
            TextBox1.ForeColor = Color.Gray
            Panel1.BackColor = Color.Gray
        End If
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        'PASSWORD NO FOCUS box
        If TextBox2.Text = "" Then
            TextBox2.PasswordChar = ""
            TextBox2.Text = "Password"
            TextBox2.ForeColor = Color.Gray
            Panel2.BackColor = Color.Gray
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Db1DS1.EnforceConstraints = False
        If TextBox1.Text = "Username" Or TextBox2.Text = "Password" Then
            MsgBox("Please fill in your username and password.")
        Else
            Try
                Dim u As String = TextBox1.Text.Trim
                Dim p As String = TextBox2.Text.Trim
                'Dim udt As db1DS.usersDataTable = UsersTableAdapter1.GetDesignationQuery(u, p)
                UsersTableAdapter1.DesignationQuery(Me.Db1DS1.users, u, p)
                Dim id As Integer
                Dim designation, name, uname, gate As String
                id = Me.Db1DS1.users.Rows(0).Item(0)
                designation = Me.Db1DS1.users.Rows(0).Item("designation")
                name = Me.Db1DS1.users.Rows(0).Item("name")
                uname = Me.Db1DS1.users.Rows(0).Item("username")
                gate = Me.Db1DS1.users.Rows(0).Item("designation").Substring(0, 1)



                If designation = "admin" Then
                    'append userid to session and logs
                    'show the admin panel
                    startsession(id, name, uname, gate)
                    ADMIN.Show()
                    Me.Close()
                    logger("Logged in to ADMIN PANEL")

                ElseIf designation = "main" Then
                    startsession(id, name, uname, gate)
                    MAINGATE.Show()
                    Me.Close()
                    logger("Logged in to MAIN GATE PANEL")

                ElseIf designation = "back" Then
                    startsession(id, name, uname, gate)
                    BACKGATE.Show()
                    Me.Close()
                    logger("Logged in to BACK GATE PANEL")

                End If
                Me.Hide()
            Catch ex As Exception
                If ex.Message = "There was no row at position 0." Then

                Else
                    'MsgBox(ex.Message)
                    MsgBox("Wrong username or password. Please try again.")
                End If
            End Try
        End If
    End Sub

    Private Sub closelbl_Click(sender As Object, e As EventArgs) Handles closelbl.Click
        Me.Close()
    End Sub
End Class
