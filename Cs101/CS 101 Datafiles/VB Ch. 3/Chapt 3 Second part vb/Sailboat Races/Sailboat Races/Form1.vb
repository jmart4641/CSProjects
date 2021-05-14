' Name: Jose R. Martinez Perez
' Date: 11/12/2020
' Purpose: To calculate (add)the total points for each boat. The result will be displayed in the designated lblBoatTotal label. 
' Input: Scores of each boat for four races. Users input the finishing position for each of three boats for 4 races. 
'        Input Race 1, 2, 3, And 4  For boat # 1,2,3.
' Processing: Add Race 1 throught Race 4 to get the the total scoring for each Boat.
'             The results will be displayed in the lblBoat#Total label assigned For Each boat.
' Output: Display the total Scoring points for each boat. Results are displayed in the in the total column.
Public Class Form1
    Private Sub btnCalculateTotal_Click(sender As Object, e As EventArgs) Handles btnCalculateTotal.Click
        ' Step 0 - Declare variables.
        ' Local Level variable to hold Boat's scoring 1,2 0r 3.
        Dim intBoat1R1 As Integer
        Dim intBoat1R2 As Integer
        Dim intBoat1R3 As Integer
        Dim intBoat1R4 As Integer

        ' Variable for Boat 2
        Dim intBoat2R1 As Integer
        Dim intBoat2R2 As Integer
        Dim intBoat2R3 As Integer
        Dim intBoat2R4 As Integer

        ' Variables for Boat # 3
        Dim intBoat3R1 As Integer
        Dim intBoat3R2 As Integer
        Dim intBoat3R3 As Integer
        Dim intBoat3R4 As Integer

        ' Variables for the Total score for each boat.
        Dim intBoat1Total As Integer
        Dim intBoat2Total As Integer
        Dim intBoat3Total As Integer
        Try
            ' Step 1 - Input
            ' Syntax:
            '       intVairbale = CInt(txtControl.Text)
            '       dblVAriable = CDbl(txtControl.Text)
            '       decVariable = CDec(txtControl.Text)

            ' Get the point that each boat receives.
            ' Converts txtClass to Integer.
            intBoat1R1 = CInt(txtBoat1R1.Text)
            intBoat1R2 = CInt(txtBoat1R2.Text)
            intBoat1R3 = CInt(txtBoat1R3.Text)
            intBoat1R4 = CInt(txtBoat1R4.Text)
            intBoat2R1 = CInt(txtBoat2R1.Text)
            intBoat2R2 = CInt(txtBoat2R2.Text)
            intBoat2R3 = CInt(txtBoat2R3.Text)
            intBoat2R4 = CInt(txtBoat2R4.Text)
            intBoat3R1 = CInt(txtBoat3R1.Text)
            intBoat3R2 = CInt(txtBoat3R2.Text)
            intBoat3R3 = CInt(txtBoat3R3.Text)
            intBoat3R4 = CInt(txtBoat3R4.Text)

            ' Step 2 - Processing
            ' Syntax:
            '       variable = expression
            ' Calculate(Multiply) the Amount of tickets sold by Each Class Price.
            intBoat1Total = intBoat1R1 + intBoat1R2 + intBoat1R3 + intBoat1R4
            intBoat2Total = intBoat2R1 + intBoat2R2 + intBoat2R3 + intBoat2R4
            intBoat3Total = intBoat3R1 + intBoat3R2 + intBoat3R3 + intBoat3R4

            ' Step 3 - Output
            ' Syntax:
            '       lblControl.Text = numericVariable.ToString()
            ' Display the total scoring in each label box in the corresponding label.
            lblBoat1Total.Text = intBoat1Total.ToString("D")
            lblBoat2Total.Text = intBoat2Total.ToString("D")
            lblBoat3Total.Text = intBoat3Total.ToString("D")

        Catch ex As InvalidCastException
            ' Display an Error Message.
            lblStatusError.Text = "Error Be sure to enter Valid Numeric Values"
        End Try

    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the textbox forms.
        txtBoat1R1.Clear()
        txtBoat1R2.Clear()
        txtBoat1R3.Clear()
        txtBoat1R4.Clear()
        txtBoat2R1.Clear()
        txtBoat2R2.Clear()
        txtBoat2R3.Clear()
        txtBoat2R4.Clear()
        txtBoat3R1.Clear()
        txtBoat3R2.Clear()
        txtBoat3R3.Clear()
        txtBoat3R4.Clear()

        ' Clear the labels forms.
        lblBoat1Total.Text = ""
        lblBoat2Total.Text = String.Empty
        lblBoat3Total.Text = String.Empty

        lblStatusError.Text = String.Empty

        ' Rest the focus to the first field.
        txtBoat1R1.Focus()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Closes the form.
        Me.Close()

    End Sub
End Class
