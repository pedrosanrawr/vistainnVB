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
            Dim query As String = "SELECT eRole FROM employee where eEmail=@eEmail AND ePassword=@ePassword"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@eEmail", email)
            cmd.Parameters.AddWithValue("@ePassword", password)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Employee.Email = email
                Employee.Role = reader("eRole").ToString()
                role = reader("eRole").ToString()

                Select Case role
                    Case "Admin"
                        basePage.loadForm(New analytics)
                    Case "Staff"
                        basePage.loadForm(New bookingTable)
                    Case "Manager"
                        basePage.loadForm(New roomTable)
                End Select
            Else
                MessageBox.Show("The username or password is incorrect", "Log In Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        conn.Close()
    End Sub
End Class

Class Employee
    Public Shared Property Email As String
    Public Shared Property Role As String

End Class
