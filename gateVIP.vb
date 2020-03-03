Public Class gateVIP
    Private Sub gateVIP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
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

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Me.CompanyloginsTableAdapter1.CompanyIn(TextBox1.Text.Trim)
        End If
    End Sub
End Class