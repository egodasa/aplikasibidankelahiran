Public Class Fperiksa
    Dim data_pasien, obat_beli As New DataTable
    Dim id_periksa As String = DateTime.Now.Ticks.ToString()
    Dim DTobat As New DataTable
    Dim cari_obat As DataTable
    Dim getDataBeli As String = "select a.id_terapi,a.id_obat,a.id_periksa,b.nm_obat as `Nama Obat`,a.jumlah as Jumlah,b.hrg_obat as `Harga`,b.hrg_obat*a.jumlah as `Total Harga` from tbl_terapi a join tbl_obat b on a.id_obat = b.id_obat where a.id_periksa = '" & id_periksa & "'"
    Sub resetDataPasien()
        Ttgl_lahir.ResetText()
        Tpekerjaan.Clear()
        Talamat.Clear()
        Cjk.SelectedIndex = 0
        Tnm_pasien.Clear()
    End Sub
    Sub resetAnc()
        Tnm_suami.Clear()
        Ttgi_badan.Clear()
        Tbrt_badan.Clear()
        Thpht.ResetText()
        Thtp.ResetText()
        Tkb.ResetText()
        Tdiagnosa.Clear()
        Tumr_kehamilan.Clear()
    End Sub
    Sub resetId()
        id_periksa = DateTime.Now.Ticks.ToString()
    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Tno_pasien_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tno_pasien.TextChanged
        If Tno_pasien.TextLength <> 0 Then
            data_pasien = fetchData("select * from tbl_pasien where no_pasien = " & Tno_pasien.Text)
            If data_pasien.Rows.Count = 1 Then
                DGrekap.DataSource = fetchData("select a.tgl_periksa,a.keluhan, a.tensi, b.tinggi_bdn AS `Tinggi Badan`, b.berat_bdn as `Berat Badan`,b.hpht AS `HPHT`, b.htp as `HTP`, b.diagnosa as `Diagnosa`,b.umur_khmln as `Umur Kehamilan`,b.kb_terakhir as `KB Terakhir` from tbl_periksa a left join tbl_anc b on a.id_periksa = b.id_periksa where no_pasien = " & data_pasien.Rows(0).Item("no_pasien"))
                Ttgl_lahir.Value = data_pasien.Rows(0).Item("tgl_lahir")
                Tpekerjaan.Text = data_pasien.Rows(0).Item("pekerjaan")
                Talamat.Text = data_pasien.Rows(0).Item("alamat")
                Cjk.Text = data_pasien.Rows(0).Item("jk")
                Tnm_pasien.Text = data_pasien.Rows(0).Item("nm_pasien")
            Else
                DGrekap.DataSource = Nothing
                DGrekap.Refresh()
                Call resetDataPasien()
            End If
        Else
            DGrekap.DataSource = Nothing
            DGrekap.Refresh()
            Call resetDataPasien()
        End If
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Fperiksa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call setKoneksi()
        Cobat.DataSource = fetchData("select a.id_obat, a.nm_obat as `Nama Obat`, a.stok as Stok, b.nm_jobat as `Jenis`, a.status as Status from tbl_obat a inner join tbl_jenis_obat b on a.id_jobat = b.id_jobat")
        DGobat_beli.DataSource = fetchData(getDataBeli)
        DGobat_beli.Columns("id_terapi").Visible = False
        DGobat_beli.Columns("id_obat").Visible = False
        DGobat_beli.Columns("id_periksa").Visible = False
        DGobat_beli.Columns("Jumlah").ReadOnly = False
    End Sub

    Private Sub Tnm_obat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tjumlah.TextChanged
        
    End Sub

    Private Sub DGdaftar_obat_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    End Sub

    Private Sub DGdaftar_obat_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    End Sub

    Private Sub Bexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bexit.Click
        If MessageBox.Show("Apakah Anda yakin ingin KELUAR?", "Peringatan!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Fmenu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Bsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsimpan.Click
        runQuery("insert into tbl_periksa (id_periksa, no_pasien,keluhan, tensi) values ('" & id_periksa & "'," & Tno_pasien.Text & ",'" & Tkeluhan.Text & "','" & Ttkn_darah.Text & "')")
        If is_anc.Checked = True Then
            runQuery("insert into tbl_anc (id_periksa,nm_suami,tinggi_bdn,berat_bdn,hpht,htp,diagnosa,umur_khmln,kb_terakhir) values ('" & id_periksa & "','" & Tnm_suami.Text & "'," & Ttgi_badan.Text & "," & Tbrt_badan.Text &
                     ", '" & Thpht.Value.ToString("yyyy-MM-dd") & "', '" & Thtp.Value.ToString("yyyy-MM-dd") & "','" & Tdiagnosa.Text & "'," & Tumr_kehamilan.Text & ", '" & Tkb.Value.ToString("yyyy-MM-dd") & "')")
            Call resetAnc()
            is_anc.Checked = False
        End If
        If DGobat_beli.RowCount <> 0 Then
            For Each x As DataGridViewRow In DGobat_beli.Rows
                If Not x.IsNewRow Then
                    If x.Cells(2).Value <> 0 Then
                        runQuery("insert into tbl_terapi(id_obat, jumlah, id_periksa) values (" & x.Cells("id_obat").Value & "," & x.Cells("Jumlah").Value & ", " & id_periksa & ")")
                    End If
                End If
            Next
        End If
        Bbatal.PerformClick()
    End Sub

    Private Sub DGrekap_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGrekap.CellContentClick
        Ttkn_darah.Text = DGrekap.CurrentRow.Cells("tensi").Value
        Tkeluhan.Text = DGrekap.CurrentRow.Cells("keluhan").Value
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles is_anc.CheckedChanged
        If Group_anc.Enabled = True Then
            Group_anc.Enabled = False
        Else
            Group_anc.Enabled = True
        End If
    End Sub

    Private Sub Tkb_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tkb.ValueChanged

    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub Cobat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cobat.SelectedIndexChanged

    End Sub

    Private Sub Cobat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cobat.TextChanged

    End Sub

    Private Sub Cobat_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cobat.KeyPress
    End Sub

    Private Sub Cobat_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cobat.KeyUp

    End Sub

    Private Sub Btambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btambah.Click
        runQuery("insert into tbl_terapi (id_obat, id_periksa, jumlah) values (" & Cobat.SelectedValue & ", '" & id_periksa & "', " & Tjumlah.Text & ")")
        Cobat.ResetText()
        Tjumlah.Clear()
        DGobat_beli.DataSource = fetchData(getDataBeli)
    End Sub

    Private Sub Fperiksa_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If DGobat_beli.Rows.Count > 0 Then
            runQuery("delete from tbl_terapi where id_periksa = '" & id_periksa & "'")
        End If
    End Sub

    Private Sub Bhapus_obat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bhapus_obat.Click
        If DGobat_beli.CurrentRow.Cells("id_terapi").Value.ToString <> "" Then
            runQuery("delete from tbl_terapi where id_terapi = '" & DGobat_beli.CurrentRow.Cells("id_terapi").Value & "'")
            DGobat_beli.DataSource = fetchData(getDataBeli)
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PasienToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasienToolStripMenuItem.Click
        Fpasien.ShowDialog()
    End Sub

    Private Sub AsuhanBayiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsuhanBayiToolStripMenuItem.Click

    End Sub

    Private Sub ObatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObatToolStripMenuItem.Click
        Fkelola_obat.ShowDialog()
    End Sub

    Private Sub Tcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tcari.TextChanged
        If Tcari.Text.Length <> 0 Then
            DGrekap.DataSource = fetchData("select a.tgl_periksa,a.keluhan, a.tensi, b.tinggi_bdn AS `Tinggi Badan`, b.berat_bdn as `Berat Badan`,b.hpht AS `HPHT`, b.htp as `HTP`, b.diagnosa as `Diagnosa`,b.umur_khmln as `Umur Kehamilan`,b.kb_terakhir as `KB Terakhir` from tbl_periksa a left join tbl_anc b on a.id_periksa = b.id_periksa where no_pasien = " & data_pasien.Rows(0).Item("no_pasien") & " AND tgl_periksa like '%" & Tcari.Text & "%' OR keluhan like '%" & Tcari.Text & "%' OR like '%" & Tcari.Text & "%' OR tensi like '% " & Tcari.Text & " %' ")
        End If
    End Sub

    Private Sub Bbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bbatal.Click
        Call resetDataPasien()
        Tkeluhan.Clear()
        Ttkn_darah.Clear()
        Tno_pasien.Clear()
        Tno_pasien.Focus()
        Tjumlah.Clear()
        Call resetId()
        DGobat_beli.DataSource = fetchData(getDataBeli)
        DGobat_beli.Columns("id_terapi").Visible = False
        DGobat_beli.Columns("id_obat").Visible = False
        DGobat_beli.Columns("id_periksa").Visible = False
        DGobat_beli.Columns("Jumlah").ReadOnly = False
    End Sub

    Private Sub DGobat_beli_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGobat_beli.CellContentClick

    End Sub
End Class