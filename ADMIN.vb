﻿Public Class ADMIN
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Dim tem As Point = New Point()
    Dim y1 As Integer = 140
    Dim y2 As Integer = 180
    Dim y3 As Integer = 220
    Dim y4 As Integer = 260
    Dim y5 As Integer = 300
    Dim y6 As Integer = 340
    Dim y7 As Integer = 380



    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown, sidepanel.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp, sidepanel.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove, sidepanel.MouseMove

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
        Label3.Text = Session.s_uname
    End Sub

    Private Sub dashbtn_Click(sender As Object, e As EventArgs) Handles dashbtn.Click
        falsifier()
        If Panel1.Location.Y Mod 5 <> 0 Then
            Dim resetloc As Point
            resetloc.Y = 140
            resetloc.X = 10
            Panel1.Location = resetloc
        End If
        tem.Y = Panel1.Location.Y
        Timer1.Start()
        dashbtn.BackColor = Color.FromArgb(45, 45, 45)
        AdminDASH1.refresher()
        AdminDASH1.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles visitorsbtn.Click
        falsifier()
        tem.Y = Panel1.Location.Y
        Timer2.Start()
        visitorsbtn.BackColor = Color.FromArgb(45, 45, 45)
        AdminVisitors1.Visible = True
        Me.AdminVisitors1.refresher()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles vehiclesbtn.Click
        falsifier()
        tem.Y = Panel1.Location.Y
        Timer3.Start()
        vehiclesbtn.BackColor = Color.FromArgb(45, 45, 45)
        AdminVehicles1.Visible = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles usersbtn.Click
        falsifier()
        tem.Y = Panel1.Location.Y
        Timer4.Start()
        usersbtn.BackColor = Color.FromArgb(45, 45, 45)
        AdminUsers1.Visible = True
        AdminUsers1.refresher()

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
        dashbtn.BackColor = Color.FromArgb(35, 35, 35)
        visitorsbtn.BackColor = Color.FromArgb(35, 35, 35)
        vehiclesbtn.BackColor = Color.FromArgb(35, 35, 35)
        usersbtn.BackColor = Color.FromArgb(35, 35, 35)
        visitorpassbtn.BackColor = Color.FromArgb(35, 35, 35)
        vipbtn.BackColor = Color.FromArgb(35, 35, 35)

        AdminBadges1.Visible = False
        AdminUsers1.Visible = False
        AdminVIP1.Visible = False
        AdminDASH1.Visible = False
        AdminVisitors1.Visible = False
        AdminVehicles1.Visible = False

        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()
        Timer5.Stop()
        Timer6.Stop()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click 'close button
        Dim logout = MessageBox.Show("Log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If logout = vbYes Then
            endsession()
            Login.Show()
            Me.Close()
        End If
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click 'minimize nutton
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles visitorpassbtn.Click
        falsifier()
        tem.Y = Panel1.Location.Y
        Timer5.Start()
        visitorpassbtn.BackColor = Color.FromArgb(45, 45, 45)
        AdminBadges1.Visible = True

    End Sub
    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles vipbtn.Click
        falsifier()
        tem.Y = Panel1.Location.Y
        Timer6.Start()
        vipbtn.BackColor = Color.FromArgb(45, 45, 45)
        AdminVIP1.Visible = True

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

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        If tem.Y > y6 Then
            tem.Y -= 5
        End If
        If tem.Y < y6 Then
            tem.Y += 5
        End If
        If tem.Y = y6 Then
            Timer6.Stop()
        End If
        Panel1.Location = tem
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        If tem.Y > y7 Then
            tem.Y -= 5
        End If
        If tem.Y < y7 Then
            tem.Y += 5
        End If
        If tem.Y = y7 Then
            Timer7.Stop()
        End If
        Panel1.Location = tem
    End Sub

End Class