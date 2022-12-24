Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class JenisKamar
    Private jenis_kamar As String
    Private harga As String

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "projek_uas"

    Public Property GSJenis() As String
        Get
            Return jenis_kamar
        End Get
        Set(value As String)
            jenis_kamar = value
        End Set
    End Property

    Public Property GSHarga() As String
        Get
            Return harga
        End Get
        Set(value As String)
            harga = value
        End Set
    End Property
End Class
