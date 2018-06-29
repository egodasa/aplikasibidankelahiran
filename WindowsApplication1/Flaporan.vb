Public Class Flaporan

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = False Then
            Tawal.Enabled = False
            Takhir.Enabled = False
            Bcetak.Enabled = False
            Bharian.Enabled = True
            Bbulan.Enabled = True
            Btahun.Enabled = True
        Else
            Tawal.Enabled = True
            Takhir.Enabled = True
            Bcetak.Enabled = True
            Bharian.Enabled = False
            Bbulan.Enabled = False
            Btahun.Enabled = False
        End If
    End Sub

    Private Sub Bexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Fmenu.Show()
        Me.Close()
    End Sub

    Private Sub Bharian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bharian.Click
        FRlaporan.laporan("harian")
    End Sub

    Private Sub Bbulan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bbulan.Click
        FRlaporan.laporan("bulanan")
    End Sub

    Private Sub Btahun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btahun.Click
        FRlaporan.laporan("tahunan")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcetak.Click
        FRlaporan.laporan("custom", Tawal.Value, Takhir.Value)
    End Sub

    Private Sub Flaporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class