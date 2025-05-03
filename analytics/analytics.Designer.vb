Imports Siticone.Desktop.UI.Winforms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class analytics
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(analytics))
        Me.menuButton = New System.Windows.Forms.PictureBox()
        Me.refreshButton = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fadeIn = New System.Windows.Forms.Timer(Me.components)
        Me.menuTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.totalRevenueLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.totalBookingsLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.availableRoomsLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.occupancyRateLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.reportsLiveChart = New LiveCharts.WinForms.CartesianChart()
        Me.reportsDateDropdown = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.priceRevenueTrendLabel = New System.Windows.Forms.Label()
        Me.monthRevenueTrendLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.recentBookingsPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.recentBookingLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.menuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.refreshButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.Guna2Panel6.SuspendLayout()
        Me.recentBookingsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuButton
        '
        Me.menuButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuButton.Image = CType(resources.GetObject("menuButton.Image"), System.Drawing.Image)
        Me.menuButton.Location = New System.Drawing.Point(31, 20)
        Me.menuButton.Name = "menuButton"
        Me.menuButton.Size = New System.Drawing.Size(50, 50)
        Me.menuButton.TabIndex = 0
        Me.menuButton.TabStop = False
        '
        'refreshButton
        '
        Me.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refreshButton.Image = CType(resources.GetObject("refreshButton.Image"), System.Drawing.Image)
        Me.refreshButton.Location = New System.Drawing.Point(111, 20)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(50, 50)
        Me.refreshButton.TabIndex = 1
        Me.refreshButton.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1061, 20)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Raleway", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(888, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ANALYTICS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Raleway", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(882, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "DASHBOARD"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fadeIn
        '
        Me.fadeIn.Interval = 5
        '
        'menuTimer
        '
        Me.menuTimer.Interval = 5
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 5
        Me.Guna2Panel1.Controls.Add(Me.totalRevenueLabel)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(31, 105)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(253, 130)
        Me.Guna2Panel1.TabIndex = 5
        '
        'totalRevenueLabel
        '
        Me.totalRevenueLabel.Font = New System.Drawing.Font("Lato", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.totalRevenueLabel.ForeColor = System.Drawing.Color.White
        Me.totalRevenueLabel.Location = New System.Drawing.Point(28, 64)
        Me.totalRevenueLabel.Name = "totalRevenueLabel"
        Me.totalRevenueLabel.Size = New System.Drawing.Size(211, 42)
        Me.totalRevenueLabel.TabIndex = 1
        Me.totalRevenueLabel.Text = "$120.4k"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Raleway", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(31, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "TOTAL REVENUE"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderRadius = 5
        Me.Guna2Panel2.Controls.Add(Me.totalBookingsLabel)
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(306, 105)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(253, 130)
        Me.Guna2Panel2.TabIndex = 6
        '
        'totalBookingsLabel
        '
        Me.totalBookingsLabel.Font = New System.Drawing.Font("Lato", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.totalBookingsLabel.ForeColor = System.Drawing.Color.Black
        Me.totalBookingsLabel.Location = New System.Drawing.Point(28, 64)
        Me.totalBookingsLabel.Name = "totalBookingsLabel"
        Me.totalBookingsLabel.Size = New System.Drawing.Size(193, 42)
        Me.totalBookingsLabel.TabIndex = 2
        Me.totalBookingsLabel.Text = "50,345"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Raleway", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(31, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "TOTAL BOOKINGS"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderRadius = 5
        Me.Guna2Panel3.Controls.Add(Me.availableRoomsLabel)
        Me.Guna2Panel3.Controls.Add(Me.Label5)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Guna2Panel3.Location = New System.Drawing.Point(581, 105)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(253, 130)
        Me.Guna2Panel3.TabIndex = 7
        '
        'availableRoomsLabel
        '
        Me.availableRoomsLabel.Font = New System.Drawing.Font("Lato", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.availableRoomsLabel.ForeColor = System.Drawing.Color.Black
        Me.availableRoomsLabel.Location = New System.Drawing.Point(28, 64)
        Me.availableRoomsLabel.Name = "availableRoomsLabel"
        Me.availableRoomsLabel.Size = New System.Drawing.Size(186, 42)
        Me.availableRoomsLabel.TabIndex = 3
        Me.availableRoomsLabel.Text = "150"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Raleway", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(31, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 25)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "AVAILABLE ROOMS"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel4.BorderRadius = 5
        Me.Guna2Panel4.Controls.Add(Me.occupancyRateLabel)
        Me.Guna2Panel4.Controls.Add(Me.Label6)
        Me.Guna2Panel4.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2Panel4.Location = New System.Drawing.Point(857, 105)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(253, 130)
        Me.Guna2Panel4.TabIndex = 8
        '
        'occupancyRateLabel
        '
        Me.occupancyRateLabel.Font = New System.Drawing.Font("Lato", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.occupancyRateLabel.ForeColor = System.Drawing.Color.White
        Me.occupancyRateLabel.Location = New System.Drawing.Point(28, 64)
        Me.occupancyRateLabel.Name = "occupancyRateLabel"
        Me.occupancyRateLabel.Size = New System.Drawing.Size(166, 42)
        Me.occupancyRateLabel.TabIndex = 4
        Me.occupancyRateLabel.Text = "40%"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Raleway", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(31, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 25)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "OCCUPANCY RATE"
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel5.BorderRadius = 5
        Me.Guna2Panel5.Controls.Add(Me.reportsLiveChart)
        Me.Guna2Panel5.Controls.Add(Me.reportsDateDropdown)
        Me.Guna2Panel5.Controls.Add(Me.Label7)
        Me.Guna2Panel5.FillColor = System.Drawing.Color.White
        Me.Guna2Panel5.Location = New System.Drawing.Point(31, 255)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(528, 500)
        Me.Guna2Panel5.TabIndex = 6
        '
        'reportsLiveChart
        '
        Me.reportsLiveChart.Location = New System.Drawing.Point(36, 83)
        Me.reportsLiveChart.Name = "reportsLiveChart"
        Me.reportsLiveChart.Size = New System.Drawing.Size(460, 383)
        Me.reportsLiveChart.TabIndex = 3
        Me.reportsLiveChart.Text = "CartesianChart1"
        '
        'reportsDateDropdown
        '
        Me.reportsDateDropdown.BackColor = System.Drawing.Color.Transparent
        Me.reportsDateDropdown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.reportsDateDropdown.BorderRadius = 5
        Me.reportsDateDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.reportsDateDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.reportsDateDropdown.FillColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.reportsDateDropdown.FocusedColor = System.Drawing.Color.Black
        Me.reportsDateDropdown.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.reportsDateDropdown.Font = New System.Drawing.Font("Lato", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.reportsDateDropdown.ForeColor = System.Drawing.Color.Black
        Me.reportsDateDropdown.ItemHeight = 30
        Me.reportsDateDropdown.Items.AddRange(New Object() {"1 month", "6 months", "12 months"})
        Me.reportsDateDropdown.Location = New System.Drawing.Point(346, 20)
        Me.reportsDateDropdown.Name = "reportsDateDropdown"
        Me.reportsDateDropdown.Size = New System.Drawing.Size(150, 36)
        Me.reportsDateDropdown.StartIndex = 0
        Me.reportsDateDropdown.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Raleway", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(31, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 25)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "REPORTS"
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel6.BorderRadius = 5
        Me.Guna2Panel6.Controls.Add(Me.Guna2Shapes1)
        Me.Guna2Panel6.Controls.Add(Me.priceRevenueTrendLabel)
        Me.Guna2Panel6.Controls.Add(Me.monthRevenueTrendLabel)
        Me.Guna2Panel6.Controls.Add(Me.Label8)
        Me.Guna2Panel6.FillColor = System.Drawing.Color.White
        Me.Guna2Panel6.Location = New System.Drawing.Point(581, 255)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.Size = New System.Drawing.Size(530, 230)
        Me.Guna2Panel6.TabIndex = 7
        '
        'Guna2Shapes1
        '
        Me.Guna2Shapes1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Shapes1.BorderThickness = 1
        Me.Guna2Shapes1.FillColor = System.Drawing.Color.Black
        Me.Guna2Shapes1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.Guna2Shapes1.LineThickness = 3
        Me.Guna2Shapes1.Location = New System.Drawing.Point(251, 68)
        Me.Guna2Shapes1.Name = "Guna2Shapes1"
        Me.Guna2Shapes1.PolygonSkip = 1
        Me.Guna2Shapes1.Rotate = 0!
        Me.Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line
        Me.Guna2Shapes1.Size = New System.Drawing.Size(29, 147)
        Me.Guna2Shapes1.TabIndex = 5
        Me.Guna2Shapes1.Text = "Guna2Shapes1"
        Me.Guna2Shapes1.UseTransparentBackground = True
        Me.Guna2Shapes1.Zoom = 80
        '
        'priceRevenueTrendLabel
        '
        Me.priceRevenueTrendLabel.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.priceRevenueTrendLabel.ForeColor = System.Drawing.Color.Black
        Me.priceRevenueTrendLabel.Location = New System.Drawing.Point(294, 83)
        Me.priceRevenueTrendLabel.Name = "priceRevenueTrendLabel"
        Me.priceRevenueTrendLabel.Size = New System.Drawing.Size(203, 120)
        Me.priceRevenueTrendLabel.TabIndex = 4
        Me.priceRevenueTrendLabel.Text = "₱20,000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "₱30,000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "₱15,000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.priceRevenueTrendLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'monthRevenueTrendLabel
        '
        Me.monthRevenueTrendLabel.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.monthRevenueTrendLabel.ForeColor = System.Drawing.Color.Black
        Me.monthRevenueTrendLabel.Location = New System.Drawing.Point(33, 83)
        Me.monthRevenueTrendLabel.Name = "monthRevenueTrendLabel"
        Me.monthRevenueTrendLabel.Size = New System.Drawing.Size(203, 120)
        Me.monthRevenueTrendLabel.TabIndex = 3
        Me.monthRevenueTrendLabel.Text = "2025-01" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2025-02" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2025-03"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Raleway", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(32, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(253, 25)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "MONTHLY REVENUE TREND"
        '
        'recentBookingsPanel
        '
        Me.recentBookingsPanel.BackColor = System.Drawing.Color.Transparent
        Me.recentBookingsPanel.BorderRadius = 5
        Me.recentBookingsPanel.Controls.Add(Me.recentBookingLabel)
        Me.recentBookingsPanel.Controls.Add(Me.Label9)
        Me.recentBookingsPanel.FillColor = System.Drawing.Color.White
        Me.recentBookingsPanel.Location = New System.Drawing.Point(581, 505)
        Me.recentBookingsPanel.Name = "recentBookingsPanel"
        Me.recentBookingsPanel.Size = New System.Drawing.Size(530, 250)
        Me.recentBookingsPanel.TabIndex = 8
        '
        'recentBookingLabel
        '
        Me.recentBookingLabel.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.recentBookingLabel.ForeColor = System.Drawing.Color.Black
        Me.recentBookingLabel.Location = New System.Drawing.Point(33, 83)
        Me.recentBookingLabel.Name = "recentBookingLabel"
        Me.recentBookingLabel.Size = New System.Drawing.Size(461, 116)
        Me.recentBookingLabel.TabIndex = 6
        Me.recentBookingLabel.Text = "Peter Dones - Paid" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Taylor Swift - Paid" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ed Sheeran - Paid"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Raleway", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(33, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(181, 25)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "RECENT BOOKINGS"
        '
        'analytics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1142, 790)
        Me.Controls.Add(Me.recentBookingsPanel)
        Me.Controls.Add(Me.Guna2Panel6)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.menuButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.refreshButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "analytics"
        Me.Text = "nb"
        CType(Me.menuButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.refreshButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        Me.Guna2Panel6.ResumeLayout(False)
        Me.Guna2Panel6.PerformLayout()
        Me.recentBookingsPanel.ResumeLayout(False)
        Me.recentBookingsPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents menuButton As PictureBox
    Friend WithEvents refreshButton As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents fadeIn As Timer
    Friend WithEvents menuTimer As Timer
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents recentBookingsPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents SiticoneComboBox3 As Siticone.Desktop.UI.Winforms.SiticoneComboBox
    Friend WithEvents reportsDateDropdown As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents totalRevenueLabel As Label
    Friend WithEvents totalBookingsLabel As Label
    Friend WithEvents availableRoomsLabel As Label
    Friend WithEvents occupancyRateLabel As Label
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents priceRevenueTrendLabel As Label
    Friend WithEvents monthRevenueTrendLabel As Label
    Friend WithEvents recentBookingLabel As Label
    Friend WithEvents reportsLiveChart As LiveCharts.WinForms.CartesianChart
End Class
