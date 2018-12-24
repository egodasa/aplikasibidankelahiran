Public Class Fpasien
    Dim getData As String = "select * from daftar_pasien_revisi"
    Sub resetForm()
        Tnm_pasien.Clear()
        Ttgl_lahir.ResetText()
        Cjk.SelectedIndex = -1
        Talamat.Clear()
        Tpekerjaan.Clear()
    End Sub
    Private Sub Fpasien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DGpasien.DataSource = fetchData(getData)
    End Sub

    Private Sub Bexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bexit.Click
        If MessageBox.Show("Apakah Anda yakin ingin KELUAR?", "Peringatan!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Fmenu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ttgl_lahir.ValueChanged

    End Sub

    Private Sub Tnm_ibu_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tnm_pasien.TextChanged

    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click

    End Sub

    Private Sub Bsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsave.Click
        runQuery("insert into tbl_pasien (nm_pasien, tgl_lahir, jk, pekerjaan, alamat) values ('" & Tnm_pasien.Text & "', STR_TO_DATE('" & Ttgl_lahir.Value.ToString("dd-MM-yyyy") & "', '%d-%m-%Y'), '" & Cjk.Text & "', '" & Tpekerjaan.Text & "', '" & Talamat.Text & "') ")
        Call successMessage()
        Call resetForm()
        Tnm_pasien.Focus()
        DGpasien.DataSource = fetchData(getData)
    End Sub

    Private Sub DGpasien_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGpasien.CellDoubleClick
        Tnm_pasien.Text = DGpasien.CurrentRow.Cells("Nama_Pasien").Value
        Ttgl_lahir.Value = Date.ParseExact(DGpasien.CurrentRow.Cells("Tanggal_Lahir").Value, "dd/MM/yyyy",
            System.Globalization.DateTimeFormatInfo.InvariantInfo)
        Cjk.Text = DGpasien.CurrentRow.Cells("Jenis_Kelamin").Value
        Tpekerjaan.Text = DGpasien.CurrentRow.Cells("Pekerjaan").Value
        Talamat.Text = DGpasien.CurrentRow.Cells("Alamat").Value
        Bsave.Enabled = False
        Bedit.Enabled = True
        Bcancel.Enabled = True
        Bdelete.Enabled = True
    End Sub

    Private Sub Bcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcancel.Click
        Bedit.Enabled = False
        Bcancel.Enabled = False
        Bdelete.Enabled = False
        Bsave.Enabled = True
        Call resetForm()
    End Sub

    Private Sub Bedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bedit.Click
        Dim tgl As String = "STR_TO_DATE('" & Ttgl_lahir.Value.ToString("dd-MM-yyyy") & "', '%d-%m-%Y')"
        runQuery("update tbl_pasien set nm_pasien = '" & Tnm_pasien.Text &
                 "', jk = '" & Cjk.Text &
                 "', tgl_lahir = " & tgl &
                 ", pekerjaan = '" & Tpekerjaan.Text &
                 "', alamat = '" & Talamat.Text &
                 "' where no_pasien = " & DGpasien.CurrentRow.Cells(0).Value)
        Call editMessage()
        Bcancel.PerformClick()
        DGpasien.DataSource = fetchData(getData)
    End Sub

    Private Sub Bdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bdelete.Click
        If MessageBox.Show("Apakah yakin data ini dihapus?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            runQuery(deleteSql("tbl_pasien", "no_pasien", DGpasien.CurrentRow.Cells(0).Value))
            DGpasien.DataSource = fetchData(getData)
            Bcancel.PerformClick()
        End If
    End Sub

    Private Sub Bcetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcetak.Click
        FRkartu_berobat.ShowDialog()
    End Sub

    Private Sub Tcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tcari.TextChanged
        If Tcari.Text.Length <> 0 Then
            DGpasien.DataSource = fetchData("select * from daftar_pasien where `No_Pasien` like '%" & Tcari.Text & "%' OR `Nama_Pasien` like '%" & Tcari.Text & "%'")
        Else
            DGpasien.DataSource = fetchData(getData)
        End If
    End Sub
End Class