<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoJenisKamar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InfoJenisKamar))
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BtnKembali = New System.Windows.Forms.Button()
        Me.GbKamar = New System.Windows.Forms.GroupBox()
        Me.LblHarga = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblJenisKamar = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.GbKamar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.BackgroundImage = CType(resources.GetObject("Panel6.BackgroundImage"), System.Drawing.Image)
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel6.Location = New System.Drawing.Point(13, 362)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(349, 59)
        Me.Panel6.TabIndex = 99
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel5.Location = New System.Drawing.Point(13, 15)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(349, 59)
        Me.Panel5.TabIndex = 98
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Location = New System.Drawing.Point(13, 89)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(349, 78)
        Me.Panel3.TabIndex = 100
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Variable Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(30, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(277, 28)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "INFORMASI JENIS KAMAR"
        '
        'BtnKembali
        '
        Me.BtnKembali.BackColor = System.Drawing.Color.Black
        Me.BtnKembali.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnKembali.ForeColor = System.Drawing.Color.White
        Me.BtnKembali.Location = New System.Drawing.Point(13, 314)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(118, 30)
        Me.BtnKembali.TabIndex = 102
        Me.BtnKembali.Text = "<< Kembali"
        Me.BtnKembali.UseVisualStyleBackColor = False
        '
        'GbKamar
        '
        Me.GbKamar.Controls.Add(Me.LblHarga)
        Me.GbKamar.Controls.Add(Me.Label6)
        Me.GbKamar.Controls.Add(Me.Label5)
        Me.GbKamar.Controls.Add(Me.LblJenisKamar)
        Me.GbKamar.Controls.Add(Me.Label2)
        Me.GbKamar.Controls.Add(Me.Label10)
        Me.GbKamar.ForeColor = System.Drawing.Color.White
        Me.GbKamar.Location = New System.Drawing.Point(13, 173)
        Me.GbKamar.Name = "GbKamar"
        Me.GbKamar.Size = New System.Drawing.Size(349, 129)
        Me.GbKamar.TabIndex = 101
        Me.GbKamar.TabStop = False
        Me.GbKamar.Text = "Informasi Jenis Kamar"
        '
        'LblHarga
        '
        Me.LblHarga.AutoSize = True
        Me.LblHarga.Font = New System.Drawing.Font("Segoe UI Variable Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblHarga.ForeColor = System.Drawing.Color.White
        Me.LblHarga.Location = New System.Drawing.Point(197, 83)
        Me.LblHarga.Name = "LblHarga"
        Me.LblHarga.Size = New System.Drawing.Size(40, 16)
        Me.LblHarga.TabIndex = 103
        Me.LblHarga.Text = "Harga"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(71, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 15)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "Jenis Kamar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(71, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Harga"
        '
        'LblJenisKamar
        '
        Me.LblJenisKamar.AutoSize = True
        Me.LblJenisKamar.Font = New System.Drawing.Font("Segoe UI Variable Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblJenisKamar.ForeColor = System.Drawing.Color.White
        Me.LblJenisKamar.Location = New System.Drawing.Point(197, 43)
        Me.LblJenisKamar.Name = "LblJenisKamar"
        Me.LblJenisKamar.Size = New System.Drawing.Size(72, 16)
        Me.LblJenisKamar.TabIndex = 102
        Me.LblJenisKamar.Text = "Jenis Kamar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(177, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 15)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(177, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 15)
        Me.Label10.TabIndex = 99
        Me.Label10.Text = ":"
        '
        'InfoJenisKamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(376, 436)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.BtnKembali)
        Me.Controls.Add(Me.GbKamar)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "InfoJenisKamar"
        Me.Text = "InfoJenisKamar"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GbKamar.ResumeLayout(False)
        Me.GbKamar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents BtnKembali As Button
    Friend WithEvents GbKamar As GroupBox
    Friend WithEvents LblHarga As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblJenisKamar As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
End Class
