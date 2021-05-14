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
        Me.lblNumberOfSlices = New System.Windows.Forms.Label()
        Me.txtDiameterPizza = New System.Windows.Forms.TextBox()
        Me.btnCalculateSlices = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Diameter of Pizza:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of Slices:"
        '
        'lblNumberOfSlices
        '
        Me.lblNumberOfSlices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumberOfSlices.Location = New System.Drawing.Point(185, 108)
        Me.lblNumberOfSlices.Name = "lblNumberOfSlices"
        Me.lblNumberOfSlices.Size = New System.Drawing.Size(100, 29)
        Me.lblNumberOfSlices.TabIndex = 2
        '
        'txtDiameterPizza
        '
        Me.txtDiameterPizza.Location = New System.Drawing.Point(185, 65)
        Me.txtDiameterPizza.Name = "txtDiameterPizza"
        Me.txtDiameterPizza.Size = New System.Drawing.Size(100, 26)
        Me.txtDiameterPizza.TabIndex = 3
        '
        'btnCalculateSlices
        '
        Me.btnCalculateSlices.Location = New System.Drawing.Point(12, 169)
        Me.btnCalculateSlices.Name = "btnCalculateSlices"
        Me.btnCalculateSlices.Size = New System.Drawing.Size(149, 55)
        Me.btnCalculateSlices.TabIndex = 4
        Me.btnCalculateSlices.Text = "Calculate Number Slices"
        Me.btnCalculateSlices.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(176, 169)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(84, 55)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(278, 169)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 55)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 283)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateSlices)
        Me.Controls.Add(Me.txtDiameterPizza)
        Me.Controls.Add(Me.lblNumberOfSlices)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Pizza Pi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNumberOfSlices As Label
    Friend WithEvents txtDiameterPizza As TextBox
    Friend WithEvents btnCalculateSlices As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
