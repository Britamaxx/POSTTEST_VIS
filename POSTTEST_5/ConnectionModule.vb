Imports MySql.Data.MySqlClient
Imports MySqlConnector

Module ModuleKoneksi
    Public Conn As MySqlConnection
    Public Cmd As MySqlCommand
    Public Da As MySqlDataAdapter
    Public Dt As DataTable

    Public Sub Koneksi()
        Try
            Conn = New MySqlConnection("server=localhost;userid=root;password=;database=dbkendaraan")
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Koneksi gagal: " & ex.Message)
        End Try
    End Sub
End Module