Imports System.Net.Mail

Public Class fogotPassword_verify
    Private otp As String = ""
    Private countdown As Integer = 59
    Private otpResent As Boolean = False
    Public userEmail As String

    Public Sub New(email As String, otp As String)
        InitializeComponent()
        userEmail = email
        Me.otp = otp
        emailLabel.Text = "One-Time Password has been sent to " & userEmail & ". Check your email and type the OTP in the text box below."
    End Sub

    Private Sub forgotPassword_verify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        fadeIn.Start()
        roundCorners(Me)
        resendLabel.Text = "Didn't receive a code? You can resend a code in (59s)"
        labelLink.Start()
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

    Private Sub verifyButton_Click(sender As Object, e As EventArgs) Handles verifyButton.Click
        Dim enteredOtp As String = otpTextBox.Text.Trim()

        If enteredOtp = otp Then
            MessageBox.Show("OTP verified successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim changePassword As New changePassword(userEmail)
            changePassword.ShowDialog()
            Me.Close()
        Else
            MessageBox.Show("Invalid OTP. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub fadeIn_Tick(sender As Object, e As EventArgs) Handles fadeIn.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        End If
    End Sub

    Private Sub resendLabel_Click(sender As Object, e As EventArgs) Handles resendLabel.Click
        If countdown = 0 AndAlso Not otpResent Then
            otp = GenerateOTP()
            SendOTPEmail(userEmail, otp)
            otpResent = True
            countdown = 59
            labelLink.Start()
            MessageBox.Show("OTP has been resent to your email address.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("You can only resend OTP after the countdown finishes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Function GenerateOTP() As String
        Dim rand As New Random()
        Return rand.Next(100000, 999999).ToString()
    End Function

    Private Function SendOTPEmail(toEmail As String, otp As String) As Boolean
        Try
            Dim smtpClient As New SmtpClient("smtp.gmail.com") With {
                .Port = 587,
                .Credentials = New Net.NetworkCredential("vistainnmanager0@gmail.com", "vder sozj geky cnzr"),
                .EnableSsl = True
            }

            Dim mailMessage As New MailMessage()
            mailMessage.From = New MailAddress("vistainnmanager0@gmail.com")
            mailMessage.To.Add(toEmail)
            mailMessage.Subject = "OTP for Password Reset"
            mailMessage.Body = "Your OTP for password reset is: " & otp

            smtpClient.Send(mailMessage)
            Return True
        Catch ex As Exception
            MessageBox.Show("Error sending OTP: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub labelLink_Tick(sender As Object, e As EventArgs) Handles labelLink.Tick
        If countdown > 0 Then
            countdown -= 1
            resendLabel.Text = "Didn't receive a code? You can resend a code in (" & countdown.ToString() & "s)"
        Else
            fadeIn.Stop()
            resendLabel.Text = "Didn't receive a code? Click here to resend a code."
        End If
    End Sub
End Class