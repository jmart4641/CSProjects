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
        Me.btnOne = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.btnFour = New System.Windows.Forms.Button()
        Me.btnFIve = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Status = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Status.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOne
        '
        Me.btnOne.Location = New System.Drawing.Point(26, 112)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(48, 31)
        Me.btnOne.TabIndex = 0
        Me.btnOne.Text = "1"
        Me.btnOne.UseVisualStyleBackColor = True
        '
        'btnTwo
        '
        Me.btnTwo.Location = New System.Drawing.Point(94, 112)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(48, 31)
        Me.btnTwo.TabIndex = 1
        Me.btnTwo.Text = "2"
        Me.btnTwo.UseVisualStyleBackColor = True
        '
        'btnThree
        '
        Me.btnThree.Location = New System.Drawing.Point(164, 112)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(48, 31)
        Me.btnThree.TabIndex = 2
        Me.btnThree.Text = "3"
        Me.btnThree.UseVisualStyleBackColor = True
        '
        'btnFour
        '
        Me.btnFour.Location = New System.Drawing.Point(234, 112)
        Me.btnFour.Name = "btnFour"
        Me.btnFour.Size = New System.Drawing.Size(48, 31)
        Me.btnFour.TabIndex = 3
        Me.btnFour.Text = "4"
        Me.btnFour.UseVisualStyleBackColor = True
        '
        'btnFIve
        '
        Me.btnFIve.Location = New System.Drawing.Point(319, 112)
        Me.btnFIve.Name = "btnFIve"
        Me.btnFIve.Size = New System.Drawing.Size(48, 31)
        Me.btnFIve.TabIndex = 4
        Me.btnFIve.Text = "5"
        Me.btnFIve.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(22, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 50)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Do you Know the French words for the numbers 1 through 5?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Click the button below to see them."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(152, 163)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 34)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Status
        '
        Me.Status.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.Status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.Status.Location = New System.Drawing.Point(0, 226)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(382, 22)
        Me.Status.TabIndex = 8
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 21)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 248)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFIve)
        Me.Controls.Add(Me.btnFour)
        Me.Controls.Add(Me.btnThree)
        Me.Controls.Add(Me.btnTwo)
        Me.Controls.Add(Me.btnOne)
        Me.Name = "Form1"
        Me.Text = "French Numbers"
        Me.Status.ResumeLayout(False)
        Me.Status.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOne As Button
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnThree As Button
    Friend WithEvents btnFour As Button
    Friend WithEvents btnFIve As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Status As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
End Class
