Imports System.Data
Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class Managestaff
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If checkId() = False Then
            MsgBox("ID is Incorrect", MsgBoxStyle.Information)
            Exit Sub
        ElseIf isIdExist() = False Then
            MsgBox("ID is already Exist! Plz enter another ID", MsgBoxStyle.Information)
            Exit Sub
        ElseIf checkname() = False Then
            MsgBox("StaffName: Character value Required!", MsgBoxStyle.Information)
            Exit Sub
        ElseIf checkdepart() = False Then
            MsgBox("Department: Character value Required!", MsgBoxStyle.Information)
            Exit Sub
        ElseIf Valibnumber() = False Then
            MsgBox("Phone Number is not Valid!", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf ValidEmail() = False Then
            MsgBox("Email Address is Not Valid", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Try
            openconn()
            cmd = New OleDbCommand("insert into staffinfo([Staffid],[Staffname],[Department],[Contact],[Email])" + "values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')", conn)
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
    Private Function checkId()
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
        Dim query As String = "select Staffid from staffinfo where Staffid=@Staffid"
        cmd = New OleDbCommand(query, conn)
        cmd.Parameters.AddWithValue("@Staffid", TextBox1.Text)
        rdr = cmd.ExecuteReader()
        While rdr.Read
            TextBox1.Clear()
            TextBox1.Focus()
            conn.Close()
            Return False
        End While
        Return True
    End Function
    'check name function is string or not
    Private Function checkname()
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
    'check department function is string or not
    Private Function checkdepart()
        Try
            If TextBox4.Text = "" Or validstring(TextBox4.Text) = False Then
                TextBox4.Focus()
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Error!")
        End Try
        Return True
    End Function
    'to clear value in textbox after insertion
    Public Sub clr()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
    End Sub
    'check validation for email
    Private Function ValidEmail()
        Dim p As String
        p = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z]*@[0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        If Regex.IsMatch(TextBox6.Text, p) = False Then
            TextBox6.Focus()
            Return False
        End If
        Return True
    End Function
    'check vallidation for number
    Private Function Valibnumber()
        Dim p As String
        p = "^([7-9]{1})([0-9]{9})$"
        If Regex.IsMatch(TextBox5.Text, p) = False Then
            TextBox5.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If checkId() = False Then
            MsgBox("ID is Incorrect!", MsgBoxStyle.Information)
            Exit Sub
        ElseIf checkname() = False Then
            MsgBox("StaffName: Character value Required!", MsgBoxStyle.Information)
            Exit Sub
        ElseIf checkdepart() = False Then
            MsgBox("Department: Character value Required!", MsgBoxStyle.Information)
            Exit Sub
        ElseIf Valibnumber() = False Then
            MsgBox("Phone Number is not Valid!", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf ValidEmail() = False Then
            MsgBox("Email Address is Not Valid", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Try
            openconn()
            cmd = New OleDbCommand("update staffinfo set [Staffname]='" & TextBox2.Text & "',[Department]='" & TextBox4.Text & "',[Contact]='" & TextBox5.Text & "',[Email]='" & TextBox6.Text & "' where [Staffid]='" & TextBox1.Text & "'", conn)
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter Student ID", MsgBoxStyle.Critical)
            TextBox1.Focus()
            Exit Sub
        End If
        Try
            openconn()
            cmd = New OleDbCommand("select*from staffinfo where Staffid='" & TextBox1.Text & "'", conn)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                TextBox1.Text = rdr.Item("Staffid")
                TextBox2.Text = rdr.Item("Staffname")
                TextBox4.Text = rdr.Item("Department")
                TextBox5.Text = rdr.Item("Contact")
                TextBox6.Text = rdr.Item("Email")

            Else
                MessageBox.Show("Record not Found")
                Exit Sub
            End If
            Dim reply As DialogResult
            reply = MessageBox.Show("Do you wish to delete record?", "Delete", MessageBoxButtons.YesNo)
            If reply = DialogResult.Yes Then
                cmd = New OleDbCommand("delete * from staffinfo where Staffid='" & TextBox1.Text & "'", conn)
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
        Dim id As String = InputBox("Enter Staff ID")
        Try
            openconn()
            cmd = New OleDbCommand("select*from staffinfo where Staffid='" & id & "'", conn)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                TextBox1.Text = rdr.Item("Staffid")
                TextBox2.Text = rdr.Item("Staffname")
                TextBox4.Text = rdr.Item("Department")
                TextBox5.Text = rdr.Item("Contact")
                TextBox6.Text = rdr.Item("Email")

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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        clr()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Mainpage.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class