Imports System.Net.Security

Public Class basePage
    Public Property FormToLoad As Form

    Private Sub basePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Timer1.Start()

        loadForm(New logInForm(Me))
        roundCorners(Me)
    End Sub

    Public Sub loadForm(formToLoad As Form)
        pagePanel.Controls.Clear()

        formToLoad.TopLevel = False
        formToLoad.Dock = DockStyle.Fill
        pagePanel.Controls.Add(formToLoad)
        formToLoad.Show()
    End Sub
End Class
