Public Class Fkelola_obat
    Dim DGjobat As New DataGridView
    Dim Cjobat As New DataTable
    Sub resetForm()
        Tnm_obat.Clear()
        Tstok.Clear()
        Cjns_obat.SelectedIndex = 0
        Thrg_obat.Clear()
        Tnm_obat.Focus()
    End Sub
    Private Sub Fkelola_obat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call setKoneksi()
        fetchData(DGobat, "select a.nm_obat as `Nama Obat`, a.stok as Stok, b.nm_jobat as `Jenis`, a.status as Status from tbl_obat a inner join tbl_jenis_obat b on a.id_jobat = b.id_jobat")
        fetchData(DGjobat, "select * from tbl_jenis_obat")
        'Menambahkan isi combobox dari database
        Cjobat = DGjobat.DataSource  'Cjobat penampung sementara dari datagridview ke combobox
        Cjns_obat.Items.Clear()
        Cjns_obat.DataSource = Cjobat
        Cjns_obat.DisplayMember = Cjobat.Columns(1).Caption
        Cjns_obat.ValueMember = Cjobat.Columns(0).Caption
    End Sub

    Private Sub Bexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Me.Close()
    End Sub

    Private Sub Bsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsave.Click
        runQuery("insert into tbl_obat (nm_obat, stok, id_jobat) values ('" & Tnm_obat.Text & "', " & Tstok.Text & ", " & Cjns_obat.SelectedValue & ")")
        MessageBox.Show("Data berhasil disimpan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        fetchData(DGobat, "select nm_obat as `Nama Obat`, stok as Stok, status as Status from tbl_obat")
        Call resetForm()
    End Sub
End Class