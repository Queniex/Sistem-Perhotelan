Imports System.IO
Public Class TambahTamu
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Dim t As New Tamu_(Login.Users.GSUserName, Login.Users.GSEmail)
        t.Show()
        Me.Close()
    End Sub

    Private Sub BtnTambahTamu_Click(sender As Object, e As EventArgs) Handles BtnTambahTamu.Click
        Tamu_.tamu.GSNIK = Integer.Parse(TxtNIK.Text)
        Tamu_.tamu.GSNama = TxtNamaTamu.Text.ToString()
        Tamu_.tamu.GSAlamat = RtbAlamat.Text.ToString()

        If RdBtnPria.Checked Then
            Tamu_.tamu.GSJenisKelamin = "Pria"
        ElseIf RdBtnWanita.Checked Then
            Tamu_.tamu.GSJenisKelamin = "Wanita"
        End If

        Tamu_.tamu.AddTamu(Tamu_.tamu.GSNIK,
                           Tamu_.tamu.GSNama,
                           Tamu_.tamu.GSAlamat,
                           Tamu_.tamu.GSJenisKelamin)

        Dim Info = New InfoTamu()
        Info.Show()
        Me.Close()
    End Sub

    Private Sub TxtNamaTamu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNamaTamu.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Karakter Tidak Diketahui")
        End If
    End Sub

    Private Sub TxtNamaTamu_Leave(sender As Object, e As EventArgs) Handles TxtNamaTamu.Leave
        If TxtNamaTamu.Text.Length < 1 Then
            TxtNamaTamu.Select()
            MessageBox.Show("Nama Tamu Tidak Boleh Kosong!")
        End If
    End Sub

    Private Sub TxtNIK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNIK.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Hanya Dapat Memasukkan Angka!")
        End If
    End Sub

    Private Sub TxtNIK_Leave(sender As Object, e As EventArgs) Handles TxtNIK.Leave
        If TxtNIK.Text.Length < 1 Then
            TxtNIK.Select()
            MessageBox.Show("No Identitas Tidak Boleh Kosong!")
        End If
    End Sub
End Class