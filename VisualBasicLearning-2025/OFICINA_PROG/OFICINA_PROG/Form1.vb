Public Class Form1
    Private Sub TiposDeMarcasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeMarcasToolStripMenuItem.Click
        Me.Hide()
        Marcas.Show()
    End Sub

    Private Sub CarrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarrosToolStripMenuItem.Click
        Me.Hide()
        Carros.Show()
    End Sub

    Private Sub CombustiveisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CombustiveisToolStripMenuItem.Click
        Me.Hide()
        combustiveis.Show()
    End Sub

    Private Sub RevisõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RevisõesToolStripMenuItem.Click
        Me.Hide()
        revisoes.Show()
    End Sub
End Class
