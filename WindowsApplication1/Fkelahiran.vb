Public Class Fkelahiran
    Dim data_pasien, data_asuhan, data_kondisi As DataTable
    Dim id_kelahiran As String = "K" & DateTime.Now.Ticks.ToString()
    Dim kondisi_tmp As String
    Dim asuhan_tmp As String
    Dim total As Integer = 0
    Sub hitungBayar()
        total = Tpersalinan.Value + Tperawatan.Value + Tperawatan_bayi.Value + Tcucian.Value + Takte.Value + Tobat.Value + Ttransportasi.Value + Tlain.Value
        Tjumlah.Text = Format(total, "Rp,   ##,##0")
    End Sub
    Sub resetDataPasien()
        Ttgl_lahir.ResetText()
        Tpekerjaan.Clear()
        Talamat.Clear()
        Cjk.SelectedIndex = -1
        Tnm_pasien.Clear()
    End Sub
    Sub resetIdKelahiran()
        id_kelahiran = "K" & DateTime.Now.Ticks.ToString()
    End Sub
    Sub resetKeadaanIbu()
        Ttgl_lahir.ResetText()
        Tnm_suami.Clear()
        Tcara.Clear()
        Tpenolong.Clear()
        Tumur.ResetText()
        Tkeadaan.Clear()
        Csat_umur.Text = "Minggu"
        Tbulan.Clear()
        Ttensi.Clear()
    End Sub
    Sub resetBayi()
        Tnm_bayi.Clear()
        Tberat.ResetText()
        Tpanjang.ResetText()
        Tlingkar.ResetText()
        Cjk_bayi.SelectedIndex = -1
        kondisi_bayi.ClearSelected()
        asuhan_bayi.ClearSelected()
        Tanak.ResetText()
        Tketerangan.Clear()
        Csat_berat.Text = "Gr"
        Csat_panjang.Text = "Cm"
        Csat_lingkar.Text = "Cm"
        asuhan_tmp = ""
        kondisi_tmp = ""
        Twaktu_lahir.ResetText()
    End Sub
    Sub resetBiayaKelahiran()
        Tpersalinan.ResetText()
        Tperawatan.ResetText()
        Tperawatan_bayi.ResetText()
        Tcucian.ResetText()
        Takte.ResetText()
        Tobat.ResetText()
        Ttransportasi.ResetText()
        Tlain.ResetText()
        Tjumlah.Clear()
    End Sub
    Sub getDataKondisi()
        kondisi_bayi.Items.Clear()
        data_kondisi = fetchData("select * from tbl_kondisi_lahir")
        For Each x As DataRow In data_kondisi.Rows
            kondisi_bayi.Items.Add(x.Item(1))
        Next
    End Sub
    Sub getDataAsuhan()
        asuhan_bayi.Items.Clear()
        data_asuhan = fetchData("select * from tbl_asuhan_bayi")
        For Each x As DataRow In data_asuhan.Rows
            asuhan_bayi.Items.Add(x.Item(1))
        Next
    End Sub
    Private Sub Tno_pasien_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tno_pasien.TextChanged
        If Tno_pasien.TextLength <> 0 Then
            data_pasien = fetchData("select * from tbl_pasien where no_pasien = " & Tno_pasien.Text)
            If data_pasien.Rows.Count = 1 Then
                Ttgl_lahir.Value = data_pasien.Rows(0).Item("tgl_lahir")
                Tpekerjaan.Text = data_pasien.Rows(0).Item("pekerjaan")
                Talamat.Text = data_pasien.Rows(0).Item("alamat")
                Cjk.Text = data_pasien.Rows(0).Item("jk")
                Tnm_pasien.Text = data_pasien.Rows(0).Item("nm_pasien")
            Else
                Call resetDataPasien()
            End If
        Else
            Call resetDataPasien()
        End If
    End Sub

    Private Sub Fkelahiran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getDataKondisi()
        getDataAsuhan()
        Call fetchComboboxData("select * from daftar_satuan where `Id_Jsat` = 1", Csat_berat, "Nama_Satuan", "Id_Sat")
        Call fetchComboboxData("select * from daftar_satuan where `Id_Jsat` = 2", Csat_panjang, "Nama_Satuan", "Id_Sat")
        Call fetchComboboxData("select * from daftar_satuan where `Id_Jsat` = 2", Csat_lingkar, "Nama_Satuan", "Id_Sat")
        Call fetchComboboxData("select * from daftar_satuan where `Id_Jsat` = 3", Csat_umur, "Nama_Satuan", "Id_Sat")
        Call resetDataPasien()
        Call resetKeadaanIbu()
        Call resetBayi()
    End Sub

    Private Sub kondisi_bayi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kondisi_bayi.SelectedIndexChanged
        Tketerangan.Clear()
    End Sub

    Private Sub kondisi_bayi_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles kondisi_bayi.ItemCheck

    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Btambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btambah.Click
        If kondisi_bayi.CheckedItems.Count <> 0 Then
            For Each itm As String In kondisi_bayi.CheckedItems
                kondisi_tmp += itm & " " & vbCrLf
            Next
        End If
        If asuhan_bayi.CheckedItems.Count <> 0 Then
            For Each itm As String In asuhan_bayi.CheckedItems
                asuhan_tmp += itm & " " & vbCrLf
            Next
        End If
        DGbayi.Rows.Add(New String() {Tnm_bayi.Text, Tanak.Value, Twaktu_lahir.Value.ToString("yyyy-MM-dd hh:mm:ss"), Tberat.Value, Tpanjang.Value, Tlingkar.Value, Cjk_bayi.Text, kondisi_tmp, asuhan_tmp, Tketerangan.Text, Csat_berat.SelectedValue, Csat_panjang.SelectedValue, Csat_lingkar.SelectedValue})
        DGbayi.Refresh()
        Call resetBayi()
    End Sub

    Private Sub Bsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsimpan.Click
        runQuery("insert into tbl_kelahiran (no_pasien, id_kelahiran, tgl_kelahiran, nm_suami,bulan,tensi,penolongan_persalinan, cara_persalinan, umur_kehamilan, keadaan_ibu, biaya_persalinan, biaya_perawatan_kelas, biaya_perawatan_bayi, biaya_obat_obatan, biaya_cucian, biaya_akte_kelahiran, biaya_transportasi, biaya_lain, id_sat_umur, nm_bidan ) values (" & Tno_pasien.Text &
                ", '" & id_kelahiran &
                "', '" & Ttgl_persalinan.Value.ToString("yyyy-MM-dd hh:mm:00") &
                "', '" & Tnm_suami.Text &
                "', '" & Tbulan.Text &
                "', '" & Ttensi.Text &
                "', '" & Tpenolong.Text &
                "', '" & Tcara.Text &
                "', " & Tumur.Value &
                ", '" & Tkeadaan.Text &
                "', '" & Tpersalinan.Value &
                "', " & Tperawatan.Value &
                ", " & Tperawatan_bayi.Value &
                ", " & Tobat.Value &
                ", " & Tcucian.Value &
                ", " & Takte.Value &
                ", " & Ttransportasi.Value &
                ", " & Tlain.Value &
                ", " & Csat_umur.SelectedValue &
                ", '" & Tnm_bidan.Text & "')")
        For Each x As DataGridViewRow In DGbayi.Rows
            If Not x.IsNewRow Then
                runQuery("insert into tbl_bayi_lahir (id_kelahiran,nm_bayi,anak_ke,berat_lahir,panjang_badan,lingkar_kepala,jk,asuhan_bayi_saat_lahir,keterangan,kondisi_bayi, id_sat_berat,id_sat_panjang,id_sat_lingkar, waktu_lahir) values('" & id_kelahiran &
                         "', '" & x.Cells("nm_bayi").Value &
                         "', " & x.Cells("anak_ke").Value &
                         ", " & x.Cells("berat_lahir").Value &
                         ", " & x.Cells("panjang_badan").Value &
                         ", " & x.Cells("lingkar_kepala").Value &
                         ", '" & x.Cells("jk").Value &
                         "', '" & x.Cells("asuhan_bayi_saat_lahir").Value &
                         "', '" & x.Cells("keterangan").Value &
                         "', '" & x.Cells("kondisi_lahir").Value &
                         "', " & x.Cells("id_sat_berat").Value &
                         ", " & x.Cells("id_sat_panjang").Value &
                         ", " & x.Cells("id_sat_lingkar").Value &
                         ", '" & x.Cells("waktu_lahir").Value &
                         "')")
            End If
        Next
        DGbayi.DataSource = Nothing
        DGbayi.Rows.Clear()
        DGbayi.Update()
        Call resetIdKelahiran()
        Call resetKeadaanIbu()
        Call resetBiayaKelahiran()
        Tno_pasien.Clear()
        Call getDataAsuhan()
        Call getDataKondisi()
        Call successMessage()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
        Fmenu.Show()
    End Sub

    Private Sub PasienToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Fpasien.ShowDialog()
    End Sub

    Private Sub ObatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Fkelola_obat.ShowDialog()
    End Sub

    Private Sub KelahiranToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KelahiranToolStripMenuItem.Click
        Fdaftar_kelahiran.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bhapus.Click
        If DGbayi.Rows.Count <> 0 Then
            DGbayi.Rows.RemoveAt(DGbayi.CurrentRow.Index)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("Apakah Anda yakin ingin membatalkan dan mengulangi entri data kelahiran? Semua data yang dientrikan tadi akan HILANG. Batalkan dan ulangi entri kelahiran?", "Peringatan!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then

            DGbayi.Refresh()
            Call resetIdKelahiran()
            Call resetKeadaanIbu()
            Call resetBiayaKelahiran()
            Tno_pasien.Clear()
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MessageBox.Show("Apakah Anda yakin ingin KELUAR?", "Peringatan!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Fmenu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub DaftarKondisiBayiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Fkondisi_bayi.ShowDialog()
    End Sub

    Private Sub DaftarAsuhanPadaBayiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Fasuhan_bayi.ShowDialog()
    End Sub

    Private Sub KBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Fkb.ShowDialog()
    End Sub

    Private Sub Tpersalinan_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ttransportasi.ValueChanged, Tpersalinan.ValueChanged, Tperawatan_bayi.ValueChanged, Tperawatan.ValueChanged, Tobat.ValueChanged, Tlain.ValueChanged, Tcucian.ValueChanged, Takte.ValueChanged
        Call hitungBayar()
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
End Class