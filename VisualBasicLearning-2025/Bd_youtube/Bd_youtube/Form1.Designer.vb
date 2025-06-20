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
        Me.EquipamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeEquipamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FicheirosToolStripMenuItem
        '
        Me.FicheirosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EquipamentosToolStripMenuItem, Me.TiposDeEquipamentosToolStripMenuItem})
        Me.FicheirosToolStripMenuItem.Name = "FicheirosToolStripMenuItem"
        Me.FicheirosToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.FicheirosToolStripMenuItem.Text = "Ficheiros"
        '
        'EquipamentosToolStripMenuItem
        '
        Me.EquipamentosToolStripMenuItem.Name = "EquipamentosToolStripMenuItem"
        Me.EquipamentosToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.EquipamentosToolStripMenuItem.Text = "Equipamentos"
        '
        'TiposDeEquipamentosToolStripMenuItem
        '
        Me.TiposDeEquipamentosToolStripMenuItem.Name = "TiposDeEquipamentosToolStripMenuItem"
        Me.TiposDeEquipamentosToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.TiposDeEquipamentosToolStripMenuItem.Text = "Tipos de Equipamentos"
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
    Friend WithEvents EquipamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiposDeEquipamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SToolStripMenuItem As ToolStripMenuItem
End Class
