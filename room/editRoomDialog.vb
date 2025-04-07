Imports System.Data.SqlClient

Public Class editRoomDialog
    Dim database As New database()
    Public Event RoomEdited As EventHandler

    Public Sub PopulateFields(roomId As String, roomNo As String, roomName As String, roomPrice As Decimal, roomCapacity As String, roomBedroom As String, roomBathroom As String, roomKitchen As String, roomTechnology As String, roomGeneral As String, roomStatus As String)
        roomIdTextBox.Text = roomId
        roomNoTextBox.Text = roomNo
        roomTypeComboBox.Text = roomName
        rateTextBox.Text = roomPrice
        capacityComboBox.Text = roomCapacity
        bedroomTextBox.Text = roomBedroom
        bathroomTextBox.Text = roomBathroom
        kitchenTextBox.Text = roomKitchen
        technologyTextBox.Text = roomTechnology
        generalTextBox.Text = roomGeneral
        statusComboBox.Text = roomStatus
    End Sub

    Private Sub editRoomButton_Click(sender As Object, e As EventArgs) Handles editRoomButton.Click
        Dim rId As Integer = roomIdTextBox.Text
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

        If rRoomNo <> roomNoTextBox.Text Then
            If roomValidations.RoomNumberExists(rRoomNo, database.connectionString) Then
                MessageBox.Show("The room number already exists. Please choose a different room number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        End If

        Dim query As String = "UPDATE rooms SET rname=@rname, rRoomNo=@rRoomNo, rPrice=@rPrice, rCategory=@rCategory, rBedroom=@rBedroom, rBathroom=@rBathroom, rTechnology=@rTechnology, rKitchen=@rKitchen, rGeneral=@rGeneral, rStatus=@rStatus WHERE rId=@rId"

        Using conn As New SqlConnection(database.connectionString)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@rId", rId)
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
                    MessageBox.Show("Room edited successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RaiseEvent RoomEdited(Me, EventArgs.Empty)
                Else
                    MessageBox.Show("An error occurred while editing the room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class