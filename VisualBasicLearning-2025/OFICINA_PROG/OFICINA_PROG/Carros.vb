Public Class Carros
    Private Sub CARROSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CARROSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CARROSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransportesDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            MsgBox("Gravação bem sucedida", vbOKOnly, "Carros!")
        Catch ex As Exception
            MsgBox("Erro! O Registo já existe!!", vbOKOnly, "Carros!")
        End Try
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles ButtonRemover.Click
        Try
            CARROSBindingSource.RemoveCurrent()
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IdMarcaTextBox.SelectedIndexChanged

    End Sub
End Class