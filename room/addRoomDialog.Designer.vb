<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addRoomDialog
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
        Me.addButton = New Guna.UI2.WinForms.Guna2Button()
        Me.generalTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.technologyTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.kitchenTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.bathroomTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bedroomTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.statusComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.roomIdTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.capacityTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.rateTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.roomTypeTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.roomNoTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'addButton
        '
        Me.addButton.BackColor = System.Drawing.Color.Transparent
        Me.addButton.BorderRadius = 5
        Me.addButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addButton.FillColor = System.Drawing.Color.Black
        Me.addButton.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.addButton.ForeColor = System.Drawing.Color.White
        Me.addButton.Location = New System.Drawing.Point(225, 704)
        Me.addButton.Name = "addButton"
        Me.addButton.ShadowDecoration.BorderRadius = 5
        Me.addButton.ShadowDecoration.Enabled = True
        Me.addButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.addButton.Size = New System.Drawing.Size(120, 50)
        Me.addButton.TabIndex = 65
        Me.addButton.Text = "ADD"
        '
        'generalTextBox
        '
        Me.generalTextBox.BackColor = System.Drawing.Color.Transparent
        Me.generalTextBox.BorderRadius = 5
        Me.generalTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.generalTextBox.DefaultText = ""
        Me.generalTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.generalTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.generalTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.generalTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.generalTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.generalTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.generalTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.generalTextBox.Location = New System.Drawing.Point(245, 580)
        Me.generalTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.generalTextBox.Name = "generalTextBox"
        Me.generalTextBox.PlaceholderText = ""
        Me.generalTextBox.SelectedText = ""
        Me.generalTextBox.ShadowDecoration.Enabled = True
        Me.generalTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.generalTextBox.Size = New System.Drawing.Size(280, 50)
        Me.generalTextBox.TabIndex = 64
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(241, 556)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(167, 26)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "GENERAL"
        '
        'technologyTextBox
        '
        Me.technologyTextBox.BackColor = System.Drawing.Color.Transparent
        Me.technologyTextBox.BorderRadius = 5
        Me.technologyTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.technologyTextBox.DefaultText = ""
        Me.technologyTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.technologyTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.technologyTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.technologyTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.technologyTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.technologyTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.technologyTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.technologyTextBox.Location = New System.Drawing.Point(245, 480)
        Me.technologyTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.technologyTextBox.Name = "technologyTextBox"
        Me.technologyTextBox.PlaceholderText = ""
        Me.technologyTextBox.SelectedText = ""
        Me.technologyTextBox.ShadowDecoration.Enabled = True
        Me.technologyTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.technologyTextBox.Size = New System.Drawing.Size(280, 50)
        Me.technologyTextBox.TabIndex = 62
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(241, 456)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(167, 26)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "TECHNOLOGY"
        '
        'kitchenTextBox
        '
        Me.kitchenTextBox.BackColor = System.Drawing.Color.Transparent
        Me.kitchenTextBox.BorderRadius = 5
        Me.kitchenTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kitchenTextBox.DefaultText = ""
        Me.kitchenTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.kitchenTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.kitchenTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.kitchenTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.kitchenTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.kitchenTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.kitchenTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.kitchenTextBox.Location = New System.Drawing.Point(245, 380)
        Me.kitchenTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.kitchenTextBox.Name = "kitchenTextBox"
        Me.kitchenTextBox.PlaceholderText = ""
        Me.kitchenTextBox.SelectedText = ""
        Me.kitchenTextBox.ShadowDecoration.Enabled = True
        Me.kitchenTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.kitchenTextBox.Size = New System.Drawing.Size(280, 50)
        Me.kitchenTextBox.TabIndex = 60
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(241, 356)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(167, 26)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "KITCHEN"
        '
        'bathroomTextBox
        '
        Me.bathroomTextBox.BackColor = System.Drawing.Color.Transparent
        Me.bathroomTextBox.BorderRadius = 5
        Me.bathroomTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bathroomTextBox.DefaultText = ""
        Me.bathroomTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.bathroomTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.bathroomTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.bathroomTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.bathroomTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.bathroomTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.bathroomTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.bathroomTextBox.Location = New System.Drawing.Point(245, 286)
        Me.bathroomTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.bathroomTextBox.Name = "bathroomTextBox"
        Me.bathroomTextBox.PlaceholderText = ""
        Me.bathroomTextBox.SelectedText = ""
        Me.bathroomTextBox.ShadowDecoration.Enabled = True
        Me.bathroomTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.bathroomTextBox.Size = New System.Drawing.Size(280, 50)
        Me.bathroomTextBox.TabIndex = 58
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(241, 262)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(167, 26)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "BATHROOM"
        '
        'bedroomTextBox
        '
        Me.bedroomTextBox.BackColor = System.Drawing.Color.Transparent
        Me.bedroomTextBox.BorderRadius = 5
        Me.bedroomTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bedroomTextBox.DefaultText = ""
        Me.bedroomTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.bedroomTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.bedroomTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.bedroomTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.bedroomTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.bedroomTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.bedroomTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.bedroomTextBox.Location = New System.Drawing.Point(245, 180)
        Me.bedroomTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.bedroomTextBox.Name = "bedroomTextBox"
        Me.bedroomTextBox.PlaceholderText = ""
        Me.bedroomTextBox.SelectedText = ""
        Me.bedroomTextBox.ShadowDecoration.Enabled = True
        Me.bedroomTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.bedroomTextBox.Size = New System.Drawing.Size(280, 50)
        Me.bedroomTextBox.TabIndex = 56
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(241, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 26)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "BEDROOM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Raleway", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(165, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 55)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "ADD ROOM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.statusComboBox.Location = New System.Drawing.Point(45, 580)
        Me.statusComboBox.Name = "statusComboBox"
        Me.statusComboBox.ShadowDecoration.Enabled = True
        Me.statusComboBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.statusComboBox.Size = New System.Drawing.Size(180, 50)
        Me.statusComboBox.TabIndex = 98
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(41, 556)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(167, 26)
        Me.Label12.TabIndex = 97
        Me.Label12.Text = "STATUS"
        '
        'roomIdTextBox
        '
        Me.roomIdTextBox.BackColor = System.Drawing.Color.Transparent
        Me.roomIdTextBox.BorderRadius = 5
        Me.roomIdTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.roomIdTextBox.DefaultText = ""
        Me.roomIdTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.roomIdTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.roomIdTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.roomIdTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.roomIdTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.roomIdTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.roomIdTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.roomIdTextBox.Location = New System.Drawing.Point(45, 180)
        Me.roomIdTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.roomIdTextBox.Name = "roomIdTextBox"
        Me.roomIdTextBox.PlaceholderText = ""
        Me.roomIdTextBox.SelectedText = ""
        Me.roomIdTextBox.ShadowDecoration.Enabled = True
        Me.roomIdTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.roomIdTextBox.Size = New System.Drawing.Size(180, 50)
        Me.roomIdTextBox.TabIndex = 88
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 20)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "ROOM ID"
        '
        'capacityTextBox
        '
        Me.capacityTextBox.BackColor = System.Drawing.Color.Transparent
        Me.capacityTextBox.BorderRadius = 5
        Me.capacityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.capacityTextBox.DefaultText = ""
        Me.capacityTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.capacityTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.capacityTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.capacityTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.capacityTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.capacityTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.capacityTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.capacityTextBox.Location = New System.Drawing.Point(45, 500)
        Me.capacityTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.capacityTextBox.Name = "capacityTextBox"
        Me.capacityTextBox.PlaceholderText = ""
        Me.capacityTextBox.SelectedText = ""
        Me.capacityTextBox.ShadowDecoration.Enabled = True
        Me.capacityTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.capacityTextBox.Size = New System.Drawing.Size(180, 50)
        Me.capacityTextBox.TabIndex = 96
        '
        'rateTextBox
        '
        Me.rateTextBox.BackColor = System.Drawing.Color.Transparent
        Me.rateTextBox.BorderRadius = 5
        Me.rateTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.rateTextBox.DefaultText = ""
        Me.rateTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.rateTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.rateTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.rateTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.rateTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.rateTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.rateTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.rateTextBox.Location = New System.Drawing.Point(45, 420)
        Me.rateTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.rateTextBox.Name = "rateTextBox"
        Me.rateTextBox.PlaceholderText = ""
        Me.rateTextBox.SelectedText = ""
        Me.rateTextBox.ShadowDecoration.Enabled = True
        Me.rateTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.rateTextBox.Size = New System.Drawing.Size(180, 50)
        Me.rateTextBox.TabIndex = 94
        '
        'roomTypeTextBox
        '
        Me.roomTypeTextBox.BackColor = System.Drawing.Color.Transparent
        Me.roomTypeTextBox.BorderRadius = 5
        Me.roomTypeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.roomTypeTextBox.DefaultText = ""
        Me.roomTypeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.roomTypeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.roomTypeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.roomTypeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.roomTypeTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.roomTypeTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.roomTypeTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.roomTypeTextBox.Location = New System.Drawing.Point(45, 340)
        Me.roomTypeTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.roomTypeTextBox.Name = "roomTypeTextBox"
        Me.roomTypeTextBox.PlaceholderText = ""
        Me.roomTypeTextBox.SelectedText = ""
        Me.roomTypeTextBox.ShadowDecoration.Enabled = True
        Me.roomTypeTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.roomTypeTextBox.Size = New System.Drawing.Size(180, 50)
        Me.roomTypeTextBox.TabIndex = 92
        '
        'roomNoTextBox
        '
        Me.roomNoTextBox.BackColor = System.Drawing.Color.Transparent
        Me.roomNoTextBox.BorderRadius = 5
        Me.roomNoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.roomNoTextBox.DefaultText = ""
        Me.roomNoTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.roomNoTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.roomNoTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.roomNoTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.roomNoTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.roomNoTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.roomNoTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.roomNoTextBox.Location = New System.Drawing.Point(45, 260)
        Me.roomNoTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.roomNoTextBox.Name = "roomNoTextBox"
        Me.roomNoTextBox.PlaceholderText = ""
        Me.roomNoTextBox.SelectedText = ""
        Me.roomNoTextBox.ShadowDecoration.Enabled = True
        Me.roomNoTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.roomNoTextBox.Size = New System.Drawing.Size(180, 50)
        Me.roomNoTextBox.TabIndex = 90
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 476)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 26)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "CAPACITY"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 396)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 26)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "RATE"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 26)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "ROOM TYPE"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Raleway", 16.48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 26)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "ROOM NUMBER"
        '
        'addRoomDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(571, 790)
        Me.Controls.Add(Me.statusComboBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.roomIdTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.capacityTextBox)
        Me.Controls.Add(Me.rateTextBox)
        Me.Controls.Add(Me.roomTypeTextBox)
        Me.Controls.Add(Me.roomNoTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.generalTextBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.technologyTextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.kitchenTextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.bathroomTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.bedroomTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addRoomDialog"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents addButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents generalTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents technologyTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents kitchenTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents bathroomTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents bedroomTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents statusComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents roomIdTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents capacityTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents rateTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents roomTypeTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents roomNoTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
