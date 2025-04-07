Imports System.Data.SqlClient

Public Class addRoomDialog
    Dim database As New database()
    Public Event RoomAdded As EventHandler

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim rName As String = roomTypeComboBox.Text
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

        Dim validationMessage As String = roomValidations.ValidateRoomFields(rName, rRoomNo, rCategory, rBedroom, rBathroom,
                                                                           rTechnology, rKitchen, rGeneral, rStatus, rPrice)

        If Not String.IsNullOrEmpty(validationMessage) Then
            MessageBox.Show(validationMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If roomValidations.RoomNumberExists(rRoomNo, database.connectionString) Then
            MessageBox.Show("The room number already exists. Please choose a different room number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                    RaiseEvent RoomAdded(Me, EventArgs.Empty)
                Else
                    MessageBox.Show("An error occurred while adding the room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class

