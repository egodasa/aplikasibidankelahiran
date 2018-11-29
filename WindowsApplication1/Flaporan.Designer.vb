<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Flaporan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Flaporan))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cjenis2 = New System.Windows.Forms.ComboBox()
        Me.Twaktu = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Bexit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MintCream
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Cjenis2)
        Me.GroupBox1.Controls.Add(Me.Twaktu)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 190)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Silahkan Pilih Waktu Laporan"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(95, 72)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(70, 23)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "CETAK"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Jenis Laporan"
        '
        'Cjenis2
        '
        Me.Cjenis2.FormattingEnabled = True
        Me.Cjenis2.Items.AddRange(New Object() {"Pemasukan dari Berobat Umum", "Pemasukan dari KB", "Pemasukan dari Kelahiran", "Pemasukan Keseluruhan"})
        Me.Cjenis2.Location = New System.Drawing.Point(95, 45)
        Me.Cjenis2.Name = "Cjenis2"
        Me.Cjenis2.Size = New System.Drawing.Size(214, 21)
        Me.Cjenis2.TabIndex = 23
        '
        'Twaktu
        '
        Me.Twaktu.CustomFormat = "MMMM yyyy"
        Me.Twaktu.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Twaktu.Location = New System.Drawing.Point(95, 19)
        Me.Twaktu.Name = "Twaktu"
        Me.Twaktu.Size = New System.Drawing.Size(214, 20)
        Me.Twaktu.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Waktu Laporan"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(12, 147)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(297, 30)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Laporan Daftar Pasien"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(12, 111)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(297, 30)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Laporan Daftar Bayi Lahir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Bexit
        '
        Me.Bexit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Bexit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bexit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bexit.Location = New System.Drawing.Point(259, 205)
        Me.Bexit.Name = "Bexit"
        Me.Bexit.Size = New System.Drawing.Size(75, 23)
        Me.Bexit.TabIndex = 18
        Me.Bexit.Text = "KELUAR"
        Me.Bexit.UseVisualStyleBackColor = False
        '
        'Flaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(347, 235)
        Me.Controls.Add(Me.Bexit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Flaporan"
        Me.Text = "Laporan Pemasukan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Bexit As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cjenis2 As System.Windows.Forms.ComboBox
    Friend WithEvents Twaktu As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
