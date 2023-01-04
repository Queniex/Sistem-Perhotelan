Imports MySql.Data.MySqlClient
Public Class EditTamu
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtNamaTamu.Text = Tamu_.tamu.GSNama
        TxtNIK.Text = Tamu_.tamu.GSNIK
        RtbAlamat.Text = Tamu_.tamu.GSAlamat

        If String.Compare(Tamu_.tamu.GSJenisKelamin, "Pria") = 0 Then
            RdBtnPria.Checked = True
        ElseIf String.Compare(Tamu_.tamu.GSJenisKelamin, "Wanita") = 0 Then
            RdBtnWanita.Checked = True
        End If
    End Sub
End Class