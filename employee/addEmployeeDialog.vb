Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Security.Cryptography
Imports System.Text

Public Class addEmployeeDialog
    Dim database As New database()
    Public Event EmployeeAdded As EventHandler

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
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

        Dim existsMessage As String = employeeValidation.EmailOrPhoneExists(eEmail, ePhoneNo, database.ConnectionString)
        If Not String.IsNullOrEmpty(existsMessage) Then
            MessageBox.Show(existsMessage, "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim defaultPassword As String = "vistainn123"
        Dim salt As String = GenerateSalt()
        Dim hashedPassword As String = HashPassword(defaultPassword, salt)

        Dim query As String = "INSERT INTO employee (eFname, eLname, eRole, eEmail, ePhoneNo, eGender, eNationality, eAddress, ePassword, eSalt) " &
                          "VALUES (@eFname, @eLname, @eRole, @eEmail, @ePhoneNo, @eGender, @eNationality, @eAddress, @ePassword, @eSalt)"

        Using conn As New SqlConnection(database.ConnectionString)
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
            cmd.Parameters.AddWithValue("@eSalt", salt)

            Try
                conn.Open()
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RaiseEvent EmployeeAdded(Me, EventArgs.Empty)
                    Me.clear()
                Else
                    MessageBox.Show("An error occurred while adding the employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Function GenerateSalt() As String
        Using rng As New RNGCryptoServiceProvider()
            Dim saltBytes(15) As Byte
            rng.GetBytes(saltBytes)
            Return Convert.ToBase64String(saltBytes)
        End Using
    End Function

    Private Function HashPassword(password As String, salt As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim saltedPassword As String = password & salt
            Dim hashBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword))
            Return Convert.ToBase64String(hashBytes)
        End Using
    End Function

    Public Sub clear()
        firstNameTextBox.Text = ""
        lastNameTextBox.Text = ""
        emailTextBox.Text = ""
        phoneNoTextBox.Text = ""
        addressTextBox.Text = ""
        roleComboBox.SelectedIndex = -1
        genderComboBox.SelectedIndex = -1
        nationalityComboBox.SelectedIndex = -1
    End Sub

    Private Sub addEmployeeDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roleComboBox.Items.Clear()

        If Employee.Role = "Manager" Then
            roleComboBox.Items.Add("Manager")
            roleComboBox.Items.Add("Staff")
        ElseIf Employee.Role = "Admin" Then
            roleComboBox.Items.Add("Admin")
            roleComboBox.Items.Add("Manager")
            roleComboBox.Items.Add("Staff")
        End If
    End Sub
End Class