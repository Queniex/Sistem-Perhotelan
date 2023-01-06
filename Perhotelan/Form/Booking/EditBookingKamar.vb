Imports MySql.Data.MySqlClient
Public Class EditBookingKamar
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CbBooking.Text = BookingKamar_.selectedTableBookingNoKamar.ToString()
        CbTamu.Text = BookingKamar_.selectedTableBookingNamaTamu.ToString()
        DtpCheckIn.Value = BookingKamar_.booking.GSCheckIn.ToString()
        DtpCheckOut.Value = BookingKamar_.booking.GSCheckOut.ToString()
        CbStatusKamar.Text = BookingKamar_.booking.GSStatus.ToString()
        LblTotalBayar.Text = BookingKamar_.booking.GSTotal.ToString()
    End Sub
End Class