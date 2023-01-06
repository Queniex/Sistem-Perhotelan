Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class BukuTamu_
    Public Shared hargaTotal
    Public Sub New(ByVal Username As String, ByVal Email As String)

        ' This call is required by the designer.
        InitializeComponent()
        ReloadDataTableDatabase()

        ' Add any initialization after the InitializeComponent() call.
        Dim usn As String = Username
        LblUser.Text = usn.ToUpper()
        LblEmail.Text = Email

        If Not String.IsNullOrEmpty(Login.Users.GSFoto) Then
            PictureBoxBukuTamu.Load(Login.Users.GSFoto)
            PictureBoxBukuTamu.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewCheckin.DataSource = BookingKamar_.booking.GetDataCheckinDatabase()
    End Sub

    Private Sub BukuTamu__Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        MessageBox.Show("Tambah Data dilakukan melalui Form Booking!")
        Dim bk As New BookingKamar_(Login.Users.GSUserName, Login.Users.GSEmail)
        bk.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripBtnBooking_Click(sender As Object, e As EventArgs) Handles ToolStripBtnCheckin.Click
        BookingKamar_.selectedTableBookingNoKamar = ""
        BookingKamar_.selectedTableBookingNamaTamu = ""

        Dim bk As New BookingKamar_(Login.Users.GSUserName, Login.Users.GSEmail)
        bk.Show()
        Me.Close()
    End Sub

    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles BtnLogOut.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim id_kamar As Integer = BookingKamar_.booking.getIdKamarByNoKamar(BookingKamar_.selectedTableBookingNoKamar)
        BookingKamar_.selectedTableBookingIdBooking = BookingKamar_.booking.getIdBookingByIdKamar(id_kamar)
        Dim dataSelected = BookingKamar_.booking.GetDataBookingById(BookingKamar_.selectedTableBookingIdBooking)
        Dim dataSelected2 As List(Of String) = BookingKamar_.booking.getHargaKamar(id_kamar)
        Try
            BookingKamar_.booking.GSIdTamu = dataSelected(1)
            BookingKamar_.booking.GSIdKamar = dataSelected(2)
            BookingKamar_.booking.GSCheckIn = dataSelected(3)
            BookingKamar_.booking.GSCheckOut = dataSelected(4)
            BookingKamar_.booking.GSStatus = dataSelected(5)
            hargaTotal = BookingKamar_.getDay(Convert.ToDateTime(dataSelected(3)), Convert.ToDateTime(dataSelected(4)), dataSelected2(0))

            HapusBukuTamu.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Anda belum memilih baris apa pun!")
        End Try
    End Sub

    Private Sub BtnInfo_Click(sender As Object, e As EventArgs) Handles BtnInfo.Click
        Dim id_kamar As Integer = BookingKamar_.booking.getIdKamarByNoKamar(BookingKamar_.selectedTableBookingNoKamar)
        BookingKamar_.selectedTableBookingIdBooking = BookingKamar_.booking.getIdBookingByIdKamar(id_kamar)
        Dim dataSelected As List(Of String) = BookingKamar_.booking.GetDataBookingById(BookingKamar_.selectedTableBookingIdBooking)
        Dim dataSelected2 As List(Of String) = BookingKamar_.booking.getHargaKamar(id_kamar)

        Try
            BookingKamar_.booking.GSIdTamu = dataSelected(1)
            BookingKamar_.booking.GSIdKamar = dataSelected(2)
            BookingKamar_.booking.GSCheckIn = dataSelected(3)
            BookingKamar_.booking.GSCheckOut = dataSelected(4)
            BookingKamar_.booking.GSStatus = dataSelected(5)
            hargaTotal = BookingKamar_.getDay(Convert.ToDateTime(dataSelected(3)), Convert.ToDateTime(dataSelected(4)), dataSelected2(0)).ToString()

            InfoBukuTamu.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Anda belum memilih baris apa pun!")
        End Try
    End Sub

    Private Sub DataGridViewCheckin_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCheckin.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewCheckin.Rows(index)

        BookingKamar_.selectedTableBookingNoKamar = selectedRow.Cells(1).Value
        BookingKamar_.selectedTableBookingNamaTamu = selectedRow.Cells(0).Value
    End Sub

    Private Sub BtnCheckOut_Click(sender As Object, e As EventArgs) Handles BtnCheckOut.Click
        Dim id_kamar As Integer = BookingKamar_.booking.getIdKamarByNoKamar(BookingKamar_.selectedTableBookingNoKamar)
        BookingKamar_.selectedTableBookingIdBooking = BookingKamar_.booking.getIdBookingByIdKamar(id_kamar)
        Dim dataSelected As List(Of String) = BookingKamar_.booking.GetDataBookingById(BookingKamar_.selectedTableBookingIdBooking)
        Dim dataSelected2 As List(Of String) = BookingKamar_.booking.getHargaKamar(id_kamar)

        Try
            BookingKamar_.booking.GSIdTamu = dataSelected(1)
            BookingKamar_.booking.GSIdKamar = dataSelected(2)
            BookingKamar_.booking.GSCheckIn = dataSelected(3)
            BookingKamar_.booking.GSCheckOut = dataSelected(4)
            BookingKamar_.booking.GSStatus = dataSelected(5)
            hargaTotal = BookingKamar_.getDay(Convert.ToDateTime(dataSelected(3)), Convert.ToDateTime(dataSelected(4)), dataSelected2(0))

            CheckOut.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Anda belum memilih baris apa pun!")
        End Try
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim id_kamar As Integer = BookingKamar_.booking.getIdKamarByNoKamar(BookingKamar_.selectedTableBookingNoKamar)
        BookingKamar_.selectedTableBookingIdBooking = BookingKamar_.booking.getIdBookingByIdKamar(id_kamar)
        Dim dataSelected As List(Of String) = BookingKamar_.booking.GetDataBookingById(BookingKamar_.selectedTableBookingIdBooking)
        Dim dataSelected2 As List(Of String) = BookingKamar_.booking.getHargaKamar(id_kamar)
        Try
            BookingKamar_.booking.GSIdTamu = dataSelected(1)
            BookingKamar_.booking.GSIdKamar = dataSelected(2)
            BookingKamar_.booking.GSCheckIn = dataSelected(3)
            BookingKamar_.booking.GSCheckOut = dataSelected(4)
            BookingKamar_.booking.GSStatus = dataSelected(5)
            hargaTotal = BookingKamar_.getDay(Convert.ToDateTime(dataSelected(3)), Convert.ToDateTime(dataSelected(4)), dataSelected2(0)).ToString()

            EditBukuTamu.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Anda belum memilih baris apa pun!")
        End Try
    End Sub
End Class