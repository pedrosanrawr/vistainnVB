Public Class employeeTable
    Dim menuForm As New menuForm()
    Dim addEmployeeDialog As New addEmployeeDialog()
    Dim editEmployeeDialog As New editEmployeeDialog()
    Dim overlayPanel As New Panel()
    Dim menuVisible As Boolean = False
    Dim slidingIn As Boolean = False
    Dim editingIn As Boolean = False

    Private Sub accTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Timer1.Start()

        overlayPanel.Dock = DockStyle.Fill
        overlayPanel.BackColor = Color.Transparent
        overlayPanel.Visible = False
        overlayPanel.BringToFront()
        AddHandler overlayPanel.Click, AddressOf overlayPanel_Click
        Me.Controls.Add(overlayPanel)

        menuForm.TopLevel = False
        menuForm.FormBorderStyle = FormBorderStyle.None
        menuForm.Left = -menuForm.Width
        menuForm.Top = 0
        menuForm.Height = Me.Height
        menuForm.Parent = Me
        Me.Controls.Add(menuForm)
        menuForm.Show()

        InitializeDialog(addEmployeeDialog)
        InitializeDialog(editEmployeeDialog)
        SDialog(addEmployeeDialog)
        SDialog(editEmployeeDialog)
    End Sub

    Private Sub InitializeDialog(dialog As Form)
        dialog.TopLevel = False
        dialog.FormBorderStyle = FormBorderStyle.None
        dialog.Dock = DockStyle.None
        Me.Controls.Add(dialog)
        dialog.BringToFront()
    End Sub

    Private Sub SDialog(dialog As Form)
        dialog.Left = Me.Width
        dialog.Top = 0
        dialog.Height = Me.Height
        dialog.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Opacity < 1 Then Me.Opacity += 0.05 Else Timer1.Stop()
    End Sub

    Private Sub btnToggleMenu_Click(sender As Object, e As EventArgs) Handles menuButton.Click
        menuForm.BringToFront()
        menuTimer.Start()
    End Sub

    Private Sub menuTimer_Tick(sender As Object, e As EventArgs) Handles menuTimer.Tick
        If menuVisible Then
            menuForm.Left = Math.Max(menuForm.Left - 20, -menuForm.Width)
            If menuForm.Left = -menuForm.Width Then menuTimer.Stop() : menuVisible = False
        Else
            menuForm.Left = Math.Min(menuForm.Left + 20, 0)
            If menuForm.Left = 0 Then menuTimer.Stop() : menuVisible = True
        End If
    End Sub

    Private Sub accTable_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If menuVisible AndAlso Not menuForm.Bounds.Contains(e.Location) Then menuTimer.Start()
    End Sub

    Private Sub addEmployeeDialog_Click(sender As Object, e As EventArgs) Handles addAccButton.Click
        overlayPanel.Visible = True
        slidingIn = True
        dialogTimer.Start()
    End Sub

    Private Sub editEmployeeDialog_Click(sender As Object, e As EventArgs) Handles editAccButton.Click
        overlayPanel.Visible = True
        editingIn = True
        dialogTimer.Start()
    End Sub

    Private Sub overlayPanel_Click(sender As Object, e As EventArgs)
        slidingIn = False
        editingIn = False
        dialogTimer.Start()
    End Sub

    Private Sub dialogTimer_Tick(sender As Object, e As EventArgs) Handles dialogTimer.Tick
        If slidingIn Then
            SlideDialogIn(addEmployeeDialog)
        ElseIf editingIn Then
            SlideDialogIn(editEmployeeDialog)
        Else
            SlideDialogsOut()
        End If
    End Sub

    Private Sub SlideDialogIn(dialog As Form)
        If dialog.Left > Me.Width - dialog.Width Then dialog.Left -= 20 Else dialogTimer.Stop()
    End Sub

    Private Sub SlideDialogsOut()
        If addEmployeeDialog.Left < Me.Width Then addEmployeeDialog.Left += 20
        If editEmployeeDialog.Left < Me.Width Then editEmployeeDialog.Left += 20
        If addEmployeeDialog.Left >= Me.Width AndAlso editEmployeeDialog.Left >= Me.Width Then
            dialogTimer.Stop()
            overlayPanel.Visible = False
        End If
    End Sub
End Class