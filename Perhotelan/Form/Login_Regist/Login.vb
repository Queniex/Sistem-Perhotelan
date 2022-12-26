Imports System.Buffers
Imports System.Security.Cryptography
Public Class Login
    Public Shared Users As Users
    'Public Shared test As test
    Private TripleDes As New TripleDESCryptoServiceProvider

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Users = New Users()
    End Sub

    Private Sub LblRegistrasi_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblRegistrasi.LinkClicked
        Dim reg As New Regist()
        reg.Show()
    End Sub

    Private Sub ChkShow_CheckedChanged(sender As Object, e As EventArgs) Handles ChkShow.CheckedChanged
        If ChkShow.Checked = True Then
            TxtPassword.UseSystemPasswordChar = False
        Else
            TxtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BtnSignIn_Click(sender As Object, e As EventArgs) Handles BtnSignIn.Click
        Dim plainUsername As String = TxtUsername.Text
        Dim plainPassword As String = TxtPassword.Text
        Dim chk = Users.CheckAuth(plainUsername, plainPassword)
        Dim count = chk.Count

        If count > 0 Then
            Users.GSFoto = chk(4)
            Users.GSUserName = chk(1)
            Users.GSEmail = chk(3)
            Dim main As New Penginapan(chk(1), chk(3))
            main.Show()
            Me.Hide()
            'Penginapan.Show()
        Else
            MessageBox.Show("Wrong Password/Username")
        End If
    End Sub

    Public Function EncryptData(ByVal plaintext As String)

        Dim plaintextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plaintext)

        Dim ms As New System.IO.MemoryStream
        Dim encStream As New CryptoStream(ms,
            TripleDes.CreateEncryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        Return Convert.ToBase64String(ms.ToArray)
    End Function
End Class