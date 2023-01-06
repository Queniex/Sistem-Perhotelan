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

    Private Sub BtnEditBukuTamu_Click(sender As Object, e As EventArgs) Handles BtnEditBukuTamu.Click
        kamar_lama = BookingKamar_.selectedTableBookingNoKamar.ToString()
        Dim cek = BookingKamar_.booking.CheckTxtTamu(CbTamu.Text)
        Dim count_ = cek.Count

        If count_ > 0 Then

            If CbCheckin.Text <> kamar_lama Then
                status = "Belum Terisi"
                BookingKamar_.booking.UpdateDataStatusKamarById(BookingKamar_.booking.getIdKamarByNoKamar(kamar_lama), status)
                MessageBox.Show(kamar_lama)
            End If

            BookingKamar_.booking.GSCheckIn = DtpCheckIn.Value.ToString("yyyy/MM/dd")
            BookingKamar_.booking.GSCheckOut = DtpCheckOut.Value.ToString("yyyy/MM/dd")
            BookingKamar_.booking.GSIdTamu = BookingKamar_.booking.getIdTamuByNama(CbTamu.Text)
            BookingKamar_.booking.GSIdKamar = BookingKamar_.booking.getIdKamarByNoKamar(CbCheckin.Text)
            BookingKamar_.booking.GSStatus = CbStatusKamar.Text.ToString()

            BookingKamar_.booking.UpdateDataBookingById(BookingKamar_.selectedTableBookingIdBooking,
                                   BookingKamar_.booking.GSIdTamu,
                                   BookingKamar_.booking.GSIdKamar,
                                   BookingKamar_.booking.GSCheckIn,
                                   BookingKamar_.booking.GSCheckOut,
                                   BookingKamar_.booking.GSStatus)

            If String.Compare(BookingKamar_.booking.GSStatus, "Check In") = 0 Then
                status = "Terisi"
                BookingKamar_.booking.UpdateDataStatusKamarById(BookingKamar_.booking.GSIdKamar, status)
            ElseIf String.Compare(BookingKamar_.booking.GSStatus, "Check Out") = 0 Then
                status = "Belum Terisi"
                BookingKamar_.booking.UpdateDataStatusKamarById(BookingKamar_.booking.GSIdKamar, status)
            ElseIf String.Compare(BookingKamar_.booking.GSStatus, "Reserved") = 0 Then
                status = "Terisi"
                BookingKamar_.booking.UpdateDataStatusKamarById(BookingKamar_.booking.GSIdKamar, status)
            End If

            CbStatusKamar.Text = "Reserved"
            LblTotalBayar.Text = "Total Bayar"
            DtpCheckIn.Value = DateTime.Today
            DtpCheckOut.Value = DateTime.Today

            Dim Info = New InfoBukuTamu()
            Info.Show()
            Me.Close()
        Else
            MessageBox.Show("Data Tamu Yang Anda Masukkan Salah")
        End If
    End Sub

    Private Sub BtnEditBukuTamu_Click(sender As Object, e As EventArgs) Handles BtnEditBukuTamu.Click
        kamar_lama = BookingKamar_.selectedTableBookingNoKamar.ToString()
        Dim cek = BookingKamar_.booking.CheckTxtTamu(CbTamu.Text)
        Dim count_ = cek.Count

        If count_ > 0 Then

            If CbCheckin.Text <> kamar_lama Then
                status = "Belum Terisi"
                BookingKamar_.booking.UpdateDataStatusKamarById(BookingKamar_.booking.getIdKamarByNoKamar(kamar_lama), status)
                MessageBox.Show(kamar_lama)
            End If

            BookingKamar_.booking.GSCheckIn = DtpCheckIn.Value.ToString("yyyy/MM/dd")
            BookingKamar_.booking.GSCheckOut = DtpCheckOut.Value.ToString("yyyy/MM/dd")
            BookingKamar_.booking.GSIdTamu = BookingKamar_.booking.getIdTamuByNama(CbTamu.Text)
            BookingKamar_.booking.GSIdKamar = BookingKamar_.booking.getIdKamarByNoKamar(CbCheckin.Text)
            BookingKamar_.booking.GSStatus = CbStatusKamar.Text.ToString()

            BookingKamar_.booking.UpdateDataBookingById(BookingKamar_.selectedTableBookingIdBooking,
                               BookingKamar_.booking.GSIdTamu,
                               BookingKamar_.booking.GSIdKamar,
                               BookingKamar_.booking.GSCheckIn,
                               BookingKamar_.booking.GSCheckOut,
                               BookingKamar_.booking.GSStatus)

            If String.Compare(BookingKamar_.booking.GSStatus, "Check In") = 0 Then
                status = "Terisi"
                BookingKamar_.booking.UpdateDataStatusKamarById(BookingKamar_.booking.GSIdKamar, status)
            ElseIf String.Compare(BookingKamar_.booking.GSStatus, "Check Out") = 0 Then
                status = "Belum Terisi"
                BookingKamar_.booking.UpdateDataStatusKamarById(BookingKamar_.booking.GSIdKamar, status)
            ElseIf String.Compare(BookingKamar_.booking.GSStatus, "Reserved") = 0 Then
                status = "Terisi"
                BookingKamar_.booking.UpdateDataStatusKamarById(BookingKamar_.booking.GSIdKamar, status)
            End If

            CbStatusKamar.Text = "Reserved"
            LblTotalBayar.Text = "Total Bayar"
            DtpCheckIn.Value = DateTime.Today
            DtpCheckOut.Value = DateTime.Today

            Dim Info = New InfoBukuTamu()
            Info.Show()
            Me.Close()
        Else
            MessageBox.Show("Data Tamu Yang Anda Masukkan Salah")
        End If
    End Sub
End Class