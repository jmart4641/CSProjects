﻿Option Strict On
'*****************************************************************************************************************************************************
' Name: Jose R. Martinez
' Date: 11/30/2020
' Purpose: To Calculate weekly PPC revenue and to display an error message if a field if nonNumeric.
' Input: There are 5 different types of input: Advertising Cost per week, Number of Ad Clicks during the past 4 Weekly Period.
' Processing: Pay Per Click(PPC) is calculated by dividing the cost of advertising by the number of times users click on an advertisement.
'                Double.TryParse() and Integer.TryParse() for input Validation for week textBox.
' Output: The total revenue is displayed in their correspoing Labels, there are 4 labels in total. Each Week's total revenue have a Label assign to.
'*******************************************************************************************************************************************************
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Step 0 - Declare Variables
        Dim dblCostPerWeek As Double
        Dim intNumOfClicks1 As Integer
        Dim intNumbOfClick2 As Integer
        Dim intNumOfClick3 As Integer
        Dim intNumOfClick4 As Integer

        Dim dblRevenue1 As Double
        Dim dblRevenue2 As Double
        Dim dblRevenue3 As Double
        Dim dblRevenue4 As Double

        ' Step 1 - Input
        lblStatusError.Text = String.Empty

        'Input Validation for Advertising cost per week.
        If Not Double.TryParse(txtAdvCostPerWeek.Text, dblCostPerWeek) Then
            lblStatusError.Text = "Must be a Numeric Value"
        End If

        ' Test input Validation for Week 1, and only Positives numbers will be accepted.
        If Integer.TryParse(txtNumAdsClick1.Text, intNumOfClicks1) Then
            If intNumOfClicks1 > 0 Then
                'Step 2 - Processing
                ' Mathematical Calculation is executed.
                dblRevenue1 = dblCostPerWeek / intNumOfClicks1

                ' Display Revenue
                lblRevenue1.Text = dblRevenue1.ToString("N")
            Else
                lblStatusError.Text = "PPC for Week 1 a positive number"
            End If
        Else
            lblStatusError.Text = "PPC for Week 1 needs to be an integer"
        End If


        ' Input Validation for Week 2
        If Integer.TryParse(txtNumAdsClick2.Text, intNumbOfClick2) Then
            If intNumbOfClick2 > 0 Then
                'Step 2 - Processing
                ' Mathematical Calculation is executed.
                dblRevenue2 = dblCostPerWeek / intNumbOfClick2
                ' Display output for Week 2
                lblRevenue2.Text = dblRevenue2.ToString("N")
            Else
                    lblStatusError.Text = "Week 2 Must be a positive number"
            End If
        Else
            lblStatusError.Text = "PPC for Week 2 needs to be an integer"
        End If


        ' Input Validation for week 3.
        If Integer.TryParse(txtNumAdsCLick3.Text, intNumOfClick3) Then
            If intNumOfClick3 > 0 Then
                'Step 2 - Processing
                ' Mathematical Calculation is executed.
                dblRevenue3 = dblCostPerWeek / intNumOfClick3
                lblRevenue3.Text = dblRevenue3.ToString("N")
            Else
                lblStatusError.Text = "Enter Positive number for Week 3"
            End If
        Else
            lblStatusError.Text = "PPC for Week 3 needs to be an integer"
        End If

        ' Input Validation for Week 4.
        If Integer.TryParse(txtNumAdsClick4.Text, intNumOfClick4) Then
            If intNumOfClick4 > 0 Then
                'Step 2 - Processing
                ' Mathematical Calculation is executed.
                dblRevenue4 = dblCostPerWeek / intNumOfClick4

                ' Step 3 - Output
                ' Assing and Display Revenues for each week.
                lblRevenue4.Text = dblRevenue4.ToString("N")
            Else
                lblStatusError.Text = "Enter Positive number for Week 4"
            End If
        Else
            lblStatusError.Text = "PPC for Week must be an integer"
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Clear TextBoxes
        txtAdvCostPerWeek.Clear()
        txtNumAdsClick1.Clear()
        txtNumAdsClick2.Clear()
        txtNumAdsCLick3.Clear()
        txtNumAdsClick4.Clear()

        ' Clear Labels
        lblRevenue1.Text = String.Empty
        lblRevenue2.Text = String.Empty
        lblRevenue3.Text = String.Empty
        lblRevenue4.Text = String.Empty

        ' Reset Focus
        txtAdvCostPerWeek.Focus()

        ' Select All
        txtAdvCostPerWeek.SelectAll()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Closes the form
        Me.Close()
    End Sub
End Class
