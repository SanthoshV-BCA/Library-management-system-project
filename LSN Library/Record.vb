Public Class Record
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Staffinf.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Studentinf.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Searchbook.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Issuebookdet.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Returnbookdet.Show()

    End Sub
    Private Sub switchpanel(ByVal panel As UserControl)
        Panel2.Controls.Clear()
        panel.Top = False
        Panel2.Controls.Add(panel)
    End Sub
End Class