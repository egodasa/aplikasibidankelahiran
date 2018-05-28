Public Class Fasuhan_bayi
    Dim getData As String = "select id_asuhan,nm_asuhan from tbl_asuhan_bayi"
    Private Sub Fasuhan_bayi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DGkondisi.DataSource = fetchData(getData)
        DGkondisi.Columns("id_asuhan").Visible = False
    End Sub

    Private Sub Bsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsave.Click
        runQuery("insert into tbl_asuhan_bayi (nm_kondisi) values ('" & Tnm_kondisi.Text & "')")
        Call successMessage()
        Tnm_kondisi.Clear()
        DGkondisi.DataSource = fetchData(getData)
        Tnm_kondisi.Focus()
        Fkelahiran.getDataAsuhan()
    End Sub

    Private Sub Bedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bedit.Click
        runQuery("update tbl_asuhan_bayi set nm_asuhan = '" & Tnm_kondisi.Text & "' where id_asuhan = " & DGkondisi.CurrentRow.Cells(0).Value)
        Call editMessage()
        Bcancel.PerformClick()
        DGkondisi.DataSource = fetchData(getData)
    End Sub

    Private Sub Bdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bdelete.Click
        If MessageBox.Show("Apakah yakin data ini dihapus?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            runQuery(deleteSql("tbl_asuhan_bayi", "id_asuhan", DGkondisi.CurrentRow.Cells("id_asuhan").Value))
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

    Private Sub Bexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Bexit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Me.Close()
    End Sub

    Private Sub DGkondisi_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGkondisi.CellContentClick
        Bedit.Enabled = True
        Bdelete.Enabled = True
        Bcancel.Enabled = True
        Bsave.Enabled = False
        Tnm_kondisi.Text = DGkondisi.CurrentRow.Cells(1).Value
    End Sub

    Private Sub Fasuhan_bayi_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Fkelahiran.getDataAsuhan()
    End Sub

    Private Sub Fasuhan_bayi_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Fkelahiran.getDataAsuhan()
    End Sub
End Class