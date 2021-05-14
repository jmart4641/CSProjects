Option Strict On
'*********************************************************************************************************************************
' Name: Jose R. Martinez Perez
' Date: 11/12/2020, 11/29/2020, 11/30/2020
' Purpose: To calculate (add)the total points for each boat. The result will be displayed in the designated lblBoatTotal label. 
' Input: Scores of each boat for four races. Users input the finishing position for each of three boats for 4 races. 
'        Input Race 1, 2, 3, And 4  For boat # 1,2,3.
' Processing: Add Race 1 throught Race 4 to get the the total scoring for each Boat.
'             The results will be displayed in the lblBoat#Total label assigned For Each boat.
' Output: Display the total Scoring points for each boat. Results are displayed in the in the total column.
'*************************************************************************************************************************************
Public Class Form1
    Private Sub btnCalculateTotal_Click(sender As Object, e As EventArgs) Handles btnCalculateTotal.Click
        ' Step 0 - Declare the variables
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
        ' Dim blnInput As Boolean = False


        ' Variables for the Total score for each boat.
        Dim intBoat1Total As Integer
        Dim intBoat2Total As Integer
        Dim intBoat3Total As Integer

        Dim strB1Total As String = ""
        Dim strB2Total As String = ""
        Dim strB3Total As String = ""

        Try
            lblStatusError.Text = String.Empty
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
            ' Verify if the sum of every Column is equal to 6
            If (intBoat1R1 + intBoat2R1 + intBoat3R1) <> 6 Then
                lblStatusError.Text = "Enter 1, 2, and 3 ony for Race 1."

            ElseIf (intBoat1R2 + intBoat2R2 + intBoat3R2) <> 6 Then
                lblStatusError.Text = "Enter 1, 2, and 3 ony for Race 2."

            ElseIf (intBoat1R3 + intBoat2R3 + intBoat3R3) <> 6 Then
                lblStatusError.Text = "Enter 1, 2, and 3 ony for Race 3."

            ElseIf (intBoat1R4 + intBoat2R4 + intBoat3R4) <> 6 Then
                lblStatusError.Text = "Enter 1, 2, and 3 ony for Race 4."
            Else
                ' Step 2- Processing
                ' Calculate Tota for Boat 1.
                intBoat1Total = intBoat1R1 + intBoat1R2 + intBoat1R3 + intBoat1R4

                If intBoat1Total > 0 Then
                    strB1Total = intBoat1Total.ToString("N0")
                End If

                ' Calculate the total for all races for boat 2.
                intBoat2Total = intBoat2R1 + intBoat2R2 + intBoat2R3 + intBoat2R4

                If intBoat2Total > 0 Then
                    strB2Total = intBoat2Total.ToString("N0")
                End If

                ' Calculate the total for all races for boat 3.
                intBoat3Total = intBoat3R1 + intBoat3R2 + intBoat3R3 + intBoat3R4

                If intBoat3Total > 0 Then
                    strB3Total = intBoat3Total.ToString("N0")
                End If

                'Step 3 - Output 
                ' Syntax:
                '       lblControl.Text = numericVariable.ToString()
                ' Display the total scoring in each label box in the corresponding label.
                lblBoat1Total.Text = strB1Total
                lblBoat2Total.Text = strB2Total
                lblBoat3Total.Text = strB3Total

                ' Determine the Ranks
                If intBoat1Total > intBoat2Total Then
                    If intBoat2Total > intBoat3Total Then
                        lblRank1.Text = "1"
                        lblRank2.Text = "2"
                        lblRank3.Text = "3"
                    Else
                        lblRank1.Text = "1"
                        lblRank2.Text = "3"
                        lblRank3.Text = "2"
                    End If

                ElseIf intBoat2Total > intBoat1Total Then
                    If intBoat3Total < intBoat1Total Then
                        lblRank1.Text = "2"
                        lblRank2.Text = "1"
                        lblRank3.Text = "3"
                    Else
                        lblRank1.Text = "2"
                        lblRank2.Text = "3"
                        lblRank3.Text = "1"
                    End If

                ElseIf intBoat1Total < intBoat3Total Then
                    If intBoat2Total > intBoat3Total Then
                        lblRank1.Text = "3"
                        lblRank2.Text = "1"
                        lblRank3.Text = "2"
                    Else
                        lblRank1.Text = "3"
                        lblRank2.Text = "2"
                        lblRank3.Text = "1"
                    End If

                Else
                    ' Display Red background if equal.
                    If intBoat1Total = intBoat2Total Then
                        If intBoat2Total = intBoat3Total Then
                            If intBoat1Total = intBoat3Total Then
                                lblRank1.BackColor = Color.Red
                                lblRank2.BackColor = Color.Red
                                lblRank3.BackColor = Color.Red
                                lblBoat1Total.ForeColor = Color.Red
                                lblBoat2Total.ForeColor = Color.Red
                                lblBoat3Total.ForeColor = Color.Red
                                lblStatusError.Text = "TIE"
                            End If
                        End If
                    End If
                End If

            End If
        Catch
            ' Display an error message
            lblStatusError.Text = "Please enter Integers only."
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

        ' Clear Status bar.
        lblStatusError.Text = String.Empty

        ' Clear text for Rank Labels
        lblRank1.Text = String.Empty
        lblRank2.Text = String.Empty
        lblRank3.Text = String.Empty

        ' Clear Back Color for Ranks
        lblRank1.BackColor = Color.Empty
        lblRank2.BackColor = Color.Empty
        lblRank3.BackColor = Color.Empty

        'Clear font colors for Total Labels
        lblBoat1Total.ForeColor = Color.Empty
        lblBoat2Total.ForeColor = Color.Empty
        lblBoat3Total.ForeColor = Color.Empty

        ' Rest the focus to the first field.
        txtBoat1R1.Focus()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Closes the form.
        Me.Close()
    End Sub
End Class
