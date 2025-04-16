Public Class HideButtons
    Public Sub hideButtonsBookings(bookingForm As bookingTable)
        If Employee.Role = "Admin" Then
            bookingForm.editBookButton.Visible = False
            bookingForm.deleteBookButton.Visible = False
        End If
    End Sub

    Public Sub hideButtonsRooms(roomForm As roomTable)
        If Employee.Role = "Admin" Then
            roomForm.addRoomButton.Visible = False
            roomForm.editRoomButton.Visible = False
            roomForm.roomPhotosButton.Visible = False
        End If
    End Sub

    Public Sub hideButtonsPayment(paymentForm As paymentTable)
        If Employee.Role = "Admin" Then
            paymentForm.editPaymentButton.Visible = False
            paymentForm.deletePaymentButton.Visible = False
        End If
    End Sub

    Public Sub hideButtonsExtras(extrasForm As extrasTable)
        If Employee.Role = "Admin" Then
            extrasForm.addExtrasButton.Visible = False
            extrasForm.editExtrasButton.Visible = False
            extrasForm.deleteExtrasButton.Visible = False
        End If
    End Sub
End Class
