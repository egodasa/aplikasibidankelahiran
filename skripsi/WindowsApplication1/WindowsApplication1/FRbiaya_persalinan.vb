Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FRbiaya_persalinan
    Dim CR As New ReportDocument()
    Private Sub FRbiaya_persalinan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CR.Load(_DIR & "biayabersalinan.rpt")
        CR.SetParameterValue("nm_pasien", Fdaftar_kelahiran.DGkelahiran.CurrentRow.Cells("Nama Pasien").Value)
        CR.SetParameterValue("alamat", Fdaftar_kelahiran.DGkelahiran.CurrentRow.Cells("Alamat").Value)
        CR.SetParameterValue("tgl_persalinan", Fdaftar_kelahiran.DGkelahiran.CurrentRow.Cells("Tanggal Kelahiran").Value)
        CR.SetParameterValue("biaya_persalinan", Fdaftar_kelahiran.DGkelahiran.CurrentRow.Cells("Persalinan").Value)
        CR.SetParameterValue("biaya_perawatan", Fdaftar_kelahiran.DGkelahiran.CurrentRow.Cells("Perawatan").Value)
        CR.SetParameterValue("biaya_perawatan_bayi", Fdaftar_kelahiran.DGkelahiran.CurrentRow.Cells("Perawatan Bayi").Value)
        CR.SetParameterValue("biaya_obat", Fdaftar_kelahiran.DGkelahiran.CurrentRow.Cells("Obat-Obatan").Value)
        CR.SetParameterValue("biaya_cuci", Fdaftar_kelahiran.DGkelahiran.CurrentRow.Cells("Cucian").Value)
        CR.SetParameterValue("biaya_akte", Fdaftar_kelahiran.DGkelahiran.CurrentRow.Cells("Akte").Value)
        CR.SetParameterValue("biaya_transportasi", Fdaftar_kelahiran.DGkelahiran.CurrentRow.Cells("Transportasi").Value)
        CR.SetParameterValue("biaya_lain", Fdaftar_kelahiran.DGkelahiran.CurrentRow.Cells("Lain").Value)
        CRbiaya.ReportSource = CR
    End Sub
End Class