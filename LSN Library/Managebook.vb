Imports System.Data
Imports System.Data.OleDb
Public Class Managebook
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If AccId() = False Then
            MsgBox("AccessionNo is not correct!", MsgBoxStyle.Information)
            Exit Sub
        ElseIf booktitle() = False Then
            MsgBox("BookTitle: Character value Required!", MsgBoxStyle.Information)
            Exit Sub
        ElseIf bookauthor() = False Then
            MsgBox("BookAuthor: Character value Required!", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf TextBox4.Text = "" Then
            MsgBox("Enter Edition Of Book")
            Exit Sub
        ElseIf publisher() = False Then
            MsgBox("Publisher: Character value Required!", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf vender() = False Then
            MsgBox("Vendor: Character value Required!", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf price() = False Then
            MsgBox("Price: Integer value Required!", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf medium() = False Then
            MsgBox("Medium: Character value Required!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Try
            openconn()
            cmd = New OleDbCommand("update bookinfo set [BookTitle]='" & TextBox2.Text & "',[BookAuthor]='" & TextBox3.Text & "',[Edition]='" & TextBox4.Text & "',[BDate]='" & DateTimePicker1.Text & "',[Publisher]='" & TextBox5.Text & "',[Vendor]='" & TextBox6.Text & "',[Price]='" & TextBox7.Text & "' where [AccessionNo]='" & TextBox1.Text & "'", conn)
            cmd.ExecuteNonQuery()
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            MessageBox.Show("Record Updated Successfully", "Update Operation")
            clr()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If AccId() = False Then
            MsgBox("AccessionNo is not correct!", MsgBoxStyle.Information)
            Exit Sub
        ElseIf isIdExist() = False Then
            MsgBox("Book is already Exist!", MsgBoxStyle.Information)
            Exit Sub
        ElseIf booktitle() = False Then
            MsgBox("BookTitle: Character value Required!", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf bookauthor() = False Then
            MsgBox("BookAuthor: Character value Required!", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf TextBox4.Text = "" Then
            MsgBox("Enter Edition Of Book")
            TextBox4.Focus()
            Exit Sub
        ElseIf publisher() = False Then
            MsgBox("Publisher: Character value Required!", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf vender() = False Then
            MsgBox("Vendor: Character value Required!", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf price() = False Then
            MsgBox("Price: Integer value Required!", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf medium() = False Then
            MsgBox("Medium: Character value Required!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Try
            openconn()
            cmd = New OleDbCommand("insert into bookinfo([AccessionNo],[BookTitle],[BookAuthor],[Edition],[BDate],[Publisher],[Vendor],[Price])" + "values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & DateTimePicker1.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "')", conn)
            cmd.ExecuteNonQuery()
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            MessageBox.Show("Record Inserted Successfully", "Insert Operation")
            clr()
            TextBox1.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Record not inserted")
            conn.Close()
        End Try
    End Sub
    Public Sub clr()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox5.Clear()
    End Sub

    'AccId function it is numeric or not
    Private Function AccId()
        Try
            If IsNumeric(TextBox1.Text) = False Then
                TextBox1.Focus()
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Error!")
        End Try
        Return True
    End Function
    'to check whether id already exist or not
    Private Function isIdExist()
        openconn()
        Dim query As String = "select AccessionNo from bookinfo where AccessionNo=@AccessionNo"
        cmd = New OleDbCommand(query, conn)
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

    'check booktitle function is string or not
    Private Function booktitle()
        Try
            If TextBox2.Text = "" Or validstring(TextBox2.Text) = False Then
                TextBox2.Focus()
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Error!")
        End Try
        Return True
    End Function
    'check bookauthor function is string or not
    Private Function bookauthor()
        Try
            If TextBox3.Text = "" Or validstring(TextBox3.Text) = False Then
                TextBox3.Focus()
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Error!")
        End Try
        Return True
    End Function
    'check publisher function is string or not
    Private Function publisher()
        Try
            If TextBox5.Text = "" Or validstring(TextBox5.Text) = False Then
                TextBox5.Focus()
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Error!")
        End Try
        Return True
    End Function
    'check vender function is string or not
    Private Function vender()
        Try
            If TextBox6.Text = "" Or validstring(TextBox6.Text) = False Then
                TextBox6.Focus()
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Error!")
        End Try
        Return True
    End Function
    'price function it is numeric or not
    Private Function price()
        Try
            If IsNumeric(TextBox7.Text) = False Then
                TextBox7.Focus()
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Error!")
        End Try
        Return True
    End Function
    'check medium function is string or not
    Private Function medium()
        Try
            If TextBox5.Text = "" Or validstring(TextBox5.Text) = False Then
                TextBox5.Focus()
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Error!")
        End Try
        Return True
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter Accession No", MsgBoxStyle.Critical)
            TextBox1.Focus()
            Exit Sub
        End If
        Try
            openconn()
            Dim id As String = CInt(TextBox1.Text)
            cmd = New OleDbCommand("select*from bookinfo where AccessionNo='" & TextBox1.Text & "'", conn)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                TextBox1.Text = rdr.Item("AccessionNo")
                TextBox2.Text = rdr.Item("BookTitle")
                TextBox3.Text = rdr.Item("BookAuthor")
                TextBox4.Text = rdr.Item("Edition")
                DateTimePicker1.Text = rdr.Item("BDate")
                TextBox5.Text = rdr.Item("Publisher")
                TextBox6.Text = rdr.Item("Vendor")
                TextBox7.Text = rdr.Item("Price")

            Else
                MessageBox.Show("Record not Found")
                Exit Sub
            End If
            Dim reply As DialogResult
            reply = MessageBox.Show("Do you wish to delete record?", "Delete", MessageBoxButtons.YesNo)
            If reply = DialogResult.Yes Then
                cmd = New OleDbCommand("delete * from bookinfo where AccessionNo='" & TextBox1.Text & "'", conn)
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
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim id As String = InputBox("Enter Accession NO.")
        Try
            openconn()
            cmd = New OleDbCommand("select * from bookinfo where AccessionNo='" & id & "'", conn)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                TextBox1.Text = rdr.Item("AccessionNo")
                TextBox2.Text = rdr.Item("BookTitle")
                TextBox3.Text = rdr.Item("BookAuthor")
                TextBox4.Text = rdr.Item("Edition")
                DateTimePicker1.Text = rdr.Item("BDate")
                TextBox5.Text = rdr.Item("Publisher")
                TextBox6.Text = rdr.Item("Vendor")
                TextBox7.Text = rdr.Item("Price")

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
End Class