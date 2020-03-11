Public Class adminVisitors
    Private Sub adminVisitors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.VisitorsTableAdapter.Fill(Me.Db1DS.Visitors) 'CheckedInToday
    End Sub
    Public Sub refresher()
        Me.VisitorsTableAdapter.Fill(Me.Db1DS.Visitors)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            Me.VisitorsTableAdapter.Fill(Me.Db1DS.Visitors)
        Else
            Me.VisitorsTableAdapter.Fill(Me.Db1DS.Visitors)
        End If
    End Sub

    Private Sub VisitorsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles VisitorsDataGridView.CellDoubleClick
        Dim id As Integer = VisitorsDataGridView.SelectedCells.Item(0).Value
        Dim pv As New PopView(id, Session.s_gate)
        pv.Show()
    End Sub

End Class
