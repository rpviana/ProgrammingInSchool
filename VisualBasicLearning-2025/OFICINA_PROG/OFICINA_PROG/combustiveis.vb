Public Class combustiveis
    Private Sub combustiveis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'TransportesDataSet.COMBUSTIVEIS'. Você pode movê-la ou removê-la conforme necessário.
        Me.COMBUSTIVEISTableAdapter.Fill(Me.TransportesDataSet.COMBUSTIVEIS)

    End Sub

    Private Sub COMBUSTIVEISBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles COMBUSTIVEISBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.COMBUSTIVEISBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransportesDataSet)

    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles ButtonAnterior.Click
        COMBUSTIVEISBindingSource.MovePrevious()
    End Sub

    Private Sub btnSeguinte_Click(sender As Object, e As EventArgs) Handles ButtonSeguinte.Click
        COMBUSTIVEISBindingSource.MoveNext()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles ButtonNovo.Click
        COMBUSTIVEISBindingSource.AddNew()
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles ButtonGravar.Click
        Try
            COMBUSTIVEISBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(TransportesDataSet)
            MsgBox("Gravação bem sucedida", vbOKOnly, "Carros!")
        Catch ex As Exception
            MsgBox("Erro! O Registo já existe!!", vbOKOnly, "Carros!")
        End Try
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles ButtonRemover.Click
        Try
            COMBUSTIVEISBindingSource.RemoveCurrent()
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