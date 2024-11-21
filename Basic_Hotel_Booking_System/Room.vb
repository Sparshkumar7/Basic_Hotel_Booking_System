Imports MySql.Data.MySqlClient
Public Class Room
    Private Sub Room_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Single room")
        ComboBox1.Items.Add("Double room")
        ComboBox1.Items.Add("Triple room")
        ComboBox1.Items.Add("Prime room")

        ComboBox3.Items.Add("Available")
        ComboBox3.Items.Add("Unavailable")

        ComboBox4.Items.Add("A/c")
        ComboBox4.Items.Add("Non A/c")

        Dim Query As String = "Select * from Rooms"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Room_Id As Integer = TextBox7.Text
        Dim Room_Type As String = ComboBox1.Text
        Dim Beds As String = NumericUpDown1.Text
        Dim Air_conditioning As String = ComboBox4.Text
        Dim Room_Rate As String = TextBox1.Text
        Dim Is_Free As String = ComboBox3.Text
        Dim Query As String = "insert into Rooms values (@Room_Id, @Room_Type, @Beds,@Air_conditioning, @Room_Rate, @Is_Free)"
        Using con As MySqlConnection = New MySqlConnection("Server=localhost; user=root; password=; database=hotel_management_system")
            Using cnn As MySqlCommand = New MySqlCommand(Query, con)
                cnn.Parameters.AddWithValue("@Room_Id", Room_Id)
                cnn.Parameters.AddWithValue("@Room_Type", Room_Type)
                cnn.Parameters.AddWithValue("@Beds", Beds)
                cnn.Parameters.AddWithValue("@Air_conditioning", Air_conditioning)
                cnn.Parameters.AddWithValue("@Room_Rate", Room_Rate)
                cnn.Parameters.AddWithValue("@Is_Free", Is_Free)

                con.Open()
                cnn.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Data Saved")

                TextBox1.Clear()
                TextBox7.Clear()
            End Using
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Room_Id As Integer = TextBox7.Text
        Dim Room_Type As String = ComboBox1.Text
        Dim Beds As String = NumericUpDown1.Text
        Dim Air_conditioning As String = ComboBox4.Text
        Dim Room_Rate As String = TextBox1.Text
        Dim Is_Free As String = ComboBox3.Text
        Dim Query As String = "update Rooms set Room_Id=@Room_Id, Room_Type=@Room_Type, Beds=@Beds, Air_conditioning=@Air_conditioning, Room_Rate=@Room_Rate, Is_Free=@Is_Free where Room_Id=@Room_Id"

        Using con As MySqlConnection = New MySqlConnection("Server=localhost; user=root; password=; database=hotel_management_system")
            Using cnn As MySqlCommand = New MySqlCommand(Query, con)
                cnn.Parameters.AddWithValue("@Room_Id", Room_Id)
                cnn.Parameters.AddWithValue("@Room_Type", Room_Type)
                cnn.Parameters.AddWithValue("@Beds", Beds)
                cnn.Parameters.AddWithValue("@Air_conditioning", Air_conditioning)
                cnn.Parameters.AddWithValue("@Room_Rate", Room_Rate)
                cnn.Parameters.AddWithValue("@Is_Free", Is_Free)

                con.Open()
                cnn.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Data Update")

                TextBox1.Clear()
                TextBox7.Clear()
            End Using
        End Using

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Room_Id As Integer = TextBox7.Text
        Dim query As String = "Delete from Rooms where Room_Id= @Room_Id"
        Using con As MySqlConnection = New MySqlConnection("Server=localhost; user=root; password=; database=hotel_management_system")
            Using cnn As MySqlCommand = New MySqlCommand(query, con)
                cnn.Parameters.AddWithValue("@Room_Id", Room_Id)

                con.Open()
                cnn.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Data Delete")

                TextBox1.Clear()
                TextBox7.Clear()
            End Using
        End Using
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Query As String = "Select * from Rooms"
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
