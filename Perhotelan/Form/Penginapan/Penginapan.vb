Imports Microsoft.VisualBasic.ApplicationServices

Public Class Penginapan

    Public Sub New(ByVal Username As String, ByVal Email As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblTgl.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Dim usn As String = Username
        LblUser.Text = usn.ToUpper()
        LblEmail.Text = Email

        If Not String.IsNullOrEmpty(Login.Users.GSFoto) Then
            PbUser.Load(Login.Users.GSFoto)
            PbUser.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub Penginapan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblJam.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub FormJenisKamar_Click(sender As Object, e As EventArgs) Handles FormJenisKamar.Click
        Dim jk As New JenisKamar_(Login.Users.GSUserName, Login.Users.GSEmail)
        jk.Show()
        Me.Close()
    End Sub
End Class
