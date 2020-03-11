Public Class adminVehicles

    Private Sub adminVehicles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.VehiclesTableAdapter.FillwithGuardonDuty(Db1DS.Vehicles)
    End Sub
End Class
