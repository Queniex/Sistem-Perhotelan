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

    Private Sub BtnBatalKamar_Click(sender As Object, e As EventArgs) Handles BtnBatalKamar.Click
        BookingKamar_.selectedTableBookingNoKamar = ""
        BookingKamar_.selectedTableBookingNamaTamu = ""
        BookingKamar_.textnamatamu = ""
        BookingKamar_.textnokamar = ""

        Dim bk As New BookingKamar_(Login.Users.GSUserName, Login.Users.GSEmail)
        bk.Show()
        Me.Close()
    End Sub

    Private Sub BtnEditBookingKamar_Click(sender As Object, e As EventArgs) Handles BtnEditBookingKamar.Click
        Dim cek = BookingKamar_.booking.CheckTxtTamu(CbTamu.Text)
        Dim count_ = cek.Count

        If count_ > 0 Then
            BookingKamar_.booking.GSCheckIn = DtpCheckIn.Value.ToString("yyyy/MM/dd")
            BookingKamar_.booking.GSCheckOut = DtpCheckOut.Value.ToString("yyyy/MM/dd")
            BookingKamar_.booking.GSIdTamu = BookingKamar_.booking.getIdTamuByNama(CbTamu.Text)
            BookingKamar_.booking.GSIdKamar = BookingKamar_.booking.getIdKamarByNoKamar(CbBooking.Text)
            BookingKamar_.booking.GSStatus = CbStatusKamar.Text.ToString()

            BookingKamar_.booking.UpdateDataBookingById(BookingKamar_.selectedTableBookingIdBooking,
                                   BookingKamar_.booking.GSIdTamu,
                                   BookingKamar_.booking.GSIdKamar,
                                   BookingKamar_.booking.GSCheckIn,
                                   BookingKamar_.booking.GSCheckOut,
                                   BookingKamar_.booking.GSStatus)

            Dim status As String = "Terisi"
            BookingKamar_.booking.UpdateDataStatusKamarById(BookingKamar_.booking.GSIdKamar, status)
            CbStatusKamar.Text = "Reserved"
            LblTotalBayar.Text = "Total Bayar"
            DtpCheckIn.Value = DateTime.Today
            DtpCheckOut.Value = DateTime.Today

            Dim Info = New InfoBookingKamar()
            Info.Show()
            Me.Close()
        Else
            MessageBox.Show("Data Tamu Yang Anda Masukkan Salah")
        End If
    End Sub

    Private Sub CbBooking_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Hanya Dapat Memasukkan Angka!")
        End If
    End Sub

    Private Sub CbTamu_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Karakter Tidak Diketahui")
        End If
    End Sub

    Private Sub CbBooking_TextChanged(sender As Object, e As EventArgs) Handles CbBooking.TextChanged
        LblTotalBayar.Text = "Masukkan Ulang Tanggal"
        Dim chk = BookingKamar_.booking.CheckTxtKamar2(CbBooking.Text)
        Dim count = chk.Count

        If count > 0 Then
            BookingKamar_.harga = chk(2)
        End If
    End Sub

    Private Sub DtpCheckOut_ValueChanged(sender As Object, e As EventArgs) Handles DtpCheckOut.ValueChanged
        BookingKamar_.textnokamar = CbBooking.Text
        Dim chk = BookingKamar_.booking.CheckTxtKamar2(BookingKamar_.textnokamar)
        Dim count = chk.Count

        If count > 0 Then
            BookingKamar_.harga = chk(2)
        End If

        If DtpCheckOut.Value.Year > DateTime.Today.Year Then
            BookingKamar_.booking.GSTotal = BookingKamar_.getDay(DtpCheckIn.Value.Date, DtpCheckOut.Value.Date, BookingKamar_.harga).ToString()
            LblTotalBayar.Text = BookingKamar_.booking.GSTotal
        ElseIf DtpCheckOut.Value.Year = DateTime.Today.Year Then

            If DtpCheckOut.Value.Month > DateTime.Today.Month Then
                BookingKamar_.booking.GSTotal = BookingKamar_.getDay(DtpCheckIn.Value.Date, DtpCheckOut.Value.Date, BookingKamar_.harga).ToString()
                LblTotalBayar.Text = BookingKamar_.booking.GSTotal
            ElseIf DtpCheckOut.Value.Month = DateTime.Today.Month Then

                If DtpCheckOut.Value.Day > DateTime.Today.Day Then
                    BookingKamar_.booking.GSTotal = BookingKamar_.getDay(DtpCheckIn.Value.Date, DtpCheckOut.Value.Date, BookingKamar_.harga).ToString()
                    LblTotalBayar.Text = BookingKamar_.booking.GSTotal
                Else
                    LblTotalBayar.Text = 0
                End If

            ElseIf DtpCheckOut.Value.Month < DateTime.Today.Month Then
                LblTotalBayar.Text = 0
            End If

        ElseIf DtpCheckOut.Value.Year < DateTime.Today.Year Then
            LblTotalBayar.Text = 0
        End If

        'LblTotalBayar.Text = BookingKamar_.booking.GSTotal.ToString()
    End Sub
End Class