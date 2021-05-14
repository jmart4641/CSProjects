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
        Me.txtPropertyValue = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAssessmentValue = New System.Windows.Forms.Label()
        Me.lblPropertyTax = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Actual Property Value:"
        '
        'txtPropertyValue
        '
        Me.txtPropertyValue.Location = New System.Drawing.Point(232, 58)
        Me.txtPropertyValue.Name = "txtPropertyValue"
        Me.txtPropertyValue.Size = New System.Drawing.Size(138, 26)
        Me.txtPropertyValue.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Assessment Value:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(114, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Property Tax:"
        '
        'lblAssessmentValue
        '
        Me.lblAssessmentValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAssessmentValue.Location = New System.Drawing.Point(232, 115)
        Me.lblAssessmentValue.Name = "lblAssessmentValue"
        Me.lblAssessmentValue.Size = New System.Drawing.Size(138, 31)
        Me.lblAssessmentValue.TabIndex = 4
        '
        'lblPropertyTax
        '
        Me.lblPropertyTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPropertyTax.Location = New System.Drawing.Point(232, 168)
        Me.lblPropertyTax.Name = "lblPropertyTax"
        Me.lblPropertyTax.Size = New System.Drawing.Size(138, 31)
        Me.lblPropertyTax.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(23, 227)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(173, 53)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate Assessment and Tax"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(215, 227)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 53)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(327, 227)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(61, 53)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 297)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblPropertyTax)
        Me.Controls.Add(Me.lblAssessmentValue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPropertyValue)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Calculate Property Taxes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPropertyValue As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAssessmentValue As Label
    Friend WithEvents lblPropertyTax As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
