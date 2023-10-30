Imports MySql.Data.MySqlClient
Module Module1
    Public mySqlConnection As MySqlConnection = New MySqlConnection("server=localhost;userid=root;password=root;database=vbdatabase")
    Public COMMAND As MySqlCommand
    Public adapter As MySqlDataAdapter
    Public Dst As New DataSet
End Module
