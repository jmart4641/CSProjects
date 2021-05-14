Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnShowBack_Click(sender As Object, e As EventArgs) Handles btnShowBack.Click
        'Make the image of the back of the card visible.
        picCardBack.Visible = True
        'Make the image of the face of the card invisible.
        picCardFace.Visible = False
    End Sub

    Private Sub btnShowFace_Click(sender As Object, e As EventArgs) Handles btnShowFace.Click
        picCardBack.Visible = False
        picCardFace.Visible = True
    End Sub

    Private Sub picCardFace_Click(sender As Object, e As EventArgs) Handles picCardFace.Click

    End Sub
End Class
