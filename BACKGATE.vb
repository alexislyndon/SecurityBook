Public Class BACKGATE
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Dim tem As Point = New Point()
    Dim y1 As Integer = 250
    Dim y2 As Integer = 310
    Dim y3 As Integer = 370
    Dim y4 As Integer = 430
    Dim y5 As Integer = 490

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown, sidepanel.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp, sidepanel.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove, sidepanel.MouseDown

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub closelbl_Click(sender As Object, e As EventArgs) Handles closelbl.Click
        Dim logout = MessageBox.Show("Log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If logout = DialogResult.Yes Then
            endsession()
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If tem.Y > y1 Then
            tem.Y -= 5
        End If
        If tem.Y < y1 Then
            tem.Y += 5
        End If
        If tem.Y = y1 Then
            Timer1.Stop()
        End If

        Panel1.Location = tem
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If tem.Y > y2 Then
            tem.Y -= 5
        End If
        If tem.Y < y2 Then
            tem.Y += 5
        End If
        If tem.Y = y2 Then
            Timer2.Stop()
        End If
        Panel1.Location = tem
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If tem.Y > y3 Then
            tem.Y -= 5
        End If
        If tem.Y < y3 Then
            tem.Y += 5
        End If
        If tem.Y = y3 Then
            Timer3.Stop()
        End If
        Panel1.Location = tem
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If tem.Y > y4 Then
            tem.Y -= 5
        End If
        If tem.Y < y4 Then
            tem.Y += 5
        End If
        If tem.Y = y4 Then
            Timer4.Stop()
        End If
        Panel1.Location = tem
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If tem.Y > y5 Then
            tem.Y -= 5
        End If
        If tem.Y < y5 Then
            tem.Y += 5
        End If
        If tem.Y = y5 Then
            Timer5.Stop()
        End If
        Panel1.Location = tem
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tem.Y = Panel1.Location.Y
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'add
        falsifier()
        AddVisitor1.Visible = True
        tem.Y = Panel1.Location.Y
        Timer2.Start()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'view
        falsifier()
        ViewVisitor1.Visible = True
        tem.Y = Panel1.Location.Y
        Timer3.Start()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        tem.Y = Panel1.Location.Y
        Timer4.Start()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        tem.Y = Panel1.Location.Y
        Timer5.Start()
    End Sub

    Private Sub MAINGATE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Visible = True
        tem.X = 3
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        'Label3.Text = Date.Now.ToString("dddd") & vbCrLf & vbCrLf & Date.Now.ToString("dd - MMM - yyyy")
        Label3.Text = Date.Now.ToString("dd MMMM yyyy")

        Label4.Text = Date.Now.ToString("dddd")
        Label1.Text = Date.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles minimizebtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub maximizebtn_Click(sender As Object, e As EventArgs) Handles maximizebtn.Click
        Dim zero As Point = New Point()
        zero.X = 0
        zero.Y = 0
        Me.Location = zero
    End Sub

    Public Sub falsifier()
        AddVisitor1.Visible = False
        ViewVisitor1.Visible = False

    End Sub
End Class