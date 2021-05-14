' **************************************************************************************
' Author: Solution (Change Counter)
' Date: 10/31/2019
' Purpose: Illustrate the use of a "Class-Level Variable" to accumulate total.
' Input: click events on 4 PictureBoxes.
' Processing: Add the coin value of the corresponding image to the total.
' Output: Display the total.
' **************************************************************************************
Public Class Form1
    Dim dblTotal As Double = 0     ' class-level variable

    Private Sub pic5Cents_Click(sender As Object, e As EventArgs) Handles pic5Cents.Click
        dblTotal += 0.05

        ' Output
        lblTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub pic10Cents_Click(sender As Object, e As EventArgs) Handles pic10Cents.Click
        dblTotal += 0.1

        ' Output
        lblTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub pic25Cents_Click(sender As Object, e As EventArgs) Handles pic25Cents.Click
        dblTotal += 0.25

        ' Output
        lblTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub pic50Cents_Click(sender As Object, e As EventArgs) Handles pic50Cents.Click
        dblTotal += 0.5

        ' Output
        lblTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
