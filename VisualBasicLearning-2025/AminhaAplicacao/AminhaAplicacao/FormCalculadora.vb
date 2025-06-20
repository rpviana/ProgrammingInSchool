Public Class FormCalculadora
    Private Sub BotVoltar_Click(sender As Object, e As EventArgs) Handles BotVoltar.Click
        Form1.frm2 = Nothing
        Form1.Show()
        Me.Close()
    End Sub
    Private Sub botLimpar_Click(sender As Object, e As EventArgs) Handles botLimpar.Click
        TextBoxResultado.Text = "0"
    End Sub
    Private Sub botDividir_Click(sender As Object, e As EventArgs) Handles botDividir.Click
        TextBoxResultado1.Text = TextBoxResultado1.Text & TextBoxResultado.Text & "/"
        TextBoxResultado.Text = ""
    End Sub

    Private Sub botVezes_Click(sender As Object, e As EventArgs) Handles botVezes.Click
        TextBoxResultado.Text += "*"
    End Sub

    Private Sub botMenos_Click(sender As Object, e As EventArgs) Handles botMenos.Click
        TextBoxResultado.Text += "-"
    End Sub

    Private Sub botMais_Click(sender As Object, e As EventArgs) Handles botMais.Click
        TextBoxResultado.Text += "+"
    End Sub

    Private Sub botUm_Click(sender As Object, e As EventArgs) Handles botUm.Click
        insereNum("1")
    End Sub

    Public Sub insereNum(numero As String)
        If (TextBoxResultado.Text = "0") Then
            TextBoxResultado.Text = numero
        Else
            TextBoxResultado.Text = TextBoxResultado.Text & numero
        End If
    End Sub

    Private Sub botDois_Click(sender As Object, e As EventArgs) Handles botDois.Click
        insereNum("2")
    End Sub

    Private Sub botTres_Click(sender As Object, e As EventArgs) Handles botTres.Click
        insereNum("3")
    End Sub

    Private Sub botQuatro_Click(sender As Object, e As EventArgs) Handles botQuatro.Click
        insereNum("4")
    End Sub

    Private Sub botCinco_Click(sender As Object, e As EventArgs) Handles botCinco.Click
        insereNum("5")
    End Sub

    Private Sub botSeis_Click(sender As Object, e As EventArgs) Handles botSeis.Click
        insereNum("6")
    End Sub

    Private Sub botSete_Click(sender As Object, e As EventArgs) Handles botSete.Click
        insereNum("7")
    End Sub

    Private Sub botOito_Click(sender As Object, e As EventArgs) Handles botOito.Click
        insereNum("8")
    End Sub

    Private Sub botNove_Click(sender As Object, e As EventArgs) Handles botNove.Click
        insereNum("9")
    End Sub

    Private Sub TextBoxResultado1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxResultado1.TextChanged
        Text
    End Sub
End Class