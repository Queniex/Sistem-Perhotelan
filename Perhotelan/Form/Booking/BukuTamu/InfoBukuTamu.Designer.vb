<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoBukuTamu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InfoBukuTamu))
        Me.BtnKembali = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblStatusKamar = New System.Windows.Forms.Label()
        Me.LblTotalBiaya = New System.Windows.Forms.Label()
        Me.Lblcekout = New System.Windows.Forms.Label()
        Me.LblCekin = New System.Windows.Forms.Label()
        Me.LblNamaTamu = New System.Windows.Forms.Label()
        Me.LblNoBooking = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnKembali
        '
        Me.BtnKembali.BackColor = System.Drawing.Color.Black
        Me.BtnKembali.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnKembali.ForeColor = System.Drawing.Color.White
        Me.BtnKembali.Location = New System.Drawing.Point(16, 404)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(118, 30)
        Me.BtnKembali.TabIndex = 98
        Me.BtnKembali.Text = "<< Kembali"
        Me.BtnKembali.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(13, 86)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(405, 78)
        Me.Panel2.TabIndex = 97
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(65, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "INFORMASI BUKU TAMU"
        '
        'LblStatusKamar
        '
        Me.LblStatusKamar.AutoSize = True
        Me.LblStatusKamar.Font = New System.Drawing.Font("Segoe UI Variable Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblStatusKamar.Location = New System.Drawing.Point(184, 167)
        Me.LblStatusKamar.Name = "LblStatusKamar"
        Me.LblStatusKamar.Size = New System.Drawing.Size(81, 16)
        Me.LblStatusKamar.TabIndex = 93
        Me.LblStatusKamar.Text = "Status Kamar"
        '
        'LblTotalBiaya
        '
        Me.LblTotalBiaya.AutoSize = True
        Me.LblTotalBiaya.Font = New System.Drawing.Font("Segoe UI Variable Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTotalBiaya.Location = New System.Drawing.Point(184, 139)
        Me.LblTotalBiaya.Name = "LblTotalBiaya"
        Me.LblTotalBiaya.Size = New System.Drawing.Size(68, 16)
        Me.LblTotalBiaya.TabIndex = 92
        Me.LblTotalBiaya.Text = "Total Bayar"
        '
        'Lblcekout
        '
        Me.Lblcekout.AutoSize = True
        Me.Lblcekout.Font = New System.Drawing.Font("Segoe UI Variable Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lblcekout.Location = New System.Drawing.Point(184, 113)
        Me.Lblcekout.Name = "Lblcekout"
        Me.Lblcekout.Size = New System.Drawing.Size(109, 16)
        Me.Lblcekout.TabIndex = 91
        Me.Lblcekout.Text = "Tanggal Check Out"
        '
        'LblCekin
        '
        Me.LblCekin.AutoSize = True
        Me.LblCekin.Font = New System.Drawing.Font("Segoe UI Variable Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblCekin.Location = New System.Drawing.Point(184, 88)
        Me.LblCekin.Name = "LblCekin"
        Me.LblCekin.Size = New System.Drawing.Size(99, 16)
        Me.LblCekin.TabIndex = 90
        Me.LblCekin.Text = "Tanggal Check In"
        '
        'LblNamaTamu
        '
        Me.LblNamaTamu.AutoSize = True
        Me.LblNamaTamu.Font = New System.Drawing.Font("Segoe UI Variable Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblNamaTamu.Location = New System.Drawing.Point(184, 62)
        Me.LblNamaTamu.Name = "LblNamaTamu"
        Me.LblNamaTamu.Size = New System.Drawing.Size(72, 16)
        Me.LblNamaTamu.TabIndex = 89
        Me.LblNamaTamu.Text = "Nama Tamu"
        '
        'LblNoBooking
        '
        Me.LblNoBooking.AutoSize = True
        Me.LblNoBooking.Font = New System.Drawing.Font("Segoe UI Variable Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblNoBooking.Location = New System.Drawing.Point(184, 35)
        Me.LblNoBooking.Name = "LblNoBooking"
        Me.LblNoBooking.Size = New System.Drawing.Size(75, 16)
        Me.LblNoBooking.TabIndex = 88
        Me.LblNoBooking.Text = "No. Booking"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(160, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(9, 16)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(43, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "No. Booking"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Location = New System.Drawing.Point(13, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(405, 59)
        Me.Panel1.TabIndex = 96
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(43, 167)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 16)
        Me.Label10.TabIndex = 86
        Me.Label10.Text = "Status Kamar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Nama Tamu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(160, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(9, 16)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = ":"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(43, 113)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(107, 16)
        Me.Label16.TabIndex = 79
        Me.Label16.Text = "Tanggal Check Out"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Total Bayar"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(43, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 16)
        Me.Label15.TabIndex = 78
        Me.Label15.Text = "Tanggal Check In"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(160, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(9, 16)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = ":"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(160, 88)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(9, 16)
        Me.Label18.TabIndex = 82
        Me.Label18.Text = ":"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(160, 113)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(9, 16)
        Me.Label19.TabIndex = 83
        Me.Label19.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(160, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(9, 16)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = ":"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel3.Location = New System.Drawing.Point(13, 448)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(405, 59)
        Me.Panel3.TabIndex = 95
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.LblStatusKamar)
        Me.GroupBox1.Controls.Add(Me.LblTotalBiaya)
        Me.GroupBox1.Controls.Add(Me.Lblcekout)
        Me.GroupBox1.Controls.Add(Me.LblCekin)
        Me.GroupBox1.Controls.Add(Me.LblNamaTamu)
        Me.GroupBox1.Controls.Add(Me.LblNoBooking)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(13, 181)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 212)
        Me.GroupBox1.TabIndex = 94
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informasi Pemesanan"
        '
        'InfoBukuTamu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(431, 520)
        Me.Controls.Add(Me.BtnKembali)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "InfoBukuTamu"
        Me.Text = "InfoBukuTamu"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnKembali As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LblStatusKamar As Label
    Friend WithEvents LblTotalBiaya As Label
    Friend WithEvents Lblcekout As Label
    Friend WithEvents LblCekin As Label
    Friend WithEvents LblNamaTamu As Label
    Friend WithEvents LblNoBooking As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox1 As GroupBox
End Class
