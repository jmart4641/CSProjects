Public Class Form1
    Private Sub btnRunDemo_Click(sender As Object, e As EventArgs) Handles btnRunDemo.Click
        ' Declare variable. This initializes it with the values of 0. Pg 322
        Dim intCOunt As Integer = 0

        ' This lis is the beginning of a Do While loop that will executed as long as it intCount ia less than 10.
        ' pretest  Do While loop.
        Do While intCOunt < 10
            lstOutput.Items.Add("Hello")
            intCOunt += 1                   ' Combined assignment operator to add 1 to inCount.(Counter). inCount keeps track of the number of iterations the loop has perfomed.
        Loop
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the list.
        lstOutput.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the form
        Me.Close()
    End Sub
End Class
