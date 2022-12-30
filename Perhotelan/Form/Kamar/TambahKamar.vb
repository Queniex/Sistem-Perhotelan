Imports System.IO
Imports MySql.Data.MySqlClient

Public Class TambahKamar

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Dim k As New Kamar(Login.Users.GSUserName, Login.Users.GSEmail)
        k.Show()
        Me.Close()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If TxtBoxNamaKamar.Text.Length > 0 Then
            Kamar.Class_Kamar.GSnamaKamar = TxtBoxNamaKamar.Text.ToString()

            Dim dataselected As List(Of String) = Kamar.Class_Kamar.getIdJenis(CbJenisKamar.Text)
            Kamar.Class_Kamar.GSid_jenisKamar = dataselected(0)

            If RdBtnTerisi.Checked Then
                Kamar.Class_Kamar.GSStatus = "Terisi"
            ElseIf RdBtnBelumTerisi.Checked Then
                Kamar.Class_Kamar.GSStatus = "Belum Terisi"
            End If

            Kamar.Class_Kamar.AddKamar(Kamar.Class_Kamar.GSnamaKamar,
                                       Kamar.Class_Kamar.GSid_jenisKamar,
                                       Kamar.Class_Kamar.GSStatus
                                       )

            Dim Info = New InfoKamar()
            Info.Show()
            Me.Close()
        End If
    End Sub
End Class