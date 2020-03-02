Public Class PopView

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Public visitID As Integer
    Public gate As String

    Public Sub New(visitID As Integer, gate As String)
        Me.visitID = visitID
        Me.gate = gate
        ' This call is required by the designer.
        InitializeComponent()
        Me.VisitorsTableAdapter.View(Me.Db1DS.Visitors, visitID)
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.VisitorsTableAdapter.View(Me.Db1DS.Visitors, visitID)
        Dim god = Db1DS.Visitors.Rows(0).Item("name")
        TextBox13.Text = god
        If gate = "a" Then
            Button1.Visible = False
        Else

        End If
        Me.Text = "Visitor Info"
        'MsgBox(DB1DataSet1.Tables(0).Rows(0).Item("firstname")) 'Db1DS1.Tables(0).Rows(0).Item("Guard")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim checkout As String

        checkout = MessageBox.Show("Are you sure you want to check out Visitor #" & visitID & vbCrLf &
                     Db1DS.Visitors.Rows(0).Item("FullName") & vbCrLf &
                     "with Badge Number: " & Db1DS.Visitors.Rows(0).Item("badge_number") & "?",
                     "Please Confirm Checkout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If checkout = vbYes Then
            Me.VisitorsTableAdapter.CheckOut(gate, visitID)
            Me.BadgesTableAdapter1.ReturnBadge(Db1DS.Visitors.Rows(0).Item("badge_number"))
            MessageBox.Show("Checkout Success." & vbCrLf,
               "Checkout Success.", MessageBoxButtons.OK, MessageBoxIcon.Information
               )
            refreshAll()
            Me.Dispose()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox3.Visible = True
        PictureBox2.Visible = False
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PictureBox3.Visible = False
        PictureBox2.Visible = True
    End Sub
End Class