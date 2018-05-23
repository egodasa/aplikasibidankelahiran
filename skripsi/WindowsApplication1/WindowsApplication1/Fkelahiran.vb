Public Class Fkelahiran
    Dim DGpasien, DGkondisi, DGasuhan As New DataGridView
    Dim data_pasien As DataTable
    Dim id_kelahiran As String = "K" & DateTime.Now.Ticks.ToString()
    Sub resetDataPasien()
        Ttgl_lahir.ResetText()
        Tpekerjaan.Clear()
        Talamat.Clear()
        Cjk.SelectedIndex = 0
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
        Tumur.Clear()
        Tkeadaan.Clear()
    End Sub
    Sub resetBayi()
        Tnm_bayi.Clear()
        Tberat.Clear()
        Tpanjang.Clear()
        Tlingkar.Clear()
        Cjk_bayi.SelectedIndex = 0
        kondisi_bayi.ClearSelected()
        asuhan_bayi.ClearSelected()
        Tanak.Clear()
        Tketerangan.Clear()
    End Sub
    Private Sub Tno_pasien_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tno_pasien.TextChanged
        If Tno_pasien.TextLength <> 0 Then
            fetchData(DGpasien, "select * from tbl_pasien where no_pasien = " & Tno_pasien.Text)
            data_pasien = DGpasien.DataSource
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
        Call setKoneksi()
        fetchData(DGasuhan, "select nm_asuhan from tbl_asuhan_bayi")
        For Each x As DataGridViewRow In DGasuhan.Rows
            If Not x.IsNewRow Then
                asuhan_bayi.Items.Add(x.Cells(0).Value)
            End If
        Next
        asuhan_bayi.Refresh()
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
        Dim kondisi_tmp As String
        Dim asuhan_tmp As String
        If kondisi_bayi.CheckedItems.Count <> 0 Then
            For Each itm As String In kondisi_bayi.CheckedItems
                kondisi_tmp += itm & vbCrLf
            Next
        End If
        If asuhan_bayi.CheckedItems.Count <> 0 Then
            For Each itm As String In asuhan_bayi.CheckedItems
                asuhan_tmp += itm & vbCrLf
            Next
        End If
        DGbayi.Rows.Add(New String() {Tnm_bayi.Text, Tanak.Text, Tberat.Text, Tpanjang.Text, Tlingkar.Text, Cjk_bayi.Text, kondisi_tmp, asuhan_tmp, Tketerangan.Text})
        DGbayi.Refresh()
        Call resetBayi()
    End Sub

    Private Sub Bsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsimpan.Click
        runQuery("insert into tbl_kelahiran (no_pasien,id_kelahiran,tgl_kelahiran,nm_suami,penolongan_persalinan,cara_persalinan,umur_kehamilan,keadaan_ibu) values (" & Tno_pasien.Text &
                 ", '" & id_kelahiran &
                 "', '" & Ttgl_lahir.Value.ToString("yyyy-MM-dd hh:mm:00") &
                 "', '" & Tnm_suami.Text &
                 "', '" & Tpenolong.Text &
                 "', '" & Tcara.Text &
                 "', " & Tumur.Text &
                 ", '" & Tkeadaan.Text &
                 "')")
        For Each x As DataGridViewRow In DGbayi.Rows
            If Not x.IsNewRow Then
                runQuery("insert into tbl_bayi_lahir (id_kelahiran,nm_bayi,anak_ke,berat_lahir,panjang_badan,lingkar_kepala,jk,asuhan_bayi_saat_lahir,keterangan,kondisi_bayi) values('" & id_kelahiran &
                         "', '" & x.Cells("nm_bayi").Value &
                         "', " & x.Cells(1).Value &
                         ", " & x.Cells(2).Value &
                         ", " & x.Cells(3).Value &
                         ", " & x.Cells(4).Value &
                         ", '" & x.Cells(5).Value &
                         "', '" & x.Cells(6).Value &
                         "', '" & x.Cells(7).Value &
                         "', '" & x.Cells(8).Value &
                         "')")
            End If
        Next
        DGbayi.DataSource = Nothing
        DGbayi.Refresh()
        Call resetIdKelahiran()
        Call resetKeadaanIbu()
        Call successMessage()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PasienToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasienToolStripMenuItem.Click
        Fpasien.ShowDialog()
    End Sub
End Class