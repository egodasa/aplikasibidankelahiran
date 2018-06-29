Public Class Fdaftar_kelahiran
    Dim getData As String = "select * from daftar_kelahiran"
    Private Sub Fdaftar_kelahiran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DGkelahiran.DataSource = fetchData(getData)
        DGkelahiran.Columns("No_Pasien").Visible = False
        DGkelahiran.Columns("Id_Kelahiran").Visible = False
    End Sub

    Private Sub Tcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tcari.TextChanged
        If Tcari.Text.Length <> 0 Then
            DGkelahiran.DataSource = fetchData(getData & " where `Nama_Pasien` like '%" & Tcari.Text & "%' OR `Nama_Suami` like '%" & Tcari.Text & "%' OR `No_Pasien` like '%" & Tcari.Text & "%'")
        Else
            DGkelahiran.DataSource = fetchData(getData)
        End If
    End Sub

    Private Sub Bbiaya_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bbiaya.Click
        FRbiaya_persalinan.Show()
    End Sub

    Private Sub Bakte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bakte.Click
        FRakte.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class