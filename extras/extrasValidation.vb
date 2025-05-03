Public Class ExtrasValidation
    Public Shared Function ValidateExtras(ixItem As String, ixPrice As String, ixQuantity As String, ByRef errorMessage As String) As Boolean
        If String.IsNullOrWhiteSpace(ixItem) OrElse
           String.IsNullOrWhiteSpace(ixPrice) OrElse
           String.IsNullOrWhiteSpace(ixQuantity) Then

            errorMessage = "All fields must be filled up."
            Return False
        End If

        If Not Decimal.TryParse(ixPrice, Nothing) Then
            errorMessage = "Price must be a valid number."
            Return False
        End If

        If Decimal.Parse(ixPrice) < 0 Then
            errorMessage = "Price must not be negative."
            Return False
        End If

        If Not Integer.TryParse(ixQuantity, Nothing) Then
            errorMessage = "Quantity must be a valid whole number."
            Return False
        End If

        If Integer.Parse(ixQuantity) < 0 Then
            errorMessage = "Quantity must not be negative."
            Return False
        End If

        Return True
    End Function
End Class
