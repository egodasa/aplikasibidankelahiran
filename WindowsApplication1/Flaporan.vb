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
End Class