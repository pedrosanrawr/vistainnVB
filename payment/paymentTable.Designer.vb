﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class paymentTable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(paymentTable))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.menuButton = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.refreshButton = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.menuTimer = New System.Windows.Forms.Timer(Me.components)
        Me.editPaymentButton = New Guna.UI2.WinForms.Guna2Button()
        Me.deletePaymentButton = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.searchPaymentTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dialogTimer = New System.Windows.Forms.Timer(Me.components)
        Me.bookDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.paymentId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paymentMethod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.oxPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.menuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.refreshButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.bookDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuButton
        '
        Me.menuButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuButton.Image = CType(resources.GetObject("menuButton.Image"), System.Drawing.Image)
        Me.menuButton.Location = New System.Drawing.Point(31, 20)
        Me.menuButton.Name = "menuButton"
        Me.menuButton.Size = New System.Drawing.Size(50, 50)
        Me.menuButton.TabIndex = 10
        Me.menuButton.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Raleway", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(882, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 22)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "TABLE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Raleway", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(888, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 34)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "PAYMENTS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1061, 20)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox3.TabIndex = 12
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
        Me.refreshButton.TabIndex = 11
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
        'editPaymentButton
        '
        Me.editPaymentButton.BackColor = System.Drawing.Color.Transparent
        Me.editPaymentButton.BorderRadius = 5
        Me.editPaymentButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editPaymentButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.editPaymentButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.editPaymentButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.editPaymentButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.editPaymentButton.FillColor = System.Drawing.Color.Black
        Me.editPaymentButton.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.editPaymentButton.ForeColor = System.Drawing.Color.White
        Me.editPaymentButton.Location = New System.Drawing.Point(31, 105)
        Me.editPaymentButton.Name = "editPaymentButton"
        Me.editPaymentButton.ShadowDecoration.BorderRadius = 5
        Me.editPaymentButton.ShadowDecoration.Enabled = True
        Me.editPaymentButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.editPaymentButton.Size = New System.Drawing.Size(130, 50)
        Me.editPaymentButton.TabIndex = 15
        Me.editPaymentButton.Text = "EDIT"
        '
        'deletePaymentButton
        '
        Me.deletePaymentButton.BackColor = System.Drawing.Color.Transparent
        Me.deletePaymentButton.BorderRadius = 5
        Me.deletePaymentButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deletePaymentButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.deletePaymentButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.deletePaymentButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.deletePaymentButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.deletePaymentButton.FillColor = System.Drawing.Color.Black
        Me.deletePaymentButton.Font = New System.Drawing.Font("Raleway", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.deletePaymentButton.ForeColor = System.Drawing.Color.White
        Me.deletePaymentButton.Location = New System.Drawing.Point(181, 105)
        Me.deletePaymentButton.Name = "deletePaymentButton"
        Me.deletePaymentButton.ShadowDecoration.BorderRadius = 5
        Me.deletePaymentButton.ShadowDecoration.Enabled = True
        Me.deletePaymentButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.deletePaymentButton.Size = New System.Drawing.Size(130, 50)
        Me.deletePaymentButton.TabIndex = 16
        Me.deletePaymentButton.Text = "DELETE"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1071, 115)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
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
        Me.searchPaymentTextBox.Location = New System.Drawing.Point(681, 105)
        Me.searchPaymentTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.searchPaymentTextBox.Name = "searchPaymentTextBox"
        Me.searchPaymentTextBox.PlaceholderText = "Search"
        Me.searchPaymentTextBox.SelectedText = ""
        Me.searchPaymentTextBox.ShadowDecoration.BorderRadius = 5
        Me.searchPaymentTextBox.ShadowDecoration.Enabled = True
        Me.searchPaymentTextBox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.searchPaymentTextBox.Size = New System.Drawing.Size(430, 50)
        Me.searchPaymentTextBox.TabIndex = 18
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 5
        Me.Guna2Panel1.Controls.Add(Me.bookDGV)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(31, 185)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.BorderRadius = 5
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.Guna2Panel1.Size = New System.Drawing.Size(1080, 570)
        Me.Guna2Panel1.TabIndex = 20
        '
        'dialogTimer
        '
        Me.dialogTimer.Interval = 5
        '
        'bookDGV
        '
        Me.bookDGV.AllowUserToAddRows = False
        Me.bookDGV.AllowUserToDeleteRows = False
        Me.bookDGV.AllowUserToResizeColumns = False
        Me.bookDGV.AllowUserToResizeRows = False
        Me.bookDGV.AlternatingRowsDefaultCellStyle = Me.bookDGV.DefaultCellStyle
        Me.bookDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
        Me.bookDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.bookDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.bookDGV.ColumnHeadersHeight = 40
        Me.bookDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.paymentId, Me.paymentMethod, Me.oxPrice, Me.totalPrice, Me.status})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.bookDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.bookDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bookDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.bookDGV.Location = New System.Drawing.Point(0, 0)
        Me.bookDGV.Name = "bookDGV"
        Me.bookDGV.ReadOnly = True
        Me.bookDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.bookDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.bookDGV.RowHeadersVisible = False
        Me.bookDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.bookDGV.RowTemplate.Height = 40
        Me.bookDGV.RowTemplate.ReadOnly = True
        Me.bookDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.bookDGV.Size = New System.Drawing.Size(1080, 570)
        Me.bookDGV.TabIndex = 2
        Me.bookDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.bookDGV.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bookDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Gray
        Me.bookDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.bookDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.bookDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.bookDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black
        Me.bookDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.bookDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.bookDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.bookDGV.ThemeStyle.HeaderStyle.Height = 40
        Me.bookDGV.ThemeStyle.ReadOnly = True
        Me.bookDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.bookDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.bookDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.bookDGV.ThemeStyle.RowsStyle.Height = 40
        Me.bookDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray
        Me.bookDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'paymentId
        '
        Me.paymentId.HeaderText = "ID"
        Me.paymentId.Name = "paymentId"
        Me.paymentId.ReadOnly = True
        '
        'paymentMethod
        '
        Me.paymentMethod.HeaderText = "PAYMENT METHOD"
        Me.paymentMethod.Name = "paymentMethod"
        Me.paymentMethod.ReadOnly = True
        Me.paymentMethod.Width = 245
        '
        'oxPrice
        '
        Me.oxPrice.HeaderText = "ORDER EXTRAS PRICE"
        Me.oxPrice.Name = "oxPrice"
        Me.oxPrice.ReadOnly = True
        Me.oxPrice.Width = 270
        '
        'totalPrice
        '
        Me.totalPrice.HeaderText = "TOTAL PRICE"
        Me.totalPrice.Name = "totalPrice"
        Me.totalPrice.ReadOnly = True
        Me.totalPrice.Width = 270
        '
        'status
        '
        Me.status.HeaderText = "STATUS"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Width = 195
        '
        'paymentTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1142, 790)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.searchPaymentTextBox)
        Me.Controls.Add(Me.deletePaymentButton)
        Me.Controls.Add(Me.editPaymentButton)
        Me.Controls.Add(Me.menuButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.refreshButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "paymentTable"
        Me.Text = "paymentTable"
        CType(Me.menuButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.refreshButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.bookDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents menuButton As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents refreshButton As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents menuTimer As Timer
    Friend WithEvents editPaymentButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents deletePaymentButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents searchPaymentTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dialogTimer As Timer
    Friend WithEvents bookDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents paymentId As DataGridViewTextBoxColumn
    Friend WithEvents paymentMethod As DataGridViewTextBoxColumn
    Friend WithEvents oxPrice As DataGridViewTextBoxColumn
    Friend WithEvents totalPrice As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
End Class
