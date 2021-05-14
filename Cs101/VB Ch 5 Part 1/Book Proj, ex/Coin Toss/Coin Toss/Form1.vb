Public Class Form1
    Private Sub btnaTose_Click(sender As Object, e As EventArgs) Handles btnaTose.Click
        Dim intSideUp As Integer    ' To indicate which side is up
        Dim rand As New Random      ' Random number generator

        ' Get a random number in the ranfe of 0 through 1.
        ' 0 means tails up, and 1 means heads up.
        intSideUp = rand.Next(2)

        ' Display the side that is up.
        If intSideUp = 0 Then
            ' 0 means tails is up, so display the tails.
            ' Image and hide the heads image.
            picTails.Visible = True
            picHead.Visible = False
        Else
            ' 1 means heads is up, so display the heads.
            ' Image and hide the tails image.
            picHead.Visible = True
            picTails.Visible = False
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' CLoses the Form
        Me.Close()
    End Sub


End Class
