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
        Me.VisitorsTableAdapter.View(Me.Db1DS1.Visitors, visitID)
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db1DS.users' table. You can move, or remove it, as needed.
        Me.VisitorsTableAdapter.View(Me.Db1DS.Visitors, visitID)
        Dim dt = Me.VisitorsTableAdapter.getview(visitID)
        Dim god = dt.Rows(0).Item("Guard")
        'Dim god = Db1DS.Tables(0).Rows(0).Item("Guard")
        TextBox13.Text = god
        If gate = "a" Then
            Button1.Visible = False
        Else

        End If
        Me.Text = "Visitor Info"
        'TODO: This line of code loads data into the 'DB1DataSet1.Visitors' table. You can move, or remove it, as needed.

        'TextBox13.Text = god
        'MsgBox(DB1DataSet1.Tables(0).Rows(0).Item("firstname")) 'Db1DS1.Tables(0).Rows(0).Item("Guard")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim checkout As String
        'Me.Db1DS1.users.Rows(0).Item(0)
        'MsgBox(Db1DS.Tables(0).Rows(0).Item("Guard")) 'Guard on Duty

        checkout = MessageBox.Show("Are you sure you want to check out Visitor #" & visitID & vbCrLf &
                     Db1DS.Tables(0).Rows(0).Item("FullName") & vbCrLf &
                     "with Badge Number: " & Db1DS.Tables(0).Rows(0).Item("badge_number") & "?",
                     "Please Confirm Checkout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If checkout = vbYes Then
            Me.VisitorsTableAdapter.CheckOut(gate, visitID)

            MessageBox.Show("Checkout Success." & vbCrLf,
               "Checkout Success.", MessageBoxButtons.OK, MessageBoxIcon.Information
               )
            refreshAll()
            Me.Dispose()
        End If
    End Sub
End Class