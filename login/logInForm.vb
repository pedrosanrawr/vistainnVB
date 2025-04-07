Imports System.Data.SqlClient

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

            Dim checkEmailQuery As String = "SELECT eRole, ePassword FROM employee WHERE eEmail=@eEmail"
            Dim cmd As New SqlCommand(checkEmailQuery, conn)
            cmd.Parameters.AddWithValue("@eEmail", email)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim storedPassword As String = reader("ePassword").ToString()

                If storedPassword = password Then
                    Employee.Email = email
                    Employee.Role = reader("eRole").ToString()
                    role = Employee.Role

                    Select Case role
                        Case "Admin"
                            basePage.loadForm(New analytics())
                        Case "Staff"
                            basePage.loadForm(New bookingTable())
                        Case "Manager"
                            basePage.loadForm(New roomTable())
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
        Dim forgotPassword_send As New forgotPassword_send()
        forgotPassword_send.ShowDialog()
    End Sub
End Class

Class Employee
    Public Shared Property Email As String
    Public Shared Property Role As String

End Class
