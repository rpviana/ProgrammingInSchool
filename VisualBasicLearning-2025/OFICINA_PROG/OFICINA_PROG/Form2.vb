
Public Class Form2
    Private Sub MARCASBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MARCASBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MARCASBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransportesDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'TransportesDataSet.MARCAS'. Você pode movê-la ou removê-la conforme necessário.
        Me.MARCASTableAdapter.Fill(Me.TransportesDataSet.MARCAS)
        'TODO: esta linha de código carrega dados na tabela 'BD_CarrosDataSet.MARCAS'. Você pode movê-la ou removê-la conforme necessário.
        Me.MARCASTableAdapter.Fill(Me.TransportesDataSet.MARCAS)

    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles ButtonAnterior.Click
        MARCASBindingSource.MovePrevious()
    End Sub

    Private Sub btnSeguinte_Click(sender As Object, e As EventArgs) Handles ButtonSeguinte.Click
        MARCASBindingSource.MoveNext()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles ButtonNovo.Click
        Me.MARCASBindingSource.AddNew()
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles ButtonGravar.Click
        Try
            Me.MARCASBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(TransportesDataSet)
            MsgBox("Gravação de dados bem sucedida", vbOKOnly, "Software Carros!")
        Catch ex As Exception
            MsgBox("Erro! Registo já existe!!", vbOKOnly, "Software Carros!")
        End Try
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles ButtonRemover.Click
        Try
            MARCASBindingSource.RemoveCurrent()
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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub MARCASBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles MARCASBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MARCASBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransportesDataSet)

    End Sub
End Class