<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.txtAnnualSalary = New System.Windows.Forms.TextBox()
        Me.txtPayPeriods = New System.Windows.Forms.TextBox()
        Me.btnCalculateSalary = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(130, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Annual salary:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pay periods per year:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Salary per pay period:"
        '
        'lblSalary
        '
        Me.lblSalary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSalary.Location = New System.Drawing.Point(250, 185)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(127, 31)
        Me.lblSalary.TabIndex = 2
        '
        'txtAnnualSalary
        '
        Me.txtAnnualSalary.Location = New System.Drawing.Point(250, 75)
        Me.txtAnnualSalary.Name = "txtAnnualSalary"
        Me.txtAnnualSalary.Size = New System.Drawing.Size(127, 26)
        Me.txtAnnualSalary.TabIndex = 0
        '
        'txtPayPeriods
        '
        Me.txtPayPeriods.Location = New System.Drawing.Point(250, 130)
        Me.txtPayPeriods.Name = "txtPayPeriods"
        Me.txtPayPeriods.Size = New System.Drawing.Size(127, 26)
        Me.txtPayPeriods.TabIndex = 1
        '
        'btnCalculateSalary
        '
        Me.btnCalculateSalary.Location = New System.Drawing.Point(194, 259)
        Me.btnCalculateSalary.Name = "btnCalculateSalary"
        Me.btnCalculateSalary.Size = New System.Drawing.Size(112, 33)
        Me.btnCalculateSalary.TabIndex = 3
        Me.btnCalculateSalary.Text = "Calculate"
        Me.btnCalculateSalary.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 336)
        Me.Controls.Add(Me.btnCalculateSalary)
        Me.Controls.Add(Me.txtPayPeriods)
        Me.Controls.Add(Me.txtAnnualSalary)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Salary Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents txtAnnualSalary As TextBox
    Friend WithEvents txtPayPeriods As TextBox
    Friend WithEvents btnCalculateSalary As Button
End Class
