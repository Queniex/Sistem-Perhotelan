Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class BukuTamu_
    Public Shared hargaTotal
    Public Sub New(ByVal Username As String, ByVal Email As String)

        ' This call is required by the designer.
        InitializeComponent()
        ReloadDataTableDatabase()

        ' Add any initialization after the InitializeComponent() call.
        Dim usn As String = Username
        LblUser.Text = usn.ToUpper()
        LblEmail.Text = Email

        If Not String.IsNullOrEmpty(Login.Users.GSFoto) Then
            PictureBoxBukuTamu.Load(Login.Users.GSFoto)
            PictureBoxBukuTamu.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewCheckin.DataSource = BookingKamar_.booking.GetDataCheckinDatabase()
    End Sub

    Private Sub BukuTamu__Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub
End Class