Imports System.Data
Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class Managestudent
    Private Sub Managestudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If checkId() = False Then
            MsgBox("Id/RollNo Is Incorrect!", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf isIdExist() = False Then
            MsgBox("ID is already Exist! Plz enter another ID", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf checkname() = False Then
            MsgBox("StudentName: Character value Required!", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf checkbatch() = False Then
            MsgBox("Student Batch: Integer value Required!", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf checkdepart() = False Then
            MsgBox("Department: Character value Required!", MsgBoxStyle.Critical)
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
            cmd = New OleDbCommand("insert into stuinfo([Studentid],[Studentname],[Studentbatch],[Department],[Contact],[Email])" + "values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')", conn)
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

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
        Dim query As String = "select Studentid from stuinfo where Studentid=@Studentid"
        cmd = New OleDbCommand(query, conn)
        cmd.Parameters.AddWithValue("@Studentid", TextBox1.Text)
        rdr = cmd.ExecuteReader()
        While rdr.Read
            TextBox1.Clear()
            TextBox1.Focus()
            conn.Close()
            Return False
        End While
        Return True
    End Function
    'checkbatch function is numeric or not
    Private Function checkbatch()
        Try
            If IsNumeric(TextBox3.Text) = False Then
                TextBox3.Focus()
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Error!")
        End Try
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
        TextBox3.Clear()
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
            MsgBox("ID/RollNo is Incorrect", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf checkname() = False Then
            MsgBox("StudentName: Character value Required!", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf checkbatch() = False Then
            MsgBox("Student Batch: Integer value Required!", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf checkdepart() = False Then
            MsgBox("Department: Character value Required!", MsgBoxStyle.Critical)
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
            cmd = New OleDbCommand("update stuinfo set [Studentname]='" & TextBox2.Text & "',[Studentbatch]='" & TextBox3.Text & "',[Department]='" & TextBox4.Text & "',[Contact]='" & TextBox5.Text & "',[Email]='" & TextBox6.Text & "' where [Studentid]='" & TextBox1.Text & "'", conn)
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
            cmd = New OleDbCommand("select*from stuinfo where Studentid='" & TextBox1.Text & "'", conn)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                TextBox1.Text = rdr.Item("Studentid")
                TextBox2.Text = rdr.Item("Studentname")
                TextBox3.Text = rdr.Item("Studentbatch")
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
                cmd = New OleDbCommand("delete * from stuinfo where Studentid='" & TextBox1.Text & "'", conn)
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
        Dim id As String = InputBox("Enter Student ID")
        Try
            openconn()
            cmd = New OleDbCommand("select*from stuinfo where Studentid='" & id & "'", conn)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                TextBox1.Text = rdr.Item("Studentid")
                TextBox2.Text = rdr.Item("Studentname")
                TextBox3.Text = rdr.Item("Studentbatch")
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
End Class