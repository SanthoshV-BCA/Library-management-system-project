Imports System.Data.OleDb
Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            openconn()
            cmd = New OleDbCommand("Select * from login where  Userid='" & TextBox1.Text & "' and Password='" & TextBox2.Text & "'", conn)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                TextBox1.Text = rdr.Item("Userid")
                TextBox2.Text = rdr.Item("Password")
                Mainpage.Show()
                Me.Hide()
                TextBox1.Clear()
                TextBox2.Clear()
            Else
                MessageBox.Show("incorrect Userid/password")
                TextBox1.Clear()
                TextBox2.Clear()
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Error logging in,please try again", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Adminlog.Show()
    End Sub
End Class