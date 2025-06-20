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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FicheirosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeMarcasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CombustiveisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RevisõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FicheirosToolStripMenuItem, Me.SToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FicheirosToolStripMenuItem
        '
        Me.FicheirosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CarrosToolStripMenuItem, Me.TiposDeMarcasToolStripMenuItem, Me.CombustiveisToolStripMenuItem, Me.RevisõesToolStripMenuItem})
        Me.FicheirosToolStripMenuItem.Name = "FicheirosToolStripMenuItem"
        Me.FicheirosToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.FicheirosToolStripMenuItem.Text = "Ficheiros"
        '
        'CarrosToolStripMenuItem
        '
        Me.CarrosToolStripMenuItem.Name = "CarrosToolStripMenuItem"
        Me.CarrosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CarrosToolStripMenuItem.Text = "Carros"
        '
        'TiposDeMarcasToolStripMenuItem
        '
        Me.TiposDeMarcasToolStripMenuItem.Name = "TiposDeMarcasToolStripMenuItem"
        Me.TiposDeMarcasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TiposDeMarcasToolStripMenuItem.Text = "Marcas"
        '
        'CombustiveisToolStripMenuItem
        '
        Me.CombustiveisToolStripMenuItem.Name = "CombustiveisToolStripMenuItem"
        Me.CombustiveisToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CombustiveisToolStripMenuItem.Text = "Combustiveis"
        '
        'RevisõesToolStripMenuItem
        '
        Me.RevisõesToolStripMenuItem.Name = "RevisõesToolStripMenuItem"
        Me.RevisõesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RevisõesToolStripMenuItem.Text = "Revisões"
        '
        'SToolStripMenuItem
        '
        Me.SToolStripMenuItem.Name = "SToolStripMenuItem"
        Me.SToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.SToolStripMenuItem.Text = "Sair"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FicheirosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CarrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiposDeMarcasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CombustiveisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RevisõesToolStripMenuItem As ToolStripMenuItem
End Class
