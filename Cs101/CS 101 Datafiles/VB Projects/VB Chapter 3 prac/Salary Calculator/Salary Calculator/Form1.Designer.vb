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
        Me.txtAnualSalary = New System.Windows.Forms.TextBox()
        Me.txtPayPeriod = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Anual Salary"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pay Period"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(246, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Salary per Pay Period"
        '
        'lblSalary
        '
        Me.lblSalary.BackColor = System.Drawing.SystemColors.Info
        Me.lblSalary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSalary.Location = New System.Drawing.Point(334, 213)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(93, 37)
        Me.lblSalary.TabIndex = 3
        Me.lblSalary.Text = "$0.00"
        Me.lblSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAnualSalary
        '
        Me.txtAnualSalary.Location = New System.Drawing.Point(334, 53)
        Me.txtAnualSalary.Name = "txtAnualSalary"
        Me.txtAnualSalary.Size = New System.Drawing.Size(100, 35)
        Me.txtAnualSalary.TabIndex = 4
        '
        'txtPayPeriod
        '
        Me.txtPayPeriod.Location = New System.Drawing.Point(334, 140)
        Me.txtPayPeriod.Name = "txtPayPeriod"
        Me.txtPayPeriod.Size = New System.Drawing.Size(100, 35)
        Me.txtPayPeriod.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(189, 304)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(128, 40)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 354)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtPayPeriod)
        Me.Controls.Add(Me.txtAnualSalary)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents txtAnualSalary As TextBox
    Friend WithEvents txtPayPeriod As TextBox
    Friend WithEvents btnCalculate As Button
End Class
