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

    Public Function AddJenisKamar(
                                jenis_kamar As String,
                                harga As Integer
                                )

        dbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=proyek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            dbConn.Open()
            sqlQuery = "INSERT INTO jenis_kamar(id_jenis_kamar, jenis_kamar, harga) VALUES ('','" & jenis_kamar & "','" _
                                         & harga & "')"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, dbConn)
                sqlRead = sqlCommand.ExecuteReader()
                sqlRead.Close()
                MsgBox("Data inserted.")
            Catch ex As Exception
                MsgBox("Failed to insert data: " & ex.Message.ToString())
            End Try
            sqlRead.Close()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try
    End Function

    Public Function UpdateDataKoleksiById(ID As Integer,
                                          jenis_kamar As String,
                                          harga As Integer
                                          )

        dbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=proyek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn

            sqlQuery = "UPDATE jenis_kamar SET " _
                        + "jenis_kamar='" & jenis_kamar & "'," _
                        + "harga='" & harga & "' WHERE id_jenis_kamar='" & ID & "' "
            Try
                sqlCommand = New MySqlCommand(sqlQuery, dbConn)
                sqlRead = sqlCommand.ExecuteReader
                dbConn.Close()
                sqlRead.Close()
                MsgBox("Data updated.")
            Catch ex As Exception
                MsgBox("Failed to update data: " & ex.Message.ToString())
            Finally
                dbConn.Dispose()
            End Try
            sqlRead.Close()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try
    End Function

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable

        dbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=proyek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            dbConn.Open()
            sqlQuery = "SELECT id_jenis_kamar AS 'No Jenis Kamar',
                               jenis_kamar AS 'Nama Jenis Kamar',
                               harga AS 'Harga Per Malam'
                               FROM jenis_kamar"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, dbConn)
                sqlRead = sqlCommand.ExecuteReader
                result.Load(sqlRead)
                Return result
            Catch ex As Exception
                MsgBox("Problem loading data: " & ex.Message.ToString)
            End Try
            sqlRead.Close()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try
    End Function

    Public Function GetDataKoleksiById(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=proyek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            dbConn.Open()
            sqlQuery = "SELECT * FROM jenis_kamar WHERE id_jenis_kamar='" & ID & "'"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, dbConn)
                sqlRead = sqlCommand.ExecuteReader

                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())
                    result.Add(sqlRead.GetString(2).ToString())
                End While
                Return result
            Catch ex As Exception
                MsgBox("Problem loading data: " & ex.Message.ToString)
            End Try
            sqlRead.Close()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try
    End Function


    Public Function DeleteDatakoleksiById(ID As Integer)
        dbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=proyek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn

            sqlQuery = "DELETE FROM jenis_kamar " &
                       "WHERE id_jenis_kamar='" & ID & "'"
            Try
                Debug.WriteLine(sqlQuery)
                sqlCommand = New MySqlCommand(sqlQuery, dbConn)
                sqlRead = sqlCommand.ExecuteReader
                dbConn.Close()
                sqlRead.Close()
                MsgBox("Data Deleted.")
            Catch ex As Exception
                MsgBox("Failed to update data: " & ex.Message.ToString())
            Finally
                dbConn.Dispose()
            End Try
            sqlRead.Close()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try
    End Function
End Class
