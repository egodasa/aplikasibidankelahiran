Public Class Fkb
    Dim data_pasien, data_obat As New DataTable
    Dim id_kb As String = DateTime.Now().ToString("ddMMyyyyhhmmssffff")
    Sub resetDataPasien()
        Ttgl_lahir.ResetText()
        Tpekerjaan.Clear()
        Talamat.Clear()
        Cjk.SelectedIndex = 0
        Tnm_ibu.Clear()
    End Sub
    Sub resetPeriksa()
        Tnm_suami.Clear()
        Tanak.ResetText()
        Thaid.ResetText()
        Tbrt_badan.ResetText()
        Ttkn_darah.ResetText()
        Tjumlah.Text = "1"
    End Sub
    Sub resetIdKb()
        id_kb = DateTime.Now().ToString("ddMMyyyyhhmmssffff")
    End Sub
    Private Sub Fkb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setKoneksi()
        Ckb.DataSource = fetchData("select a.id_obat, a.nm_obat,a.stok,a.hrg_obat from tbl_obat a inner join tbl_jenis_obat b on a.id_jobat = b.id_jobat where b.nm_jobat = 'KB'")
        data_obat = fetchData("select a.id_obat, a.nm_obat,a.stok,a.hrg_obat from tbl_obat a inner join tbl_jenis_obat b on a.id_jobat = b.id_jobat where b.nm_jobat = 'KB'")
        Ckb.ValueMember = "id_obat"
        Ckb.DisplayMember = "nm_obat"
        Ckb.SelectedIndex = 0
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MessageBox.Show("Apakah Anda yakin ingin KELUAR?", "Peringatan!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Fmenu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Tno_pasien_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tno_pasien.TextChanged
        If Tno_pasien.TextLength <> 0 Then
            data_pasien = fetchData("select * from tbl_pasien where no_pasien = " & Tno_pasien.Text)
            If data_pasien.Rows.Count = 1 Then
                Ttgl_lahir.Value = data_pasien.Rows(0).Item("tgl_lahir")
                Tpekerjaan.Text = data_pasien.Rows(0).Item("pekerjaan")
                Talamat.Text = data_pasien.Rows(0).Item("alamat")
                Cjk.Text = data_pasien.Rows(0).Item("jk")
                Tnm_ibu.Text = data_pasien.Rows(0).Item("nm_pasien")
                DGrekap.DataSource = fetchData("select nm_pasien as `Nama Pasien`, tgl_lahir as `Tanggal Lahir` , tgl_periksa as `Tanggal Pasang`, anak_ke as `Anak Ke`, haid_terakhir as `Haid  Terakhir`, berat_badan as `Berat Badan`, tensi as `Tensi`, nm_obat as `KB` from laporan_kb where no_pasien = " & Tno_pasien.Text)
            Else
                Call resetDataPasien()
            End If
        Else
            Call resetDataPasien()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        runQuery("insert into tbl_periksa_kb (id_kb, no_pasien,nm_suami,anak_ke,haid_terakhir, berat_badan, tensi) values ('" & id_kb & "'," & Tno_pasien.Text & " , '" & Tnm_suami.Text & "', " & Tanak.Text & ", '" & Thaid.Value.ToString("yyyy-MM-dd") & "', " & Tbrt_badan.Text & ", '" & Ttkn_darah.Text & "')")
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
        If data_obat.Rows.Count <> 0 And Tjumlah.Text.Length <> 0 Then
            Ttotal.Text = Val(Tjumlah.Text) * Val(data_obat.Rows(Ckb.SelectedIndex).Item("hrg_obat"))
        End If
    End Sub

    Private Sub Ckb_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ckb.Leave
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ttotal.TextChanged

    End Sub

    Private Sub Thaid_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Thaid.ValueChanged

    End Sub

    Private Sub Tjumlah_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Tjumlah_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tjumlah.ValueChanged
        If data_obat.Rows.Count <> 0 And Tjumlah.Text.Length <> 0 Then
            Ttotal.Text = Val(Tjumlah.Text) * Val(data_obat.Rows(Ckb.SelectedIndex).Item("hrg_obat"))
        End If
    End Sub
End Class