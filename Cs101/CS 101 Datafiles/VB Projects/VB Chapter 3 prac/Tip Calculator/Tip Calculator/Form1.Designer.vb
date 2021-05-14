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
        Me.btnFifteen = New System.Windows.Forms.Button()
        Me.btnTwenty = New System.Windows.Forms.Button()
        Me.btnTwentyFive = New System.Windows.Forms.Button()
        Me.txtBillAmount = New System.Windows.Forms.TextBox()
        Me.lblTip = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Amount of Bill:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Amount To Top:"
        '
        'btnFifteen
        '
        Me.btnFifteen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFifteen.Location = New System.Drawing.Point(54, 93)
        Me.btnFifteen.Name = "btnFifteen"
        Me.btnFifteen.Size = New System.Drawing.Size(104, 33)
        Me.btnFifteen.TabIndex = 2
        Me.btnFifteen.Text = "15%"
        Me.btnFifteen.UseVisualStyleBackColor = True
        '
        'btnTwenty
        '
        Me.btnTwenty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTwenty.Location = New System.Drawing.Point(187, 93)
        Me.btnTwenty.Name = "btnTwenty"
        Me.btnTwenty.Size = New System.Drawing.Size(104, 33)
        Me.btnTwenty.TabIndex = 3
        Me.btnTwenty.Text = "20%"
        Me.btnTwenty.UseVisualStyleBackColor = True
        '
        'btnTwentyFive
        '
        Me.btnTwentyFive.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTwentyFive.Location = New System.Drawing.Point(314, 93)
        Me.btnTwentyFive.Name = "btnTwentyFive"
        Me.btnTwentyFive.Size = New System.Drawing.Size(104, 33)
        Me.btnTwentyFive.TabIndex = 4
        Me.btnTwentyFive.Text = "25%"
        Me.btnTwentyFive.UseVisualStyleBackColor = True
        '
        'txtBillAmount
        '
        Me.txtBillAmount.Location = New System.Drawing.Point(230, 28)
        Me.txtBillAmount.Name = "txtBillAmount"
        Me.txtBillAmount.Size = New System.Drawing.Size(153, 35)
        Me.txtBillAmount.TabIndex = 5
        '
        'lblTip
        '
        Me.lblTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTip.Location = New System.Drawing.Point(225, 150)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(158, 37)
        Me.lblTip.TabIndex = 6
        Me.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(187, 210)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 36)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 258)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTip)
        Me.Controls.Add(Me.txtBillAmount)
        Me.Controls.Add(Me.btnTwentyFive)
        Me.Controls.Add(Me.btnTwenty)
        Me.Controls.Add(Me.btnFifteen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form1"
        Me.Text = "Tip Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnFifteen As Button
    Friend WithEvents btnTwenty As Button
    Friend WithEvents btnTwentyFive As Button
    Friend WithEvents txtBillAmount As TextBox
    Friend WithEvents lblTip As Label
    Friend WithEvents btnExit As Button
End Class
