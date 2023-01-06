<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Penginapan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Penginapan))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ToolStripBtnPenginapan = New System.Windows.Forms.ToolStripDropDownButton()
        Me.FormJenisKamar = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormKamar = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormTamu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.LblJam = New System.Windows.Forms.Label()
        Me.LblTgl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.PbUser = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnBooking = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblTerpakai = New System.Windows.Forms.Label()
        Me.LblKosong = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewCheckout = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewCheckin = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewReserved = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridViewCheckout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridViewCheckin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewReserved, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(11, 36)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(856, 117)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 113
        Me.PictureBox3.TabStop = False
        '
        'ToolStripBtnPenginapan
        '
        Me.ToolStripBtnPenginapan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripBtnPenginapan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormJenisKamar, Me.FormKamar, Me.FormTamu})
        Me.ToolStripBtnPenginapan.Image = CType(resources.GetObject("ToolStripBtnPenginapan.Image"), System.Drawing.Image)
        Me.ToolStripBtnPenginapan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnPenginapan.Name = "ToolStripBtnPenginapan"
        Me.ToolStripBtnPenginapan.Size = New System.Drawing.Size(26, 22)
        Me.ToolStripBtnPenginapan.Text = "ToolStripDropDownButton1"
        '
        'FormJenisKamar
        '
        Me.FormJenisKamar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormJenisKamar.Name = "FormJenisKamar"
        Me.FormJenisKamar.Size = New System.Drawing.Size(191, 22)
        Me.FormJenisKamar.Text = "[1] Form Jenis Kamar"
        '
        'FormKamar
        '
        Me.FormKamar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormKamar.Name = "FormKamar"
        Me.FormKamar.Size = New System.Drawing.Size(191, 22)
        Me.FormKamar.Text = "[2] Form Kamar"
        '
        'FormTamu
        '
        Me.FormTamu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormTamu.Name = "FormTamu"
        Me.FormTamu.Size = New System.Drawing.Size(191, 22)
        Me.FormTamu.Text = "[3] Form Tamu"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(13, 13)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBtnPenginapan})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(877, 25)
        Me.ToolStrip1.TabIndex = 90
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'LblJam
        '
        Me.LblJam.ForeColor = System.Drawing.Color.White
        Me.LblJam.Location = New System.Drawing.Point(789, 166)
        Me.LblJam.Name = "LblJam"
        Me.LblJam.Size = New System.Drawing.Size(78, 15)
        Me.LblJam.TabIndex = 111
        Me.LblJam.Text = "01:23:40 AM"
        '
        'LblTgl
        '
        Me.LblTgl.ForeColor = System.Drawing.Color.White
        Me.LblTgl.Location = New System.Drawing.Point(789, 182)
        Me.LblTgl.Name = "LblTgl"
        Me.LblTgl.Size = New System.Drawing.Size(78, 15)
        Me.LblTgl.TabIndex = 112
        Me.LblTgl.Text = "15/12/2022"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(105, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SISTEM PERHOTELAN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(631, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 21)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Hello,"
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblUser.ForeColor = System.Drawing.Color.White
        Me.LblUser.Location = New System.Drawing.Point(676, 23)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(44, 21)
        Me.LblUser.TabIndex = 34
        Me.LblUser.Text = "User"
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.BackColor = System.Drawing.Color.Transparent
        Me.LblEmail.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblEmail.ForeColor = System.Drawing.Color.White
        Me.LblEmail.Location = New System.Drawing.Point(631, 42)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(138, 21)
        Me.LblEmail.TabIndex = 35
        Me.LblEmail.Text = "User@gmail.com"
        '
        'PbUser
        '
        Me.PbUser.BackColor = System.Drawing.Color.White
        Me.PbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbUser.Location = New System.Drawing.Point(786, 16)
        Me.PbUser.Name = "PbUser"
        Me.PbUser.Size = New System.Drawing.Size(55, 53)
        Me.PbUser.TabIndex = 36
        Me.PbUser.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Papyrus", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(100, 12)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(245, 38)
        Me.Label14.TabIndex = 107
        Me.Label14.Text = "HOTEL AYO'S"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.PbUser)
        Me.Panel1.Controls.Add(Me.LblEmail)
        Me.Panel1.Controls.Add(Me.LblUser)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(11, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(856, 83)
        Me.Panel1.TabIndex = 109
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.Black
        Me.BtnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLogout.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnLogout.Location = New System.Drawing.Point(108, 166)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(91, 29)
        Me.BtnLogout.TabIndex = 108
        Me.BtnLogout.Text = "Log Out"
        Me.BtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'BtnBooking
        '
        Me.BtnBooking.BackColor = System.Drawing.Color.Black
        Me.BtnBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBooking.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnBooking.Location = New System.Drawing.Point(11, 166)
        Me.BtnBooking.Name = "BtnBooking"
        Me.BtnBooking.Size = New System.Drawing.Size(91, 29)
        Me.BtnBooking.TabIndex = 106
        Me.BtnBooking.Text = "Booking"
        Me.BtnBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBooking.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblTerpakai)
        Me.GroupBox1.Controls.Add(Me.LblKosong)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 201)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(855, 209)
        Me.GroupBox1.TabIndex = 115
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMASI DATA"
        '
        'LblTerpakai
        '
        Me.LblTerpakai.AutoSize = True
        Me.LblTerpakai.Location = New System.Drawing.Point(176, 185)
        Me.LblTerpakai.Name = "LblTerpakai"
        Me.LblTerpakai.Size = New System.Drawing.Size(50, 16)
        Me.LblTerpakai.TabIndex = 10
        Me.LblTerpakai.Text = "Jumlah"
        '
        'LblKosong
        '
        Me.LblKosong.AutoSize = True
        Me.LblKosong.Location = New System.Drawing.Point(177, 167)
        Me.LblKosong.Name = "LblKosong"
        Me.LblKosong.Size = New System.Drawing.Size(50, 16)
        Me.LblKosong.TabIndex = 9
        Me.LblKosong.Text = "Jumlah"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(165, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = ":" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(165, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = ":" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 16)
        Me.Label5.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jumlah Kamar Terpakai " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Jumlah Kamar Kosong " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridViewCheckout)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Red
        Me.GroupBox4.Location = New System.Drawing.Point(570, 18)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(276, 145)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Checkout"
        '
        'DataGridViewCheckout
        '
        Me.DataGridViewCheckout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCheckout.Location = New System.Drawing.Point(7, 22)
        Me.DataGridViewCheckout.Name = "DataGridViewCheckout"
        Me.DataGridViewCheckout.RowTemplate.Height = 25
        Me.DataGridViewCheckout.Size = New System.Drawing.Size(263, 111)
        Me.DataGridViewCheckout.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridViewCheckin)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox3.Location = New System.Drawing.Point(288, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(276, 145)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Checkin"
        '
        'DataGridViewCheckin
        '
        Me.DataGridViewCheckin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCheckin.Location = New System.Drawing.Point(6, 22)
        Me.DataGridViewCheckin.Name = "DataGridViewCheckin"
        Me.DataGridViewCheckin.RowTemplate.Height = 25
        Me.DataGridViewCheckin.Size = New System.Drawing.Size(263, 111)
        Me.DataGridViewCheckin.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridViewReserved)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(6, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(276, 145)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reserved"
        '
        'DataGridViewReserved
        '
        Me.DataGridViewReserved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewReserved.Location = New System.Drawing.Point(6, 22)
        Me.DataGridViewReserved.Name = "DataGridViewReserved"
        Me.DataGridViewReserved.RowTemplate.Height = 25
        Me.DataGridViewReserved.Size = New System.Drawing.Size(263, 111)
        Me.DataGridViewReserved.TabIndex = 0
        '
        'Penginapan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(877, 419)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnBooking)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblTgl)
        Me.Controls.Add(Me.LblJam)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Name = "Penginapan"
        Me.Text = "Penginapan"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridViewCheckout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridViewCheckin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridViewReserved, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ToolStripBtnPenginapan As ToolStripDropDownButton
    Friend WithEvents FormJenisKamar As ToolStripMenuItem
    Friend WithEvents FormKamar As ToolStripMenuItem
    Friend WithEvents FormTamu As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents LblJam As Label
    Friend WithEvents LblTgl As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LblUser As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents PbUser As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnBooking As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblTerpakai As Label
    Friend WithEvents LblKosong As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DataGridViewCheckout As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridViewCheckin As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridViewReserved As DataGridView
End Class
