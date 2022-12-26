Public Class HapusJenisKamar
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim text = JenisKamar_.JenisKamar.GSJenis
        LblJKamar.Text = text.ToUpper()
        Dim text2 = JenisKamar_.JenisKamar.GSHarga
        LblHarga.Text = text2.ToUpper()
    End Sub
    Private Sub BtnHapusJKamar_Click(sender As Object, e As EventArgs) Handles BtnHapusJKamar.Click
        JenisKamar_.JenisKamar.DeleteDatakoleksiById(JenisKamar_.selectedTableKoleksi)
        MessageBox.Show("Data berhasil dihapus")

        Me.Close()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Dim jk As New JenisKamar_(Login.Users.GSUserName, Login.Users.GSEmail)
        jk.Show()
        Me.Close()
    End Sub
End Class