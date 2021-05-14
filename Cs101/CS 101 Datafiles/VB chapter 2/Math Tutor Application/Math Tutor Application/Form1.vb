'**************************************************************************************************************************************************
'Name: Jose Martinez Perez
'Date: October 28, 2020
'Purpose: The Purpose of this application/Code is to diplay a simple math problem in lblAnswer label and have a button that closes the application.
'Input: None
'Processing: Change the Visible Property of lblShowAnswer to False to hide the corresponding Answer and assing true to lblAnswer.visible to show.
'Output: Shows Answer of a simple math problem in lblAnswer control when the Show Answer button is clicked.
'**************************************************************************************************************************************************
Public Class Form1
    Private Sub btnShowAnswer_Click(sender As Object, e As EventArgs) Handles btnShowAnswer.Click
        'Since the value is set to true, This Makes the Number Visible in the control label.
        lblShowAnswer.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Closes the application when the Exit botton is click.
        Me.Close()
    End Sub
End Class
