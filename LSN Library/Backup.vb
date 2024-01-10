Imports System.Data.OleDb
Imports System.IO
Public Class Backup
    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim backup As New FolderBrowserDialog
            If backup.ShowDialog() = vbOK Then
                File.Copy("G:\+FAMILY PHOTO+\LSN Library\santo.accdb", backup.SelectedPath & "\santo.accdb")
                MessageBox.Show("Backup Created Successfully")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim backup As New FolderBrowserDialog
            If backup.ShowDialog() = vbOK Then
                File.Copy(backup.SelectedPath & "\santo.accdb", "G:\+FAMILY PHOTO+\LSN Library\santo.accdb")
                MessageBox.Show("Backup Restored Successfully")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!")
        End Try
    End Sub
End Class