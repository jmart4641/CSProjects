Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim monthsIdx, yearIdx As Integer
        '
        monthsIdx = lstMonths.SelectedIndex
        yearIdx = lstYear.SelectedIndex

        lblStatus.Text = lstMonths.Items(monthsIdx).ToString() & "" & lstYear.Items(yearIdx).ToString()     ' Also lstMonth.selectedItem.Tostring() & " " & lstYear.SelectedItem.ToString() (an If statement must be used if this is used)

    End Sub
End Class
