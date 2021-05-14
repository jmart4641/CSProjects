<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radOneTimePchse = New System.Windows.Forms.RadioButton()
        Me.radYearlyLic = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkCloudBackup = New System.Windows.Forms.CheckBox()
        Me.chkOneSiteTrain = New System.Windows.Forms.CheckBox()
        Me.chkLevel3TechS = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCostOptFeat = New System.Windows.Forms.Label()
        Me.lblCostSoftwLice = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.radOneTimePchse)
        Me.GroupBox1.Controls.Add(Me.radYearlyLic)
        Me.GroupBox1.Location = New System.Drawing.Point(57, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 180)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Licencing Options"
        '
        'radOneTimePchse
        '
        Me.radOneTimePchse.AutoSize = True
        Me.radOneTimePchse.Location = New System.Drawing.Point(18, 75)
        Me.radOneTimePchse.Name = "radOneTimePchse"
        Me.radOneTimePchse.Size = New System.Drawing.Size(174, 24)
        Me.radOneTimePchse.TabIndex = 1
        Me.radOneTimePchse.TabStop = True
        Me.radOneTimePchse.Text = "One-Time Purchase"
        Me.radOneTimePchse.UseVisualStyleBackColor = True
        '
        'radYearlyLic
        '
        Me.radYearlyLic.AutoSize = True
        Me.radYearlyLic.Location = New System.Drawing.Point(18, 36)
        Me.radYearlyLic.Name = "radYearlyLic"
        Me.radYearlyLic.Size = New System.Drawing.Size(137, 24)
        Me.radYearlyLic.TabIndex = 0
        Me.radYearlyLic.TabStop = True
        Me.radYearlyLic.Text = "Yearly License"
        Me.radYearlyLic.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Controls.Add(Me.chkCloudBackup)
        Me.GroupBox2.Controls.Add(Me.chkOneSiteTrain)
        Me.GroupBox2.Controls.Add(Me.chkLevel3TechS)
        Me.GroupBox2.Location = New System.Drawing.Point(367, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(299, 180)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Optional Features (Yearly)"
        '
        'chkCloudBackup
        '
        Me.chkCloudBackup.AutoSize = True
        Me.chkCloudBackup.Location = New System.Drawing.Point(17, 121)
        Me.chkCloudBackup.Name = "chkCloudBackup"
        Me.chkCloudBackup.Size = New System.Drawing.Size(134, 24)
        Me.chkCloudBackup.TabIndex = 2
        Me.chkCloudBackup.Text = "Cloud Backup"
        Me.chkCloudBackup.UseVisualStyleBackColor = True
        '
        'chkOneSiteTrain
        '
        Me.chkOneSiteTrain.AutoSize = True
        Me.chkOneSiteTrain.Location = New System.Drawing.Point(17, 76)
        Me.chkOneSiteTrain.Name = "chkOneSiteTrain"
        Me.chkOneSiteTrain.Size = New System.Drawing.Size(146, 24)
        Me.chkOneSiteTrain.TabIndex = 1
        Me.chkOneSiteTrain.Text = "On-site Training"
        Me.chkOneSiteTrain.UseVisualStyleBackColor = True
        '
        'chkLevel3TechS
        '
        Me.chkLevel3TechS.AutoSize = True
        Me.chkLevel3TechS.Location = New System.Drawing.Point(17, 36)
        Me.chkLevel3TechS.Name = "chkLevel3TechS"
        Me.chkLevel3TechS.Size = New System.Drawing.Size(218, 24)
        Me.chkLevel3TechS.TabIndex = 0
        Me.chkLevel3TechS.Text = "Level-3 Technical Support"
        Me.chkLevel3TechS.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblCostOptFeat)
        Me.Panel1.Controls.Add(Me.lblCostSoftwLice)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(127, 239)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(475, 114)
        Me.Panel1.TabIndex = 2
        '
        'lblCostOptFeat
        '
        Me.lblCostOptFeat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCostOptFeat.Location = New System.Drawing.Point(298, 55)
        Me.lblCostOptFeat.Name = "lblCostOptFeat"
        Me.lblCostOptFeat.Size = New System.Drawing.Size(161, 28)
        Me.lblCostOptFeat.TabIndex = 3
        '
        'lblCostSoftwLice
        '
        Me.lblCostSoftwLice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCostSoftwLice.Location = New System.Drawing.Point(298, 19)
        Me.lblCostSoftwLice.Name = "lblCostSoftwLice"
        Me.lblCostSoftwLice.Size = New System.Drawing.Size(161, 28)
        Me.lblCostSoftwLice.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cost of optional features:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cost of software licensing:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(149, 371)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(110, 30)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(309, 371)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 30)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(471, 371)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(110, 30)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 450)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "Software Sales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radOneTimePchse As RadioButton
    Friend WithEvents radYearlyLic As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkCloudBackup As CheckBox
    Friend WithEvents chkOneSiteTrain As CheckBox
    Friend WithEvents chkLevel3TechS As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCostOptFeat As Label
    Friend WithEvents lblCostSoftwLice As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
End Class
