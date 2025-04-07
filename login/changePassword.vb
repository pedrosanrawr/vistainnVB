Public Class changePassword
    Private Sub changePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Timer1.Start()
        roundCorners(Me)
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub

    Private Sub sendButton_Click(sender As Object, e As EventArgs) Handles sendButton.Click
        Me.Close()
    End Sub
End Class