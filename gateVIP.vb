Public Class gateVIP
    Private Sub gateVIP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Me.CompanyloginsTableAdapter1.CompanyIn(TextBox1.Text.Trim, Session.s_gate)
        End If
    End Sub
End Class