Public Class adminDASH
    Private Sub adminDASH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label10.Text = Me.VisitorsTableAdapter1.countinside()
        Label11.Text = Me.VisitorsTableAdapter1.countinside()
    End Sub

End Class
