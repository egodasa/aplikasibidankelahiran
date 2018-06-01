Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FRakte
    Dim CR As New ReportDocument()
    Private Sub FRakte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CR.Load("F:\skprsifauzan\skripsi\WindowsApplication1\WindowsApplication1\suratketerangankelahiran.rpt")
        CR.SetParameterValue("id_kelahiran", Fdaftar_kelahiran.DGkelahiran.CurrentRow.Cells("id_kelahiran").Value)
        CRakte.ReportSource = CR
    End Sub
End Class