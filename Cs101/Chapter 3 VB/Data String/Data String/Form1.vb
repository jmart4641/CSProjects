Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnShowDate_Click(sender As Object, e As EventArgs) Handles btnShowDate.Click
        'Step 0 - Declare Variables
        Dim strDayOfWeek As String
        Dim strMonth As String
        Dim StrDayOfMonth As String
        Dim strYear As String
        Dim strFullDate As String

        'Step 1 -Get the Input
        'Syntax:
        '   strVariable = txtControlName.Text
        '   intVariable = CInt(txtControlName.Text)
        '   dblVariable = CDbl(txtControlName.Text)
        '   decVariable = Cdec(txtControlName.Text)
        strDayOfWeek = txtDayOfWeek.Text
        strMonth = txtMonth.Text
        StrDayOfMonth = txtDayOfMonth.Text
        strYear = txtYear.Text


        'Step 2 -Processing
        'Syntax:
        '   Variable = expression 
        strFullDate = strDayOfWeek & "," &
            strMonth & " " &
            StrDayOfMonth & " " &
            StrDayOfMonth & "," &
            strYear

        'Step 3 =Display Output
        'Syntax:
        '   1. lblControlName.Text = strVariable
        '   2. lblControlName.Text = numVariable.ToString()
        '   3. lblControlName.Text =numVariable.ToString("C2')
        '   4.lblControlName.Text = numVariable.ToString ("N2)
        '("P2)

        lblFullDate.Text = Str.StarFullDate
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear TextBoxex
        txtDayOfWeek.Clear()
        txtMonth.Clear()

        'Clear
        lblFullDate.Text = ""
    End Sub
End Class
