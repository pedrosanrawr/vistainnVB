Imports System.Security.Cryptography
Imports System.Text
Imports System.Data.SqlClient

Public Class changePassword
    Dim database As New database()
    Public userEmail As String

    Public Sub New(email As String)
        InitializeComponent()
        userEmail = email
        emailLabel.Text = userEmail
    End Sub

    Private Sub changeButton_Click(sender As Object, e As EventArgs) Handles changeButton.Click
        If newPasswordTextBox.Text <> reEnterNewPasswordTextBox.Text Then
            MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If String.IsNullOrEmpty(newPasswordTextBox.Text) Then
            MessageBox.Show("Please enter a new password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim newPassword As String = newPasswordTextBox.Text
        Dim salt As String = GenerateSalt()
        Dim hashedPassword As String = HashPassword(newPassword, salt)

        Dim user As String = userEmail

        If UpdatePasswordInDatabase(user, hashedPassword, salt) Then
            MessageBox.Show("Your password has been successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Failed to update password. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
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
            Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword))
            Return Convert.ToBase64String(hashedBytes)
        End Using
    End Function

    Private Function UpdatePasswordInDatabase(email As String, hashedPassword As String, salt As String) As Boolean
        Dim query As String = "UPDATE employee SET ePassword = @ePassword, eSalt = @eSalt WHERE eEmail = @eEmail"

        Using conn As New SqlConnection(database.connectionString)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ePassword", hashedPassword)
            cmd.Parameters.AddWithValue("@eSalt", salt)
            cmd.Parameters.AddWithValue("@eEmail", email)

            Try
                conn.Open()
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to cancel changing the password?",
            "Cancel Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
