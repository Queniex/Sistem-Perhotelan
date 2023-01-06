Public Class HapusBukuTamu
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblNoBooking.Text = BookingKamar_.selectedTableBookingIdBooking.ToString()
        LblNamaTamu.Text = BookingKamar_.selectedTableBookingNamaTamu.ToString()
        LblCekin.Text = BookingKamar_.booking.GSCheckIn.ToString()
        Lblcekout.Text = BookingKamar_.booking.GSCheckOut.ToString()
        LblStatusKamar.Text = BookingKamar_.booking.GSStatus.ToString()
        LblTotalBiaya.Text = BukuTamu_.hargaTotal.ToString()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        BookingKamar_.selectedTableBookingNoKamar = ""
        BookingKamar_.selectedTableBookingNamaTamu = ""
        BookingKamar_.textnamatamu = ""
        BookingKamar_.textnokamar = ""

        Dim bk As New BukuTamu_(Login.Users.GSUserName, Login.Users.GSEmail)
        bk.Show()
        Me.Close()
    End Sub

    Private Sub BtnHapusBukuTamu_Click(sender As Object, e As EventArgs) Handles BtnHapusBukuTamu.Click
        BookingKamar_.booking.DeleteDataBookingById(BookingKamar_.selectedTableBookingIdBooking)
        Dim status As String = "Belum Terisi"
        BookingKamar_.booking.UpdateDataStatusKamarById(BookingKamar_.booking.GSIdKamar, status)

        Dim bk As New BukuTamu_(Login.Users.GSUserName, Login.Users.GSEmail)
        bk.Show()
        Me.Close()

        BookingKamar_.selectedTableBookingNoKamar = ""
        BookingKamar_.selectedTableBookingNamaTamu = ""
        BookingKamar_.textnamatamu = ""
        BookingKamar_.textnokamar = ""
    End Sub
End Class