Imports System.Data.SqlClient

Public Class editPaymentDialog
    Dim database As New database()
    Public Event PaymentEdited As EventHandler

    Public Sub PopulateFields(bookId As Integer, paymentMethod As String, oxPrrice As Decimal, totalPrice As Decimal, downPayment As Decimal, amountDue As Decimal, status As String)
        bookingIdTextBox.Text = bookId.ToString()
        paymentMethodTextBox.Text = paymentMethod
        oxPriceTextBox.Text = oxPrrice.ToString("N2")
        totalPriceTextBox.Text = totalPrice.ToString("N2")
        downPaymentTextBox.Text = downPayment.ToString("N2")
        amountDueTextBox.Text = amountDue.ToString("N2")
        statusComboBox.Text = status
    End Sub

    Private Sub statusComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles statusComboBox.SelectedIndexChanged
        Dim totalPrice As Decimal = Decimal.Parse(totalPriceTextBox.Text)
        Dim newAmountDue As Decimal
        Dim newDownPayment As Decimal

        Select Case statusComboBox.Text
            Case "Paid"
                newAmountDue = 0D
                newDownPayment = totalPrice
            Case "Partially Paid"
                newAmountDue = totalPrice * 0.5D
                newDownPayment = totalPrice * 0.5D
            Case "Cancelled", "Refunded"
                newAmountDue = 0D
                newDownPayment = 0D
            Case Else
                newAmountDue = totalPrice
                newDownPayment = 0D
        End Select

        amountDueTextBox.Text = newAmountDue.ToString("N2")
        downPaymentTextBox.Text = newDownPayment.ToString("N2")
    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        Dim bId As Integer = Integer.Parse(bookingIdTextBox.Text)
        Dim pPaymentMethod As String = paymentMethodTextBox.Text
        Dim pOxPrice As Decimal = Decimal.Parse(oxPriceTextBox.Text)
        Dim pTotalPrice As Decimal = Decimal.Parse(totalPriceTextBox.Text)
        Dim pStatus As String = statusComboBox.Text
        Dim pDownPayment As Decimal = Decimal.Parse(downPaymentTextBox.Text)
        Dim pAmountDue As Decimal = Decimal.Parse(amountDueTextBox.Text)

        Dim query As String = "UPDATE payments 
                               SET pPaymentMethod = @pPaymentMethod, 
                                   pOxPrice = @pOxPrice, 
                                   pTotalPrice = @pTotalPrice, 
                                   pStatus = @pStatus, 
                                   pDownPayment = @pDownPayment, 
                                   pAmountDue = @pAmountDue 
                               WHERE bId = @bId"

        Using conn As New SqlConnection(database.connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@bId", bId)
                cmd.Parameters.AddWithValue("@pPaymentMethod", pPaymentMethod)
                cmd.Parameters.AddWithValue("@pOxPrice", pOxPrice)
                cmd.Parameters.AddWithValue("@pTotalPrice", pTotalPrice)
                cmd.Parameters.AddWithValue("@pStatus", pStatus)
                cmd.Parameters.AddWithValue("@pDownPayment", pDownPayment)
                cmd.Parameters.AddWithValue("@pAmountDue", pAmountDue)

                Try
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Payment edited successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        RaiseEvent PaymentEdited(Me, EventArgs.Empty)
                    Else
                        MessageBox.Show("No changes were made to the payment.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
End Class