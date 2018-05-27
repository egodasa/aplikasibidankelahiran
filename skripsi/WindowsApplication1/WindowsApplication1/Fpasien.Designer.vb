<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fpasien
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Ttgl_lahir = New System.Windows.Forms.DateTimePicker()
        Me.Talamat = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Tpekerjaan = New System.Windows.Forms.TextBox()
        Me.Cjk = New System.Windows.Forms.ComboBox()
        Me.Tnm_pasien = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Bcancel = New System.Windows.Forms.Button()
        Me.Bdelete = New System.Windows.Forms.Button()
        Me.Bedit = New System.Windows.Forms.Button()
        Me.Bexit = New System.Windows.Forms.Button()
        Me.Bsave = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Bcetak = New System.Windows.Forms.Button()
        Me.Tcari = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGpasien = New System.Windows.Forms.DataGridView()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGpasien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.MintCream
        Me.GroupBox2.Controls.Add(Me.Ttgl_lahir)
        Me.GroupBox2.Controls.Add(Me.Talamat)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Tpekerjaan)
        Me.GroupBox2.Controls.Add(Me.Cjk)
        Me.GroupBox2.Controls.Add(Me.Tnm_pasien)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(461, 172)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATA PASIEN"
        '
        'Ttgl_lahir
        '
        Me.Ttgl_lahir.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ttgl_lahir.Location = New System.Drawing.Point(118, 51)
        Me.Ttgl_lahir.Name = "Ttgl_lahir"
        Me.Ttgl_lahir.Size = New System.Drawing.Size(335, 23)
        Me.Ttgl_lahir.TabIndex = 11
        '
        'Talamat
        '
        Me.Talamat.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Talamat.Location = New System.Drawing.Point(118, 139)
        Me.Talamat.Name = "Talamat"
        Me.Talamat.Size = New System.Drawing.Size(335, 23)
        Me.Talamat.TabIndex = 10
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(6, 139)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 15)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "Alamat"
        '
        'Tpekerjaan
        '
        Me.Tpekerjaan.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tpekerjaan.Location = New System.Drawing.Point(118, 110)
        Me.Tpekerjaan.Name = "Tpekerjaan"
        Me.Tpekerjaan.Size = New System.Drawing.Size(335, 23)
        Me.Tpekerjaan.TabIndex = 8
        '
        'Cjk
        '
        Me.Cjk.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cjk.FormattingEnabled = True
        Me.Cjk.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.Cjk.Location = New System.Drawing.Point(118, 80)
        Me.Cjk.Name = "Cjk"
        Me.Cjk.Size = New System.Drawing.Size(335, 23)
        Me.Cjk.TabIndex = 1
        '
        'Tnm_pasien
        '
        Me.Tnm_pasien.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tnm_pasien.Location = New System.Drawing.Point(118, 22)
        Me.Tnm_pasien.Name = "Tnm_pasien"
        Me.Tnm_pasien.Size = New System.Drawing.Size(335, 23)
        Me.Tnm_pasien.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Pekerjaan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 15)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Jenis Kelamin"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 51)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 15)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Tanggal Lahir"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 15)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Nama Pasien"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MintCream
        Me.GroupBox1.Controls.Add(Me.Bcancel)
        Me.GroupBox1.Controls.Add(Me.Bdelete)
        Me.GroupBox1.Controls.Add(Me.Bedit)
        Me.GroupBox1.Controls.Add(Me.Bexit)
        Me.GroupBox1.Controls.Add(Me.Bsave)
        Me.GroupBox1.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(481, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(97, 168)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PROSES"
        '
        'Bcancel
        '
        Me.Bcancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Bcancel.Enabled = False
        Me.Bcancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bcancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bcancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bcancel.Location = New System.Drawing.Point(12, 100)
        Me.Bcancel.Name = "Bcancel"
        Me.Bcancel.Size = New System.Drawing.Size(75, 23)
        Me.Bcancel.TabIndex = 5
        Me.Bcancel.Text = "BATAL"
        Me.Bcancel.UseVisualStyleBackColor = False
        '
        'Bdelete
        '
        Me.Bdelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Bdelete.Enabled = False
        Me.Bdelete.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bdelete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bdelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bdelete.Location = New System.Drawing.Point(12, 71)
        Me.Bdelete.Name = "Bdelete"
        Me.Bdelete.Size = New System.Drawing.Size(75, 23)
        Me.Bdelete.TabIndex = 4
        Me.Bdelete.Text = "HAPUS"
        Me.Bdelete.UseVisualStyleBackColor = False
        '
        'Bedit
        '
        Me.Bedit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bedit.Enabled = False
        Me.Bedit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bedit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bedit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bedit.Location = New System.Drawing.Point(12, 42)
        Me.Bedit.Name = "Bedit"
        Me.Bedit.Size = New System.Drawing.Size(75, 23)
        Me.Bedit.TabIndex = 3
        Me.Bedit.Text = "UBAH"
        Me.Bedit.UseVisualStyleBackColor = False
        '
        'Bexit
        '
        Me.Bexit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Bexit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bexit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bexit.Location = New System.Drawing.Point(12, 129)
        Me.Bexit.Name = "Bexit"
        Me.Bexit.Size = New System.Drawing.Size(75, 23)
        Me.Bexit.TabIndex = 2
        Me.Bexit.Text = "KELUAR"
        Me.Bexit.UseVisualStyleBackColor = False
        '
        'Bsave
        '
        Me.Bsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bsave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bsave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bsave.Location = New System.Drawing.Point(12, 13)
        Me.Bsave.Name = "Bsave"
        Me.Bsave.Size = New System.Drawing.Size(75, 23)
        Me.Bsave.TabIndex = 1
        Me.Bsave.Text = "SIMPAN"
        Me.Bsave.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.MintCream
        Me.GroupBox3.Controls.Add(Me.Bcetak)
        Me.GroupBox3.Controls.Add(Me.Tcari)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.DGpasien)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 190)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(566, 202)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Daftar Pasien"
        '
        'Bcetak
        '
        Me.Bcetak.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bcetak.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bcetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bcetak.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bcetak.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bcetak.Location = New System.Drawing.Point(449, 16)
        Me.Bcetak.Name = "Bcetak"
        Me.Bcetak.Size = New System.Drawing.Size(107, 23)
        Me.Bcetak.TabIndex = 15
        Me.Bcetak.Text = "Cetak Kartu"
        Me.Bcetak.UseVisualStyleBackColor = False
        '
        'Tcari
        '
        Me.Tcari.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tcari.Location = New System.Drawing.Point(118, 16)
        Me.Tcari.Name = "Tcari"
        Me.Tcari.Size = New System.Drawing.Size(310, 23)
        Me.Tcari.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Cari pasien"
        '
        'DGpasien
        '
        Me.DGpasien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGpasien.Location = New System.Drawing.Point(9, 42)
        Me.DGpasien.Name = "DGpasien"
        Me.DGpasien.ReadOnly = True
        Me.DGpasien.Size = New System.Drawing.Size(547, 150)
        Me.DGpasien.TabIndex = 15
        '
        'Fpasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(585, 395)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Fpasien"
        Me.Text = "Form Pasien"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGpasien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Ttgl_lahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Talamat As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Tpekerjaan As System.Windows.Forms.TextBox
    Friend WithEvents Cjk As System.Windows.Forms.ComboBox
    Friend WithEvents Tnm_pasien As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Bexit As System.Windows.Forms.Button
    Friend WithEvents Bsave As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Tcari As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DGpasien As System.Windows.Forms.DataGridView
    Friend WithEvents Bcancel As System.Windows.Forms.Button
    Friend WithEvents Bdelete As System.Windows.Forms.Button
    Friend WithEvents Bedit As System.Windows.Forms.Button
    Friend WithEvents Bcetak As System.Windows.Forms.Button
End Class
