Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Reservation
    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Single room")
        ComboBox1.Items.Add("Double room")
        ComboBox1.Items.Add("Triple room")
        ComboBox1.Items.Add("Prime room")

        Dim Query As String = "Select * from reservation_details"
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
        Dim Customer_Id As Integer = TextBox1.Text
        Dim Checkin_Date As String = DateTimePicker1.Text
        Dim Checkin_Time As String = DateTimePicker2.Text
        Dim No_of_Guests As String = NumericUpDown1.Text
        Dim No_of_days_reserved As String = NumericUpDown2.Text
        Dim Room_No As String = TextBox2.Text
        Dim Room_Type As String = ComboBox1.Text
        Dim Checkout_Date As String = DateTimePicker3.Text
        Dim Checkout_Time As String = DateTimePicker4.Text
        Dim Query As String = "insert into reservation_details values (@Customer_Id, @Checkin_Date, @Checkin_Time, @No_of_Guests, @No_of_days_reserved, @Room_No, @Room_Type, @Checkout_Date, @Checkout_Time)"
        Using con As MySqlConnection = New MySqlConnection("Server=localhost; user=root; password=; database=hotel_management_system")
            Using cnn As MySqlCommand = New MySqlCommand(Query, con)
                cnn.Parameters.AddWithValue("@Customer_Id", Customer_Id)
                cnn.Parameters.AddWithValue("@Checkin_Date", Checkin_Date)
                cnn.Parameters.AddWithValue("@Checkin_Time", Checkin_Time)
                cnn.Parameters.AddWithValue("@No_of_Guests", No_of_Guests)
                cnn.Parameters.AddWithValue("@No_of_days_reserved", No_of_days_reserved)
                cnn.Parameters.AddWithValue("@Room_No", Room_No)
                cnn.Parameters.AddWithValue("@Room_Type", Room_Type)
                cnn.Parameters.AddWithValue("@Checkout_Date", Checkout_Date)
                cnn.Parameters.AddWithValue("@Checkout_Time", Checkout_Time)

                con.Open()
                cnn.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Data Saved")
                TextBox1.Clear()
                TextBox2.Clear()
            End Using
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Customer_Id As Integer = TextBox1.Text
        Dim query As String = "Delete from reservation_details where Customer_Id= @Customer_Id"
        Using con As MySqlConnection = New MySqlConnection("Server=localhost; user=root; password=; database=hotel_management_system")
            Using cnn As MySqlCommand = New MySqlCommand(query, con)
                cnn.Parameters.AddWithValue("@Customer_Id", Customer_Id)

                con.Open()
                cnn.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Data Delete and Cancel Reservation")

                TextBox1.Clear()
                TextBox2.Clear()
            End Using
        End Using
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Customer_Id As Integer = TextBox1.Text
        Dim Checkin_Date As String = DateTimePicker1.Text
        Dim Checkin_Time As String = DateTimePicker2.Text
        Dim No_of_Guests As String = NumericUpDown1.Text
        Dim No_of_days_reserved As String = NumericUpDown2.Text
        Dim Room_No As String = TextBox2.Text
        Dim Room_Type As String = ComboBox1.Text
        Dim Checkout_Date As String = DateTimePicker3.Text
        Dim Checkout_Time As String = DateTimePicker4.Text
        Dim Query As String = "update reservation_details set Customer_Id=@Customer_Id, Checkin_Date=@Checkin_Date, Checkin_Time=@Checkin_Time, No_of_Guests=@No_of_Guests, No_of_days_reserved=@No_of_days_reserved, Room_No=@Room_No, Room_Type=@Room_Type, Checkout_Date=@Checkout_Date, Checkout_Time=@Checkout_Time where Customer_Id=@Customer_Id"

        Using con As MySqlConnection = New MySqlConnection("Server=localhost; user=root; password=; database=hotel_management_system")
            Using cnn As MySqlCommand = New MySqlCommand(Query, con)
                cnn.Parameters.AddWithValue("@Customer_Id", Customer_Id)
                cnn.Parameters.AddWithValue("@Checkin_Date", Checkin_Date)
                cnn.Parameters.AddWithValue("@Checkin_Time", Checkin_Time)
                cnn.Parameters.AddWithValue("@No_of_Guests", No_of_Guests)
                cnn.Parameters.AddWithValue("@No_of_days_reserved", No_of_days_reserved)
                cnn.Parameters.AddWithValue("@Room_No", Room_No)
                cnn.Parameters.AddWithValue("@Room_Type", Room_Type)
                cnn.Parameters.AddWithValue("@Checkout_Date", Checkout_Date)
                cnn.Parameters.AddWithValue("@Checkout_Time", Checkout_Time)


                con.Open()
                cnn.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Data Update")

                TextBox1.Clear()
                TextBox2.Clear()

            End Using
        End Using
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Query As String = "Select * from reservation_details"
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