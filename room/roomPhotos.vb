Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports Guna.UI2.WinForms

Public Class roomPhotos
    Dim database As New database()

    Public Async Sub LoadRoomPhotos()
        roomPhotosFlowLayoutPanel.Controls.Clear()

        Dim query As String = "SELECT rName FROM rooms GROUP BY rName"

        Using conn As New SqlConnection(database.ConnectionString)
            Dim cmd As New SqlCommand(query, conn)
            Dim dt As New DataTable()

            Try
                conn.Open()
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)

                For Each row As DataRow In dt.Rows
                    Dim roomName As String = row("rName").ToString()

                    Dim roomPanel As New Panel() With {
                    .Size = New Size(530, 150),
                    .Margin = New Padding(10)
                }

                    Dim pictureBox As New Guna2PictureBox() With {
                    .Size = New Size(150, 150),
                    .Location = New Point(15, 0),
                    .SizeMode = PictureBoxSizeMode.StretchImage,
                    .BorderRadius = 5,
                    .FillColor = Color.LightGray,
                    .BackColor = Color.LightGray,
                    .UseTransparentBackground = False
                }


                    Dim nameLabel As New Label() With {
                    .Text = roomName,
                    .Location = New Point(167, -8),
                    .Font = New Font("Raleway", 24, FontStyle.Bold, GraphicsUnit.Pixel),
                    .ForeColor = Color.Black,
                    .AutoSize = True
                }

                    Dim editButton As New Guna2Button() With {
                    .Text = "EDIT",
                    .Size = New Size(130, 50),
                    .Location = New Point(395, 100),
                    .FillColor = Color.Black,
                    .ForeColor = Color.White,
                    .BorderRadius = 6,
                    .Font = New Font("Raleway", 20, FontStyle.Bold, GraphicsUnit.Pixel),
                    .Tag = roomName
                }
                    AddHandler editButton.Click, AddressOf editRoomPhotosButton_Click

                    roomPanel.Controls.Add(pictureBox)
                    roomPanel.Controls.Add(nameLabel)
                    roomPanel.Controls.Add(editButton)

                    roomPhotosFlowLayoutPanel.Controls.Add(roomPanel)

                    Await Task.Run(Sub()
                                       Dim imageBytes As Byte() = Nothing
                                       Using imgConn As New SqlConnection(database.ConnectionString)
                                           Dim imgCmd As New SqlCommand("SELECT TOP 1 rImage FROM rooms WHERE rName = @rName ORDER BY rID DESC", imgConn)
                                           imgCmd.Parameters.AddWithValue("@rName", roomName)
                                           imgConn.Open()
                                           Dim result = imgCmd.ExecuteScalar()
                                           If result IsNot DBNull.Value Then
                                               imageBytes = CType(result, Byte())
                                           End If
                                       End Using

                                       If imageBytes IsNot Nothing Then
                                           Try
                                               Using ms As New MemoryStream(imageBytes)
                                                   Dim img = Image.FromStream(ms)
                                                   pictureBox.Invoke(Sub()
                                                                         pictureBox.Image = img
                                                                     End Sub)
                                               End Using
                                           Catch ex As Exception
                                           End Try
                                       End If
                                   End Sub)
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

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to change the room photo?", "Confirm Photo Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
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
