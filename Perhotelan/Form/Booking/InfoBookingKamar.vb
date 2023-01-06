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

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        BookingKamar_.selectedTableBookingNoKamar = ""
        BookingKamar_.selectedTableBookingNamaTamu = ""
        BookingKamar_.textnokamar = ""
        BookingKamar_.textnamatamu = ""

        Dim bk As New BookingKamar_(Login.Users.GSUserName, Login.Users.GSEmail)
        bk.Show()
        Me.Close()
    End Sub
End Class