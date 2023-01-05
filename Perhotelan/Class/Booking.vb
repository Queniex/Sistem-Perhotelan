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

    Public Property GSNamaTamu() As String
        Get
            Return NamaTamu
        End Get
        Set(ByVal value As String)
            NamaTamu = value
        End Set
    End Property

    Public Property GSCheckIn() As String
        Get
            Return check_in
        End Get
        Set(value As String)
            check_in = value
        End Set
    End Property

    Public Property GSCheckOut() As String
        Get
            Return check_out
        End Get
        Set(value As String)
            check_out = value
        End Set
    End Property

    Public Property GSStatus() As String
        Get
            Return status
        End Get
        Set(value As String)
            status = value
        End Set
    End Property

    Public Function AddBooking(ID_Tamu As Integer,
                               ID_Kamar As Integer,
                               Check_In As String,
                               Check_Out As String,
                               Status As String)

        dbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=projek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            dbConn.Open()
            sqlQuery = "INSERT INTO booking_kamar (id, id_tamu, id_kamar, check_in, 
                                         check_out, status) VALUES ('','" & ID_Tamu & "','" & ID_Kamar & "','" _
                                         & Check_In & "','" _
                                         & Check_Out & "','" _
                                         & Status & "')"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, dbConn)
                sqlRead = sqlCommand.ExecuteReader()
                sqlRead.Close()
                MsgBox("Data Berhasil Ditambahkan.")
            Catch ex As Exception
                MsgBox("Failed : " & ex.Message.ToString())
            End Try
            sqlRead.Close()
        Catch ex As Exception
            MsgBox("Connection : " & ex.Message.ToString)
        End Try
    End Function
End Class
