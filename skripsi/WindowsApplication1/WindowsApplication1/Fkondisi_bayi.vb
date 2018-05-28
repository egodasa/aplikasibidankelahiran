Public Class Fkondisi_bayi
    Dim getData As String = "select id_kondisi,nm_kondisi from tbl_kondisi_lahir"
    Private Sub Fkondisi_bayi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DGkondisi.DataSource = fetchData(getData)
        DGkondisi.Columns("id_kondisi").Visible = False
    End Sub

    Private Sub Bsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsave.Click
        runQuery("insert into tbl_kondisi_lahir (nm_kondisi) values ('" & Tnm_kondisi.Text & "')")
        Call successMessage()
        Tnm_kondisi.Clear()
        DGkondisi.DataSource = fetchData(getData)
        Tnm_kondisi.Focus()
    End Sub

    Private Sub Bedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bedit.Click
        runQuery("update tbl_jenis_obat set nm_kondisi = '" & Tnm_kondisi.Text & "' where id_kondisi = " & DGkondisi.CurrentRow.Cells(0).Value)
        Call editMessage()
        Bcancel.PerformClick()
        DGkondisi.DataSource = fetchData(getData)
    End Sub

    Private Sub Bdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bdelete.Click
        If MessageBox.Show("Apakah yakin data ini dihapus?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            runQuery(deleteSql("tbl_kondisi_lahir", "id_kondisi", DGkondisi.CurrentRow.Cells("id_kondisi").Value))
            DGkondisi.DataSource = fetchData(getData)
            Bcancel.PerformClick()
        End If
    End Sub

    Private Sub Bcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcancel.Click
        Bedit.Enabled = False
        Bdelete.Enabled = False
        Bcancel.Enabled = False
        Bsave.Enabled = True
        Tnm_kondisi.Clear()
    End Sub

    Private Sub Bexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Me.Close()
    End Sub

    Private Sub Fkondisi_bayi_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Fkelahiran.getDataKondisi()
    End Sub

    Private Sub DGkondisi_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGkondisi.CellContentDoubleClick
        Bedit.Enabled = True
        Bdelete.Enabled = True
        Bcancel.Enabled = True
        Bsave.Enabled = False
        Tnm_kondisi.Text = DGkondisi.CurrentRow.Cells(1).Value
    End Sub

    Private Sub Fkondisi_bayi_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Fkelahiran.getDataKondisi()
    End Sub
End Class