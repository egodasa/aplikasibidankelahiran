Public Class Fperiksa
    Dim DGpasien As New DataGridView
    Dim data_pasien, obat_beli As New DataTable
    Dim id_periksa As String = DateTime.Now.Ticks.ToString()
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
            fetchData(DGpasien, "select * from tbl_pasien where no_pasien = " & Tno_pasien.Text)
            data_pasien = DGpasien.DataSource
            If data_pasien.Rows.Count = 1 Then
                fetchData(DGrekap, "select tgl_periksa,keluhan, tensi from tbl_periksa where no_pasien = " & data_pasien.Rows(0).Item("no_pasien") & " ")
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
        fetchData(DGdaftar_obat, "select a.id_obat, a.nm_obat as `Nama Obat`, a.stok as Stok, b.nm_jobat as `Jenis`, a.status as Status from tbl_obat a inner join tbl_jenis_obat b on a.id_jobat = b.id_jobat")
        DGdaftar_obat.Columns("id_obat").Visible = False
    End Sub

    Private Sub Tnm_obat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tnm_obat.TextChanged
        If Tnm_obat.TextLength <> 0 Then
            fetchData(DGdaftar_obat, "select a.id_obat, a.nm_obat as `Nama Obat`, a.stok as Stok, b.nm_jobat as `Jenis`, a.status as Status from tbl_obat a inner join tbl_jenis_obat b on a.id_jobat = b.id_jobat where a.nm_obat like '%" & Tnm_obat.Text & "%'")
        Else
            fetchData(DGdaftar_obat, "select a.id_obat, a.nm_obat as `Nama Obat`, a.stok as Stok, b.nm_jobat as `Jenis`, a.status as Status from tbl_obat a inner join tbl_jenis_obat b on a.id_jobat = b.id_jobat")
        End If
    End Sub

    Private Sub DGdaftar_obat_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGdaftar_obat.CellContentClick
        End Sub

    Private Sub DGdaftar_obat_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGdaftar_obat.CellContentDoubleClick
        DGobat_beli.Rows.Add(New String() {DGdaftar_obat.CurrentRow.Cells(0).Value, DGdaftar_obat.CurrentRow.Cells(1).Value, 0})
        DGobat_beli.Refresh()
        Tnm_obat.Clear()
        fetchData(DGdaftar_obat, "select a.id_obat, a.nm_obat as `Nama Obat`, a.stok as Stok, b.nm_jobat as `Jenis`, a.status as Status from tbl_obat a inner join tbl_jenis_obat b on a.id_jobat = b.id_jobat")
    End Sub

    Private Sub Bexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Me.Close()
    End Sub

    Private Sub Bsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsimpan.Click
        runQuery("insert into tbl_periksa (id_periksa, no_pasien,keluhan, tensi) values ('" & id_periksa & "'," & Tno_pasien.Text & ",'" & Tkeluhan.Text & "','" & Ttkn_darah.Text & "')")
        If is_anc.Checked = True Then
            runQuery("insert into tbl_anc (id_periksa,nm_suami,tinggi_bdn,berat_bdn,tekanan_drh,hpht,htp,diagnosa,umur_khmln,kb_terakhir) values ('" & id_periksa & "','" & Tnm_suami.Text & "'," & Ttgi_badan.Text & "," & Tbrt_badan.Text & ",'" & Ttkn_darah.Text &
                     "', '" & Thpht.Value.ToString("yyyy-MM-dd") & "', '" & Thtp.Value.ToString("yyyy-MM-dd") & "','" & Tdiagnosa.Text & "'," & Tumr_kehamilan.Text & ", '" & Tkb.Value.ToString("yyyy-MM-dd") & "')")
            Call resetAnc()
            is_anc.Checked = False
        End If
        If DGobat_beli.RowCount <> 0 Then
            For Each x As DataGridViewRow In DGobat_beli.Rows
                If Not x.IsNewRow Then
                    If x.Cells(2).Value <> 0 Then
                        runQuery("insert into tbl_terapi(id_obat, jumlah, id_periksa) values (" & x.Cells(0).Value & "," & x.Cells(2).Value & ", " & id_periksa & ")")
                    End If
                End If
            Next
        End If

        Call resetDataPasien()
        Tkeluhan.Clear()
        Ttkn_darah.Clear()
        Tno_pasien.Clear()
        Tno_pasien.Focus()
        DGobat_beli.DataSource = Nothing
        DGobat_beli.Refresh()
        Tnm_obat.Clear()
        Call resetId()
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
End Class