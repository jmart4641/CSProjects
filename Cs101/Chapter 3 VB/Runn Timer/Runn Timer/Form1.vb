Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intRunner1Time As Integer
        Dim intRunner2Time As Integer
        Dim intRunner3Time As Integer
        Dim dblAverage As Double

        Try 'Input Runner 1 Time
            intRunner1Time = CInt(txtRunner1.Text)
            Try ' Input Runner 2 Time 
                intRunner2Time = CInt(txtRunner2.Text)
                Try ' Input runner 3 Time
                    intRunner3Time = CInt(txtRunner3.Text)
                    'Step 2 - Processing
                    dblAverage = (intRunner1Time + intRunner2Time + intRunner3Time) / 3

                    ' Step 3 - Output
                    lblAverage.Text = dblAverage.ToString("N")

                Catch ex As Exception

                End Try
            Catch ex As Exception
                MessageBox.Show("Enter number ontly for Runner 3 Time.")
                txtRunner3.Focus()
                txtRunner3.selectAll()
            End Try
        Catch ex As Exception

        End Try
    End Sub
End Class
