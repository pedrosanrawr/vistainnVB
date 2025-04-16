<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class employeeTable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(employeeTable))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.menuButton = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.refreshAccButton = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.menuTimer = New System.Windows.Forms.Timer(Me.components)
        Me.addAccButton = New Guna.UI2.WinForms.Guna2Button()
        Me.editAccButton = New Guna.UI2.WinForms.Guna2Button()
        Me.deleteAccButton = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.searchAccTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.employeeDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.employeeId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeFname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeLname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeRole = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeePhoneNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeGender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeNationality = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dialogTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.menuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.refreshAccButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.employeeDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuButton
        '
        Me.menuButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuButton.Image = CType(resources.GetObject("menuButton.Image"), System.Drawing.Image)
        Me.menuButton.Location = New System.Drawing.Point(31, 20)
        Me.menuButton.Name = "menuButton"
        Me.menuButton.Size = New System.Drawing.Size(50, 50)
        Me.menuButton.TabIndex = 20
        Me.menuButton.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Raleway", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(882, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 22)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "TABLE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Raleway", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(888, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 34)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "ACCOUNTS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1061, 20)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox3.TabIndex = 22
        Me.PictureBox3.TabStop = False
        '
        'refreshAccButton
        '
        Me.refreshAccButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.refreshAccButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refreshAccButton.Image = CType(resources.GetObject("refreshAccButton.Image"), System.Drawing.Image)
        Me.refreshAccButton.Location = New System.Drawing.Point(111, 20)
        Me.refreshAccButton.Name = "refreshAccButton"
        Me.refreshAccButton.Size = New System.Drawing.Size(50, 50)
        Me.refreshAccButton.TabIndex = 21
        Me.refreshAccButton.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 5
        '
        'menuTimer
        '
        Me.menuTimer.Interval = 5
        '
        'addAccButton
        '
        Me.addAccButton.BackColor = System.Drawing.Color.Transparent
        Me.addAccButton.BorderRadius = 5
        Me.addAccButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addAccButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addAccButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addAccButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addAccButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addAccButton.FillColor = System.Drawing.Color.Black
        Me.addAccButton.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.addAccButton.ForeColor = System.Drawing.Color.White
        Me.addAccButton.Location = New System.Drawing.Point(31, 105)
        Me.addAccButton.Name = "addAccButton"
        Me.addAccButton.ShadowDecoration.BorderRadius = 5
        Me.addAccButton.ShadowDecoration.Enabled = True
        Me.addAccButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.addAccButton.Size = New System.Drawing.Size(130, 50)
        Me.addAccButton.TabIndex = 25
        Me.addAccButton.Text = "ADD"
        '
        'editAccButton
        '
        Me.editAccButton.BackColor = System.Drawing.Color.Transparent
        Me.editAccButton.BorderRadius = 5
        Me.editAccButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editAccButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.editAccButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.editAccButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.editAccButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.editAccButton.FillColor = System.Drawing.Color.Black
        Me.editAccButton.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.editAccButton.ForeColor = System.Drawing.Color.White
        Me.editAccButton.Location = New System.Drawing.Point(181, 105)
        Me.editAccButton.Name = "editAccButton"
        Me.editAccButton.ShadowDecoration.BorderRadius = 5
        Me.editAccButton.ShadowDecoration.Enabled = True
        Me.editAccButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.editAccButton.Size = New System.Drawing.Size(130, 50)
        Me.editAccButton.TabIndex = 26
        Me.editAccButton.Text = "EDIT"
        '
        'deleteAccButton
        '
        Me.deleteAccButton.BackColor = System.Drawing.Color.Transparent
        Me.deleteAccButton.BorderRadius = 5
        Me.deleteAccButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deleteAccButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.deleteAccButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.deleteAccButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.deleteAccButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.deleteAccButton.FillColor = System.Drawing.Color.Black
        Me.deleteAccButton.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.deleteAccButton.ForeColor = System.Drawing.Color.White
        Me.deleteAccButton.Location = New System.Drawing.Point(331, 105)
        Me.deleteAccButton.Name = "deleteAccButton"
        Me.deleteAccButton.ShadowDecoration.BorderRadius = 5
        Me.deleteAccButton.ShadowDecoration.Enabled = True
        Me.deleteAccButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.deleteAccButton.Size = New System.Drawing.Size(130, 50)
        Me.deleteAccButton.TabIndex = 27
        Me.deleteAccButton.Text = "DELETE"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1071, 115)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'searchAccTextBox
        '
        Me.searchAccTextBox.BackColor = System.Drawing.Color.Transparent
        Me.searchAccTextBox.BorderRadius = 5
        Me.searchAccTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.searchAccTextBox.DefaultText = ""
        Me.searchAccTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.searchAccTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.searchAccTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchAccTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchAccTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.searchAccTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.searchAccTextBox.ForeColor = System.Drawing.Color.Black
        Me.searchAccTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.searchAccTextBox.Location = New System.Drawing.Point(681, 105)
        Me.searchAccTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.searchAccTextBox.Name = "searchAccTextBox"
        Me.searchAccTextBox.PlaceholderText = "Search"
        Me.searchAccTextBox.SelectedText = ""
        Me.searchAccTextBox.ShadowDecoration.BorderRadius = 5
        Me.searchAccTextBox.ShadowDecoration.Enabled = True
        Me.searchAccTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.searchAccTextBox.Size = New System.Drawing.Size(430, 50)
        Me.searchAccTextBox.TabIndex = 28
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 5
        Me.Guna2Panel1.Controls.Add(Me.employeeDGV)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(31, 185)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.BorderRadius = 5
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.Guna2Panel1.Size = New System.Drawing.Size(1080, 570)
        Me.Guna2Panel1.TabIndex = 30
        '
        'employeeDGV
        '
        Me.employeeDGV.AllowUserToAddRows = False
        Me.employeeDGV.AllowUserToDeleteRows = False
        Me.employeeDGV.AllowUserToResizeColumns = False
        Me.employeeDGV.AllowUserToResizeRows = False
        Me.employeeDGV.AlternatingRowsDefaultCellStyle = Me.employeeDGV.DefaultCellStyle
        Me.employeeDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
        Me.employeeDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.employeeDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.employeeDGV.ColumnHeadersHeight = 40
        Me.employeeDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.employeeId, Me.employeeFname, Me.employeeLname, Me.employeeRole, Me.employeeEmail, Me.employeePhoneNo, Me.employeeGender, Me.employeeNationality, Me.employeeAddress})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.employeeDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.employeeDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.employeeDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.employeeDGV.Location = New System.Drawing.Point(0, 0)
        Me.employeeDGV.Name = "employeeDGV"
        Me.employeeDGV.ReadOnly = True
        Me.employeeDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.employeeDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.employeeDGV.RowHeadersVisible = False
        Me.employeeDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.employeeDGV.RowTemplate.Height = 40
        Me.employeeDGV.RowTemplate.ReadOnly = True
        Me.employeeDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.employeeDGV.Size = New System.Drawing.Size(1080, 570)
        Me.employeeDGV.TabIndex = 4
        Me.employeeDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.employeeDGV.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.employeeDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Gray
        Me.employeeDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.employeeDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.employeeDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.employeeDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black
        Me.employeeDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.employeeDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.employeeDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.employeeDGV.ThemeStyle.HeaderStyle.Height = 40
        Me.employeeDGV.ThemeStyle.ReadOnly = True
        Me.employeeDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.employeeDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.employeeDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.employeeDGV.ThemeStyle.RowsStyle.Height = 40
        Me.employeeDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray
        Me.employeeDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'employeeId
        '
        Me.employeeId.DataPropertyName = "eId"
        Me.employeeId.HeaderText = "ID"
        Me.employeeId.Name = "employeeId"
        Me.employeeId.ReadOnly = True
        Me.employeeId.Width = 50
        '
        'employeeFname
        '
        Me.employeeFname.DataPropertyName = "eFname"
        Me.employeeFname.HeaderText = "FIRST NAME"
        Me.employeeFname.Name = "employeeFname"
        Me.employeeFname.ReadOnly = True
        Me.employeeFname.Width = 130
        '
        'employeeLname
        '
        Me.employeeLname.DataPropertyName = "eLname"
        Me.employeeLname.HeaderText = "LAST NAME"
        Me.employeeLname.Name = "employeeLname"
        Me.employeeLname.ReadOnly = True
        Me.employeeLname.Width = 130
        '
        'employeeRole
        '
        Me.employeeRole.DataPropertyName = "eRole"
        Me.employeeRole.HeaderText = "ROLE"
        Me.employeeRole.Name = "employeeRole"
        Me.employeeRole.ReadOnly = True
        '
        'employeeEmail
        '
        Me.employeeEmail.DataPropertyName = "eEmail"
        Me.employeeEmail.HeaderText = "EMAIL"
        Me.employeeEmail.Name = "employeeEmail"
        Me.employeeEmail.ReadOnly = True
        '
        'employeePhoneNo
        '
        Me.employeePhoneNo.DataPropertyName = "ePhoneNo"
        Me.employeePhoneNo.HeaderText = "PHONE NO"
        Me.employeePhoneNo.Name = "employeePhoneNo"
        Me.employeePhoneNo.ReadOnly = True
        Me.employeePhoneNo.Width = 110
        '
        'employeeGender
        '
        Me.employeeGender.DataPropertyName = "eGender"
        Me.employeeGender.HeaderText = "GENDER"
        Me.employeeGender.Name = "employeeGender"
        Me.employeeGender.ReadOnly = True
        '
        'employeeNationality
        '
        Me.employeeNationality.DataPropertyName = "eNationality"
        Me.employeeNationality.HeaderText = "NATIONALITY"
        Me.employeeNationality.Name = "employeeNationality"
        Me.employeeNationality.ReadOnly = True
        Me.employeeNationality.Width = 130
        '
        'employeeAddress
        '
        Me.employeeAddress.DataPropertyName = "eAddress"
        Me.employeeAddress.HeaderText = "ADDRESS"
        Me.employeeAddress.Name = "employeeAddress"
        Me.employeeAddress.ReadOnly = True
        Me.employeeAddress.Width = 230
        '
        'dialogTimer
        '
        Me.dialogTimer.Interval = 5
        '
        'employeeTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1142, 790)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.searchAccTextBox)
        Me.Controls.Add(Me.deleteAccButton)
        Me.Controls.Add(Me.editAccButton)
        Me.Controls.Add(Me.addAccButton)
        Me.Controls.Add(Me.menuButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.refreshAccButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "employeeTable"
        Me.Text = "accTable"
        CType(Me.menuButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.refreshAccButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.employeeDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents menuButton As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents refreshAccButton As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents menuTimer As Timer
    Friend WithEvents addAccButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents editAccButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents deleteAccButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents searchAccTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dialogTimer As Timer
    Friend WithEvents employeeDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents employeeId As DataGridViewTextBoxColumn
    Friend WithEvents employeeFname As DataGridViewTextBoxColumn
    Friend WithEvents employeeLname As DataGridViewTextBoxColumn
    Friend WithEvents employeeRole As DataGridViewTextBoxColumn
    Friend WithEvents employeeEmail As DataGridViewTextBoxColumn
    Friend WithEvents employeePhoneNo As DataGridViewTextBoxColumn
    Friend WithEvents employeeGender As DataGridViewTextBoxColumn
    Friend WithEvents employeeNationality As DataGridViewTextBoxColumn
    Friend WithEvents employeeAddress As DataGridViewTextBoxColumn
End Class
