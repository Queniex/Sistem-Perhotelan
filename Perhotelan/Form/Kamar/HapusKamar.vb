Public Class HapusKamar
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
End Class