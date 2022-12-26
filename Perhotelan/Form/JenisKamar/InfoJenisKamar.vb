Public Class InfoJenisKamar
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblJenisKamar.Text = JenisKamar_.JenisKamar.GSJenis
        LblHarga.Text = JenisKamar_.JenisKamar.GSHarga
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        JenisKamar_.Show()
        Me.Close()
    End Sub
End Class