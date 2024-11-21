Public Class Loginpage
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user As String = TextBox1.Text
        Dim pass As String = TextBox2.Text
        If user = "Sparsh" And pass = "admin" Then
            loading.Show()
        Else
            MsgBox("You User and Password is incorrect")
        End If
    End Sub
End Class

