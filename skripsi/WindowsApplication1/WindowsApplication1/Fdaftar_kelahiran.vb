Public Class Fdaftar_kelahiran
    Dim getData As String = "select a.no_pasien,a.id_kelahiran,b.nm_pasien as `Nama Pasien`,a.tgl_kelahiran as `Tanggal Kelahiran`, a.nm_suami as `Nama Suami`,b.alamat as `Alamat`, a.cara_persalinan as `Cara Persalinan`, a.penolongan_persalinan as `Penolongan Persalinan`, a.keadaan_ibu as `Keadaan Ibu`, a.umur_kehamilan as `Umur Kehamilan`,count(c.id_bayi) as `Banyak Anak`,a.biaya_persalinan as `Persalinan`,a.biaya_perawatan_kelas as `Perawatan`,a.biaya_perawatan_bayi as `Perawatan Bayi`,a.biaya_obat_obatan as `Obat-Obatan`,a.biaya_cucian as `Cucian`,a.biaya_akte_kelahiran as `Akte`,a.biaya_transportasi as `Transportasi`,a.biaya_lain as `Lain` from tbl_kelahiran a join tbl_pasien b on a.no_pasien = b.no_pasien join tbl_bayi_lahir c on a.id_kelahiran = c.id_kelahiran group by a.id_kelahiran"
    Private Sub Fdaftar_kelahiran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DGkelahiran.DataSource = fetchData(getData)
        DGkelahiran.Columns("no_pasien").Visible = False
        DGkelahiran.Columns("id_kelahiran").Visible = False
    End Sub

    Private Sub Tcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tcari.TextChanged
        If Tcari.Text.Length <> 0 Then
            DGkelahiran.DataSource = fetchData("select a.no_pasien,a.id_kelahiran,b.nm_pasien as `Nama Pasien`,a.tgl_kelahiran as `Tanggal Kelahiran`, a.nm_suami as `Nama Suami`,b.alamat as `Alamat`, a.cara_persalinan as `Cara Persalinan`, a.penolongan_persalinan as `Penolongan Persalinan`, a.keadaan_ibu as `Keadaan Ibu`, a.umur_kehamilan as `Umur Kehamilan`,count(c.id_bayi) as `Banyak Anak`,a.biaya_persalinan as `Persalinan`,a.biaya_perawatan_kelas as `Perawatan`,a.biaya_perawatan_bayi as `Perawatan Bayi`,a.biaya_obat_obatan as `Obat-Obatan`,a.biaya_cucian as `Cucian`,a.biaya_akte_kelahiran as `Akte`,a.biaya_transportasi as `Transportasi`,a.biaya_lain as `Lain` from tbl_kelahiran a join tbl_pasien b on a.no_pasien = b.no_pasien join tbl_bayi_lahir c on a.id_kelahiran = c.id_kelahiran where b.nm_pasien like '% " & Tcari.Text & " %' OR a.nm_suami like '% " & Tcari.Text & " %' group by a.id_kelahiran")
        Else
            DGkelahiran.DataSource = fetchData(getData)
        End If
    End Sub

    Private Sub Bbiaya_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bbiaya.Click
        FRbiaya_persalinan.Show()
    End Sub

    Private Sub Bakte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bakte.Click
        FRakte.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class