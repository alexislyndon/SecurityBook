Imports System.ComponentModel

Public Class adminVisitors
    Dim entry, exited As String

    Private Sub adminVisitors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.VisitorsTableAdapter.Fill(Me.Db1DS.Visitors) 'CheckedInToday
        Me.VisitorsDataGridView.Sort(Me.VisitorsDataGridView.Columns("DataGridViewTextBoxColumn1"), ListSortDirection.Descending)
    End Sub
    Public Sub refresher()
        Me.VisitorsTableAdapter.Fill(Me.Db1DS.Visitors)
    End Sub

    Private Sub VisitorsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles VisitorsDataGridView.CellDoubleClick
        Dim id As Integer = VisitorsDataGridView.SelectedCells.Item(0).Value
        Dim pv As New PopView(id, Session.s_gate)
        pv.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.VisitorsTableAdapter.Fill(Me.Db1DS.Visitors)
        Clear(Me)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim timefrom As Date = DateTimePicker1.Value
        Dim timeto As Date = DateTimePicker2.Value.AddSeconds(84398)
        Dim entry, exited As String
        'MsgBox(CheckedListBox1.CheckedIndices.Item(0))
        If CheckedListBox1.CheckedIndices.Count = 1 Then
            If CheckedListBox1.CheckedIndices.Item(0) = 0 Then
                entry = "m"
            ElseIf CheckedListBox1.CheckedIndices.Item(0) = 1 Then
                entry = "b"
            End If
        End If
        If CheckedListBox2.CheckedIndices.Count = 1 Then
            If CheckedListBox2.CheckedIndices.Item(0) = 0 Then
                exited = "m"
            ElseIf CheckedListBox2.CheckedIndices.Item(0) = 1 Then
                exited = "b"
            End If
        End If
        For Each ctrls In Me.Controls
            ctrls.Text = byeSpace(ctrls.Text)
        Next
        If v_idbox.Text.Length = 0 Then
            Me.Db1DS.EnforceConstraints = False

            Me.VisitorsTableAdapter.AdvSearch(Me.Db1DS.Visitors, last.Text, first.Text, middle.Text, destination.Text, timefrom, timeto, entry, exited)

        Else
            Me.VisitorsTableAdapter.View(Me.Db1DS.Visitors, v_idbox.Text)

        End If
    End Sub
End Class
