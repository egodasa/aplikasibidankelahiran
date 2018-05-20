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
        Me.Bexit = New System.Windows.Forms.Button()
        Me.Bsave = New System.Windows.Forms.Button()
        Me.DGpasien = New System.Windows.Forms.DataGridView()
        Me.Tcari = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGpasien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
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
        Me.GroupBox2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(481, 203)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATA PASIEN"
        '
        'Ttgl_lahir
        '
        Me.Ttgl_lahir.Location = New System.Drawing.Point(143, 60)
        Me.Ttgl_lahir.Name = "Ttgl_lahir"
        Me.Ttgl_lahir.Size = New System.Drawing.Size(331, 23)
        Me.Ttgl_lahir.TabIndex = 11
        '
        'Talamat
        '
        Me.Talamat.Location = New System.Drawing.Point(140, 164)
        Me.Talamat.Name = "Talamat"
        Me.Talamat.Size = New System.Drawing.Size(335, 23)
        Me.Talamat.TabIndex = 10
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(21, 164)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(53, 14)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "Alamat"
        '
        'Tpekerjaan
        '
        Me.Tpekerjaan.Location = New System.Drawing.Point(140, 130)
        Me.Tpekerjaan.Name = "Tpekerjaan"
        Me.Tpekerjaan.Size = New System.Drawing.Size(335, 23)
        Me.Tpekerjaan.TabIndex = 8
        '
        'Cjk
        '
        Me.Cjk.FormattingEnabled = True
        Me.Cjk.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.Cjk.Location = New System.Drawing.Point(140, 94)
        Me.Cjk.Name = "Cjk"
        Me.Cjk.Size = New System.Drawing.Size(335, 24)
        Me.Cjk.TabIndex = 1
        '
        'Tnm_pasien
        '
        Me.Tnm_pasien.Location = New System.Drawing.Point(140, 22)
        Me.Tnm_pasien.Name = "Tnm_pasien"
        Me.Tnm_pasien.Size = New System.Drawing.Size(335, 23)
        Me.Tnm_pasien.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Pekerjaan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 14)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Jenis Kelamin"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(21, 58)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 14)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Tanggal Lahir"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(21, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 14)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Nama Pasien"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Bexit)
        Me.GroupBox1.Controls.Add(Me.Bsave)
        Me.GroupBox1.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(499, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(97, 70)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PROSES"
        '
        'Bexit
        '
        Me.Bexit.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bexit.Location = New System.Drawing.Point(12, 41)
        Me.Bexit.Name = "Bexit"
        Me.Bexit.Size = New System.Drawing.Size(75, 23)
        Me.Bexit.TabIndex = 2
        Me.Bexit.Text = "EXIT"
        Me.Bexit.UseVisualStyleBackColor = True
        '
        'Bsave
        '
        Me.Bsave.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsave.Location = New System.Drawing.Point(12, 13)
        Me.Bsave.Name = "Bsave"
        Me.Bsave.Size = New System.Drawing.Size(75, 23)
        Me.Bsave.TabIndex = 1
        Me.Bsave.Text = "SAVE"
        Me.Bsave.UseVisualStyleBackColor = True
        '
        'DGpasien
        '
        Me.DGpasien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGpasien.Location = New System.Drawing.Point(12, 247)
        Me.DGpasien.Name = "DGpasien"
        Me.DGpasien.Size = New System.Drawing.Size(584, 150)
        Me.DGpasien.TabIndex = 13
        '
        'Tcari
        '
        Me.Tcari.Location = New System.Drawing.Point(130, 221)
        Me.Tcari.Name = "Tcari"
        Me.Tcari.Size = New System.Drawing.Size(363, 20)
        Me.Tcari.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 14)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Cari pasien"
        '
        'Fpasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 404)
        Me.Controls.Add(Me.Tcari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGpasien)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Fpasien"
        Me.Text = "Fpasien"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGpasien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents DGpasien As System.Windows.Forms.DataGridView
    Friend WithEvents Tcari As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
