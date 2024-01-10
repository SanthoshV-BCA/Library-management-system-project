Imports System.Data.OleDb
Imports System.Data
Public Class Staffinf
    Private Sub gridview()
        openconn()
        cmd = New OleDbCommand("select * from staffinfo", conn)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "staffinfo")
        DataGridView1.DataSource = ds.Tables("staffinfo")
        conn.Close()
    End Sub
    Private Sub UserControl1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gridview()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Then
            MessageBox.Show("Enter Department!")
            Exit Sub
        End If
        Try
            openconn()
            cmd = New OleDbCommand("select * from staffinfo where Department='" & TextBox2.Text & "'", conn)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                TextBox2.Text = rdr.Item("Department")
            Else
                MsgBox("Staff member not Found", MsgBoxStyle.Information)
                TextBox2.Focus()
                Exit Sub
            End If
            cmd = New OleDbCommand("select * from staffinfo where Department='" & TextBox2.Text & "'", conn)
            da = New OleDbDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "staffinfo")
            DataGridView1.DataSource = ds.Tables("staffinfo")
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
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Enter StaffID!")
            Exit Sub
        End If
        Try
            openconn()
            cmd = New OleDbCommand("select * from staffinfo where Staffid='" & TextBox1.Text & "'", conn)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                TextBox1.Text = rdr.Item("Staffid")
            Else
                MsgBox("Staff member not Found", MsgBoxStyle.Information)
                TextBox1.Focus()
                Exit Sub
            End If
            cmd = New OleDbCommand("select * from staffinfo where Staffid='" & TextBox1.Text & "'", conn)
            da = New OleDbDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "staffinfo")
            DataGridView1.DataSource = ds.Tables("staffinfo")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!")
        End Try
    End Sub
End Class