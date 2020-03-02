Public Class adminBadges
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As String = ""
        For Each item In ListBox1.Items
            Try
                Me.BadgesTableAdapter1.Insert(item.ToString, 1)
                s += item.ToString + " "
                Me.BadgesTableAdapter1.Fill(Db1DS.Badges)
                MsgBox("Successfully added " & s)
            Catch ex As Exception
                MsgBox("You are trying to add Badges that are already in the Database.")
            End Try
        Next
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            For l_index As Integer = 0 To ListBox1.Items.Count - 1
                If CStr(ListBox1.Items(l_index)) = TextBox1.Text Then
                    TextBox1.Clear()
                    Return
                End If
            Next

            ListBox1.Items.Add(TextBox1.Text.Trim)
            TextBox1.Clear()
            e.Handled = True
        End If
    End Sub

    Private Sub adminBadges_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BadgesTableAdapter1.Fill(Db1DS.Badges)
    End Sub
End Class
