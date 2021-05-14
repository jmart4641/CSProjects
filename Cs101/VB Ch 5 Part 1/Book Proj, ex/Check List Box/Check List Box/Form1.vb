Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnChecked.Click
        Dim intIndex As Integer         ' List box index
        Dim intCount As Integer = 0     ' To count the checked cities

        ' Specifying a step value. A negative number decrements the counter variable after each interation.
        For intIndex = 0 To clbCities.Items.Count - 1
            If (clbCities.GetItemChecked(intIndex)) Then
                lstCheckedCities.Items.Add(clbCities.Items.Item(intIndex))
                intCount += 1
            End If
        Next

        ' Display the number of checked cities. This can also be displayed in a message box.
        lstCheckedCities.Items.Add("")
        lstCheckedCities.Items.Add("Checked Cities:  " & intCount.ToString())
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        lstCheckedCities.Items.Clear()
    End Sub
End Class
