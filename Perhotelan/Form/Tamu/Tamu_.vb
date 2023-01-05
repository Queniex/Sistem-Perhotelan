Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Public Class Tamu_
    Public Shared tamu As Tamu
    Public Shared selectedTableTamuNik
    Public Shared selectedTableTamuNama
    Public Shared selectedTableTamuAlamat
    Public Shared selectedTableTamuJenisKelamin

    Public Sub New(ByVal Username As String, ByVal Email As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        tamu = New Tamu
        ReloadDataTableDatabase()

        Dim usn As String = Username
        LblUser.Text = usn.ToUpper()
        LblEmail.Text = Email

        If Not String.IsNullOrEmpty(Login.Users.GSFoto) Then
            PictureBoxNama.Load(Login.Users.GSFoto)
            PictureBoxNama.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewTamu.DataSource = tamu.GetDataTamuDatabase()
    End Sub
    Private Sub Tamu__Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub DataGridViewTamu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewTamu.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewTamu.Rows(index)

        selectedTableTamuNik = selectedRow.Cells(0).Value
        selectedTableTamuNama = selectedRow.Cells(1).Value
        selectedTableTamuAlamat = selectedRow.Cells(2).Value
        selectedTableTamuJenisKelamin = selectedRow.Cells(3).Value
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim dataSelected As List(Of String) = tamu.GetDataTamuByNIK(selectedTableTamuNik)

        Try
            tamu.GSNIK = dataSelected(0)
            tamu.GSNama = dataSelected(1)
            tamu.GSAlamat = dataSelected(2)
            tamu.GSJenisKelamin = dataSelected(3)

            Dim formEdit = New EditTamu()
            formEdit.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Anda belum memilih baris apa pun!")
        End Try
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        TambahTamu.Show()
        Me.Hide()
    End Sub

    Private Sub BtnInfo_Click(sender As Object, e As EventArgs) Handles BtnInfo.Click
        Dim dataSelected As List(Of String) = tamu.GetDataTamuByNIK(selectedTableTamuNik)
        Try
            tamu.GSNIK = dataSelected(0)
            tamu.GSNama = dataSelected(1)
            tamu.GSAlamat = dataSelected(2)
            tamu.GSJenisKelamin = dataSelected(3)

            Dim formInfo = New InfoTamu()
            formInfo.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Anda belum memilih baris apa pun!")
        End Try
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim dataSelected As List(Of String) = tamu.GetDataTamuByNIK(selectedTableTamuNik)
        Try
            tamu.GSNIK = dataSelected(0)
            tamu.GSNama = dataSelected(1)
            tamu.GSAlamat = dataSelected(2)
            tamu.GSJenisKelamin = dataSelected(3)

            Dim formHapus = New HapusTamu()
            formHapus.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Anda belum memilih baris apa pun!")
        End Try
    End Sub

    Private Sub BtnLogout_Click_1(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripBtnTamu_Click_1(sender As Object, e As EventArgs) Handles ToolStripBtnTamu.Click
        Dim main As New Penginapan(Login.Users.GSUserName, Login.Users.GSEmail)
        main.Show()
        Me.Close()
    End Sub
End Class