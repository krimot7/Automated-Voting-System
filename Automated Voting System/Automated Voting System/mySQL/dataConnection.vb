Imports MySql.Data.MySqlClient

Module dataConnection

    Public Sub dbConnection()

        conn = New MySqlConnection
        conn.ConnectionString = "server=server_id;user id=userid;password=password;database=general_elections"
        conn.Open()

    End Sub

End Module
