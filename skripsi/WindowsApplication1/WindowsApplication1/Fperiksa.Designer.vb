﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fperiksa
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Tkb = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Tumr_kehamilan = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Tdiagnosa = New System.Windows.Forms.TextBox()
        Me.Thtp = New System.Windows.Forms.TextBox()
        Me.Thpht = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Tbrt_badan = New System.Windows.Forms.TextBox()
        Me.Ttgi_badan = New System.Windows.Forms.TextBox()
        Me.Tnm_suami = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Bhapus_obat = New System.Windows.Forms.Button()
        Me.DGdaftar_obat = New System.Windows.Forms.DataGridView()
        Me.DGobat_beli = New System.Windows.Forms.DataGridView()
        Me.Tjml_obat = New System.Windows.Forms.TextBox()
        Me.Tnm_obat = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Ttkn_darah = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tkeluhan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Talamat = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Tpekerjaan = New System.Windows.Forms.TextBox()
        Me.Cjk = New System.Windows.Forms.ComboBox()
        Me.Tnm_pasien = New System.Windows.Forms.TextBox()
        Me.Tno_pasien = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Bsave = New System.Windows.Forms.Button()
        Me.Bexit = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGrekap = New System.Windows.Forms.DataGridView()
        Me.Tcari = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Bcetak = New System.Windows.Forms.Button()
        Me.Ttgl_lahir = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.id_obaat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nm_obat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bsimpan = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGdaftar_obat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGobat_beli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGrekap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Tkb)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Tumr_kehamilan)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Tdiagnosa)
        Me.GroupBox1.Controls.Add(Me.Thtp)
        Me.GroupBox1.Controls.Add(Me.Thpht)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Tbrt_badan)
        Me.GroupBox1.Controls.Add(Me.Ttgi_badan)
        Me.GroupBox1.Controls.Add(Me.Tnm_suami)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(560, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 338)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "KUNJUNGAN ANC"
        '
        'Tkb
        '
        Me.Tkb.Location = New System.Drawing.Point(237, 216)
        Me.Tkb.Name = "Tkb"
        Me.Tkb.Size = New System.Drawing.Size(128, 22)
        Me.Tkb.TabIndex = 27
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 210)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(221, 28)
        Me.Label22.TabIndex = 26
        Me.Label22.Text = "pengguna kontrasepsi " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sebelum kehamilan (KB terakhir)"
        '
        'Tumr_kehamilan
        '
        Me.Tumr_kehamilan.Location = New System.Drawing.Point(237, 293)
        Me.Tumr_kehamilan.Name = "Tumr_kehamilan"
        Me.Tumr_kehamilan.Size = New System.Drawing.Size(128, 22)
        Me.Tumr_kehamilan.TabIndex = 25
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(9, 292)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(115, 14)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "umur kehamilan"
        '
        'Tdiagnosa
        '
        Me.Tdiagnosa.Location = New System.Drawing.Point(237, 257)
        Me.Tdiagnosa.Name = "Tdiagnosa"
        Me.Tdiagnosa.Size = New System.Drawing.Size(128, 22)
        Me.Tdiagnosa.TabIndex = 19
        '
        'Thtp
        '
        Me.Thtp.Location = New System.Drawing.Point(237, 172)
        Me.Thtp.Name = "Thtp"
        Me.Thtp.Size = New System.Drawing.Size(128, 22)
        Me.Thtp.TabIndex = 18
        '
        'Thpht
        '
        Me.Thpht.Location = New System.Drawing.Point(237, 142)
        Me.Thpht.Name = "Thpht"
        Me.Thpht.Size = New System.Drawing.Size(128, 22)
        Me.Thpht.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(324, 85)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 14)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "KG"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(323, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 14)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "CM"
        '
        'Tbrt_badan
        '
        Me.Tbrt_badan.Location = New System.Drawing.Point(237, 82)
        Me.Tbrt_badan.Name = "Tbrt_badan"
        Me.Tbrt_badan.Size = New System.Drawing.Size(80, 22)
        Me.Tbrt_badan.TabIndex = 14
        '
        'Ttgi_badan
        '
        Me.Ttgi_badan.Location = New System.Drawing.Point(237, 56)
        Me.Ttgi_badan.Name = "Ttgi_badan"
        Me.Ttgi_badan.Size = New System.Drawing.Size(80, 22)
        Me.Ttgi_badan.TabIndex = 13
        '
        'Tnm_suami
        '
        Me.Tnm_suami.Location = New System.Drawing.Point(237, 20)
        Me.Tnm_suami.Name = "Tnm_suami"
        Me.Tnm_suami.Size = New System.Drawing.Size(128, 22)
        Me.Tnm_suami.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 259)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 14)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "diagnosa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 14)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "HTP(hari pertama persalinan)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(227, 14)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "HPHT (hari pertama haid terakhir)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 14)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "berat badan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "tinggi badan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama suami"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Bhapus_obat)
        Me.GroupBox4.Controls.Add(Me.DGdaftar_obat)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.DGobat_beli)
        Me.GroupBox4.Controls.Add(Me.Tjml_obat)
        Me.GroupBox4.Controls.Add(Me.Tnm_obat)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(306, 377)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(635, 229)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "TERAPI"
        '
        'Bhapus_obat
        '
        Me.Bhapus_obat.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bhapus_obat.Location = New System.Drawing.Point(511, 37)
        Me.Bhapus_obat.Name = "Bhapus_obat"
        Me.Bhapus_obat.Size = New System.Drawing.Size(111, 22)
        Me.Bhapus_obat.TabIndex = 13
        Me.Bhapus_obat.Text = "HAPUS OBAT"
        Me.Bhapus_obat.UseVisualStyleBackColor = True
        '
        'DGdaftar_obat
        '
        Me.DGdaftar_obat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGdaftar_obat.Location = New System.Drawing.Point(12, 90)
        Me.DGdaftar_obat.Name = "DGdaftar_obat"
        Me.DGdaftar_obat.Size = New System.Drawing.Size(281, 129)
        Me.DGdaftar_obat.TabIndex = 13
        '
        'DGobat_beli
        '
        Me.DGobat_beli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGobat_beli.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_obaat, Me.nm_obat, Me.jumlah})
        Me.DGobat_beli.Location = New System.Drawing.Point(296, 90)
        Me.DGobat_beli.Name = "DGobat_beli"
        Me.DGobat_beli.Size = New System.Drawing.Size(326, 129)
        Me.DGobat_beli.TabIndex = 11
        '
        'Tjml_obat
        '
        Me.Tjml_obat.Location = New System.Drawing.Point(299, 36)
        Me.Tjml_obat.Name = "Tjml_obat"
        Me.Tjml_obat.Size = New System.Drawing.Size(206, 23)
        Me.Tjml_obat.TabIndex = 10
        '
        'Tnm_obat
        '
        Me.Tnm_obat.Location = New System.Drawing.Point(12, 36)
        Me.Tnm_obat.Name = "Tnm_obat"
        Me.Tnm_obat.Size = New System.Drawing.Size(278, 23)
        Me.Tnm_obat.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(296, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 14)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Daftar Obat beli"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(296, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 14)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Jumlah Obat"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 14)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Nama Obat"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Ttgl_lahir)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Ttkn_darah)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Tkeluhan)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Talamat)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Tpekerjaan)
        Me.GroupBox2.Controls.Add(Me.Cjk)
        Me.GroupBox2.Controls.Add(Me.Tnm_pasien)
        Me.GroupBox2.Controls.Add(Me.Tno_pasien)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 411)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PASIEN"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(212, 244)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 14)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "MMHG"
        '
        'Ttkn_darah
        '
        Me.Ttkn_darah.Location = New System.Drawing.Point(115, 241)
        Me.Ttkn_darah.Name = "Ttkn_darah"
        Me.Ttkn_darah.Size = New System.Drawing.Size(91, 23)
        Me.Ttkn_darah.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 247)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "tekanan darah"
        '
        'Tkeluhan
        '
        Me.Tkeluhan.Location = New System.Drawing.Point(8, 308)
        Me.Tkeluhan.Multiline = True
        Me.Tkeluhan.Name = "Tkeluhan"
        Me.Tkeluhan.Size = New System.Drawing.Size(272, 97)
        Me.Tkeluhan.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 282)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 14)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "pemeriksaan"
        '
        'Talamat
        '
        Me.Talamat.Location = New System.Drawing.Point(115, 210)
        Me.Talamat.Name = "Talamat"
        Me.Talamat.Size = New System.Drawing.Size(156, 23)
        Me.Talamat.TabIndex = 10
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(5, 213)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(53, 14)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "Alamat"
        '
        'Tpekerjaan
        '
        Me.Tpekerjaan.Location = New System.Drawing.Point(115, 176)
        Me.Tpekerjaan.Name = "Tpekerjaan"
        Me.Tpekerjaan.Size = New System.Drawing.Size(156, 23)
        Me.Tpekerjaan.TabIndex = 8
        '
        'Cjk
        '
        Me.Cjk.FormattingEnabled = True
        Me.Cjk.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.Cjk.Location = New System.Drawing.Point(115, 140)
        Me.Cjk.Name = "Cjk"
        Me.Cjk.Size = New System.Drawing.Size(156, 24)
        Me.Cjk.TabIndex = 1
        '
        'Tnm_pasien
        '
        Me.Tnm_pasien.Location = New System.Drawing.Point(115, 68)
        Me.Tnm_pasien.Name = "Tnm_pasien"
        Me.Tnm_pasien.Size = New System.Drawing.Size(156, 23)
        Me.Tnm_pasien.TabIndex = 6
        '
        'Tno_pasien
        '
        Me.Tno_pasien.Location = New System.Drawing.Point(115, 30)
        Me.Tno_pasien.Name = "Tno_pasien"
        Me.Tno_pasien.Size = New System.Drawing.Size(156, 23)
        Me.Tno_pasien.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Pekerjaan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 14)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Jenis Kelamin"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(5, 107)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 14)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Tanggal Lahir"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(5, 71)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 14)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Nama Pasien"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(5, 33)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 14)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "No Pasien"
        '
        'Bsave
        '
        Me.Bsave.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsave.Location = New System.Drawing.Point(115, 543)
        Me.Bsave.Name = "Bsave"
        Me.Bsave.Size = New System.Drawing.Size(75, 23)
        Me.Bsave.TabIndex = 6
        Me.Bsave.Text = "save"
        Me.Bsave.UseVisualStyleBackColor = True
        '
        'Bexit
        '
        Me.Bexit.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bexit.Location = New System.Drawing.Point(160, 499)
        Me.Bexit.Name = "Bexit"
        Me.Bexit.Size = New System.Drawing.Size(75, 23)
        Me.Bexit.TabIndex = 7
        Me.Bexit.Text = "exit"
        Me.Bexit.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(569, 12)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(111, 17)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "pemeriksaan ANC"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGrekap)
        Me.GroupBox3.Controls.Add(Me.Tcari)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Location = New System.Drawing.Point(306, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(248, 367)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'DGrekap
        '
        Me.DGrekap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGrekap.Location = New System.Drawing.Point(12, 59)
        Me.DGrekap.Name = "DGrekap"
        Me.DGrekap.Size = New System.Drawing.Size(223, 277)
        Me.DGrekap.TabIndex = 14
        '
        'Tcari
        '
        Me.Tcari.Location = New System.Drawing.Point(127, 21)
        Me.Tcari.Name = "Tcari"
        Me.Tcari.Size = New System.Drawing.Size(108, 20)
        Me.Tcari.TabIndex = 28
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(9, 21)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(84, 13)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "pencarian rekap"
        '
        'Bcetak
        '
        Me.Bcetak.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bcetak.Location = New System.Drawing.Point(33, 499)
        Me.Bcetak.Name = "Bcetak"
        Me.Bcetak.Size = New System.Drawing.Size(121, 44)
        Me.Bcetak.TabIndex = 12
        Me.Bcetak.Text = "CETAK KARTU BEROBAT"
        Me.Bcetak.UseVisualStyleBackColor = True
        '
        'Ttgl_lahir
        '
        Me.Ttgl_lahir.Location = New System.Drawing.Point(115, 103)
        Me.Ttgl_lahir.Name = "Ttgl_lahir"
        Me.Ttgl_lahir.Size = New System.Drawing.Size(156, 23)
        Me.Ttgl_lahir.TabIndex = 29
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(9, 73)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(82, 14)
        Me.Label23.TabIndex = 12
        Me.Label23.Text = "Daftar Obat"
        '
        'id_obaat
        '
        Me.id_obaat.HeaderText = "id_obat"
        Me.id_obaat.Name = "id_obaat"
        Me.id_obaat.ReadOnly = True
        Me.id_obaat.Visible = False
        '
        'nm_obat
        '
        Me.nm_obat.HeaderText = "Nama Obat"
        Me.nm_obat.Name = "nm_obat"
        Me.nm_obat.ReadOnly = True
        '
        'jumlah
        '
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.Name = "jumlah"
        Me.jumlah.ReadOnly = True
        '
        'Bsimpan
        '
        Me.Bsimpan.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsimpan.Location = New System.Drawing.Point(12, 421)
        Me.Bsimpan.Name = "Bsimpan"
        Me.Bsimpan.Size = New System.Drawing.Size(75, 23)
        Me.Bsimpan.TabIndex = 13
        Me.Bsimpan.Text = "Simpan"
        Me.Bsimpan.UseVisualStyleBackColor = True
        '
        'Fperiksa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 612)
        Me.Controls.Add(Me.Bsimpan)
        Me.Controls.Add(Me.Bcetak)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Bexit)
        Me.Controls.Add(Me.Bsave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Fperiksa"
        Me.Text = "Form Pemeriksaan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DGdaftar_obat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGobat_beli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGrekap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Tdiagnosa As System.Windows.Forms.TextBox
    Friend WithEvents Thtp As System.Windows.Forms.TextBox
    Friend WithEvents Thpht As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Tbrt_badan As System.Windows.Forms.TextBox
    Friend WithEvents Ttgi_badan As System.Windows.Forms.TextBox
    Friend WithEvents Tnm_suami As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Tjml_obat As System.Windows.Forms.TextBox
    Friend WithEvents Tnm_obat As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Bhapus_obat As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Tpekerjaan As System.Windows.Forms.TextBox
    Friend WithEvents Cjk As System.Windows.Forms.ComboBox
    Friend WithEvents Tnm_pasien As System.Windows.Forms.TextBox
    Friend WithEvents Tno_pasien As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Bsave As System.Windows.Forms.Button
    Friend WithEvents Bexit As System.Windows.Forms.Button
    Friend WithEvents Tumr_kehamilan As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Talamat As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Tkb As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents DGobat_beli As System.Windows.Forms.DataGridView
    Friend WithEvents DGdaftar_obat As System.Windows.Forms.DataGridView
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Ttkn_darah As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Tkeluhan As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DGrekap As System.Windows.Forms.DataGridView
    Friend WithEvents Tcari As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Bcetak As System.Windows.Forms.Button
    Friend WithEvents Ttgl_lahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents id_obaat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nm_obat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bsimpan As System.Windows.Forms.Button
End Class
