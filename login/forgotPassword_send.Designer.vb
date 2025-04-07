<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forgotPassword_send
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
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.sendButton = New Guna.UI2.WinForms.Guna2Button()
        Me.cancelButton = New Guna.UI2.WinForms.Guna2Button()
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
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "FORGOT PASSWORD"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lato", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(169, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(267, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "SEND ONE-TIME PASSWORD TO:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'emailLabel
        '
        Me.emailLabel.Font = New System.Drawing.Font("Lato", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.emailLabel.Location = New System.Drawing.Point(169, 201)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(267, 21)
        Me.emailLabel.TabIndex = 6
        Me.emailLabel.Text = "Email@email.com"
        Me.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.sendButton.Location = New System.Drawing.Point(237, 331)
        Me.sendButton.Name = "sendButton"
        Me.sendButton.ShadowDecoration.BorderRadius = 5
        Me.sendButton.ShadowDecoration.Enabled = True
        Me.sendButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.sendButton.Size = New System.Drawing.Size(130, 50)
        Me.sendButton.TabIndex = 16
        Me.sendButton.Text = "SEND"
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
        Me.cancelButton.Location = New System.Drawing.Point(237, 401)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.PressedColor = System.Drawing.Color.Transparent
        Me.cancelButton.ShadowDecoration.BorderRadius = 5
        Me.cancelButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.cancelButton.Size = New System.Drawing.Size(130, 50)
        Me.cancelButton.TabIndex = 17
        Me.cancelButton.Text = "CANCEL"
        '
        'forgotPassword_send
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(604, 483)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.sendButton)
        Me.Controls.Add(Me.emailLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "forgotPassword_send"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "forgotPassword_send"
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
    Friend WithEvents emailLabel As Label
    Friend WithEvents sendButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cancelButton As Guna.UI2.WinForms.Guna2Button
End Class
