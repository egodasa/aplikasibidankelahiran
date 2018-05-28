Public Class Fkelola_obat
    Dim Cjobat As New DataTable
    Dim getData As String = "select a.id_obat, a.nm_obat as `Nama Obat`, a.stok as Stok, b.nm_jobat as `Jenis`, a.hrg_obat as `Harga` from tbl_obat a inner join tbl_jenis_obat b on a.id_jobat = b.id_jobat"
    Sub resetForm()
        Tnm_obat.Clear()
        Tstok.Clear()
        Cjns_obat.SelectedIndex = 0
        Thrg_obat.Clear()
        Tnm_obat.Focus()
    End Sub
    Private Sub Fkelola_obat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call setKoneksi()
        DGobat.DataSource = fetchData(getData)
        'Menambahkan isi combobox dari database
        Cjobat = fetchData("select * from tbl_jenis_obat")
        Cjns_obat.Items.Clear()
        Cjns_obat.DataSource = Cjobat
        Cjns_obat.DisplayMember = Cjobat.Columns(1).Caption
        Cjns_obat.ValueMember = Cjobat.Columns(0).Caption
        DGobat.Columns("id_obat").Visible = False
    End Sub

    Private Sub Bexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bexit.Click
        If MessageBox.Show("Apakah Anda yakin ingin KELUAR?", "Peringatan!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Fmenu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Bsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsave.Click
        runQuery("insert into tbl_obat (nm_obat, stok, id_jobat, hrg_obat) values ('" & Tnm_obat.Text & "', " & Tstok.Text & ", " & Cjns_obat.SelectedValue & ", " & Thrg_obat.Text & ")")
        Call successMessage()
        DGobat.DataSource = fetchData(getData)
        Call resetForm()
    End Sub

    Private Sub DGobat_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGobat.CellDoubleClick
        Tnm_obat.Text = DGobat.CurrentRow.Cells(1).Value
        Cjns_obat.Text = DGobat.CurrentRow.Cells(3).Value
        Tstok.Text = DGobat.CurrentRow.Cells(2).Value
        Thrg_obat.Text = DGobat.CurrentRow.Cells(4).Value
        Bedit.Enabled = True
        Bcancel.Enabled = True
        Bdelete.Enabled = True
        Bsave.Enabled = False
    End Sub

    Private Sub Bcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcancel.Click
        Bedit.Enabled = False
        Bcancel.Enabled = False
        Bdelete.Enabled = False
        Bsave.Enabled = True
        Call resetForm()
    End Sub

    Private Sub Bdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bdelete.Click
        If MessageBox.Show("Apakah yakin data ini dihapus?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            runQuery(deleteSql("tbl_obat", "id_obat", DGobat.CurrentRow.Cells("id_obat").Value))
            DGobat.DataSource = fetchData(getData)
            Bcancel.PerformClick()
        End If
    End Sub

    Private Sub Bedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bedit.Click
        runQuery("update tbl_obat set nm_obat = '" & Tnm_obat.Text &
                 "', id_jobat = " & Cjns_obat.SelectedValue &
                 ", hrg_obat = " & Thrg_obat.Text &
                 ", stok = " & Tstok.Text &
                 " where id_obat = " & DGobat.CurrentRow.Cells("id_obat").Value)
        Call editMessage()
        Bcancel.PerformClick()
        DGobat.DataSource = fetchData(getData)
    End Sub

    Private Sub Tcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tcari.TextChanged
        If Tcari.Text.Length <> 0 Then
            DGobat.DataSource = fetchData("select a.id_obat, a.nm_obat as `Nama Obat`, a.stok as Stok, b.nm_jobat as `Jenis`, a.hrg_obat as `Harga` from tbl_obat a inner join tbl_jenis_obat b on a.id_jobat = b.id_jobat where nm_obat like '% " & Tcari.Text & " %'")
        Else
            DGobat.DataSource = fetchData(getData)
        End If
    End Sub
End Class