Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class addEmployeeDialog
    Dim database As New database()
    Public Event EmployeeAdded As EventHandler

    Private Sub logInButton_Click(sender As Object, e As EventArgs) Handles logInButton.Click
        Dim eFname As String = employeeValidation.Capitalize(firstNameTextBox.Text)
        Dim eLname As String = employeeValidation.Capitalize(lastNameTextBox.Text)
        Dim eRole As String = roleComboBox.Text
        Dim eEmail As String = emailTextBox.Text
        Dim ePhoneNo As String = phoneNoTextBox.Text
        Dim eGender As String = genderComboBox.Text
        Dim eNationality As String = nationalityComboBox.Text
        Dim eAddress As String = addressTextBox.Text

        Dim validationMessage As String = employeeValidation.ValidateEmployeeFields(eFname, eLname, eRole, eEmail, ePhoneNo, eGender, eNationality, eAddress)
        If Not String.IsNullOrEmpty(validationMessage) Then
            MessageBox.Show(validationMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim existsMessage As String = employeeValidation.EmailOrPhoneExists(eEmail, ePhoneNo, database.connectionString)
        If Not String.IsNullOrEmpty(existsMessage) Then
            MessageBox.Show(existsMessage, "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim salt As Byte() = GenerateSalt()
        Dim defaultPassword As String = "vistainn123"
        Dim hashedPassword As String = HashPasswordWithSalt(defaultPassword, salt)

        Dim saltBase64 As String = Convert.ToBase64String(salt)

        Dim query As String = "INSERT INTO employee (eFname, eLname, eRole, eEmail, ePhoneNo, eGender, eNationality, eAddress, ePassword, eSalt) " &
                              "VALUES (@eFname, @eLname, @eRole, @eEmail, @ePhoneNo, @eGender, @eNationality, @eAddress, @ePassword, @eSalt)"

        Using conn As New SqlConnection(database.connectionString)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@eFname", eFname)
            cmd.Parameters.AddWithValue("@eLname", eLname)
            cmd.Parameters.AddWithValue("@eRole", eRole)
            cmd.Parameters.AddWithValue("@eEmail", eEmail)
            cmd.Parameters.AddWithValue("@ePhoneNo", ePhoneNo)
            cmd.Parameters.AddWithValue("@eGender", eGender)
            cmd.Parameters.AddWithValue("@eNationality", eNationality)
            cmd.Parameters.AddWithValue("@eAddress", eAddress)
            cmd.Parameters.AddWithValue("@ePassword", hashedPassword)
            cmd.Parameters.AddWithValue("@eSalt", saltBase64)

            Try
                conn.Open()
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RaiseEvent EmployeeAdded(Me, EventArgs.Empty)
                Else
                    MessageBox.Show("An error occurred while adding the employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Function GenerateSalt(Optional length As Integer = 16) As Byte()
        Dim salt(length - 1) As Byte
        Using rng As New RNGCryptoServiceProvider()
            rng.GetBytes(salt)
        End Using
        Return salt
    End Function

    Public Function HashPasswordWithSalt(password As String, salt As Byte()) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim passwordBytes As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
            Dim passwordWithSalt As Byte() = passwordBytes.Concat(salt).ToArray()
            Dim hashBytes As Byte() = sha256.ComputeHash(passwordWithSalt)
            Return Convert.ToBase64String(hashBytes)
        End Using
    End Function
End Class