﻿Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FRakte
    Dim CR As New ReportDocument()
    Private Sub FRakte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CR.Load(_DIR & "suratketerangankelahiran.rpt")
        CR.SetParameterValue("id_kelahiran", Fdaftar_kelahiran.DGkelahiran.CurrentRow.Cells("Id_Kelahiran").Value)
        CRakte.ReportSource = CR
    End Sub
End Class