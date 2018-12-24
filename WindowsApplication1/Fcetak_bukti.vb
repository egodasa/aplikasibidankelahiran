Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Fcetak_bukti
    Dim CR As New ReportDocument()
    Private Sub Fcetak_bukti_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CR.Load(_DIR & "cetakberobat.rpt")
        CRbukti.SelectionFormula = "{tbl_periksa1.id_periksa} = '" & Fperiksa.id_periksa_siap & "'"
        CRbukti.ReportSource = CR
    End Sub
End Class