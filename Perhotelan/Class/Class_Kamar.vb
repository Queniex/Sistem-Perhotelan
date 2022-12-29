Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class Class_Kamar
    'Database Global Variable

    Private koleksiDataTable As New ArrayList()

    Private namaKamar As String
    Private id_jenisKamar As Integer
    Private status As String
    Private kamar As String
    Private jeniskamar As String

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "projek_uas"

    Public Property GSnamaKamar() As String
        Get
            Return namaKamar
        End Get
        Set(value As String)
            namaKamar = value
        End Set
    End Property

    Public Property GSid_jenisKamar() As Integer
        Get
            Return id_jenisKamar
        End Get
        Set(value As Integer)
            id_jenisKamar = value
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

    Public Function AddKamar(nama_kamar As String,
                             id_jenis_kamar As Integer,
                             status As String
                             )

        dbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=projek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            dbConn.Open()
            sqlQuery = "INSERT INTO kamar(id_kamar, nama_kamar, 
                                         id_jenis_kamar, status) VALUES ('','" & nama_kamar & "','" _
                                         & id_jenis_kamar & "','" _
                                         & status & "')"
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

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable

        dbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=projek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            dbConn.Open()
            sqlQuery = "SELECT id_kamar AS 'No',
                        nama_kamar AS 'Nama Kamar',
                        jenis_kamar.jenis_kamar AS 'Jenis Kamar',
                        status AS 'Status'
                        FROM kamar INNER JOIN jenis_kamar on kamar.id_jenis_kamar = jenis_kamar.id_jenis_kamar"
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
        End Try
    End Function

    Public Function GetDataKoleksiById(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=projek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            dbConn.Open()
            sqlQuery = "SELECT * FROM kamar WHERE id_kamar='" & ID & "'"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, dbConn)
                sqlRead = sqlCommand.ExecuteReader

                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())
                    result.Add(sqlRead.GetString(2).ToString())
                    result.Add(sqlRead.GetString(3).ToString())
                End While
                Return result
            Catch ex As Exception
                MessageBox.Show("Problem : " & ex.Message.ToString())
            End Try
            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show("Connection : " & ex.Message.ToString())
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function UpdateDataKoleksiById(id_kamar As Integer,
                                          id_jenis_kamar As Integer,
                                          nama_kamar As String,
                                          status As String
                                          )

        dbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=projek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn

            sqlQuery = "UPDATE kamar SET " _
                        + "nama_kamar='" & nama_kamar & "'," _
                        + "id_jenis_kamar='" & id_jenis_kamar & "'," _
                        + "status='" & status & "' WHERE id_kamar='" & id_kamar & "' "
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

    Public Function DeleteDatakoleksiById(ID As Integer)

        dbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=projek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn

            sqlQuery = "DELETE FROM kamar " &
                       "WHERE id_kamar='" & ID & "'"
            Try
                Debug.WriteLine(sqlQuery)
                sqlCommand = New MySqlCommand(sqlQuery, dbConn)
                sqlRead = sqlCommand.ExecuteReader
                dbConn.Close()
                sqlRead.Close()
                MsgBox("Data Berhasil Terhapus.")
            Catch ex As Exception
                MessageBox.Show("Problem : " & ex.Message.ToString())
            Finally
                dbConn.Dispose()
            End Try
            sqlRead.Close()
        Catch ex As Exception
            MessageBox.Show("Connection : " & ex.Message.ToString())
        End Try
    End Function


End Class