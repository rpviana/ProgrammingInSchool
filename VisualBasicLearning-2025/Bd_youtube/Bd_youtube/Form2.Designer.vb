<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim Nr_TipoLabel As System.Windows.Forms.Label
        Dim Nome_TipoLabel As System.Windows.Forms.Label
        Me.ButtonSeguinte = New System.Windows.Forms.Button()
        Me.ButtonSair = New System.Windows.Forms.Button()
        Me.ButtonFechar = New System.Windows.Forms.Button()
        Me.ButtonGravar = New System.Windows.Forms.Button()
        Me.ButtonRemover = New System.Windows.Forms.Button()
        Me.ButtonNovo = New System.Windows.Forms.Button()
        Me.ButtonAnterior = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BD_YoutubeDataSet = New Bd_youtube.BD_YoutubeDataSet()
        Me.TiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TiposTableAdapter = New Bd_youtube.BD_YoutubeDataSetTableAdapters.TiposTableAdapter()
        Me.TableAdapterManager = New Bd_youtube.BD_YoutubeDataSetTableAdapters.TableAdapterManager()
        Me.TiposBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TiposBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Nr_TipoTextBox = New System.Windows.Forms.TextBox()
        Me.Nome_TipoTextBox = New System.Windows.Forms.TextBox()
        Nr_TipoLabel = New System.Windows.Forms.Label()
        Nome_TipoLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BD_YoutubeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TiposBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonSeguinte
        '
        Me.ButtonSeguinte.Location = New System.Drawing.Point(131, 348)
        Me.ButtonSeguinte.Name = "ButtonSeguinte"
        Me.ButtonSeguinte.Size = New System.Drawing.Size(93, 33)
        Me.ButtonSeguinte.TabIndex = 50
        Me.ButtonSeguinte.Text = "Seguinte"
        Me.ButtonSeguinte.UseVisualStyleBackColor = True
        '
        'ButtonSair
        '
        Me.ButtonSair.Location = New System.Drawing.Point(687, 348)
        Me.ButtonSair.Name = "ButtonSair"
        Me.ButtonSair.Size = New System.Drawing.Size(93, 33)
        Me.ButtonSair.TabIndex = 49
        Me.ButtonSair.Text = "Sair"
        Me.ButtonSair.UseVisualStyleBackColor = True
        '
        'ButtonFechar
        '
        Me.ButtonFechar.Location = New System.Drawing.Point(578, 348)
        Me.ButtonFechar.Name = "ButtonFechar"
        Me.ButtonFechar.Size = New System.Drawing.Size(93, 33)
        Me.ButtonFechar.TabIndex = 48
        Me.ButtonFechar.Text = "Fechar"
        Me.ButtonFechar.UseVisualStyleBackColor = True
        '
        'ButtonGravar
        '
        Me.ButtonGravar.Location = New System.Drawing.Point(352, 348)
        Me.ButtonGravar.Name = "ButtonGravar"
        Me.ButtonGravar.Size = New System.Drawing.Size(93, 33)
        Me.ButtonGravar.TabIndex = 47
        Me.ButtonGravar.Text = "Gravar"
        Me.ButtonGravar.UseVisualStyleBackColor = True
        '
        'ButtonRemover
        '
        Me.ButtonRemover.Location = New System.Drawing.Point(463, 348)
        Me.ButtonRemover.Name = "ButtonRemover"
        Me.ButtonRemover.Size = New System.Drawing.Size(93, 33)
        Me.ButtonRemover.TabIndex = 46
        Me.ButtonRemover.Text = "Remover"
        Me.ButtonRemover.UseVisualStyleBackColor = True
        '
        'ButtonNovo
        '
        Me.ButtonNovo.Location = New System.Drawing.Point(242, 348)
        Me.ButtonNovo.Name = "ButtonNovo"
        Me.ButtonNovo.Size = New System.Drawing.Size(93, 33)
        Me.ButtonNovo.TabIndex = 45
        Me.ButtonNovo.Text = "Novo"
        Me.ButtonNovo.UseVisualStyleBackColor = True
        '
        'ButtonAnterior
        '
        Me.ButtonAnterior.Location = New System.Drawing.Point(20, 348)
        Me.ButtonAnterior.Name = "ButtonAnterior"
        Me.ButtonAnterior.Size = New System.Drawing.Size(93, 33)
        Me.ButtonAnterior.TabIndex = 44
        Me.ButtonAnterior.Text = "Anterior"
        Me.ButtonAnterior.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(327, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Tipos de Equipamentos"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Khaki
        Me.GroupBox1.Controls.Add(Nr_TipoLabel)
        Me.GroupBox1.Controls.Add(Me.Nr_TipoTextBox)
        Me.GroupBox1.Controls.Add(Nome_TipoLabel)
        Me.GroupBox1.Controls.Add(Me.Nome_TipoTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(242, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 180)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipos de Equipamentos"
        '
        'BD_YoutubeDataSet
        '
        Me.BD_YoutubeDataSet.DataSetName = "BD_YoutubeDataSet"
        Me.BD_YoutubeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TiposBindingSource
        '
        Me.TiposBindingSource.DataMember = "Tipos"
        Me.TiposBindingSource.DataSource = Me.BD_YoutubeDataSet
        '
        'TiposTableAdapter
        '
        Me.TiposTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EquipamentosTableAdapter = Nothing
        Me.TableAdapterManager.TiposTableAdapter = Me.TiposTableAdapter
        Me.TableAdapterManager.UpdateOrder = Bd_youtube.BD_YoutubeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TiposBindingNavigator
        '
        Me.TiposBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TiposBindingNavigator.BindingSource = Me.TiposBindingSource
        Me.TiposBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TiposBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TiposBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TiposBindingNavigatorSaveItem})
        Me.TiposBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TiposBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TiposBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TiposBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TiposBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TiposBindingNavigator.Name = "TiposBindingNavigator"
        Me.TiposBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TiposBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.TiposBindingNavigator.TabIndex = 51
        Me.TiposBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primeiro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posição"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posição actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover seguinte"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Adicionar novo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'TiposBindingNavigatorSaveItem
        '
        Me.TiposBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TiposBindingNavigatorSaveItem.Image = CType(resources.GetObject("TiposBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TiposBindingNavigatorSaveItem.Name = "TiposBindingNavigatorSaveItem"
        Me.TiposBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.TiposBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'Nr_TipoLabel
        '
        Nr_TipoLabel.AutoSize = True
        Nr_TipoLabel.Location = New System.Drawing.Point(71, 67)
        Nr_TipoLabel.Name = "Nr_TipoLabel"
        Nr_TipoLabel.Size = New System.Drawing.Size(45, 13)
        Nr_TipoLabel.TabIndex = 0
        Nr_TipoLabel.Text = "Nr Tipo:"
        '
        'Nr_TipoTextBox
        '
        Me.Nr_TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiposBindingSource, "Nr Tipo", True))
        Me.Nr_TipoTextBox.Location = New System.Drawing.Point(139, 64)
        Me.Nr_TipoTextBox.Name = "Nr_TipoTextBox"
        Me.Nr_TipoTextBox.Size = New System.Drawing.Size(35, 20)
        Me.Nr_TipoTextBox.TabIndex = 1
        '
        'Nome_TipoLabel
        '
        Nome_TipoLabel.AutoSize = True
        Nome_TipoLabel.Location = New System.Drawing.Point(71, 93)
        Nome_TipoLabel.Name = "Nome_TipoLabel"
        Nome_TipoLabel.Size = New System.Drawing.Size(62, 13)
        Nome_TipoLabel.TabIndex = 2
        Nome_TipoLabel.Text = "Nome Tipo:"
        '
        'Nome_TipoTextBox
        '
        Me.Nome_TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiposBindingSource, "Nome Tipo", True))
        Me.Nome_TipoTextBox.Location = New System.Drawing.Point(139, 90)
        Me.Nome_TipoTextBox.Name = "Nome_TipoTextBox"
        Me.Nome_TipoTextBox.Size = New System.Drawing.Size(105, 20)
        Me.Nome_TipoTextBox.TabIndex = 3
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TiposBindingNavigator)
        Me.Controls.Add(Me.ButtonSeguinte)
        Me.Controls.Add(Me.ButtonSair)
        Me.Controls.Add(Me.ButtonFechar)
        Me.Controls.Add(Me.ButtonGravar)
        Me.Controls.Add(Me.ButtonRemover)
        Me.Controls.Add(Me.ButtonNovo)
        Me.Controls.Add(Me.ButtonAnterior)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BD_YoutubeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TiposBindingNavigator.ResumeLayout(False)
        Me.TiposBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonSeguinte As Button
    Friend WithEvents ButtonSair As Button
    Friend WithEvents ButtonFechar As Button
    Friend WithEvents ButtonGravar As Button
    Friend WithEvents ButtonRemover As Button
    Friend WithEvents ButtonNovo As Button
    Friend WithEvents ButtonAnterior As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BD_YoutubeDataSet As BD_YoutubeDataSet
    Friend WithEvents TiposBindingSource As BindingSource
    Friend WithEvents TiposTableAdapter As BD_YoutubeDataSetTableAdapters.TiposTableAdapter
    Friend WithEvents TableAdapterManager As BD_YoutubeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TiposBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TiposBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Nr_TipoTextBox As TextBox
    Friend WithEvents Nome_TipoTextBox As TextBox
End Class
