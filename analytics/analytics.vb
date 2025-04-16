Imports System.Data.SqlClient
Imports System.Text
Imports System.Windows.Media
Imports LiveCharts
Imports LiveCharts.Wpf

Public Class analytics
    Dim menuForm As Form
    Dim menuVisible As Boolean = False
    Dim menuSpeed As Integer = 20
    Dim database As New database()

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Timer1.Start()

        Select Case Employee.Role
            Case "Staff"
                menuForm = New menuFormStaff()
            Case "Manager"
                menuForm = New menuFormManager()
            Case "Admin"
                menuForm = New menuForm()
        End Select

        menuForm.TopLevel = False
        menuForm.Left = -menuForm.Width
        menuForm.Top = 0
        menuForm.Height = Me.Height
        menuForm.Parent = Me
        menuForm.BringToFront()
        Me.Controls.Add(menuForm)
        menuForm.Show()

        LoadAnalyticsData()
        LoadMonthlyRevenueTrend()
        LoadRecentBookings()
        LoadMonthlyRevenueTrend()
        LoadLiveChartReports()
        reportsDateDropdown.SelectedIndex = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        Else
            Timer1.Stop()
        End If
    End Sub

    Private Sub btnToggleMenu_Click(sender As Object, e As EventArgs) Handles menuButton.Click
        menuForm.BringToFront()
        menuTimer.Start()
    End Sub

    Private Sub menuTimer_Tick(sender As Object, e As EventArgs) Handles menuTimer.Tick
        If menuVisible Then
            If menuForm.Left > -menuForm.Width Then
                menuForm.Left -= menuSpeed
            Else
                menuForm.Left = -menuForm.Width
                menuTimer.Stop()
                menuVisible = False
            End If
        Else
            If menuForm.Left < 0 Then
                menuForm.Left += menuSpeed
                If menuForm.Left > 0 Then menuForm.Left = 0
            Else
                menuForm.Left = 0
                menuTimer.Stop()
                menuVisible = True
            End If
        End If
    End Sub

    Private Sub analytics_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If menuVisible AndAlso Not menuForm.Bounds.Contains(e.Location) Then
            menuTimer.Start()
        End If
    End Sub

    Private Sub LoadAnalyticsData()
        Dim conn As New SqlConnection(database.connectionString)

        Dim revenueQuery As String = "SELECT ISNULL(SUM(pTotalPrice), 0) FROM payments"
        Dim bookingsQuery As String = "SELECT COUNT(*) FROM bookings"
        Dim availableRoomsQuery As String = "SELECT COUNT(*) FROM rooms WHERE rStatus = 'Available'"
        Dim occupiedRoomsQuery As String = "SELECT COUNT(*) FROM rooms WHERE rStatus = 'Occupied'"
        Dim totalRoomsQuery As String = "SELECT COUNT(*) FROM rooms"

        Try
            conn.Open()

            Dim revenueCmd As New SqlCommand(revenueQuery, conn)
            Dim totalRevenue As Decimal = Convert.ToDecimal(revenueCmd.ExecuteScalar())
            totalRevenueLabel.Text = "₱" & totalRevenue.ToString("N1") & "k"

            Dim bookingsCmd As New SqlCommand(bookingsQuery, conn)
            totalBookingsLabel.Text = bookingsCmd.ExecuteScalar().ToString()

            Dim availableCmd As New SqlCommand(availableRoomsQuery, conn)
            availableRoomsLabel.Text = availableCmd.ExecuteScalar().ToString()

            Dim totalRoomsCmd As New SqlCommand(totalRoomsQuery, conn)
            Dim occupiedCmd As New SqlCommand(occupiedRoomsQuery, conn)

            Dim totalRooms As Integer = Convert.ToInt32(totalRoomsCmd.ExecuteScalar())
            Dim occupiedRooms As Integer = Convert.ToInt32(occupiedCmd.ExecuteScalar())

            Dim occupancyRate As Double = If(totalRooms = 0, 0, (occupiedRooms / totalRooms) * 100)
            occupancyRateLabel.Text = occupancyRate.ToString("0") & "%"

        Catch ex As Exception
            MessageBox.Show("Error loading analytics: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LoadMonthlyRevenueTrend()
        Dim conn As New SqlConnection(database.connectionString)
        Dim query As String = "
        SELECT TOP 3 
            FORMAT(b.bCheckInDate, 'yyyy-MM') AS Month,
            SUM(p.pTotalPrice) AS TotalRevenue
        FROM bookings b
        JOIN payments p ON b.bId = p.bId
        WHERE p.pStatus = 'Paid'
        GROUP BY FORMAT(b.bCheckInDate, 'yyyy-MM')
        ORDER BY Month DESC
        "

        Try
            conn.Open()
            Dim cmd As New SqlCommand(query, conn)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            Dim monthsBuilder As New System.Text.StringBuilder()
            Dim revenueBuilder As New System.Text.StringBuilder()

            While reader.Read()
                Dim month As String = reader("Month").ToString()
                Dim revenue As Decimal = Convert.ToDecimal(reader("TotalRevenue"))

                monthsBuilder.Insert(0, month & Environment.NewLine & Environment.NewLine)
                revenueBuilder.Insert(0, "₱" & revenue.ToString("N0") & Environment.NewLine & Environment.NewLine)
            End While

            monthRevenueTrendLabel.Text = monthsBuilder.ToString()
            priceRevenueTrendLabel.Text = revenueBuilder.ToString()

        Catch ex As Exception
            MessageBox.Show("Error loading revenue trend: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LoadRecentBookings()
        Dim conn As New SqlConnection(database.connectionString)
        Dim query As String = "SELECT TOP 3 b.bFname, b.bLname, p.pStatus " &
                              "FROM bookings b " &
                              "JOIN payments p ON b.bID = p.bID " &
                              "ORDER BY b.bCheckInDate DESC"

        Dim cmd As New SqlCommand(query, conn)
        Dim reader As SqlDataReader
        Dim recentBookingsBuilder As New StringBuilder()

        Try
            conn.Open()
            reader = cmd.ExecuteReader()

            While reader.Read()
                Dim firstName As String = reader("bFname").ToString()
                Dim lastName As String = reader("bLname").ToString()
                Dim status As String = reader("pStatus").ToString()

                recentBookingsBuilder.AppendLine($"{firstName} {lastName} - {status}" & Environment.NewLine)
            End While

            recentBookingLabel.Text = recentBookingsBuilder.ToString()

        Catch ex As Exception
            MessageBox.Show("Error loading recent bookings: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LoadLiveChartReports()
        Dim conn As New SqlConnection(database.connectionString)
        Dim range As Integer = 3
        Dim groupSize As Integer = 1

        Select Case reportsDateDropdown.SelectedIndex
            Case 0
                range = 3
                groupSize = 1
            Case 1
                range = 6
                groupSize = 2
            Case 2
                range = 12
                groupSize = 4
        End Select

        Dim endDate As Date = Date.Today
        Dim startDate As Date = endDate.AddMonths(-range)

        Dim query As String = "
        SELECT b.bCheckInDate, p.pTotalPrice
        FROM bookings b
        JOIN payments p ON b.bId = p.bId
        WHERE p.pStatus = 'Paid' AND b.bCheckInDate BETWEEN @startDate AND @endDate
        "

        Dim revenues(2) As Decimal
        Dim occupancies(2) As Integer
        Dim months(2) As String

        Try
            conn.Open()
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@startDate", startDate)
            cmd.Parameters.AddWithValue("@endDate", endDate)

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Dim records As New List(Of Tuple(Of Date, Decimal))

            While reader.Read()
                Dim checkInDate As Date = Convert.ToDateTime(reader("bCheckInDate"))
                Dim revenue As Decimal = Convert.ToDecimal(reader("pTotalPrice"))
                records.Add(Tuple.Create(checkInDate, revenue))
            End While

            For i = 0 To 2
                Dim fromDate As Date = endDate.AddMonths(-range + (i * groupSize))
                Dim toDate As Date = fromDate.AddMonths(groupSize)

                Dim groupRecords = records.Where(Function(r) r.Item1 >= fromDate AndAlso r.Item1 < toDate).ToList()
                If groupRecords.Any() Then
                    revenues(i) = groupRecords.Sum(Function(r) r.Item2)
                    occupancies(i) = groupRecords.Count
                End If
                months(i) = fromDate.ToString("MMM yy") & " - " & toDate.AddDays(-1).ToString("MMM yy")
            Next

            reportsLiveChart.Series = New SeriesCollection From {
            New ColumnSeries With {
                .Title = "Revenue",
                .Values = New ChartValues(Of Decimal)(revenues),
                .Fill = New SolidColorBrush(Color.FromArgb(255, &HC6, &HAC, &H8F))
            },
            New ColumnSeries With {
                .Title = "Occupancy",
                .Values = New ChartValues(Of Integer)(occupancies),
                .Fill = New SolidColorBrush(Color.FromArgb(255, &H5E, &H50, &H3F))
            }
        }

            reportsLiveChart.AxisX.Clear()
            reportsLiveChart.AxisX.Add(New Axis With {
            .Title = "Month Range",
            .Labels = months.ToList()
        })

            reportsLiveChart.AxisY.Clear()
            reportsLiveChart.AxisY.Add(New Axis With {.Title = "Value"})

        Catch ex As Exception
            MessageBox.Show("Error loading chart: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub reportsDateButton_SelectedIndexChanged(sender As Object, e As EventArgs) Handles reportsDateDropdown.SelectedIndexChanged
        LoadLiveChartReports()
    End Sub

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        LoadAnalyticsData()
        LoadMonthlyRevenueTrend()
        LoadRecentBookings()
        LoadMonthlyRevenueTrend()
        LoadLiveChartReports()
    End Sub

    Private Sub recentBookingsPanel_Click(sender As Object, e As EventArgs) Handles recentBookingsPanel.Click
        basePage.loadForm(New bookingTable())
    End Sub
End Class
