Public Class Fkelahiran
    Dim DGpasien As New DataGridView
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
    End Sub
End Class