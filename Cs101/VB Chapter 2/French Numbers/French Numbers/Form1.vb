Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        'Display the French Word for one.
        MessageBox.Show("un")
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        'Dispay the French word for two.
        MessageBox.Show("deux")
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        'Display the French word for three.
        MessageBox.Show("trois")
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        'Display the French word for four.
        MessageBox.Show("quatre")
    End Sub

    Private Sub btnFIve_Click(sender As Object, e As EventArgs) Handles btnFIve.Click
        'Displays the French word for five.
        lblStatus.Text = ("cinq")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Close the form
        Me.Close()
    End Sub

    Private Sub lblStatus_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Status.ItemClicked

    End Sub
End Class
