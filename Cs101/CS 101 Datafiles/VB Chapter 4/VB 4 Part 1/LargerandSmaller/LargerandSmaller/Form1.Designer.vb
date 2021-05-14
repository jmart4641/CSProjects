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
        Me.btnCompare = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtAInteger = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.txtBInteger = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "A:"
        '
        'btnCompare
        '
        Me.btnCompare.Location = New System.Drawing.Point(86, 172)
        Me.btnCompare.Name = "btnCompare"
        Me.btnCompare.Size = New System.Drawing.Size(104, 36)
        Me.btnCompare.TabIndex = 6
        Me.btnCompare.Text = "Compare"
        Me.btnCompare.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(250, 172)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 36)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtAInteger
        '
        Me.txtAInteger.Location = New System.Drawing.Point(85, 69)
        Me.txtAInteger.Name = "txtAInteger"
        Me.txtAInteger.Size = New System.Drawing.Size(125, 26)
        Me.txtAInteger.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(239, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "B:"
        '
        'lblResults
        '
        Me.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResults.Location = New System.Drawing.Point(27, 119)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(398, 33)
        Me.lblResults.TabIndex = 2
        Me.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBInteger
        '
        Me.txtBInteger.Location = New System.Drawing.Point(271, 66)
        Me.txtBInteger.Name = "txtBInteger"
        Me.txtBInteger.Size = New System.Drawing.Size(125, 26)
        Me.txtBInteger.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(314, 33)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Enter Two Integers"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 261)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBInteger)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAInteger)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCompare)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Larger and Smaller"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCompare As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtAInteger As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblResults As Label
    Friend WithEvents txtBInteger As TextBox
    Friend WithEvents Label3 As Label
End Class
