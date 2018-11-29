Public Class Frekap_pasiens
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FRlaporan.laporanRekapPasien(Cnm_pasien.SelectedValue, Cjenis1.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FRlaporan.laporanRekapKeseluruhan(Cjenis2.Text, Twaktu.Value)
    End Sub

    Private Sub Flaporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call fetchComboboxData("select No_Pasien, Nama_Pasien FROM daftar_pasien", Cnm_pasien, "Nama_Pasien", "No_Pasien")
    End Sub

    Private Sub Bexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Fmenu.Show()
        Me.Close()
    End Sub
End Class