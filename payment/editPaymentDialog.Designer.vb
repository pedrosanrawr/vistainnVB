<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editPaymentDialog
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
        Me.paymentIdTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bookingIdTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.paymentMethodTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.oxPriceButton = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.totalPriceTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.statusTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.editButton = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Raleway", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 55)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "EDIT PAYMENT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'paymentIdTextBox
        '
        Me.paymentIdTextBox.BackColor = System.Drawing.Color.Transparent
        Me.paymentIdTextBox.BorderRadius = 5
        Me.paymentIdTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.paymentIdTextBox.DefaultText = ""
        Me.paymentIdTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.paymentIdTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.paymentIdTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.paymentIdTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.paymentIdTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.paymentIdTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.paymentIdTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.paymentIdTextBox.Location = New System.Drawing.Point(45, 180)
        Me.paymentIdTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.paymentIdTextBox.Name = "paymentIdTextBox"
        Me.paymentIdTextBox.PlaceholderText = ""
        Me.paymentIdTextBox.SelectedText = ""
        Me.paymentIdTextBox.ShadowDecoration.Enabled = True
        Me.paymentIdTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.paymentIdTextBox.Size = New System.Drawing.Size(230, 50)
        Me.paymentIdTextBox.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 26)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "PAYMENT ID"
        '
        'bookingIdTextBox
        '
        Me.bookingIdTextBox.BackColor = System.Drawing.Color.Transparent
        Me.bookingIdTextBox.BorderRadius = 5
        Me.bookingIdTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bookingIdTextBox.DefaultText = ""
        Me.bookingIdTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.bookingIdTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.bookingIdTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.bookingIdTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.bookingIdTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.bookingIdTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.bookingIdTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.bookingIdTextBox.Location = New System.Drawing.Point(45, 280)
        Me.bookingIdTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.bookingIdTextBox.Name = "bookingIdTextBox"
        Me.bookingIdTextBox.PlaceholderText = ""
        Me.bookingIdTextBox.SelectedText = ""
        Me.bookingIdTextBox.ShadowDecoration.Enabled = True
        Me.bookingIdTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.bookingIdTextBox.Size = New System.Drawing.Size(230, 50)
        Me.bookingIdTextBox.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 26)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "BOOKING ID"
        '
        'paymentMethodTextBox
        '
        Me.paymentMethodTextBox.BackColor = System.Drawing.Color.Transparent
        Me.paymentMethodTextBox.BorderRadius = 5
        Me.paymentMethodTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.paymentMethodTextBox.DefaultText = ""
        Me.paymentMethodTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.paymentMethodTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.paymentMethodTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.paymentMethodTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.paymentMethodTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.paymentMethodTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.paymentMethodTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.paymentMethodTextBox.Location = New System.Drawing.Point(45, 380)
        Me.paymentMethodTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.paymentMethodTextBox.Name = "paymentMethodTextBox"
        Me.paymentMethodTextBox.PlaceholderText = ""
        Me.paymentMethodTextBox.SelectedText = ""
        Me.paymentMethodTextBox.ShadowDecoration.Enabled = True
        Me.paymentMethodTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.paymentMethodTextBox.Size = New System.Drawing.Size(230, 50)
        Me.paymentMethodTextBox.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(234, 26)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "PAYMENT METHOD"
        '
        'oxPriceButton
        '
        Me.oxPriceButton.BackColor = System.Drawing.Color.Transparent
        Me.oxPriceButton.BorderRadius = 5
        Me.oxPriceButton.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.oxPriceButton.DefaultText = ""
        Me.oxPriceButton.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.oxPriceButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.oxPriceButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.oxPriceButton.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.oxPriceButton.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.oxPriceButton.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.oxPriceButton.HoverState.BorderColor = System.Drawing.Color.Black
        Me.oxPriceButton.Location = New System.Drawing.Point(295, 180)
        Me.oxPriceButton.Margin = New System.Windows.Forms.Padding(6)
        Me.oxPriceButton.Name = "oxPriceButton"
        Me.oxPriceButton.PlaceholderText = ""
        Me.oxPriceButton.SelectedText = ""
        Me.oxPriceButton.ShadowDecoration.Enabled = True
        Me.oxPriceButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.oxPriceButton.Size = New System.Drawing.Size(230, 50)
        Me.oxPriceButton.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(291, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 26)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "OX PRICE"
        '
        'totalPriceTextBox
        '
        Me.totalPriceTextBox.BackColor = System.Drawing.Color.Transparent
        Me.totalPriceTextBox.BorderRadius = 5
        Me.totalPriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.totalPriceTextBox.DefaultText = ""
        Me.totalPriceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.totalPriceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.totalPriceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.totalPriceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.totalPriceTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.totalPriceTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.totalPriceTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.totalPriceTextBox.Location = New System.Drawing.Point(295, 280)
        Me.totalPriceTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.totalPriceTextBox.Name = "totalPriceTextBox"
        Me.totalPriceTextBox.PlaceholderText = ""
        Me.totalPriceTextBox.SelectedText = ""
        Me.totalPriceTextBox.ShadowDecoration.Enabled = True
        Me.totalPriceTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.totalPriceTextBox.Size = New System.Drawing.Size(230, 50)
        Me.totalPriceTextBox.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(291, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 26)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "TOTAL PRICE"
        '
        'statusTextBox
        '
        Me.statusTextBox.BackColor = System.Drawing.Color.Transparent
        Me.statusTextBox.BorderRadius = 5
        Me.statusTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.statusTextBox.DefaultText = ""
        Me.statusTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.statusTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.statusTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.statusTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.statusTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.statusTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.statusTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.statusTextBox.Location = New System.Drawing.Point(295, 380)
        Me.statusTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.statusTextBox.Name = "statusTextBox"
        Me.statusTextBox.PlaceholderText = ""
        Me.statusTextBox.SelectedText = ""
        Me.statusTextBox.ShadowDecoration.Enabled = True
        Me.statusTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.statusTextBox.Size = New System.Drawing.Size(230, 50)
        Me.statusTextBox.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(291, 356)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 26)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "STATUS"
        '
        'editButton
        '
        Me.editButton.BackColor = System.Drawing.Color.Transparent
        Me.editButton.BorderRadius = 5
        Me.editButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.editButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.editButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.editButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.editButton.FillColor = System.Drawing.Color.Black
        Me.editButton.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.editButton.ForeColor = System.Drawing.Color.White
        Me.editButton.Location = New System.Drawing.Point(225, 704)
        Me.editButton.Name = "editButton"
        Me.editButton.ShadowDecoration.BorderRadius = 5
        Me.editButton.ShadowDecoration.Enabled = True
        Me.editButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.editButton.Size = New System.Drawing.Size(120, 50)
        Me.editButton.TabIndex = 55
        Me.editButton.Text = "EDIT"
        '
        'editPaymentDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(571, 790)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.statusTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.totalPriceTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.oxPriceButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.paymentMethodTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.bookingIdTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.paymentIdTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "editPaymentDialog"
        Me.Text = "editPaymentDialog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents paymentIdTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents bookingIdTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents paymentMethodTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents oxPriceButton As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents totalPriceTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents statusTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents editButton As Guna.UI2.WinForms.Guna2Button
End Class
