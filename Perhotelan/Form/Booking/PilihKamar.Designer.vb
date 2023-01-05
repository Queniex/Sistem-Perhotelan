<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PilihKamar
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
        Me.DataGridViewDataKamar = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBatalDataKamar = New System.Windows.Forms.Button()
        Me.BtnPilihDataKamar = New System.Windows.Forms.Button()
        CType(Me.DataGridViewDataKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewDataKamar
        '
        Me.DataGridViewDataKamar.BackgroundColor = System.Drawing.Color.Black
        Me.DataGridViewDataKamar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewDataKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDataKamar.Location = New System.Drawing.Point(12, 56)
        Me.DataGridViewDataKamar.Name = "DataGridViewDataKamar"
        Me.DataGridViewDataKamar.RowHeadersWidth = 62
        Me.DataGridViewDataKamar.RowTemplate.Height = 25
        Me.DataGridViewDataKamar.Size = New System.Drawing.Size(499, 199)
        Me.DataGridViewDataKamar.TabIndex = 104
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(163, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 33)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "DATA KAMAR"
        '
        'BtnBatalDataKamar
        '
        Me.BtnBatalDataKamar.BackColor = System.Drawing.Color.Black
        Me.BtnBatalDataKamar.ForeColor = System.Drawing.Color.White
        Me.BtnBatalDataKamar.Location = New System.Drawing.Point(287, 264)
        Me.BtnBatalDataKamar.Name = "BtnBatalDataKamar"
        Me.BtnBatalDataKamar.Size = New System.Drawing.Size(109, 32)
        Me.BtnBatalDataKamar.TabIndex = 106
        Me.BtnBatalDataKamar.Text = "Batal"
        Me.BtnBatalDataKamar.UseVisualStyleBackColor = False
        '
        'BtnPilihDataKamar
        '
        Me.BtnPilihDataKamar.BackColor = System.Drawing.Color.Black
        Me.BtnPilihDataKamar.ForeColor = System.Drawing.Color.White
        Me.BtnPilihDataKamar.Location = New System.Drawing.Point(402, 264)
        Me.BtnPilihDataKamar.Name = "BtnPilihDataKamar"
        Me.BtnPilihDataKamar.Size = New System.Drawing.Size(109, 32)
        Me.BtnPilihDataKamar.TabIndex = 107
        Me.BtnPilihDataKamar.Text = "Pilih"
        Me.BtnPilihDataKamar.UseVisualStyleBackColor = False
        '
        'PilihKamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(523, 308)
        Me.Controls.Add(Me.BtnPilihDataKamar)
        Me.Controls.Add(Me.BtnBatalDataKamar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewDataKamar)
        Me.Name = "PilihKamar"
        Me.Text = "PilihKamar"
        CType(Me.DataGridViewDataKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewDataKamar As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBatalDataKamar As Button
    Friend WithEvents BtnPilihDataKamar As Button
End Class
