Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class roomValidations

    Public Shared Function ValidateRoomFields(rName As String, rRoomNo As String, rCategory As String, rBedroom As String,
                                              rBathroom As String, rTechnology As String, rKitchen As String,
                                              rGeneral As String, rStatus As String, rPrice As Decimal) As String
        If String.IsNullOrWhiteSpace(rName) OrElse String.IsNullOrWhiteSpace(rRoomNo) OrElse
           String.IsNullOrWhiteSpace(rCategory) OrElse String.IsNullOrWhiteSpace(rBedroom) OrElse
           String.IsNullOrWhiteSpace(rBathroom) OrElse String.IsNullOrWhiteSpace(rTechnology) OrElse
           String.IsNullOrWhiteSpace(rKitchen) OrElse String.IsNullOrWhiteSpace(rGeneral) OrElse
           String.IsNullOrWhiteSpace(rStatus) Then
            Return "Please fill all required fields correctly."
        End If

        If rPrice <= 0 Then
            Return "Please enter a valid price for the room."
        End If

        If Not Regex.IsMatch(rRoomNo, "^\d{3}$") Then
            Return "Invalid room number format. Room number must be a 3-digit number (e.g., 101, 102)."
        End If

        Return String.Empty
    End Function

    Public Shared Function RoomNumberExists(roomNo As String, connectionString As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM rooms WHERE rRoomNo = @rRoomNo"
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@rRoomNo", roomNo)

            Try
                conn.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function

End Class

