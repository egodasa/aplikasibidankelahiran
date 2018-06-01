Imports MySql.Data.MySqlClient
Module db
    Public kon As MySqlConnection
    Public da As MySqlDataAdapter
    Public ds As New DataSet
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public str As String
    Public _DIR As String = "F:\skprsifauzan\skripsi\WindowsApplication1\WindowsApplication1\"
    Sub setKoneksi()
        str = "Server=192.168.56.1;uid=root;pwd=123456;database=db_bidan;port=3306"
        kon = New MySqlConnection(str)
        If kon.State = ConnectionState.Closed Then
            kon.Open()
        Else
            MsgBox("lun")
        End If
    End Sub
    Function fetchData(ByVal q As String)
        Call setKoneksi()
        da = New MySqlDataAdapter(q, kon)
        ds = New DataSet
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
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
End Module
