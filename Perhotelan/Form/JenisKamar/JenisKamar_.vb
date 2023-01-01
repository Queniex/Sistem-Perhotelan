Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Microsoft.VisualBasic.ApplicationServices

Public Class JenisKamar_
    Public Shared JenisKamar As JenisKamar
    Public Shared selectedTableKoleksi
    Public Shared selectedTableKoleksiNama

    Public Sub New(ByVal Username As String, ByVal Email As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        JenisKamar = New JenisKamar()
        ReloadDataTableDatabase()

        Dim usn As String = Username
        LblUser.Text = usn.ToUpper()
        LblEmail.Text = Email

        If Not String.IsNullOrEmpty(Login.Users.GSFoto) Then
            PbUser.Load(Login.Users.GSFoto)
            PbUser.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewJKamar.DataSource = JenisKamar.GetDataKoleksiDatabase()
    End Sub

    Private Sub JenisKamar_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub ToolStripBtnJKamar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnJKamar.Click
        'Dim Penginapan = New Penginapan()
        Dim main As New Penginapan(Login.Users.GSUserName, Login.Users.GSEmail)
        main.Show()
        Me.Close()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        TambahJenisKamar.Show()
        Me.Hide()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim dataSelected As List(Of String) = JenisKamar.GetDataKoleksiById(selectedTableKoleksi)
        Try
            JenisKamar.GSJenis = dataSelected(1)
            JenisKamar.GSHarga = dataSelected(2)

            Dim formUpdate = New EditJenisKamar()
            formUpdate.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Anda belum memilih baris apa pun!")
        End Try
    End Sub

    Private Sub BtnInfo_Click(sender As Object, e As EventArgs) Handles BtnInfo.Click
        Dim dataselected = JenisKamar.GetDataKoleksiById(selectedTableKoleksi)

        Try
            JenisKamar.GSJenis = dataselected(1)
            JenisKamar.GSHarga = dataselected(2)

            'Dim data_koleksi As List(Of String) = JenisKamar.convertStringToKoleksi(dataselected(10))

            'For Each info_tambah In data_koleksi
            '    dataPerpustakaan.GSkategori.Add(info_tambah)
            'Next

            Dim infoTambah = New InfoJenisKamar()
            infoTambah.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Anda belum memilih baris apa pun!")
        End Try

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim dataSelected As List(Of String) = JenisKamar.GetDataKoleksiById(selectedTableKoleksi)
        Try
            JenisKamar.GSJenis = dataSelected(1)
            JenisKamar.GSHarga = dataSelected(2)
            Dim formHapus = New HapusJenisKamar()
            formHapus.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Anda belum memilih baris apa pun!")
        End Try
    End Sub

    Private Sub DataGridViewJKamar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewJKamar.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewJKamar.Rows(index)

        selectedTableKoleksi = selectedRow.Cells(0).Value
        selectedTableKoleksiNama = selectedRow.Cells(1).Value
    End Sub

End Class