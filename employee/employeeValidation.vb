Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class employeeValidation

    Public Shared Function ValidateEmployeeFields(fname As String, lname As String, role As String, email As String,
                                                  phoneNo As String, gender As String, nationality As String,
                                                  address As String) As String
        If String.IsNullOrWhiteSpace(fname) OrElse String.IsNullOrWhiteSpace(lname) OrElse
           String.IsNullOrWhiteSpace(role) OrElse String.IsNullOrWhiteSpace(email) OrElse
           String.IsNullOrWhiteSpace(phoneNo) OrElse String.IsNullOrWhiteSpace(gender) OrElse
           String.IsNullOrWhiteSpace(nationality) OrElse String.IsNullOrWhiteSpace(address) Then
            Return "Please fill all required fields."
        End If

        If Not Regex.IsMatch(fname, "^[A-Z][a-zA-Z]*$") Then
            Return "First name must start with a capital letter and contain only letters."
        End If
        If Not Regex.IsMatch(lname, "^[A-Z][a-zA-Z]*$") Then
            Return "Last name must start with a capital letter and contain only letters."
        End If

        If Not Regex.IsMatch(email, "^[^@\s]+@[^@\s]+\.[^@\s]+$") Then
            Return "Invalid email format."
        End If

        If Not Regex.IsMatch(phoneNo, "^\d{11}$") Then
            Return "Phone number must be 11 digits long."
        End If

        Return String.Empty
    End Function

    Public Shared Function EmailOrPhoneExists(email As String, phoneNo As String, connectionString As String,
                                          Optional originalEmail As String = "", Optional originalPhoneNo As String = "") As String
        Dim query As String = "SELECT eEmail, ePhoneNo FROM employee WHERE (eEmail = @eEmail OR ePhoneNo = @ePhoneNo)"
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@eEmail", email)
            cmd.Parameters.AddWithValue("@ePhoneNo", phoneNo)

            Try
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim existingEmail As String = reader("eEmail").ToString()
                    Dim existingPhone As String = reader("ePhoneNo").ToString()

                    If existingEmail = originalEmail AndAlso existingPhone = originalPhoneNo Then
                        Continue While
                    End If

                    If existingEmail = email AndAlso email <> originalEmail Then
                        Return "The email is already taken."
                    End If
                    If existingPhone = phoneNo AndAlso phoneNo <> originalPhoneNo Then
                        Return "The phone number is already taken."
                    End If
                End While
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        Return String.Empty
    End Function

    Public Shared Function Capitalize(value As String) As String
        If String.IsNullOrEmpty(value) Then Return value
        Return Char.ToUpper(value(0)) & value.Substring(1).ToLower()
    End Function

End Class
