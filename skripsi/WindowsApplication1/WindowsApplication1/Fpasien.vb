Public Class Fpasien
    Sub resetForm()
        Tnm_pasien.Clear()
        Ttgl_lahir.ResetText()
        Cjk.SelectedIndex = 0
        Talamat.Clear()
        Tpekerjaan.Clear()
    End Sub
    Private Sub Fpasien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fetchData(DGpasien, "select no_pasien as `No Pasien`, nm_pasien as `Nama Pasien`, DATE_FORMAT(tgl_lahir, '%d/%m/%Y') as `Tgl lahir`, jk as `Jenis Kelamin`, pekerjaan as `Pekerjaaan`, alamat as `Alamat` from tbl_pasien")
    End Sub

    Private Sub Bexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Me.Close()
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
        fetchData(DGpasien, "select no_pasien as `No Pasien`, nm_pasien as `Nama Pasien`, DATE_FORMAT(tgl_lahir, '%d/%m/%Y') as `Tgl lahir`, jk as `Jenis Kelamin`, pekerjaan as `Pekerjaaan`, alamat as `Alamat` from tbl_pasien")
    End Sub
End Class