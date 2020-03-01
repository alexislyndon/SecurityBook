Imports System.Text.RegularExpressions
Public Class AddVisitor
    Dim names As New Regex("^[a-zA-z\s]+$")
    Dim phonenumber As New Regex("^\+?[\d]+$")
    Dim tem As Point = New Point()
    Dim uc As Point = New Point()
    Dim x = 62 '62
    'y = 17

    Private Sub checkinbtn_Click(sender As Object, e As EventArgs) Handles checkinbtn.Click

        Dim gtg = True
        For Each ctrls In Me.Controls
            ctrls.Text = byeSpace(ctrls.Text)
        Next

        If Not names.IsMatch(lname.Text) Then 'lastname
            gtg = False
            ErrorProvider1.SetError(lname, "Only Letters and Spaces allowed")
        End If
        If Not names.IsMatch(fname.Text) Then 'firstname
            gtg = False
            ErrorProvider1.SetError(fname, "Only Letters and Spaces allowed")
        End If
        If Not names.IsMatch(mname.Text) Then 'middlename
            gtg = False
            ErrorProvider1.SetError(mname, "Only Letters and Spaces allowed")
        End If
        If sex.SelectedIndex = -1 Then 'sex
            gtg = False
            ErrorProvider1.SetError(sex, "Please Select Sex.")
        End If
        If Not phonenumber.IsMatch(phone.Text) Then 'phone
            gtg = False
            ErrorProvider1.SetError(phone, "Only numbers and/or a '+' at the beginning is allowed.")
        End If
        If dest.Text = "" Then 'destination
            gtg = False
            ErrorProvider1.SetError(dest, "Please fill out Destination Field.")
        End If
        If purp.Text = "" Then 'purpose
            gtg = False
            ErrorProvider1.SetError(purp, "Please fill out Purpose Field.")
        End If
        If idsurr.Text = "" Then 'id surrendered
            gtg = False
            ErrorProvider1.SetError(idsurr, "Please fill out this Field.")
        End If
        If badge.Text = "" Then 'badge
            gtg = False
            ErrorProvider1.SetError(badge, "Please fill out this Field.")
        End If


        If gtg Then
            Try
                Me.VisitorsTableAdapter.CheckIn(fname.Text, mname.Text, lname.Text, sex.Text, "m", dest.Text, purp.Text, badge.SelectedValue, imgtobyte(PictureBox1.Image, False), imgtobyte(PictureBox2.Image, False), imgtobyte(PictureBox3.Image, False), idsurr.Text, phone.Text, 1, 0)
                MsgBox("Successfully Checked in visitor!")
                ErrorProvider1.Clear()
                'hadcapid = False
                'hadcappor = False
                ''hadcapback = False
                'PictureBox1.Image = Image.FromFile("X:\1902\VB.net\Security Logbook\img\portrait.jpg")
                'PictureBox2.Image = Image.FromFile("X:\1902\VB.net\Security Logbook\img\blankid.jpg")
                'PictureBox3.Image = Image.FromFile("X:\1902\VB.net\Security Logbook\img\backside.jpg")

                'maxid = VisitorsTableAdapter.MaxID() + 1
                'v_id.Text = maxid
                refreshAll()
                clear(Me)

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Please fill out the form completely and correctly.")
        End If
    End Sub

    Private Sub AddVisitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tem.Y = 17
        'uc.X = -93
        'uc.Y = 17
        Me.BadgesTableAdapter.AvailableBadges(Me.Db1DS.Badges)
    End Sub

    Private Sub badge_SelectedIndexChanged(sender As Object, e As EventArgs) Handles badge.GotFocus
        Me.BadgesTableAdapter.AvailableBadges(Me.Db1DS.Badges)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox3.Visible = True
        PictureBox2.Visible = False
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PictureBox3.Visible = False
        PictureBox2.Visible = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If tem.X > x Then
            tem.X -= 5
        End If
        If tem.X < x Then
            tem.X += 5
        End If
        If tem.X = x Then
            Timer1.Stop()
        End If

        uclabel.Location = tem
    End Sub

    Public Sub setuc()
        'uclabel.Location = uc
    End Sub
End Class
