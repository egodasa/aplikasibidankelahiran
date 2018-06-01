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
        Me.Bcetak = New System.Windows.Forms.Button()
        Me.Takhir = New System.Windows.Forms.DateTimePicker()
        Me.Tawal = New System.Windows.Forms.DateTimePicker()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Btahun = New System.Windows.Forms.Button()
        Me.Bbulan = New System.Windows.Forms.Button()
        Me.Bharian = New System.Windows.Forms.Button()
        Me.Bexit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MintCream
        Me.GroupBox1.Controls.Add(Me.Bcetak)
        Me.GroupBox1.Controls.Add(Me.Takhir)
        Me.GroupBox1.Controls.Add(Me.Tawal)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Btahun)
        Me.GroupBox1.Controls.Add(Me.Bbulan)
        Me.GroupBox1.Controls.Add(Me.Bharian)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 144)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Silahkan Pilih Waktu Laporan"
        '
        'Bcetak
        '
        Me.Bcetak.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Bcetak.Enabled = False
        Me.Bcetak.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bcetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bcetak.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bcetak.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Bcetak.Location = New System.Drawing.Point(224, 102)
        Me.Bcetak.Name = "Bcetak"
        Me.Bcetak.Size = New System.Drawing.Size(88, 30)
        Me.Bcetak.TabIndex = 7
        Me.Bcetak.Text = "Cetak"
        Me.Bcetak.UseVisualStyleBackColor = False
        '
        'Takhir
        '
        Me.Takhir.Enabled = False
        Me.Takhir.Location = New System.Drawing.Point(156, 73)
        Me.Takhir.Name = "Takhir"
        Me.Takhir.Size = New System.Drawing.Size(156, 20)
        Me.Takhir.TabIndex = 6
        '
        'Tawal
        '
        Me.Tawal.Enabled = False
        Me.Tawal.Location = New System.Drawing.Point(156, 42)
        Me.Tawal.Name = "Tawal"
        Me.Tawal.Size = New System.Drawing.Size(156, 20)
        Me.Tawal.TabIndex = 5
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(156, 19)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(122, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Pilih Waktu Laporan"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Btahun
        '
        Me.Btahun.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btahun.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Btahun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btahun.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btahun.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btahun.Location = New System.Drawing.Point(15, 102)
        Me.Btahun.Name = "Btahun"
        Me.Btahun.Size = New System.Drawing.Size(88, 32)
        Me.Btahun.TabIndex = 2
        Me.Btahun.Text = "Tahun Ini"
        Me.Btahun.UseVisualStyleBackColor = False
        '
        'Bbulan
        '
        Me.Bbulan.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Bbulan.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bbulan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bbulan.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bbulan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Bbulan.Location = New System.Drawing.Point(15, 61)
        Me.Bbulan.Name = "Bbulan"
        Me.Bbulan.Size = New System.Drawing.Size(88, 32)
        Me.Bbulan.TabIndex = 1
        Me.Bbulan.Text = "Bulan Ini"
        Me.Bbulan.UseVisualStyleBackColor = False
        '
        'Bharian
        '
        Me.Bharian.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Bharian.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bharian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bharian.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bharian.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Bharian.Location = New System.Drawing.Point(15, 19)
        Me.Bharian.Name = "Bharian"
        Me.Bharian.Size = New System.Drawing.Size(88, 32)
        Me.Bharian.TabIndex = 0
        Me.Bharian.Text = "Hari Ini"
        Me.Bharian.UseVisualStyleBackColor = False
        '
        'Bexit
        '
        Me.Bexit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Bexit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bexit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bexit.Location = New System.Drawing.Point(259, 159)
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
        Me.ClientSize = New System.Drawing.Size(340, 186)
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
    Friend WithEvents Btahun As System.Windows.Forms.Button
    Friend WithEvents Bbulan As System.Windows.Forms.Button
    Friend WithEvents Bharian As System.Windows.Forms.Button
    Friend WithEvents Bcetak As System.Windows.Forms.Button
    Friend WithEvents Takhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Tawal As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Bexit As System.Windows.Forms.Button
End Class
