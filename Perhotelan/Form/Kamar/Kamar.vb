Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Kamar
    Public Shared Class_Kamar As Class_Kamar
    Public Shared selectedTableKoleksi
    Public Shared selectedTableKoleksiNama
    Public Shared selectedTableKoleksiJenis
    Public Shared selectedTableKoleksiStatus

    Public Sub New(ByVal Username As String, ByVal Email As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Class_Kamar = New Class_Kamar()
        ReloadDataTableDatabase()

        Dim usn As String = Username
        LblUser.Text = usn.ToUpper()
        LblEmail.Text = Email

        If Not String.IsNullOrEmpty(Login.Users.GSFoto) Then
            PictBoxNama.Load(Login.Users.GSFoto)
            PictBoxNama.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewKamar.DataSource = Class_Kamar.GetDataKoleksiDatabase()
    End Sub

    Private Sub Kamar_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub DataGridViewKamar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewKamar.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewKamar.Rows(index)

        selectedTableKoleksi = selectedRow.Cells(0).Value
        selectedTableKoleksiJenis = selectedRow.Cells(1).Value
        selectedTableKoleksiNama = selectedRow.Cells(2).Value
        selectedTableKoleksiStatus = selectedRow.Cells(3).Value
    End Sub

    'BUTTON

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        TambahKamar.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles BtnLogOut.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim main As New Penginapan(Login.Users.GSUserName, Login.Users.GSEmail)
        main.Show()
        Me.Close()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        'EditKamar.Show()
        Dim dataSelected As List(Of String) = Class_Kamar.GetDataKoleksiById(selectedTableKoleksi)
        Try
            Class_Kamar.GSnamaKamar = dataSelected(2)
            Class_Kamar.GSStatus = dataSelected(3)

            Dim dataselected2 As List(Of String) = Class_Kamar.GetJenisKamarById(dataSelected(1))
            Class_Kamar.GSJenisKamar = dataselected2(0)
            Dim formUpdate = New EditKamar()
            formUpdate.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Anda belum memilih baris apa pun!")
        End Try
    End Sub

    Private Sub BtnInfo_Click(sender As Object, e As EventArgs) Handles BtnInfo.Click
        'InfoKamar.Show()
        Dim dataselected = Class_Kamar.GetDataKoleksiById(selectedTableKoleksi)

        Try
            Class_Kamar.GSnamaKamar = dataselected(2)
            Class_Kamar.GSid_jenisKamar = dataselected(1)
            Class_Kamar.GSStatus = dataselected(3)

            Dim infoTambah = New InfoKamar()
            infoTambah.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Anda belum memilih baris apa pun!")
        End Try
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        'HapusKamar.Show()
        Dim dataSelected As List(Of String) = Class_Kamar.GetDataKoleksiById(selectedTableKoleksi)
        Try
            Class_Kamar.GSnamaKamar = dataSelected(2)
            Class_Kamar.GSid_jenisKamar = dataSelected(1)
            Class_Kamar.GSStatus = dataSelected(3)

            Dim formHapus = New HapusKamar()
            formHapus.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Anda belum memilih baris apa pun!")
        End Try
    End Sub
End Class