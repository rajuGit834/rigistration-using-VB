Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Dim txtFirstName, txtMiddleName, txtLastName, checkGender, txtAddress As String
        txtFirstName = firstName.Text
        txtMiddleName = middleName.Text
        txtLastName = lastName.Text
        checkGender = gender.Text
        txtAddress = address.Text

        Try
            Dim query As String
            query = "INSERT INTO registration (firstname, middlename, lastname, gender, address) 
                     VALUES ('" & txtFirstName & "', '" & txtMiddleName & "', '" & txtLastName & "', '" & checkGender & "', '" & txtAddress & "')"
            COMMAND = New MySqlCommand(query, mySqlConnection)
            COMMAND.ExecuteNonQuery()
            MessageBox.Show("Data inserted successfully.")
            mySqlConnection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mySqlConnection.Open()
        Dim query As String
        query = "SELECT * FROM registration"
        adapter = New MySqlDataAdapter(query, mySqlConnection)
        adapter.Fill(Dst, "registration")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
