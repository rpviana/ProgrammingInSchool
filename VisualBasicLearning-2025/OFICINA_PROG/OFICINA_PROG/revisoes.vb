Public Class revisoes
    Private Sub REVISOESBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles REVISOESBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.REVISOESBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransportesDataSet)

    End Sub

    Private Sub revisoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'TransportesDataSet.CARROS'. Você pode movê-la ou removê-la conforme necessário.
        Me.CARROSTableAdapter.Fill(Me.TransportesDataSet.CARROS)
        'TODO: esta linha de código carrega dados na tabela 'TransportesDataSet.REVISOES'. Você pode movê-la ou removê-la conforme necessário.
        Me.REVISOESTableAdapter.Fill(Me.TransportesDataSet.REVISOES)

    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles ButtonAnterior.Click
        REVISOESBindingSource.MovePrevious()
    End Sub

    Private Sub btnSeguinte_Click(sender As Object, e As EventArgs) Handles ButtonSeguinte.Click
        REVISOESBindingSource.MoveNext()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles ButtonNovo.Click
        REVISOESBindingSource.AddNew()
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles ButtonGravar.Click
        Try
            REVISOESBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(TransportesDataSet)
            MsgBox("Gravação bem sucedida", vbOKOnly, "Carros!")
        Catch ex As Exception
            MsgBox("Erro! O Registo já existe!!", vbOKOnly, "Carros!")
        End Try
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles ButtonRemover.Click
        Try
            REVISOESBindingSource.RemoveCurrent()
            TableAdapterManager.UpdateAll(TransportesDataSet)
            MsgBox("O Registo foi apagado", vbOKOnly, "Carros!")
        Catch ex As Exception
            MsgBox("Erro!!", vbOKOnly, "Carros!")
        End Try
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles ButtonFechar.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles ButtonSair.Click
        Application.Exit()
    End Sub
End Class