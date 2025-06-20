Public Class Form1

    Public frm2 As FormCalculadora
    Public frm3 As FormIMC

    Private Sub botCalc_Click(sender As Object, e As EventArgs) Handles botCalc.Click
        If IsNothing(frm2) = False Then
            MsgBox("O formulário já esta aberto !", MsgBoxStyle.Exclamation)
        Else
            frm2 = New FormCalculadora
            frm2.Show()

            Me.Hide()
        End If
    End Sub

    Private Sub botIMC_Click(sender As Object, e As EventArgs) Handles botIMC.Click
        If IsNothing(frm3) = False Then
            MsgBox("O formulário já esta aberto !", MsgBoxStyle.Exclamation)
        Else
            frm3 = New FormIMC
            frm3.Show()

            Me.Hide()
        End If
    End Sub
End Class