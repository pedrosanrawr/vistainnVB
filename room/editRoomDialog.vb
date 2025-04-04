Public Class editRoomDialog
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
End Class