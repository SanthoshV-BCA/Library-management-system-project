Imports System.Data
Imports System.Data.OleDb
Public Class issuebook
    Dim i As Integer
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox7.Text = "" Then
            MsgBox("Enter Book AccessionNo")
            TextBox1.Focus()
            Exit Sub
        End If
        Try
            openconn()
            cmd = New OleDbCommand("select * from bookinfo where AccessionNo='" & TextBox7.Text & "'", conn)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                TextBox7.Text = rdr.Item("AccessionNo")
            Else
                MessageBox.Show("Book not Found")
                TextBox7.Focus()
                Exit Sub
            End If
            cmd = New OleDbCommand("select * from bookinfo where AccessionNo='" & TextBox7.Text & "'", conn)
            da = New OleDbDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "bookinfo")
            DataGridView1.DataSource = ds.Tables("bookinfo")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!")
        End Try
    End Sub
    Private Function isbookAlreadyIssue()
        openconn()
        cmd = New OleDbCommand("select AccessionNo from issuebook where AccessionNo=@AccessionNo", conn)
        cmd.Parameters.AddWithValue("@AccessionNo", TextBox1.Text)
        rdr = cmd.ExecuteReader()
        While rdr.Read
            TextBox1.Clear()
            TextBox1.Focus()
            conn.Close()
            Return False
        End While
        Return True
    End Function
    Private Sub clr()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        ComboBox1.Text = ""
        DateTimePicker1.Text = ""
        DateTimePicker2.Text = ""
    End Sub
    'showing data into grid
    Private Sub gridview()
        openconn()
        Dim sql As String = "select * from bookinfo"
        da = New OleDbDataAdapter(sql, conn)
        ds = New DataSet
        da.Fill(ds, "bookinfo")
        DataGridView1.DataSource = ds.Tables("bookinfo")
        conn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If isbookAlreadyIssue() = False Then
            MsgBox("Book Already Issued")
            Exit Sub
        End If
        Try
            openconn()
            cmd = New OleDbCommand("select*from bookinfo where AccessionNo='" & TextBox1.Text & "'", conn)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                TextBox1.Text = rdr.Item("AccessionNo")
                TextBox2.Text = rdr.Item("BookTitle")
                TextBox3.Text = rdr.Item("BookAuthor")
            Else
                MessageBox.Show("Record not Found")
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox1.Focus()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            openconn()
            cmd = New OleDbCommand("select*from stuinfo where Studentid='" & TextBox4.Text & "'", conn)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                TextBox4.Text = rdr.Item("Studentid")
                TextBox5.Text = rdr.Item("Studentname")
                TextBox6.Text = rdr.Item("Department")
            Else
                MessageBox.Show("Record not Found")
                TextBox4.Clear()
                TextBox5.Clear()
                TextBox6.Clear()
                TextBox4.Focus()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!")
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or ComboBox1.Text = "" Then
            MessageBox.Show("Please Fill All Details,Before Proceed")
            TextBox1.Focus()
            Exit Sub
        End If
        Try
            openconn()
            cmd = New OleDbCommand("insert into issuebook([AccessionNo],[BookTitle],[Author],[idRollno],[SName],[Department],[Type],[issueDate],[returnDate])" + "values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & ComboBox1.Text & "','" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "')", conn)
            cmd.ExecuteNonQuery()
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            MessageBox.Show("Book Issued Successfully", "Issue Book")
            clr()
            TextBox1.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Book Not Issued,Error!")
            conn.Close()
        End Try
    End Sub

    Private Sub issuebook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gridview()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            i = DataGridView1.CurrentRow.Index
            TextBox1.Text = DataGridView1.Item(0, i).Value
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clr()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Mainpage.Show()
        Me.Hide()
    End Sub
End Class