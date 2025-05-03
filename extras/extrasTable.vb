Imports System.Data.SqlClient

Public Class extrasTable
    Dim menuForm As Form
    Dim addExtrasDialog As New addExtrasDialog()
    Dim editExtraDialog As New editExtraDialog()
    Dim overlayPanel As New Panel()
    Dim menuVisible As Boolean = False
    Dim slidingIn As Boolean = False
    Dim editingIn As Boolean = False
    Dim HideButtons As New HideButtons()
    Dim database As New database()
    Dim extrasBindingSource As New BindingSource()
    Public Event ExtrasDeleted As EventHandler

    Private Sub bookingTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        fadeIn.Start()

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

        InitializeDialog(addExtrasDialog)
        InitializeDialog(editExtraDialog)
        SDialog(addExtrasDialog)
        SDialog(editExtraDialog)
        HideButtons.hideButtonsExtras(Me)
        AddHandler addExtrasDialog.ExtrasAdded, AddressOf AddExtrasDialog_ExtrasAdded
        AddHandler editExtraDialog.ExtrasEdited, AddressOf EditExtrasDialog_ExtrasEdited

        LoadExtrasData()
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

    Private Sub fadeIn_Tick(sender As Object, e As EventArgs) Handles fadeIn.Tick
        If Me.Opacity < 1 Then Me.Opacity += 0.05 Else fadeIn.Stop()
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

    Private Sub extras_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If menuVisible AndAlso Not menuForm.Bounds.Contains(e.Location) Then menuTimer.Start()
    End Sub

    Private Sub addExtrasButton_Click(sender As Object, e As EventArgs) Handles addExtrasButton.Click
        overlayPanel.Visible = True
        slidingIn = True
        dialogTimer.Start()
    End Sub

    Private Sub editExtrasButton_Click(sender As Object, e As EventArgs) Handles editExtrasButton.Click
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
            SlideDialogIn(addExtrasDialog)
        ElseIf editingIn Then
            SlideDialogIn(editExtraDialog)
        Else
            SlideDialogsOut()
        End If
    End Sub

    Private Sub SlideDialogIn(dialog As Form)
        If dialog.Left > Me.Width - dialog.Width Then dialog.Left -= 20 Else dialogTimer.Stop()
    End Sub

    Private Sub SlideDialogsOut()
        If addExtrasDialog.Left < Me.Width Then addExtrasDialog.Left += 20
        If editExtraDialog.Left < Me.Width Then editExtraDialog.Left += 20
        If addExtrasDialog.Left >= Me.Width AndAlso editExtraDialog.Left >= Me.Width Then
            dialogTimer.Stop()
            overlayPanel.Visible = False
        End If
    End Sub

    Public Sub LoadExtrasData()
        Dim query As String = "SELECT * FROM itemExtras"

        Using conn As New SqlConnection(database.connectionString)
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim dt As New DataTable()

            Try
                conn.Open()
                adapter.Fill(dt)

                extrasBindingSource.DataSource = dt

                extrasDGV.DataSource = extrasBindingSource
                extrasDGV.Columns("extrasPrice").DefaultCellStyle.Format = "N2"

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub extrasDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles extrasDGV.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = extrasDGV.Rows(e.RowIndex)

            Dim extrasId As Integer = selectedRow.Cells("extrasId").Value.ToString()
            Dim extrasItem As String = selectedRow.Cells("extrasItems").Value.ToString()
            Dim extrasPrice As String = selectedRow.Cells("extrasPrice").Value.ToString()
            Dim extrasQty As String = selectedRow.Cells("extrasQuantity").Value.ToString()

            editExtraDialog.PopulateFields(extrasId, extrasItem, extrasPrice, extrasQty)
        End If
    End Sub

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        LoadExtrasData()
    End Sub

    Private Sub AddExtrasDialog_ExtrasAdded(sender As Object, e As EventArgs)
        LoadExtrasData()
    End Sub

    Private Sub EditExtrasDialog_ExtrasEdited(sender As Object, e As EventArgs)
        LoadExtrasData()
    End Sub

    Private Sub searchTextBox_TextChanged(sender As Object, e As EventArgs) Handles searchTextBox.TextChanged
        Dim filter As String = searchTextBox.Text

        If String.IsNullOrWhiteSpace(filter) Then
            extrasBindingSource.Filter = Nothing
        Else
            extrasBindingSource.Filter = String.Format("ixExtras LIKE '%{0}%'", filter)
        End If
    End Sub

    Private Sub deleteExtrasButton_Click(sender As Object, e As EventArgs) Handles deleteExtrasButton.Click
        If extrasDGV.CurrentRow Is Nothing Then
            MessageBox.Show("Please select an item to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim confirmResult As DialogResult = MessageBox.Show(
            "Are you sure you want to delete this item? This action cannot be undone.",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If confirmResult = DialogResult.Yes Then
            Dim selectedRow As DataGridViewRow = extrasDGV.CurrentRow
            Dim selectedId As String = selectedRow.Cells("extrasId").Value.ToString()

            Dim conn As New SqlConnection(database.connectionString)
            Dim query As String = "DELETE FROM itemExtras WHERE ixId = @ixId"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ixId", selectedId)

            Try
                conn.Open()
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    RaiseEvent ExtrasDeleted(Me, EventArgs.Empty)

                    LoadExtrasData()
                    MessageBox.Show("Item successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No item was deleted. It may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End If
    End Sub
End Class