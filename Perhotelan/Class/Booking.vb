Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common
Public Class Booking
    Private id_tamu As Integer
    Private id_kamar As Integer
    Private check_in As String
    Private check_out As String
    Private status As String
    Private NoKamar As String
    Private NamaTamu As String
    Private totalHarga As String

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Public Property GSIdTamu() As Integer
        Get
            Return id_tamu
        End Get
        Set(value As Integer)
            id_tamu = value
        End Set
    End Property

    Public Property GSIdKamar() As Integer
        Get
            Return id_kamar
        End Get
        Set(value As Integer)
            id_kamar = value
        End Set
    End Property

    Public Property GSTotal() As String
        Get
            Return totalHarga
        End Get
        Set(value As String)
            totalHarga = value
        End Set
    End Property

    Public Property GSNoKamar() As String
        Get
            Return NoKamar
        End Get
        Set(ByVal value As String)
            NoKamar = value
        End Set
    End Property
End Class
