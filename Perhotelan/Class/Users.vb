Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class Users
    Private TripleDes As New TripleDESCryptoServiceProvider
    Private UserName As String
    Private Password As String
    Private Email As String
    Private Foto As String

    Public Shared DbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Public Property GSUserName() As String
        Get
            Return UserName
        End Get
        Set(ByVal value As String)
            UserName = value
        End Set
    End Property

    Public Property GSPassword() As String
        Get
            Return Password
        End Get
        Set(ByVal value As String)
            Password = value
        End Set
    End Property

    Public Property GSEmail() As String
        Get
            Return Email
        End Get
        Set(ByVal value As String)
            Email = value
        End Set
    End Property

    Public Property GSFoto() As String
        Get
            Return Foto
        End Get
        Set(ByVal value As String)
            Foto = value
        End Set
    End Property

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
