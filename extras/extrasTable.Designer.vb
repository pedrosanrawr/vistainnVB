<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class extrasTable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(extrasTable))
        Me.menuButton = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.refreshButton = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.menuTimer = New System.Windows.Forms.Timer(Me.components)
        Me.addExtrasButton = New Guna.UI2.WinForms.Guna2Button()
        Me.editExtrasButton = New Guna.UI2.WinForms.Guna2Button()
        Me.deleteExtrasButton = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.searchTextBox = New Guna.UI2.WinForms.Guna2TextBox()
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
        Me.menuButton.TabIndex = 15
        Me.menuButton.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Raleway", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(882, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 22)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "TABLE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Raleway", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(888, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 34)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "EXTRAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1061, 20)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox3.TabIndex = 17
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
        Me.refreshButton.TabIndex = 16
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
        'addExtrasButton
        '
        Me.addExtrasButton.BackColor = System.Drawing.Color.Transparent
        Me.addExtrasButton.BorderRadius = 5
        Me.addExtrasButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addExtrasButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addExtrasButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addExtrasButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addExtrasButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addExtrasButton.FillColor = System.Drawing.Color.Black
        Me.addExtrasButton.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.addExtrasButton.ForeColor = System.Drawing.Color.White
        Me.addExtrasButton.Location = New System.Drawing.Point(31, 105)
        Me.addExtrasButton.Name = "addExtrasButton"
        Me.addExtrasButton.ShadowDecoration.BorderRadius = 5
        Me.addExtrasButton.ShadowDecoration.Enabled = True
        Me.addExtrasButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.addExtrasButton.Size = New System.Drawing.Size(130, 50)
        Me.addExtrasButton.TabIndex = 20
        Me.addExtrasButton.Text = "ADD"
        '
        'editExtrasButton
        '
        Me.editExtrasButton.BackColor = System.Drawing.Color.Transparent
        Me.editExtrasButton.BorderRadius = 5
        Me.editExtrasButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editExtrasButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.editExtrasButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.editExtrasButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.editExtrasButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.editExtrasButton.FillColor = System.Drawing.Color.Black
        Me.editExtrasButton.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.editExtrasButton.ForeColor = System.Drawing.Color.White
        Me.editExtrasButton.Location = New System.Drawing.Point(181, 105)
        Me.editExtrasButton.Name = "editExtrasButton"
        Me.editExtrasButton.ShadowDecoration.BorderRadius = 5
        Me.editExtrasButton.ShadowDecoration.Enabled = True
        Me.editExtrasButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.editExtrasButton.Size = New System.Drawing.Size(130, 50)
        Me.editExtrasButton.TabIndex = 21
        Me.editExtrasButton.Text = "EDIT"
        '
        'deleteExtrasButton
        '
        Me.deleteExtrasButton.BackColor = System.Drawing.Color.Transparent
        Me.deleteExtrasButton.BorderRadius = 5
        Me.deleteExtrasButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deleteExtrasButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.deleteExtrasButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.deleteExtrasButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.deleteExtrasButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.deleteExtrasButton.FillColor = System.Drawing.Color.Black
        Me.deleteExtrasButton.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.deleteExtrasButton.ForeColor = System.Drawing.Color.White
        Me.deleteExtrasButton.Location = New System.Drawing.Point(331, 105)
        Me.deleteExtrasButton.Name = "deleteExtrasButton"
        Me.deleteExtrasButton.ShadowDecoration.BorderRadius = 5
        Me.deleteExtrasButton.ShadowDecoration.Enabled = True
        Me.deleteExtrasButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.deleteExtrasButton.Size = New System.Drawing.Size(130, 50)
        Me.deleteExtrasButton.TabIndex = 22
        Me.deleteExtrasButton.Text = "DELETE"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1071, 115)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'searchTextBox
        '
        Me.searchTextBox.BackColor = System.Drawing.Color.Transparent
        Me.searchTextBox.BorderRadius = 5
        Me.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.searchTextBox.DefaultText = ""
        Me.searchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.searchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.searchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.searchTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.searchTextBox.ForeColor = System.Drawing.Color.Black
        Me.searchTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.searchTextBox.Location = New System.Drawing.Point(681, 105)
        Me.searchTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.PlaceholderText = "Search"
        Me.searchTextBox.SelectedText = ""
        Me.searchTextBox.ShadowDecoration.BorderRadius = 5
        Me.searchTextBox.ShadowDecoration.Enabled = True
        Me.searchTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.searchTextBox.Size = New System.Drawing.Size(430, 50)
        Me.searchTextBox.TabIndex = 23
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
        Me.Guna2Panel1.TabIndex = 25
        '
        'dialogTimer
        '
        Me.dialogTimer.Interval = 5
        '
        'extrasTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1142, 790)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.searchTextBox)
        Me.Controls.Add(Me.deleteExtrasButton)
        Me.Controls.Add(Me.editExtrasButton)
        Me.Controls.Add(Me.addExtrasButton)
        Me.Controls.Add(Me.menuButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.refreshButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "extrasTable"
        Me.Text = "extrasTable"
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
    Friend WithEvents addExtrasButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents editExtrasButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents deleteExtrasButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents searchTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dialogTimer As Timer
End Class
