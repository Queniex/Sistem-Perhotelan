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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Penginapan))
        Me.BtnBooking = New System.Windows.Forms.Button()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.DataGridViewPenginapan = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripBtnPenginapan = New System.Windows.Forms.ToolStripDropDownButton()
        Me.FormJenisKamar = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormKamar = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormTamu = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormBukuTamu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewPenginapan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBooking
        '
        Me.BtnBooking.BackColor = System.Drawing.Color.Black
        Me.BtnBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBooking.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnBooking.Location = New System.Drawing.Point(11, 173)
        Me.BtnBooking.Name = "BtnBooking"
        Me.BtnBooking.Size = New System.Drawing.Size(91, 29)
        Me.BtnBooking.TabIndex = 106
        Me.BtnBooking.Text = "Booking"
        Me.BtnBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBooking.UseVisualStyleBackColor = False
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.Black
        Me.BtnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLogout.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnLogout.Location = New System.Drawing.Point(108, 173)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(91, 29)
        Me.BtnLogout.TabIndex = 108
        Me.BtnLogout.Text = "Log Out"
        Me.BtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'DataGridViewPenginapan
        '
        Me.DataGridViewPenginapan.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridViewPenginapan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPenginapan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No})
        Me.DataGridViewPenginapan.GridColor = System.Drawing.Color.Black
        Me.DataGridViewPenginapan.Location = New System.Drawing.Point(8, 208)
        Me.DataGridViewPenginapan.Name = "DataGridViewPenginapan"
        Me.DataGridViewPenginapan.RowHeadersWidth = 62
        Me.DataGridViewPenginapan.RowTemplate.Height = 25
        Me.DataGridViewPenginapan.Size = New System.Drawing.Size(684, 193)
        Me.DataGridViewPenginapan.TabIndex = 107
        '
        'No
        '
        Me.No.HeaderText = "No"
        Me.No.MinimumWidth = 8
        Me.No.Name = "No"
        Me.No.Width = 150
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.LblEmail)
        Me.Panel1.Controls.Add(Me.LblUser)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(8, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(685, 83)
        Me.Panel1.TabIndex = 109
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Papyrus", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(100, 16)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(245, 38)
        Me.Label14.TabIndex = 107
        Me.Label14.Text = "HOTEL AYO'S"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(600, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(84, 82)
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.BackColor = System.Drawing.Color.Transparent
        Me.LblEmail.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblEmail.ForeColor = System.Drawing.Color.White
        Me.LblEmail.Location = New System.Drawing.Point(443, 35)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(138, 21)
        Me.LblEmail.TabIndex = 35
        Me.LblEmail.Text = "User@gmail.com"
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblUser.ForeColor = System.Drawing.Color.White
        Me.LblUser.Location = New System.Drawing.Point(543, 16)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(44, 21)
        Me.LblUser.TabIndex = 34
        Me.LblUser.Text = "User"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(493, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 21)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Hello,"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(100, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SISTEM PERHOTELAN"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(614, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 15)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "15/12/2022"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(636, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 15)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "13 : 40 "
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBtnPenginapan})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(702, 31)
        Me.ToolStrip1.TabIndex = 110
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripBtnPenginapan
        '
        Me.ToolStripBtnPenginapan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripBtnPenginapan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormJenisKamar, Me.FormKamar, Me.FormTamu, Me.FormBukuTamu})
        Me.ToolStripBtnPenginapan.Image = CType(resources.GetObject("ToolStripBtnPenginapan.Image"), System.Drawing.Image)
        Me.ToolStripBtnPenginapan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnPenginapan.Name = "ToolStripBtnPenginapan"
        Me.ToolStripBtnPenginapan.Size = New System.Drawing.Size(37, 28)
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
        'FormBukuTamu
        '
        Me.FormBukuTamu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBukuTamu.Name = "FormBukuTamu"
        Me.FormBukuTamu.Size = New System.Drawing.Size(191, 22)
        Me.FormBukuTamu.Text = "[4] Form Buku Tamu"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(11, 42)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(680, 119)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 113
        Me.PictureBox3.TabStop = False
        '
        'Penginapan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(702, 408)
        Me.Controls.Add(Me.BtnBooking)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.DataGridViewPenginapan)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Name = "Penginapan"
        Me.Text = "Penginapan"
        CType(Me.DataGridViewPenginapan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBooking As Button
    Friend WithEvents BtnLogout As Button
    Friend WithEvents DataGridViewPenginapan As DataGridView
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblUser As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripBtnPenginapan As ToolStripDropDownButton
    Friend WithEvents FormJenisKamar As ToolStripMenuItem
    Friend WithEvents FormKamar As ToolStripMenuItem
    Friend WithEvents FormTamu As ToolStripMenuItem
    Friend WithEvents FormBukuTamu As ToolStripMenuItem
    Friend WithEvents PictureBox3 As PictureBox
End Class
