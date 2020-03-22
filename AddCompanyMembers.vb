Public Class AddCompanyMembers
    Dim i As Integer
    Public Sub New(id As Integer)
        i = id
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub closelbl_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub AddCompanyMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.CustomFormat = "MMM - dd - yyyy"

        companyid.Text = i
    End Sub

    Private Sub addmember_Click(sender As Object, e As EventArgs) Handles addmember.Click
        Me.Company_MembersTableAdapter1.AddCompanyMember(i, membername.Text.Trim, designation.Text.Trim, entrycode.Text.Trim, DateTimePicker1.Value)
    End Sub
End Class