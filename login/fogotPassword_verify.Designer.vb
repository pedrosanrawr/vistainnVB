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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.searchPaymentTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.sendButton = New Guna.UI2.WinForms.Guna2Button()
        Me.cancelButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
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
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Lato", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(126, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(353, 80)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "One-Time Password has been sent to your email. Check your email and type the OTP " &
    "on the text box below:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'searchPaymentTextBox
        '
        Me.searchPaymentTextBox.BackColor = System.Drawing.Color.Transparent
        Me.searchPaymentTextBox.BorderRadius = 5
        Me.searchPaymentTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.searchPaymentTextBox.DefaultText = ""
        Me.searchPaymentTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.searchPaymentTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.searchPaymentTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchPaymentTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchPaymentTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.searchPaymentTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.searchPaymentTextBox.ForeColor = System.Drawing.Color.Black
        Me.searchPaymentTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.searchPaymentTextBox.Location = New System.Drawing.Point(180, 201)
        Me.searchPaymentTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.searchPaymentTextBox.Name = "searchPaymentTextBox"
        Me.searchPaymentTextBox.PlaceholderText = ""
        Me.searchPaymentTextBox.SelectedText = ""
        Me.searchPaymentTextBox.ShadowDecoration.BorderRadius = 5
        Me.searchPaymentTextBox.ShadowDecoration.Enabled = True
        Me.searchPaymentTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.searchPaymentTextBox.Size = New System.Drawing.Size(244, 50)
        Me.searchPaymentTextBox.TabIndex = 19
        '
        'sendButton
        '
        Me.sendButton.BackColor = System.Drawing.Color.Transparent
        Me.sendButton.BorderRadius = 5
        Me.sendButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sendButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.sendButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.sendButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.sendButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.sendButton.FillColor = System.Drawing.Color.Black
        Me.sendButton.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.sendButton.ForeColor = System.Drawing.Color.White
        Me.sendButton.Location = New System.Drawing.Point(237, 281)
        Me.sendButton.Name = "sendButton"
        Me.sendButton.ShadowDecoration.BorderRadius = 5
        Me.sendButton.ShadowDecoration.Enabled = True
        Me.sendButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.sendButton.Size = New System.Drawing.Size(130, 50)
        Me.sendButton.TabIndex = 20
        Me.sendButton.Text = "VERIFY"
        '
        'cancelButton
        '
        Me.cancelButton.BackColor = System.Drawing.Color.Transparent
        Me.cancelButton.BorderColor = System.Drawing.Color.Transparent
        Me.cancelButton.BorderRadius = 5
        Me.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cancelButton.FillColor = System.Drawing.Color.Transparent
        Me.cancelButton.Font = New System.Drawing.Font("Raleway", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cancelButton.ForeColor = System.Drawing.Color.Black
        Me.cancelButton.Location = New System.Drawing.Point(237, 351)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.PressedColor = System.Drawing.Color.Transparent
        Me.cancelButton.ShadowDecoration.BorderRadius = 5
        Me.cancelButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.cancelButton.Size = New System.Drawing.Size(130, 50)
        Me.cancelButton.TabIndex = 21
        Me.cancelButton.Text = "CANCEL"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Lato", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(88, 401)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(427, 30)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Didn't receive a code? You can resend a code in (59s)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fogotPassword_verify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(604, 483)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.sendButton)
        Me.Controls.Add(Me.searchPaymentTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fogotPassword_verify"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fogotPassword_verify"
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

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents searchPaymentTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents sendButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cancelButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
End Class
