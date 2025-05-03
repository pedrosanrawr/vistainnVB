Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

Public Class menuForm
    Dim nestedTabTables As New nestedTabTables()
    Private isExpanded As Boolean = False
    Private expandedHeight As Integer = 300
    Private selectedButton As Guna.UI2.WinForms.Guna2Button = Nothing
    Private radioButtons As New List(Of Guna.UI2.WinForms.Guna2Button)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nestedTabTables.Height = 0
        nestedTabTables.Visible = False
        nestedTabTables.Parent = Me

        nestedTabTables.Location = New Point(btnTables.Left, btnTables.Bottom + 5)

        dropDownIcon.Image.RotateFlip(RotateFlipType.Rotate180FlipXY)

        radioButtons.Add(btnTables)
        radioButtons.Add(profileButton)
        radioButtons.Add(logOutButton)
        radioButtons.Add(btnAnalytics)

    End Sub


    Private Sub SelectButton(selected As Guna.UI2.WinForms.Guna2Button)
        If selectedButton IsNot Nothing Then
            selectedButton.FillColor = Color.Empty
        End If

        selectedButton = selected
        selectedButton.FillColor = Color.Black
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim stepSize As Integer = 10

        If isExpanded Then
            If nestedTabTables.Height > 0 Then
                nestedTabTables.Height -= stepSize
                AdjustButtonPositions(-stepSize)
            Else
                nestedTabTables.Visible = False
                Timer1.Stop()
                isExpanded = False
                RotateIcon()
            End If
        Else
            nestedTabTables.Visible = True
            If nestedTabTables.Height < expandedHeight Then
                nestedTabTables.Height += stepSize
                AdjustButtonPositions(stepSize)
            Else
                Timer1.Stop()
                isExpanded = True
                RotateIcon()
            End If
        End If
    End Sub

    Private Sub AdjustButtonPositions(stepSize As Integer)
        profileButton.Top += stepSize
        profileIcon.Top += stepSize
        logOutButton.Top += stepSize
        logOutIcon.Top += stepSize
    End Sub

    Private Sub RotateIcon()
        dropDownIcon.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
        dropDownIcon.Refresh()
    End Sub

    Private Sub btnAnalytics_Click(sender As Object, e As EventArgs) Handles btnAnalytics.Click
        SelectButton(sender)
        basePage.loadForm(New analytics())
    End Sub

    Private Sub btnTables_Click(sender As Object, e As EventArgs) Handles btnTables.Click
        SelectButton(sender)
        Timer1.Start()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles profileButton.Click
        SelectButton(sender)
        basePage.loadForm(New profile())
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles logOutButton.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?",
                                                 "Confirm Logout",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            SelectButton(sender)
            basePage.loadForm(New logInForm(basePage))
        End If
    End Sub
End Class
