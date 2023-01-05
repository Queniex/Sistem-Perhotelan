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

    Public Shared Function getDay(CheckIn As Date, Checkout As Date, JenisKamar As Integer)
        Dim day As Integer = DateDiff(DateInterval.Day, CheckIn, Checkout)
        Dim total As Integer = day * JenisKamar
        Return total
    End Function

    Private Sub DtpCheckOut_ValueChanged(sender As Object, e As EventArgs) Handles DtpCheckOut.ValueChanged
        If DtpCheckOut.Value.Year > DateTime.Today.Year Then

            booking.GSTotal = getDay(DtpCheckIn.Value.Date, DtpCheckOut.Value.Date, harga).ToString()

        ElseIf DtpCheckOut.Value.Year = DateTime.Today.Year Then

            If DtpCheckOut.Value.Month > DateTime.Today.Month Then
                booking.GSTotal = getDay(DtpCheckIn.Value.Date, DtpCheckOut.Value.Date, harga).ToString()

            ElseIf DtpCheckOut.Value.Month = DateTime.Today.Month Then

                If DtpCheckOut.Value.Day > DateTime.Today.Day Then
                    booking.GSTotal = getDay(DtpCheckIn.Value.Date, DtpCheckOut.Value.Date, harga).ToString()

                Else
                    booking.GSTotal = 0
                End If

            ElseIf DtpCheckOut.Value.Month < DateTime.Today.Month Then
                booking.GSTotal = 0
            End If

        ElseIf DtpCheckOut.Value.Year < DateTime.Today.Year Then
            booking.GSTotal = 0
        End If

        LblTotalBayar.Text = booking.GSTotal.ToString()
    End Sub

    Private Sub DataGridViewBooking_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewBooking.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewBooking.Rows(index)

        selectedTableBookingNoKamar = selectedRow.Cells(1).Value
        selectedTableBookingNamaTamu = selectedRow.Cells(0).Value
    End Sub

    Private Sub TxtBoxNoKamar_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxNoKamar.TextChanged
        textnokamar = TxtBoxNoKamar.Text
        Dim chk = booking.CheckTxtKamar2(textnokamar)
        Dim count = chk.Count

        If count > 0 Then
            harga = chk(2)
        End If
    End Sub

    Private Sub TxtNamaTamu_TextChanged(sender As Object, e As EventArgs) Handles TxtNamaTamu.TextChanged
        textnamatamu = TxtNamaTamu.Text
    End Sub

    Private Sub TxtBoxNoKamar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBoxNoKamar.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Hanya Dapat Memasukkan Angka!")
        End If
    End Sub

    Private Sub TxtNamaTamu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNamaTamu.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Karakter Tidak Diketahui")
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim id_kamar As Integer = booking.getIdKamarByNoKamar(selectedTableBookingNoKamar)
        selectedTableBookingIdBooking = booking.getIdBookingByIdKamar(id_kamar)
        Dim dataSelected As List(Of String) = booking.GetDataBookingById(selectedTableBookingIdBooking)
        Dim dataSelected2 As List(Of String) = booking.getHargaKamar(id_kamar)
        Try
            booking.GSIdTamu = dataSelected(1)
            booking.GSIdKamar = dataSelected(2)
            booking.GSCheckIn = dataSelected(3)
            booking.GSCheckOut = dataSelected(4)
            booking.GSStatus = dataSelected(5)
            booking.GSTotal = getDay(Convert.ToDateTime(dataSelected(3)), Convert.ToDateTime(dataSelected(4)), dataSelected2(0)).ToString()

            Dim formUpdate = New EditBookingKamar()
            formUpdate.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Anda belum memilih baris apa pun!")
        End Try
    End Sub

    Private Sub BtnInfo_Click(sender As Object, e As EventArgs) Handles BtnInfo.Click
        Dim id_kamar As Integer = booking.getIdKamarByNoKamar(selectedTableBookingNoKamar)
        selectedTableBookingIdBooking = booking.getIdBookingByIdKamar(id_kamar)
        Dim dataSelected As List(Of String) = booking.GetDataBookingById(selectedTableBookingIdBooking)
        Dim dataSelected2 As List(Of String) = booking.getHargaKamar(id_kamar)

        Try
            booking.GSIdTamu = dataSelected(1)
            booking.GSIdKamar = dataSelected(2)
            booking.GSCheckIn = dataSelected(3)
            booking.GSCheckOut = dataSelected(4)
            booking.GSStatus = dataSelected(5)
            booking.GSTotal = getDay(Convert.ToDateTime(dataSelected(3)), Convert.ToDateTime(dataSelected(4)), dataSelected2(0))

            Dim formInfo = New InfoBookingKamar()
            formInfo.Show()
            Me.Hide()

        Catch ex As Exception
            MsgBox("Anda belum memilih baris apa pun!")
        End Try
    End Sub
End Class