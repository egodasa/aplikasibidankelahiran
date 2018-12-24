Public Class Flaporan

    Private Sub Bexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Flogin.Show()
        Call logout()
        Me.Close()
    End Sub

    Private Sub Bharian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FRlaporan.laporan("harian")
    End Sub

    Private Sub Bbulan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FRlaporan.laporan("bulanan")
    End Sub

    Private Sub Btahun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FRlaporan.laporan("tahunan")
    End Sub

    Private Sub Flaporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call fetchComboboxData("select No_Pasien, Nama_Pasien FROM daftar_pasien", Cnm_pasien, "Nama_Pasien", "No_Pasien")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FRlaporan.laporan("bayi")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FRlaporan.laporan("pasien")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        FRlaporan.laporanPemasukan(Cjenis2.Text, Twaktu.Value)
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        FRlaporan.laporanRekapPasien(Cnm_pasien.SelectedValue, Cjenis3.Text)
    End Sub
End Class