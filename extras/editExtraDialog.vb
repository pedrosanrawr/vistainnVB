Imports System.Data.SqlClient

Public Class editExtraDialog
    Dim database As New database()
    Public Event ExtrasEdited As EventHandler

    Public Sub PopulateFields(extrasId As Integer, extrasItem As String, extrasPrice As Decimal, extrasQuantity As Integer)
        extrasIdTextBox.Text = extrasId
        itemTextBox.Text = extrasItem
        priceTextBox.Text = extrasPrice
        quantityTextBox.Text = extrasQuantity
    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        Dim ixId As Integer = Integer.Parse(extrasIdTextBox.Text)
        Dim ixItem As String = itemTextBox.Text.Trim()
        Dim ixPrice As String = priceTextBox.Text.Trim()
        Dim ixQuantity As String = quantityTextBox.Text.Trim()

        Dim errorMsg As String = ""

        If Not ExtrasValidation.ValidateExtras(ixItem, ixPrice, ixQuantity, errorMsg) Then
            MessageBox.Show(errorMsg, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim query As String = "UPDATE itemExtras SET ixExtras=@ixExtras, ixPrice=@ixPrice, ixQuantity=@ixQuantity WHERE ixId=@ixId"

        Using conn As New SqlConnection(database.connectionString)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ixId", ixId)
            cmd.Parameters.AddWithValue("@ixExtras", ixItem)
            cmd.Parameters.AddWithValue("@ixPrice", Decimal.Parse(ixPrice))
            cmd.Parameters.AddWithValue("@ixQuantity", Integer.Parse(ixQuantity))

            Try
                conn.Open()

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Item edited successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RaiseEvent ExtrasEdited(Me, EventArgs.Empty)
                Else
                    MessageBox.Show("An error occurred while editing the item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class