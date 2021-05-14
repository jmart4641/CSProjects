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
        Me.radSenior = New System.Windows.Forms.RadioButton()
        Me.radStudent = New System.Windows.Forms.RadioButton()
        Me.radChild = New System.Windows.Forms.RadioButton()
        Me.radAdult = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkTrainer = New System.Windows.Forms.CheckBox()
        Me.chkKarate = New System.Windows.Forms.CheckBox()
        Me.chkYoga = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtMonths = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblMonthlyFee = New System.Windows.Forms.Label()
        Me.lblTotalFee = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radSenior)
        Me.GroupBox1.Controls.Add(Me.radStudent)
        Me.GroupBox1.Controls.Add(Me.radChild)
        Me.GroupBox1.Controls.Add(Me.radAdult)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 159)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type of Membership"
        '
        'radSenior
        '
        Me.radSenior.AutoSize = True
        Me.radSenior.Location = New System.Drawing.Point(22, 115)
        Me.radSenior.Name = "radSenior"
        Me.radSenior.Size = New System.Drawing.Size(132, 24)
        Me.radSenior.TabIndex = 5
        Me.radSenior.TabStop = True
        Me.radSenior.Text = "S&enior Citizen"
        Me.radSenior.UseVisualStyleBackColor = True
        '
        'radStudent
        '
        Me.radStudent.AutoSize = True
        Me.radStudent.Location = New System.Drawing.Point(22, 85)
        Me.radStudent.Name = "radStudent"
        Me.radStudent.Size = New System.Drawing.Size(91, 24)
        Me.radStudent.TabIndex = 4
        Me.radStudent.TabStop = True
        Me.radStudent.Text = "&Student"
        Me.radStudent.UseVisualStyleBackColor = True
        '
        'radChild
        '
        Me.radChild.AutoSize = True
        Me.radChild.Location = New System.Drawing.Point(22, 55)
        Me.radChild.Name = "radChild"
        Me.radChild.Size = New System.Drawing.Size(161, 24)
        Me.radChild.TabIndex = 3
        Me.radChild.TabStop = True
        Me.radChild.Text = "Chil&d (12 && under)"
        Me.radChild.UseVisualStyleBackColor = True
        '
        'radAdult
        '
        Me.radAdult.AutoSize = True
        Me.radAdult.Location = New System.Drawing.Point(22, 25)
        Me.radAdult.Name = "radAdult"
        Me.radAdult.Size = New System.Drawing.Size(141, 24)
        Me.radAdult.TabIndex = 2
        Me.radAdult.TabStop = True
        Me.radAdult.Text = "Standard &Adult"
        Me.radAdult.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkTrainer)
        Me.GroupBox2.Controls.Add(Me.chkKarate)
        Me.GroupBox2.Controls.Add(Me.chkYoga)
        Me.GroupBox2.Location = New System.Drawing.Point(341, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(264, 159)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Options"
        '
        'chkTrainer
        '
        Me.chkTrainer.AutoSize = True
        Me.chkTrainer.Location = New System.Drawing.Point(18, 87)
        Me.chkTrainer.Name = "chkTrainer"
        Me.chkTrainer.Size = New System.Drawing.Size(150, 24)
        Me.chkTrainer.TabIndex = 5
        Me.chkTrainer.Text = "&Personal Trainer"
        Me.chkTrainer.UseVisualStyleBackColor = True
        '
        'chkKarate
        '
        Me.chkKarate.AutoSize = True
        Me.chkKarate.Location = New System.Drawing.Point(18, 55)
        Me.chkKarate.Name = "chkKarate"
        Me.chkKarate.Size = New System.Drawing.Size(82, 24)
        Me.chkKarate.TabIndex = 4
        Me.chkKarate.Text = "&Karate"
        Me.chkKarate.UseVisualStyleBackColor = True
        '
        'chkYoga
        '
        Me.chkYoga.AutoSize = True
        Me.chkYoga.Location = New System.Drawing.Point(18, 25)
        Me.chkYoga.Name = "chkYoga"
        Me.chkYoga.Size = New System.Drawing.Size(73, 24)
        Me.chkYoga.TabIndex = 3
        Me.chkYoga.Text = "&Yoga"
        Me.chkYoga.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtMonths)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(47, 184)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(264, 159)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Memebership Length"
        '
        'txtMonths
        '
        Me.txtMonths.Location = New System.Drawing.Point(22, 79)
        Me.txtMonths.Name = "txtMonths"
        Me.txtMonths.Size = New System.Drawing.Size(200, 26)
        Me.txtMonths.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(46, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 42)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter the Number of Months:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblMonthlyFee)
        Me.GroupBox4.Controls.Add(Me.lblTotalFee)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(341, 184)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(264, 159)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Membership Fee"
        '
        'lblMonthlyFee
        '
        Me.lblMonthlyFee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMonthlyFee.Location = New System.Drawing.Point(131, 45)
        Me.lblMonthlyFee.Name = "lblMonthlyFee"
        Me.lblMonthlyFee.Size = New System.Drawing.Size(87, 25)
        Me.lblMonthlyFee.TabIndex = 7
        '
        'lblTotalFee
        '
        Me.lblTotalFee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalFee.Location = New System.Drawing.Point(131, 79)
        Me.lblTotalFee.Name = "lblTotalFee"
        Me.lblTotalFee.Size = New System.Drawing.Size(87, 25)
        Me.lblTotalFee.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Monthly Fee:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(140, 363)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(102, 37)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "C&alculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(265, 363)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(102, 37)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clea&r"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(389, 363)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(102, 37)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 425)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(652, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 15)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 447)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Member Fee Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radAdult As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkYoga As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtMonths As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents radSenior As RadioButton
    Friend WithEvents radStudent As RadioButton
    Friend WithEvents radChild As RadioButton
    Friend WithEvents chkTrainer As CheckBox
    Friend WithEvents chkKarate As CheckBox
    Friend WithEvents lblMonthlyFee As Label
    Friend WithEvents lblTotalFee As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
End Class
