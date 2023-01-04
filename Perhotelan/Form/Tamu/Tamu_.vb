Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Public Class Tamu_
    Public Shared tamu As Tamu
    Public Shared selectedTableTamuNik
    Public Shared selectedTableTamuNama
    Public Shared selectedTableTamuAlamat
    Public Shared selectedTableTamuJenisKelamin

    Public Sub New(ByVal Username As String, ByVal Email As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        tamu = New Tamu

        Dim usn As String = Username
        LblUser.Text = usn.ToUpper()
        LblEmail.Text = Email

        If Not String.IsNullOrEmpty(Login.Users.GSFoto) Then
            PictureBoxNama.Load(Login.Users.GSFoto)
            PictureBoxNama.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub
End Class