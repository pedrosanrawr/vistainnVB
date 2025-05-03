Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class bookValidation
    Private database As New database()

    Public Function AreRequiredFieldsFilled(bFname As String, bLname As String, bEmail As String, bPhoneNo As String, bRoomName As String, bRoomNo As String, bPax As String, bCheckInTime As String, bCheckOutTime As String) As Boolean
        Return Not String.IsNullOrWhiteSpace(bFname) AndAlso
           Not String.IsNullOrWhiteSpace(bLname) AndAlso
           Not String.IsNullOrWhiteSpace(bEmail) AndAlso
           Not String.IsNullOrWhiteSpace(bPhoneNo) AndAlso
           Not String.IsNullOrWhiteSpace(bRoomName) AndAlso
           Not String.IsNullOrWhiteSpace(bRoomNo) AndAlso
           Not String.IsNullOrWhiteSpace(bPax) AndAlso
           Not String.IsNullOrWhiteSpace(bCheckInTime) AndAlso
           Not String.IsNullOrWhiteSpace(bCheckOutTime)
    End Function

    Public Function IsNameValid(name As String) As Boolean
        Return Regex.IsMatch(name.Trim(), "^[A-Za-z\s]+$")
    End Function

    Public Function IsEmailValid(email As String) As Boolean
        Return Regex.IsMatch(email.Trim(), "^[\w\.-]+@[\w\.-]+\.\w+$")
    End Function

    Public Function IsPhoneValid(phone As String) As Boolean
        Return Regex.IsMatch(phone.Trim(), "^\d{10,15}$")
    End Function

    Public Function AreRoomSelectionsValid(roomName As String, roomNo As String) As Boolean
        Return Not String.IsNullOrWhiteSpace(roomName) AndAlso Not String.IsNullOrWhiteSpace(roomNo)
    End Function

    Public Function IsBookingConflict(roomName As String, roomNo As String, checkIn As Date, checkOut As Date, currentBookId As Integer) As Boolean
        Dim query As String = "
            SELECT COUNT(*) FROM bookings b
            INNER JOIN payments p ON b.bId = p.bId
            WHERE b.bRName = @rName AND b.bRoomNo = @roomNo 
            AND p.pStatus IN ('Paid', 'Pending', 'Partially Paid')
            AND (
                (@inDate BETWEEN b.bCheckInDate AND b.bCheckOutDate)
                OR
                (@outDate BETWEEN b.bCheckInDate AND b.bCheckOutDate)
                OR
                (b.bCheckInDate BETWEEN @inDate AND @outDate)
            )
            AND b.bId <> @currentBookId
        "

        Using conn As New SqlConnection(database.connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@rName", roomName)
                cmd.Parameters.AddWithValue("@roomNo", roomNo)
                cmd.Parameters.AddWithValue("@inDate", checkIn)
                cmd.Parameters.AddWithValue("@outDate", checkOut)
                cmd.Parameters.AddWithValue("@currentBookId", currentBookId)

                conn.Open()
                Dim count As Integer = CInt(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Public Function IsDateRangeValid(checkIn As Date, checkOut As Date) As Boolean
        Return checkIn < checkOut
    End Function

    Public Function IsTimeRangeValid(checkInDate As Date, checkOutDate As Date, checkInTime As String, checkOutTime As String) As Boolean
        If checkInDate = checkOutDate Then
            Dim inTime As DateTime = DateTime.Parse(checkInTime)
            Dim outTime As DateTime = DateTime.Parse(checkOutTime)
            Return inTime < outTime
        End If
        Return True
    End Function
End Class
