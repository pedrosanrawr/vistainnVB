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
        Me.dialogTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.menuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.refreshAccButton, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(31, 185)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.BorderRadius = 5
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.Guna2Panel1.Size = New System.Drawing.Size(1080, 570)
        Me.Guna2Panel1.TabIndex = 30
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
End Class
