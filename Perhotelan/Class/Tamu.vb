Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common
Public Class Tamu
    Private NIK As Integer
    Private Nama As String
    Private Alamat As String
    Private Jenis_Kelamin As String

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Public Property GSNIK() As Integer
        Get
            Return NIK
        End Get
        Set(value As Integer)
            NIK = value
        End Set
    End Property
    Public Property GSNama() As String
        Get
            Return Nama
        End Get
        Set(value As String)
            Nama = value
        End Set
    End Property

    Public Property GSAlamat() As String
        Get
            Return Alamat
        End Get
        Set(value As String)
            Alamat = value
        End Set
    End Property

    Public Property GSJenisKelamin() As String
        Get
            Return Jenis_Kelamin
        End Get
        Set(value As String)
            Jenis_Kelamin = value
        End Set
    End Property

End Class
