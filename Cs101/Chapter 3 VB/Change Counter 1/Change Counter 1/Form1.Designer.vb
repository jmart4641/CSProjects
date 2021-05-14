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
        Me.picFiveCents = New System.Windows.Forms.PictureBox()
        Me.picTwentyFIveCents = New System.Windows.Forms.PictureBox()
        Me.picFIftyCents = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.picTenCents = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picFiveCents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTwentyFIveCents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFIftyCents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTenCents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picFiveCents
        '
        Me.picFiveCents.Image = Global.Change_Counter_1.My.Resources.Resources._5cents
        Me.picFiveCents.Location = New System.Drawing.Point(43, 50)
        Me.picFiveCents.Name = "picFiveCents"
        Me.picFiveCents.Size = New System.Drawing.Size(125, 181)
        Me.picFiveCents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFiveCents.TabIndex = 0
        Me.picFiveCents.TabStop = False
        '
        'picTwentyFIveCents
        '
        Me.picTwentyFIveCents.Image = Global.Change_Counter_1.My.Resources.Resources._25cents
        Me.picTwentyFIveCents.Location = New System.Drawing.Point(43, 269)
        Me.picTwentyFIveCents.Name = "picTwentyFIveCents"
        Me.picTwentyFIveCents.Size = New System.Drawing.Size(125, 181)
        Me.picTwentyFIveCents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTwentyFIveCents.TabIndex = 1
        Me.picTwentyFIveCents.TabStop = False
        '
        'picFIftyCents
        '
        Me.picFIftyCents.Image = Global.Change_Counter_1.My.Resources.Resources._50cents
        Me.picFIftyCents.Location = New System.Drawing.Point(224, 269)
        Me.picFIftyCents.Name = "picFIftyCents"
        Me.picFIftyCents.Size = New System.Drawing.Size(125, 181)
        Me.picFIftyCents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFIftyCents.TabIndex = 3
        Me.picFIftyCents.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Click the Coins"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(115, 474)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 29)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(195, 474)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(111, 29)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picTenCents
        '
        Me.picTenCents.Image = Global.Change_Counter_1.My.Resources.Resources._10cents
        Me.picTenCents.Location = New System.Drawing.Point(224, 50)
        Me.picTenCents.Name = "picTenCents"
        Me.picTenCents.Size = New System.Drawing.Size(125, 181)
        Me.picTenCents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTenCents.TabIndex = 7
        Me.picTenCents.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(155, 533)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 33)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 578)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picTenCents)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picFIftyCents)
        Me.Controls.Add(Me.picTwentyFIveCents)
        Me.Controls.Add(Me.picFiveCents)
        Me.Name = "Form1"
        Me.Text = "Change Counter"
        CType(Me.picFiveCents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTwentyFIveCents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFIftyCents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTenCents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picFiveCents As PictureBox
    Friend WithEvents picTwentyFIveCents As PictureBox
    Friend WithEvents picFIftyCents As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents picTenCents As PictureBox
    Friend WithEvents btnExit As Button
End Class
