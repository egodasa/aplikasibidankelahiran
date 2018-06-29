Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FRkartu_berobat
    Dim CR As New ReportDocument()
    Private Sub Fkartu_berobat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CR.Load(_DIR & "kartu berobat.rpt")
        CR.SetParameterValue("no_pasien", Fpasien.DGpasien.CurrentRow.Cells("No_Pasien").Value)
        CR.SetParameterValue("nm_pasien", Fpasien.DGpasien.CurrentRow.Cells("Nama_Pasien").Value)
        CR.SetParameterValue("jk", Fpasien.DGpasien.CurrentRow.Cells("Jenis_Kelamin").Value)
        CR.SetParameterValue("pekerjaan", Fpasien.DGpasien.CurrentRow.Cells("Pekerjaan").Value)
        CR.SetParameterValue("alamat", Fpasien.DGpasien.CurrentRow.Cells("Alamat").Value)
        CRpasien.ReportSource = CR
    End Sub
End Class