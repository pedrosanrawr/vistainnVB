<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class logInForm
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(logInForm))
        Me.sidePanel = New System.Windows.Forms.Panel()
        Me.logInButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.forgotPasswordLabelLink = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.passwordTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.emailTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.hidePass = New System.Windows.Forms.PictureBox()
        Me.sidePanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hidePass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sidePanel
        '
        Me.sidePanel.Controls.Add(Me.logInButton)
        Me.sidePanel.Controls.Add(Me.Label4)
        Me.sidePanel.Controls.Add(Me.forgotPasswordLabelLink)
        Me.sidePanel.Controls.Add(Me.Label2)
        Me.sidePanel.Controls.Add(Me.Label1)
        Me.sidePanel.Controls.Add(Me.passwordTextBox)
        Me.sidePanel.Controls.Add(Me.emailTextBox)
        Me.sidePanel.Controls.Add(Me.PictureBox1)
        Me.sidePanel.Controls.Add(Me.hidePass)
        Me.sidePanel.Location = New System.Drawing.Point(442, 0)
        Me.sidePanel.Name = "sidePanel"
        Me.sidePanel.Size = New System.Drawing.Size(700, 790)
        Me.sidePanel.TabIndex = 1
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
        Me.logInButton.Location = New System.Drawing.Point(285, 505)
        Me.logInButton.Name = "logInButton"
        Me.logInButton.ShadowDecoration.BorderRadius = 5
        Me.logInButton.ShadowDecoration.Enabled = True
        Me.logInButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.logInButton.Size = New System.Drawing.Size(130, 50)
        Me.logInButton.TabIndex = 9
        Me.logInButton.Text = "LOG IN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lato", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(96, 705)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(509, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = """YOUR GETAWAY TO RELAXATION AND COMFORT"""
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'forgotPasswordLabelLink
        '
        Me.forgotPasswordLabelLink.AutoSize = True
        Me.forgotPasswordLabelLink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.forgotPasswordLabelLink.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forgotPasswordLabelLink.Location = New System.Drawing.Point(323, 440)
        Me.forgotPasswordLabelLink.Name = "forgotPasswordLabelLink"
        Me.forgotPasswordLabelLink.Size = New System.Drawing.Size(167, 22)
        Me.forgotPasswordLabelLink.TabIndex = 7
        Me.forgotPasswordLabelLink.Text = "FORGOT PASSWORD"
        Me.forgotPasswordLabelLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Raleway", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(204, 348)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 34)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "PASSWORD"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Raleway", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(204, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "EMAIL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'passwordTextBox
        '
        Me.passwordTextBox.BackColor = System.Drawing.Color.Transparent
        Me.passwordTextBox.BorderRadius = 5
        Me.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passwordTextBox.DefaultText = ""
        Me.passwordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.passwordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.passwordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.passwordTextBox.Font = New System.Drawing.Font("Lato", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.passwordTextBox.ForeColor = System.Drawing.Color.Black
        Me.passwordTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.passwordTextBox.Location = New System.Drawing.Point(210, 385)
        Me.passwordTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.PlaceholderText = ""
        Me.passwordTextBox.SelectedText = ""
        Me.passwordTextBox.ShadowDecoration.BorderRadius = 5
        Me.passwordTextBox.ShadowDecoration.Depth = 40
        Me.passwordTextBox.ShadowDecoration.Enabled = True
        Me.passwordTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.passwordTextBox.Size = New System.Drawing.Size(280, 50)
        Me.passwordTextBox.TabIndex = 2
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
        Me.emailTextBox.Font = New System.Drawing.Font("Lato", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.emailTextBox.ForeColor = System.Drawing.Color.Black
        Me.emailTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.emailTextBox.Location = New System.Drawing.Point(210, 285)
        Me.emailTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.PlaceholderText = ""
        Me.emailTextBox.SelectedText = ""
        Me.emailTextBox.ShadowDecoration.BorderRadius = 5
        Me.emailTextBox.ShadowDecoration.Depth = 40
        Me.emailTextBox.ShadowDecoration.Enabled = True
        Me.emailTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.emailTextBox.Size = New System.Drawing.Size(280, 50)
        Me.emailTextBox.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(100, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(500, 130)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'hidePass
        '
        Me.hidePass.Image = CType(resources.GetObject("hidePass.Image"), System.Drawing.Image)
        Me.hidePass.Location = New System.Drawing.Point(460, 352)
        Me.hidePass.Name = "hidePass"
        Me.hidePass.Size = New System.Drawing.Size(30, 30)
        Me.hidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hidePass.TabIndex = 6
        Me.hidePass.TabStop = False
        '
        'logInForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1142, 790)
        Me.Controls.Add(Me.sidePanel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "logInForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.sidePanel.ResumeLayout(False)
        Me.sidePanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hidePass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents sidePanel As Panel
    Friend WithEvents logInButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents forgotPasswordLabelLink As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents passwordTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents emailTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents hidePass As PictureBox
End Class
