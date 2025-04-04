Imports System.Data.SqlClient

Public Class addRoomDialog
    Dim database As New database()

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim rName As String = roomTypeTextBox.Text
        Dim rRoomNo As String = roomNoTextBox.Text
        Dim rPrice As Decimal
        Decimal.TryParse(rateTextBox.Text, rPrice)
        Dim rCategory As String = capacityComboBox.Text
        Dim rBedroom As String = bedroomTextBox.Text
        Dim rBathroom As String = bathroomTextBox.Text
        Dim rTechnology As String = technologyTextBox.Text
        Dim rKitchen As String = kitchenTextBox.Text
        Dim rGeneral As String = generalTextBox.Text
        Dim rStatus As String = statusComboBox.Text

        If String.IsNullOrWhiteSpace(rName) OrElse String.IsNullOrWhiteSpace(rRoomNo) OrElse rPrice <= 0 OrElse String.IsNullOrWhiteSpace(rCategory) Then
            MessageBox.Show("Please fill all required fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "INSERT INTO rooms (rName, rRoomNo, rPrice, rCategory, rBedroom, rBathroom, rTechnology, rKitchen, rGeneral, rStatus) " &
                              "VALUES (@rName, @rRoomNo, @rPrice, @rCategory, @rBedroom, @rBathroom, @rTechnology, @rKitchen, @rGeneral, @rStatus)"

        Using conn As New SqlConnection(database.connectionString)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@rName", rName)
            cmd.Parameters.AddWithValue("@rRoomNo", rRoomNo)
            cmd.Parameters.AddWithValue("@rPrice", rPrice)
            cmd.Parameters.AddWithValue("@rCategory", rCategory)
            cmd.Parameters.AddWithValue("@rBedroom", rBedroom)
            cmd.Parameters.AddWithValue("@rBathroom", rBathroom)
            cmd.Parameters.AddWithValue("@rTechnology", rTechnology)
            cmd.Parameters.AddWithValue("@rKitchen", rKitchen)
            cmd.Parameters.AddWithValue("@rGeneral", rGeneral)
            cmd.Parameters.AddWithValue("@rStatus", rStatus)

            Try
                conn.Open()

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Room added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("An error occurred while adding the room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        roomTable.LoadRoomData()
    End Sub

End Class