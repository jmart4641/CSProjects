' **************************************************************************************
' Author: Solution (Date String)
' Date: 10/31/2019
' Purpose: Combine strings and string literals to display the Full Date.
' Input: Day of Week, Month, Day of Month, and Year.
' Processing: Using the concatenation (&) operator, combine the inputed strings and
'             string literals to produce the full date.
' Output: Display the full date.
' **************************************************************************************
Public Class Form1
    Private Sub btnShowDate_Click(sender As Object, e As EventArgs) Handles btnShowDate.Click
        ' Step 0 - Declare Variables
        ' Syntax:
        '    Dim strVar As String
        '    Dim intVar As Integer
        '    Dim dblVar As Double
        '    Dim decVar As Decimal
        Dim strYear As String
        Dim strMonth As String
        Dim strDayOfMonth As String
        Dim strDayOfWeek As String
        Dim strDate As String

        ' Step 1 - Input
        ' Syntax:
        '    strVar = txtControl.Text
        '    intVar = CInt(txtControl.Text)
        '    dblVar = CDbl(txtControl.Text)
        '    decVar = CDec(txtControl.Text)
        strYear = txtYear.Text
        strMonth = txtMonth.Text
        strDayOfMonth = txtDayOfMonth.Text
        strDayOfWeek = txtDayOfWeek.Text

        ' Step 2 - Processing
        ' Syntax:
        '    variable = expression
        strDate = strDayOfWeek & ", " & strMonth & " " &
            strDayOfMonth & ", " & strYear

        ' Step 3 - Output
        ' Syntax:
        '    lblControl.Text = strVariable
        '    lblControl.Text = numVariable.ToString()
        '    lblControl.Text = numVariable.ToString()
        '    lblControl.Text = numVariable.ToString("P0")
        ' Refer to tables 3-14 thru 3-18 for more format
        ' specifiers on pages 161 thru 163 of the textbook.
        lblDate.Text = strDate
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear TextBoxes
        txtYear.Clear()
        txtMonth.Clear()
        txtDayOfMonth.Clear()
        txtDayOfWeek.Clear()

        ' Clear Labels
        lblDate.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
