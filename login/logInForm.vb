Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class logInForm
    Dim database As New database()

    Private Sub logInForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passwordTextBox.PasswordChar = "•"c
    End Sub

    Dim isPasswordVisible As Boolean = False
    Private Sub hidePass_Click(sender As Object, e As EventArgs) Handles hidePass.Click
        If isPasswordVisible Then
            passwordTextBox.PasswordChar = "•"c
            isPasswordVisible = False
            hidePass.Image = Image.FromFile("C:\Users\Chris\source\repos\vistainnVB\Resources\iconHide.png")
        Else
            passwordTextBox.PasswordChar = ControlChars.NullChar
            isPasswordVisible = True
            hidePass.Image = Image.FromFile("C:\Users\Chris\source\repos\vistainnVB\Resources\iconShow.png")
        End If
    End Sub

    Private parentPage As basePage

    Public Sub New(parent As basePage)
        InitializeComponent()
        Me.parentPage = parent
    End Sub

    Private Sub logInButton_Click(sender As Object, e As EventArgs) Handles logInButton.Click
        Dim email As String = emailTextBox.Text
        Dim password As String = passwordTextBox.Text
        Dim role As String = ""

        Dim conn As New SqlConnection(database.connectionString)

        Try
            conn.Open()

            Dim checkEmailQuery As String = "SELECT eRole, ePassword, eSalt FROM employee WHERE eEmail=@eEmail"
            Dim cmd As New SqlCommand(checkEmailQuery, conn)
            cmd.Parameters.AddWithValue("@eEmail", email)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim storedHash As String = reader("ePassword").ToString()
                Dim storedSaltBase64 As String = reader("eSalt").ToString()

                Dim saltedPassword As String = password & storedSaltBase64
                Dim inputHash As String
                Using sha256 As SHA256 = SHA256.Create()
                    Dim hashBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword))
                    inputHash = Convert.ToBase64String(hashBytes)
                End Using

                If storedHash = inputHash Then
                    Employee.Email = email
                    Employee.Role = reader("eRole").ToString()
                    role = Employee.Role

                    reader.Close()

                    Select Case role
                        Case "Admin"
                            basePage.loadForm(New analytics())
                        Case "Staff"
                            basePage.loadForm(New bookingTable())
                        Case "Manager"
                            basePage.loadForm(New bookingTable())
                    End Select
                Else
                    MessageBox.Show("The password you entered is incorrect.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("The email address is not registered or invalid. Please check your email.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub forgotPasswordLabelLink_Click(sender As Object, e As EventArgs) Handles forgotPasswordLabelLink.Click
        If String.IsNullOrEmpty(emailTextBox.Text) Then
            MessageBox.Show("Please enter an email first.", "Email Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim forgotPassword_send As New forgotPassword_send(emailTextBox.Text)
            forgotPassword_send.ShowDialog()
        End If
    End Sub
End Class

Class Employee
    Public Shared Property Email As String
    Public Shared Property Role As String
    Public Shared Property ProfilePic As Byte()
    Public Shared Property FirstName As String
    Public Shared Property LastName As String
    Public Shared Property PhoneNo As String
    Public Shared Property Gender As String
    Public Shared Property Nationality As String
    Public Shared Property Address As String
End Class
