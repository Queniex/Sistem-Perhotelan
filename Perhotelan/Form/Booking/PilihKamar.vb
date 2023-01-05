Public Class PilihKamar
    Public Shared selectedTableKamarID
    Public Shared selectedTableKamarHarga
    Public Shared selectedTableKamarNama
    Public Shared selectedTableKamarJenis
    Public Shared harga As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewDataKamar.DataSource = BookingKamar_.booking.getDataKamar()
    End Sub

    Private Sub PilihKamar_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub
End Class