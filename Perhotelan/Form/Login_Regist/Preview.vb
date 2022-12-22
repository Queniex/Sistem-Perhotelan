Public Class preview
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ShowInTaskbar = False

        If Not String.IsNullOrEmpty(Login.Users.GSFoto) Then
            PbUser.Load(Login.Users.GSFoto)
            PbUser.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub BtnX_Click(sender As Object, e As EventArgs) Handles BtnX.Click
        Me.Close()
    End Sub

    Private Sub preview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub preview_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            BtnX_Click(sender, e)
        End If
    End Sub
End Class