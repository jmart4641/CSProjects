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
        Me.btnCalculateAve = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblAverageTemp = New System.Windows.Forms.Label()
        Me.txtWeekOneTemp = New System.Windows.Forms.TextBox()
        Me.txtWeekThreeTemp = New System.Windows.Forms.TextBox()
        Me.txtWeekTwoTemp = New System.Windows.Forms.TextBox()
        Me.txtWeekFiveTemp = New System.Windows.Forms.TextBox()
        Me.txtWeekFourTemp = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalculateAve
        '
        Me.btnCalculateAve.Location = New System.Drawing.Point(72, 380)
        Me.btnCalculateAve.Name = "btnCalculateAve"
        Me.btnCalculateAve.Size = New System.Drawing.Size(90, 40)
        Me.btnCalculateAve.TabIndex = 0
        Me.btnCalculateAve.Text = "Calculate"
        Me.btnCalculateAve.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Week #1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Week #2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Week #3:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(98, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Week #4:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(98, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Week #5:"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(178, 380)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 40)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(284, 380)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 40)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(98, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Average:"
        '
        'lblAverageTemp
        '
        Me.lblAverageTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageTemp.Location = New System.Drawing.Point(188, 310)
        Me.lblAverageTemp.Name = "lblAverageTemp"
        Me.lblAverageTemp.Size = New System.Drawing.Size(100, 30)
        Me.lblAverageTemp.TabIndex = 9
        '
        'txtWeekOneTemp
        '
        Me.txtWeekOneTemp.Location = New System.Drawing.Point(188, 67)
        Me.txtWeekOneTemp.Name = "txtWeekOneTemp"
        Me.txtWeekOneTemp.Size = New System.Drawing.Size(100, 26)
        Me.txtWeekOneTemp.TabIndex = 10
        Me.txtWeekOneTemp.Text = "4"
        '
        'txtWeekThreeTemp
        '
        Me.txtWeekThreeTemp.Location = New System.Drawing.Point(188, 163)
        Me.txtWeekThreeTemp.Name = "txtWeekThreeTemp"
        Me.txtWeekThreeTemp.Size = New System.Drawing.Size(100, 26)
        Me.txtWeekThreeTemp.TabIndex = 11
        '
        'txtWeekTwoTemp
        '
        Me.txtWeekTwoTemp.Location = New System.Drawing.Point(188, 112)
        Me.txtWeekTwoTemp.Name = "txtWeekTwoTemp"
        Me.txtWeekTwoTemp.Size = New System.Drawing.Size(100, 26)
        Me.txtWeekTwoTemp.TabIndex = 12
        '
        'txtWeekFiveTemp
        '
        Me.txtWeekFiveTemp.Location = New System.Drawing.Point(188, 254)
        Me.txtWeekFiveTemp.Name = "txtWeekFiveTemp"
        Me.txtWeekFiveTemp.Size = New System.Drawing.Size(100, 26)
        Me.txtWeekFiveTemp.TabIndex = 13
        '
        'txtWeekFourTemp
        '
        Me.txtWeekFourTemp.Location = New System.Drawing.Point(188, 211)
        Me.txtWeekFourTemp.Name = "txtWeekFourTemp"
        Me.txtWeekFourTemp.Size = New System.Drawing.Size(100, 26)
        Me.txtWeekFourTemp.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 450)
        Me.Controls.Add(Me.txtWeekFourTemp)
        Me.Controls.Add(Me.txtWeekFiveTemp)
        Me.Controls.Add(Me.txtWeekTwoTemp)
        Me.Controls.Add(Me.txtWeekThreeTemp)
        Me.Controls.Add(Me.txtWeekOneTemp)
        Me.Controls.Add(Me.lblAverageTemp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalculateAve)
        Me.Name = "Form1"
        Me.Text = "Weekly Temperature Average"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculateAve As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lblAverageTemp As Label
    Friend WithEvents txtWeekOneTemp As TextBox
    Friend WithEvents txtWeekThreeTemp As TextBox
    Friend WithEvents txtWeekTwoTemp As TextBox
    Friend WithEvents txtWeekFiveTemp As TextBox
    Friend WithEvents txtWeekFourTemp As TextBox
End Class
