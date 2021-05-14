Public Class Form1
    Const dblNEW_RATE As Double = 0.089
    Const dblUSED_RATE As Double = 0.095
    Dim dblAnnualRate As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dblAnnualRate = dblNEW_RATE
        lblAnnualInterestRate.text = dblAnnualRate.ToString("P")
    End Sub
End Class
