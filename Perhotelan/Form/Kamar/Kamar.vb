Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Kamar
    Public Shared Class_Kamar As Class_Kamar

    Public Sub New(ByVal Username As String, ByVal Email As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Class_Kamar = New Class_Kamar()
        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewKamar.DataSource = Class_Kamar.GetDataKoleksiDatabase()
    End Sub

    Private Sub Kamar_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    'BUTTON

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        TambahKamar.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripKamar__ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStripKamar_.ItemClicked
        Dim main As New Penginapan(Login.Users.GSUserName, Login.Users.GSEmail)
        main.Show()
        Me.Close()
    End Sub

End Class