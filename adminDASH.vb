Public Class adminDASH
    Private Sub adminDASH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Db1DS1.EnforceConstraints = False
        visin.Text = Me.VisitorsTableAdapter1.countinside()
        vistoday.Text = Me.VisitorsTableAdapter1.VisitorsToday()
        vistotal.Text = Me.VisitorsTableAdapter1.CountAll()

        vehiclein.Text = Me.VehiclesTableAdapter1.VehiclesInside()
        vehicletoday.Text = Me.VehiclesTableAdapter1.VehiclesToday()
        vehicleall.Text = Me.VehiclesTableAdapter1.VehiclesAll()

        mainguard.Text = Me.MainbackTableAdapter1.whoistheguard("main")
        backguard.Text = Me.MainbackTableAdapter1.whoistheguard("back")

    End Sub

    Public Sub refresher()
        Me.Db1DS1.EnforceConstraints = False
        visin.Text = Me.VisitorsTableAdapter1.countinside()
        vistoday.Text = Me.VisitorsTableAdapter1.VisitorsToday()
        vistotal.Text = Me.VisitorsTableAdapter1.CountAll()

        vehiclein.Text = Me.VehiclesTableAdapter1.VehiclesInside()
        vehicletoday.Text = Me.VehiclesTableAdapter1.VehiclesToday()
        vehicleall.Text = Me.VehiclesTableAdapter1.VehiclesAll()

        mainguard.Text = Me.MainbackTableAdapter1.whoistheguard("main")
        backguard.Text = Me.MainbackTableAdapter1.whoistheguard("back")
    End Sub
End Class
