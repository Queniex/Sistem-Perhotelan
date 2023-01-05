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

    Public Function GetDataBookingDatabase() As DataTable
        Dim result As New DataTable

        dbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=projek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            dbConn.Open()
            sqlQuery = "SELECT tamu.nama AS 'Nama Lengkap',
                        kamar.nama_kamar AS 'No. Kamar',
                        check_in AS 'Tanggal Check In',
                        check_out AS 'Tanggal Check Out',
                        booking_kamar.status AS 'Status'
                        FROM booking_kamar
                        INNER JOIN tamu ON booking_kamar.id_tamu = tamu.nik
                        INNER JOIN kamar ON booking_kamar.id_kamar = kamar.id_kamar WHERE booking_kamar.status = 'Reserved' "

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

    Public Function GetDataBookingById(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=projek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            dbConn.Open()
            sqlQuery = "SELECT id, id_tamu, id_kamar, check_in, check_out, status FROM booking_kamar WHERE id='" & ID & "'"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, dbConn)
                sqlRead = sqlCommand.ExecuteReader

                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())
                    result.Add(sqlRead.GetString(2).ToString())
                    result.Add(sqlRead.GetString(3).ToString())
                    result.Add(sqlRead.GetString(4).ToString())
                    result.Add(sqlRead.GetString(5).ToString())
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

    Public Function CheckTxtKamar(nama_kamar As String)

        Dim result As New List(Of String)

        dbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=projek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            dbConn.Open()
            sqlQuery = "SELECT id_kamar, nama_kamar, jenis_kamar.harga FROM kamar INNER JOIN jenis_kamar on kamar.id_jenis_kamar = jenis_kamar.id_jenis_kamar "
            sqlQuery &= "WHERE nama_kamar = '" & nama_kamar & "' OR status='Belum Terisi'"
            sqlQuery &= ""
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

    Public Function CheckTxtKamar2(nama_kamar As String)

        Dim result As New List(Of String)

        dbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=projek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            dbConn.Open()
            sqlQuery = "SELECT id_kamar, nama_kamar, jenis_kamar.harga FROM kamar INNER JOIN jenis_kamar on kamar.id_jenis_kamar = jenis_kamar.id_jenis_kamar "
            sqlQuery &= "WHERE nama_kamar = '" & nama_kamar & "'"
            sqlQuery &= ""
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

    Public Function CheckTxtTamu(nama_tamu As String)

        Dim result As New List(Of String)

        dbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=projek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            dbConn.Open()
            sqlQuery = "SELECT nik, nama FROM tamu WHERE nama = '" & nama_tamu & "' "
            Try
                sqlCommand = New MySqlCommand(sqlQuery, dbConn)
                sqlRead = sqlCommand.ExecuteReader

                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())
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

    Public Function getDataTamu()
        Dim result As New DataTable
        dbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=projek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            dbConn.Open()
            sqlQuery = "SELECT nik AS 'NIK',
                        nama AS 'Nama Tamu'
                        FROM tamu"
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

    Public Function getDataKamar()
        Dim result As New DataTable
        dbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=projek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            dbConn.Open()
            sqlQuery = "SELECT id_kamar AS 'Id',
                        jenis_kamar.jenis_kamar AS 'Info Jenis Kamar',
                        nama_kamar AS 'Nomor Kamar',
                        jenis_kamar.harga AS 'Harga'
                        FROM kamar INNER JOIN jenis_kamar on kamar.id_jenis_kamar = jenis_kamar.id_jenis_kamar WHERE kamar.status = 'Belum Terisi'"
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

    Public Function getNoKamarByIdKamar(Id_kamar As Integer)
        Dim result As New List(Of String)

        dbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=projek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            dbConn.Open()
            sqlQuery = "SELECT nama_kamar FROM kamar WHERE id_kamar='" & Id_kamar & "'"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, dbConn)
                sqlRead = sqlCommand.ExecuteReader

                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString())
                End While
                Return result
            Catch ex As Exception
                MsgBox("Problem : " & ex.Message.ToString)
            End Try
            sqlRead.Close()
        Catch ex As Exception
            MsgBox("Connection : " & ex.Message.ToString)
        End Try
    End Function

    Public Function getNamaTamuByIdTamu(id_tamu As Integer)
        Dim result As New List(Of String)

        dbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=projek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            dbConn.Open()
            sqlQuery = "SELECT nama FROM tamu WHERE nik='" & id_tamu & "'"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, dbConn)
                sqlRead = sqlCommand.ExecuteReader

                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString())
                End While
                Return result
            Catch ex As Exception
                MsgBox("Problem : " & ex.Message.ToString)
            End Try
            sqlRead.Close()
        Catch ex As Exception
            MsgBox("Connection : " & ex.Message.ToString)
        End Try
    End Function

    Public Function getIdBookingByIdKamar(Id_kamar As String)
        Dim result As Integer

        dbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=projek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            dbConn.Open()
            sqlQuery = "SELECT id FROM booking_kamar WHERE id_kamar='" & Id_kamar & "'"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, dbConn)
                sqlRead = sqlCommand.ExecuteReader

                While sqlRead.Read
                    result = sqlRead.GetString(0).ToString
                End While
                Return result
            Catch ex As Exception
                MsgBox("Problem : " & ex.Message.ToString)
            End Try
            sqlRead.Close()
        Catch ex As Exception
            MsgBox("Connection : " & ex.Message.ToString)
        End Try
    End Function
    Public Function getIdTamuByNama(nama_tamu As String)
        Dim result As Integer

        dbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=projek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            dbConn.Open()
            sqlQuery = "SELECT nik FROM tamu WHERE nama='" & nama_tamu & "'"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, dbConn)
                sqlRead = sqlCommand.ExecuteReader

                While sqlRead.Read
                    result = sqlRead.GetString(0).ToString
                End While
                Return result
            Catch ex As Exception
                MsgBox("Problem : " & ex.Message.ToString)
            End Try
            sqlRead.Close()
        Catch ex As Exception
            MsgBox("Connection : " & ex.Message.ToString)
        End Try
    End Function

    Public Function getIdKamarByNoKamar(nomor_kamar As String)
        Dim result As Integer

        dbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=projek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            dbConn.Open()
            sqlQuery = "SELECT id_kamar FROM kamar WHERE nama_kamar='" & nomor_kamar & "'"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, dbConn)
                sqlRead = sqlCommand.ExecuteReader

                While sqlRead.Read
                    result = sqlRead.GetString(0).ToString
                End While

                Return result
            Catch ex As Exception
                MsgBox("Problem : " & ex.Message.ToString)
            End Try
            sqlRead.Close()
        Catch ex As Exception
            MsgBox("Connection : " & ex.Message.ToString)
        End Try
    End Function

    Public Function getKamar(id_kamar As Integer)
        Dim result As New List(Of String)

        dbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=projek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            dbConn.Open()
            sqlQuery = "SELECT nama_kamar FROM kamar WHERE nama_kamar ='" & id_kamar & "' OR status = 'Belum Terisi' "
            Try
                sqlCommand = New MySqlCommand(sqlQuery, dbConn)
                sqlRead = sqlCommand.ExecuteReader

                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString)
                End While

                Return result
            Catch ex As Exception
                MsgBox("Problem : " & ex.Message.ToString)
            End Try
            sqlRead.Close()
        Catch ex As Exception
            MsgBox("Connection : " & ex.Message.ToString)
        End Try
    End Function
End Class
