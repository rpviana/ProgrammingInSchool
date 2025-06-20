Public Class Form3
    Private Sub MARCASBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CARROSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CARROSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransportesDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'BD_CarrosDataSet.MARCAS'. Você pode movê-la ou removê-la conforme necessário.
        Me.CARROSTableAdapter.Fill(Me.TransportesDataSet.CARROS)

    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles ButtonAnterior.Click
        CARROSBindingSource.MovePrevious()
    End Sub

    Private Sub btnSeguinte_Click(sender As Object, e As EventArgs) Handles ButtonSeguinte.Click
        CARROSBindingSource.MoveNext()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles ButtonNovo.Click
        CARROSBindingSource.AddNew()
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles ButtonGravar.Click
        Try
            CARROSBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(TransportesDataSet)
            MsgBox("Gravação de dados bem sucedida", vbOKOnly, "Software Carros!")
        Catch ex As Exception
            MsgBox("Erro! Registo já existe!!", vbOKOnly, "Software Carros!")
        End Try
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles ButtonRemover.Click
        Try
            CARROSBindingSource.RemoveCurrent()
            TableAdapterManager.UpdateAll(TransportesDataSet)
            MsgBox("Registo foi apagado com successo", vbOKOnly, "Software Carros!")
        Catch ex As Exception
            MsgBox("Erro!!", vbOKOnly, "Software Carros!")
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