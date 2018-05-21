Public Class Fjenis_obat

    Private Sub Bexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Me.Close()

    End Sub

    Private Sub jenis_obat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setKoneksi()
        fetchData(DGjobat, "select nm_jobat as 'Jenis Obat' from tbl_jenis_obat")
    End Sub

    Private Sub Bsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsave.Click
        runQuery("insert into tbl_jenis_obat (nm_jobat) values ('" + Tnm_jenis.Text + "')")
        Call successMessage()
        Tnm_jenis.Clear()
        fetchData(DGjobat, "select nm_jobat as 'Jenis Obat' from tbl_jenis_obat")
        Tnm_jenis.Focus()
    End Sub
End Class