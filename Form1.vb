Public Class Form1
    Private Sub butcreate_Click(sender As Object, e As EventArgs) Handles butcreate.Click
        Try
            create("INSERT INTO dbdata (FirstName, MiddleName, LastName) VALUES ('" & textfname.Text & "','" & textmname.Text & "','" & textlname.Text & "')")


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub butload_Click(sender As Object, e As EventArgs) Handles butload.Click
        Try
            reload("SELECT * FROM dbdata", gridlist)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub butupdate_Click(sender As Object, e As EventArgs) Handles butupdate.Click
        Try
            updates("UPDATE dbdata SET FirstName='" & textfname.Text & "', MiddleName='" & textmname.Text & "', LastName='" & textlname.Text & "' WHERE id = '" & textid.Text & "'")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub gridlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridlist.CellContentClick
        textid.Text = gridlist.CurrentRow.Cells(0).Value
        textfname.Text = gridlist.CurrentRow.Cells(1).Value
        textmname.Text = gridlist.CurrentRow.Cells(2).Value
        textlname.Text = gridlist.CurrentRow.Cells(3).Value
    End Sub

    Private Sub butdel_Click(sender As Object, e As EventArgs) Handles butdel.Click
        Try
            delete("DELETE FROM dbdata WHERE ID = '" & textid.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub butnew_Click(sender As Object, e As EventArgs) Handles butnew.Click
        textid.Text = ""
        textfname.Clear()
        textmname.Clear()
        textlname.Clear()
    End Sub

    Private Sub Guna2TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then

                Dim dv As DataView
                dv = dt.DefaultView
                dv.RowFilter = String.Format("SELECT * FROM dbdata WHERE ID = '" & textid.Text & "'")
                gridlist.DataSource = dv.ToTable()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        login.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged

    End Sub

    Private Sub textid_TextChanged(sender As Object, e As EventArgs) Handles textid.TextChanged

    End Sub
End Class
