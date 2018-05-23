Public Class Fkb
    Dim DGkb, DGpasien As New DataGridView
    Dim data_pasien As New DataTable
    Sub resetDataPasien()
        Ttgl_lahir.ResetText()
        Tpekerjaan.Clear()
        Talamat.Clear()
        Cjk.SelectedIndex = 0
        Tnm_ibu.Clear()
    End Sub
    Sub resetPeriksa()
        Tnm_suami.Clear()
        Tanak.Clear()
        Thaid.ResetText()
        Tbrt_badan.Clear()
        Ttkn_darah.Clear()
    End Sub
    Private Sub Fkb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setKoneksi()
        fetchData(DGkb, "select a.id_obat, a.nm_obat from tbl_obat a inner join tbl_jenis_obat b on a.id_jobat = b.id_jobat where b.nm_jobat = 'KB'")
        Ckb.DataSource = DGkb.DataSource
        Ckb.ValueMember = "id_obat"
        Ckb.DisplayMember = "nm_obat"
        Ckb.SelectedIndex = 0
        fetchData(DGrekap, "select * from laporan_kb")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
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
                Tnm_ibu.Text = data_pasien.Rows(0).Item("nm_pasien")
            Else
                Call resetDataPasien()
            End If
        Else
            Call resetDataPasien()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        runQuery("insert into tbl_periksa_kb (no_pasien,nm_suami,anak_ke,haid_terakhir, id_obat, berat_badan, tekanan_darah) values (" & Tno_pasien.Text & " , '" & Tnm_suami.Text & "', " & Tanak.Text & ", '" & Thaid.Value.ToString("yyyy-MM-dd") & "', " & Ckb.SelectedValue & ", " & Tbrt_badan.Text & ", '" & Ttkn_darah.Text & "')")
        Call successMessage()
        Call resetDataPasien()
        Call resetPeriksa()
        Tno_pasien.Focus()
        DGrekap.Refresh()
    End Sub
End Class