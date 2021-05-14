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
        Me.btnChecked = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstCheckedCities = New System.Windows.Forms.ListBox()
        Me.clbCities = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'btnChecked
        '
        Me.btnChecked.Location = New System.Drawing.Point(138, 219)
        Me.btnChecked.Name = "btnChecked"
        Me.btnChecked.Size = New System.Drawing.Size(91, 42)
        Me.btnChecked.TabIndex = 0
        Me.btnChecked.Text = "OK"
        Me.btnChecked.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(329, 219)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 42)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Clear"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstCheckedCities
        '
        Me.lstCheckedCities.FormattingEnabled = True
        Me.lstCheckedCities.ItemHeight = 20
        Me.lstCheckedCities.Location = New System.Drawing.Point(307, 43)
        Me.lstCheckedCities.Name = "lstCheckedCities"
        Me.lstCheckedCities.Size = New System.Drawing.Size(168, 144)
        Me.lstCheckedCities.TabIndex = 2
        '
        'clbCities
        '
        Me.clbCities.FormattingEnabled = True
        Me.clbCities.Items.AddRange(New Object() {"Atlanta", "Chicago", "Los Angeles", "New York", "San Francisco"})
        Me.clbCities.Location = New System.Drawing.Point(102, 43)
        Me.clbCities.Name = "clbCities"
        Me.clbCities.Size = New System.Drawing.Size(184, 142)
        Me.clbCities.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.clbCities)
        Me.Controls.Add(Me.lstCheckedCities)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnChecked)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnChecked As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lstCheckedCities As ListBox
    Friend WithEvents clbCities As CheckedListBox
End Class
