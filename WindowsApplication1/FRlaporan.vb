Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FRlaporan
    Dim CR As New ReportDocument()
    Dim sekarang As DateTime = Now()
    Sub laporan(ByVal tipe As String, Optional ByVal awal As Date = Nothing, Optional ByVal akhir As Date = Nothing)
        If tipe = "harian" Then
            CR.Load(_DIR & "laporan.rpt")
            CR.SetParameterValue("judul", "Laporan Pemasukan Hari " & sekarang.ToString("dddd, dd MMMM yyyy") & "")
            CRlaporan.SelectionFormula = "{laporan_harian1.Tgl_Periksa} = Date(" & sekarang.ToString("yyyy") & "," & sekarang.ToString("MM") & "," & sekarang.ToString("dd") & ")"
        ElseIf tipe = "bulanan" Then
            CR.Load(_DIR & "lap_bulanan.rpt")
            'CR.SetParameterValue("judul", "Laporan Berobat Per Bulan " & sekarang.ToString("MMMM yyyy"))
            'CRlaporan.SelectionFormula = "Month({laporan_harian1.Tgl_Periksa}) = " & sekarang.ToString("MM") & " AND Year({laporan_harian1.Tgl_Periksa}) = " & sekarang.ToString("yyyy")
        ElseIf tipe = "tahunan" Then
            CR.Load(_DIR & "lap_tahunan.rpt")
            'CR.SetParameterValue("judul", "Laporan Berobat Per Tahun " & sekarang.ToString("yyyy"))
            'CRlaporan.SelectionFormula = "Year({laporan_harian1.Tgl_Periksa}) = " & sekarang.ToString("yyyy") & " GROUP BY laporan_harian1.Nama_Obat"
        ElseIf tipe = "custom" Then
            CR.Load(_DIR & "laporan.rpt")
            CR.SetParameterValue("judul", "Laporan Berobat Per Tanggal " & awal.ToString("dd-MM-yyyy") & " - " & akhir.ToString("dd-MM-yyyy"))
            CRlaporan.SelectionFormula = "{laporan_harian1.Tgl_Periksa} in Date(" & awal.ToString("yyyy,M,d") & ") to Date(" & akhir.ToString("yyyy,M,d") & ")"
        ElseIf tipe = "bayi" Then
            CR.Load(_DIR & "bayi.rpt")
        ElseIf tipe = "pasien" Then
            CR.Load(_DIR & "pasien.rpt")
        ElseIf tipe = "obat" Then
            CR.Load(_DIR & "laporan_stok_obat.rpt")
        End If
        CRlaporan.ReportSource = CR
        Me.Show()
    End Sub
    Sub laporanRekapPasien(ByVal no_pasien As Integer, ByVal tipe As String)
        Dim laporan As String = Nothing
        If tipe = "Rekap Berobat Umum" Then
            laporan = "lap_berobat_umum_perorang.rpt"
        ElseIf tipe = "Rekap KB" Then
            laporan = "lap_kb_perorang.rpt"
        ElseIf tipe = "Rekap Kehamilan" Then
            laporan = "lap_kehamilan_perorang.rpt"
        ElseIf tipe = "Rekap Kelahiran" Then
            laporan = "lap_kelahiran_perorang.rpt"
        End If
        CR.Load(_DIR & laporan)
        CR.SetParameterValue("no_pasien", no_pasien)
        CRlaporan.ReportSource = CR
        Me.Show()
    End Sub
    Sub laporanRekapKeseluruhan(ByVal tipe As String, ByVal waktu As Date)
        Dim laporan As String = Nothing
        If tipe = "Rekap Berobat Umum" Then
            laporan = "lap_berobat_umum.rpt"
        ElseIf tipe = "Rekap KB" Then
            laporan = "lap_kb.rpt"
        ElseIf tipe = "Rekap Kehamilan" Then
            laporan = "lap_kehamilan.rpt"
        ElseIf tipe = "Rekap Kelahiran" Then
            laporan = "lap_kelahiran.rpt"
        End If
        CR.Load(_DIR & laporan)
        CR.SetParameterValue("bulan", waktu.Month())
        CR.SetParameterValue("tahun", waktu.Year())
        CR.SetParameterValue("waktu", waktu)
        CRlaporan.ReportSource = CR
        Me.Show()
    End Sub
    Sub laporanPemasukan(ByVal tipe As String, ByVal waktu As Date)
        Dim laporan As String = Nothing
        If tipe = "Pemasukan dari Berobat Umum" Then
            laporan = "lap_berobat_umum_biaya.rpt"
        ElseIf tipe = "Pemasukan dari KB" Then
            laporan = "lap_kb_biaya.rpt"
        ElseIf tipe = "Pemasukan dari Kelahiran" Then
            laporan = "lap_kelahiran_biaya.rpt"
        ElseIf tipe = "Pemasukan Keseluruhan" Then
            laporan = "lap_pemasukan.rpt"
        End If
        CR.Load(_DIR & laporan)
        CR.SetParameterValue("bulan", waktu.Month())
        CR.SetParameterValue("tahun", waktu.Year())
        CR.SetParameterValue("waktu", waktu)
        If tipe = "Pemasukan Keseluruhan" Then
            CR.SetParameterValue("tahun12", 12)
        End If
        CRlaporan.ReportSource = CR
        Me.Show()
    End Sub
    Private Sub FRlaporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CRlaporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CRlaporan.Load

    End Sub
End Class