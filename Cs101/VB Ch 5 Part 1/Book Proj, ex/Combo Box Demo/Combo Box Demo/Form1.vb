Public Class Form1
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        ' Display the combo box selection
        lblCountry.Text = cboCountries.Text
        lblPlay.Text = CboPlays.Text
        lblArtist.Text = cboArtists.Text
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Reset he combo box.
        cboCountries.SelectedIndex = -1
        cboCountries.Text = String.Empty
        CboPlays.SelectedIndex = -1
        CboPlays.Text = String.Empty
        cboArtists.SelectedIndex = -1
        cboArtists.Text = String.Empty
        ' Note: cboArtists.Text is read-only

        ' Reset the labels.
        lblCountry.Text = String.Empty
        lblPlay.Text = String.Empty
        lblArtist.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the form
        Me.Close()
    End Sub
End Class
