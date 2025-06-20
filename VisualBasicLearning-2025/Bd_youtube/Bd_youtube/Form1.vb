Public Class Form1
    Private Sub TiposDeEquipamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeEquipamentosToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub EquipamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EquipamentosToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class
