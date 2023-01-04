Imports MySql.Data.MySqlClient
Public Class EditTamu
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtNamaTamu.Text = Tamu_.tamu.GSNama
        TxtNIK.Text = Tamu_.tamu.GSNIK
        RtbAlamat.Text = Tamu_.tamu.GSAlamat

        If String.Compare(Tamu_.tamu.GSJenisKelamin, "Pria") = 0 Then
            RdBtnPria.Checked = True
        ElseIf String.Compare(Tamu_.tamu.GSJenisKelamin, "Wanita") = 0 Then
            RdBtnWanita.Checked = True
        End If
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Dim t As New Tamu_(Login.Users.GSUserName, Login.Users.GSEmail)
        t.Show()
        Me.Close()
    End Sub

    Private Sub BtnEditTamu_Click(sender As Object, e As EventArgs) Handles BtnEditTamu.Click
        Tamu_.tamu.GSNIK = Integer.Parse(TxtNIK.Text)
        Tamu_.tamu.GSNama = TxtNamaTamu.Text.ToString()
        Tamu_.tamu.GSAlamat = RtbAlamat.Text.ToString()

        If RdBtnPria.Checked Then
            Tamu_.tamu.GSJenisKelamin = "Pria"
        ElseIf RdBtnWanita.Checked Then
            Tamu_.tamu.GSJenisKelamin = "Wanita"
        End If

        Tamu_.tamu.UpdateDataTamuByNIK(Tamu_.tamu.GSNIK,
                                       Tamu_.tamu.GSNama,
                                       Tamu_.tamu.GSAlamat,
                                       Tamu_.tamu.GSJenisKelamin)
        Dim Info = New InfoTamu()
        Info.Show()
        Me.Close()
    End Sub
End Class