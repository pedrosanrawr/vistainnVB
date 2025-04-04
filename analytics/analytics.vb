Public Class analytics
    Dim menuForm As Form
    Dim menuVisible As Boolean = False
    Dim menuSpeed As Integer = 20

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Timer1.Start()

        Select Case Employee.Role
            Case "Staff"
                menuForm = New menuFormStaff()
            Case "Manager"
                menuForm = New menuFormManager()
            Case "Admin"
                menuForm = New menuForm()
        End Select

        menuForm.TopLevel = False
        menuForm.Left = -menuForm.Width
        menuForm.Top = 0
        menuForm.Height = Me.Height
        menuForm.Parent = Me
        menuForm.BringToFront()
        Me.Controls.Add(menuForm)
        menuForm.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        Else
            Timer1.Stop()
        End If
    End Sub

    Private Sub btnToggleMenu_Click(sender As Object, e As EventArgs) Handles menuButton.Click
        menuForm.BringToFront()
        menuTimer.Start()
    End Sub

    Private Sub menuTimer_Tick(sender As Object, e As EventArgs) Handles menuTimer.Tick
        If menuVisible Then
            If menuForm.Left > -menuForm.Width Then
                menuForm.Left -= menuSpeed
            Else
                menuForm.Left = -menuForm.Width
                menuTimer.Stop()
                menuVisible = False
            End If
        Else
            If menuForm.Left < 0 Then
                menuForm.Left += menuSpeed
                If menuForm.Left > 0 Then menuForm.Left = 0
            Else
                menuForm.Left = 0
                menuTimer.Stop()
                menuVisible = True
            End If
        End If
    End Sub

    Private Sub analytics_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If menuVisible AndAlso Not menuForm.Bounds.Contains(e.Location) Then
            menuTimer.Start()
        End If
    End Sub
End Class
