<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class profile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(profile))
        Me.menuButton = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.refreshButton = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.menuTimer = New System.Windows.Forms.Timer(Me.components)
        Me.profilePicture = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.roleLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.phoneNoLabel = New System.Windows.Forms.Label()
        Me.genderLabel = New System.Windows.Forms.Label()
        Me.nationalityLabel = New System.Windows.Forms.Label()
        Me.addressLabel = New System.Windows.Forms.Label()
        Me.changeProfilePicButton = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.menuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.refreshButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.profilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuButton
        '
        Me.menuButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuButton.Image = CType(resources.GetObject("menuButton.Image"), System.Drawing.Image)
        Me.menuButton.Location = New System.Drawing.Point(31, 20)
        Me.menuButton.Name = "menuButton"
        Me.menuButton.Size = New System.Drawing.Size(50, 50)
        Me.menuButton.TabIndex = 25
        Me.menuButton.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Raleway", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(882, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 22)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "ACCOUNT"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Raleway", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(888, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 34)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "PROFILE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1061, 20)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox3.TabIndex = 27
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
        Me.refreshButton.TabIndex = 26
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
        'profilePicture
        '
        Me.profilePicture.BorderRadius = 60
        Me.profilePicture.Image = CType(resources.GetObject("profilePicture.Image"), System.Drawing.Image)
        Me.profilePicture.ImageRotate = 0!
        Me.profilePicture.InitialImage = CType(resources.GetObject("profilePicture.InitialImage"), System.Drawing.Image)
        Me.profilePicture.Location = New System.Drawing.Point(289, 138)
        Me.profilePicture.Name = "profilePicture"
        Me.profilePicture.Size = New System.Drawing.Size(120, 120)
        Me.profilePicture.TabIndex = 30
        Me.profilePicture.TabStop = False
        '
        'nameLabel
        '
        Me.nameLabel.Font = New System.Drawing.Font("Raleway", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(429, 138)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(423, 70)
        Me.nameLabel.TabIndex = 45
        Me.nameLabel.Text = "NAME"
        Me.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'roleLabel
        '
        Me.roleLabel.Font = New System.Drawing.Font("Lato", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.roleLabel.Location = New System.Drawing.Point(436, 208)
        Me.roleLabel.Name = "roleLabel"
        Me.roleLabel.Size = New System.Drawing.Size(304, 30)
        Me.roleLabel.TabIndex = 46
        Me.roleLabel.Text = "ROLE"
        Me.roleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Raleway", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(436, 305)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 30)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "EMAIL:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Raleway", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(436, 354)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 30)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "PHONE NO.:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Raleway", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(436, 405)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 30)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "GENDER:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Raleway", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(436, 454)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 30)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "NATIONALITY:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Raleway", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(436, 511)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 30)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "ADDRESS:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'emailLabel
        '
        Me.emailLabel.Font = New System.Drawing.Font("Lato", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.emailLabel.Location = New System.Drawing.Point(510, 305)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(230, 30)
        Me.emailLabel.TabIndex = 52
        Me.emailLabel.Text = "Email@gmail.com"
        Me.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'phoneNoLabel
        '
        Me.phoneNoLabel.Font = New System.Drawing.Font("Lato", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.phoneNoLabel.Location = New System.Drawing.Point(559, 354)
        Me.phoneNoLabel.Name = "phoneNoLabel"
        Me.phoneNoLabel.Size = New System.Drawing.Size(181, 30)
        Me.phoneNoLabel.TabIndex = 53
        Me.phoneNoLabel.Text = "09081303441"
        Me.phoneNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'genderLabel
        '
        Me.genderLabel.Font = New System.Drawing.Font("Lato", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.genderLabel.Location = New System.Drawing.Point(532, 406)
        Me.genderLabel.Name = "genderLabel"
        Me.genderLabel.Size = New System.Drawing.Size(208, 30)
        Me.genderLabel.TabIndex = 54
        Me.genderLabel.Text = "Male"
        Me.genderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nationalityLabel
        '
        Me.nationalityLabel.Font = New System.Drawing.Font("Lato", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.nationalityLabel.Location = New System.Drawing.Point(581, 455)
        Me.nationalityLabel.Name = "nationalityLabel"
        Me.nationalityLabel.Size = New System.Drawing.Size(159, 30)
        Me.nationalityLabel.TabIndex = 55
        Me.nationalityLabel.Text = "Filipino"
        Me.nationalityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'addressLabel
        '
        Me.addressLabel.Font = New System.Drawing.Font("Lato", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.addressLabel.Location = New System.Drawing.Point(543, 515)
        Me.addressLabel.Name = "addressLabel"
        Me.addressLabel.Size = New System.Drawing.Size(197, 70)
        Me.addressLabel.TabIndex = 56
        Me.addressLabel.Text = "Camarin, Calooocan City Philippines"
        '
        'changeProfilePicButton
        '
        Me.changeProfilePicButton.BackColor = System.Drawing.Color.Transparent
        Me.changeProfilePicButton.BorderRadius = 5
        Me.changeProfilePicButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.changeProfilePicButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.changeProfilePicButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.changeProfilePicButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.changeProfilePicButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.changeProfilePicButton.FillColor = System.Drawing.Color.Black
        Me.changeProfilePicButton.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.changeProfilePicButton.ForeColor = System.Drawing.Color.White
        Me.changeProfilePicButton.Location = New System.Drawing.Point(414, 655)
        Me.changeProfilePicButton.Name = "changeProfilePicButton"
        Me.changeProfilePicButton.ShadowDecoration.BorderRadius = 5
        Me.changeProfilePicButton.ShadowDecoration.Enabled = True
        Me.changeProfilePicButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.changeProfilePicButton.Size = New System.Drawing.Size(314, 50)
        Me.changeProfilePicButton.TabIndex = 66
        Me.changeProfilePicButton.Text = "CHANGE PROFILE PICTURE"
        '
        'profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1142, 790)
        Me.Controls.Add(Me.changeProfilePicButton)
        Me.Controls.Add(Me.addressLabel)
        Me.Controls.Add(Me.nationalityLabel)
        Me.Controls.Add(Me.genderLabel)
        Me.Controls.Add(Me.phoneNoLabel)
        Me.Controls.Add(Me.emailLabel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.roleLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.profilePicture)
        Me.Controls.Add(Me.menuButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.refreshButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "profile"
        Me.Text = " "
        CType(Me.menuButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.refreshButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.profilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents menuButton As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents refreshButton As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents menuTimer As Timer
    Friend WithEvents profilePicture As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents nameLabel As Label
    Friend WithEvents roleLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents emailLabel As Label
    Friend WithEvents phoneNoLabel As Label
    Friend WithEvents genderLabel As Label
    Friend WithEvents nationalityLabel As Label
    Friend WithEvents addressLabel As Label
    Friend WithEvents changeProfilePicButton As Guna.UI2.WinForms.Guna2Button
End Class
