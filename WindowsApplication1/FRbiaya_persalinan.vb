Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FRbiaya_persalinan
    Dim CR As New ReportDocument()
    Private Sub FRbiaya_persalinan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CR.Load(_DIR & "biayabersalinan.rpt")
        CR.SetParameterValue("nm_pasien", Fdaftar_kelahiran.DGkelahiran.CurrentRow.Cells("Nama_Pasien").Value)
        CR.SetParameterValue("alamat", Fdaftar_kelahiran.DGkelahiran.CurrentRow.Cells("Alamat").Value)
        CR.SetParameterValue("tgl_persalinan", Fdaftar_kelahiran.DGkelahiran.CurrentRow.Cells("Tanggal_Kelahiran").Value)
        CR.SetParameterValue("biaya_persalinan", Fdaftar_kelahiran.DGkelahiran.CurrentRow.Cells("Biaya_Persalinan").Value)
        CR.SetParameterValue("biaya_perawatan", Fdaftar_kelahiran.DGkelahiran.CurrentRow.Cells("Biaya_Perawatan").Value)
        CR.SetParameterValue("biaya_perawatan_bayi", Fdaftar_kelahiran.DGkelahiran.CurrentRow.Cells("Biaya_Perawatan_Bayi").Value)
        CR.SetParameterValue("biaya_obat", Fdaftar_kelahiran.DGkelahiran.CurrentRow.Cells("Biaya_Obat_Obatan").Value)
        CR.SetParameterValue("biaya_cuci", Fdaftar_kelahiran.DGkelahiran.CurrentRow.Cells("Biaya_Cucian").Value)
        CR.SetParameterValue("biaya_akte", Fdaftar_kelahiran.DGkelahiran.CurrentRow.Cells("Biaya_Akte").Value)
        CR.SetParameterValue("biaya_transportasi", Fdaftar_kelahiran.DGkelahiran.CurrentRow.Cells("Biaya_Transportasi").Value)
        CR.SetParameterValue("biaya_lain", Fdaftar_kelahiran.DGkelahiran.CurrentRow.Cells("Biaya_Lain").Value)
        CRbiaya.ReportSource = CR
    End Sub
End Class