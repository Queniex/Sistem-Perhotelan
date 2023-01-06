<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditBookingKamar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditBookingKamar))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbBooking = New System.Windows.Forms.ComboBox()
        Me.CbTamu = New System.Windows.Forms.ComboBox()
        Me.LblTotalBayar = New System.Windows.Forms.Label()
        Me.CbStatusKamar = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DtpCheckOut = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DtpCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnEditBookingKamar = New System.Windows.Forms.Button()
        Me.BtnBatalKamar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CbBooking)
        Me.GroupBox1.Controls.Add(Me.CbTamu)
        Me.GroupBox1.Controls.Add(Me.LblTotalBayar)
        Me.GroupBox1.Controls.Add(Me.CbStatusKamar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DtpCheckOut)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.DtpCheckIn)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(15, 167)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 235)
        Me.GroupBox1.TabIndex = 92
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit Pemesanan"
        '
        'CbBooking
        '
        Me.CbBooking.FormattingEnabled = True
        Me.CbBooking.Location = New System.Drawing.Point(162, 32)
        Me.CbBooking.Name = "CbBooking"
        Me.CbBooking.Size = New System.Drawing.Size(187, 23)
        Me.CbBooking.TabIndex = 114
        '
        'CbTamu
        '
        Me.CbTamu.FormattingEnabled = True
        Me.CbTamu.Location = New System.Drawing.Point(162, 65)
        Me.CbTamu.Name = "CbTamu"
        Me.CbTamu.Size = New System.Drawing.Size(187, 23)
        Me.CbTamu.TabIndex = 113
        '
        'LblTotalBayar
        '
        Me.LblTotalBayar.AutoSize = True
        Me.LblTotalBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTotalBayar.ForeColor = System.Drawing.Color.Red
        Me.LblTotalBayar.Location = New System.Drawing.Point(167, 164)
        Me.LblTotalBayar.Name = "LblTotalBayar"
        Me.LblTotalBayar.Size = New System.Drawing.Size(79, 15)
        Me.LblTotalBayar.TabIndex = 112
        Me.LblTotalBayar.Text = "Total Bayar"
        '
        'CbStatusKamar
        '
        Me.CbStatusKamar.FormattingEnabled = True
        Me.CbStatusKamar.Items.AddRange(New Object() {"Reserved", "Check In", "Check Out"})
        Me.CbStatusKamar.Location = New System.Drawing.Point(163, 190)
        Me.CbStatusKamar.Name = "CbStatusKamar"
        Me.CbStatusKamar.Size = New System.Drawing.Size(187, 23)
        Me.CbStatusKamar.TabIndex = 111
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(31, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Nama Kamar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(150, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 15)
        Me.Label6.TabIndex = 110
        Me.Label6.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 15)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Nama Tamu"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(30, 193)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 15)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "Status Kamar"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(32, 135)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(111, 15)
        Me.Label16.TabIndex = 98
        Me.Label16.Text = "Tanggal Check Out"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(150, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 15)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(31, 100)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 15)
        Me.Label15.TabIndex = 97
        Me.Label15.Text = "Tanggal Check In"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 15)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "Total Bayar"
        '
        'DtpCheckOut
        '
        Me.DtpCheckOut.CalendarMonthBackground = System.Drawing.SystemColors.Menu
        Me.DtpCheckOut.Location = New System.Drawing.Point(163, 130)
        Me.DtpCheckOut.Name = "DtpCheckOut"
        Me.DtpCheckOut.Size = New System.Drawing.Size(187, 21)
        Me.DtpCheckOut.TabIndex = 104
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(148, 100)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(10, 15)
        Me.Label18.TabIndex = 102
        Me.Label18.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(148, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(10, 15)
        Me.Label9.TabIndex = 99
        Me.Label9.Text = ":"
        '
        'DtpCheckIn
        '
        Me.DtpCheckIn.CalendarMonthBackground = System.Drawing.SystemColors.Menu
        Me.DtpCheckIn.Location = New System.Drawing.Point(162, 98)
        Me.DtpCheckIn.Name = "DtpCheckIn"
        Me.DtpCheckIn.Size = New System.Drawing.Size(187, 21)
        Me.DtpCheckIn.TabIndex = 101
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(149, 135)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(10, 15)
        Me.Label19.TabIndex = 103
        Me.Label19.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(148, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(10, 15)
        Me.Label11.TabIndex = 100
        Me.Label11.Text = ":"
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.Location = New System.Drawing.Point(15, 15)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(378, 130)
        Me.Panel4.TabIndex = 89
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(58, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EDIT BOOKING KAMAR"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(15, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(378, 60)
        Me.Panel1.TabIndex = 88
        '
        'BtnEditBookingKamar
        '
        Me.BtnEditBookingKamar.BackColor = System.Drawing.Color.Black
        Me.BtnEditBookingKamar.ForeColor = System.Drawing.Color.White
        Me.BtnEditBookingKamar.Location = New System.Drawing.Point(284, 407)
        Me.BtnEditBookingKamar.Name = "BtnEditBookingKamar"
        Me.BtnEditBookingKamar.Size = New System.Drawing.Size(109, 32)
        Me.BtnEditBookingKamar.TabIndex = 94
        Me.BtnEditBookingKamar.Text = "Edit"
        Me.BtnEditBookingKamar.UseVisualStyleBackColor = False
        '
        'BtnBatalKamar
        '
        Me.BtnBatalKamar.BackColor = System.Drawing.Color.Black
        Me.BtnBatalKamar.ForeColor = System.Drawing.Color.White
        Me.BtnBatalKamar.Location = New System.Drawing.Point(169, 407)
        Me.BtnBatalKamar.Name = "BtnBatalKamar"
        Me.BtnBatalKamar.Size = New System.Drawing.Size(109, 32)
        Me.BtnBatalKamar.TabIndex = 93
        Me.BtnBatalKamar.Text = "Batal"
        Me.BtnBatalKamar.UseVisualStyleBackColor = False
        '
        'EditBookingKamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(408, 448)
        Me.Controls.Add(Me.BtnEditBookingKamar)
        Me.Controls.Add(Me.BtnBatalKamar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "EditBookingKamar"
        Me.Text = "EditBookingKamar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblTotalBayar As Label
    Friend WithEvents CbStatusKamar As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DtpCheckOut As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DtpCheckIn As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnEditBookingKamar As Button
    Friend WithEvents BtnBatalKamar As Button
    Friend WithEvents CbBooking As ComboBox
    Friend WithEvents CbTamu As ComboBox
End Class
