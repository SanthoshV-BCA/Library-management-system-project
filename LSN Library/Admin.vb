Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class Admin
    Dim i As Integer
    Private Sub gridview()
        openconn()
        cmd = New OleDbCommand("select * from login", conn)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "login")
        DataGridView1.DataSource = ds.Tables("login")
        conn.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter The USERID!", MsgBoxStyle.Information)
            TextBox1.Focus()
            Exit Sub
        ElseIf TextBox2.Text = "" Then
            MsgBox("Enter Name..", MsgBoxStyle.Information)
            Exit Sub
        ElseIf isIdExist() = False Then
            MsgBox("ID is already Exist! Plz enter another ID", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf ValidEmail() = False Then
            MsgBox("Email Address is Not Valid", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf Password() = False Then
            MsgBox("Password Should be atleast 8 digit/character long", MsgBoxStyle.Information)
            Exit Sub
        End If
        Try
            openconn()
            cmd = New OleDbCommand("insert into login([Userid],[Uname],[Email],[Password])" + "values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')", conn)
            cmd.ExecuteNonQuery()
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            MessageBox.Show("Record Inserted Successfully", "Insert Operation")
            clr()
            gridview()
            TextBox1.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Record not inserted")
            conn.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter USER ID", MsgBoxStyle.Critical)
            TextBox1.Focus()
            Exit Sub
        End If
        Try
            openconn()
            cmd = New OleDbCommand("select*from login where Userid='" & TextBox1.Text & "'", conn)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                TextBox1.Text = rdr.Item("Userid")
                TextBox2.Text = rdr.Item("Uname")
                TextBox3.Text = rdr.Item("Email")
                TextBox4.Text = rdr.Item("Password")
            Else
                MessageBox.Show("Record not Found")
                Exit Sub
            End If
            Dim reply As DialogResult
            reply = MessageBox.Show("Do you wish to delete record?", "Delete", MessageBoxButtons.YesNo)
            If reply = DialogResult.Yes Then
                cmd = New OleDbCommand("delete * from login where Userid='" & TextBox1.Text & "'", conn)
                cmd.ExecuteNonQuery()
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                MessageBox.Show("Record Deleted Successfully", "Update Operation")
                clr()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.Remove(row)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Please enter USERID ", MsgBoxStyle.Information)
            TextBox1.Focus()
            Exit Sub
        End If
        Try
            openconn()
            cmd = New OleDbCommand("update login set [Uname]='" & TextBox2.Text & "',[Email]='" & TextBox3.Text & "',[Password]='" & TextBox4.Text & "' where [Userid]='" & TextBox1.Text & "'", conn)
            cmd.ExecuteNonQuery()
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            MessageBox.Show("Record Updated Successfully", "Update Operation")
            clr()
            gridview()
            TextBox1.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function isIdExist()
        openconn()
        Dim query As String = "select Userid from login where Userid=@Userid"
        cmd = New OleDbCommand(query, conn)
        cmd.Parameters.AddWithValue("@Userid", TextBox1.Text)
        rdr = cmd.ExecuteReader()
        While rdr.Read
            TextBox1.Clear()
            TextBox1.Focus()
            conn.Close()
            Return False
        End While
        Return True
    End Function
    'to clear value in textbox after insertion
    Public Sub clr()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub
    'check validation for email
    Private Function ValidEmail()
        Dim p As String
        p = "^([0-9a-zA-Z]{4}([-\.\w]*[0-9a-zA-Z]*@[0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        If Regex.IsMatch(TextBox3.Text, p) = False Then
            TextBox3.Focus()
            Return False
        End If
        Return True
    End Function
    'check validation for Password
    Private Function Password()
        If TextBox4.TextLength < 8 = True Then
            TextBox4.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox5.Text = "" Then
            MessageBox.Show("Enter USERID!")
            TextBox5.Focus()
            Exit Sub
        End If
        Try
            openconn()
            cmd = New OleDbCommand("select * from login where Userid='" & TextBox5.Text & "' ", conn)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                TextBox1.Text = rdr.Item("Userid")
            Else
                MsgBox("USER not Found", MsgBoxStyle.Information)
                TextBox1.Focus()
                Exit Sub
            End If
            cmd = New OleDbCommand("select * from login where Userid='" & TextBox5.Text & "'", conn)
            da = New OleDbDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "login")
            DataGridView1.DataSource = ds.Tables("login")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!")
        End Try
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            i = DataGridView1.CurrentRow.Index
            TextBox1.Text = DataGridView1.Item(0, i).Value
            TextBox2.Text = DataGridView1.Item(1, i).Value
            TextBox3.Text = DataGridView1.Item(2, i).Value
            TextBox4.Text = DataGridView1.Item(3, i).Value
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Backup.ShowDialog()
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SantoDataSet14.login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.SantoDataSet14.login)

    End Sub
End Class
