Public Class logInForm
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
        parentPage.loadForm(New analytics())
    End Sub
End Class