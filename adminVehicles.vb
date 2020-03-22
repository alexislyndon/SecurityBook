Public Class adminVehicles

    Private Sub adminVehicles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.CustomFormat = "MMM - dd - yyyy"
        DateTimePicker2.CustomFormat = "MMM - dd - yyyy"

        Me.VehiclesTableAdapter.FillwithGuardonDuty(Db1DS.Vehicles)
        DateTimePicker1.Value = Me.VehiclesTableAdapter.VehicleEarly()

    End Sub

    Private Sub Filterbtn_Click(sender As Object, e As EventArgs) Handles Filterbtn.Click
        Dim timefrom As Date = DateTimePicker1.Value
        Dim timeto As Date = DateTimePicker2.Value.AddSeconds(84398)

        If idbx.Text.Length = 0 Then
            Me.Db1DS.EnforceConstraints = False

            Me.VehiclesTableAdapter.VehiclesAdvSearch(Me.Db1DS.Vehicles, makebx.Text, modelbx.Text, colorbx.Text, typecbx.Text, platebx.Text, driverbx.Text, timefrom, timeto)

        Else
            Me.VehiclesTableAdapter.VehicleQuerybyID(Me.Db1DS.Vehicles, idbx.Text)

        End If
    End Sub

    Private Sub Resetbtn_Click(sender As Object, e As EventArgs) Handles Resetbtn.Click
        Me.VehiclesTableAdapter.FillwithGuardonDuty(Db1DS.Vehicles)
        DateTimePicker1.Value = Me.VehiclesTableAdapter.VehicleEarly()
        Clear(Me.GroupBox1)
    End Sub
End Class
