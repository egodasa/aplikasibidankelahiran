Public Class Fkb
    Dim data_pasien, data_obat As New DataTable
    Dim id_kb As String = DateTime.Now().ToString("ddMMyyyyhhmmssffff")
    Dim total As Integer = 0
    Sub resetDataPasien()
        Ttgl_lahir.ResetText()
        Tpekerjaan.Clear()
        Talamat.Clear()
        Cjk.SelectedIndex = -1
        Tnm_ibu.Clear()
    End Sub
    Sub resetPeriksa()
        Call fetchComboboxData("select * from daftar_obat where `Jenis_Obat` = 'KB'", Ckb, "Nama_Obat", "Id_Obat")
        data_obat = Ckb.DataSource
        Ckb.SelectedIndex = -1
        Call fetchComboboxData("select * from daftar_satuan where `Id_Jsat` = 5", Csat_tkn, "Nama_Satuan", "Id_Sat")
        Call fetchComboboxData("select * from daftar_satuan where `Id_Jsat` = 1", Csat_berat, "Nama_Satuan", "Id_Sat")
        Csat_tkn.Text = "MMHG"
        Csat_berat.Text = "Kg"
        Tnm_suami.Clear()
        Tanak.ResetText()
        Thaid.ResetText()
        Tbrt_badan.ResetText()
        Ttkn_darah.ResetText()
        Ttkn_darah1.ResetText()
        Tjumlah.ResetText()
        Lstok.Text = ""
    End Sub
    Sub resetIdKb()
        id_kb = DateTime.Now().ToString("ddMMyyyyhhmmssffff")
    End Sub
    Sub resetPembayaran()
        Tdibayarkan.ResetText()
        Ttotal.Clear()
        Tkembalian.Clear()
    End Sub
    Private Sub Fkb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setKoneksi()
        Call resetPeriksa()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MessageBox.Show("Apakah Anda yakin ingin KELUAR?", "Peringatan!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Fmenu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Tno_pasien_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tno_pasien.TextChanged
        If Tno_pasien.TextLength <> 0 Then
            data_pasien = fetchData("select * from daftar_pasien where `No_Pasien` = " & Tno_pasien.Text)
            If data_pasien.Rows.Count = 1 Then
                Ttgl_lahir.Value = data_pasien.Rows(0).Item("Tanggal_Lahir")
                Tpekerjaan.Text = data_pasien.Rows(0).Item("Pekerjaan")
                Talamat.Text = data_pasien.Rows(0).Item("Alamat")
                Cjk.Text = data_pasien.Rows(0).Item("Jenis_Kelamin")
                Tnm_ibu.Text = data_pasien.Rows(0).Item("Nama_Pasien")
            Else
                Call resetDataPasien()
            End If
            DGrekap.DataSource = fetchData("select * from laporan_kb where `No_Pasien` = " & Tno_pasien.Text)
            DGrekap.Columns("No_Pasien").Visible = False
            DGrekap.Columns("Id_Periksa").Visible = False
            DGrekap.Columns("Id_Sat_Berat").Visible = False
            DGrekap.Columns("Tinggi_Badan").Visible = False
            DGrekap.Columns("Keluhan").Visible = False
        Else
            DGrekap.DataSource = Nothing
            Call resetDataPasien()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        runQuery("insert into tbl_periksa (id_periksa, no_pasien,keluhan, tensi, id_sat_tensi) values ('" & id_kb & "'," & Tno_pasien.Text & ",'Pemeriksaan/Pemasangan KB','" & Ttkn_darah.Text & "/" & Ttkn_darah1.Text & "'," & Csat_tkn.SelectedValue & ")")
        runQuery("insert into tbl_periksa_kb (id_periksa, nm_suami,anak_ke,haid_terakhir, berat_badan,id_sat_berat) values ('" & id_kb & "', '" & Tnm_suami.Text & "', " & Tanak.Text & ", '" & Thaid.Value.ToString("yyyy-MM-dd") & "', " & Tbrt_badan.Text & "," & Csat_berat.SelectedValue & ")")
        runQuery("insert into tbl_terapi (id_periksa, id_obat, jumlah) values ('" & id_kb & "', " & Ckb.SelectedValue & ", " & Tjumlah.Text & ")")
        Call successMessage()
        Call resetPembayaran()
        Call resetDataPasien()
        Call resetPeriksa()
        Call resetIdKb()
        Tno_pasien.Clear()
        Tno_pasien.Focus()
        DGrekap.DataSource = Nothing
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PasienToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Fpasien.ShowDialog()
    End Sub

    Private Sub ObatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Fkelola_obat.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("Apakah Anda yakin ingin membatalkan dan mengulangi entri data pemeriksaan? Semua data yang dientrikan tadi akan HILANG. Batalkan dan ulangi entri kelahiran?", "Peringatan!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Call resetDataPasien()
            Call resetPeriksa()
            Call resetPembayaran()
            Tno_pasien.Clear()
            Call resetIdKb()
            Tno_pasien.Focus()
        End If
    End Sub

    Private Sub Ckb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ckb.SelectedIndexChanged
        If data_obat.Rows.Count <> 0 And Ckb.SelectedIndex <> -1 Then
            Lstok.Text = "Stok " & data_obat.Rows(Ckb.SelectedIndex).Item("Stok") & " " & data_obat.Rows(Ckb.SelectedIndex).Item("Satuan")
            Tjumlah.Maximum = Val(data_obat.Rows(Ckb.SelectedIndex).Item("Stok"))
            total = Val(Tjumlah.Text) * Val(data_obat.Rows(Ckb.SelectedIndex).Item("Harga_Obat"))
            Ttotal.Text = Format(total, "Rp,   ##,##0")
        Else
            Lstok.Text = ""
            Ttotal.Clear()
            total = 0
        End If
    End Sub

    Private Sub Tjumlah_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tjumlah.ValueChanged, Tjumlah.KeyUp, Tdibayarkan.ValueChanged, Tdibayarkan.KeyUp
        If data_obat.Rows.Count <> 0 Then
            total = Tjumlah.Value * Val(data_obat.Rows(Ckb.SelectedIndex).Item("Harga_Obat"))
            Ttotal.Text = Format(total, "Rp,   ##,##0")
            Tkembalian.Text = Format(Val(Tdibayarkan.Text) - total, "Rp,   ##,##0")
        End If
    End Sub
End Class