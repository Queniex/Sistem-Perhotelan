Public Class PilihTamu
    Public Shared selectedTableTamuNik
    Public Shared selectedTableTamuNama
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewDataTamu.DataSource = BookingKamar_.booking.getDataTamu()
    End Sub

    Private Sub PilihTamu_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub
End Class