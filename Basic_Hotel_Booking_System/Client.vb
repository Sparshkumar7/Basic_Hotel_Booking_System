Imports MySql.Data.MySqlClient
Public Class Client
    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Male")
        ComboBox1.Items.Add("Female")

        Dim Query As String = "Select * from Clients_details"
        Using con As MySqlConnection = New MySqlConnection("Server=localhost; user=root; password=; database=hotel_management_system")
            Using cnn As MySqlCommand = New MySqlCommand(Query, con)
                Using da As New MySqlDataAdapter(cnn)
                    Using de As New DataTable()
                        da.Fill(de)
                        DataGridView1.DataSource = de
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button1.MouseHover
        Dim Id As Integer = TextBox7.Text
        Dim First_Name As String = TextBox1.Text
        Dim Last_Name As String = TextBox6.Text
        Dim Age As String = TextBox2.Text
        Dim Gender As String = ComboBox1.Text
        Dim Email_Id As String = TextBox3.Text
        Dim Address As String = TextBox4.Text
        Dim Phone_Number As String = TextBox5.Text
        Dim Query As String = "insert into Clients_details values (@Id, @First_Name, @Last_Name, @Age, @Gender, @Email_Id, @Address, @Phone_Number)"
        Using con As MySqlConnection = New MySqlConnection("Server=localhost; user=root; password=; database=hotel_management_system")
            Using cnn As MySqlCommand = New MySqlCommand(Query, con)
                cnn.Parameters.AddWithValue("@Id", Id)
                cnn.Parameters.AddWithValue("@First_Name", First_Name)
                cnn.Parameters.AddWithValue("@Last_Name", Last_Name)
                cnn.Parameters.AddWithValue("@Age", Age)
                cnn.Parameters.AddWithValue("@Gender", Gender)
                cnn.Parameters.AddWithValue("@Email_Id", Email_Id)
                cnn.Parameters.AddWithValue("@Address", Address)
                cnn.Parameters.AddWithValue("@Phone_Number", Phone_Number)

                con.Open()
                cnn.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Data Saved")

                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                TextBox6.Clear()
                TextBox7.Clear()
            End Using
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Id As Integer = TextBox7.Text
        Dim query As String = "Delete from Clients_details where Id= @Id"
        Using con As MySqlConnection = New MySqlConnection("Server=localhost; user=root; password=; database=hotel_management_system")
            Using cnn As MySqlCommand = New MySqlCommand(query, con)
                cnn.Parameters.AddWithValue("@Id", Id)


                con.Open()
                cnn.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Data Delete")

                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox7.Clear()
            End Using
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Id As Integer = TextBox7.Text
        Dim First_Name As String = TextBox1.Text
        Dim Last_Name As String = TextBox6.Text
        Dim Age As String = TextBox2.Text
        Dim Gender As String = ComboBox1.Text
        Dim Email_Id As String = TextBox3.Text
        Dim Address As String = TextBox4.Text
        Dim Phone_Number As String = TextBox5.Text
        Dim Query As String = "update Clients_details set Id=@Id, First_Name=@First_Name, Last_Name=@Last_Name, Age=@Age, Gender=@Gender, Email_Id=@Email_Id, Address=@Address, Phone_Number=@Phone_Number where Id=@Id"

        Using con As MySqlConnection = New MySqlConnection("Server=localhost; user=root; password=; database=hotel_management_system")
            Using cnn As MySqlCommand = New MySqlCommand(Query, con)
                cnn.Parameters.AddWithValue("@Id", Id)
                cnn.Parameters.AddWithValue("@First_Name", First_Name)
                cnn.Parameters.AddWithValue("@Last_Name", Last_Name)
                cnn.Parameters.AddWithValue("@Age", Age)
                cnn.Parameters.AddWithValue("@Gender", Gender)
                cnn.Parameters.AddWithValue("@Email_Id", Email_Id)
                cnn.Parameters.AddWithValue("@Address", Address)
                cnn.Parameters.AddWithValue("@Phone_Number", Phone_Number)

                con.Open()
                cnn.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Data Update")

                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox7.Clear()

            End Using
        End Using
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Query As String = "Select * from Clients_details"
        Using con As MySqlConnection = New MySqlConnection("Server=localhost; user=root; password=; database=hotel_management_system")
            Using cnn As MySqlCommand = New MySqlCommand(Query, con)
                Using da As New MySqlDataAdapter(cnn)
                    Using de As New DataTable()
                        da.Fill(de)
                        DataGridView1.DataSource = de
                    End Using
                End Using
            End Using
        End Using
    End Sub
End Class