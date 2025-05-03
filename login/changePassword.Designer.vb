<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(changePassword))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.newPasswordTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.reEnterNewPasswordTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.changeButton = New Guna.UI2.WinForms.Guna2Button()
        Me.cancelBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.hidePassEnter = New System.Windows.Forms.PictureBox()
        Me.hidePassReEnter = New System.Windows.Forms.PictureBox()
        CType(Me.hidePassEnter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hidePassReEnter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Raleway", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(190, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 29)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "CHANGE PASSWORD"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'newPasswordTextBox
        '
        Me.newPasswordTextBox.BackColor = System.Drawing.Color.Transparent
        Me.newPasswordTextBox.BorderRadius = 5
        Me.newPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.newPasswordTextBox.DefaultText = ""
        Me.newPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.newPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.newPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.newPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.newPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.newPasswordTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.newPasswordTextBox.ForeColor = System.Drawing.Color.Black
        Me.newPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.newPasswordTextBox.Location = New System.Drawing.Point(161, 175)
        Me.newPasswordTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.newPasswordTextBox.Name = "newPasswordTextBox"
        Me.newPasswordTextBox.PlaceholderText = ""
        Me.newPasswordTextBox.SelectedText = ""
        Me.newPasswordTextBox.ShadowDecoration.BorderRadius = 5
        Me.newPasswordTextBox.ShadowDecoration.Enabled = True
        Me.newPasswordTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.newPasswordTextBox.Size = New System.Drawing.Size(244, 50)
        Me.newPasswordTextBox.TabIndex = 20
        '
        'reEnterNewPasswordTextBox
        '
        Me.reEnterNewPasswordTextBox.BackColor = System.Drawing.Color.Transparent
        Me.reEnterNewPasswordTextBox.BorderRadius = 5
        Me.reEnterNewPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.reEnterNewPasswordTextBox.DefaultText = ""
        Me.reEnterNewPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.reEnterNewPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.reEnterNewPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.reEnterNewPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.reEnterNewPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.reEnterNewPasswordTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.reEnterNewPasswordTextBox.ForeColor = System.Drawing.Color.Black
        Me.reEnterNewPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.reEnterNewPasswordTextBox.Location = New System.Drawing.Point(161, 275)
        Me.reEnterNewPasswordTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.reEnterNewPasswordTextBox.Name = "reEnterNewPasswordTextBox"
        Me.reEnterNewPasswordTextBox.PlaceholderText = ""
        Me.reEnterNewPasswordTextBox.SelectedText = ""
        Me.reEnterNewPasswordTextBox.ShadowDecoration.BorderRadius = 5
        Me.reEnterNewPasswordTextBox.ShadowDecoration.Enabled = True
        Me.reEnterNewPasswordTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.reEnterNewPasswordTextBox.Size = New System.Drawing.Size(244, 50)
        Me.reEnterNewPasswordTextBox.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Raleway", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(161, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 21)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "ENTER NEW PASSWORD"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Raleway", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(161, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 21)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "RE-ENTER NEW PASSWORD"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'changeButton
        '
        Me.changeButton.BackColor = System.Drawing.Color.Transparent
        Me.changeButton.BorderRadius = 5
        Me.changeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.changeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.changeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.changeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.changeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.changeButton.FillColor = System.Drawing.Color.Black
        Me.changeButton.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.changeButton.ForeColor = System.Drawing.Color.White
        Me.changeButton.Location = New System.Drawing.Point(339, 381)
        Me.changeButton.Name = "changeButton"
        Me.changeButton.ShadowDecoration.BorderRadius = 5
        Me.changeButton.ShadowDecoration.Enabled = True
        Me.changeButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.changeButton.Size = New System.Drawing.Size(150, 50)
        Me.changeButton.TabIndex = 24
        Me.changeButton.Text = "CHANGE"
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
        Me.cancelBtn.Location = New System.Drawing.Point(115, 381)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.PressedColor = System.Drawing.Color.Transparent
        Me.cancelBtn.ShadowDecoration.BorderRadius = 5
        Me.cancelBtn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.cancelBtn.Size = New System.Drawing.Size(130, 50)
        Me.cancelBtn.TabIndex = 25
        Me.cancelBtn.Text = "CANCEL"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'emailLabel
        '
        Me.emailLabel.Font = New System.Drawing.Font("Lato", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.emailLabel.Location = New System.Drawing.Point(69, 95)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(466, 42)
        Me.emailLabel.TabIndex = 26
        Me.emailLabel.Text = "Email"
        Me.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hidePassEnter
        '
        Me.hidePassEnter.Image = CType(resources.GetObject("hidePassEnter.Image"), System.Drawing.Image)
        Me.hidePassEnter.Location = New System.Drawing.Point(414, 184)
        Me.hidePassEnter.Name = "hidePassEnter"
        Me.hidePassEnter.Size = New System.Drawing.Size(30, 30)
        Me.hidePassEnter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hidePassEnter.TabIndex = 27
        Me.hidePassEnter.TabStop = False
        '
        'hidePassReEnter
        '
        Me.hidePassReEnter.Image = CType(resources.GetObject("hidePassReEnter.Image"), System.Drawing.Image)
        Me.hidePassReEnter.Location = New System.Drawing.Point(414, 285)
        Me.hidePassReEnter.Name = "hidePassReEnter"
        Me.hidePassReEnter.Size = New System.Drawing.Size(30, 30)
        Me.hidePassReEnter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hidePassReEnter.TabIndex = 28
        Me.hidePassReEnter.TabStop = False
        '
        'changePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(604, 483)
        Me.Controls.Add(Me.hidePassReEnter)
        Me.Controls.Add(Me.hidePassEnter)
        Me.Controls.Add(Me.emailLabel)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.changeButton)
        Me.Controls.Add(Me.reEnterNewPasswordTextBox)
        Me.Controls.Add(Me.newPasswordTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "changePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "changePassword"
        CType(Me.hidePassEnter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hidePassReEnter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        Else
            Timer1.Stop()
        End If
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

    Friend WithEvents Label1 As Label
    Friend WithEvents newPasswordTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents reEnterNewPasswordTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents changeButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cancelBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents emailLabel As Label
    Friend WithEvents hidePassEnter As PictureBox
    Friend WithEvents hidePassReEnter As PictureBox
End Class
