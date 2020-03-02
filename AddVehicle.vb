Imports System.Text.RegularExpressions
Public Class AddVehicle
    Dim platergx As New Regex("^[a-zA-Z0-9-]+$")
    Dim gtg As Boolean = True
    Private Sub AddVehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.VehiclesTableAdapter.Fill(Db1DS.Vehicles)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each ctrl In Me.Controls
            ctrl.Text = byeSpace(ctrl.Text)
        Next

        gtg = True
        If Not platergx.IsMatch(plate.Text) Then 'plate
            gtg = False
            ErrorProvider1.SetError(plate, "Only letters, numbers, and dashes are allowed. No spaces.")
        End If

        If make.Text = "" Then 'make
            gtg = False
            ErrorProvider1.SetError(make, "Please fill out this field")
        End If

        If model.Text = "" Then 'model
            gtg = False
            ErrorProvider1.SetError(model, "Please fill out this field")
        End If

        If color.Text = "" Then 'color
            gtg = False
            ErrorProvider1.SetError(color, "Please fill out this field")
        End If

        If type.Text = "" Then 'type
            gtg = False
            ErrorProvider1.SetError(type, "Please fill out this field")
        End If

        'If Driver.Text = "" Then 'type
        '    Driver.Text = Nothing
        'End If

        If gtg Then
            Try
                Me.VehiclesTableAdapter.CheckInVehicle(make.Text, model.Text, color.Text, type.Text, plate.Text, 1)
                MsgBox("Successfully Checked in Vehicle!")

                ErrorProvider1.Clear()
                refreshAll()
                Clear(Me.GroupBox1)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Please fill out the form completely and correctly.")
        End If


    End Sub

    Public Sub refresher()
        Me.VehiclesTableAdapter.Fill(Db1DS.Vehicles)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
