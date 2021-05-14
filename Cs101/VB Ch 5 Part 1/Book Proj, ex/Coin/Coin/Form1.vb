Public Class Form1
    Const intHEAD As Integer = 0
    Const intTAIL As Integer = 1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim rand As New Random()
        Dim intToss As Integer

        ' The system clock is been used as a seed.
        intToss = rand.Next(2)
        If (intToss = intHEAD) Then
            picHead.Visible = True
            picTail.Visible = False
        Else
            piHead.Visisble = False
            picTail.Visible = True
        End If
    End Sub
End Class
