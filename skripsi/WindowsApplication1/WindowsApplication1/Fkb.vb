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
        Tno_pasien.Clear()
    End Sub
    Sub resetPeriksa()
        Call fetchComboboxData("select * from daftar_obat where jenis = 'KB'", Ckb, "Nama Obat", "Id Obat")
        Ckb.SelectedIndex = -1
        Call fetchComboboxData("select * from daftar_satuan where `Id Jsat` = 5", Csat_tkn, "Nama Satuan", "Id Sat")
        Call fetchComboboxData("select * from daftar_satuan where `Id Jsat` = 1", Csat_berat, "Nama Satuan", "Id Sat")
        Csat_tkn.Text = "MMHG"
        Csat_berat.Text = "Kg"
        Tnm_suami.Clear()
        Tanak.ResetText()
        Thaid.ResetText()
        Tbrt_badan.ResetText()
        Ttkn_darah.ResetText()
        Ttkn_darah1.ResetText()
        Tjumlah.ResetText()
    End Sub
    Sub resetIdKb()
        id_kb = DateTime.Now().ToString("ddMMyyyyhhmmssffff")
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
            data_pasien = fetchData("select * from daftar_pasien where `No Pasien` = " & Tno_pasien.Text)
            If data_pasien.Rows.Count = 1 Then
                Ttgl_lahir.Value = data_pasien.Rows(0).Item("Tanggal Lahir")
                Tpekerjaan.Text = data_pasien.Rows(0).Item("Pekerjaan")
                Talamat.Text = data_pasien.Rows(0).Item("Alamat")
                Cjk.Text = data_pasien.Rows(0).Item("Jenis Kelamin")
                Tnm_ibu.Text = data_pasien.Rows(0).Item("Nama Pasien")
                DGrekap.DataSource = fetchData("select nm_pasien as `Nama Pasien`, tgl_lahir as `Tanggal Lahir` , tgl_periksa as `Tanggal Pasang`, anak_ke as `Anak Ke`, haid_terakhir as `Haid  Terakhir`, berat_badan as `Berat Badan`, tensi as `Tensi`, nm_obat as `KB` from laporan_kb where no_pasien = " & Tno_pasien.Text)
            Else
                Call resetDataPasien()
            End If
        Else
            Call resetDataPasien()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        runQuery("insert into tbl_periksa_kb (id_kb, no_pasien,nm_suami,anak_ke,haid_terakhir, berat_badan, tensi, id_sat_tensi) values ('" & id_kb & "'," & Tno_pasien.Text & " , '" & Tnm_suami.Text & "', " & Tanak.Text & ", '" & Thaid.Value.ToString("yyyy-MM-dd") & "', " & Tbrt_badan.Text & ", '" & Ttkn_darah.Value & "/" & Ttkn_darah1.Value & "'," & Csat_tkn.SelectedValue & ")")
        runQuery("insert into tbl_terapi (id_periksa, id_obat, jumlah) values ('" & id_kb & "', " & Ckb.SelectedValue & ", " & Tjumlah.Text & ")")
        Call successMessage()
        Call resetDataPasien()
        Call resetPeriksa()
        Call resetIdKb()
        Tno_pasien.Focus()
        DGrekap.DataSource = Nothing
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PasienToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasienToolStripMenuItem.Click
        Fpasien.ShowDialog()
    End Sub

    Private Sub ObatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObatToolStripMenuItem.Click
        Fkelola_obat.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("Apakah Anda yakin ingin membatalkan dan mengulangi entri data pemeriksaan? Semua data yang dientrikan tadi akan HILANG. Batalkan dan ulangi entri kelahiran?", "Peringatan!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Call resetDataPasien()
            Call resetPeriksa()
            Tno_pasien.Clear()
            Tno_pasien.Focus()
        End If
    End Sub

    Private Sub Ckb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ckb.SelectedIndexChanged
        If data_obat.Rows.Count <> 0 And Tjumlah.Value <> 0 Then
            total = Val(Tjumlah.Text) * Val(data_obat.Rows(Ckb.SelectedIndex).Item("hrg_obat"))
            Ttotal.Text = Format(total, "Rp,   ##,##0")
        End If
    End Sub

    Private Sub Ckb_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ckb.Leave
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ttotal.TextChanged

    End Sub

    Private Sub Thaid_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Thaid.ValueChanged

    End Sub

    Private Sub Tjumlah_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Tjumlah_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tjumlah.KeyUp
        If data_obat.Rows.Count <> 0 And Tjumlah.Value <> 0 Then
            total = Val(Tjumlah.Text) * Val(data_obat.Rows(Ckb.SelectedIndex).Item("hrg_obat"))
            Ttotal.Text = Format(total, "Rp,   ##,##0")
        End If
    End Sub

    Private Sub Tdibayarkan_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tdibayarkan.KeyUp
        If data_obat.Rows.Count <> 0 And Tjumlah.Value <> 0 Then
            total = Val(Tjumlah.Text) * Val(data_obat.Rows(Ckb.SelectedIndex).Item("hrg_obat"))
            Ttotal.Text = Format(total, "Rp,   ##,##0")
            Tkembalian.Text = Format(Val(Tdibayarkan.Text) - total, "Rp,   ##,##0")
        End If
    End Sub
End Class