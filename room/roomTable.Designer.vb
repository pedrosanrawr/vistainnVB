Imports Guna.UI2.WinForms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class roomTable
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(roomTable))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.menuButton = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.refreshButton = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.menuTimer = New System.Windows.Forms.Timer(Me.components)
        Me.addRoomButton = New Guna.UI2.WinForms.Guna2Button()
        Me.editRoomButton = New Guna.UI2.WinForms.Guna2Button()
        Me.roomPhotosButton = New Guna.UI2.WinForms.Guna2Button()
        Me.searchRoomTextbox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.roomDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.roomId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roomName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roomNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roomPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roomCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roomBedroom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roomBathroom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roomTechnology = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roomKitchen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roomGeneral = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roomStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dialogTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.menuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.refreshButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.roomDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuButton
        '
        Me.menuButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuButton.Image = CType(resources.GetObject("menuButton.Image"), System.Drawing.Image)
        Me.menuButton.Location = New System.Drawing.Point(31, 20)
        Me.menuButton.Name = "menuButton"
        Me.menuButton.Size = New System.Drawing.Size(50, 50)
        Me.menuButton.TabIndex = 5
        Me.menuButton.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Raleway", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(882, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 22)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "TABLE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Raleway", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(888, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 34)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ROOMS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1061, 20)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'refreshButton
        '
        Me.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refreshButton.Image = CType(resources.GetObject("refreshButton.Image"), System.Drawing.Image)
        Me.refreshButton.Location = New System.Drawing.Point(111, 20)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(50, 50)
        Me.refreshButton.TabIndex = 6
        Me.refreshButton.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 5
        '
        'menuTimer
        '
        Me.menuTimer.Interval = 5
        '
        'addRoomButton
        '
        Me.addRoomButton.BackColor = System.Drawing.Color.Transparent
        Me.addRoomButton.BorderRadius = 5
        Me.addRoomButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addRoomButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addRoomButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addRoomButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addRoomButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addRoomButton.FillColor = System.Drawing.Color.Black
        Me.addRoomButton.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.addRoomButton.ForeColor = System.Drawing.Color.White
        Me.addRoomButton.Location = New System.Drawing.Point(31, 105)
        Me.addRoomButton.Name = "addRoomButton"
        Me.addRoomButton.ShadowDecoration.BorderRadius = 5
        Me.addRoomButton.ShadowDecoration.Enabled = True
        Me.addRoomButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.addRoomButton.Size = New System.Drawing.Size(130, 50)
        Me.addRoomButton.TabIndex = 10
        Me.addRoomButton.Text = "ADD"
        '
        'editRoomButton
        '
        Me.editRoomButton.BackColor = System.Drawing.Color.Transparent
        Me.editRoomButton.BorderRadius = 5
        Me.editRoomButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editRoomButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.editRoomButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.editRoomButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.editRoomButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.editRoomButton.FillColor = System.Drawing.Color.Black
        Me.editRoomButton.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.editRoomButton.ForeColor = System.Drawing.Color.White
        Me.editRoomButton.Location = New System.Drawing.Point(181, 105)
        Me.editRoomButton.Name = "editRoomButton"
        Me.editRoomButton.ShadowDecoration.BorderRadius = 5
        Me.editRoomButton.ShadowDecoration.Enabled = True
        Me.editRoomButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.editRoomButton.Size = New System.Drawing.Size(130, 50)
        Me.editRoomButton.TabIndex = 11
        Me.editRoomButton.Text = "EDIT"
        '
        'roomPhotosButton
        '
        Me.roomPhotosButton.BackColor = System.Drawing.Color.Transparent
        Me.roomPhotosButton.BorderRadius = 5
        Me.roomPhotosButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.roomPhotosButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.roomPhotosButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.roomPhotosButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.roomPhotosButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.roomPhotosButton.FillColor = System.Drawing.Color.Black
        Me.roomPhotosButton.Font = New System.Drawing.Font("Raleway", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.roomPhotosButton.ForeColor = System.Drawing.Color.White
        Me.roomPhotosButton.Location = New System.Drawing.Point(331, 105)
        Me.roomPhotosButton.Name = "roomPhotosButton"
        Me.roomPhotosButton.ShadowDecoration.BorderRadius = 5
        Me.roomPhotosButton.ShadowDecoration.Enabled = True
        Me.roomPhotosButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.roomPhotosButton.Size = New System.Drawing.Size(180, 50)
        Me.roomPhotosButton.TabIndex = 13
        Me.roomPhotosButton.Text = "ROOM PHOTOS"
        '
        'searchRoomTextbox
        '
        Me.searchRoomTextbox.BackColor = System.Drawing.Color.Transparent
        Me.searchRoomTextbox.BorderRadius = 5
        Me.searchRoomTextbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.searchRoomTextbox.DefaultText = ""
        Me.searchRoomTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.searchRoomTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.searchRoomTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchRoomTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchRoomTextbox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.searchRoomTextbox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.searchRoomTextbox.ForeColor = System.Drawing.Color.Black
        Me.searchRoomTextbox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.searchRoomTextbox.Location = New System.Drawing.Point(681, 105)
        Me.searchRoomTextbox.Margin = New System.Windows.Forms.Padding(6)
        Me.searchRoomTextbox.Name = "searchRoomTextbox"
        Me.searchRoomTextbox.PlaceholderText = "Search"
        Me.searchRoomTextbox.SelectedText = ""
        Me.searchRoomTextbox.ShadowDecoration.BorderRadius = 5
        Me.searchRoomTextbox.ShadowDecoration.Enabled = True
        Me.searchRoomTextbox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.searchRoomTextbox.Size = New System.Drawing.Size(430, 50)
        Me.searchRoomTextbox.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1071, 115)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 5
        Me.Guna2Panel1.Controls.Add(Me.roomDGV)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(31, 185)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.BorderRadius = 5
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.Guna2Panel1.Size = New System.Drawing.Size(1080, 570)
        Me.Guna2Panel1.TabIndex = 16
        '
        'roomDGV
        '
        Me.roomDGV.AllowUserToAddRows = False
        Me.roomDGV.AllowUserToDeleteRows = False
        Me.roomDGV.AllowUserToResizeColumns = False
        Me.roomDGV.AllowUserToResizeRows = False
        Me.roomDGV.AlternatingRowsDefaultCellStyle = Me.roomDGV.DefaultCellStyle
        Me.roomDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
        Me.roomDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.roomDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.roomDGV.ColumnHeadersHeight = 40
        Me.roomDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.roomId, Me.roomName, Me.roomNo, Me.roomPrice, Me.roomCategory, Me.roomBedroom, Me.roomBathroom, Me.roomTechnology, Me.roomKitchen, Me.roomGeneral, Me.roomStatus})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.roomDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.roomDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.roomDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.roomDGV.Location = New System.Drawing.Point(0, 0)
        Me.roomDGV.Name = "roomDGV"
        Me.roomDGV.ReadOnly = True
        Me.roomDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.roomDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.roomDGV.RowHeadersVisible = False
        Me.roomDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.roomDGV.RowTemplate.Height = 40
        Me.roomDGV.RowTemplate.ReadOnly = True
        Me.roomDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.roomDGV.Size = New System.Drawing.Size(1080, 570)
        Me.roomDGV.TabIndex = 0
        Me.roomDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.roomDGV.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.roomDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Gray
        Me.roomDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.roomDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.roomDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.roomDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black
        Me.roomDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.roomDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.roomDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.roomDGV.ThemeStyle.HeaderStyle.Height = 40
        Me.roomDGV.ThemeStyle.ReadOnly = True
        Me.roomDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.roomDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.roomDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.roomDGV.ThemeStyle.RowsStyle.Height = 40
        Me.roomDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray
        Me.roomDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'roomId
        '
        Me.roomId.DataPropertyName = "rId"
        Me.roomId.HeaderText = "ID"
        Me.roomId.Name = "roomId"
        Me.roomId.ReadOnly = True
        Me.roomId.Width = 50
        '
        'roomName
        '
        Me.roomName.DataPropertyName = "rName"
        Me.roomName.HeaderText = "NAME"
        Me.roomName.Name = "roomName"
        Me.roomName.ReadOnly = True
        Me.roomName.Width = 85
        '
        'roomNo
        '
        Me.roomNo.DataPropertyName = "rRoomNo"
        Me.roomNo.HeaderText = "ROOM NO"
        Me.roomNo.Name = "roomNo"
        Me.roomNo.ReadOnly = True
        Me.roomNo.Width = 110
        '
        'roomPrice
        '
        Me.roomPrice.DataPropertyName = "rPrice"
        Me.roomPrice.HeaderText = "PRICE"
        Me.roomPrice.Name = "roomPrice"
        Me.roomPrice.ReadOnly = True
        Me.roomPrice.Width = 85
        '
        'roomCategory
        '
        Me.roomCategory.DataPropertyName = "rCategory"
        Me.roomCategory.HeaderText = "CATEGORY"
        Me.roomCategory.Name = "roomCategory"
        Me.roomCategory.ReadOnly = True
        Me.roomCategory.Width = 110
        '
        'roomBedroom
        '
        Me.roomBedroom.DataPropertyName = "rBedroom"
        Me.roomBedroom.HeaderText = "BEDROOM"
        Me.roomBedroom.Name = "roomBedroom"
        Me.roomBedroom.ReadOnly = True
        Me.roomBedroom.Width = 110
        '
        'roomBathroom
        '
        Me.roomBathroom.DataPropertyName = "rBathroom"
        Me.roomBathroom.HeaderText = "BATHROOM"
        Me.roomBathroom.Name = "roomBathroom"
        Me.roomBathroom.ReadOnly = True
        Me.roomBathroom.Width = 110
        '
        'roomTechnology
        '
        Me.roomTechnology.DataPropertyName = "rTechnology"
        Me.roomTechnology.HeaderText = "TECHNOLOGY"
        Me.roomTechnology.Name = "roomTechnology"
        Me.roomTechnology.ReadOnly = True
        Me.roomTechnology.Width = 130
        '
        'roomKitchen
        '
        Me.roomKitchen.DataPropertyName = "rKitchen"
        Me.roomKitchen.HeaderText = "KITCHEN"
        Me.roomKitchen.Name = "roomKitchen"
        Me.roomKitchen.ReadOnly = True
        Me.roomKitchen.Width = 110
        '
        'roomGeneral
        '
        Me.roomGeneral.DataPropertyName = "rGeneral"
        Me.roomGeneral.HeaderText = "GENERAL"
        Me.roomGeneral.Name = "roomGeneral"
        Me.roomGeneral.ReadOnly = True
        Me.roomGeneral.Width = 110
        '
        'roomStatus
        '
        Me.roomStatus.DataPropertyName = "rStatus"
        Me.roomStatus.HeaderText = "STATUS"
        Me.roomStatus.Name = "roomStatus"
        Me.roomStatus.ReadOnly = True
        Me.roomStatus.Width = 110
        '
        'dialogTimer
        '
        Me.dialogTimer.Interval = 3
        '
        'roomTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1142, 790)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.searchRoomTextbox)
        Me.Controls.Add(Me.roomPhotosButton)
        Me.Controls.Add(Me.editRoomButton)
        Me.Controls.Add(Me.addRoomButton)
        Me.Controls.Add(Me.menuButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.refreshButton)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "roomTable"
        Me.Text = "N"
        CType(Me.menuButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.refreshButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.roomDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents menuButton As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents refreshButton As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents menuTimer As Timer
    Friend WithEvents addRoomButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents editRoomButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents roomPhotosButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents searchRoomTextbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dialogTimer As Timer
    Friend WithEvents roomDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2DataGridViewStyler1 As Guna.UI2.WinForms.Guna2DataGridViewStyler
    Friend WithEvents Guna2DataGridViewStyler2 As Guna.UI2.WinForms.Guna2DataGridViewStyler
    Friend WithEvents roomId As DataGridViewTextBoxColumn
    Friend WithEvents roomName As DataGridViewTextBoxColumn
    Friend WithEvents roomNo As DataGridViewTextBoxColumn
    Friend WithEvents roomPrice As DataGridViewTextBoxColumn
    Friend WithEvents roomCategory As DataGridViewTextBoxColumn
    Friend WithEvents roomBedroom As DataGridViewTextBoxColumn
    Friend WithEvents roomBathroom As DataGridViewTextBoxColumn
    Friend WithEvents roomTechnology As DataGridViewTextBoxColumn
    Friend WithEvents roomKitchen As DataGridViewTextBoxColumn
    Friend WithEvents roomGeneral As DataGridViewTextBoxColumn
    Friend WithEvents roomStatus As DataGridViewTextBoxColumn
End Class
