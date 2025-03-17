Public Class menuForm
    Private isExpanded As Boolean = False
    Private expandedHeight As Integer = 200
    Private selectedButton As Guna.UI2.WinForms.Guna2Button = Nothing
    Private radioButtons As New List(Of Guna.UI2.WinForms.Guna2Button)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlNestedTabs.Height = 0
        pnlNestedTabs.Visible = False
        dropDownIcon.Image.RotateFlip(RotateFlipType.Rotate180FlipXY)

        radioButtons.Add(btnTables)
        radioButtons.Add(profileButton)
        radioButtons.Add(logOutButton)
        radioButtons.Add(btnAnalytics)
        radioButtons.Add(roomButton)
        radioButtons.Add(bookingButton)
        radioButtons.Add(paymentButton)
        radioButtons.Add(extrasButton)
        radioButtons.Add(accButton)
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
            If pnlNestedTabs.Height > 0 Then
                pnlNestedTabs.Height -= stepSize
                profileButton.Top -= stepSize
                profileIcon.Top -= stepSize
                logOutButton.Top -= stepSize
                logOutIcon.Top -= stepSize
            Else
                pnlNestedTabs.Visible = False
                Timer1.Stop()
                isExpanded = False
                RotateIcon()
            End If
        Else
            pnlNestedTabs.Visible = True
            If pnlNestedTabs.Height < expandedHeight Then
                pnlNestedTabs.Height += stepSize
                profileButton.Top += stepSize
                profileIcon.Top += stepSize
                logOutButton.Top += stepSize
                logOutIcon.Top += stepSize
            Else
                Timer1.Stop()
                isExpanded = True
                RotateIcon()
            End If
        End If
    End Sub

    Private Sub RotateIcon()
        dropDownIcon.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
        dropDownIcon.Refresh()
    End Sub

    Private Sub roomButton_Click(sender As Object, e As EventArgs) Handles roomButton.Click
        SelectButton(sender)
        basePage.loadForm(New roomTable())
    End Sub

    Private Sub bookingButton_Click(sender As Object, e As EventArgs) Handles bookingButton.Click
        SelectButton(sender)
        basePage.loadForm(New bookingTable())
    End Sub

    Private Sub paymentButton_Click(sender As Object, e As EventArgs) Handles paymentButton.Click
        SelectButton(sender)
        basePage.loadForm(New paymentTable())
    End Sub

    Private Sub extrasButton_Click(sender As Object, e As EventArgs) Handles extrasButton.Click
        SelectButton(sender)
        basePage.loadForm(New extrasTable())
    End Sub

    Private Sub accButton_Click(sender As Object, e As EventArgs) Handles accButton.Click
        SelectButton(sender)
        basePage.loadForm(New accTable())
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
        SelectButton(sender)
    End Sub
End Class
