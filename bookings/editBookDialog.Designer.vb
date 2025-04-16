<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editBookDialog
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
        Me.logInButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.phoneNoTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.emailTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lastNameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.firstNameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bookingIdTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.outTimeComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.inTimeComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.outDatePickerButton = New Guna.UI2.WinForms.Guna2Button()
        Me.inDatePickerButton = New Guna.UI2.WinForms.Guna2Button()
        Me.paxComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.roomNoComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.roomNameComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.SuspendLayout()
        '
        'logInButton
        '
        Me.logInButton.BackColor = System.Drawing.Color.Transparent
        Me.logInButton.BorderRadius = 5
        Me.logInButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logInButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.logInButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.logInButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.logInButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.logInButton.FillColor = System.Drawing.Color.Black
        Me.logInButton.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.logInButton.ForeColor = System.Drawing.Color.White
        Me.logInButton.Location = New System.Drawing.Point(225, 704)
        Me.logInButton.Name = "logInButton"
        Me.logInButton.ShadowDecoration.BorderRadius = 5
        Me.logInButton.ShadowDecoration.Enabled = True
        Me.logInButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.logInButton.Size = New System.Drawing.Size(120, 50)
        Me.logInButton.TabIndex = 82
        Me.logInButton.Text = "EDIT"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Raleway Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(391, 556)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(134, 26)
        Me.Label14.TabIndex = 80
        Me.Label14.Text = "TIME"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Raleway Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(242, 556)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(134, 26)
        Me.Label15.TabIndex = 78
        Me.Label15.Text = "DATE"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(242, 511)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(134, 26)
        Me.Label13.TabIndex = 77
        Me.Label13.Text = "CHECK-OUT"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Raleway Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(391, 406)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(134, 26)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "TIME"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Raleway Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(242, 406)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 26)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "DATE"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(242, 356)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 26)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "CHECK-IN"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(391, 256)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 26)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "ROOM NO."
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(241, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 26)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "PAX"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(241, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 26)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "ROOM NAME"
        '
        'phoneNoTextBox
        '
        Me.phoneNoTextBox.BackColor = System.Drawing.Color.Transparent
        Me.phoneNoTextBox.BorderRadius = 5
        Me.phoneNoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.phoneNoTextBox.DefaultText = ""
        Me.phoneNoTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.phoneNoTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.phoneNoTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.phoneNoTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.phoneNoTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.phoneNoTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.phoneNoTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.phoneNoTextBox.Location = New System.Drawing.Point(45, 580)
        Me.phoneNoTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.phoneNoTextBox.Name = "phoneNoTextBox"
        Me.phoneNoTextBox.PlaceholderText = ""
        Me.phoneNoTextBox.SelectedText = ""
        Me.phoneNoTextBox.ShadowDecoration.Enabled = True
        Me.phoneNoTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.phoneNoTextBox.Size = New System.Drawing.Size(180, 50)
        Me.phoneNoTextBox.TabIndex = 65
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 556)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 26)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "PHONE NO. (PH)"
        '
        'emailTextBox
        '
        Me.emailTextBox.BackColor = System.Drawing.Color.Transparent
        Me.emailTextBox.BorderRadius = 5
        Me.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.emailTextBox.DefaultText = ""
        Me.emailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.emailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.emailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.emailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.emailTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.emailTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.emailTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.emailTextBox.Location = New System.Drawing.Point(45, 480)
        Me.emailTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.PlaceholderText = ""
        Me.emailTextBox.SelectedText = ""
        Me.emailTextBox.ShadowDecoration.Enabled = True
        Me.emailTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.emailTextBox.Size = New System.Drawing.Size(180, 50)
        Me.emailTextBox.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 456)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 26)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "EMAIL"
        '
        'lastNameTextBox
        '
        Me.lastNameTextBox.BackColor = System.Drawing.Color.Transparent
        Me.lastNameTextBox.BorderRadius = 5
        Me.lastNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lastNameTextBox.DefaultText = ""
        Me.lastNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lastNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lastNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lastNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lastNameTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.lastNameTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lastNameTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.lastNameTextBox.Location = New System.Drawing.Point(45, 380)
        Me.lastNameTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.lastNameTextBox.Name = "lastNameTextBox"
        Me.lastNameTextBox.PlaceholderText = ""
        Me.lastNameTextBox.SelectedText = ""
        Me.lastNameTextBox.ShadowDecoration.Enabled = True
        Me.lastNameTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.lastNameTextBox.Size = New System.Drawing.Size(180, 50)
        Me.lastNameTextBox.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 26)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "LAST NAME"
        '
        'firstNameTextBox
        '
        Me.firstNameTextBox.BackColor = System.Drawing.Color.Transparent
        Me.firstNameTextBox.BorderRadius = 5
        Me.firstNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.firstNameTextBox.DefaultText = ""
        Me.firstNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.firstNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.firstNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.firstNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.firstNameTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.firstNameTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.firstNameTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.firstNameTextBox.Location = New System.Drawing.Point(45, 280)
        Me.firstNameTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.firstNameTextBox.Name = "firstNameTextBox"
        Me.firstNameTextBox.PlaceholderText = ""
        Me.firstNameTextBox.SelectedText = ""
        Me.firstNameTextBox.ShadowDecoration.Enabled = True
        Me.firstNameTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.firstNameTextBox.Size = New System.Drawing.Size(180, 50)
        Me.firstNameTextBox.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 26)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "FIRST NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Raleway", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(132, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 55)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "EDIT BOOKING"
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
        Me.bookingIdTextBox.Size = New System.Drawing.Size(180, 50)
        Me.bookingIdTextBox.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 26)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "BOOKING ID"
        '
        'outTimeComboBox
        '
        Me.outTimeComboBox.BackColor = System.Drawing.Color.Transparent
        Me.outTimeComboBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.outTimeComboBox.BorderRadius = 5
        Me.outTimeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.outTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.outTimeComboBox.FocusedColor = System.Drawing.Color.Black
        Me.outTimeComboBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.outTimeComboBox.Font = New System.Drawing.Font("Lato", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.outTimeComboBox.ForeColor = System.Drawing.Color.Black
        Me.outTimeComboBox.IntegralHeight = False
        Me.outTimeComboBox.ItemHeight = 44
        Me.outTimeComboBox.Items.AddRange(New Object() {"12:00 AM  ", "01:00 AM  ", "02:00 AM  ", "03:00 AM  ", "04:00 AM  ", "05:00 AM  ", "06:00 AM  ", "07:00 AM  ", "08:00 AM  ", "09:00 AM  ", "10:00 AM  ", "11:00 AM  ", "12:00 PM  ", "01:00 PM  ", "02:00 PM  ", "03:00 PM  ", "04:00 PM  ", "05:00 PM  ", "06:00 PM  ", "07:00 PM  ", "08:00 PM  ", "09:00 PM  ", "10:00 PM  ", "11:00 PM"})
        Me.outTimeComboBox.Location = New System.Drawing.Point(395, 580)
        Me.outTimeComboBox.Name = "outTimeComboBox"
        Me.outTimeComboBox.ShadowDecoration.Enabled = True
        Me.outTimeComboBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.outTimeComboBox.Size = New System.Drawing.Size(130, 50)
        Me.outTimeComboBox.TabIndex = 86
        '
        'inTimeComboBox
        '
        Me.inTimeComboBox.BackColor = System.Drawing.Color.Transparent
        Me.inTimeComboBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.inTimeComboBox.BorderRadius = 5
        Me.inTimeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.inTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.inTimeComboBox.FocusedColor = System.Drawing.Color.Black
        Me.inTimeComboBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.inTimeComboBox.Font = New System.Drawing.Font("Lato", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.inTimeComboBox.ForeColor = System.Drawing.Color.Black
        Me.inTimeComboBox.IntegralHeight = False
        Me.inTimeComboBox.ItemHeight = 44
        Me.inTimeComboBox.Items.AddRange(New Object() {"12:00 AM  ", "01:00 AM  ", "02:00 AM  ", "03:00 AM  ", "04:00 AM  ", "05:00 AM  ", "06:00 AM  ", "07:00 AM  ", "08:00 AM  ", "09:00 AM  ", "10:00 AM  ", "11:00 AM  ", "12:00 PM  ", "01:00 PM  ", "02:00 PM  ", "03:00 PM  ", "04:00 PM  ", "05:00 PM  ", "06:00 PM  ", "07:00 PM  ", "08:00 PM  ", "09:00 PM  ", "10:00 PM  ", "11:00 PM"})
        Me.inTimeComboBox.Location = New System.Drawing.Point(395, 430)
        Me.inTimeComboBox.Name = "inTimeComboBox"
        Me.inTimeComboBox.ShadowDecoration.Enabled = True
        Me.inTimeComboBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.inTimeComboBox.Size = New System.Drawing.Size(130, 50)
        Me.inTimeComboBox.TabIndex = 85
        '
        'outDatePickerButton
        '
        Me.outDatePickerButton.BackColor = System.Drawing.Color.Transparent
        Me.outDatePickerButton.BorderRadius = 5
        Me.outDatePickerButton.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.outDatePickerButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.outDatePickerButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.outDatePickerButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.outDatePickerButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.outDatePickerButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.outDatePickerButton.FillColor = System.Drawing.Color.White
        Me.outDatePickerButton.FocusedColor = System.Drawing.Color.Black
        Me.outDatePickerButton.Font = New System.Drawing.Font("Lato", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.outDatePickerButton.ForeColor = System.Drawing.Color.Black
        Me.outDatePickerButton.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.outDatePickerButton.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.outDatePickerButton.Location = New System.Drawing.Point(246, 580)
        Me.outDatePickerButton.Name = "outDatePickerButton"
        Me.outDatePickerButton.ShadowDecoration.Enabled = True
        Me.outDatePickerButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.outDatePickerButton.Size = New System.Drawing.Size(129, 50)
        Me.outDatePickerButton.TabIndex = 84
        Me.outDatePickerButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'inDatePickerButton
        '
        Me.inDatePickerButton.BackColor = System.Drawing.Color.Transparent
        Me.inDatePickerButton.BorderRadius = 5
        Me.inDatePickerButton.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.inDatePickerButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.inDatePickerButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.inDatePickerButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.inDatePickerButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.inDatePickerButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.inDatePickerButton.FillColor = System.Drawing.Color.White
        Me.inDatePickerButton.FocusedColor = System.Drawing.Color.Black
        Me.inDatePickerButton.Font = New System.Drawing.Font("Lato", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.inDatePickerButton.ForeColor = System.Drawing.Color.Black
        Me.inDatePickerButton.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.inDatePickerButton.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.inDatePickerButton.Location = New System.Drawing.Point(246, 430)
        Me.inDatePickerButton.Name = "inDatePickerButton"
        Me.inDatePickerButton.ShadowDecoration.Enabled = True
        Me.inDatePickerButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.inDatePickerButton.Size = New System.Drawing.Size(129, 50)
        Me.inDatePickerButton.TabIndex = 83
        Me.inDatePickerButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'paxComboBox
        '
        Me.paxComboBox.BackColor = System.Drawing.Color.Transparent
        Me.paxComboBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.paxComboBox.BorderRadius = 5
        Me.paxComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.paxComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.paxComboBox.FocusedColor = System.Drawing.Color.Black
        Me.paxComboBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.paxComboBox.Font = New System.Drawing.Font("Lato", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.paxComboBox.ForeColor = System.Drawing.Color.Black
        Me.paxComboBox.IntegralHeight = False
        Me.paxComboBox.ItemHeight = 44
        Me.paxComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.paxComboBox.Location = New System.Drawing.Point(246, 280)
        Me.paxComboBox.Name = "paxComboBox"
        Me.paxComboBox.ShadowDecoration.Enabled = True
        Me.paxComboBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.paxComboBox.Size = New System.Drawing.Size(130, 50)
        Me.paxComboBox.TabIndex = 87
        '
        'roomNoComboBox
        '
        Me.roomNoComboBox.BackColor = System.Drawing.Color.Transparent
        Me.roomNoComboBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.roomNoComboBox.BorderRadius = 5
        Me.roomNoComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.roomNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.roomNoComboBox.FocusedColor = System.Drawing.Color.Black
        Me.roomNoComboBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.roomNoComboBox.Font = New System.Drawing.Font("Lato", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.roomNoComboBox.ForeColor = System.Drawing.Color.Black
        Me.roomNoComboBox.IntegralHeight = False
        Me.roomNoComboBox.ItemHeight = 44
        Me.roomNoComboBox.Location = New System.Drawing.Point(395, 280)
        Me.roomNoComboBox.Name = "roomNoComboBox"
        Me.roomNoComboBox.ShadowDecoration.Enabled = True
        Me.roomNoComboBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.roomNoComboBox.Size = New System.Drawing.Size(130, 50)
        Me.roomNoComboBox.TabIndex = 88
        '
        'roomNameComboBox
        '
        Me.roomNameComboBox.BackColor = System.Drawing.Color.Transparent
        Me.roomNameComboBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.roomNameComboBox.BorderRadius = 5
        Me.roomNameComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.roomNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.roomNameComboBox.FocusedColor = System.Drawing.Color.Black
        Me.roomNameComboBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.roomNameComboBox.Font = New System.Drawing.Font("Lato", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.roomNameComboBox.ForeColor = System.Drawing.Color.Black
        Me.roomNameComboBox.IntegralHeight = False
        Me.roomNameComboBox.ItemHeight = 44
        Me.roomNameComboBox.Items.AddRange(New Object() {"Single", "Double", "Suite", "Family", "Deluxe", "King", "Queen", "Studio", "Penthouse", "Presedential Suite"})
        Me.roomNameComboBox.Location = New System.Drawing.Point(246, 180)
        Me.roomNameComboBox.Name = "roomNameComboBox"
        Me.roomNameComboBox.ShadowDecoration.Enabled = True
        Me.roomNameComboBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.roomNameComboBox.Size = New System.Drawing.Size(279, 50)
        Me.roomNameComboBox.TabIndex = 89
        '
        'editBookDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(571, 790)
        Me.Controls.Add(Me.roomNameComboBox)
        Me.Controls.Add(Me.roomNoComboBox)
        Me.Controls.Add(Me.paxComboBox)
        Me.Controls.Add(Me.outTimeComboBox)
        Me.Controls.Add(Me.inTimeComboBox)
        Me.Controls.Add(Me.outDatePickerButton)
        Me.Controls.Add(Me.inDatePickerButton)
        Me.Controls.Add(Me.logInButton)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.phoneNoTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.emailTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lastNameTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.firstNameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bookingIdTextBox)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "editBookDialog"
        Me.Text = "editBookDialog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents logInButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents phoneNoTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents emailTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lastNameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents firstNameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bookingIdTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents outTimeComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents inTimeComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents outDatePickerButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents inDatePickerButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents paxComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents roomNoComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents roomNameComboBox As Guna.UI2.WinForms.Guna2ComboBox
End Class
