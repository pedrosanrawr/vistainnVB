Public Class HideButtons
    Public Sub hideButtonsBookings(bookingForm As bookingTable)
        If Employee.Role = "Admin" Then
            bookingForm.addBookButton.Enabled = False
            bookingForm.editBookButton.Enabled = False
            bookingForm.deleteBookButton.Enabled = False
        End If
    End Sub

    Public Sub hideButtonsRooms(roomForm As roomTable)
        If Employee.Role = "Admin" Then
            roomForm.addRoomButton.Enabled = False
            roomForm.editRoomButton.Enabled = False
            roomForm.roomPhotosButton.Enabled = False
        End If
    End Sub

    Public Sub hideButtonsPayment(paymentForm As paymentTable)
        If Employee.Role = "Admin" Then
            paymentForm.editPaymentButton.Enabled = False
            paymentForm.deletePaymentButton.Enabled = False
        End If
    End Sub

    Public Sub hideButtonsExtras(extrasForm As extrasTable)
        If Employee.Role = "Admin" Then
            extrasForm.addExtrasButton.Enabled = False
            extrasForm.editExtrasButton.Enabled = False
            extrasForm.deleteExtrasButton.Enabled = False
        End If
    End Sub
End Class
