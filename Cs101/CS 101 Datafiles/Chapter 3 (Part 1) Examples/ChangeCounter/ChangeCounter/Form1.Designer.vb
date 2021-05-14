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
        Me.pic5Cents = New System.Windows.Forms.PictureBox()
        Me.pic10Cents = New System.Windows.Forms.PictureBox()
        Me.pic25Cents = New System.Windows.Forms.PictureBox()
        Me.pic50Cents = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.pic5Cents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic10Cents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic25Cents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic50Cents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic5Cents
        '
        Me.pic5Cents.Image = Global.ChangeCounter.My.Resources.Resources._5cents
        Me.pic5Cents.Location = New System.Drawing.Point(36, 34)
        Me.pic5Cents.Name = "pic5Cents"
        Me.pic5Cents.Size = New System.Drawing.Size(100, 88)
        Me.pic5Cents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic5Cents.TabIndex = 0
        Me.pic5Cents.TabStop = False
        '
        'pic10Cents
        '
        Me.pic10Cents.Image = Global.ChangeCounter.My.Resources.Resources._10cents
        Me.pic10Cents.Location = New System.Drawing.Point(190, 34)
        Me.pic10Cents.Name = "pic10Cents"
        Me.pic10Cents.Size = New System.Drawing.Size(100, 88)
        Me.pic10Cents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic10Cents.TabIndex = 1
        Me.pic10Cents.TabStop = False
        '
        'pic25Cents
        '
        Me.pic25Cents.Image = Global.ChangeCounter.My.Resources.Resources._25cents
        Me.pic25Cents.Location = New System.Drawing.Point(36, 170)
        Me.pic25Cents.Name = "pic25Cents"
        Me.pic25Cents.Size = New System.Drawing.Size(100, 88)
        Me.pic25Cents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic25Cents.TabIndex = 2
        Me.pic25Cents.TabStop = False
        '
        'pic50Cents
        '
        Me.pic50Cents.Image = Global.ChangeCounter.My.Resources.Resources._50cents
        Me.pic50Cents.Location = New System.Drawing.Point(190, 170)
        Me.pic50Cents.Name = "pic50Cents"
        Me.pic50Cents.Size = New System.Drawing.Size(100, 88)
        Me.pic50Cents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic50Cents.TabIndex = 3
        Me.pic50Cents.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 313)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total: "
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(160, 312)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(75, 23)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(122, 385)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 29)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pic50Cents)
        Me.Controls.Add(Me.pic25Cents)
        Me.Controls.Add(Me.pic10Cents)
        Me.Controls.Add(Me.pic5Cents)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pic5Cents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic10Cents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic25Cents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic50Cents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic5Cents As PictureBox
    Friend WithEvents pic10Cents As PictureBox
    Friend WithEvents pic25Cents As PictureBox
    Friend WithEvents pic50Cents As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnExit As Button
End Class
