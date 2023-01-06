<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JenisKamar_
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JenisKamar_))
        Me.ToolStripKamar_ = New System.Windows.Forms.ToolStrip()
        Me.ToolStripBtnJKamar = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnInfo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewJKamar = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.PbUser = New System.Windows.Forms.PictureBox()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolStripKamar_.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewJKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripKamar_
        '
        Me.ToolStripKamar_.Dock = System.Windows.Forms.DockStyle.Right
        Me.ToolStripKamar_.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStripKamar_.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBtnJKamar})
        Me.ToolStripKamar_.Location = New System.Drawing.Point(828, 0)
        Me.ToolStripKamar_.Name = "ToolStripKamar_"
        Me.ToolStripKamar_.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStripKamar_.Size = New System.Drawing.Size(30, 488)
        Me.ToolStripKamar_.TabIndex = 113
        Me.ToolStripKamar_.Text = "ToolStrip1"
        '
        'ToolStripBtnJKamar
        '
        Me.ToolStripBtnJKamar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripBtnJKamar.Image = CType(resources.GetObject("ToolStripBtnJKamar.Image"), System.Drawing.Image)
        Me.ToolStripBtnJKamar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnJKamar.Name = "ToolStripBtnJKamar"
        Me.ToolStripBtnJKamar.Size = New System.Drawing.Size(25, 28)
        Me.ToolStripBtnJKamar.Text = "ToolStripButton1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.BtnTambah)
        Me.Panel2.Controls.Add(Me.BtnHapus)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.BtnEdit)
        Me.Panel2.Controls.Add(Me.BtnInfo)
        Me.Panel2.Location = New System.Drawing.Point(9, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(812, 45)
        Me.Panel2.TabIndex = 115
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.DimGray
        Me.BtnTambah.BackgroundImage = CType(resources.GetObject("BtnTambah.BackgroundImage"), System.Drawing.Image)
        Me.BtnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnTambah.Location = New System.Drawing.Point(640, 5)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(36, 33)
        Me.BtnTambah.TabIndex = 103
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.DimGray
        Me.BtnHapus.BackgroundImage = CType(resources.GetObject("BtnHapus.BackgroundImage"), System.Drawing.Image)
        Me.BtnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnHapus.Location = New System.Drawing.Point(760, 5)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(39, 33)
        Me.BtnHapus.TabIndex = 99
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Papyrus", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(43, 2)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(274, 42)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "HOTEL AYO'S"
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.DimGray
        Me.BtnEdit.BackgroundImage = CType(resources.GetObject("BtnEdit.BackgroundImage"), System.Drawing.Image)
        Me.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnEdit.Location = New System.Drawing.Point(681, 5)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(35, 33)
        Me.BtnEdit.TabIndex = 98
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnInfo
        '
        Me.BtnInfo.BackColor = System.Drawing.Color.DimGray
        Me.BtnInfo.BackgroundImage = CType(resources.GetObject("BtnInfo.BackgroundImage"), System.Drawing.Image)
        Me.BtnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnInfo.Location = New System.Drawing.Point(720, 4)
        Me.BtnInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnInfo.Name = "BtnInfo"
        Me.BtnInfo.Size = New System.Drawing.Size(36, 34)
        Me.BtnInfo.TabIndex = 100
        Me.BtnInfo.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "JENIS KAMAR"
        '
        'DataGridViewJKamar
        '
        Me.DataGridViewJKamar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridViewJKamar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders
        Me.DataGridViewJKamar.BackgroundColor = System.Drawing.Color.Black
        Me.DataGridViewJKamar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewJKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewJKamar.Location = New System.Drawing.Point(9, 252)
        Me.DataGridViewJKamar.Name = "DataGridViewJKamar"
        Me.DataGridViewJKamar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewJKamar.RowTemplate.Height = 25
        Me.DataGridViewJKamar.Size = New System.Drawing.Size(468, 233)
        Me.DataGridViewJKamar.TabIndex = 116
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.BtnLogout)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(9, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(812, 53)
        Me.Panel1.TabIndex = 114
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.Black
        Me.BtnLogout.BackgroundImage = CType(resources.GetObject("BtnLogout.BackgroundImage"), System.Drawing.Image)
        Me.BtnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnLogout.Location = New System.Drawing.Point(761, 5)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(36, 33)
        Me.BtnLogout.TabIndex = 82
        Me.BtnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.Location = New System.Drawing.Point(486, 116)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(335, 130)
        Me.Panel4.TabIndex = 112
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Panel5.Location = New System.Drawing.Point(486, 253)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(335, 232)
        Me.Panel5.TabIndex = 113
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.LblEmail)
        Me.Panel3.Controls.Add(Me.PbUser)
        Me.Panel3.Controls.Add(Me.LblUser)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(9, 115)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(468, 130)
        Me.Panel3.TabIndex = 114
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(29, 96)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(249, 11)
        Me.Panel6.TabIndex = 100
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.BackColor = System.Drawing.Color.Transparent
        Me.LblEmail.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblEmail.ForeColor = System.Drawing.Color.Black
        Me.LblEmail.Location = New System.Drawing.Point(128, 51)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(138, 21)
        Me.LblEmail.TabIndex = 99
        Me.LblEmail.Text = "User@gmail.com"
        '
        'PbUser
        '
        Me.PbUser.Location = New System.Drawing.Point(29, 17)
        Me.PbUser.Name = "PbUser"
        Me.PbUser.Size = New System.Drawing.Size(76, 70)
        Me.PbUser.TabIndex = 0
        Me.PbUser.TabStop = False
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.BackColor = System.Drawing.Color.Transparent
        Me.LblUser.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblUser.ForeColor = System.Drawing.Color.Black
        Me.LblUser.Location = New System.Drawing.Point(175, 31)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(44, 21)
        Me.LblUser.TabIndex = 98
        Me.LblUser.Text = "User"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(128, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 21)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Hello,"
        '
        'JenisKamar_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(858, 488)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.ToolStripKamar_)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridViewJKamar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "JenisKamar_"
        Me.Text = "JenisKamar_"
        Me.ToolStripKamar_.ResumeLayout(False)
        Me.ToolStripKamar_.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridViewJKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PbUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStripKamar_ As ToolStrip
    Friend WithEvents ToolStripBtnJKamar As ToolStripButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnInfo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewJKamar As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnLogout As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents LblEmail As Label
    Friend WithEvents PbUser As PictureBox
    Friend WithEvents LblUser As Label
    Friend WithEvents Label7 As Label
End Class
