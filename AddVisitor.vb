Imports System.Text.RegularExpressions
Public Class AddVisitor
    Dim names As New Regex("^[a-zA-z\s]+$")
    Dim phonenumber As New Regex("^\+?[\d]+$")
    Dim tem As Point = New Point()
    Dim uc As Point = New Point()
    Dim x = 62 '62
    'y = 17
    Public hadcappor As Boolean = False 'had captured a portrait
    Public hadcapid As Boolean = False 'had captured id 
    Public hadcapback As Boolean = False 'had captured id 

    Private Sub checkinbtn_Click(sender As Object, e As EventArgs) Handles checkinbtn.Click

        Dim gtg = True

        For Each ctrls In Me.GroupBox1.Controls
            ctrls.Text = byeSpace(ctrls.Text)
        Next
        For Each ctrls In Me.GroupBox2.Controls
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
                Me.VisitorsTableAdapter.CheckIn(fname.Text, mname.Text, lname.Text, sex.Text, Session.s_gate, dest.Text, purp.Text, badge.SelectedValue, imgtobyte(PictureBox1.Image, hadcappor), imgtobyte(PictureBox2.Image, hadcapid), imgtobyte(PictureBox3.Image, hadcapback), idsurr.Text, phone.Text, Session.s_uid, 0)
                Me.BadgesTableAdapter.TakeBadge(badge.SelectedValue)
                MsgBox("Successfully Checked in visitor!")
                ErrorProvider1.Clear()
                hadcapid = False
                hadcappor = False
                hadcapback = False
                PictureBox1.Image = Nothing
                PictureBox2.Image = Nothing
                PictureBox3.Image = Nothing
                'maxid = VisitorsTableAdapter.MaxID() + 1
                'v_id.Text = maxid
                refreshAll()
                'Clear(Me)
                Clear(Me.GroupBox1)
                Clear(Me.GroupBox2)

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
        Me.BadgesTableAdapter.AvailableBadge(Me.Db1DS.Badges)
    End Sub

    Private Sub badge_SelectedIndexChanged(sender As Object, e As EventArgs) Handles badge.GotFocus
        Me.BadgesTableAdapter.AvailableBadge(Me.Db1DS.Badges)
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

    Private Sub captureID_Click(sender As Object, e As EventArgs) Handles capid.Click
        'take picture of ID
        PictureBox2.Image = Nothing
        Dim cid As New captureID(Me)
        cid.Show()
    End Sub

    Private Sub portrait_Click(sender As Object, e As EventArgs) Handles capportrait.Click
        'take picture of person
        PictureBox1.Image = Nothing
        Dim cp As New capturePortrait(Me)
        cp.Show()
    End Sub

    Public Sub setportraitpic(img As Image)
        PictureBox1.Image = img
    End Sub
    Public Sub setidpic(img As Image)
        PictureBox2.Image = img
    End Sub
    Public Sub setidback(img As Image)
        PictureBox3.Image = img
    End Sub
End Class
