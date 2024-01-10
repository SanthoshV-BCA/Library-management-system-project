Imports System.Data
Imports System.Data.OleDb
Public Class Studentinf
    Private Sub gridview()
        openconn()
        cmd = New OleDbCommand("select * from stuinfo", conn)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "stuinfo")
        DataGridView1.DataSource = ds.Tables("stuinfo")
        conn.Close()
    End Sub
    Private Sub Studentinf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gridview()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Enter StudentID!")
            TextBox1.Focus()
            Exit Sub
        End If
        Try
            openconn()
            cmd = New OleDbCommand("select * from stuinfo where Studentid='" & TextBox1.Text & "' ", conn)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                TextBox1.Text = rdr.Item("Studentid")
            Else
                MsgBox("Student not Found", MsgBoxStyle.Information)
                TextBox1.Focus()
                Exit Sub
            End If
            cmd = New OleDbCommand("select * from stuinfo where Studentid='" & TextBox1.Text & "'", conn)
            da = New OleDbDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "stuinfo")
            DataGridView1.DataSource = ds.Tables("stuinfo")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!")
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Then
            MessageBox.Show("Enter Department!")
            TextBox2.Focus()
            Exit Sub
        End If
        Try
            openconn()
            cmd = New OleDbCommand("select * from stuinfo where Department='" & TextBox2.Text & "' ", conn)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                TextBox2.Text = rdr.Item("Department")
            Else
                MsgBox("Student Not Found", MsgBoxStyle.Information)
                TextBox2.Focus()
                Exit Sub
            End If
            cmd = New OleDbCommand("select * from stuinfo where Department='" & TextBox2.Text & "'", conn)
            da = New OleDbDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "stuinfo")
            DataGridView1.DataSource = ds.Tables("stuinfo")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox1.Focus()
        gridview()
    End Sub
End Class