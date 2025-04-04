<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nestedTabTablesStaff
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.extrasButton = New Guna.UI2.WinForms.Guna2Button()
        Me.bookingButton = New Guna.UI2.WinForms.Guna2Button()
        Me.paymentButton = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'extrasButton
        '
        Me.extrasButton.BackColor = System.Drawing.Color.Transparent
        Me.extrasButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.extrasButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.extrasButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.extrasButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.extrasButton.FillColor = System.Drawing.Color.Transparent
        Me.extrasButton.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.extrasButton.ForeColor = System.Drawing.Color.White
        Me.extrasButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.extrasButton.ImageOffset = New System.Drawing.Point(32, 0)
        Me.extrasButton.ImageSize = New System.Drawing.Size(50, 50)
        Me.extrasButton.Location = New System.Drawing.Point(0, 100)
        Me.extrasButton.Name = "extrasButton"
        Me.extrasButton.Size = New System.Drawing.Size(385, 40)
        Me.extrasButton.TabIndex = 30
        Me.extrasButton.Text = "EXTRAS"
        Me.extrasButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.extrasButton.TextOffset = New System.Drawing.Point(94, 0)
        Me.extrasButton.UseTransparentBackground = True
        '
        'bookingButton
        '
        Me.bookingButton.BackColor = System.Drawing.Color.Transparent
        Me.bookingButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bookingButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bookingButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bookingButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bookingButton.FillColor = System.Drawing.Color.Transparent
        Me.bookingButton.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.bookingButton.ForeColor = System.Drawing.Color.White
        Me.bookingButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.bookingButton.ImageOffset = New System.Drawing.Point(32, 0)
        Me.bookingButton.ImageSize = New System.Drawing.Size(50, 50)
        Me.bookingButton.Location = New System.Drawing.Point(0, 0)
        Me.bookingButton.Name = "bookingButton"
        Me.bookingButton.Size = New System.Drawing.Size(385, 40)
        Me.bookingButton.TabIndex = 28
        Me.bookingButton.Text = "BOOKINGS"
        Me.bookingButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.bookingButton.TextOffset = New System.Drawing.Point(94, 0)
        Me.bookingButton.UseTransparentBackground = True
        '
        'paymentButton
        '
        Me.paymentButton.BackColor = System.Drawing.Color.Transparent
        Me.paymentButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.paymentButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.paymentButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.paymentButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.paymentButton.FillColor = System.Drawing.Color.Transparent
        Me.paymentButton.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.paymentButton.ForeColor = System.Drawing.Color.White
        Me.paymentButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.paymentButton.ImageOffset = New System.Drawing.Point(32, 0)
        Me.paymentButton.ImageSize = New System.Drawing.Size(50, 50)
        Me.paymentButton.Location = New System.Drawing.Point(0, 50)
        Me.paymentButton.Name = "paymentButton"
        Me.paymentButton.Size = New System.Drawing.Size(385, 40)
        Me.paymentButton.TabIndex = 29
        Me.paymentButton.Text = "PAYMENT"
        Me.paymentButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.paymentButton.TextOffset = New System.Drawing.Point(94, 0)
        Me.paymentButton.UseTransparentBackground = True
        '
        'nestedTabTablesStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Controls.Add(Me.extrasButton)
        Me.Controls.Add(Me.bookingButton)
        Me.Controls.Add(Me.paymentButton)
        Me.Name = "nestedTabTablesStaff"
        Me.Size = New System.Drawing.Size(385, 145)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents extrasButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bookingButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents paymentButton As Guna.UI2.WinForms.Guna2Button
End Class
