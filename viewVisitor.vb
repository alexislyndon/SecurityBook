Public Class viewVisitor
    Private Sub viewVisitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.VisitorsTableAdapter.Fill(Me.Db1DS.Visitors)
    End Sub
End Class
