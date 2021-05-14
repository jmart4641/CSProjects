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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtYearOnJob = New System.Windows.Forms.TextBox()
        Me.txtAnnualSalary = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnCheckQualifications = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Annual salary:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtYearOnJob)
        Me.GroupBox1.Controls.Add(Me.txtAnnualSalary)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(401, 198)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter tge following information"
        '
        'txtYearOnJob
        '
        Me.txtYearOnJob.Location = New System.Drawing.Point(194, 120)
        Me.txtYearOnJob.Name = "txtYearOnJob"
        Me.txtYearOnJob.Size = New System.Drawing.Size(130, 26)
        Me.txtYearOnJob.TabIndex = 4
        '
        'txtAnnualSalary
        '
        Me.txtAnnualSalary.Location = New System.Drawing.Point(194, 53)
        Me.txtAnnualSalary.Name = "txtAnnualSalary"
        Me.txtAnnualSalary.Size = New System.Drawing.Size(130, 26)
        Me.txtAnnualSalary.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(43, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 52)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of years at your current job:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMessage
        '
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessage.Location = New System.Drawing.Point(35, 258)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(401, 32)
        Me.lblMessage.TabIndex = 2
        '
        'btnCheckQualifications
        '
        Me.btnCheckQualifications.Location = New System.Drawing.Point(35, 305)
        Me.btnCheckQualifications.Name = "btnCheckQualifications"
        Me.btnCheckQualifications.Size = New System.Drawing.Size(114, 54)
        Me.btnCheckQualifications.TabIndex = 5
        Me.btnCheckQualifications.Text = "Check Qualifications"
        Me.btnCheckQualifications.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(198, 305)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(86, 54)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(332, 305)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 54)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 395)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCheckQualifications)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Loan Qualifier"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtYearOnJob As TextBox
    Friend WithEvents txtAnnualSalary As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents btnCheckQualifications As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
