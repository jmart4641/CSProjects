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
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.txtIntergerRange = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(34, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 50)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Equivalent Roman Numeral:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(144, 167)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(104, 38)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'txtIntergerRange
        '
        Me.txtIntergerRange.Location = New System.Drawing.Point(233, 50)
        Me.txtIntergerRange.Name = "txtIntergerRange"
        Me.txtIntergerRange.Size = New System.Drawing.Size(179, 26)
        Me.txtIntergerRange.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(254, 167)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(102, 38)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(33, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 45)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Enter a decimal integer in the range 1-10:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(233, 107)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(179, 30)
        Me.lblResult.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 238)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtIntergerRange)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Roman Numeral Convertor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents txtIntergerRange As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblResult As Label
End Class
