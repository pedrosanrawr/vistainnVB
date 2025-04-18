﻿Public Class nestedTabTablesStaff
    Inherits UserControl

    Private selectedButton As Guna.UI2.WinForms.Guna2Button = Nothing
    Private radioButtons As New List(Of Guna.UI2.WinForms.Guna2Button)

    Private Sub SelectButton(selected As Guna.UI2.WinForms.Guna2Button)
        If selectedButton IsNot Nothing Then
            selectedButton.FillColor = Color.Empty
        End If

        selectedButton = selected
        selectedButton.FillColor = Color.Black
    End Sub

    Private Sub bookingButton_Click(sender As Object, e As EventArgs)
        SelectButton(sender)
        basePage.loadForm(New bookingTable())
    End Sub

    Private Sub paymentButton_Click(sender As Object, e As EventArgs)
        SelectButton(sender)
        basePage.loadForm(New paymentTable())
    End Sub

    Private Sub extrasButton_Click(sender As Object, e As EventArgs)
        SelectButton(sender)
        basePage.loadForm(New extrasTable())
    End Sub

    Private Sub nestedTabTables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radioButtons.Add(bookingButton)
        radioButtons.Add(paymentButton)
        radioButtons.Add(extrasButton)

        AddHandler bookingButton.Click, AddressOf bookingButton_Click
        AddHandler paymentButton.Click, AddressOf paymentButton_Click
        AddHandler extrasButton.Click, AddressOf extrasButton_Click
    End Sub
End Class
