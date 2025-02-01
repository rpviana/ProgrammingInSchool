Public Class Form2
    Private Sub TiposBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TiposBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TiposBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_YoutubeDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TiposTableAdapter.Fill(Me.BD_YoutubeDataSet.Tipos)
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles ButtonAnterior.Click
        TiposBindingSource.MovePrevious() 'mover anterior'
    End Sub

    Private Sub btnSeguinte_Click(sender As Object, e As EventArgs) Handles ButtonSeguinte.Click
        TiposBindingSource.MoveNext() 'mover posterior'
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles ButtonNovo.Click
        Me.TiposBindingSource.AddNew() 'novo registo'
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles ButtonGravar.Click
        'Try
        ' Me.TiposBindingSource.EndEdit()
        ' Me.TableAdapterManager.UpdateAll(Me.BD_YoutubeDataSet)
        ' MsgBox("Gravação de dados feita!!", vbOKOnly, "Equipamentos!!")
        'Catch ex As Exception
        'MsgBox("Erro! O Registo já existe!!", vbOKOnly, "Equipamentos!")
        'End Try


        Try
            Dim dataTable As DataTable = CType(TiposBindingSource.DataSource, DataTable)
            If dataTable.GetChanges() IsNot Nothing Then
                Me.TiposBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BD_YoutubeDataSet)
                MsgBox("Gravação de dados feita!!", vbOKOnly, "Equipamentos!!")
            Else
                MsgBox("Nenhuma alteração foi feita.", vbOKOnly, "Equipamentos!")
            End If
        Catch ex As Exception
            MsgBox("Erro! O Registo já existe ou ocorreu outro erro!", vbOKOnly, "Equipamentos!")
        End Try
    End Sub


    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles ButtonRemover.Click
        Try
            TiposBindingSource.RemoveCurrent()
            TableAdapterManager.UpdateAll(BD_YoutubeDataSet)
            MsgBox("O Registo foi apagado!", vbOKOnly, "Equipamentos!")
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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TiposBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles TiposBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TiposBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_YoutubeDataSet)

    End Sub
End Class