Imports MySql.Data.MySqlClient
Module db
    Public kon As MySqlConnection
    Public da As MySqlDataAdapter
    Public ds As New DataSet
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public str As String
    Sub setKoneksi()
        str = "Server=192.168.56.1;uid=root;pwd=123456;database=db_bidan;port=3306"
        kon = New MySqlConnection(str)
        If kon.State = ConnectionState.Closed Then
            kon.Open()
        Else
            MsgBox("lun")
        End If
    End Sub
    Sub fetchData(ByVal dt As DataGridView, ByVal q As String)
        Call setKoneksi()
        da = New MySqlDataAdapter(q, kon)
        ds = New DataSet
        da.Fill(ds)
        dt.DataSource = ds.Tables(0)
        dt.ReadOnly = True
    End Sub
    Sub runQuery(ByVal q As String)
        cmd = New MySqlCommand(q, kon)
        cmd.Connection = kon
        cmd.CommandType = CommandType.Text
        cmd.CommandText = q
        cmd.ExecuteNonQuery()

    End Sub
    Sub successMessage()
        MessageBox.Show("Data berhasil disimpan", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Sub editMessage()
        MessageBox.Show("Data berhasil diubah", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Function deleteSql(ByVal t As String, ByVal id As String, ByVal id_val As String)
        Return "delete from " & t & " where " & id & " = " & id_val
    End Function
    'Dim getDataCari As String = "select a.no_pasien,a.id_kelahiran,b.nm_pasien as `Nama Pasien`,a.tgl_kelahiran as `Tanggal Kelahiran`, a.nm_suami as `Nama Suami`, a.cara_persalinan as `Cara Persalinan`, a.penolongan_persalinan as `Penolongan Persalinan`, a.keadaan_ibu as `Keadaan Ibu`, a.umur_kehamilan as `Umur Kehamilan`,count(c.id_bayi) as `Banyak Anak` from tbl_kelahiran a join tbl_pasien b on a.no_pasien = b.no_pasien join tbl_bayi_lahir c on a.id_kelahiran = c.id_kelahiran where CONCAT(b.nm_pasien, ' ',a.nm_suami) like '% " & Tcari.Text & " %' group by a.id_kelahiran"
End Module
