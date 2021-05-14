Public Class Form1
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        ' Clear status bar
        lblStatus.text = ""
        lstMonths.Sorted = True

        lstYears.Items.Add("2022")
        lstYears.Items.Insert(2, "2015")
        lstYears.Items.Remove("2022")

        If (lstMonths.SelectedIndex <> -1) Then
            If (lstYears.SelectedIndex <> -1) Then
                lblStatus.Text = lstMonths.SelectedItem.ToString() & " " & lstYears.ToString()
            Else
                lblstatus.text = "Please"
            End If
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Reset the List Boxes.
        lstMonths.SelectedIndex = -1
        lstYears.SelectedIndex = -1
    End Sub
End Class
