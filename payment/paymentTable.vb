Imports System.Data.SqlClient

Public Class paymentTable
    Dim menuForm As Form
    Dim editPaymentDialog As New editPaymentDialog()
    Dim overlayPanel As New Panel()
    Dim menuVisible As Boolean = False
    Dim slidingIn As Boolean = False
    Dim editingIn As Boolean = False
    Dim HideButtons As New HideButtons()
    Dim database As New database()
    Dim paymentBindingSource As New BindingSource()
    Public Event PaymentDeleted As EventHandler

    Private Sub paymentTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        InitializeDialog(editPaymentDialog)
        SDialog(editPaymentDialog)
        HideButtons.hideButtonsPayment(Me)
        AddHandler editPaymentDialog.PaymentEdited, AddressOf EditPaymentDialog_PaymentEdited

        LoadPaymentData()
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

    Private Sub payment_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If menuVisible AndAlso Not menuForm.Bounds.Contains(e.Location) Then menuTimer.Start()
    End Sub

    Private Sub editPaymentButton_Click(sender As Object, e As EventArgs) Handles editPaymentButton.Click
        overlayPanel.Visible = True
        editingIn = True
        dialogTimer.Start()
    End Sub

    Private Sub overlayPanel_Click(sender As Object, e As EventArgs)
        editingIn = False
        dialogTimer.Start()
    End Sub

    Private Sub dialogTimer_Tick(sender As Object, e As EventArgs) Handles dialogTimer.Tick
        If editingIn Then
            SlideDialogIn(editPaymentDialog)
        Else
            SlideDialogsOut()
        End If
    End Sub

    Private Sub SlideDialogIn(dialog As Form)
        If dialog.Left > Me.Width - dialog.Width Then
            dialog.Left -= 20
        Else
            dialogTimer.Stop()
        End If
    End Sub

    Private Sub SlideDialogsOut()
        If editPaymentDialog.Left < Me.Width Then editPaymentDialog.Left += 20
        If editPaymentDialog.Left >= Me.Width Then dialogTimer.Stop() : overlayPanel.Visible = False
    End Sub

    Public Sub LoadPaymentData()
        Dim query As String = "SELECT * FROM payments"

        Using conn As New SqlConnection(database.connectionString)
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim dt As New DataTable()

            Try
                conn.Open()
                adapter.Fill(dt)

                paymentBindingSource.DataSource = dt

                paymentDGV.DataSource = paymentBindingSource
                paymentDGV.Columns("pId").Visible = False
                paymentDGV.Columns("oxPrice").DefaultCellStyle.Format = "N2"
                paymentDGV.Columns("totalPrice").DefaultCellStyle.Format = "N2"
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub paymentDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles paymentDGV.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = paymentDGV.Rows(e.RowIndex)

            Dim bookId As Integer = selectedRow.Cells("bookId").Value.ToString()
            Dim paymentMethod As String = selectedRow.Cells("paymentMethod").Value.ToString()
            Dim oxPrice As Decimal = selectedRow.Cells("oxPrice").Value.ToString()
            Dim totalPrice As Decimal = selectedRow.Cells("totalPrice").Value.ToString()
            Dim downPayment As Decimal = selectedRow.Cells("downPayment").Value.ToString()
            Dim amountDue As Decimal = selectedRow.Cells("amountDue").Value.ToString()
            Dim status As String = selectedRow.Cells("status").Value.ToString()

            editPaymentDialog.PopulateFields(bookId, paymentMethod, oxPrice, totalPrice, downPayment, amountDue, status)
        End If
    End Sub

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        LoadPaymentData()
    End Sub

    Private Sub EditPaymentDialog_PaymentEdited(sender As Object, e As EventArgs)
        LoadPaymentData()
    End Sub

    Private Sub searchPaymentTextBox_TextChanged(sender As Object, e As EventArgs) Handles searchPaymentTextBox.TextChanged
        Dim filter As String = searchPaymentTextBox.Text

        If String.IsNullOrWhiteSpace(filter) Then
            paymentBindingSource.Filter = Nothing
        Else
            paymentBindingSource.Filter = String.Format("Convert(bId, 'System.String') LIKE '%{0}%' OR pStatus LIKE '%{0}%'", filter)
        End If
    End Sub

    Private Sub deletePaymentButton_Click(sender As Object, e As EventArgs) Handles deletePaymentButton.Click
        If paymentDGV.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a payment to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim confirmResult As DialogResult = MessageBox.Show(
            "Are you sure you want to delete this payment? This action cannot be undone.",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If confirmResult = DialogResult.Yes Then
            Dim selectedRow As DataGridViewRow = paymentDGV.CurrentRow
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

                RaiseEvent PaymentDeleted(Me, EventArgs.Empty)
                LoadPaymentData()
                MessageBox.Show("Payment, related booking, and extras successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

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