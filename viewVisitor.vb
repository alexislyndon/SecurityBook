Public Class viewVisitor
    Private Sub viewVisitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visitors1TableAdapter1.Fill(Db1DS.Visitors1, Nothing) 'CheckedInToday
    End Sub
    Public Sub refresher()
        Me.VisitorsTableAdapter.CheckedInToday(Me.Db1DS.Visitors, Nothing)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'BIG CHECKOUT BUTTON
        Dim selectedrows As DataGridViewSelectedRowCollection = VisitorsDataGridView.SelectedRows
        'For i = 0 To VisitorsDataGridView.SelectedRows.Count()
        '    Dim checkout As String
        '    checkout = CheckOutMsg(selectedrows, DB1DataSet1)
        '    Me.VisitorsTableAdapter1.CHECKOUT(selectedrows.Item(i).Cells.Item(0).Value)
        'Next
        Dim checkout = CheckOutMsg(selectedrows)


        'Dim id As Integer = selectedcells.Item(0).Value


        'Dim checkout As String
        'checkout = CheckOutMsg(selectedcells, DB1DataSet1)

        If checkout = vbYes Then
            For i = 0 To selectedrows.Count() - 1
                Me.VisitorsTableAdapter.CheckOut("m", selectedrows.Item(i).Cells.Item(0).Value) ' m means exited at main gate
                BadgesTableAdapter.ReturnBadge(selectedrows.Item(i).Cells.Item(1).Value)
            Next

            SuccessMsg()
            refreshAll()
            'Else
            '    MsgBox("No one was checked out.")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            Me.VisitorsTableAdapter.CheckedInToday(Me.Db1DS.Visitors, "m") 'm meaning exited already @ Main Gate
        Else
            Me.VisitorsTableAdapter.CheckedInToday(Me.Db1DS.Visitors, Nothing)
        End If
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Visitors1TableAdapter1.Fill(Me.Db1DS.Visitors1, ExitedToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
