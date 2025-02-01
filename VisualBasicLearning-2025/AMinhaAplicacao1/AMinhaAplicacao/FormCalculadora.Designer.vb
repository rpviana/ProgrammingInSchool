<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCalculadora
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBoxResultado1 = New System.Windows.Forms.TextBox()
        Me.BotVoltar = New System.Windows.Forms.Button()
        Me.TextBoxResultado = New System.Windows.Forms.TextBox()
        Me.botDividir = New System.Windows.Forms.Button()
        Me.botApagar = New System.Windows.Forms.Button()
        Me.botLimpar = New System.Windows.Forms.Button()
        Me.botVezes = New System.Windows.Forms.Button()
        Me.botMenos = New System.Windows.Forms.Button()
        Me.botMais = New System.Windows.Forms.Button()
        Me.botNove = New System.Windows.Forms.Button()
        Me.botSeis = New System.Windows.Forms.Button()
        Me.botTres = New System.Windows.Forms.Button()
        Me.botOito = New System.Windows.Forms.Button()
        Me.botCinco = New System.Windows.Forms.Button()
        Me.botDois = New System.Windows.Forms.Button()
        Me.botSete = New System.Windows.Forms.Button()
        Me.botQuatro = New System.Windows.Forms.Button()
        Me.botUm = New System.Windows.Forms.Button()
        Me.botIgual = New System.Windows.Forms.Button()
        Me.botVirgula = New System.Windows.Forms.Button()
        Me.botZero = New System.Windows.Forms.Button()
        Me.botInverte = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxResultado1
        '
        Me.TextBoxResultado1.BackColor = System.Drawing.Color.White
        Me.TextBoxResultado1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxResultado1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxResultado1.Location = New System.Drawing.Point(13, 11)
        Me.TextBoxResultado1.Multiline = True
        Me.TextBoxResultado1.Name = "TextBoxResultado1"
        Me.TextBoxResultado1.Size = New System.Drawing.Size(314, 35)
        Me.TextBoxResultado1.TabIndex = 68
        Me.TextBoxResultado1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BotVoltar
        '
        Me.BotVoltar.BackColor = System.Drawing.Color.White
        Me.BotVoltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotVoltar.Location = New System.Drawing.Point(12, 461)
        Me.BotVoltar.Name = "BotVoltar"
        Me.BotVoltar.Size = New System.Drawing.Size(315, 78)
        Me.BotVoltar.TabIndex = 67
        Me.BotVoltar.Text = "VOLTAR MENU"
        Me.BotVoltar.UseVisualStyleBackColor = False
        '
        'TextBoxResultado
        '
        Me.TextBoxResultado.BackColor = System.Drawing.Color.White
        Me.TextBoxResultado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxResultado.Location = New System.Drawing.Point(13, 52)
        Me.TextBoxResultado.Multiline = True
        Me.TextBoxResultado.Name = "TextBoxResultado"
        Me.TextBoxResultado.Size = New System.Drawing.Size(314, 53)
        Me.TextBoxResultado.TabIndex = 66
        Me.TextBoxResultado.Text = "0"
        Me.TextBoxResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'botDividir
        '
        Me.botDividir.BackColor = System.Drawing.Color.Silver
        Me.botDividir.Location = New System.Drawing.Point(174, 111)
        Me.botDividir.Name = "botDividir"
        Me.botDividir.Size = New System.Drawing.Size(75, 64)
        Me.botDividir.TabIndex = 65
        Me.botDividir.Text = "%"
        Me.botDividir.UseVisualStyleBackColor = False
        '
        'botApagar
        '
        Me.botApagar.BackColor = System.Drawing.Color.Silver
        Me.botApagar.Location = New System.Drawing.Point(93, 111)
        Me.botApagar.Name = "botApagar"
        Me.botApagar.Size = New System.Drawing.Size(75, 64)
        Me.botApagar.TabIndex = 64
        Me.botApagar.Text = "<x="
        Me.botApagar.UseVisualStyleBackColor = False
        '
        'botLimpar
        '
        Me.botLimpar.BackColor = System.Drawing.Color.Silver
        Me.botLimpar.Location = New System.Drawing.Point(12, 111)
        Me.botLimpar.Name = "botLimpar"
        Me.botLimpar.Size = New System.Drawing.Size(75, 64)
        Me.botLimpar.TabIndex = 63
        Me.botLimpar.Text = "C"
        Me.botLimpar.UseVisualStyleBackColor = False
        '
        'botVezes
        '
        Me.botVezes.BackColor = System.Drawing.Color.Silver
        Me.botVezes.Location = New System.Drawing.Point(252, 111)
        Me.botVezes.Name = "botVezes"
        Me.botVezes.Size = New System.Drawing.Size(75, 64)
        Me.botVezes.TabIndex = 62
        Me.botVezes.Text = "X"
        Me.botVezes.UseVisualStyleBackColor = False
        '
        'botMenos
        '
        Me.botMenos.BackColor = System.Drawing.Color.Silver
        Me.botMenos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botMenos.Location = New System.Drawing.Point(252, 181)
        Me.botMenos.Name = "botMenos"
        Me.botMenos.Size = New System.Drawing.Size(75, 64)
        Me.botMenos.TabIndex = 61
        Me.botMenos.Text = "-"
        Me.botMenos.UseVisualStyleBackColor = False
        '
        'botMais
        '
        Me.botMais.BackColor = System.Drawing.Color.Silver
        Me.botMais.Location = New System.Drawing.Point(252, 251)
        Me.botMais.Name = "botMais"
        Me.botMais.Size = New System.Drawing.Size(75, 64)
        Me.botMais.TabIndex = 60
        Me.botMais.Text = "+"
        Me.botMais.UseVisualStyleBackColor = False
        '
        'botNove
        '
        Me.botNove.BackColor = System.Drawing.Color.White
        Me.botNove.Location = New System.Drawing.Point(174, 181)
        Me.botNove.Name = "botNove"
        Me.botNove.Size = New System.Drawing.Size(75, 64)
        Me.botNove.TabIndex = 59
        Me.botNove.Text = "9"
        Me.botNove.UseVisualStyleBackColor = False
        '
        'botSeis
        '
        Me.botSeis.BackColor = System.Drawing.Color.White
        Me.botSeis.Location = New System.Drawing.Point(174, 251)
        Me.botSeis.Name = "botSeis"
        Me.botSeis.Size = New System.Drawing.Size(75, 64)
        Me.botSeis.TabIndex = 58
        Me.botSeis.Text = "6"
        Me.botSeis.UseVisualStyleBackColor = False
        '
        'botTres
        '
        Me.botTres.BackColor = System.Drawing.Color.White
        Me.botTres.Location = New System.Drawing.Point(174, 321)
        Me.botTres.Name = "botTres"
        Me.botTres.Size = New System.Drawing.Size(75, 64)
        Me.botTres.TabIndex = 57
        Me.botTres.Text = "3"
        Me.botTres.UseVisualStyleBackColor = False
        '
        'botOito
        '
        Me.botOito.BackColor = System.Drawing.Color.White
        Me.botOito.Location = New System.Drawing.Point(93, 181)
        Me.botOito.Name = "botOito"
        Me.botOito.Size = New System.Drawing.Size(75, 64)
        Me.botOito.TabIndex = 56
        Me.botOito.Text = "8"
        Me.botOito.UseVisualStyleBackColor = False
        '
        'botCinco
        '
        Me.botCinco.BackColor = System.Drawing.Color.White
        Me.botCinco.Location = New System.Drawing.Point(93, 251)
        Me.botCinco.Name = "botCinco"
        Me.botCinco.Size = New System.Drawing.Size(75, 64)
        Me.botCinco.TabIndex = 55
        Me.botCinco.Text = "5"
        Me.botCinco.UseVisualStyleBackColor = False
        '
        'botDois
        '
        Me.botDois.BackColor = System.Drawing.Color.White
        Me.botDois.Location = New System.Drawing.Point(93, 321)
        Me.botDois.Name = "botDois"
        Me.botDois.Size = New System.Drawing.Size(75, 64)
        Me.botDois.TabIndex = 54
        Me.botDois.Text = "2"
        Me.botDois.UseVisualStyleBackColor = False
        '
        'botSete
        '
        Me.botSete.BackColor = System.Drawing.Color.White
        Me.botSete.Location = New System.Drawing.Point(12, 181)
        Me.botSete.Name = "botSete"
        Me.botSete.Size = New System.Drawing.Size(75, 64)
        Me.botSete.TabIndex = 53
        Me.botSete.Text = "7"
        Me.botSete.UseVisualStyleBackColor = False
        '
        'botQuatro
        '
        Me.botQuatro.BackColor = System.Drawing.Color.White
        Me.botQuatro.Location = New System.Drawing.Point(12, 251)
        Me.botQuatro.Name = "botQuatro"
        Me.botQuatro.Size = New System.Drawing.Size(75, 64)
        Me.botQuatro.TabIndex = 52
        Me.botQuatro.Text = "4"
        Me.botQuatro.UseVisualStyleBackColor = False
        '
        'botUm
        '
        Me.botUm.BackColor = System.Drawing.Color.White
        Me.botUm.Location = New System.Drawing.Point(12, 321)
        Me.botUm.Name = "botUm"
        Me.botUm.Size = New System.Drawing.Size(75, 64)
        Me.botUm.TabIndex = 51
        Me.botUm.Text = "1"
        Me.botUm.UseVisualStyleBackColor = False
        '
        'botIgual
        '
        Me.botIgual.BackColor = System.Drawing.Color.LightBlue
        Me.botIgual.Location = New System.Drawing.Point(252, 321)
        Me.botIgual.Name = "botIgual"
        Me.botIgual.Size = New System.Drawing.Size(75, 134)
        Me.botIgual.TabIndex = 50
        Me.botIgual.Text = "="
        Me.botIgual.UseVisualStyleBackColor = False
        '
        'botVirgula
        '
        Me.botVirgula.BackColor = System.Drawing.Color.Silver
        Me.botVirgula.Location = New System.Drawing.Point(174, 391)
        Me.botVirgula.Name = "botVirgula"
        Me.botVirgula.Size = New System.Drawing.Size(75, 64)
        Me.botVirgula.TabIndex = 49
        Me.botVirgula.Text = ","
        Me.botVirgula.UseVisualStyleBackColor = False
        '
        'botZero
        '
        Me.botZero.BackColor = System.Drawing.Color.White
        Me.botZero.Location = New System.Drawing.Point(93, 391)
        Me.botZero.Name = "botZero"
        Me.botZero.Size = New System.Drawing.Size(75, 64)
        Me.botZero.TabIndex = 48
        Me.botZero.Text = "0"
        Me.botZero.UseVisualStyleBackColor = False
        '
        'botInverte
        '
        Me.botInverte.BackColor = System.Drawing.Color.Silver
        Me.botInverte.Location = New System.Drawing.Point(12, 391)
        Me.botInverte.Name = "botInverte"
        Me.botInverte.Size = New System.Drawing.Size(75, 64)
        Me.botInverte.TabIndex = 47
        Me.botInverte.Text = "+/-"
        Me.botInverte.UseVisualStyleBackColor = False
        '
        'FormCalculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(339, 551)
        Me.Controls.Add(Me.TextBoxResultado1)
        Me.Controls.Add(Me.BotVoltar)
        Me.Controls.Add(Me.TextBoxResultado)
        Me.Controls.Add(Me.botDividir)
        Me.Controls.Add(Me.botApagar)
        Me.Controls.Add(Me.botLimpar)
        Me.Controls.Add(Me.botVezes)
        Me.Controls.Add(Me.botMenos)
        Me.Controls.Add(Me.botMais)
        Me.Controls.Add(Me.botNove)
        Me.Controls.Add(Me.botSeis)
        Me.Controls.Add(Me.botTres)
        Me.Controls.Add(Me.botOito)
        Me.Controls.Add(Me.botCinco)
        Me.Controls.Add(Me.botDois)
        Me.Controls.Add(Me.botSete)
        Me.Controls.Add(Me.botQuatro)
        Me.Controls.Add(Me.botUm)
        Me.Controls.Add(Me.botIgual)
        Me.Controls.Add(Me.botVirgula)
        Me.Controls.Add(Me.botZero)
        Me.Controls.Add(Me.botInverte)
        Me.Name = "FormCalculadora"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxResultado1 As TextBox
    Friend WithEvents BotVoltar As Button
    Friend WithEvents TextBoxResultado As TextBox
    Friend WithEvents botDividir As Button
    Friend WithEvents botApagar As Button
    Friend WithEvents botLimpar As Button
    Friend WithEvents botVezes As Button
    Friend WithEvents botMenos As Button
    Friend WithEvents botMais As Button
    Friend WithEvents botNove As Button
    Friend WithEvents botSeis As Button
    Friend WithEvents botTres As Button
    Friend WithEvents botOito As Button
    Friend WithEvents botCinco As Button
    Friend WithEvents botDois As Button
    Friend WithEvents botSete As Button
    Friend WithEvents botQuatro As Button
    Friend WithEvents botUm As Button
    Friend WithEvents botIgual As Button
    Friend WithEvents botVirgula As Button
    Friend WithEvents botZero As Button
    Friend WithEvents botInverte As Button
End Class
