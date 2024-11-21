Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currentReservationCount As Integer = 0
        Dim query As String = "SELECT Checkout_Date, Checkout_Time FROM reservation_details"
        Using con As New MySqlConnection("Server=localhost; user=root; password=; database=hotel_management_system")
            Using cmd As New MySqlCommand(query, con)
                con.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim checkoutDate As DateTime = DateTime.Parse(reader("Checkout_Date").ToString())
                        Dim checkoutTime As DateTime = DateTime.Parse(reader("Checkout_Time").ToString())

                        Dim checkoutDateTime As DateTime = checkoutDate.Date.Add(checkoutTime.TimeOfDay)

                        If checkoutDateTime > DateTime.Now Then
                            currentReservationCount += 1
                        End If
                    End While
                End Using
            End Using
        End Using
        Label4.Text = currentReservationCount.ToString()


        Dim Quer As String = "SELECT COUNT(*) FROM Clients_details"
        Using con As MySqlConnection = New MySqlConnection("Server=localhost; user=root; password=; database=hotel_management_system")
            Using cnn As MySqlCommand = New MySqlCommand(Quer, con)
                Using da As New MySqlDataAdapter(cnn)
                    Using de As New DataTable()
                        da.Fill(de)
                        If de.Rows.Count > 0 Then
                            Label6.Text = de.Rows(0)(0).ToString()
                        Else
                            Label6.Text = "0"
                        End If
                    End Using
                End Using
            End Using
        End Using

        Dim Que As String = "SELECT COUNT(*) FROM Rooms"
        Using con As MySqlConnection = New MySqlConnection("Server=localhost; user=root; password=; database=hotel_management_system")
            Using cnn As MySqlCommand = New MySqlCommand(Que, con)
                Using da As New MySqlDataAdapter(cnn)
                    Using de As New DataTable()
                        da.Fill(de)
                        If de.Rows.Count > 0 Then
                            Label5.Text = de.Rows(0)(0).ToString()
                        Else
                            Label5.Text = "0"
                        End If
                    End Using
                End Using
            End Using
        End Using

        Dim Qu As String = "SELECT COUNT(*) FROM rooms WHERE Is_Free = 'Available'"
        Using con As MySqlConnection = New MySqlConnection("Server=localhost; user=root; password=; database=hotel_management_system")
            Using cnn As MySqlCommand = New MySqlCommand(Qu, con)
                Using da As New MySqlDataAdapter(cnn)
                    Using de As New DataTable()
                        da.Fill(de)
                        If de.Rows.Count > 0 Then
                            Label7.Text = de.Rows(0)(0).ToString()
                        Else
                            Label7.Text = "0"
                        End If
                    End Using
                End Using
            End Using
        End Using


        Dim Q As String = "SELECT COUNT(*) FROM rooms WHERE Is_Free = 'Unavailable'"
        Using con As MySqlConnection = New MySqlConnection("Server=localhost; user=root; password=; database=hotel_management_system")
            Using cnn As MySqlCommand = New MySqlCommand(Q, con)
                Using da As New MySqlDataAdapter(cnn)
                    Using de As New DataTable()
                        da.Fill(de)
                        If de.Rows.Count > 0 Then
                            Label12.Text = de.Rows(0)(0).ToString()
                        Else
                            Label12.Text = "0"
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim currentReservationCount As Integer = 0
        Dim query As String = "SELECT Checkout_Date, Checkout_Time FROM reservation_details"
        Using con As New MySqlConnection("Server=localhost; user=root; password=; database=hotel_management_system")
            Using cmd As New MySqlCommand(query, con)
                con.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim checkoutDate As DateTime = DateTime.Parse(reader("Checkout_Date").ToString())
                        Dim checkoutTime As DateTime = DateTime.Parse(reader("Checkout_Time").ToString())

                        Dim checkoutDateTime As DateTime = checkoutDate.Date.Add(checkoutTime.TimeOfDay)

                        If checkoutDateTime > DateTime.Now Then
                            currentReservationCount += 1
                        End If
                    End While
                End Using
            End Using
        End Using
        Label4.Text = currentReservationCount.ToString()

        Dim Quer As String = "SELECT COUNT(*) FROM Clients_details"
        Using con As MySqlConnection = New MySqlConnection("Server=localhost; user=root; password=; database=hotel_management_system")
            Using cnn As MySqlCommand = New MySqlCommand(Quer, con)
                Using da As New MySqlDataAdapter(cnn)
                    Using de As New DataTable()
                        da.Fill(de)
                        If de.Rows.Count > 0 Then
                            Label6.Text = de.Rows(0)(0).ToString()
                        Else
                            Label6.Text = "0"
                        End If
                    End Using
                End Using
            End Using
        End Using

        Dim Que As String = "SELECT COUNT(*) FROM Rooms"
        Using con As MySqlConnection = New MySqlConnection("Server=localhost; user=root; password=; database=hotel_management_system")
            Using cnn As MySqlCommand = New MySqlCommand(Que, con)
                Using da As New MySqlDataAdapter(cnn)
                    Using de As New DataTable()
                        da.Fill(de)
                        If de.Rows.Count > 0 Then
                            Label5.Text = de.Rows(0)(0).ToString()
                        Else
                            Label5.Text = "0"
                        End If
                    End Using
                End Using
            End Using
        End Using

        Dim Qu As String = "SELECT COUNT(*) FROM rooms WHERE Is_Free = 'Available'"
        Using con As MySqlConnection = New MySqlConnection("Server=localhost; user=root; password=; database=hotel_management_system")
            Using cnn As MySqlCommand = New MySqlCommand(Qu, con)
                Using da As New MySqlDataAdapter(cnn)
                    Using de As New DataTable()
                        da.Fill(de)
                        If de.Rows.Count > 0 Then
                            Label7.Text = de.Rows(0)(0).ToString()
                        Else
                            Label7.Text = "0"
                        End If
                    End Using
                End Using
            End Using
        End Using


        Dim Q As String = "SELECT COUNT(*) FROM rooms WHERE Is_Free = 'Unavailable'"
        Using con As MySqlConnection = New MySqlConnection("Server=localhost; user=root; password=; database=hotel_management_system")
            Using cnn As MySqlCommand = New MySqlCommand(Q, con)
                Using da As New MySqlDataAdapter(cnn)
                    Using de As New DataTable()
                        da.Fill(de)
                        If de.Rows.Count > 0 Then
                            Label12.Text = de.Rows(0)(0).ToString()
                        Else
                            Label12.Text = "0"
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub


End Class