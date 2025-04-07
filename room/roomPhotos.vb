Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports Guna.UI2.WinForms

Public Class roomPhotos
    Dim database As New database()

    Public Sub LoadRoomPhotos()
        roomPhotosFlowLayoutPanel.Controls.Clear()

        Dim query As String = "SELECT rName, MAX(rImage) as rImage FROM rooms GROUP BY rName"

        Using conn As New SqlConnection(database.connectionString)
            Dim cmd As New SqlCommand(query, conn)
            Dim dt As New DataTable()

            Try
                conn.Open()
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)

                For Each row As DataRow In dt.Rows
                    Dim roomPanel As New Panel()
                    roomPanel.Size = New Size(530, 150)
                    roomPanel.Margin = New Padding(10)

                    Dim pictureBox As New Guna2PictureBox()
                    pictureBox.Size = New Size(150, 150)
                    pictureBox.Location = New Point(15, 0)
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                    pictureBox.BorderRadius = 5

                    If Not IsDBNull(row("rImage")) Then
                        Dim photo As Byte() = CType(row("rImage"), Byte())
                        Using ms As New MemoryStream(photo)
                            pictureBox.Image = Image.FromStream(ms)
                        End Using
                    End If

                    Dim nameLabel As New Label()
                    nameLabel.Text = row("rName").ToString()
                    nameLabel.Location = New Point(167, -8)
                    nameLabel.Font = New Font("Raleway", 24, FontStyle.Bold, GraphicsUnit.Pixel)
                    nameLabel.ForeColor = Color.Black
                    nameLabel.AutoSize = True

                    Dim editButton As New Guna2Button()
                    editButton.Text = "EDIT"
                    editButton.Size = New Size(130, 50)
                    editButton.Location = New Point(395, 100)
                    editButton.FillColor = Color.Black
                    editButton.ForeColor = Color.White
                    editButton.BorderRadius = 6
                    editButton.Font = New Font("Raleway", 20, FontStyle.Bold, GraphicsUnit.Pixel)

                    editButton.Tag = row("rName").ToString()
                    AddHandler editButton.Click, AddressOf editRoomPhotosButton_Click

                    roomPanel.Controls.Add(pictureBox)
                    roomPanel.Controls.Add(nameLabel)
                    roomPanel.Controls.Add(editButton)

                    roomPhotosFlowLayoutPanel.Controls.Add(roomPanel)
                Next
            Catch ex As Exception
                MessageBox.Show("Error loading room photos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub roomPhotos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRoomPhotos()
    End Sub

    Private Sub editRoomPhotosButton_Click(sender As Object, e As EventArgs)
        Dim roomName As String = CType(sender, Guna2Button).Tag.ToString()

        Dim openFileDialog As New OpenFileDialog() With {
            .Filter = "Image Files|*.jpg;*.jpeg;*.png",
            .Title = "Select a Room Image"
        }

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim selectedImagePath As String = openFileDialog.FileName
            Dim selectedImage As Image = Image.FromFile(selectedImagePath)

            Dim imageBytes As Byte()
            Using ms As New MemoryStream()
                selectedImage.Save(ms, ImageFormat.Png)
                imageBytes = ms.ToArray()
            End Using

            UpdateRoomImageInDatabase(roomName, imageBytes)
            UpdateRoomPictureBox(roomName, selectedImage)
            MessageBox.Show("Room photo updated successfully!")
        End If
    End Sub

    Private Sub UpdateRoomImageInDatabase(roomName As String, imageBytes As Byte())
        Using conn As New SqlConnection(database.connectionString)
            Dim query As String = "UPDATE rooms SET rImage = @rImage WHERE rName = @rName"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@rImage", imageBytes)
            cmd.Parameters.AddWithValue("@rName", roomName)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error updating room image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub UpdateRoomPictureBox(roomName As String, selectedImage As Image)
        For Each roomPanel As Panel In roomPhotosFlowLayoutPanel.Controls
            Dim nameLabel As Label = roomPanel.Controls.OfType(Of Label)().FirstOrDefault()

            If nameLabel IsNot Nothing AndAlso nameLabel.Text = roomName Then
                Dim pictureBox As Guna2PictureBox = roomPanel.Controls.OfType(Of Guna2PictureBox)().FirstOrDefault()
                If pictureBox IsNot Nothing Then
                    pictureBox.Image = selectedImage
                End If
                Exit For
            End If
        Next
    End Sub
End Class
