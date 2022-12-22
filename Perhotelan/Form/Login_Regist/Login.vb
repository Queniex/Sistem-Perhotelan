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
End Class