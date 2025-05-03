<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editExtraDialog
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
        Me.editButton = New Guna.UI2.WinForms.Guna2Button()
        Me.quantityTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.itemTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.priceTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.extrasIdTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        Me.editButton.TabIndex = 79
        Me.editButton.Text = "EDIT"
        '
        'quantityTextBox
        '
        Me.quantityTextBox.BackColor = System.Drawing.Color.Transparent
        Me.quantityTextBox.BorderRadius = 5
        Me.quantityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.quantityTextBox.DefaultText = ""
        Me.quantityTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.quantityTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.quantityTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.quantityTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.quantityTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.quantityTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.quantityTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.quantityTextBox.Location = New System.Drawing.Point(295, 280)
        Me.quantityTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.quantityTextBox.Name = "quantityTextBox"
        Me.quantityTextBox.PlaceholderText = ""
        Me.quantityTextBox.SelectedText = ""
        Me.quantityTextBox.ShadowDecoration.Enabled = True
        Me.quantityTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.quantityTextBox.Size = New System.Drawing.Size(230, 50)
        Me.quantityTextBox.TabIndex = 78
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(291, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 26)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "QUANTITY"
        '
        'itemTextBox
        '
        Me.itemTextBox.BackColor = System.Drawing.Color.Transparent
        Me.itemTextBox.BorderRadius = 5
        Me.itemTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.itemTextBox.DefaultText = ""
        Me.itemTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.itemTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.itemTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.itemTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.itemTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.itemTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.itemTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.itemTextBox.Location = New System.Drawing.Point(295, 180)
        Me.itemTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.itemTextBox.Name = "itemTextBox"
        Me.itemTextBox.PlaceholderText = ""
        Me.itemTextBox.SelectedText = ""
        Me.itemTextBox.ShadowDecoration.Enabled = True
        Me.itemTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.itemTextBox.Size = New System.Drawing.Size(230, 50)
        Me.itemTextBox.TabIndex = 76
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(291, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 26)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "ITEM"
        '
        'priceTextBox
        '
        Me.priceTextBox.BackColor = System.Drawing.Color.Transparent
        Me.priceTextBox.BorderRadius = 5
        Me.priceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.priceTextBox.DefaultText = ""
        Me.priceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.priceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.priceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.priceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.priceTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.priceTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.priceTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.priceTextBox.Location = New System.Drawing.Point(45, 280)
        Me.priceTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.priceTextBox.Name = "priceTextBox"
        Me.priceTextBox.PlaceholderText = ""
        Me.priceTextBox.SelectedText = ""
        Me.priceTextBox.ShadowDecoration.Enabled = True
        Me.priceTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.priceTextBox.Size = New System.Drawing.Size(230, 50)
        Me.priceTextBox.TabIndex = 74
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 26)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "PRICE"
        '
        'extrasIdTextBox
        '
        Me.extrasIdTextBox.BackColor = System.Drawing.Color.Transparent
        Me.extrasIdTextBox.BorderRadius = 5
        Me.extrasIdTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.extrasIdTextBox.DefaultText = ""
        Me.extrasIdTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.extrasIdTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.extrasIdTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.extrasIdTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.extrasIdTextBox.Enabled = False
        Me.extrasIdTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.extrasIdTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.extrasIdTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.extrasIdTextBox.Location = New System.Drawing.Point(45, 180)
        Me.extrasIdTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.extrasIdTextBox.Name = "extrasIdTextBox"
        Me.extrasIdTextBox.PlaceholderText = ""
        Me.extrasIdTextBox.ReadOnly = True
        Me.extrasIdTextBox.SelectedText = ""
        Me.extrasIdTextBox.ShadowDecoration.Enabled = True
        Me.extrasIdTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.extrasIdTextBox.Size = New System.Drawing.Size(230, 50)
        Me.extrasIdTextBox.TabIndex = 72
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 26)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "EXTRAS ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Raleway", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 55)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "EDIT EXTRAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'editExtraDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(571, 790)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.quantityTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.itemTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.priceTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.extrasIdTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "editExtraDialog"
        Me.Text = "editExtraDialog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents editButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents quantityTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents itemTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents priceTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents extrasIdTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
