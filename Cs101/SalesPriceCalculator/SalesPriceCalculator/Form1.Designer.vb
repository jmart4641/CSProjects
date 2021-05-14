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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOriginalPrice = New System.Windows.Forms.TextBox()
        Me.txtDiscountPercentage = New System.Windows.Forms.TextBox()
        Me.btnCalculateSalePrice = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSalePrice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Orginal Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Discount Percentage"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sale Price"
        '
        'txtOriginalPrice
        '
        Me.txtOriginalPrice.Location = New System.Drawing.Point(343, 61)
        Me.txtOriginalPrice.Name = "txtOriginalPrice"
        Me.txtOriginalPrice.Size = New System.Drawing.Size(100, 35)
        Me.txtOriginalPrice.TabIndex = 0
        '
        'txtDiscountPercentage
        '
        Me.txtDiscountPercentage.Location = New System.Drawing.Point(343, 136)
        Me.txtDiscountPercentage.Name = "txtDiscountPercentage"
        Me.txtDiscountPercentage.Size = New System.Drawing.Size(100, 35)
        Me.txtDiscountPercentage.TabIndex = 1
        '
        'btnCalculateSalePrice
        '
        Me.btnCalculateSalePrice.Location = New System.Drawing.Point(95, 284)
        Me.btnCalculateSalePrice.Name = "btnCalculateSalePrice"
        Me.btnCalculateSalePrice.Size = New System.Drawing.Size(162, 71)
        Me.btnCalculateSalePrice.TabIndex = 6
        Me.btnCalculateSalePrice.Text = "Calculate Sale Price"
        Me.btnCalculateSalePrice.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(295, 298)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 38)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblSalePrice
        '
        Me.lblSalePrice.BackColor = System.Drawing.SystemColors.Info
        Me.lblSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSalePrice.Location = New System.Drawing.Point(319, 209)
        Me.lblSalePrice.Name = "lblSalePrice"
        Me.lblSalePrice.Size = New System.Drawing.Size(124, 42)
        Me.lblSalePrice.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 431)
        Me.Controls.Add(Me.lblSalePrice)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculateSalePrice)
        Me.Controls.Add(Me.txtDiscountPercentage)
        Me.Controls.Add(Me.txtOriginalPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOriginalPrice As TextBox
    Friend WithEvents txtDiscountPercentage As TextBox
    Friend WithEvents btnCalculateSalePrice As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblSalePrice As Label
End Class
