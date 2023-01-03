<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahTamu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TambahTamu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RtbAlamat = New System.Windows.Forms.RichTextBox()
        Me.TxtNIK = New System.Windows.Forms.TextBox()
        Me.BtnTambahTamu = New System.Windows.Forms.Button()
        Me.TxtNamaTamu = New System.Windows.Forms.TextBox()
        Me.GbJenisKelamin = New System.Windows.Forms.GroupBox()
        Me.RdBtnWanita = New System.Windows.Forms.RadioButton()
        Me.RdBtnPria = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbJenisKelamin.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(18, 39)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(331, 40)
        Me.Panel1.TabIndex = 85
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(45, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PENDAFTARAN TAMU"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(18, 20)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(331, 78)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 97
        Me.PictureBox3.TabStop = False
        '
        'BtnBatal
        '
        Me.BtnBatal.BackColor = System.Drawing.Color.Black
        Me.BtnBatal.ForeColor = System.Drawing.Color.White
        Me.BtnBatal.Location = New System.Drawing.Point(55, 369)
        Me.BtnBatal.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(126, 33)
        Me.BtnBatal.TabIndex = 104
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(55, 353)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 15)
        Me.Label8.TabIndex = 105
        Me.Label8.Text = "* Required"
        '
        'RtbAlamat
        '
        Me.RtbAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RtbAlamat.Location = New System.Drawing.Point(54, 277)
        Me.RtbAlamat.Margin = New System.Windows.Forms.Padding(2)
        Me.RtbAlamat.Name = "RtbAlamat"
        Me.RtbAlamat.Size = New System.Drawing.Size(254, 65)
        Me.RtbAlamat.TabIndex = 113
        Me.RtbAlamat.Text = ""
        '
        'TxtNIK
        '
        Me.TxtNIK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNIK.Location = New System.Drawing.Point(54, 184)
        Me.TxtNIK.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNIK.Name = "TxtNIK"
        Me.TxtNIK.Size = New System.Drawing.Size(253, 23)
        Me.TxtNIK.TabIndex = 112
        '
        'BtnTambahTamu
        '
        Me.BtnTambahTamu.BackColor = System.Drawing.Color.Black
        Me.BtnTambahTamu.ForeColor = System.Drawing.Color.White
        Me.BtnTambahTamu.Location = New System.Drawing.Point(185, 369)
        Me.BtnTambahTamu.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnTambahTamu.Name = "BtnTambahTamu"
        Me.BtnTambahTamu.Size = New System.Drawing.Size(122, 33)
        Me.BtnTambahTamu.TabIndex = 106
        Me.BtnTambahTamu.Text = "Tambah"
        Me.BtnTambahTamu.UseVisualStyleBackColor = False
        '
        'TxtNamaTamu
        '
        Me.TxtNamaTamu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNamaTamu.Location = New System.Drawing.Point(54, 139)
        Me.TxtNamaTamu.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNamaTamu.Name = "TxtNamaTamu"
        Me.TxtNamaTamu.Size = New System.Drawing.Size(253, 23)
        Me.TxtNamaTamu.TabIndex = 111
        '
        'GbJenisKelamin
        '
        Me.GbJenisKelamin.BackColor = System.Drawing.Color.Transparent
        Me.GbJenisKelamin.Controls.Add(Me.RdBtnWanita)
        Me.GbJenisKelamin.Controls.Add(Me.RdBtnPria)
        Me.GbJenisKelamin.ForeColor = System.Drawing.Color.White
        Me.GbJenisKelamin.Location = New System.Drawing.Point(54, 206)
        Me.GbJenisKelamin.Margin = New System.Windows.Forms.Padding(2)
        Me.GbJenisKelamin.Name = "GbJenisKelamin"
        Me.GbJenisKelamin.Padding = New System.Windows.Forms.Padding(2)
        Me.GbJenisKelamin.Size = New System.Drawing.Size(253, 43)
        Me.GbJenisKelamin.TabIndex = 107
        Me.GbJenisKelamin.TabStop = False
        Me.GbJenisKelamin.Text = "Jenis Kelamin *"
        '
        'RdBtnWanita
        '
        Me.RdBtnWanita.AutoSize = True
        Me.RdBtnWanita.Location = New System.Drawing.Point(142, 21)
        Me.RdBtnWanita.Margin = New System.Windows.Forms.Padding(2)
        Me.RdBtnWanita.Name = "RdBtnWanita"
        Me.RdBtnWanita.Size = New System.Drawing.Size(62, 19)
        Me.RdBtnWanita.TabIndex = 1
        Me.RdBtnWanita.TabStop = True
        Me.RdBtnWanita.Text = "Wanita"
        Me.RdBtnWanita.UseVisualStyleBackColor = True
        '
        'RdBtnPria
        '
        Me.RdBtnPria.AutoSize = True
        Me.RdBtnPria.Location = New System.Drawing.Point(9, 21)
        Me.RdBtnPria.Margin = New System.Windows.Forms.Padding(2)
        Me.RdBtnPria.Name = "RdBtnPria"
        Me.RdBtnPria.Size = New System.Drawing.Size(45, 19)
        Me.RdBtnPria.TabIndex = 0
        Me.RdBtnPria.TabStop = True
        Me.RdBtnPria.Text = "Pria"
        Me.RdBtnPria.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(54, 263)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 15)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Alamat *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(54, 125)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Nama Lengkap *"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(54, 170)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "No Identitas *"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 102)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(340, 316)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 120
        Me.PictureBox1.TabStop = False
        '
        'TambahTamu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(360, 431)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.RtbAlamat)
        Me.Controls.Add(Me.TxtNIK)
        Me.Controls.Add(Me.BtnTambahTamu)
        Me.Controls.Add(Me.TxtNamaTamu)
        Me.Controls.Add(Me.GbJenisKelamin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TambahTamu"
        Me.Text = "TambahTamu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbJenisKelamin.ResumeLayout(False)
        Me.GbJenisKelamin.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BtnBatal As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents RtbAlamat As RichTextBox
    Friend WithEvents TxtNIK As TextBox
    Friend WithEvents BtnTambahTamu As Button
    Friend WithEvents TxtNamaTamu As TextBox
    Friend WithEvents GbJenisKelamin As GroupBox
    Friend WithEvents RdBtnWanita As RadioButton
    Friend WithEvents RdBtnPria As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
