<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahJenisKamar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TambahJenisKamar))
        Me.BtnBatalKamar = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBoxHarga = New System.Windows.Forms.TextBox()
        Me.TxtBoxJKamar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnBatalKamar
        '
        Me.BtnBatalKamar.BackColor = System.Drawing.Color.Black
        Me.BtnBatalKamar.ForeColor = System.Drawing.Color.White
        Me.BtnBatalKamar.Location = New System.Drawing.Point(254, 583)
        Me.BtnBatalKamar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnBatalKamar.Name = "BtnBatalKamar"
        Me.BtnBatalKamar.Size = New System.Drawing.Size(156, 53)
        Me.BtnBatalKamar.TabIndex = 108
        Me.BtnBatalKamar.Text = "Batal"
        Me.BtnBatalKamar.UseVisualStyleBackColor = False
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackColor = System.Drawing.Color.Black
        Me.BtnSimpan.ForeColor = System.Drawing.Color.White
        Me.BtnSimpan.Location = New System.Drawing.Point(418, 583)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(156, 53)
        Me.BtnSimpan.TabIndex = 109
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(21, 77)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(553, 100)
        Me.Panel1.TabIndex = 106
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(92, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TAMBAH JENIS KAMAR"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtBoxHarga)
        Me.GroupBox1.Controls.Add(Me.TxtBoxJKamar)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(21, 263)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(553, 310)
        Me.GroupBox1.TabIndex = 110
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tambah Jenis Kamar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(225, 178)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 24)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 178)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 24)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Harga"
        '
        'TxtBoxHarga
        '
        Me.TxtBoxHarga.BackColor = System.Drawing.SystemColors.Menu
        Me.TxtBoxHarga.Location = New System.Drawing.Point(247, 172)
        Me.TxtBoxHarga.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxHarga.Name = "TxtBoxHarga"
        Me.TxtBoxHarga.Size = New System.Drawing.Size(244, 31)
        Me.TxtBoxHarga.TabIndex = 21
        '
        'TxtBoxJKamar
        '
        Me.TxtBoxJKamar.BackColor = System.Drawing.SystemColors.Menu
        Me.TxtBoxJKamar.Location = New System.Drawing.Point(247, 92)
        Me.TxtBoxJKamar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxJKamar.Name = "TxtBoxJKamar"
        Me.TxtBoxJKamar.Size = New System.Drawing.Size(244, 31)
        Me.TxtBoxJKamar.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(225, 98)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 24)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 98)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Jenis Kamar"
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.Location = New System.Drawing.Point(21, 19)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(553, 217)
        Me.Panel4.TabIndex = 107
        '
        'TambahJenisKamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(595, 654)
        Me.Controls.Add(Me.BtnBatalKamar)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "TambahJenisKamar"
        Me.Text = "TambahJenisKamar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnBatalKamar As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtBoxHarga As TextBox
    Friend WithEvents TxtBoxJKamar As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
End Class
