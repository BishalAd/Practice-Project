Public Class Form1
    Private Sub उधयगपरफईलToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles उधयगपरफईलToolStripMenuItem1.Click
        Form2.MdiParent = Me
        Form2.Show()
    End Sub

    Private Sub नवकरणToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles नवकरणToolStripMenuItem3.Click
        Form3.MdiParent = Me
        Form3.Show()
    End Sub

    Private Sub सशधनToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles सशधनToolStripMenuItem3.Click
        Form4.MdiParent = Me
        Form4.Show()
    End Sub
End Class
