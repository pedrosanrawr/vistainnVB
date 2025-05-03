Imports System.Data.SqlClient
Imports TheArtOfDev.HtmlRenderer.Adapters

Public Class roomTable
    Dim menuForm As Form
    Dim database As New database()
    Dim addRoomDialog As New addRoomDialog()
    Dim editRoomDialog As New editRoomDialog()
    Dim roomPhotos As New roomPhotos()
    Dim overlayPanel As New Panel()
    Dim menuVisible As Boolean = False
    Dim slidingIn As Boolean = False
    Dim editingIn As Boolean = False
    Dim roomPhotosIn As Boolean = False
    Dim HideButtons As New HideButtons()
    Dim roomBindingSource As New BindingSource()

    Private Sub roomTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        InitializeDialog(addRoomDialog)
        InitializeDialog(editRoomDialog)
        InitializeDialog(roomPhotos)
        SDialog(addRoomDialog)
        SDialog(editRoomDialog)
        SDialog(roomPhotos)
        HideButtons.hideButtonsRooms(Me)
        AddHandler addRoomDialog.RoomAdded, AddressOf AddRoomDialog_RoomAdded
        AddHandler editRoomDialog.RoomEdited, AddressOf EditRoomDialog_RoomEdited

        LoadRoomData()
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

    Private Sub roomTable_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If menuVisible AndAlso Not menuForm.Bounds.Contains(e.Location) Then menuTimer.Start()
    End Sub

    Private Sub addRoomButton_Click(sender As Object, e As EventArgs) Handles addRoomButton.Click
        overlayPanel.Visible = True
        slidingIn = True
        dialogTimer.Start()
    End Sub

    Private Sub editRoomButton_Click(sender As Object, e As EventArgs) Handles editRoomButton.Click
        overlayPanel.Visible = True
        editingIn = True
        dialogTimer.Start()
    End Sub

    Private Sub roomPhotosButton_Click(sender As Object, e As EventArgs) Handles roomPhotosButton.Click
        overlayPanel.Visible = True
        roomPhotosIn = True
        dialogTimer.Start()
    End Sub

    Private Sub overlayPanel_Click(sender As Object, e As EventArgs)
        slidingIn = False
        editingIn = False
        roomPhotosIn = False
        dialogTimer.Start()
        roomPhotos.LoadRoomPhotos()
    End Sub

    Private Sub dialogTimer_Tick(sender As Object, e As EventArgs) Handles dialogTimer.Tick
        If slidingIn Then
            SlideDialogIn(addRoomDialog)
        ElseIf editingIn Then
            SlideDialogIn(editRoomDialog)
        ElseIf roomPhotosIn Then
            SlideDialogIn(roomPhotos)
        Else
            SlideDialogsOut()
        End If
    End Sub

    Private Sub SlideDialogIn(dialog As Form)
        If dialog.Left > Me.Width - dialog.Width Then dialog.Left -= 20 Else dialogTimer.Stop()
    End Sub

    Private Sub SlideDialogsOut()
        If addRoomDialog.Left < Me.Width Then addRoomDialog.Left += 20
        If editRoomDialog.Left < Me.Width Then editRoomDialog.Left += 20
        If roomPhotos.Left < Me.Width Then roomPhotos.Left += 20
        If addRoomDialog.Left >= Me.Width AndAlso editRoomDialog.Left >= Me.Width AndAlso roomPhotos.Left >= Me.Width Then
            dialogTimer.Stop()
            overlayPanel.Visible = False
        End If
    End Sub

    Public Sub LoadRoomData()
        Dim query As String = "SELECT * FROM rooms"

        Using conn As New SqlConnection(database.connectionString)
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim dt As New DataTable()

            Try
                conn.Open()
                adapter.Fill(dt)

                roomBindingSource.DataSource = dt

                roomDGV.DataSource = roomBindingSource

                roomDGV.Columns("rImage").Visible = False
                roomDGV.Columns("roomPrice").DefaultCellStyle.Format = "C2"
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub roomDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles roomDGV.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = roomDGV.Rows(e.RowIndex)

            Dim roomId As String = selectedRow.Cells("roomId").Value.ToString()
            Dim roomNo As String = selectedRow.Cells("roomNo").Value.ToString()
            Dim roomName As String = selectedRow.Cells("roomName").Value.ToString()
            Dim roomPrice As Decimal = selectedRow.Cells("roomPrice").Value.ToString()
            Dim roomCapacity As String = selectedRow.Cells("roomCategory").Value.ToString()
            Dim roomBedroom As String = selectedRow.Cells("roomBedroom").Value.ToString()
            Dim roomBathroom As String = selectedRow.Cells("roomBathroom").Value.ToString()
            Dim roomKitchen As String = selectedRow.Cells("roomKitchen").Value.ToString()
            Dim roomTechnology As String = selectedRow.Cells("roomTechnology").Value.ToString()
            Dim roomGeneral As String = selectedRow.Cells("roomGeneral").Value.ToString()
            Dim roomStatus As String = selectedRow.Cells("roomStatus").Value.ToString()

            editRoomDialog.PopulateFields(roomId, roomNo, roomName, roomPrice, roomCapacity, roomBedroom, roomBathroom, roomKitchen, roomTechnology, roomGeneral, roomStatus)
        End If
    End Sub

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        LoadRoomData()
    End Sub

    Private Sub AddRoomDialog_RoomAdded(sender As Object, e As EventArgs)
        LoadRoomData()
    End Sub

    Private Sub EditRoomDialog_RoomEdited(sender As Object, e As EventArgs)
        LoadRoomData()
    End Sub

    Private Sub searchRoomTextbox_TextChanged(sender As Object, e As EventArgs) Handles searchRoomTextbox.TextChanged
        Dim filter As String = searchRoomTextbox.Text

        If String.IsNullOrWhiteSpace(filter) Then
            roomBindingSource.Filter = Nothing
        Else
            roomBindingSource.Filter = String.Format("rRoomNo LIKE '%{0}%' OR rName LIKE '%{0}%' OR rCategory LIKE '%{0}%' OR rStatus LIKE '%{0}%'", filter)
        End If
    End Sub
End Class
