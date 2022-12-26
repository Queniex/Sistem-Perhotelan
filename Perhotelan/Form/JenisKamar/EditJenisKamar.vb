Public Class EditJenisKamar
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtBoxJKamar.Text = JenisKamar_.JenisKamar.GSJenis
        TxtBoxHarga.Text = JenisKamar_.JenisKamar.GSHarga
    End Sub

    Private Sub BtnEditJKamar_Click(sender As Object, e As EventArgs) Handles BtnEditJKamar.Click
        JenisKamar_.JenisKamar.GSJenis = TxtBoxJKamar.Text.ToString()
        JenisKamar_.JenisKamar.GSHarga = Integer.Parse(TxtBoxHarga.Text)

        JenisKamar_.JenisKamar.UpdateDataKoleksiById(JenisKamar_.selectedTableKoleksi,
                                           JenisKamar_.JenisKamar.GSJenis,
                                           JenisKamar_.JenisKamar.GSHarga
                                           )

        Dim info = New InfoJenisKamar()
        info.Show()

        Me.Close()
    End Sub

    Private Sub BtnBatalKamar_Click(sender As Object, e As EventArgs) Handles BtnBatalKamar.Click
        Dim jk As New JenisKamar_(Login.Users.GSUserName, Login.Users.GSEmail)
        jk.Show()
        Me.Close()
    End Sub
End Class