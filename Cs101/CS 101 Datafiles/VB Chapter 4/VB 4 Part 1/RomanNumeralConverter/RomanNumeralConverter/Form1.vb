Option Strict On

' **********************************************************************************************************************************************************
' Name: Jose R. Martinez Perez
' Date: 11/30/2020
' Purpose: To Create an application that allows the user to enter an integer between 1 and 10 into the text box. The main purpose is to identify
'          which Roman Numeral is the correct translation of the integer.
' Input: The user enters an integer between 1 and 10. It must be a numeric value, and needs to be between 1 and 10. Otherwise, there will 
'         an error message display on the label.
' Processing:  Select Case statement(Similar to If..Then..ElseIf st) is used to test the value of an expression once which in this case the expression
'              (CInt(txtIntegerRange.Text) expression is tested. The Case 1, Case 2, Case 3, Case 4, Case 5, Case 6, Case 7, Case 8, Case 9, and Case 10
'              mark where the program is to branch to if the test expression is equals to values 1, 2, 3, 4, 5, 6, 7, 8, 9, and 10. After a value in a 
'              expression list matches the value of the test expresion, the strrResult statement ss executed and is displayed in label lblResult.
' Output: Displays a Roman numeral from I(1) and V(10) in the label lbl results(Equivalent Roman Numeral).
'*************************************************************************************************************************************************************************
Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        ' Step 0 - Declare the variables
        Dim strResult As String = ""

        ' Step 2
        ' Determine the Roman Numerals.
        Try
            Select Case CInt(txtIntergerRange.Text)
                Case 1
                    strResult = "I"
                Case 2
                    strResult = "II"
                Case 3
                    strResult = "III"
                Case 4
                    strResult = "IV"
                Case 5
                    strResult = "V"
                Case 6
                    strResult = "VI"
                Case 7
                    strResult = "VII"
                Case 8
                    strResult = "VIII"
                Case 9
                    strResult = "IX"
                Case = 10
                    strResult = "X"
                Case Else
                    ' Display an Error message alert to enter integers between 1 to 10 only.
                    strResult = "Invalid Input"
            End Select

            ' Step 3 - Output
            ' Display the Roman numerals that is the correct translation of the integer.
            lblResult.Text = strResult

        Catch
            ' Display an error message alerting the user invalid input
            MessageBox.Show("Error: Please enter a Numeric Value.")
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the form.
        Me.Close()
    End Sub
End Class
