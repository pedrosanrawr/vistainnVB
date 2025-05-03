Imports System.Data.SqlClient

Public Class bookingTable
    Dim menuForm As Form
    Dim editBookDialog As New editBookDialog()
    Dim overlayPanel As New Panel()
    Dim menuVisible As Boolean = False
    Dim slidingIn As Boolean = False
    Dim editingIn As Boolean = False
    Dim HideButtons As New HideButtons()
    Dim database As New database()
    Dim bookBindingSource As New BindingSource()
    Public Event BookDeleted As EventHandler

    Private Sub bookingTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        fadeIn.Start()

        Select Case Employee.Role
            Case "Staff"
                menuForm = New menuFormStaff()
            Case "Manager"
                menuForm = New menuFormManager()
            Case "Admin"
                menuForm = New menuForm()
        End Select

        overlayPanel.Dock = DockStyle.Fill
        overlayPanel.BackColor = Color.Transparent
        overlayPanel.Visible = False
        overlayPanel.BringToFront()
        AddHandler overlayPanel.Click, AddressOf overlayPanel_Click
        Me.Controls.Add(overlayPanel)

        menuForm.TopLevel = False
        menuForm.FormBorderStyle = FormBorderStyle.None
        menuForm.Left = -menuForm.Width
        menuForm.Top = 0
        menuForm.Height = Me.Height
        menuForm.Parent = Me
        Me.Controls.Add(menuForm)
        menuForm.Show()

        InitializeDialog(editBookDialog)
        SDialog(editBookDialog)
        HideButtons.hideButtonsBookings(Me)
        AddHandler editBookDialog.BookEdited, AddressOf EditBookDialog_BookEdited

        LoadBookingData()
    End Sub

    Private Sub InitializeDialog(dialog As Form)
        dialog.TopLevel = False
        dialog.FormBorderStyle = FormBorderStyle.None
        dialog.Dock = DockStyle.None
        Me.Controls.Add(dialog)
        dialog.BringToFront()
    End Sub

    Private Sub SDialog(dialog As Form)
        dialog.Left = Me.Width
        dialog.Top = 0
        dialog.Height = Me.Height
        dialog.Show()
    End Sub

    Private Sub fadeIn_Tick(sender As Object, e As EventArgs) Handles fadeIn.Tick
        If Me.Opacity < 1 Then Me.Opacity += 0.05 Else fadeIn.Stop()
    End Sub

    Private Sub btnToggleMenu_Click(sender As Object, e As EventArgs) Handles menuButton.Click
        menuForm.BringToFront()
        menuTimer.Start()
    End Sub

    Private Sub menuTimer_Tick(sender As Object, e As EventArgs) Handles menuTimer.Tick
        If menuVisible Then
            menuForm.Left = Math.Max(menuForm.Left - 20, -menuForm.Width)
            If menuForm.Left = -menuForm.Width Then menuTimer.Stop() : menuVisible = False
        Else
            menuForm.Left = Math.Min(menuForm.Left + 20, 0)
            If menuForm.Left = 0 Then menuTimer.Stop() : menuVisible = True
        End If
    End Sub

    Private Sub bookings_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If menuVisible AndAlso Not menuForm.Bounds.Contains(e.Location) Then menuTimer.Start()
    End Sub

    Private Sub addBookButton_Click(sender As Object, e As EventArgs)
        overlayPanel.Visible = True
        slidingIn = True
        dialogTimer.Start()
    End Sub

    Private Sub editBookButton_Click(sender As Object, e As EventArgs) Handles editBookButton.Click
        overlayPanel.Visible = True
        editingIn = True
        dialogTimer.Start()
    End Sub

    Private Sub overlayPanel_Click(sender As Object, e As EventArgs)
        slidingIn = False
        editingIn = False
        dialogTimer.Start()
    End Sub

    Private Sub dialogTimer_Tick(sender As Object, e As EventArgs) Handles dialogTimer.Tick
        If editingIn Then
            SlideDialogIn(editBookDialog)
        Else
            SlideDialogsOut()
        End If
    End Sub

    Private Sub SlideDialogIn(dialog As Form)
        If dialog.Left > Me.Width - dialog.Width Then dialog.Left -= 20 Else dialogTimer.Stop()
    End Sub

    Private Sub SlideDialogsOut()
        If editBookDialog.Left < Me.Width Then editBookDialog.Left += 20
        If editBookDialog.Left >= Me.Width Then
            dialogTimer.Stop()
            overlayPanel.Visible = False
        End If
    End Sub

    Public Sub LoadBookingData()
        Dim query As String = "SELECT * FROM bookings"

        Using conn As New SqlConnection(database.connectionString)
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim dt As New DataTable()

            Try
                conn.Open()
                adapter.Fill(dt)

                bookBindingSource.DataSource = dt

                bookDGV.DataSource = bookBindingSource
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub bookDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles bookDGV.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = bookDGV.Rows(e.RowIndex)

            Dim bookId As Integer = selectedRow.Cells("bookId").Value.ToString()
            Dim bookFname As String = selectedRow.Cells("bookFname").Value.ToString()
            Dim bookLname As String = selectedRow.Cells("bookLname").Value.ToString()
            Dim bookEmail As String = selectedRow.Cells("bookEmail").Value.ToString()
            Dim bookPhoneNo As String = selectedRow.Cells("bookPhoneNo").Value.ToString()
            Dim bookRoomName As String = selectedRow.Cells("bookRoomName").Value.ToString()
            Dim bookRoomNo As String = selectedRow.Cells("bookRoomNo").Value.ToString()
            Dim bookPax As Integer = selectedRow.Cells("bookPax").Value.ToString()
            Dim bookCheckInDate As Date = selectedRow.Cells("bookCheckInDate").Value.ToString()
            Dim bookCheckInTime As String = selectedRow.Cells("bookCheckInTime").Value.ToString()
            Dim bookCheckOutDate As Date = selectedRow.Cells("bookCheckOutDate").Value.ToString()
            Dim bookCheckOutTime As String = selectedRow.Cells("bookCheckOutTime").Value.ToString()

            editBookDialog.PopulateFields(bookId, bookFname, bookLname, bookEmail, bookPhoneNo, bookRoomName, bookRoomNo, bookPax, bookCheckInDate, bookCheckInTime, bookCheckOutDate, bookCheckOutTime)
        End If
    End Sub

    Private Sub refreshBookButton_Click(sender As Object, e As EventArgs) Handles refreshBookButton.Click
        LoadBookingData()
    End Sub

    Private Sub EditBookDialog_BookEdited(sender As Object, e As EventArgs)
        LoadBookingData()
    End Sub

    Private Sub searchBookTextBox_TextChanged(sender As Object, e As EventArgs) Handles searchBookTextBox.TextChanged
        Dim filter As String = searchBookTextBox.Text

        If String.IsNullOrWhiteSpace(filter) Then
            bookBindingSource.Filter = Nothing
        Else
            bookBindingSource.Filter = String.Format("bFname LIKE '%{0}%' OR bLname LIKE '%{0}%' OR bEmail LIKE '%{0}%' OR bPhoneNo LIKE '%{0}%' OR bRoomNo LIKE '%{0}%' OR bRName LIKE '%{0}%' OR bReferenceNo LIKE '%{0}%'", filter)
        End If
    End Sub

    Private Sub deleteAccButton_Click(sender As Object, e As EventArgs) Handles deleteBookButton.Click
        If bookDGV.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a booking to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim confirmResult As DialogResult = MessageBox.Show(
            "Are you sure you want to delete this booking? This action cannot be undone.",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If confirmResult = DialogResult.Yes Then
            Dim selectedRow As DataGridViewRow = bookDGV.CurrentRow
            Dim selectedBook As String = selectedRow.Cells("bookId").Value.ToString()

            Dim conn As New SqlConnection(database.connectionString)
            Dim cmd As New SqlCommand()
            cmd.Connection = conn
            Dim transaction As SqlTransaction

            Try
                conn.Open()
                transaction = conn.BeginTransaction()
                cmd.Transaction = transaction

                cmd.CommandText = "DELETE FROM orderExtras WHERE bId = @bId"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@bId", selectedBook)
                cmd.ExecuteNonQuery()

                cmd.CommandText = "DELETE FROM payments WHERE bId = @bId"
                cmd.ExecuteNonQuery()

                cmd.CommandText = "DELETE FROM bookings WHERE bId = @bId"
                cmd.ExecuteNonQuery()

                transaction.Commit()

                RaiseEvent BookDeleted(Me, EventArgs.Empty)
                LoadBookingData()
                MessageBox.Show("Booking and all related records successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                If conn.State = ConnectionState.Open Then
                    transaction?.Rollback()
                End If
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Finally
                conn.Close()
            End Try
        End If
    End Sub
End Class