Public Class Mainpage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Managestudent.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Managestaff.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Managebook.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Searchbook.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        issuebook.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Returnbook.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Renewbook.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Record.ShowDialog()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub Mainpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub StudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentToolStripMenuItem.Click
        Managestudent.ShowDialog()

    End Sub

    Private Sub StaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffToolStripMenuItem.Click
        Managestaff.ShowDialog()
    End Sub

    Private Sub BookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookToolStripMenuItem.Click
        Managebook.ShowDialog()
    End Sub

    Private Sub IssueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IssueToolStripMenuItem.Click
        issuebook.ShowDialog()
    End Sub

    Private Sub ReturnBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnBookToolStripMenuItem.Click
        Returnbook.ShowDialog()
    End Sub

    Private Sub RecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecordToolStripMenuItem.Click
        Record.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        Login.Show()
    End Sub
End Class