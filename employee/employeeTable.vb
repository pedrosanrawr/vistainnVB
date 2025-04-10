Imports System.Data.SqlClient

Public Class employeeTable
    Dim menuForm As Form
    Dim addEmployeeDialog As New addEmployeeDialog()
    Dim editEmployeeDialog As New editEmployeeDialog()
    Dim overlayPanel As New Panel()
    Dim menuVisible As Boolean = False
    Dim slidingIn As Boolean = False
    Dim editingIn As Boolean = False
    Dim database As New database()
    Dim employeeBindingSource As New BindingSource()

    Private Sub accTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        AddHandler addEmployeeDialog.EmployeeAdded, AddressOf AddEmployeeDialog_EmployeeAdded
        AddHandler editEmployeeDialog.EmployeeEdited, AddressOf EditEmployeeDialog_EmployeeEdited

        LoadEmployeeData()
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

    Public Sub LoadEmployeeData()
        Dim query As String = "SELECT * FROM employee"

        Using conn As New SqlConnection(database.connectionString)
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim dt As New DataTable()

            Try
                conn.Open()
                adapter.Fill(dt)

                employeeBindingSource.DataSource = dt

                employeeDGV.DataSource = employeeBindingSource

                employeeDGV.Columns("eProfilePic").Visible = False
                employeeDGV.Columns("ePassword").Visible = False
                employeeDGV.Columns("eSalt").Visible = False
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub employeeDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles employeeDGV.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = employeeDGV.Rows(e.RowIndex)

            Dim employeeId As Integer = selectedRow.Cells("employeeId").Value.ToString()
            Dim employeeFname As String = selectedRow.Cells("employeeFname").Value.ToString()
            Dim employeeLname As String = selectedRow.Cells("employeeLname").Value.ToString()
            Dim employeeRole As String = selectedRow.Cells("employeeRole").Value.ToString()
            Dim employeeEmail As String = selectedRow.Cells("employeeEmail").Value.ToString()
            Dim employeePhoneNo As String = selectedRow.Cells("employeePhoneNo").Value.ToString()
            Dim employeeGender As String = selectedRow.Cells("employeeGender").Value.ToString()
            Dim employeeNationality As String = selectedRow.Cells("employeeNationality").Value.ToString()
            Dim employeeAddress As String = selectedRow.Cells("employeeAddress").Value.ToString()

            editEmployeeDialog.PopulateFields(employeeId, employeeFname, employeeLname, employeeRole, employeeEmail, employeePhoneNo, employeeGender, employeeNationality, employeeAddress)
        End If
    End Sub

    Private Sub refreshAccButton_Click(sender As Object, e As EventArgs) Handles refreshAccButton.Click
        LoadEmployeeData()
    End Sub

    Private Sub AddEmployeeDialog_EmployeeAdded(sender As Object, e As EventArgs)
        LoadEmployeeData()
    End Sub

    Private Sub EditEmployeeDialog_EmployeeEdited(sender As Object, e As EventArgs)
        LoadEmployeeData()
    End Sub

    Private Sub searchAccTextBox_TextChanged(sender As Object, e As EventArgs) Handles searchAccTextBox.TextChanged
        Dim filter As String = searchAccTextBox.Text

        If String.IsNullOrWhiteSpace(filter) Then
            employeeBindingSource.Filter = Nothing
        Else
            employeeBindingSource.Filter = String.Format("eFname LIKE '%{0}%' OR eLname LIKE '%{0}%' OR eEmail LIKE '%{0}%' OR ePhoneNo LIKE '%{0}%'", filter)
        End If
    End Sub
End Class