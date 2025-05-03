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
        Me.bookingIdTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.paymentMethodTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.oxPriceTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.totalPriceTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.editButton = New Guna.UI2.WinForms.Guna2Button()
        Me.statusComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.downPaymentTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.amountDueTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
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
        Me.bookingIdTextBox.Enabled = False
        Me.bookingIdTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.bookingIdTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.bookingIdTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.bookingIdTextBox.Location = New System.Drawing.Point(45, 180)
        Me.bookingIdTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.bookingIdTextBox.Name = "bookingIdTextBox"
        Me.bookingIdTextBox.PlaceholderText = ""
        Me.bookingIdTextBox.ReadOnly = True
        Me.bookingIdTextBox.SelectedText = ""
        Me.bookingIdTextBox.ShadowDecoration.Enabled = True
        Me.bookingIdTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.bookingIdTextBox.Size = New System.Drawing.Size(230, 50)
        Me.bookingIdTextBox.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 156)
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
        Me.paymentMethodTextBox.Enabled = False
        Me.paymentMethodTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.paymentMethodTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.paymentMethodTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.paymentMethodTextBox.Location = New System.Drawing.Point(295, 180)
        Me.paymentMethodTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.paymentMethodTextBox.Name = "paymentMethodTextBox"
        Me.paymentMethodTextBox.PlaceholderText = ""
        Me.paymentMethodTextBox.ReadOnly = True
        Me.paymentMethodTextBox.SelectedText = ""
        Me.paymentMethodTextBox.ShadowDecoration.Enabled = True
        Me.paymentMethodTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.paymentMethodTextBox.Size = New System.Drawing.Size(230, 50)
        Me.paymentMethodTextBox.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(291, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(234, 26)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "PAYMENT METHOD"
        '
        'oxPriceTextBox
        '
        Me.oxPriceTextBox.BackColor = System.Drawing.Color.Transparent
        Me.oxPriceTextBox.BorderRadius = 5
        Me.oxPriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.oxPriceTextBox.DefaultText = ""
        Me.oxPriceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.oxPriceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.oxPriceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.oxPriceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.oxPriceTextBox.Enabled = False
        Me.oxPriceTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.oxPriceTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.oxPriceTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.oxPriceTextBox.Location = New System.Drawing.Point(45, 280)
        Me.oxPriceTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.oxPriceTextBox.Name = "oxPriceTextBox"
        Me.oxPriceTextBox.PlaceholderText = ""
        Me.oxPriceTextBox.ReadOnly = True
        Me.oxPriceTextBox.SelectedText = ""
        Me.oxPriceTextBox.ShadowDecoration.Enabled = True
        Me.oxPriceTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.oxPriceTextBox.Size = New System.Drawing.Size(230, 50)
        Me.oxPriceTextBox.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 256)
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
        Me.totalPriceTextBox.Enabled = False
        Me.totalPriceTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.totalPriceTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.totalPriceTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.totalPriceTextBox.Location = New System.Drawing.Point(45, 380)
        Me.totalPriceTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.totalPriceTextBox.Name = "totalPriceTextBox"
        Me.totalPriceTextBox.PlaceholderText = ""
        Me.totalPriceTextBox.ReadOnly = True
        Me.totalPriceTextBox.SelectedText = ""
        Me.totalPriceTextBox.ShadowDecoration.Enabled = True
        Me.totalPriceTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.totalPriceTextBox.Size = New System.Drawing.Size(230, 50)
        Me.totalPriceTextBox.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 356)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 26)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "TOTAL PRICE"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 458)
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
        'statusComboBox
        '
        Me.statusComboBox.BackColor = System.Drawing.Color.Transparent
        Me.statusComboBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.statusComboBox.BorderRadius = 5
        Me.statusComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.statusComboBox.FocusedColor = System.Drawing.Color.Black
        Me.statusComboBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.statusComboBox.Font = New System.Drawing.Font("Lato", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.statusComboBox.ForeColor = System.Drawing.Color.Black
        Me.statusComboBox.IntegralHeight = False
        Me.statusComboBox.ItemHeight = 44
        Me.statusComboBox.Items.AddRange(New Object() {"Paid", "Pending", "Partially Paid", "Refunded", "Cancelled"})
        Me.statusComboBox.Location = New System.Drawing.Point(45, 482)
        Me.statusComboBox.Name = "statusComboBox"
        Me.statusComboBox.ShadowDecoration.Enabled = True
        Me.statusComboBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.statusComboBox.Size = New System.Drawing.Size(230, 50)
        Me.statusComboBox.TabIndex = 88
        '
        'downPaymentTextBox
        '
        Me.downPaymentTextBox.BackColor = System.Drawing.Color.Transparent
        Me.downPaymentTextBox.BorderRadius = 5
        Me.downPaymentTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.downPaymentTextBox.DefaultText = ""
        Me.downPaymentTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.downPaymentTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.downPaymentTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.downPaymentTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.downPaymentTextBox.Enabled = False
        Me.downPaymentTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.downPaymentTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.downPaymentTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.downPaymentTextBox.Location = New System.Drawing.Point(295, 280)
        Me.downPaymentTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.downPaymentTextBox.Name = "downPaymentTextBox"
        Me.downPaymentTextBox.PlaceholderText = ""
        Me.downPaymentTextBox.ReadOnly = True
        Me.downPaymentTextBox.SelectedText = ""
        Me.downPaymentTextBox.ShadowDecoration.Enabled = True
        Me.downPaymentTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.downPaymentTextBox.Size = New System.Drawing.Size(230, 50)
        Me.downPaymentTextBox.TabIndex = 90
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(291, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 26)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "DOWN PAYMENT"
        '
        'amountDueTextBox
        '
        Me.amountDueTextBox.BackColor = System.Drawing.Color.Transparent
        Me.amountDueTextBox.BorderRadius = 5
        Me.amountDueTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.amountDueTextBox.DefaultText = ""
        Me.amountDueTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.amountDueTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.amountDueTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.amountDueTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.amountDueTextBox.Enabled = False
        Me.amountDueTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.amountDueTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.amountDueTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.amountDueTextBox.Location = New System.Drawing.Point(295, 380)
        Me.amountDueTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.amountDueTextBox.Name = "amountDueTextBox"
        Me.amountDueTextBox.PlaceholderText = ""
        Me.amountDueTextBox.ReadOnly = True
        Me.amountDueTextBox.SelectedText = ""
        Me.amountDueTextBox.ShadowDecoration.Enabled = True
        Me.amountDueTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.amountDueTextBox.Size = New System.Drawing.Size(230, 50)
        Me.amountDueTextBox.TabIndex = 92
        '
        'Label8
        '
        Me.Label8.CausesValidation = False
        Me.Label8.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(291, 356)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(167, 26)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "AMOUNT DUE"
        '
        'editPaymentDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(571, 790)
        Me.Controls.Add(Me.amountDueTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.downPaymentTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.statusComboBox)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.totalPriceTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.oxPriceTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.paymentMethodTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.bookingIdTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "editPaymentDialog"
        Me.Text = "editPaymentDialog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents bookingIdTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents paymentMethodTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents oxPriceTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents totalPriceTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents editButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents statusComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents downPaymentTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents amountDueTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
End Class
