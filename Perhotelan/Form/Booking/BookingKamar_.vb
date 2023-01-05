Imports Microsoft.VisualBasic.ApplicationServices
Imports Org.BouncyCastle.Utilities
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Public Class BookingKamar_
    Public Shared booking As Booking
    Public Shared selectedTableBookingIdBooking
    Public Shared selectedTableBookingNoKamar
    Public Shared selectedTableBookingNamaTamu
    Public Shared selectedTableBookingCheckIn
    Public Shared selectedTableBookingCheckOut
    Public Shared selectedTableBookingStatus

    Public Shared datas As New List(Of String)
    Public Shared harga As Integer
    Public Shared textnokamar As String
    Public Shared textnamatamu As String
    Private Status As New List(Of String) From {"Reserved", "Check In", "Check Out"}
    Public Sub New(ByVal Username As String, ByVal Email As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        booking = New Booking()
        CbStatusKamar.DataSource = Status
        ReloadDataTableDatabase()

        'DtpCheckIn.Format = DateTimePickerFormat.Custom
        'DtpCheckIn.CustomFormat = "yyyy/MM/dd"
        'DtpCheckOut.Format = DateTimePickerFormat.Custom
        'DtpCheckOut.CustomFormat = "yyyy/MM/dd"

        Dim usn As String = Username
        LblUser.Text = usn.ToUpper()
        LblEmail.Text = Email

        If Not String.IsNullOrEmpty(Login.Users.GSFoto) Then
            PictureBoxBooking.Load(Login.Users.GSFoto)
            PictureBoxBooking.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewBooking.DataSource = booking.GetDataBookingDatabase()
        TxtNamaTamu.Text = textnamatamu
        TxtBoxNoKamar.Text = textnokamar
    End Sub

    Private Sub BookingKamar__Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub BtnNoKamar_Click(sender As Object, e As EventArgs) Handles BtnNoKamar.Click
        PilihKamar.Show()
        Me.Close()
    End Sub

    Private Sub BtnNamaTamu_Click(sender As Object, e As EventArgs) Handles BtnNamaTamu.Click
        PilihTamu.Show()
        Me.Close()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripBtnBooking_Click(sender As Object, e As EventArgs) Handles ToolStripBtnBooking.Click
        Dim main As New Penginapan(Login.Users.GSUserName, Login.Users.GSEmail)
        main.Show()
        Me.Close()
    End Sub

    Private Sub BtnSaveBooking_Click(sender As Object, e As EventArgs) Handles BtnSaveBooking.Click

        Dim chk = booking.CheckTxtKamar(textnokamar)
        Dim count = chk.Count
        Dim cek = booking.CheckTxtTamu(textnamatamu)
        Dim count_ = cek.Count

        If count > 0 Then
            If count_ > 0 Then
                booking.GSCheckIn = DtpCheckIn.Value.ToString("yyyy/MM/dd")
                booking.GSCheckOut = DtpCheckOut.Value.ToString("yyyy/MM/dd")
                booking.GSIdTamu = booking.getIdTamuByNama(textnamatamu)
                booking.GSIdKamar = booking.getIdKamarByNoKamar(textnokamar)
                booking.GSStatus = CbStatusKamar.Text.ToString()

                booking.AddBooking(booking.GSIdTamu,
                                   booking.GSIdKamar,
                                   booking.GSCheckIn,
                                   booking.GSCheckOut,
                                   booking.GSStatus)

                Dim status As String = "Terisi"
                booking.UpdateDataStatusKamarById(booking.GSIdKamar, status)
                textnamatamu = ""
                textnokamar = ""
                TxtBoxNoKamar.Text = ""
                TxtNamaTamu.Text = ""
                CbStatusKamar.Text = "Reserved"
                LblTotalBayar.Text = "Total Bayar"
                DtpCheckIn.Value = DateTime.Today
                DtpCheckOut.Value = DateTime.Today

                ReloadDataTableDatabase()
            Else
                MessageBox.Show("Data Tamu Yang Anda Masukkan Salah")
            End If
        Else
            MessageBox.Show("Data Kamar Yang Anda Masukkan Salah")
        End If
    End Sub
End Class