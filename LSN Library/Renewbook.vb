Imports System.Data
Imports System.Data.OleDb
Public Class Renewbook
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox2.Text = "" Then
            MessageBox.Show("Please Enter the Book Accession No.")
            Exit Sub
        End If
        Try
            openconn()
            cmd = New OleDbCommand("select*from issuebook where AccessionNo='" & TextBox2.Text & "'", conn)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                TextBox1.Text = rdr.Item("AccessionNo")
                TextBox3.Text = rdr.Item("BookTitle")
                TextBox4.Text = rdr.Item("Author")
                TextBox5.Text = rdr.Item("idRollno")
                issuedate.Text = rdr.Item("issueDate")
                returndate.Text = rdr.Item("returnDate")
            Else
                MessageBox.Show("Record not Found")
                TextBox2.Clear()
                TextBox2.Focus()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            openconn()
            cmd = New OleDbCommand("update issuebook set [returnDate]='" & renewdate.Text & "' where [AccessionNo]='" & TextBox2.Text & "'", conn)
            cmd.ExecuteNonQuery()
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            MessageBox.Show("Book Renew Successfully", "Renew Operation")
            clr()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub clr()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        issuedate.Text = ""
        returndate.Text = ""
        renewdate.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clr()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Mainpage.Show()
        Me.Hide()
    End Sub
End Class