Imports Org.BouncyCastle.Crypto.Engines

Public Class cform
    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Me.Hide()
        login.Show()
    End Sub


    Private Sub spass_CheckedChanged(sender As Object, e As EventArgs) Handles spass.CheckedChanged
        If spass.Checked = True Then

            txtpasss.UseSystemPasswordChar = False
        Else
            txtpasss.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click

        MessageBox.Show("Succesfully Registered New Account", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Close()
    End Sub
End Class