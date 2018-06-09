Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FRlaporan
    Dim CR As New ReportDocument()
    Dim sekarang As DateTime = Now()
    Sub laporan(ByVal tipe As String, Optional ByVal awal As Date = Nothing, Optional ByVal akhir As Date = Nothing)
        CR.Load(_DIR & "laporan.rpt")
        If tipe = "harian" Then
            CR.SetParameterValue("judul", "Laporan Berobat Per Hari " & sekarang.ToString("dddd, dd MMMM yyyy") & "")
            CRlaporan.SelectionFormula = "{tbl_periksa1.tgl_periksa} = Date(" & sekarang.ToString("yyyy") & "," & sekarang.ToString("MM") & "," & sekarang.ToString("dd") & ")"
        ElseIf tipe = "bulanan" Then
            CR.SetParameterValue("judul", "Laporan Berobat Per Bulan " & sekarang.ToString("MMMM yyyy"))
            CRlaporan.SelectionFormula = "Month({tbl_periksa1.tgl_periksa}) = " & sekarang.ToString("MM") & "AND Year({tbl_periksa1.tgl_periksa}) = " & sekarang.ToString("yyyy")
        ElseIf tipe = "tahunan" Then
            CR.SetParameterValue("judul", "Laporan Berobat Per Tahun " & sekarang.ToString("yyyy"))
            CRlaporan.SelectionFormula = "Year({tbl_periksa1.tgl_periksa}) = " & sekarang.ToString("yyyy")
        ElseIf tipe = "custom" Then
            CR.SetParameterValue("judul", "Laporan Berobat Per Tanggal " & awal.ToString("dd-MM-yyyy") & " - " & akhir.ToString("dd-MM-yyyy"))
            CRlaporan.SelectionFormula = "{tbl_periksa1.tgl_periksa} in Date(" & awal.ToString("yyyy,M,d") & ") to Date(" & akhir.ToString("yyyy,M,d") & ")"
        End If
        CRlaporan.ReportSource = CR
        Me.Show()
    End Sub
    Private Sub FRlaporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub
End Class