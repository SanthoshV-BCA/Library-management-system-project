Imports System.Data
Imports System.Data.OleDb
Public Class Searchbook
    Private Sub gridview()
        openconn()
        cmd = New OleDbCommand("select * from bookinfo", conn)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "bookinfo")
        DataGridView1.DataSource = ds.Tables("bookinfo")
        conn.Close()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter Accession Number!", MsgBoxStyle.Information)
            Exit Sub
        End If
        Try
            openconn()
            cmd = New OleDbCommand("select * from bookinfo where AccessionNo='" & TextBox1.Text & "'", conn)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                TextBox1.Text = rdr.Item("AccessionNo")
            Else
                MessageBox.Show("Book not Found")
                TextBox1.Focus()
                Exit Sub
            End If
            cmd = New OleDbCommand("select * from bookinfo where AccessionNo='" & TextBox1.Text & "'", conn)
            da = New OleDbDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "bookinfo")
            DataGridView1.DataSource = ds.Tables("bookinfo")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!")
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Then
            MsgBox("Enter BookTitle!", MsgBoxStyle.Information)
            Exit Sub
        End If
        Try
            openconn()
            cmd = New OleDbCommand("select * from bookinfo where BookTitle='" & TextBox2.Text & "'", conn)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                TextBox2.Text = rdr.Item("BookTitle")
            Else
                MessageBox.Show("Book not Found")
                TextBox2.Focus()
                Exit Sub
            End If
            cmd = New OleDbCommand("select * from bookinfo where BookTitle='" & TextBox2.Text & "'", conn)
            da = New OleDbDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "bookinfo")
            DataGridView1.DataSource = ds.Tables("bookinfo")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox3.Text = "" Then
            MsgBox("Enter Author Name!", MsgBoxStyle.Information)
            Exit Sub
        End If
        Try
            openconn()
            cmd = New OleDbCommand("select * from bookinfo where BookAuthor='" & TextBox3.Text & "'", conn)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                TextBox3.Text = rdr.Item("BookAuthor")
            Else
                MessageBox.Show("Book not Found")
                TextBox3.Focus()
                Exit Sub
            End If
            cmd = New OleDbCommand("select * from bookinfo where BookAuthor='" & TextBox3.Text & "'", conn)
            da = New OleDbDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "bookinfo")
            DataGridView1.DataSource = ds.Tables("bookinfo")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        gridview()
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Mainpage.Show()
        Me.Hide()
    End Sub

    Private Sub Searchbook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SantoDataSet10.bookinfo' table. You can move, or remove it, as needed.
        Me.BookinfoTableAdapter.Fill(Me.SantoDataSet10.bookinfo)
        gridview()
    End Sub
End Class