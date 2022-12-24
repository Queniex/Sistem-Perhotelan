Public Class JenisKamar_
    Public Shared JenisKamar As JenisKamar
    Public Shared selectedTableKoleksi
    Public Shared selectedTableKoleksiNama

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        JenisKamar = New JenisKamar()
    End Sub

    Private Sub ToolStripBtnJKamar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnJKamar.Click
        'Penginapan.Show()
        Me.Close()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Login.Show()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        TambahJenisKamar.Show()
        Me.Hide()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        EditJenisKamar.Show()
        Me.Close()
    End Sub

    Private Sub BtnInfo_Click(sender As Object, e As EventArgs) Handles BtnInfo.Click
        InfoJenisKamar.Show()
        Me.Close()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        HapusJenisKamar.Show()
        Me.Close()
    End Sub

    Private Sub DataGridViewJKamar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewJKamar.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewJKamar.Rows(index)

        selectedTableKoleksi = selectedRow.Cells(0).Value
        selectedTableKoleksiNama = selectedRow.Cells(1).Value
    End Sub
End Class