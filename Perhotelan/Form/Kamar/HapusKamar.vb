Public Class HapusKamar
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        LblHapusKamar.Text = Kamar.Class_Kamar.GSnamaKamar
        LblHapusJenisKamar.Text = Kamar.Class_Kamar.GSid_jenisKamar
        LblHapusStatus.Text = Kamar.Class_Kamar.GSStatus

    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Dim k As New Kamar(Login.Users.GSUserName, Login.Users.GSEmail)
        k.Show()
        Me.Close()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Kamar.Class_Kamar.DeleteDatakoleksiById(Kamar.selectedTableKoleksi)
        'MessageBox.Show("Data berhasil dihapus")

        Dim k As New Kamar(Login.Users.GSUserName, Login.Users.GSEmail)
        k.Show()
        Me.Close()
    End Sub
End Class