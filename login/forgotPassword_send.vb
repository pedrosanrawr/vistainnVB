Imports System.Net.Mail

Public Class forgotPassword_send
    Public userEmail As String
    Public otp As String

    Public Sub New(email As String)
        InitializeComponent()
        userEmail = email
        emailLabel.Text = email
    End Sub

    Private Sub forgotPassword_send_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Timer1.Start()
        roundCorners(Me)
    End Sub

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


    Private Sub sendButton_Click(sender As Object, e As EventArgs) Handles sendButton.Click
        If String.IsNullOrEmpty(userEmail) Then
            MessageBox.Show("Email address is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        If SendOTPEmail(userEmail, otp) Then
            MessageBox.Show("OTP sent successfully to your email address.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim verifyForm As New fogotPassword_verify(userEmail, otp)
            verifyForm.ShowDialog()
            Me.Close()
        Else
            MessageBox.Show("Failed to send OTP. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Function GenerateOTP() As String
        Dim rand As New Random()
        Return rand.Next(100000, 999999).ToString()
    End Function

    Private Function SendOTPEmail(toEmail As String, ByRef generatedOtp As String) As Boolean
        Try
            Dim smtpClient As New SmtpClient("smtp.gmail.com") With {
                .Port = 587,
                .Credentials = New Net.NetworkCredential("vistainnmanager0@gmail.com", "vder sozj geky cnzr"),
                .EnableSsl = True
            }

            generatedOtp = GenerateOTP()
            Me.otp = generatedOtp

            Dim mailMessage As New MailMessage()
            mailMessage.From = New MailAddress("vistainnmanager0@gmail.com", "VistaInn Team")
            mailMessage.To.Add(toEmail)
            mailMessage.Subject = "OTP for Password Reset"
            mailMessage.Body = "Your OTP for password reset is: " & generatedOtp

            smtpClient.Send(mailMessage)
            Return True
        Catch ex As Exception
            MessageBox.Show("Error sending OTP: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Class

