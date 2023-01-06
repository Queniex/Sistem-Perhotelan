Public Class InfoBookingKamar
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblNoBooking.Text = BookingKamar_.selectedTableBookingIdBooking.ToString()
        LblNamaTamu.Text = BookingKamar_.selectedTableBookingNamaTamu.ToString()
        LblCekin.Text = BookingKamar_.booking.GSCheckIn.ToString()
        Lblcekout.Text = BookingKamar_.booking.GSCheckOut.ToString()
        LblStatusKamar.Text = BookingKamar_.booking.GSStatus.ToString()
        LblTotalBiaya.Text = BookingKamar_.booking.GSTotal.ToString()
    End Sub
End Class