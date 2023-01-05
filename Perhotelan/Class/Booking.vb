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
End Class
