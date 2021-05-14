Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnShowDate_Click(sender As Object, e As EventArgs) Handles btnShowDate.Click
        'Step 0 - Declare Variables
        ' Dim strDayOfWeek As String
        'Dim strMonth As String
        'Dim strDayOfMonth As String
        'Dim strYear As String

        'step 1 - Get the Input
        'Syntax:
        '   strVariable = txtControlName.Text
        '   intVariable = CInt(txtControlName.Text)
        '   dblVariable = CDbl(txtControlName.Text)
        '   decVariable = CDec)txtControlName.Text)

        ' strDayOfWeek = txtDayOfWeek.Text
        'strMonth = txtMonth.Text
        'strDayOfMonth = txtDayOfMonth.Text
        'strYear = txtYear.Text

        'Step 2 - Processing
        'Syntax: 
        '       variable = expression
        lblDateString.Text = txtDayOfWeek.Text & ", " &
            txtMonth.Text & " " &
            txtDayOfMonth.Text & ", " &
            txtDayOfMonth.Text & ", " &
            txtYear.Text

        'Step 3 - Output
        'Syntax:
        '       lblControlName.Text = numericVariable.ToString()
        '       lblControlName.Text = numericVariable.ToString("Cn)
        '       lblControlName.Text = numericVariable.ToString("Pn")
        'Concatenate the input and build the date string.
        'lblDateString.Text = lblDateString.ToString()



    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the Text Boxes and lblDateString.
        txtDayOfWeek.Clear()
        txtMonth.Clear()
        txtDayOfMonth.Clear()
        txtYear.Clear()
        lblDateString.Text = String.Empty

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes Form
        Me.Close()
    End Sub
End Class
