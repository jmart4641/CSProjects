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
        Me.components = New System.ComponentModel.Container()
        Me.btnaTose = New System.Windows.Forms.Button()
        Me.picHead = New System.Windows.Forms.PictureBox()
        Me.picTails = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.picHead, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnaTose
        '
        Me.btnaTose.Location = New System.Drawing.Point(85, 239)
        Me.btnaTose.Name = "btnaTose"
        Me.btnaTose.Size = New System.Drawing.Size(195, 41)
        Me.btnaTose.TabIndex = 0
        Me.btnaTose.Text = "&Toss the Coin"
        Me.ToolTip1.SetToolTip(Me.btnaTose, "Click to toss the coin")
        Me.btnaTose.UseVisualStyleBackColor = True
        '
        'picHead
        '
        Me.picHead.Image = Global.Coin_Toss.My.Resources.Resources.Heads
        Me.picHead.Location = New System.Drawing.Point(42, 12)
        Me.picHead.Name = "picHead"
        Me.picHead.Size = New System.Drawing.Size(238, 177)
        Me.picHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHead.TabIndex = 1
        Me.picHead.TabStop = False
        '
        'picTails
        '
        Me.picTails.Image = Global.Coin_Toss.My.Resources.Resources.Tails
        Me.picTails.Location = New System.Drawing.Point(305, 12)
        Me.picTails.Name = "picTails"
        Me.picTails.Size = New System.Drawing.Size(214, 177)
        Me.picTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTails.TabIndex = 2
        Me.picTails.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(305, 239)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(195, 41)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Click to Exit")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 324)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picTails)
        Me.Controls.Add(Me.picHead)
        Me.Controls.Add(Me.btnaTose)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picHead, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnaTose As Button
    Friend WithEvents picHead As PictureBox
    Friend WithEvents picTails As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
