Public Class TambahJenisKamar
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub TxtBoxJKamar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBoxJKamar.KeyPress
        If TxtBoxJKamar.Text.Length < 1 Then
            TxtBoxJKamar.Select()
            MessageBox.Show("Please add At least 1 String")
        End If
    End Sub

    Private Sub TxtBoxHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBoxHarga.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Hanya angka yang dapat di input!")
        End If

        If TxtBoxJKamar.Text.Length < 1 Then
            TxtBoxJKamar.Select()
            MessageBox.Show("Please add At least 1 String")
        End If
    End Sub

    Private Sub BtnBatalKamar_Click(sender As Object, e As EventArgs) Handles BtnBatalKamar.Click
        Dim jk As New JenisKamar_(Login.Users.GSUserName, Login.Users.GSEmail)
        jk.Show()
        Me.Close()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        JenisKamar_.JenisKamar.GSJenis = TxtBoxJKamar.Text
        JenisKamar_.JenisKamar.GSHarga = Integer.Parse(TxtBoxHarga.Text)

        JenisKamar_.JenisKamar.AddJenisKamar(JenisKamar_.JenisKamar.GSJenis,
                                           JenisKamar_.JenisKamar.GSHarga
                                           )

        Dim info = New InfoJenisKamar()
        info.Show()

        Me.Close()
    End Sub
End Class