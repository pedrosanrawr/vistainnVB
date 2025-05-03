Imports System.Data.SqlClient

Public Class editEmployeeDialog
    Dim database As New database()
    Public Event EmployeeEdited As EventHandler
    Private originalEmail As String
    Private originalPhoneNo As String

    Public Sub PopulateFields(employeeId As Integer, employeeFname As String, employeeLname As String, employeeRole As String, employeeEmail As String, employeePhoneNo As String, employeeGender As String, employeeNationality As String, employeeAddress As String)
        employeeIdTextBox.Text = employeeId
        firstNameTextBox.Text = employeeFname
        lastNameTextBox.Text = employeeLname
        roleComboBox.Text = employeeRole
        emailTextBox.Text = employeeEmail
        phoneNoTextBox.Text = employeePhoneNo
        genderComboBox.Text = employeeGender
        nationalityComboBox.Text = employeeNationality
        addressTextBox.Text = employeeAddress
        originalEmail = employeeEmail
        originalPhoneNo = employeePhoneNo
    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        Dim eId As Integer = employeeIdTextBox.Text
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

        Dim existsMsg As String = employeeValidation.EmailOrPhoneExists(eEmail, ePhoneNo, database.connectionString, originalEmail, originalPhoneNo)
        If Not String.IsNullOrEmpty(existsMsg) Then
            MessageBox.Show(existsMsg, "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "UPDATE employee SET eFname=@eFname, eLname=@eLname, eRole=@eRole, eEmail=@eEmail, ePhoneNo=@ePhoneNo, eGender=@eGender, eNationality=@eNationality, eAddress=@eAddress WHERE eId=@eId"

        Using conn As New SqlConnection(database.connectionString)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@eId", eId)
            cmd.Parameters.AddWithValue("@eFname", eFname)
            cmd.Parameters.AddWithValue("@eLname", eLname)
            cmd.Parameters.AddWithValue("@eRole", eRole)
            cmd.Parameters.AddWithValue("@eEmail", eEmail)
            cmd.Parameters.AddWithValue("@ePhoneNo", ePhoneNo)
            cmd.Parameters.AddWithValue("@eGender", eGender)
            cmd.Parameters.AddWithValue("@eNationality", eNationality)
            cmd.Parameters.AddWithValue("@eAddress", eAddress)
            Try
                conn.Open()

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Employee edited successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RaiseEvent EmployeeEdited(Me, EventArgs.Empty)
                Else
                    MessageBox.Show("An error occurred while editing the employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub editEmployeeDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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