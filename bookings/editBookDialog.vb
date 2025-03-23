Public Class editBookDialog
    Private WithEvents inCalendar As New MonthCalendar()
    Private WithEvents outCalendar As New MonthCalendar()

    Private Sub editBookDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inDatePickerButton.Text = DateTime.Now.ToString("dd MMM yyyy")
        inCalendar.Visible = False
        inCalendar.MaxSelectionCount = 1
        inCalendar.ShowTodayCircle = True
        inCalendar.ShowWeekNumbers = False
        Me.Controls.Add(inCalendar)

        outDateTimeButton.Text = DateTime.Now.AddDays(1).ToString("dd MMM yyyy")
        outCalendar.Visible = False
        outCalendar.MaxSelectionCount = 1
        outCalendar.ShowTodayCircle = True
        outCalendar.ShowWeekNumbers = False
        Me.Controls.Add(outCalendar)
    End Sub

    Private Sub inDatePickerButton_Click(sender As Object, e As EventArgs) Handles inDatePickerButton.Click
        inCalendar.Location = New Point(inDatePickerButton.Left, inDatePickerButton.Bottom)
        inCalendar.Visible = Not inCalendar.Visible
        inCalendar.BringToFront()
    End Sub

    Private Sub inCalendar_DateSelected(sender As Object, e As DateRangeEventArgs) Handles inCalendar.DateSelected
        inDatePickerButton.Text = e.Start.ToString("dd MMM yyyy")
        inCalendar.Visible = False
    End Sub

    Private Sub addBookDialog_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        If inCalendar.Visible Then inCalendar.Visible = False
        If outCalendar.Visible Then outCalendar.Visible = False
    End Sub

    Private Sub outDateTimePicker_Click(sender As Object, e As EventArgs) Handles outDateTimeButton.Click
        outCalendar.Location = New Point(outDateTimeButton.Left, outDateTimeButton.Bottom)
        outCalendar.Visible = Not outCalendar.Visible
        outCalendar.BringToFront()
    End Sub

    Private Sub outCalendar_DateSelected(sender As Object, e As DateRangeEventArgs) Handles outCalendar.DateSelected
        outDateTimeButton.Text = e.Start.ToString("dd MMM yyyy")
        outCalendar.Visible = False
    End Sub
End Class