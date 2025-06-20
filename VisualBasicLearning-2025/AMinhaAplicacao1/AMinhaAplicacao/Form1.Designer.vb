<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.botCalc = New System.Windows.Forms.Button()
        Me.botIMC = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(129, -24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(562, 379)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Welcome to my indian turkish kebab aplication"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'botCalc
        '
        Me.botCalc.Location = New System.Drawing.Point(12, 323)
        Me.botCalc.Name = "botCalc"
        Me.botCalc.Size = New System.Drawing.Size(213, 115)
        Me.botCalc.TabIndex = 4
        Me.botCalc.Text = "Abrir Calculadora"
        Me.botCalc.UseVisualStyleBackColor = True
        '
        'botIMC
        '
        Me.botIMC.Location = New System.Drawing.Point(576, 323)
        Me.botIMC.Name = "botIMC"
        Me.botIMC.Size = New System.Drawing.Size(212, 115)
        Me.botIMC.TabIndex = 3
        Me.botIMC.Text = "Abrir Calc de IMC"
        Me.botIMC.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.botCalc)
        Me.Controls.Add(Me.botIMC)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents botCalc As Button
    Friend WithEvents botIMC As Button
End Class
