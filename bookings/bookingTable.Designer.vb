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
        CType(Me.menuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.refreshBookButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
End Class
