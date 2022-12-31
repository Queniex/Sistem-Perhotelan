Imports MySql.Data.MySqlClient

Public Class EditKamar
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        TxtBoxChangeNamaKamar.Text = Kamar.Class_Kamar.GSnamaKamar

        If String.Compare(Kamar.Class_Kamar.GSStatus, "Terisi") = 0 Then
            RdBtnChangeTerisi.Checked = True
        ElseIf String.Compare(Kamar.Class_Kamar.GSStatus, "Belum Terisi") = 0 Then
            RdBtnChangeBelumTerisi.Checked = True
        End If

    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If TxtBoxChangeNamaKamar.Text.Length > 0 Then
            Kamar.Class_Kamar.GSnamaKamar = TxtBoxChangeNamaKamar.Text.ToString()

            Dim dataselected As List(Of String) = Kamar.Class_Kamar.getIdJenis(CbChangeJenisKamar.Text)
            Kamar.Class_Kamar.GSid_jenisKamar = dataselected(0)

            If RdBtnChangeTerisi.Checked Then
                Kamar.Class_Kamar.GSStatus = "Terisi"
            ElseIf RdBtnChangeBelumTerisi.Checked Then
                Kamar.Class_Kamar.GSStatus = "Belum Terisi"
            End If

            Kamar.Class_Kamar.UpdateDataKoleksiById(Kamar.selectedTableKoleksi,
                                                    Kamar.Class_Kamar.GSid_jenisKamar,
                                                    Kamar.Class_Kamar.GSnamaKamar,
                                                    Kamar.Class_Kamar.GSStatus
                                                    )
            Dim Info = New InfoKamar()
            Info.Show()
            Me.Close()
        End If
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Dim k As New Kamar(Login.Users.GSUserName, Login.Users.GSEmail)
        k.Show()
        Me.Close()
    End Sub

    Private Sub EditKamar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim conn As New MySqlConnection("Data Source=localhost;user id=root;password=;database=projek_uas;Convert Zero Datetime=True;Allow Zero Datetime=True")
            Dim cmd As New MySqlCommand("SELECT id_jenis_kamar, jenis_kamar FROM jenis_kamar", conn)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            CbChangeJenisKamar.DataSource = dt
            CbChangeJenisKamar.ValueMember = "jenis_kamar"
            CbChangeJenisKamar.DisplayMember = "jenis_kamar"
            CbChangeJenisKamar.Text = Kamar.Class_Kamar.GSJenisKamar
        Catch ex As Exception
            MsgBox("Error : " + ex.Message)
        Finally
            Class_Kamar.dbConn.Close()
        End Try
    End Sub
End Class