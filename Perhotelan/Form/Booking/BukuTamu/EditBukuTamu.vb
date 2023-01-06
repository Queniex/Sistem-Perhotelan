Imports MySql.Data.MySqlClient
Public Class EditBukuTamu
    Dim status As String
    Dim kamar_lama As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CbCheckin.Text = BookingKamar_.selectedTableBookingNoKamar.ToString()
        CbTamu.Text = BookingKamar_.selectedTableBookingNamaTamu.ToString()
        DtpCheckIn.Value = BookingKamar_.booking.GSCheckIn.ToString()
        DtpCheckOut.Value = BookingKamar_.booking.GSCheckOut.ToString()
        CbStatusKamar.Text = BookingKamar_.booking.GSStatus.ToString()
        LblTotalBayar.Text = BukuTamu_.hargaTotal.ToString()
    End Sub
End Class