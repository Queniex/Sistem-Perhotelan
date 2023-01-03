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

    Public Function AddTamu(nik_tamu As Integer,
                            nama_tamu As String,
                            alamat_tamu As String,
                            jeniskelamin_tamu As String)

        dbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=projek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            dbConn.Open()
            sqlQuery = "INSERT INTO tamu(nik, nama, alamat,
                                         jenis_kelamin) VALUES ('" & nik_tamu & "','" & nama_tamu & "','" _
                                         & alamat_tamu & "','" _
                                         & jeniskelamin_tamu & "')"

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
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataTamuDatabase() As DataTable
        Dim result As New DataTable

        dbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=projek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            dbConn.Open()
            sqlQuery = "SELECT nik AS 'No Identitas',
                        nama AS 'Nama Lengkap',
                        alamat AS 'Alamat',
                        jenis_kelamin AS 'Jenis Kelamin'
                        FROM tamu"

            Try
                sqlCommand = New MySqlCommand(sqlQuery, dbConn)
                sqlRead = sqlCommand.ExecuteReader
                result.Load(sqlRead)
                Return result
            Catch ex As Exception
                MsgBox("Problem : " & ex.Message.ToString)
            End Try
            sqlRead.Close()
        Catch ex As Exception
            MsgBox("Connection : " & ex.Message.ToString)
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function UpdateDataTamuByNIK(nik_tamu As Integer,
                                            nama_tamu As String,
                                            alamat_tamu As String,
                                            jeniskelamin_tamu As String)

        dbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=projek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn

            sqlQuery = "UPDATE tamu SET " _
                        + "nik='" & nik_tamu & "'," _
                        + "nama='" & nama_tamu & "'," _
                        + "alamat='" & alamat_tamu & "'," _
                        + "jenis_kelamin='" & jeniskelamin_tamu & "' WHERE nik='" & nik_tamu & "' "
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function

End Class
