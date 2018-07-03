Public Class Fmenu

    Private Sub Fmenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If jenis_pengguna = "Admin" Then
            data_obat.Visible = True
            data_jobat.Visible = True
            data_pasien.Visible = True
            data_user.Visible = True
            data_periksa.Visible = False
            data_kb.Visible = False
            data_kelahiran.Visible = False
        Else
            data_periksa.Visible = True
            data_kb.Visible = True
            data_kelahiran.Visible = True
            data_obat.Visible = False
            data_jobat.Visible = False
            data_pasien.Visible = False
            data_user.Visible = False
        End If
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles data_pasien.Click
        Fpasien.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles data_obat.Click
        Fkelola_obat.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles data_periksa.Click
        Fperiksa.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles data_kb.Click
        Fkb.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles data_jobat.Click
        Fjenis_obat.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles data_kelahiran.Click
        Fkelahiran.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Flogin.Show()
        Call logout()
        Me.Close()
    End Sub

    Private Sub Blaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Flaporan.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles data_user.Click
        Fpengguna.Show()
        Me.Hide()
    End Sub
End Class