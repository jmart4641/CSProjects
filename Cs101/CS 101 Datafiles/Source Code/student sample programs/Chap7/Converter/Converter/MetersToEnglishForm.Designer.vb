<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MetersToEnglishForm
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMetersToYards = New System.Windows.Forms.Button()
        Me.btnMetersToFeet = New System.Windows.Forms.Button()
        Me.btnMetersToInches = New System.Windows.Forms.Button()
        Me.txtMeters = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(152, 136)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 42)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "C&lose"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMetersToYards
        '
        Me.btnMetersToYards.Location = New System.Drawing.Point(273, 85)
        Me.btnMetersToYards.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMetersToYards.Name = "btnMetersToYards"
        Me.btnMetersToYards.Size = New System.Drawing.Size(100, 42)
        Me.btnMetersToYards.TabIndex = 3
        Me.btnMetersToYards.Text = "Convert to &Yards"
        Me.btnMetersToYards.UseVisualStyleBackColor = True
        '
        'btnMetersToFeet
        '
        Me.btnMetersToFeet.Location = New System.Drawing.Point(152, 85)
        Me.btnMetersToFeet.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMetersToFeet.Name = "btnMetersToFeet"
        Me.btnMetersToFeet.Size = New System.Drawing.Size(100, 42)
        Me.btnMetersToFeet.TabIndex = 2
        Me.btnMetersToFeet.Text = "Convert to &Feet"
        Me.btnMetersToFeet.UseVisualStyleBackColor = True
        '
        'btnMetersToInches
        '
        Me.btnMetersToInches.Location = New System.Drawing.Point(31, 85)
        Me.btnMetersToInches.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMetersToInches.Name = "btnMetersToInches"
        Me.btnMetersToInches.Size = New System.Drawing.Size(100, 42)
        Me.btnMetersToInches.TabIndex = 1
        Me.btnMetersToInches.Text = "Convert to &Inches"
        Me.btnMetersToInches.UseVisualStyleBackColor = True
        '
        'txtMeters
        '
        Me.txtMeters.Location = New System.Drawing.Point(227, 29)
        Me.txtMeters.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMeters.Name = "txtMeters"
        Me.txtMeters.Size = New System.Drawing.Size(132, 23)
        Me.txtMeters.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enter the number of meters:"
        '
        'MetersToEnglishForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 199)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnMetersToYards)
        Me.Controls.Add(Me.btnMetersToFeet)
        Me.Controls.Add(Me.btnMetersToInches)
        Me.Controls.Add(Me.txtMeters)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MetersToEnglishForm"
        Me.Text = "Meters to English"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMetersToYards As System.Windows.Forms.Button
    Friend WithEvents btnMetersToFeet As System.Windows.Forms.Button
    Friend WithEvents btnMetersToInches As System.Windows.Forms.Button
    Friend WithEvents txtMeters As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
