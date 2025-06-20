Public Class Form3
    Private Sub EquipamentosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EquipamentosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EquipamentosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_YoutubeDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EquipamentosTableAdapter.Fill(Me.BD_YoutubeDataSet.Equipamentos)
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles ButtonAnterior.Click
        EquipamentosBindingSource.MovePrevious()
    End Sub

    Private Sub btnSeguinte_Click(sender As Object, e As EventArgs) Handles ButtonSeguinte.Click
        EquipamentosBindingSource.MoveNext()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles ButtonNovo.Click
        Me.EquipamentosBindingSource.AddNew()
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles ButtonGravar.Click
        Try
            Me.EquipamentosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(BD_YoutubeDataSet)
            MsgBox("Gravação bem sucedida", vbOKOnly, "Equipamentos!")
        Catch ex As Exception
            MsgBox("Erro! O Registo já existe!!", vbOKOnly, "Equipamentos!")
        End Try
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles ButtonRemover.Click
        Try
            EquipamentosBindingSource.RemoveCurrent()
            TableAdapterManager.UpdateAll(BD_YoutubeDataSet)
            MsgBox("O Registo foi apagado!!", vbOKOnly, "Equipamentos!")
        Catch ex As Exception
            MsgBox("Erro!!", vbOKOnly, "Equipamentos!")
        End Try
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles ButtonFechar.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles ButtonSair.Click
        Application.Exit()
    End Sub


    Private Sub EquipamentosBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles EquipamentosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EquipamentosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_YoutubeDataSet)

    End Sub
End Class