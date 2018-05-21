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
End Module
