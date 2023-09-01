Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class login
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        cform.Show()
    End Sub


    Private Sub showpass_CheckedChanged_1(sender As Object, e As EventArgs) Handles showpass.CheckedChanged
        If showpass.Checked = True Then
            txtpass.PasswordChar = ""

        ElseIf showpass.Checked = False Then
            txtpass.PasswordChar = "*"

        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub
End Class