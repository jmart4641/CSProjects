Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intCount As Integer
        Dim intTotal As Integer = 0

        For intCount = 1 To 100
            intTotal += intCount
            ' Display the sum of the numbers
            MessageBox.Show("The sum of 1 through 100 is " & intTotal.ToString())
        Next

    End Sub
End Class
