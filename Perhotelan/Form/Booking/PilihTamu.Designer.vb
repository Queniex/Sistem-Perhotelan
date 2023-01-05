<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PilihTamu
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
        Me.BtnPilihDataTamu = New System.Windows.Forms.Button()
        Me.BtnBatalDataTamu = New System.Windows.Forms.Button()
        Me.LblDataTamu = New System.Windows.Forms.Label()
        Me.DataGridViewDataTamu = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewDataTamu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnPilihDataTamu
        '
        Me.BtnPilihDataTamu.BackColor = System.Drawing.Color.Black
        Me.BtnPilihDataTamu.ForeColor = System.Drawing.Color.White
        Me.BtnPilihDataTamu.Location = New System.Drawing.Point(149, 264)
        Me.BtnPilihDataTamu.Name = "BtnPilihDataTamu"
        Me.BtnPilihDataTamu.Size = New System.Drawing.Size(109, 32)
        Me.BtnPilihDataTamu.TabIndex = 111
        Me.BtnPilihDataTamu.Text = "Pilih"
        Me.BtnPilihDataTamu.UseVisualStyleBackColor = False
        '
        'BtnBatalDataTamu
        '
        Me.BtnBatalDataTamu.BackColor = System.Drawing.Color.Black
        Me.BtnBatalDataTamu.ForeColor = System.Drawing.Color.White
        Me.BtnBatalDataTamu.Location = New System.Drawing.Point(34, 264)
        Me.BtnBatalDataTamu.Name = "BtnBatalDataTamu"
        Me.BtnBatalDataTamu.Size = New System.Drawing.Size(109, 32)
        Me.BtnBatalDataTamu.TabIndex = 110
        Me.BtnBatalDataTamu.Text = "Batal"
        Me.BtnBatalDataTamu.UseVisualStyleBackColor = False
        '
        'LblDataTamu
        '
        Me.LblDataTamu.AutoSize = True
        Me.LblDataTamu.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblDataTamu.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblDataTamu.Location = New System.Drawing.Point(48, 9)
        Me.LblDataTamu.Name = "LblDataTamu"
        Me.LblDataTamu.Size = New System.Drawing.Size(191, 33)
        Me.LblDataTamu.TabIndex = 109
        Me.LblDataTamu.Text = "DATA TAMU"
        '
        'DataGridViewDataTamu
        '
        Me.DataGridViewDataTamu.BackgroundColor = System.Drawing.Color.Black
        Me.DataGridViewDataTamu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewDataTamu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDataTamu.Location = New System.Drawing.Point(12, 58)
        Me.DataGridViewDataTamu.Name = "DataGridViewDataTamu"
        Me.DataGridViewDataTamu.RowHeadersWidth = 62
        Me.DataGridViewDataTamu.RowTemplate.Height = 25
        Me.DataGridViewDataTamu.Size = New System.Drawing.Size(268, 199)
        Me.DataGridViewDataTamu.TabIndex = 108
        '
        'PilihTamu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(292, 308)
        Me.Controls.Add(Me.BtnPilihDataTamu)
        Me.Controls.Add(Me.BtnBatalDataTamu)
        Me.Controls.Add(Me.LblDataTamu)
        Me.Controls.Add(Me.DataGridViewDataTamu)
        Me.Name = "PilihTamu"
        Me.Text = "PilihTamu"
        CType(Me.DataGridViewDataTamu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnPilihDataTamu As Button
    Friend WithEvents BtnBatalDataTamu As Button
    Friend WithEvents LblDataTamu As Label
    Friend WithEvents DataGridViewDataTamu As DataGridView
End Class
