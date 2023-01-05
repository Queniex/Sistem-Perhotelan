Public Class InfoTamu
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblNIK.Text = Tamu_.tamu.GSNIK
        LblNamaTamu.Text = Tamu_.tamu.GSNama
        LblAlamat.Text = Tamu_.tamu.GSAlamat
        LblJenisKelamin.Text = Tamu_.tamu.GSJenisKelamin
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Dim t As New Tamu_(Login.Users.GSUserName, Login.Users.GSEmail)
        t.Show()
        Me.Close()
    End Sub
End Class