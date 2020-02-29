Public Class ADMIN
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Dim tem As Point = New Point()

    Dim y1 As Integer = 140
    Dim y2 As Integer = 180
    Dim y3 As Integer = 220
    Dim y4 As Integer = 260



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

    Private Sub ADMIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Visible = True
        tem.X = 10

    End Sub

    Private Sub dashbtn_Click(sender As Object, e As EventArgs) Handles dashbtn.Click
        falsifier()
        tem.Y = Panel1.Location.Y
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        falsifier()
        tem.Y = Panel1.Location.Y
        Timer2.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        falsifier()
        tem.Y = Panel1.Location.Y
        Timer3.Start()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        falsifier()
        tem.Y = Panel1.Location.Y
        Timer4.Start()
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

    Public Sub falsifier()

    End Sub

End Class