Public Class Fdaftar_kelahiran
    Dim getData As String = "select a.no_pasien,a.id_kelahiran,b.nm_pasien as `Nama Pasien`,a.tgl_kelahiran as `Tanggal Kelahiran`, a.nm_suami as `Nama Suami`, a.cara_persalinan as `Cara Persalinan`, a.penolongan_persalinan as `Penolongan Persalinan`, a.keadaan_ibu as `Keadaan Ibu`, a.umur_kehamilan as `Umur Kehamilan`,count(c.id_bayi) as `Banyak Anak` from tbl_kelahiran a join tbl_pasien b on a.no_pasien = b.no_pasien join tbl_bayi_lahir c on a.id_kelahiran = c.id_kelahiran group by a.id_kelahiran"
    Private Sub Fdaftar_kelahiran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fetchData(DGkelahiran, getData)
    End Sub

    Private Sub Tcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tcari.TextChanged
        If Tcari.Text.Length <> 0 Then
            fetchData(DGkelahiran, "select a.no_pasien,a.id_kelahiran,b.nm_pasien as `Nama Pasien`,a.tgl_kelahiran as `Tanggal Kelahiran`, a.nm_suami as `Nama Suami`, a.cara_persalinan as `Cara Persalinan`, a.penolongan_persalinan as `Penolongan Persalinan`, a.keadaan_ibu as `Keadaan Ibu`, a.umur_kehamilan as `Umur Kehamilan`,count(c.id_bayi) as `Banyak Anak` from tbl_kelahiran a join tbl_pasien b on a.no_pasien = b.no_pasien join tbl_bayi_lahir c on a.id_kelahiran = c.id_kelahiran where CONCAT(b.nm_pasien, ' ',a.nm_suami) like '% " & Tcari.Text & " %' group by a.id_kelahiran")
        Else
            fetchData(DGkelahiran, getData)
        End If
    End Sub
End Class