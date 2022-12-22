Imports System.Security.Cryptography
Imports Google.Protobuf.WellKnownTypes

Public Class Regist
    Private TripleDes As New TripleDESCryptoServiceProvider

    Private Sub BtnPhoto_Click(sender As Object, e As EventArgs) Handles BtnPhoto.Click
        OpenFileDialog1.Title = "Open Foto"
        OpenFileDialog1.Filter = "Image Files (*.jpeg, *.jpg, *.png, *.bmap)|*.jpeg; *.jpg; *.png; *.bmap|All Files (*.*)|*.*"
        OpenFileDialog1.ShowDialog()

        'PBGambar.Load(OpenFileDialog1.FileName)
        'PBGambar.SizeMode = PictureBoxSizeMode.StretchImage
        Login.Users.GSFoto = OpenFileDialog1.FileName.ToString()
        Login.Users.GSFoto = Login.Users.GSFoto.Replace("\", "/")
    End Sub

    Private Sub BtnPre_Click(sender As Object, e As EventArgs) Handles BtnPre.Click
        'Munculkan preview gambar using custom message box
        Dim pre As New preview()
        pre.ShowDialog()
    End Sub

    Private Sub TxtUsernsme2_Leave(sender As Object, e As EventArgs) Handles TxtUsernsme2.Leave
        If TxtUsernsme2.Text.Length < 1 Then
            TxtUsernsme2.Select()
            MessageBox.Show("Username can't be empty!")
        End If
    End Sub

    Private Sub TxtEmail_Leave(sender As Object, e As EventArgs) Handles TxtEmail.Leave
        Dim at As String
        Dim chk As Boolean
        at = TxtEmail.Text
        chk = at.Contains("@")
        If TxtEmail.Text.Length < 1 Then
            TxtEmail.Select()
            MessageBox.Show("Email can't be empty!")
        ElseIf chk = False Then
            TxtEmail.Select()
            MessageBox.Show("Enter the correct email!")
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

    Private Sub LblLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.Close()
        Login.Show()
    End Sub

    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        If TxtPassword2.Text.Length = 0 Then
            TxtPassword2.Select()
            MessageBox.Show("Password can't be empty!")
        Else
            If IsNothing(Login.Users.GSFoto) Then
                MessageBox.Show("Photo can't be empty!")
            Else
                Login.Users.GSUserName = TxtUsernsme2.Text
                'Login.Users.GSPassword = EncryptData(TxtPass2.Text)
                Login.Users.GSPassword = TxtPassword2.Text
                Login.Users.GSEmail = TxtEmail.Text

                If Login.Users.CheckUsn(Login.Users.GSUserName, Login.Users.GSEmail) Then
                    MessageBox.Show("Pick another username / email")
                Else
                    Login.Users.AddKoleksiUser(
                                            Login.Users.GSUserName,
                                            Login.Users.GSPassword,
                                            Login.Users.GSEmail,
                                            Login.Users.GSFoto)
                    Me.Close()
                    Login.Show()
                End If
            End If
        End If
    End Sub
End Class