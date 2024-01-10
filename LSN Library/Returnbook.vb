Imports System.Data.OleDb
Public Class Returnbook
    Dim i As Integer
    Private Sub gridview()
        openconn()
        cmd = New OleDbCommand("select * from issuebook", conn)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "issuebook")
        DataGridView1.DataSource = ds.Tables("issuebook")
        conn.Close()
    End Sub
    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter AccessionNo.", MsgBoxStyle.Information)
            Exit Sub
        End If
        Try
            openconn()
            cmd = New OleDbCommand("select*from issuebook where AccessionNo='" & TextBox1.Text & "'", conn)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                TextBox1.Text = rdr.Item("AccessionNo")
                TextBox2.Text = rdr.Item("BookTitle")
                TextBox4.Text = rdr.Item("idRollno")
                issuedate.Text = rdr.Item("issueDate")
                DateTimePicker1.Text = rdr.Item("returnDate")
                ComboBox1.Text = rdr.Item("Type")
                fine()
            Else
                MessageBox.Show("Record not Found")
                Exit Sub
            End If
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub fine()
        Dim diffdate As String
        diffdate = DateDiff(DateInterval.Day, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
        TextBox8.Text = diffdate
        diffdate *= 10
        TextBox9.Text = diffdate
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter the detail,before procced", MsgBoxStyle.Information)
        End If
        Try
            openconn()
            cmd = New OleDbCommand("select*from issuebook where AccessionNo='" & TextBox1.Text & "'", conn)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                TextBox1.Text = rdr.Item("AccessionNo")
            Else
                MessageBox.Show("Record not Found")
                Exit Sub
            End If
            cmd = New OleDbCommand("delete * from issuebook where AccessionNo='" & TextBox1.Text & "'", conn)
            cmd.ExecuteNonQuery()
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!")
            conn.Close()
        End Try
        Try
            openconn()
            cmd = New OleDbCommand("insert into returnbook([AccessionNo],[BookTitle],[idRollno],[Type],[issueDate],[returnDate],[todayDate],[delay],[fine])" + "values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox4.Text & "','" & ComboBox1.Text & "','" & issuedate.Text & "','" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "')", conn)
            cmd.ExecuteNonQuery()
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            MessageBox.Show("Book Returned Successfully", "Return Book")
            clr()
            gridview()
            TextBox1.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub clr()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox4.Clear()
        ComboBox1.Text = ""
        issuedate.Clear()
        DateTimePicker1.Text = ""
        DateTimePicker2.Text = ""
        TextBox8.Clear()
        TextBox9.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clr()
        gridview()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Mainpage.Show()
        Me.Hide()
    End Sub

    Private Sub Returnbook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SantoDataSet11.issuebook' table. You can move, or remove it, as needed.
        Me.IssuebookTableAdapter.Fill(Me.SantoDataSet11.issuebook)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox3.Text = "" Then
            MsgBox("Enter Book AccessionNo")
            TextBox3.Focus()
            Exit Sub
        End If
        Try
            openconn()
            cmd = New OleDbCommand("select * from issuebook where AccessionNo='" & TextBox3.Text & "'", conn)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                TextBox3.Text = rdr.Item("AccessionNo")
            Else
                MessageBox.Show("Book not Found")
                TextBox3.Focus()
                Exit Sub
            End If
            cmd = New OleDbCommand("select * from issuebook where AccessionNo='" & TextBox3.Text & "'", conn)
            da = New OleDbDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "issuebook")
            DataGridView1.DataSource = ds.Tables("issuebook")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!")
        End Try
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            i = DataGridView1.CurrentRow.Index
            TextBox1.Text = DataGridView1.Item(0, i).Value
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub
End Class