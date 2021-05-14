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
        ' Declared the variables
        Dim intBt1R1 As Integer
        Dim intBt1R2 As Integer
        Dim intBt1R3 As Integer
        Dim intBt1R4 As Integer
        Dim intB1Total As Integer

        Dim strRank1 As String = ""
        Dim strRank2 As String = ""
        Dim strRank3 As String = ""
        Dim blninput = False

        Dim intBt2R1 As Integer
        Dim intBt2R2 As Integer
        Dim intBt2R3 As Integer
        Dim intBt2R4 As Integer
        Dim intB2Total As Integer

        Dim intBt3R1 As Integer
        Dim intBt3R2 As Integer
        Dim intBt3R3 As Integer
        Dim intBt3R4 As Integer
        Dim IntB3Total As Integer

        Dim intRace1 As Integer
        Dim intRace2 As Integer
        Dim intRace3 As Integer
        Dim intRace4 As Integer

        Dim Race1 As Integer
        Dim Race2 As Integer
        Dim Race3 As Integer
        Dim Race4 As Integer 




        Try

            lblStatusError.Text = String.Empty

            ' Step 1 - Input
            ' Convert Values into integers
            intBt1R1 = CInt(txtBoat1R1.Text)
            intBt1R2 = CInt(txtBoat1R2.Text)
            intBt1R3 = CInt(txtBoat1R3.Text)
            intBt1R4 = CInt(txtBoat1R4.Text)

            intBt2R1 = CInt(txtBoat2R1.Text)
            intBt2R2 = CInt(txtBoat2R2.Text)
            intBt2R3 = CInt(txtBoat2R3.Text)
            intBt2R4 = CInt(txtBoat2R4.Text)

            intBt3R1 = CInt(txtBoat3R1.Text)
            intBt3R2 = CInt(txtBoat3R2.Text)
            intBt3R3 = CInt(txtBoat3R3.Text)
            intBt3R4 = CInt(txtBoat3R4.Text)

            ' Step 2 - Processing
            intRace1 = intBt1R1 + intBt2R1 + intBt3R1
            intRace2 = intBt1R2 + intBt2R2 + intBt3R2
            intRace3 = intBt1R3 + intBt2R3 + intBt3R3
            intRace4 = intBt1R4 + intBt2R4 + intBt3R4



            If intRace1 <> 6 Then
                lblStatusError.Text = "Enter1, 2 and 3 only for Race 1."
            ElseIf intRace2 <> 6 Then
                lblStatusError.Text = "Enter 1, 2 and 3 only for Race 2"
            ElseIf intRace3 <> 6 Then
                lblStatusError.Text = "Enter 1, 2 and 3 only for Race 3"
            ElseIf intRace4 <> 6 Then
                lblStatusError.Text = "Enter 1, 2 and 3 only for Race 4"
            Else
                intB1Total = intBt1R1 + intBt1R2 + intBt1R3 + intBt1R4
                intB2Total = intBt2R1 + intBt2R2 + intBt2R3 + intBt2R4
                IntB3Total = intBt3R1 + intBt3R2 + intBt3R3 + intBt3R4
                If intB1Total >
                    lblBoat1Total.Text = intB1Total.ToString("N0")
                    lblBoat2Total.Text = intB2Total.ToString("N0")
                    lblBoat3Total.Text = IntB3Total.ToString("N0")
                End If

            End If



            If intB1Total > intB2Total Then
                If intB2Total > IntB3Total Then
                    strRank1 = "1"
                    strRank2 = "2"
                    strRank3 = "3"
                Else
                    strRank1 = "1"
                    strRank2 = "3"
                    strRank3 = "2"
                End If
            ElseIf intB2Total > intB1Total Then
                If intB1Total > IntB3Total Then
                    strRank1 = "2"
                    strRank2 = "1"
                    strRank3 = "3"
                Else
                    strRank1 = "2"
                    strRank2 = "3"
                    strRank3 = "1"
                End If
            ElseIf intB2Total > intB3Total Then
                If IntB3Total > intB1Total Then
                    strRank1 = "3"
                    strRank2 = "1"
                    strRank3 = "2"
                Else
                    strRank1 = "3"
                    strRank2 = "2"
                    strRank3 = "1"
                End If
            End If



            ' Step 3 - Output

            ' lblStatusError.Text = "TIE"
            'lblRank1.BackColor = Color.Red
            'lblRank2.BackColor = Color.Red
            ' lblRank3.BackColor = Color.Red






            lblRank1.Text = strRank1
            lblRank2.Text = strRank2
            lblRank3.Text = strRank3



        Catch
            MessageBox.Show("Input Integers")
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear TextBoxes
        txtBoat1R1.Clear()
        txtBoat1R2.Clear()
        txtBoat1R3.Clear()
        txtBoat1R4.Clear()

        'clear textBoxes for boat 2.
        txtBoat2R1.Clear()
        txtBoat2R2.Clear()
        txtBoat2R3.Clear()
        txtBoat2R4.Clear()

        ' Clear textboxes for boat 3
        txtBoat3R1.Clear()
        txtBoat3R2.Clear()
        txtBoat3R3.Clear()
        txtBoat3R4.Clear()

        ' Clear labels for total Boat 1, 2, and 3.
        lblBoat1Total.Text = String.Empty
        lblBoat2Total.Text = String.Empty
        lblBoat3Total.Text = String.Empty

        ' Clear Ranks
        lblRank1.Text = String.Empty
        lblRank2.Text = String.Empty
        lblRank3.Text = String.Empty

        ' Clear background
        lblRank1.BackColor = Color.Empty
        lblRank2.BackColor = Color.Empty
        lblRank3.BackColor = Color.Empty

        lblStatusError.Text = String.Empty

    End Sub
End Class