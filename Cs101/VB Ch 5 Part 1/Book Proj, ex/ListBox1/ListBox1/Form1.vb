Public Class Form1
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        ' Step 0 - Declare Variables
        Dim strInput As String  ' Holds selected month and year

        If (lstMonths.SelectedIndex = -1) Then
            ' No Month is Selected
            MessageBox.Show("Select a Month.")
        ElseIf lstYears.SelectedIndex = -1 Then
            ' No year is selected
            MessageBox.Show("Select a Year.")
        Else
            ' Get the Selected Month and Year
            strInput = lstMonths.SelectedItem.ToString() &
                     " " & lstYears.SelectedItem.ToString()
            MessageBox.Show("You have selected " & strInput)
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Reset the List Boxes.
        lstMonths.SelectedIndex = -1
        lstYears.SelectedIndex = -1
    End Sub
End Class
