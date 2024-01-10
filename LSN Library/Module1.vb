Imports System.Data
Imports System.Data.OleDb
Module Module1
    Public conn As OleDbConnection
    Public cmd As OleDbCommand
    Public rdr As OleDbDataReader
    Public ds As DataSet
    Public da As OleDbDataAdapter
    Public Sub openconn()
        Try
            conn = New OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\+FAMILY PHOTO+\LSN Library\santo.accdb")
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Public Function validstring(ByVal str)
        Dim i As Integer
        Dim ch As Char
        i = 0
        While i < str.length()
            ch = str.chars(i)
            If IsNumeric(ch) = True Then
                Return False
            End If
            i += 1
        End While
        Return True
    End Function
End Module
