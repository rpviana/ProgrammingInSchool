Public Class FormCalculadora

    Dim op As String = "" ' Operador atual
    Dim num1 As Double = 0 ' Primeiro número ou resultado acumulado
    Dim num2 As Double = 0 ' Segundo número
    Dim resultado As Double = 0 ' Resultado das operações
    Dim novaOperacao As Boolean = False ' Indica se é uma nova operação

    ' Atualiza a TextBoxResultado1 e define o operador
    Public Sub Adicionar_Numero_Operacao()
        If TextBoxResultado.Text <> "" Then
            If novaOperacao Then
                ' Usa o resultado anterior como base para a próxima operação
                TextBoxResultado1.Text = resultado & " " & op
            Else
                num1 = (TextBoxResultado.Text) ' Primeiro número
                TextBoxResultado1.Text = num1 & " " & op
            End If
            TextBoxResultado.Text = "" ' Reseta a entrada para o próximo número
            novaOperacao = False ' Reseta o estado de nova operação
        End If
    End Sub

    ' Botão para limpar tudo
    Private Sub botLimpar_Click(sender As Object, e As EventArgs) Handles botLimpar.Click

    End Sub

    ' Botões de operadores
    Private Sub botDividir_Click(sender As Object, e As EventArgs) Handles botDividir.Click
        Processar_Operacao("/")
    End Sub

    Private Sub botVezes_Click(sender As Object, e As EventArgs) Handles botVezes.Click
        Processar_Operacao("*")
    End Sub

    Private Sub botMenos_Click(sender As Object, e As EventArgs) Handles botMenos.Click
        Processar_Operacao("-")
    End Sub

    Private Sub botMais_Click(sender As Object, e As EventArgs) Handles botMais.Click
        Processar_Operacao("+")
    End Sub

    ' Método para processar operações
    Private Sub Processar_Operacao(operador As String)
        If novaOperacao Then
            ' Se é uma nova operação, define o operador e exibe na TextBoxResultado1
            op = operador
            TextBoxResultado1.Text = resultado & " " & op
        Else
            If TextBoxResultado.Text <> "" Then
                num1 = Double.Parse(TextBoxResultado.Text)
                op = operador
                Adicionar_Numero_Operacao()
            End If
        End If
    End Sub

    ' Botão igual
    Private Sub botIgual_Click(sender As Object, e As EventArgs) Handles botIgual.Click
        If TextBoxResultado.Text <> "" Then
            num2 = Double.Parse(TextBoxResultado.Text)
            Select Case op
                Case "+"
                    resultado = num1 + num2
                Case "-"
                    resultado = num1 - num2
                Case "*"
                    resultado = num1 * num2
                Case "/"
                    If num2 <> 0 Then
                        resultado = num1 / num2
                    Else
                        MessageBox.Show("Erro: Divisão por zero!")
                        Exit Sub
                    End If
                Case Else
                    MessageBox.Show("Selecione uma operação válida!")
                    Exit Sub
            End Select

            ' Atualiza a interface
            TextBoxResultado1.Text = num1 & " " & op & " " & num2 & " = " & resultado ' Mostra a conta completa
            TextBoxResultado.Text = resultado ' Mostra o resultado
            num1 = resultado ' Atualiza o num1 com o resultado para a próxima operação
            novaOperacao = True ' Indica que a próxima operação usa o resultado anterior
        End If
    End Sub

    ' Botões numéricos
    Public Sub insereNum(numero As String)
        If novaOperacao Then
            TextBoxResultado.Text = numero
            novaOperacao = False
        ElseIf TextBoxResultado.Text = "0" Then
            TextBoxResultado.Text = numero
        Else
            TextBoxResultado.Text &= numero
        End If
    End Sub

    Private Sub botZero_Click(sender As Object, e As EventArgs) Handles botZero.Click
        insereNum("0")
    End Sub

    Private Sub botUm_Click(sender As Object, e As EventArgs) Handles botUm.Click
        insereNum("1")
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

    ' Botão para inverter sinal
    Private Sub botInverte_Click(sender As Object, e As EventArgs) Handles botInverte.Click
        If TextBoxResultado.Text <> "" AndAlso TextBoxResultado.Text <> "0" Then
            TextBoxResultado.Text = (-Double.Parse(TextBoxResultado.Text)).ToString()
        End If
    End Sub

    ' Botão de apagar (backspace)
    Private Sub botApagar_Click(sender As Object, e As EventArgs) Handles botApagar.Click
        If TextBoxResultado.Text.Length > 0 Then
            TextBoxResultado.Text = TextBoxResultado.Text.Substring(0, TextBoxResultado.Text.Length - 1)
            If TextBoxResultado.Text = "" Then
                TextBoxResultado.Text = "0"
            End If
        End If
    End Sub

    ' Botão de vírgula (decimal)
    Private Sub botVirgula_Click(sender As Object, e As EventArgs) Handles botVirgula.Click
        If Not TextBoxResultado.Text.Contains(",") Then
            TextBoxResultado.Text &= ","
        End If
    End Sub

    ' Botão para voltar ao menu
    Private Sub BotVoltar_Click(sender As Object, e As EventArgs) Handles BotVoltar.Click
        Form1.Show()
        Me.Close()
    End Sub

End Class
