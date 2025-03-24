<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bookingTable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bookingTable))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.menuButton = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.refreshBookButton = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.menuTimer = New System.Windows.Forms.Timer(Me.components)
        Me.addBookButton = New Guna.UI2.WinForms.Guna2Button()
        Me.editBookButton = New Guna.UI2.WinForms.Guna2Button()
        Me.deleteBookButton = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.searchBookTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dialogTimer = New System.Windows.Forms.Timer(Me.components)
        Me.bookDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.bookingId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bookFname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bookLname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bookEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bookPhoneNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bookRoomName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bookRoomNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bookPax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bookCheckInDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bookCheckInTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bookCheckOutdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bookCheckOutTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.menuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.refreshBookButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.bookDGV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Text = "BOOKINGS"
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
        'refreshBookButton
        '
        Me.refreshBookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.refreshBookButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refreshBookButton.Image = CType(resources.GetObject("refreshBookButton.Image"), System.Drawing.Image)
        Me.refreshBookButton.Location = New System.Drawing.Point(111, 20)
        Me.refreshBookButton.Name = "refreshBookButton"
        Me.refreshBookButton.Size = New System.Drawing.Size(50, 50)
        Me.refreshBookButton.TabIndex = 6
        Me.refreshBookButton.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 5
        '
        'menuTimer
        '
        Me.menuTimer.Interval = 5
        '
        'addBookButton
        '
        Me.addBookButton.BackColor = System.Drawing.Color.Transparent
        Me.addBookButton.BorderRadius = 5
        Me.addBookButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addBookButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addBookButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addBookButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addBookButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addBookButton.FillColor = System.Drawing.Color.Black
        Me.addBookButton.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.addBookButton.ForeColor = System.Drawing.Color.White
        Me.addBookButton.Location = New System.Drawing.Point(31, 105)
        Me.addBookButton.Name = "addBookButton"
        Me.addBookButton.ShadowDecoration.BorderRadius = 5
        Me.addBookButton.ShadowDecoration.Enabled = True
        Me.addBookButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.addBookButton.Size = New System.Drawing.Size(130, 50)
        Me.addBookButton.TabIndex = 11
        Me.addBookButton.Text = "ADD"
        '
        'editBookButton
        '
        Me.editBookButton.BackColor = System.Drawing.Color.Transparent
        Me.editBookButton.BorderRadius = 5
        Me.editBookButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editBookButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.editBookButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.editBookButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.editBookButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.editBookButton.FillColor = System.Drawing.Color.Black
        Me.editBookButton.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.editBookButton.ForeColor = System.Drawing.Color.White
        Me.editBookButton.Location = New System.Drawing.Point(181, 105)
        Me.editBookButton.Name = "editBookButton"
        Me.editBookButton.ShadowDecoration.BorderRadius = 5
        Me.editBookButton.ShadowDecoration.Enabled = True
        Me.editBookButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.editBookButton.Size = New System.Drawing.Size(130, 50)
        Me.editBookButton.TabIndex = 12
        Me.editBookButton.Text = "EDIT"
        '
        'deleteBookButton
        '
        Me.deleteBookButton.BackColor = System.Drawing.Color.Transparent
        Me.deleteBookButton.BorderRadius = 5
        Me.deleteBookButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deleteBookButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.deleteBookButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.deleteBookButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.deleteBookButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.deleteBookButton.FillColor = System.Drawing.Color.Black
        Me.deleteBookButton.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.deleteBookButton.ForeColor = System.Drawing.Color.White
        Me.deleteBookButton.Location = New System.Drawing.Point(331, 105)
        Me.deleteBookButton.Name = "deleteBookButton"
        Me.deleteBookButton.ShadowDecoration.BorderRadius = 5
        Me.deleteBookButton.ShadowDecoration.Enabled = True
        Me.deleteBookButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.deleteBookButton.Size = New System.Drawing.Size(130, 50)
        Me.deleteBookButton.TabIndex = 13
        Me.deleteBookButton.Text = "DELETE"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1071, 115)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'searchBookTextBox
        '
        Me.searchBookTextBox.BackColor = System.Drawing.Color.Transparent
        Me.searchBookTextBox.BorderRadius = 5
        Me.searchBookTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.searchBookTextBox.DefaultText = ""
        Me.searchBookTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.searchBookTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.searchBookTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchBookTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchBookTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.searchBookTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.searchBookTextBox.ForeColor = System.Drawing.Color.Black
        Me.searchBookTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.searchBookTextBox.Location = New System.Drawing.Point(681, 105)
        Me.searchBookTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.searchBookTextBox.Name = "searchBookTextBox"
        Me.searchBookTextBox.PlaceholderText = "Search"
        Me.searchBookTextBox.SelectedText = ""
        Me.searchBookTextBox.ShadowDecoration.BorderRadius = 5
        Me.searchBookTextBox.ShadowDecoration.Enabled = True
        Me.searchBookTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.searchBookTextBox.Size = New System.Drawing.Size(430, 50)
        Me.searchBookTextBox.TabIndex = 16
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 5
        Me.Guna2Panel1.Controls.Add(Me.bookDGV)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(31, 185)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.BorderRadius = 5
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.Guna2Panel1.Size = New System.Drawing.Size(1080, 570)
        Me.Guna2Panel1.TabIndex = 18
        '
        'dialogTimer
        '
        Me.dialogTimer.Interval = 5
        '
        'bookDGV
        '
        Me.bookDGV.AllowUserToAddRows = False
        Me.bookDGV.AllowUserToDeleteRows = False
        Me.bookDGV.AllowUserToResizeColumns = False
        Me.bookDGV.AllowUserToResizeRows = False
        Me.bookDGV.AlternatingRowsDefaultCellStyle = Me.bookDGV.DefaultCellStyle
        Me.bookDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
        Me.bookDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.bookDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.bookDGV.ColumnHeadersHeight = 40
        Me.bookDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bookingId, Me.bookFname, Me.bookLname, Me.bookEmail, Me.bookPhoneNo, Me.bookRoomName, Me.bookRoomNo, Me.bookPax, Me.bookCheckInDate, Me.bookCheckInTime, Me.bookCheckOutdate, Me.bookCheckOutTime})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.bookDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.bookDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bookDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.bookDGV.Location = New System.Drawing.Point(0, 0)
        Me.bookDGV.Name = "bookDGV"
        Me.bookDGV.ReadOnly = True
        Me.bookDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.bookDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.bookDGV.RowHeadersVisible = False
        Me.bookDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.bookDGV.RowTemplate.Height = 40
        Me.bookDGV.RowTemplate.ReadOnly = True
        Me.bookDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.bookDGV.Size = New System.Drawing.Size(1080, 570)
        Me.bookDGV.TabIndex = 1
        Me.bookDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.bookDGV.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bookDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Gray
        Me.bookDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.bookDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.bookDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.bookDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black
        Me.bookDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.bookDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.bookDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.bookDGV.ThemeStyle.HeaderStyle.Height = 40
        Me.bookDGV.ThemeStyle.ReadOnly = True
        Me.bookDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.bookDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.bookDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.bookDGV.ThemeStyle.RowsStyle.Height = 40
        Me.bookDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray
        Me.bookDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'bookingId
        '
        Me.bookingId.HeaderText = "ID"
        Me.bookingId.Name = "bookingId"
        Me.bookingId.ReadOnly = True
        Me.bookingId.Width = 50
        '
        'bookFname
        '
        Me.bookFname.HeaderText = "FIRST NAME"
        Me.bookFname.Name = "bookFname"
        Me.bookFname.ReadOnly = True
        Me.bookFname.Width = 120
        '
        'bookLname
        '
        Me.bookLname.HeaderText = "LAST NAME"
        Me.bookLname.Name = "bookLname"
        Me.bookLname.ReadOnly = True
        Me.bookLname.Width = 120
        '
        'bookEmail
        '
        Me.bookEmail.HeaderText = "EMAIL"
        Me.bookEmail.Name = "bookEmail"
        Me.bookEmail.ReadOnly = True
        Me.bookEmail.Width = 75
        '
        'bookPhoneNo
        '
        Me.bookPhoneNo.HeaderText = "PHONE NO"
        Me.bookPhoneNo.Name = "bookPhoneNo"
        Me.bookPhoneNo.ReadOnly = True
        '
        'bookRoomName
        '
        Me.bookRoomName.HeaderText = "ROOM NAME"
        Me.bookRoomName.Name = "bookRoomName"
        Me.bookRoomName.ReadOnly = True
        Me.bookRoomName.Width = 120
        '
        'bookRoomNo
        '
        Me.bookRoomNo.HeaderText = "ROOM NO"
        Me.bookRoomNo.Name = "bookRoomNo"
        Me.bookRoomNo.ReadOnly = True
        '
        'bookPax
        '
        Me.bookPax.HeaderText = "PAX"
        Me.bookPax.Name = "bookPax"
        Me.bookPax.ReadOnly = True
        Me.bookPax.Width = 50
        '
        'bookCheckInDate
        '
        Me.bookCheckInDate.HeaderText = "CHECK IN DATE"
        Me.bookCheckInDate.Name = "bookCheckInDate"
        Me.bookCheckInDate.ReadOnly = True
        Me.bookCheckInDate.Width = 130
        '
        'bookCheckInTime
        '
        Me.bookCheckInTime.HeaderText = "CHECK IN TIME"
        Me.bookCheckInTime.Name = "bookCheckInTime"
        Me.bookCheckInTime.ReadOnly = True
        Me.bookCheckInTime.Width = 130
        '
        'bookCheckOutdate
        '
        Me.bookCheckOutdate.HeaderText = "CHECK OUT DATE"
        Me.bookCheckOutdate.Name = "bookCheckOutdate"
        Me.bookCheckOutdate.ReadOnly = True
        Me.bookCheckOutdate.Width = 150
        '
        'bookCheckOutTime
        '
        Me.bookCheckOutTime.HeaderText = "CHECK OUT TIME"
        Me.bookCheckOutTime.Name = "bookCheckOutTime"
        Me.bookCheckOutTime.ReadOnly = True
        Me.bookCheckOutTime.Width = 150
        '
        'bookingTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1142, 790)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.searchBookTextBox)
        Me.Controls.Add(Me.deleteBookButton)
        Me.Controls.Add(Me.editBookButton)
        Me.Controls.Add(Me.addBookButton)
        Me.Controls.Add(Me.menuButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.refreshBookButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "bookingTable"
        Me.Text = "bookingTable"
        CType(Me.menuButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.refreshBookButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.bookDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents menuButton As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents refreshBookButton As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents menuTimer As Timer
    Friend WithEvents addBookButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents editBookButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents deleteBookButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents searchBookTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dialogTimer As Timer
    Friend WithEvents bookDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents bookingId As DataGridViewTextBoxColumn
    Friend WithEvents bookFname As DataGridViewTextBoxColumn
    Friend WithEvents bookLname As DataGridViewTextBoxColumn
    Friend WithEvents bookEmail As DataGridViewTextBoxColumn
    Friend WithEvents bookPhoneNo As DataGridViewTextBoxColumn
    Friend WithEvents bookRoomName As DataGridViewTextBoxColumn
    Friend WithEvents bookRoomNo As DataGridViewTextBoxColumn
    Friend WithEvents bookPax As DataGridViewTextBoxColumn
    Friend WithEvents bookCheckInDate As DataGridViewTextBoxColumn
    Friend WithEvents bookCheckInTime As DataGridViewTextBoxColumn
    Friend WithEvents bookCheckOutdate As DataGridViewTextBoxColumn
    Friend WithEvents bookCheckOutTime As DataGridViewTextBoxColumn
End Class
