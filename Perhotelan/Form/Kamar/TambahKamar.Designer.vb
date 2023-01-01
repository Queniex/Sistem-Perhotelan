<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahKamar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TambahKamar))
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtBoxNamaKamar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbJenisKamar = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RdBtnBelumTerisi = New System.Windows.Forms.RadioButton()
        Me.RdBtnTerisi = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackColor = System.Drawing.Color.Black
        Me.BtnSimpan.ForeColor = System.Drawing.Color.White
        Me.BtnSimpan.Location = New System.Drawing.Point(326, 460)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(91, 23)
        Me.BtnSimpan.TabIndex = 67
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = False
        '
        'BtnBatal
        '
        Me.BtnBatal.BackColor = System.Drawing.Color.Black
        Me.BtnBatal.ForeColor = System.Drawing.Color.White
        Me.BtnBatal.Location = New System.Drawing.Point(230, 460)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(91, 23)
        Me.BtnBatal.TabIndex = 66
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtBoxNamaKamar)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CbJenisKamar)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 276)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit Kamar"
        '
        'TxtBoxNamaKamar
        '
        Me.TxtBoxNamaKamar.BackColor = System.Drawing.SystemColors.Menu
        Me.TxtBoxNamaKamar.Location = New System.Drawing.Point(167, 50)
        Me.TxtBoxNamaKamar.Name = "TxtBoxNamaKamar"
        Me.TxtBoxNamaKamar.Size = New System.Drawing.Size(187, 23)
        Me.TxtBoxNamaKamar.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(43, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 16)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Nama Kamar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(150, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(9, 16)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = ":"
        '
        'CbJenisKamar
        '
        Me.CbJenisKamar.FormattingEnabled = True
        Me.CbJenisKamar.Location = New System.Drawing.Point(167, 96)
        Me.CbJenisKamar.Name = "CbJenisKamar"
        Me.CbJenisKamar.Size = New System.Drawing.Size(187, 24)
        Me.CbJenisKamar.TabIndex = 28
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RdBtnBelumTerisi)
        Me.GroupBox3.Controls.Add(Me.RdBtnTerisi)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(167, 141)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(187, 105)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pilih Status"
        '
        'RdBtnBelumTerisi
        '
        Me.RdBtnBelumTerisi.AutoSize = True
        Me.RdBtnBelumTerisi.Location = New System.Drawing.Point(43, 61)
        Me.RdBtnBelumTerisi.Name = "RdBtnBelumTerisi"
        Me.RdBtnBelumTerisi.Size = New System.Drawing.Size(87, 20)
        Me.RdBtnBelumTerisi.TabIndex = 1
        Me.RdBtnBelumTerisi.TabStop = True
        Me.RdBtnBelumTerisi.Text = "Belum Terisi"
        Me.RdBtnBelumTerisi.UseVisualStyleBackColor = True
        '
        'RdBtnTerisi
        '
        Me.RdBtnTerisi.AutoSize = True
        Me.RdBtnTerisi.Location = New System.Drawing.Point(43, 33)
        Me.RdBtnTerisi.Name = "RdBtnTerisi"
        Me.RdBtnTerisi.Size = New System.Drawing.Size(51, 20)
        Me.RdBtnTerisi.TabIndex = 0
        Me.RdBtnTerisi.TabStop = True
        Me.RdBtnTerisi.Text = "Terisi"
        Me.RdBtnTerisi.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(150, 139)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(9, 16)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(150, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(9, 16)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Jenis Kamar"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Location = New System.Drawing.Point(12, 47)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(405, 60)
        Me.Panel6.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TAMBAH KAMAR"
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Panel5.Location = New System.Drawing.Point(12, 12)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(405, 130)
        Me.Panel5.TabIndex = 64
        '
        'TambahKamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(430, 493)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Name = "TambahKamar"
        Me.Text = "TambahKamar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtBoxNamaKamar As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CbJenisKamar As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RdBtnBelumTerisi As RadioButton
    Friend WithEvents RdBtnTerisi As RadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
End Class
