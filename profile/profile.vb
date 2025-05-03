Imports System.Data.SqlClient

Public Class profile
    Dim menuForm As Form
    Dim menuVisible As Boolean = False
    Dim menuSpeed As Integer = 20
    Dim database As New database()
    Dim employeeData As Employee = GetEmployeeData(Employee.Email)

    Private Sub profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        fadeIn.Start()

        DisplayEmployeeProfile(employeeData)

        Select Case Employee.Role
            Case "Staff"
                menuForm = New menuFormStaff()
            Case "Manager"
                menuForm = New menuFormManager()
            Case "Admin"
                menuForm = New menuForm()
        End Select

        menuForm.TopLevel = False
        menuForm.FormBorderStyle = FormBorderStyle.None
        menuForm.Left = -menuForm.Width
        menuForm.Top = 0
        menuForm.Height = Me.Height
        menuForm.Parent = Me
        menuForm.BringToFront()
        Me.Controls.Add(menuForm)
        menuForm.Show()
    End Sub

    Private Sub fadeIn_Tick(sender As Object, e As EventArgs) Handles fadeIn.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        Else
            fadeIn.Stop()
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

    Private Function GetEmployeeData(email As String) As Employee
        Dim employee As New Employee()

        Dim query As String = "SELECT eProfilePic, eFname, eLname, eRole, eEmail, ePhoneNo, eGender, eNationality, eAddress FROM Employee WHERE eEmail = @Email"

        Using conn As New SqlConnection(database.connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Email", email)

                conn.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Employee.ProfilePic = If(IsDBNull(reader("eProfilePic")), Nothing, CType(reader("eProfilePic"), Byte()))
                            Employee.FirstName = reader("eFname").ToString()
                            Employee.LastName = reader("eLname").ToString()
                            Employee.Role = reader("eRole").ToString()
                            Employee.Email = reader("eEmail").ToString()
                            Employee.PhoneNo = reader("ePhoneNo").ToString()
                            Employee.Gender = reader("eGender").ToString()
                            Employee.Nationality = reader("eNationality").ToString()
                            Employee.Address = reader("eAddress").ToString()
                        End While
                    End If
                End Using
            End Using
        End Using

        Return employee
    End Function

    Private Sub DisplayEmployeeProfile(employee As Employee)
        nameLabel.Text = Employee.FirstName & " " & Employee.LastName
        roleLabel.Text = Employee.Role
        emailLabel.Text = Employee.Email
        phoneNoLabel.Text = Employee.PhoneNo
        genderLabel.Text = Employee.Gender
        nationalityLabel.Text = Employee.Nationality
        addressLabel.Text = Employee.Address

        If Employee.ProfilePic IsNot Nothing Then
            Using ms As New IO.MemoryStream(Employee.ProfilePic)
                profilePicture.Image = Image.FromStream(ms)
                profilePicture.SizeMode = PictureBoxSizeMode.StretchImage
            End Using
        Else
            profilePicture.Image = My.Resources.Ellipse_1
        End If
    End Sub

    Private Sub changeProfilePicButton_Click(sender As Object, e As EventArgs) Handles changeProfilePicButton.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to change your profile picture?", "Confirm Profile Picture Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim ofd As New OpenFileDialog()
            ofd.Title = "Select a Profile Picture"
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

            If ofd.ShowDialog() = DialogResult.OK Then
                Dim imageBytes() As Byte = IO.File.ReadAllBytes(ofd.FileName)
                UpdateProfilePicture(Employee.Email, imageBytes)

                Using ms As New IO.MemoryStream(imageBytes)
                    profilePicture.Image = Image.FromStream(ms)
                End Using

                Employee.ProfilePic = imageBytes

                MessageBox.Show("Profile picture updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub UpdateProfilePicture(email As String, imageBytes As Byte())
        Dim query As String = "UPDATE Employee SET eProfilePic = @ProfilePic WHERE eEmail = @Email"

        Using conn As New SqlConnection(database.connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ProfilePic", imageBytes)
                cmd.Parameters.AddWithValue("@Email", email)

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        DisplayEmployeeProfile(employeeData)
    End Sub
End Class