Public Class Form1

    Public frm2 As FormCalculadora
    Public frm3 As FormIMC

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If IsNothing(frm2) = False Then
            MsgBox("O formulário já esta aberto !", MsgBoxStyle.Exclamation)
        Else
            frm2 = New FormCalculadora
            frm2.Show()

            Me.Hide()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNothing(frm3) = False Then
            MsgBox("O formulário já esta aberto !", MsgBoxStyle.Exclamation)
        Else
            frm3 = New FormIMC
            frm3.Show()

            Me.Hide()
        End If
    End Sub
End Class
