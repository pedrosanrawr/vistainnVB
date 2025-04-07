<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class roomPhotos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.roomPhotosFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.roomPhotosPanel = New System.Windows.Forms.Panel()
        Me.editRoomPhotosButton = New Guna.UI2.WinForms.Guna2Button()
        Me.roomNameLabel = New System.Windows.Forms.Label()
        Me.roomPhotosPictureBox = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.roomPhotosFlowLayoutPanel.SuspendLayout()
        Me.roomPhotosPanel.SuspendLayout()
        CType(Me.roomPhotosPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Raleway", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(125, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 55)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "ROOM PHOTOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'roomPhotosFlowLayoutPanel
        '
        Me.roomPhotosFlowLayoutPanel.AutoScroll = True
        Me.roomPhotosFlowLayoutPanel.Controls.Add(Me.roomPhotosPanel)
        Me.roomPhotosFlowLayoutPanel.Location = New System.Drawing.Point(0, 135)
        Me.roomPhotosFlowLayoutPanel.Name = "roomPhotosFlowLayoutPanel"
        Me.roomPhotosFlowLayoutPanel.Size = New System.Drawing.Size(571, 655)
        Me.roomPhotosFlowLayoutPanel.TabIndex = 24
        '
        'roomPhotosPanel
        '
        Me.roomPhotosPanel.Controls.Add(Me.editRoomPhotosButton)
        Me.roomPhotosPanel.Controls.Add(Me.roomNameLabel)
        Me.roomPhotosPanel.Controls.Add(Me.roomPhotosPictureBox)
        Me.roomPhotosPanel.Location = New System.Drawing.Point(3, 3)
        Me.roomPhotosPanel.Name = "roomPhotosPanel"
        Me.roomPhotosPanel.Size = New System.Drawing.Size(568, 150)
        Me.roomPhotosPanel.TabIndex = 0
        '
        'editRoomPhotosButton
        '
        Me.editRoomPhotosButton.BackColor = System.Drawing.Color.Transparent
        Me.editRoomPhotosButton.BorderRadius = 5
        Me.editRoomPhotosButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editRoomPhotosButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.editRoomPhotosButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.editRoomPhotosButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.editRoomPhotosButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.editRoomPhotosButton.FillColor = System.Drawing.Color.Black
        Me.editRoomPhotosButton.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.editRoomPhotosButton.ForeColor = System.Drawing.Color.White
        Me.editRoomPhotosButton.Location = New System.Drawing.Point(395, 100)
        Me.editRoomPhotosButton.Name = "editRoomPhotosButton"
        Me.editRoomPhotosButton.ShadowDecoration.BorderRadius = 5
        Me.editRoomPhotosButton.ShadowDecoration.Enabled = True
        Me.editRoomPhotosButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.editRoomPhotosButton.Size = New System.Drawing.Size(130, 50)
        Me.editRoomPhotosButton.TabIndex = 11
        Me.editRoomPhotosButton.Text = "EDIT"
        '
        'roomNameLabel
        '
        Me.roomNameLabel.Font = New System.Drawing.Font("Raleway", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.roomNameLabel.Location = New System.Drawing.Point(168, -8)
        Me.roomNameLabel.Name = "roomNameLabel"
        Me.roomNameLabel.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.roomNameLabel.Size = New System.Drawing.Size(209, 34)
        Me.roomNameLabel.TabIndex = 9
        Me.roomNameLabel.Text = "ROOMS"
        Me.roomNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'roomPhotosPictureBox
        '
        Me.roomPhotosPictureBox.BorderRadius = 5
        Me.roomPhotosPictureBox.ImageRotate = 0!
        Me.roomPhotosPictureBox.Location = New System.Drawing.Point(16, 0)
        Me.roomPhotosPictureBox.Name = "roomPhotosPictureBox"
        Me.roomPhotosPictureBox.Size = New System.Drawing.Size(150, 150)
        Me.roomPhotosPictureBox.TabIndex = 0
        Me.roomPhotosPictureBox.TabStop = False
        '
        'roomPhotos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(571, 790)
        Me.Controls.Add(Me.roomPhotosFlowLayoutPanel)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "roomPhotos"
        Me.Text = "roomPhotos"
        Me.roomPhotosFlowLayoutPanel.ResumeLayout(False)
        Me.roomPhotosPanel.ResumeLayout(False)
        CType(Me.roomPhotosPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents roomPhotosFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents roomPhotosPanel As Panel
    Friend WithEvents roomPhotosPictureBox As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents roomNameLabel As Label
    Friend WithEvents editRoomPhotosButton As Guna.UI2.WinForms.Guna2Button
End Class
