Public Class PilihTamu
    Public Shared selectedTableTamuNik
    Public Shared selectedTableTamuNama
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewDataTamu.DataSource = BookingKamar_.booking.getDataTamu()
    End Sub

    Private Sub PilihTamu_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub DataGridViewDataTamu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewDataTamu.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewDataTamu.Rows(index)

        selectedTableTamuNik = selectedRow.Cells(0).Value
        selectedTableTamuNama = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnBatalDataTamu_Click(sender As Object, e As EventArgs) Handles BtnBatalDataTamu.Click
        Dim bk As New BookingKamar_(Login.Users.GSUserName, Login.Users.GSEmail)
        bk.Show()
        Me.Close()
    End Sub

    Private Sub BtnPilihDataTamu_Click(sender As Object, e As EventArgs) Handles BtnPilihDataTamu.Click
        Try
            BookingKamar_.textnamatamu = selectedTableTamuNama

            Me.Close()
            Dim bk As New BookingKamar_(Login.Users.GSUserName, Login.Users.GSEmail)
            bk.Show()
        Catch ex As Exception
            MsgBox("Anda belum memilih baris apa pun!")
        End Try
    End Sub
End Class