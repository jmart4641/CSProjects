﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lblGreeting = New System.Windows.Forms.Label()
        Me.btnItalian = New System.Windows.Forms.Button()
        Me.btnSpanish = New System.Windows.Forms.Button()
        Me.btnGerman = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(109, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(441, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select a Language to say Good Morning"
        '
        'lblGreeting
        '
        Me.lblGreeting.BackColor = System.Drawing.SystemColors.Info
        Me.lblGreeting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGreeting.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreeting.Location = New System.Drawing.Point(114, 120)
        Me.lblGreeting.Name = "lblGreeting"
        Me.lblGreeting.Size = New System.Drawing.Size(462, 44)
        Me.lblGreeting.TabIndex = 1
        Me.lblGreeting.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnItalian
        '
        Me.btnItalian.Location = New System.Drawing.Point(114, 183)
        Me.btnItalian.Name = "btnItalian"
        Me.btnItalian.Size = New System.Drawing.Size(117, 34)
        Me.btnItalian.TabIndex = 2
        Me.btnItalian.Text = "Italian"
        Me.btnItalian.UseVisualStyleBackColor = True
        '
        'btnSpanish
        '
        Me.btnSpanish.Location = New System.Drawing.Point(275, 184)
        Me.btnSpanish.Name = "btnSpanish"
        Me.btnSpanish.Size = New System.Drawing.Size(117, 34)
        Me.btnSpanish.TabIndex = 3
        Me.btnSpanish.Text = "Spanish"
        Me.btnSpanish.UseVisualStyleBackColor = True
        '
        'btnGerman
        '
        Me.btnGerman.Location = New System.Drawing.Point(433, 184)
        Me.btnGerman.Name = "btnGerman"
        Me.btnGerman.Size = New System.Drawing.Size(117, 34)
        Me.btnGerman.TabIndex = 4
        Me.btnGerman.Text = "German"
        Me.btnGerman.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 402)
        Me.Controls.Add(Me.btnGerman)
        Me.Controls.Add(Me.btnSpanish)
        Me.Controls.Add(Me.btnItalian)
        Me.Controls.Add(Me.lblGreeting)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Language Translator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblGreeting As Label
    Friend WithEvents btnItalian As Button
    Friend WithEvents btnSpanish As Button
    Friend WithEvents btnGerman As Button
End Class
