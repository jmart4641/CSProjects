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
        Me.pc5Cent = New System.Windows.Forms.PictureBox()
        Me.pc25Cent = New System.Windows.Forms.PictureBox()
        Me.pic50Cent = New System.Windows.Forms.PictureBox()
        Me.pc10Cent = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.pc5Cent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pc25Cent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic50Cent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pc10Cent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pc5Cent
        '
        Me.pc5Cent.Image = Global.ChangeCounter.My.Resources.Resources._5cents
        Me.pc5Cent.Location = New System.Drawing.Point(86, 77)
        Me.pc5Cent.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.pc5Cent.Name = "pc5Cent"
        Me.pc5Cent.Size = New System.Drawing.Size(125, 181)
        Me.pc5Cent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pc5Cent.TabIndex = 0
        Me.pc5Cent.TabStop = False
        '
        'pc25Cent
        '
        Me.pc25Cent.Image = Global.ChangeCounter.My.Resources.Resources._25cents
        Me.pc25Cent.Location = New System.Drawing.Point(86, 248)
        Me.pc25Cent.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.pc25Cent.Name = "pc25Cent"
        Me.pc25Cent.Size = New System.Drawing.Size(125, 181)
        Me.pc25Cent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pc25Cent.TabIndex = 1
        Me.pc25Cent.TabStop = False
        '
        'pic50Cent
        '
        Me.pic50Cent.Image = Global.ChangeCounter.My.Resources.Resources._50cents
        Me.pic50Cent.Location = New System.Drawing.Point(316, 248)
        Me.pic50Cent.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.pic50Cent.Name = "pic50Cent"
        Me.pic50Cent.Size = New System.Drawing.Size(125, 181)
        Me.pic50Cent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic50Cent.TabIndex = 2
        Me.pic50Cent.TabStop = False
        '
        'pc10Cent
        '
        Me.pc10Cent.Image = Global.ChangeCounter.My.Resources.Resources._10cents
        Me.pc10Cent.Location = New System.Drawing.Point(316, 77)
        Me.pc10Cent.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.pc10Cent.Name = "pc10Cent"
        Me.pc10Cent.Size = New System.Drawing.Size(125, 181)
        Me.pc10Cent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pc10Cent.TabIndex = 3
        Me.pc10Cent.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 464)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(295, 458)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(166, 41)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "$0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(230, 544)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 40)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 612)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pc10Cent)
        Me.Controls.Add(Me.pic50Cent)
        Me.Controls.Add(Me.pc25Cent)
        Me.Controls.Add(Me.pc5Cent)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form1"
        Me.Text = "Change Counter"
        CType(Me.pc5Cent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pc25Cent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic50Cent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pc10Cent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pc5Cent As PictureBox
    Friend WithEvents pc25Cent As PictureBox
    Friend WithEvents pic50Cent As PictureBox
    Friend WithEvents pc10Cent As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnExit As Button
End Class
