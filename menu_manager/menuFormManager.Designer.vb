<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuFormManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuFormManager))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.logOutIcon = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.profileIcon = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.dropDownIcon = New System.Windows.Forms.PictureBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.profileButton = New Guna.UI2.WinForms.Guna2Button()
        Me.logOutButton = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTables = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logOutIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.profileIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dropDownIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(52, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(280, 81)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'logOutIcon
        '
        Me.logOutIcon.BackColor = System.Drawing.Color.Transparent
        Me.logOutIcon.Image = CType(resources.GetObject("logOutIcon.Image"), System.Drawing.Image)
        Me.logOutIcon.ImageRotate = 0!
        Me.logOutIcon.Location = New System.Drawing.Point(52, 425)
        Me.logOutIcon.Name = "logOutIcon"
        Me.logOutIcon.Size = New System.Drawing.Size(36, 36)
        Me.logOutIcon.TabIndex = 25
        Me.logOutIcon.TabStop = False
        '
        'profileIcon
        '
        Me.profileIcon.BackColor = System.Drawing.Color.Transparent
        Me.profileIcon.Image = CType(resources.GetObject("profileIcon.Image"), System.Drawing.Image)
        Me.profileIcon.ImageRotate = 0!
        Me.profileIcon.Location = New System.Drawing.Point(52, 325)
        Me.profileIcon.Name = "profileIcon"
        Me.profileIcon.Size = New System.Drawing.Size(36, 36)
        Me.profileIcon.TabIndex = 24
        Me.profileIcon.TabStop = False
        '
        'dropDownIcon
        '
        Me.dropDownIcon.BackColor = System.Drawing.Color.Transparent
        Me.dropDownIcon.Image = CType(resources.GetObject("dropDownIcon.Image"), System.Drawing.Image)
        Me.dropDownIcon.Location = New System.Drawing.Point(324, 225)
        Me.dropDownIcon.Name = "dropDownIcon"
        Me.dropDownIcon.Size = New System.Drawing.Size(36, 36)
        Me.dropDownIcon.TabIndex = 26
        Me.dropDownIcon.TabStop = False
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(52, 225)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(36, 36)
        Me.Guna2PictureBox2.TabIndex = 21
        Me.Guna2PictureBox2.TabStop = False
        '
        'profileButton
        '
        Me.profileButton.BackColor = System.Drawing.Color.Transparent
        Me.profileButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.profileButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.profileButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.profileButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.profileButton.FillColor = System.Drawing.Color.Transparent
        Me.profileButton.Font = New System.Drawing.Font("Raleway", 23.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.profileButton.ForeColor = System.Drawing.Color.White
        Me.profileButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.profileButton.ImageOffset = New System.Drawing.Point(32, 0)
        Me.profileButton.ImageSize = New System.Drawing.Size(50, 50)
        Me.profileButton.Location = New System.Drawing.Point(0, 307)
        Me.profileButton.Name = "profileButton"
        Me.profileButton.Size = New System.Drawing.Size(385, 70)
        Me.profileButton.TabIndex = 22
        Me.profileButton.Text = "PROFILE"
        Me.profileButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.profileButton.TextOffset = New System.Drawing.Point(94, 0)
        Me.profileButton.UseTransparentBackground = True
        '
        'logOutButton
        '
        Me.logOutButton.BackColor = System.Drawing.Color.Transparent
        Me.logOutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.logOutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.logOutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.logOutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.logOutButton.FillColor = System.Drawing.Color.Transparent
        Me.logOutButton.Font = New System.Drawing.Font("Raleway", 23.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.logOutButton.ForeColor = System.Drawing.Color.White
        Me.logOutButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.logOutButton.ImageOffset = New System.Drawing.Point(32, 0)
        Me.logOutButton.ImageSize = New System.Drawing.Size(50, 50)
        Me.logOutButton.Location = New System.Drawing.Point(0, 407)
        Me.logOutButton.Name = "logOutButton"
        Me.logOutButton.Size = New System.Drawing.Size(385, 70)
        Me.logOutButton.TabIndex = 23
        Me.logOutButton.Text = "LOG OUT"
        Me.logOutButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.logOutButton.TextOffset = New System.Drawing.Point(94, 0)
        Me.logOutButton.UseTransparentBackground = True
        '
        'btnTables
        '
        Me.btnTables.BackColor = System.Drawing.Color.Transparent
        Me.btnTables.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTables.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTables.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTables.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTables.FillColor = System.Drawing.Color.Transparent
        Me.btnTables.Font = New System.Drawing.Font("Raleway", 23.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnTables.ForeColor = System.Drawing.Color.White
        Me.btnTables.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnTables.ImageOffset = New System.Drawing.Point(32, 0)
        Me.btnTables.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnTables.Location = New System.Drawing.Point(0, 207)
        Me.btnTables.Name = "btnTables"
        Me.btnTables.Size = New System.Drawing.Size(385, 70)
        Me.btnTables.TabIndex = 20
        Me.btnTables.Text = "TABLES"
        Me.btnTables.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnTables.TextOffset = New System.Drawing.Point(94, 0)
        Me.btnTables.UseTransparentBackground = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'menuFormManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(385, 790)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.logOutIcon)
        Me.Controls.Add(Me.profileIcon)
        Me.Controls.Add(Me.dropDownIcon)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.profileButton)
        Me.Controls.Add(Me.logOutButton)
        Me.Controls.Add(Me.btnTables)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "menuFormManager"
        Me.Text = " "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logOutIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.profileIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dropDownIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents logOutIcon As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents profileIcon As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents dropDownIcon As PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents profileButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents logOutButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTables As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
End Class
