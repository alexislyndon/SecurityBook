Public Class serviceproviderUC


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            If Me.Company_MembersTableAdapter1.isentrycodevalid(TextBox1.Text.Trim) = 1 Then
                If Me.CompanyloginsTableAdapter1.iscodeloggedin(TextBox1.Text.Trim) = 1 Then
                    Try
                        Me.CompanyloginsTableAdapter1.CompanyOut(Session.s_gate, TextBox1.Text.Trim)
                        MsgBox("LOG OUT SUCCESS")
                        TextBox1.Clear()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    Try
                        Me.CompanyloginsTableAdapter1.CompanyIn(TextBox1.Text.Trim, Session.s_gate)
                        MsgBox("LOG IN SUCCESS")
                        TextBox1.Clear()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            Else
                MsgBox("Wrong entry code.")
            End If
        End If

    End Sub

End Class
