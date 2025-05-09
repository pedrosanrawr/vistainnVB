<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class orderExtras
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(orderExtras))
        Me.dialogTimer = New System.Windows.Forms.Timer(Me.components)
        Me.oxExtrasDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.searchOxExtrasTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.menuTimer = New System.Windows.Forms.Timer(Me.components)
        Me.fadeIn = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.refreshButton = New System.Windows.Forms.PictureBox()
        Me.menuButton = New System.Windows.Forms.PictureBox()
        Me.bookId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.orderExtrasItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.orderExtrasQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bookingReferenceNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.oxExtrasDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.refreshButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.menuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dialogTimer
        '
        Me.dialogTimer.Interval = 5
        '
        'oxExtrasDGV
        '
        Me.oxExtrasDGV.AllowUserToAddRows = False
        Me.oxExtrasDGV.AllowUserToDeleteRows = False
        Me.oxExtrasDGV.AllowUserToResizeColumns = False
        Me.oxExtrasDGV.AllowUserToResizeRows = False
        Me.oxExtrasDGV.AlternatingRowsDefaultCellStyle = Me.oxExtrasDGV.DefaultCellStyle
        Me.oxExtrasDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.oxExtrasDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.oxExtrasDGV.ColumnHeadersHeight = 40
        Me.oxExtrasDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bookId, Me.orderExtrasItem, Me.orderExtrasQuantity, Me.bookingReferenceNo})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.oxExtrasDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.oxExtrasDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oxExtrasDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.oxExtrasDGV.Location = New System.Drawing.Point(0, 0)
        Me.oxExtrasDGV.Name = "oxExtrasDGV"
        Me.oxExtrasDGV.ReadOnly = True
        Me.oxExtrasDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.oxExtrasDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.oxExtrasDGV.RowHeadersVisible = False
        Me.oxExtrasDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.oxExtrasDGV.RowTemplate.Height = 40
        Me.oxExtrasDGV.RowTemplate.ReadOnly = True
        Me.oxExtrasDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.oxExtrasDGV.Size = New System.Drawing.Size(1080, 570)
        Me.oxExtrasDGV.TabIndex = 2
        Me.oxExtrasDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.oxExtrasDGV.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oxExtrasDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.oxExtrasDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Gray
        Me.oxExtrasDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.oxExtrasDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.oxExtrasDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.oxExtrasDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black
        Me.oxExtrasDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.oxExtrasDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oxExtrasDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.oxExtrasDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.oxExtrasDGV.ThemeStyle.HeaderStyle.Height = 40
        Me.oxExtrasDGV.ThemeStyle.ReadOnly = True
        Me.oxExtrasDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.oxExtrasDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.oxExtrasDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oxExtrasDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.oxExtrasDGV.ThemeStyle.RowsStyle.Height = 40
        Me.oxExtrasDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray
        Me.oxExtrasDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 5
        Me.Guna2Panel1.Controls.Add(Me.oxExtrasDGV)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(31, 185)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.BorderRadius = 5
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.Guna2Panel1.Size = New System.Drawing.Size(1080, 570)
        Me.Guna2Panel1.TabIndex = 30
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1071, 115)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'searchOxExtrasTextBox
        '
        Me.searchOxExtrasTextBox.BackColor = System.Drawing.Color.Transparent
        Me.searchOxExtrasTextBox.BorderRadius = 5
        Me.searchOxExtrasTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.searchOxExtrasTextBox.DefaultText = ""
        Me.searchOxExtrasTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.searchOxExtrasTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.searchOxExtrasTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchOxExtrasTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchOxExtrasTextBox.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.searchOxExtrasTextBox.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.searchOxExtrasTextBox.ForeColor = System.Drawing.Color.Black
        Me.searchOxExtrasTextBox.HoverState.BorderColor = System.Drawing.Color.Black
        Me.searchOxExtrasTextBox.Location = New System.Drawing.Point(681, 105)
        Me.searchOxExtrasTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.searchOxExtrasTextBox.Name = "searchOxExtrasTextBox"
        Me.searchOxExtrasTextBox.PlaceholderText = "Search"
        Me.searchOxExtrasTextBox.SelectedText = ""
        Me.searchOxExtrasTextBox.ShadowDecoration.BorderRadius = 5
        Me.searchOxExtrasTextBox.ShadowDecoration.Enabled = True
        Me.searchOxExtrasTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.searchOxExtrasTextBox.Size = New System.Drawing.Size(430, 50)
        Me.searchOxExtrasTextBox.TabIndex = 28
        '
        'menuTimer
        '
        Me.menuTimer.Interval = 5
        '
        'fadeIn
        '
        Me.fadeIn.Interval = 5
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Raleway", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(882, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 22)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "TABLE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Raleway", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(825, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 34)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "ORDER EXTRAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1061, 20)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox3.TabIndex = 23
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
        Me.refreshButton.TabIndex = 22
        Me.refreshButton.TabStop = False
        '
        'menuButton
        '
        Me.menuButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuButton.Image = CType(resources.GetObject("menuButton.Image"), System.Drawing.Image)
        Me.menuButton.Location = New System.Drawing.Point(31, 20)
        Me.menuButton.Name = "menuButton"
        Me.menuButton.Size = New System.Drawing.Size(50, 50)
        Me.menuButton.TabIndex = 21
        Me.menuButton.TabStop = False
        '
        'bookId
        '
        Me.bookId.DataPropertyName = "bId"
        Me.bookId.HeaderText = "ID"
        Me.bookId.Name = "bookId"
        Me.bookId.ReadOnly = True
        '
        'orderExtrasItem
        '
        Me.orderExtrasItem.DataPropertyName = "oxExtras"
        Me.orderExtrasItem.HeaderText = "ORDERED ITEMS"
        Me.orderExtrasItem.Name = "orderExtrasItem"
        Me.orderExtrasItem.ReadOnly = True
        '
        'orderExtrasQuantity
        '
        Me.orderExtrasQuantity.DataPropertyName = "oxQuantity"
        Me.orderExtrasQuantity.HeaderText = "QUANTITY"
        Me.orderExtrasQuantity.Name = "orderExtrasQuantity"
        Me.orderExtrasQuantity.ReadOnly = True
        '
        'bookingReferenceNo
        '
        Me.bookingReferenceNo.DataPropertyName = "bReferenceNo"
        Me.bookingReferenceNo.HeaderText = "REFERENCE NO"
        Me.bookingReferenceNo.Name = "bookingReferenceNo"
        Me.bookingReferenceNo.ReadOnly = True
        '
        'orderExtras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1142, 790)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.searchOxExtrasTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.refreshButton)
        Me.Controls.Add(Me.menuButton)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "orderExtras"
        Me.Text = "orderExtras"
        CType(Me.oxExtrasDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.refreshButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.menuButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dialogTimer As Timer
    Friend WithEvents oxExtrasDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents searchOxExtrasTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents menuTimer As Timer
    Friend WithEvents fadeIn As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents refreshButton As PictureBox
    Friend WithEvents menuButton As PictureBox
    Friend WithEvents bookId As DataGridViewTextBoxColumn
    Friend WithEvents orderExtrasItem As DataGridViewTextBoxColumn
    Friend WithEvents orderExtrasQuantity As DataGridViewTextBoxColumn
    Friend WithEvents bookingReferenceNo As DataGridViewTextBoxColumn
End Class
