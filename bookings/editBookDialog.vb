Imports System.Data.SqlClient
Imports System.Net
Imports System.Security.Cryptography
Imports System.Text.RegularExpressions
Imports System.Web.Security
Imports System.Web.UI.HtmlControls

Public Class editBookDialog
    Private WithEvents inCalendar As New MonthCalendar()
    Private WithEvents outCalendar As New MonthCalendar()
    Dim database As New database()
    Public Event BookEdited As EventHandler

    Public Sub PopulateFields(bookId As Integer, bookFname As String, bookLname As String, bookEmail As String, bookPhoneNo As String, bookRoomName As String, bookRoomNo As String, bookPax As Integer, bookCheckInDate As Date, bookCheckInTime As String, bookCheckOutDate As Date, bookCheckOutTime As String)
        bookingIdTextBox.Text = bookId
        firstNameTextBox.Text = bookFname
        lastNameTextBox.Text = bookLname
        emailTextBox.Text = bookEmail
        phoneNoTextBox.Text = bookPhoneNo
        roomNameComboBox.Text = bookRoomName
        roomNoComboBox.Text = bookRoomNo
        paxComboBox.Text = bookPax
        inDatePickerButton.Text = bookCheckInDate
        inTimeComboBox.Text = bookCheckInTime
        outDatePickerButton.Text = bookCheckOutDate
        outTimeComboBox.Text = bookCheckOutTime
    End Sub

    Private Sub editBookDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inCalendar.Visible = False
        inCalendar.MaxSelectionCount = 1
        inCalendar.ShowTodayCircle = True
        inCalendar.ShowWeekNumbers = False
        inCalendar.MinDate = Date.Today
        Me.Controls.Add(inCalendar)

        outCalendar.Visible = False
        outCalendar.MaxSelectionCount = 1
        outCalendar.ShowTodayCircle = True
        outCalendar.ShowWeekNumbers = False
        outCalendar.MinDate = Date.Today.AddDays(1)
        Me.Controls.Add(outCalendar)
    End Sub

    Private Sub inDatePickerButton_Click(sender As Object, e As EventArgs) Handles inDatePickerButton.Click
        inCalendar.Location = New Point(inDatePickerButton.Left, inDatePickerButton.Bottom)
        inCalendar.Visible = Not inCalendar.Visible
        inCalendar.BringToFront()
    End Sub

    Private Sub inCalendar_DateSelected(sender As Object, e As DateRangeEventArgs) Handles inCalendar.DateSelected
        inDatePickerButton.Text = e.Start.ToString("dd MMM yyyy")
        inCalendar.Visible = False
    End Sub

    Private Sub addBookDialog_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        If inCalendar.Visible Then inCalendar.Visible = False
        If outCalendar.Visible Then outCalendar.Visible = False
    End Sub

    Private Sub outDateTimePicker_Click(sender As Object, e As EventArgs) Handles outDatePickerButton.Click
        outCalendar.Location = New Point(outDatePickerButton.Left, outDatePickerButton.Bottom)
        outCalendar.Visible = Not outCalendar.Visible
        outCalendar.BringToFront()
    End Sub

    Private Sub outCalendar_DateSelected(sender As Object, e As DateRangeEventArgs) Handles outCalendar.DateSelected
        outDatePickerButton.Text = e.Start.ToString("dd MMM yyyy")
        outCalendar.Visible = False
    End Sub

    Private Sub logInButton_Click(sender As Object, e As EventArgs) Handles logInButton.Click
        Dim bId As Integer = bookingIdTextBox.Text
        Dim bFname As String = firstNameTextBox.Text.Trim()
        Dim bLname As String = lastNameTextBox.Text.Trim()
        Dim bEmail As String = emailTextBox.Text.Trim()
        Dim bPhoneNo As String = phoneNoTextBox.Text.Trim()
        Dim bRoomNo As String = roomNoComboBox.Text
        Dim bRName As String = roomNameComboBox.Text
        Dim bPax As Integer = paxComboBox.Text
        Dim bCheckInDate As Date = Date.Parse(inDatePickerButton.Text)
        Dim bCheckInTime As String = inTimeComboBox.Text
        Dim bCheckOutDate As Date = Date.Parse(outDatePickerButton.Text)
        Dim bCheckOutTime As String = outTimeComboBox.Text

        Dim validator As New bookValidation()

        If Not validator.IsNameValid(bFname) Then
            MessageBox.Show("First name must contain only letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not validator.IsNameValid(bLname) Then
            MessageBox.Show("Last name must contain only letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not validator.IsEmailValid(bEmail) Then
            MessageBox.Show("Invalid email format.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not validator.IsPhoneValid(bPhoneNo) Then
            MessageBox.Show("Phone number must be 10-15 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not validator.AreRoomSelectionsValid(bRName, bRoomNo) Then
            MessageBox.Show("Please select a room name and room number.", "Missing Room", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If validator.IsBookingConflict(bRName, bRoomNo, bCheckInDate, bCheckOutDate, bId) Then
            MessageBox.Show($"Room '{bRName}' No. '{bRoomNo}' is already booked between {bCheckInDate:dd MMM yyyy} and {bCheckOutDate:dd MMM yyyy}.", "Booking Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not validator.IsDateRangeValid(bCheckInDate, bCheckOutDate) Then
            MessageBox.Show("Check-out date must be after check-in date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not validator.IsTimeRangeValid(bCheckInDate, bCheckOutDate, bCheckInTime, bCheckOutTime) Then
            MessageBox.Show("Check-out time must be after check-in time when dates are the same.", "Invalid Time Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim query As String = "UPDATE bookings SET bFname=@bFname, bLname=@bLname, bEmail=@bEmail, bPhoneNo=@bPhoneNo, bRoomNo=@bRoomNo, bRName=@bRName, bPax=@bPax, 
        bCheckInDate=@bCheckInDate, bCheckInTime=@bCheckInTime, bCheckOutDate=@bCheckOutDate, bCheckOutTime=@bCheckOutTime WHERE bId=@bId"

        Using conn As New SqlConnection(database.connectionString)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@bId", bId)
            cmd.Parameters.AddWithValue("@bFname", bFname)
            cmd.Parameters.AddWithValue("@bLname", bLname)
            cmd.Parameters.AddWithValue("@bEmail", bEmail)
            cmd.Parameters.AddWithValue("@bPhoneNo", bPhoneNo)
            cmd.Parameters.AddWithValue("@bRoomNo", bRoomNo)
            cmd.Parameters.AddWithValue("@bRName", bRName)
            cmd.Parameters.AddWithValue("@bPax", bPax)
            cmd.Parameters.AddWithValue("@bCheckInDate", bCheckInDate)
            cmd.Parameters.AddWithValue("@bCheckInTime", bCheckInTime)
            cmd.Parameters.AddWithValue("@bCheckOutDate", bCheckOutDate)
            cmd.Parameters.AddWithValue("@bCheckOutTime", bCheckOutTime)

            Try
                conn.Open()
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Booking edited successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RaiseEvent BookEdited(Me, EventArgs.Empty)
                Else
                    MessageBox.Show("An error occurred while editing the booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Private Sub roomNameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles roomNameComboBox.SelectedIndexChanged
        Dim selectedRoomName As String = roomNameComboBox.Text
        Dim selectedRoomNo As String = roomNoComboBox.Text

        LoadAvailableRoomNumbers(selectedRoomName)
    End Sub

    Private Sub LoadAvailableRoomNumbers(roomName As String)
        roomNoComboBox.Items.Clear()

        Dim query As String = "SELECT rRoomNo FROM rooms WHERE rName = @rName AND rStatus = 'Available'"

        Using conn As New SqlConnection(database.connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@rName", roomName)

                Try
                    conn.Open()
                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        roomNoComboBox.Items.Add(reader("rRoomNo").ToString())
                    End While

                Catch ex As Exception
                    MessageBox.Show("Failed to load room numbers: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
End Class