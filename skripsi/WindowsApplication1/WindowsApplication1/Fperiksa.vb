﻿Public Class Fperiksa
    Dim data_pasien, obat_beli, data_obat As New DataTable
    Dim id_periksa As String = DateTime.Now.ToString("ddMMyyhhmmssffff")
    Dim DTobat As New DataTable
    Dim cari_obat As DataTable
    Dim total_harga As Integer = 0
    Dim getDataBeli As String = "select * from daftar_obat_beli where `Id Periksa` = '" & id_periksa & "'"
    Sub resetDataPasien()
        Ttgl_lahir.ResetText()
        Tpekerjaan.Clear()
        Talamat.Clear()
        Cjk.SelectedIndex = -1
        Tnm_pasien.Clear()
        Call fetchComboboxData("select * from daftar_satuan where `Id Jsat` = 5", Csat_tkn, "Nama Satuan", "Id Sat")
        Csat_tkn.Text = "MMHG"
        Ttkn_darah.ResetText()
        Ttkn_darah1.ResetText()
        is_anc.Checked = False
        Tkeluhan.Clear()
    End Sub
    Sub resetRekap()
        Tcari.Clear()
        DGrekap.DataSource = Nothing
    End Sub
    Sub resetAnc()
        Tnm_suami.Clear()
        Ttgi_badan.ResetText()
        Tbrt_badan.ResetText()
        Thpht.ResetText()
        Thtp.ResetText()
        Tkb.ResetText()
        Tumr_kehamilan.ResetText()
        Call fetchComboboxData("select * from daftar_satuan where `Id Jsat` = 1", Csat_berat, "Nama Satuan", "Id Sat")
        Call fetchComboboxData("select * from daftar_satuan where `Id Jsat` = 2", Csat_tinggi, "Nama Satuan", "Id Sat")
        Call fetchComboboxData("select * from daftar_satuan where `Id Jsat` = 3", Csat_umur, "Nama Satuan", "Id Sat")
        Csat_berat.Text = "Kg"
        Csat_tinggi.Text = "Cm"
        Csat_umur.Text = "Minggu"
    End Sub
    Sub resetTerapi()
        Call fetchComboboxData("select * from daftar_obat", Cobat, "Nama Obat", "Id Obat")
        Cobat.SelectedIndex = -1
        data_obat = Cobat.DataSource
        Tjumlah.ResetText()
        Tjumlah.Maximum = 100000000
        DGobat_beli.DataSource = fetchData("select * from daftar_obat_beli where `Id Periksa` = '" & id_periksa & "'")
        DGobat_beli.Columns("Id Terapi").Visible = False
        DGobat_beli.Columns("Id Obat").Visible = False
        DGobat_beli.Columns("Id Periksa").Visible = False
        DGobat_beli.Columns("Jumlah").ReadOnly = False
        Lstok.ResetText()
        If DGobat_beli.RowCount <> 0 Then
            For Each x As DataGridViewRow In DGobat_beli.Rows
                If Not x.IsNewRow Then
                    If x.Cells(2).Value <> 0 Then
                        runQuery("insert into tbl_terapi(id_obat, jumlah, id_periksa) values (" & x.Cells("id_obat").Value & "," & x.Cells("Jumlah").Value & ", " & id_periksa & ")")
                    End If
                End If
            Next
        End If
    End Sub
    Sub resetId()
        id_periksa = DateTime.Now.ToString("ddMMyyhhmmssffff")
        getDataBeli = "select * from daftar_obat_beli where `Id Periksa` = '" & id_periksa & "'"
    End Sub
    Sub resetTransaksi()
        If DGobat_beli.Rows.Count <> 0 Then
            runQuery("delete from tbl_terapi where id_periksa = '" & id_periksa & "'")
        End If
    End Sub
    Sub resetPembayaran()
        Ttotal_harga.Clear()
        Tdibayarkan.ResetText()
        Tkembalian.Clear()
    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Tno_pasien_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tno_pasien.TextChanged
        If Tno_pasien.TextLength <> 0 Then
            data_pasien = fetchData("select * from daftar_pasien where `No Pasien` = " & Tno_pasien.Text)
            If data_pasien.Rows.Count = 1 Then
                DGrekap.DataSource = fetchData("select * from laporan_rekap_pasien where `No Pasien` = " & data_pasien.Rows(0).Item("No Pasien"))
                Ttgl_lahir.Value = Date.ParseExact(data_pasien.Rows(0).Item("Tanggal Lahir"), "dd/MM/yyyy",
            System.Globalization.DateTimeFormatInfo.InvariantInfo)
                Tpekerjaan.Text = data_pasien.Rows(0).Item("Pekerjaan")
                Talamat.Text = data_pasien.Rows(0).Item("Alamat")
                Cjk.Text = data_pasien.Rows(0).Item("Jenis Kelamin")
                Tnm_pasien.Text = data_pasien.Rows(0).Item("Nama Pasien")
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
        Call resetDataPasien()
        Call resetRekap()
        Call resetPembayaran()
        Call resetAnc()
        Call resetTerapi()
    End Sub

    Private Sub Tnm_obat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
        runQuery("insert into tbl_periksa (id_periksa, no_pasien,keluhan, tensi, id_sat_tensi) values ('" & id_periksa & "'," & Tno_pasien.Text & ",'" & Tkeluhan.Text & "','" & Ttkn_darah.Text & "/" & Ttkn_darah1.Text & "'," & Csat_tkn.SelectedValue & ")")
        If is_anc.Checked = True Then
            runQuery("insert into tbl_anc (id_sat_tinggi, id_sat_berat, id_sat_umur, id_periksa,nm_suami,tinggi_bdn,berat_bdn,hpht,htp,umur_khmln,kb_terakhir) values (" & Csat_tinggi.SelectedValue & "," & Csat_berat.SelectedValue & "," & Csat_umur.SelectedValue & ",'" & id_periksa & "','" & Tnm_suami.Text & "'," & Ttgi_badan.Text & "," & Tbrt_badan.Text &
                     ", '" & Thpht.Value.ToString("yyyy-MM-dd") & "', '" & Thtp.Value.ToString("yyyy-MM-dd") & "'," & Tumr_kehamilan.Text & ", '" & Tkb.Value.ToString("yyyy-MM-dd") & "')")
        End If
        Call resetTransaksi()
        Call resetId()
        Call resetDataPasien()
        Call resetRekap()
        Call resetPembayaran()
        Call resetAnc()
        Call resetTerapi()
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
        If data_obat.Rows.Count <> 0 And Cobat.SelectedIndex <> -1 Then
            Lstok.Text = "Stok " & data_obat.Rows(Cobat.SelectedIndex).Item("Stok") & " " & data_obat.Rows(Cobat.SelectedIndex).Item("Satuan")
            Tjumlah.Maximum = Val(data_obat.Rows(Cobat.SelectedIndex).Item("Stok"))
        End If
    End Sub

    Private Sub Cobat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Cobat_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    End Sub

    Private Sub Cobat_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub Btambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btambah.Click
        If Cobat.SelectedIndex <> -1 And Cobat.Text <> "" Then
            runQuery("insert into tbl_terapi (id_obat, id_periksa, jumlah) values (" & Cobat.SelectedValue & ", '" & id_periksa & "', " & Tjumlah.Text & ")")
            DGobat_beli.DataSource = fetchData(getDataBeli)
            total_harga = 0
            For x As Integer = 0 To DGobat_beli.Rows.Count - 1
                total_harga += DGobat_beli.Rows(x).Cells("Total Harga").Value
            Next
            Ttotal_harga.Text = Format(total_harga, "Rp,   ##,##0")
            Call fetchComboboxData("select * from daftar_obat", Cobat, "Nama Obat", "Id Obat")
            data_obat = Cobat.DataSource
            Tjumlah.ResetText()
            Lstok.ResetText()
        End If
    End Sub

    Private Sub Fperiksa_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If DGobat_beli.Rows.Count > 0 Then
            runQuery("delete from tbl_terapi where id_periksa = '" & id_periksa & "'")
        End If
    End Sub

    Private Sub Bhapus_obat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bhapus_obat.Click
        Try
            runQuery("delete from tbl_terapi where id_obat = " & DGobat_beli.CurrentRow.Cells("Id Obat").Value & " and id_periksa = '" & id_periksa & "'")
            DGobat_beli.DataSource = fetchData(getDataBeli)
            total_harga = 0
            For x As Integer = 0 To DGobat_beli.Rows.Count - 1
                total_harga += DGobat_beli.Rows(x).Cells("Total Harga").Value
            Next
            Ttotal_harga.Text = Format(total_harga, "Rp,   ##,##0")
            Call fetchComboboxData("select * from daftar_obat", Cobat, "Nama Obat", "Id Obat")
            data_obat = Cobat.DataSource
            Lstok.ResetText()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
        Fmenu.Show()
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
            DGrekap.DataSource = fetchData("select * from laporan_rekap_pasien where `No Pasien` = " & data_pasien.Rows(0).Item("No Pasien") & " AND `Tanggal Periksa` like '%" & Tcari.Text & "%' OR `Keluhan/Diagnosa` like '%" & Tcari.Text & "%'")
        Else
            DGrekap.DataSource = fetchData("select * from laporan_rekap_pasien where `No Pasien` = " & data_pasien.Rows(0).Item("No Pasien"))
        End If
    End Sub

    Private Sub Bbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bbatal.Click
        If MessageBox.Show("Apakah pemeriksaan ini akan DIBATALKAN?", "Peringatan", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
            Call resetTransaksi()
            Call resetId()
            Call resetDataPasien()
            Call resetRekap()
            Call resetPembayaran()
            Call resetAnc()
            Call resetTerapi()
        End If
    End Sub

    Private Sub DGobat_beli_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGobat_beli.CellContentClick

    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tdibayarkan.ValueChanged
        
    End Sub

    Private Sub Tdibayarkan_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Tdibayarkan.KeyUp
        If Ttotal_harga.Text <> "" Or Val(Ttotal_harga.Text) <> 0 Then
            Tkembalian.Text = Format(Val(Tdibayarkan.Text) - total_harga, "Rp,   ##,##0")
        End If
    End Sub

    Private Sub Ttgi_badan_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ttgi_badan.ValueChanged

    End Sub

    Private Sub KBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KBToolStripMenuItem.Click
        Fkb.ShowDialog()
    End Sub

    Private Sub Fperiksa_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If DGobat_beli.Rows.Count > 0 Then
            runQuery("delete from tbl_terapi where id_periksa = '" & id_periksa & "'")
        End If
    End Sub
End Class