<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fogotPassword_verify
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.otpTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.verifyButton = New Guna.UI2.WinForms.Guna2Button()
        Me.cancelBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.resendLabel = New System.Windows.Forms.Label()
        Me.labelLink = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Raleway", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "FORGOT PASSWORD"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'emailLabel
        '
        Me.emailLabel.Font = New System.Drawing.Font("Lato", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.emailLabel.Location = New System.Drawing.Point(69, 101)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(466, 80)
        Me.emailLabel.TabIndex = 6
        Me.emailLabel.Text = "One-Time Password has been sent to your email. Check your email and type the OTP " &
    "on the text box below:"
        Me.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'otpTextBox
        '
        Me.otpTextBox.BackColor = System.Drawing.Color.Transparent
        Me.otpTextBox.BorderRadius = 5
        Me.otpTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.otpTextBox.DefaultText = ""
        Me.otpTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.otpTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.otpTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.otpTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.otpTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.otpTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.otpTextBox.ForeColor = System.Drawing.Color.Black
        Me.otpTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.otpTextBox.Location = New System.Drawing.Point(180, 201)
        Me.otpTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.otpTextBox.Name = "otpTextBox"
        Me.otpTextBox.PlaceholderText = ""
        Me.otpTextBox.SelectedText = ""
        Me.otpTextBox.ShadowDecoration.BorderRadius = 5
        Me.otpTextBox.ShadowDecoration.Enabled = True
        Me.otpTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.otpTextBox.Size = New System.Drawing.Size(244, 50)
        Me.otpTextBox.TabIndex = 19
        '
        'verifyButton
        '
        Me.verifyButton.BackColor = System.Drawing.Color.Transparent
        Me.verifyButton.BorderRadius = 5
        Me.verifyButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.verifyButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.verifyButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.verifyButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.verifyButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.verifyButton.FillColor = System.Drawing.Color.Black
        Me.verifyButton.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.verifyButton.ForeColor = System.Drawing.Color.White
        Me.verifyButton.Location = New System.Drawing.Point(237, 281)
        Me.verifyButton.Name = "verifyButton"
        Me.verifyButton.ShadowDecoration.BorderRadius = 5
        Me.verifyButton.ShadowDecoration.Enabled = True
        Me.verifyButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.verifyButton.Size = New System.Drawing.Size(130, 50)
        Me.verifyButton.TabIndex = 20
        Me.verifyButton.Text = "VERIFY"
        '
        'cancelBtn
        '
        Me.cancelBtn.BackColor = System.Drawing.Color.Transparent
        Me.cancelBtn.BorderColor = System.Drawing.Color.Transparent
        Me.cancelBtn.BorderRadius = 5
        Me.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cancelBtn.FillColor = System.Drawing.Color.Transparent
        Me.cancelBtn.Font = New System.Drawing.Font("Raleway", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cancelBtn.ForeColor = System.Drawing.Color.Black
        Me.cancelBtn.Location = New System.Drawing.Point(237, 351)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.PressedColor = System.Drawing.Color.Transparent
        Me.cancelBtn.ShadowDecoration.BorderRadius = 5
        Me.cancelBtn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.cancelBtn.Size = New System.Drawing.Size(130, 50)
        Me.cancelBtn.TabIndex = 21
        Me.cancelBtn.Text = "CANCEL"
        '
        'resendLabel
        '
        Me.resendLabel.Font = New System.Drawing.Font("Lato", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.resendLabel.Location = New System.Drawing.Point(88, 401)
        Me.resendLabel.Name = "resendLabel"
        Me.resendLabel.Size = New System.Drawing.Size(427, 30)
        Me.resendLabel.TabIndex = 22
        Me.resendLabel.Text = "Didn't receive a code? You can resend a code in (59s)"
        Me.resendLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelLink
        '
        Me.labelLink.Interval = 1000
        '
        'fogotPassword_verify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(604, 483)
        Me.Controls.Add(Me.resendLabel)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.verifyButton)
        Me.Controls.Add(Me.otpTextBox)
        Me.Controls.Add(Me.emailLabel)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fogotPassword_verify"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fogotPassword_verify"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub



    Private Sub roundCorners(obj As Form)
        Dim DGP As New Drawing2D.GraphicsPath
        Dim radius = 25
        DGP.StartFigure()
        DGP.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        DGP.AddLine(radius, 0, obj.Width - radius, 0)
        DGP.AddArc(New Rectangle(obj.Width - radius, 0, radius, radius), -90, 90)
        DGP.AddLine(obj.Width, radius, obj.Width, obj.Height - radius)
        DGP.AddArc(New Rectangle(obj.Width - radius, obj.Height - radius, radius, radius), 0, 90)
        DGP.AddLine(obj.Width - radius, obj.Height, radius, obj.Height)
        DGP.AddArc(New Rectangle(0, obj.Height - radius, radius, radius), 90, 90)
        DGP.CloseFigure()
        obj.Region = New Region(DGP)
    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents emailLabel As Label
    Friend WithEvents otpTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents verifyButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cancelBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents resendLabel As Label
    Friend WithEvents labelLink As Timer
End Class
