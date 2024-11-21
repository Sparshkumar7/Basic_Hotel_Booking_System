Imports MySql.Data.MySqlClient
Public Class Homepage
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = DateTime.Now.ToString("dd-MMM-yyyy  hh:mm:ss tt")

    End Sub

    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        Panel3.Controls.Clear()
        Dashboard.TopLevel = False
        Panel3.Controls.Add(Dashboard)
        Dashboard.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel3.Controls.Clear()
        Client.TopLevel = False
        Panel3.Controls.Add(Client)
        Client.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel3.Controls.Clear()
        Room.TopLevel = False
        Panel3.Controls.Add(Room)
        Room.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel3.Controls.Clear()
        Reservation.TopLevel = False
        Panel3.Controls.Add(Reservation)
        Reservation.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel3.Controls.Clear()
        Dashboard.TopLevel = False
        Panel3.Controls.Add(Dashboard)
        Dashboard.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dashboard.Show()
        Me.Close()
    End Sub
End Class