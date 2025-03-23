<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class roomTable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(roomTable))
        Me.menuButton = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.refreshButton = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.menuTimer = New System.Windows.Forms.Timer(Me.components)
        Me.addRoomButton = New Guna.UI2.WinForms.Guna2Button()
        Me.editRoomButton = New Guna.UI2.WinForms.Guna2Button()
        Me.deleteRoomButton = New Guna.UI2.WinForms.Guna2Button()
        Me.roomPhotosButton = New Guna.UI2.WinForms.Guna2Button()
        Me.searchRoomButton = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dialogTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.menuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.refreshButton, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Text = "ROOMS"
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
        'refreshButton
        '
        Me.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refreshButton.Image = CType(resources.GetObject("refreshButton.Image"), System.Drawing.Image)
        Me.refreshButton.Location = New System.Drawing.Point(111, 20)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(50, 50)
        Me.refreshButton.TabIndex = 6
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
        'addRoomButton
        '
        Me.addRoomButton.BackColor = System.Drawing.Color.Transparent
        Me.addRoomButton.BorderRadius = 5
        Me.addRoomButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addRoomButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addRoomButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addRoomButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addRoomButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addRoomButton.FillColor = System.Drawing.Color.Black
        Me.addRoomButton.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.addRoomButton.ForeColor = System.Drawing.Color.White
        Me.addRoomButton.Location = New System.Drawing.Point(31, 105)
        Me.addRoomButton.Name = "addRoomButton"
        Me.addRoomButton.ShadowDecoration.BorderRadius = 5
        Me.addRoomButton.ShadowDecoration.Enabled = True
        Me.addRoomButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.addRoomButton.Size = New System.Drawing.Size(130, 50)
        Me.addRoomButton.TabIndex = 10
        Me.addRoomButton.Text = "ADD"
        '
        'editRoomButton
        '
        Me.editRoomButton.BackColor = System.Drawing.Color.Transparent
        Me.editRoomButton.BorderRadius = 5
        Me.editRoomButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editRoomButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.editRoomButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.editRoomButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.editRoomButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.editRoomButton.FillColor = System.Drawing.Color.Black
        Me.editRoomButton.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.editRoomButton.ForeColor = System.Drawing.Color.White
        Me.editRoomButton.Location = New System.Drawing.Point(181, 105)
        Me.editRoomButton.Name = "editRoomButton"
        Me.editRoomButton.ShadowDecoration.BorderRadius = 5
        Me.editRoomButton.ShadowDecoration.Enabled = True
        Me.editRoomButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.editRoomButton.Size = New System.Drawing.Size(130, 50)
        Me.editRoomButton.TabIndex = 11
        Me.editRoomButton.Text = "EDIT"
        '
        'deleteRoomButton
        '
        Me.deleteRoomButton.BackColor = System.Drawing.Color.Transparent
        Me.deleteRoomButton.BorderRadius = 5
        Me.deleteRoomButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deleteRoomButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.deleteRoomButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.deleteRoomButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.deleteRoomButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.deleteRoomButton.FillColor = System.Drawing.Color.Black
        Me.deleteRoomButton.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.deleteRoomButton.ForeColor = System.Drawing.Color.White
        Me.deleteRoomButton.Location = New System.Drawing.Point(331, 105)
        Me.deleteRoomButton.Name = "deleteRoomButton"
        Me.deleteRoomButton.ShadowDecoration.BorderRadius = 5
        Me.deleteRoomButton.ShadowDecoration.Enabled = True
        Me.deleteRoomButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.deleteRoomButton.Size = New System.Drawing.Size(130, 50)
        Me.deleteRoomButton.TabIndex = 12
        Me.deleteRoomButton.Text = "DELETE"
        '
        'roomPhotosButton
        '
        Me.roomPhotosButton.BackColor = System.Drawing.Color.Transparent
        Me.roomPhotosButton.BorderRadius = 5
        Me.roomPhotosButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.roomPhotosButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.roomPhotosButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.roomPhotosButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.roomPhotosButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.roomPhotosButton.FillColor = System.Drawing.Color.Black
        Me.roomPhotosButton.Font = New System.Drawing.Font("Raleway", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.roomPhotosButton.ForeColor = System.Drawing.Color.White
        Me.roomPhotosButton.Location = New System.Drawing.Point(481, 105)
        Me.roomPhotosButton.Name = "roomPhotosButton"
        Me.roomPhotosButton.ShadowDecoration.BorderRadius = 5
        Me.roomPhotosButton.ShadowDecoration.Enabled = True
        Me.roomPhotosButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.roomPhotosButton.Size = New System.Drawing.Size(180, 50)
        Me.roomPhotosButton.TabIndex = 13
        Me.roomPhotosButton.Text = "ROOM PHOTOS"
        '
        'searchRoomButton
        '
        Me.searchRoomButton.BackColor = System.Drawing.Color.Transparent
        Me.searchRoomButton.BorderRadius = 5
        Me.searchRoomButton.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.searchRoomButton.DefaultText = ""
        Me.searchRoomButton.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.searchRoomButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.searchRoomButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchRoomButton.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchRoomButton.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.searchRoomButton.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.searchRoomButton.ForeColor = System.Drawing.Color.Black
        Me.searchRoomButton.HoverState.BorderColor = System.Drawing.Color.Black
        Me.searchRoomButton.Location = New System.Drawing.Point(681, 105)
        Me.searchRoomButton.Margin = New System.Windows.Forms.Padding(6)
        Me.searchRoomButton.Name = "searchRoomButton"
        Me.searchRoomButton.PlaceholderText = "Search"
        Me.searchRoomButton.SelectedText = ""
        Me.searchRoomButton.ShadowDecoration.BorderRadius = 5
        Me.searchRoomButton.ShadowDecoration.Enabled = True
        Me.searchRoomButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.searchRoomButton.Size = New System.Drawing.Size(430, 50)
        Me.searchRoomButton.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1071, 115)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
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
        Me.Guna2Panel1.TabIndex = 16
        '
        'dialogTimer
        '
        Me.dialogTimer.Interval = 3
        '
        'roomTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1142, 790)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.searchRoomButton)
        Me.Controls.Add(Me.roomPhotosButton)
        Me.Controls.Add(Me.deleteRoomButton)
        Me.Controls.Add(Me.editRoomButton)
        Me.Controls.Add(Me.addRoomButton)
        Me.Controls.Add(Me.menuButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.refreshButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "roomTable"
        Me.Text = "N"
        CType(Me.menuButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.refreshButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents menuButton As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents refreshButton As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents menuTimer As Timer
    Friend WithEvents addRoomButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents editRoomButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents deleteRoomButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents roomPhotosButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents searchRoomButton As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dialogTimer As Timer
End Class
