Imports System.Data.SqlClient

Public Class addExtrasDialog
    Dim database As New database()
    Public Event ExtrasAdded As EventHandler

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim ixItem As String = itemTextBox.Text.Trim()
        Dim ixPrice As String = priceTextBox.Text.Trim()
        Dim ixQuantity As String = quantityTextBox.Text.Trim()

        Dim errorMsg As String = ""

        If Not ExtrasValidation.ValidateExtras(ixItem, ixPrice, ixQuantity, errorMsg) Then
            MessageBox.Show(errorMsg, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim query As String = "INSERT INTO itemExtras (ixExtras, ixPrice, ixQuantity) VALUES (@ixExtras, @ixPrice, @ixQuantity)"

        Using conn As New SqlConnection(database.connectionString)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ixExtras", ixItem)
            cmd.Parameters.AddWithValue("@ixPrice", Decimal.Parse(ixPrice))
            cmd.Parameters.AddWithValue("@ixQuantity", Integer.Parse(ixQuantity))

            Try
                conn.Open()

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RaiseEvent ExtrasAdded(Me, EventArgs.Empty)
                Else
                    MessageBox.Show("An error occurred while adding the item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class