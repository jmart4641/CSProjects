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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMonths = New System.Windows.Forms.TextBox()
        Me.txtDownPayment = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.radNew = New System.Windows.Forms.RadioButton()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radUsed = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblAnnualRate = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtMonths)
        Me.GroupBox1.Controls.Add(Me.txtDownPayment)
        Me.GroupBox1.Controls.Add(Me.txtCost)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(53, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 186)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vehicle && Loan Information"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Number of Months:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Amount of Down Payment:"
        '
        'txtMonths
        '
        Me.txtMonths.Location = New System.Drawing.Point(203, 127)
        Me.txtMonths.Name = "txtMonths"
        Me.txtMonths.Size = New System.Drawing.Size(137, 26)
        Me.txtMonths.TabIndex = 4
        '
        'txtDownPayment
        '
        Me.txtDownPayment.Location = New System.Drawing.Point(203, 80)
        Me.txtDownPayment.Name = "txtDownPayment"
        Me.txtDownPayment.Size = New System.Drawing.Size(137, 26)
        Me.txtDownPayment.TabIndex = 3
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(203, 39)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(137, 26)
        Me.txtCost.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cost of Vehicle:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(91, 607)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(120, 27)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'radNew
        '
        Me.radNew.AutoSize = True
        Me.radNew.Location = New System.Drawing.Point(30, 49)
        Me.radNew.Name = "radNew"
        Me.radNew.Size = New System.Drawing.Size(65, 24)
        Me.radNew.TabIndex = 3
        Me.radNew.TabStop = True
        Me.radNew.Text = "&New"
        Me.radNew.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 20
        Me.lstOutput.Location = New System.Drawing.Point(10, 71)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(484, 224)
        Me.lstOutput.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radUsed)
        Me.GroupBox3.Controls.Add(Me.radNew)
        Me.GroupBox3.Location = New System.Drawing.Point(432, 45)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(131, 176)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "New or Used?"
        '
        'radUsed
        '
        Me.radUsed.AutoSize = True
        Me.radUsed.Location = New System.Drawing.Point(30, 96)
        Me.radUsed.Name = "radUsed"
        Me.radUsed.Size = New System.Drawing.Size(63, 24)
        Me.radUsed.TabIndex = 4
        Me.radUsed.TabStop = True
        Me.radUsed.Text = "&Use"
        Me.radUsed.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblAnnualRate)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.lstOutput)
        Me.GroupBox4.Location = New System.Drawing.Point(53, 268)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(510, 319)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Interest and Principal Payments"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(199, 42)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(161, 20)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Annual Interest Rate:"
        '
        'lblAnnualRate
        '
        Me.lblAnnualRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnnualRate.Location = New System.Drawing.Point(366, 42)
        Me.lblAnnualRate.Name = "lblAnnualRate"
        Me.lblAnnualRate.Size = New System.Drawing.Size(78, 20)
        Me.lblAnnualRate.TabIndex = 5
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(256, 607)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 27)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(407, 607)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 27)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(53, 235)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(510, 30)
        Me.lblMessage.TabIndex = 6
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 669)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Loan Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMonths As TextBox
    Friend WithEvents txtDownPayment As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents radNew As RadioButton
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents radUsed As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents lblAnnualRate As Label
    Public WithEvents btnCalculate As Button
    Public WithEvents btnClear As Button
    Public WithEvents btnExit As Button
    Friend WithEvents lblMessage As Label
End Class
