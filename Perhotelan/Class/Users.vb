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

    Public Function CheckUsn(ByVal username As String, ByVal email As String)

        Dim a As Boolean

        DbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=projek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            DbConn.Open()
            sqlQuery = "SELECT Username, Email FROM user WHERE Username = '" & username & "' OR Email = '" & email & "'"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, DbConn)
                sqlRead = sqlCommand.ExecuteReader

                If sqlRead.Read Then
                    a = True
                Else
                    a = False
                End If

                Return a
            Catch ex As Exception
                MsgBox("Problem loading data: " & ex.Message.ToString)
            End Try
            sqlRead.Close()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try
    End Function

    Public Function EncryptMD5(ByVal password As String)
        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        bs = x.ComputeHash(bs)
        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        Return s.ToString()
    End Function

    Public Function AddKoleksiUser(
                                    Username As String,
                                    Password As String,
                                    Email As String,
                                    Foto As String
                                    )

        DbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=projek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            DbConn.Open()
            sqlQuery = "INSERT INTO user(Id_User, Username, Pass, Email, Foto) VALUES ('','" & Username & "','" _
                                        & EncryptMD5(Password) & "','" & Email & "','" & Foto & "')"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, DbConn)
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

    Public Function GetDataUser()
        Dim result As New ArrayList

        DbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=projek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            DbConn.Open()
            sqlQuery = "SELECT Username, Pass, Email, Foto FROM user"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, DbConn)
                sqlRead = sqlCommand.ExecuteReader

                While sqlRead.Read
                    result.Add({sqlRead.GetString(0), sqlRead.GetString(1), sqlRead.GetString(2), sqlRead.GetString(3)})
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

    Public Function GetDataUsers(
                                 Username As String,
                                 Password As String
                                )
        Dim result As New ArrayList

        DbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=projek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            DbConn.Open()
            sqlQuery = "SELECT Id_User, Username, Pass, Email, Foto FROM user WHERE Username = '" & Username & "' "
            sqlQuery &= "AND Pass='" & EncryptMD5(Password) & "'"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, DbConn)
                sqlRead = sqlCommand.ExecuteReader

                While sqlRead.Read
                    result.Add({sqlRead.GetString(0), sqlRead.GetString(1), sqlRead.GetString(2), sqlRead.GetString(3)})
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

    Public Function CheckAuth(username As String, ByVal plainPassword As String)

        Dim result As New List(Of String)

        DbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=projek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            DbConn.Open()
            sqlQuery = "SELECT Id_User, Username, Pass, Email, Foto FROM user WHERE Username = '" & username & "' "
            sqlQuery &= "AND Pass='" & EncryptMD5(plainPassword) & "'"
            'sqlQuery &= "AND Pass='" & EncryptData(plainPassword) & "'"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, DbConn)
                sqlRead = sqlCommand.ExecuteReader

                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())
                    result.Add(sqlRead.GetString(2).ToString())
                    result.Add(sqlRead.GetString(3).ToString())
                    result.Add(sqlRead.GetString(4).ToString())
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
End Class
