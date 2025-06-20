<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Dim NrLabel As System.Windows.Forms.Label
        Dim DescriçãoLabel As System.Windows.Forms.Label
        Dim Nr_TipoLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
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
        Me.EquipamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EquipamentosTableAdapter = New Bd_youtube.BD_YoutubeDataSetTableAdapters.EquipamentosTableAdapter()
        Me.TableAdapterManager = New Bd_youtube.BD_YoutubeDataSetTableAdapters.TableAdapterManager()
        Me.EquipamentosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EquipamentosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NrTextBox = New System.Windows.Forms.TextBox()
        Me.DescriçãoTextBox = New System.Windows.Forms.TextBox()
        Me.Nr_TipoTextBox = New System.Windows.Forms.TextBox()
        Me.DataDateTimePicker = New System.Windows.Forms.DateTimePicker()
        NrLabel = New System.Windows.Forms.Label()
        DescriçãoLabel = New System.Windows.Forms.Label()
        Nr_TipoLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BD_YoutubeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipamentosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EquipamentosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonSeguinte
        '
        Me.ButtonSeguinte.Location = New System.Drawing.Point(131, 358)
        Me.ButtonSeguinte.Name = "ButtonSeguinte"
        Me.ButtonSeguinte.Size = New System.Drawing.Size(93, 33)
        Me.ButtonSeguinte.TabIndex = 63
        Me.ButtonSeguinte.Text = "Seguinte"
        Me.ButtonSeguinte.UseVisualStyleBackColor = True
        '
        'ButtonSair
        '
        Me.ButtonSair.Location = New System.Drawing.Point(687, 358)
        Me.ButtonSair.Name = "ButtonSair"
        Me.ButtonSair.Size = New System.Drawing.Size(93, 33)
        Me.ButtonSair.TabIndex = 62
        Me.ButtonSair.Text = "Sair"
        Me.ButtonSair.UseVisualStyleBackColor = True
        '
        'ButtonFechar
        '
        Me.ButtonFechar.Location = New System.Drawing.Point(578, 358)
        Me.ButtonFechar.Name = "ButtonFechar"
        Me.ButtonFechar.Size = New System.Drawing.Size(93, 33)
        Me.ButtonFechar.TabIndex = 61
        Me.ButtonFechar.Text = "Fechar"
        Me.ButtonFechar.UseVisualStyleBackColor = True
        '
        'ButtonGravar
        '
        Me.ButtonGravar.Location = New System.Drawing.Point(352, 358)
        Me.ButtonGravar.Name = "ButtonGravar"
        Me.ButtonGravar.Size = New System.Drawing.Size(93, 33)
        Me.ButtonGravar.TabIndex = 60
        Me.ButtonGravar.Text = "Gravar"
        Me.ButtonGravar.UseVisualStyleBackColor = True
        '
        'ButtonRemover
        '
        Me.ButtonRemover.Location = New System.Drawing.Point(463, 358)
        Me.ButtonRemover.Name = "ButtonRemover"
        Me.ButtonRemover.Size = New System.Drawing.Size(93, 33)
        Me.ButtonRemover.TabIndex = 59
        Me.ButtonRemover.Text = "Remover"
        Me.ButtonRemover.UseVisualStyleBackColor = True
        '
        'ButtonNovo
        '
        Me.ButtonNovo.Location = New System.Drawing.Point(242, 358)
        Me.ButtonNovo.Name = "ButtonNovo"
        Me.ButtonNovo.Size = New System.Drawing.Size(93, 33)
        Me.ButtonNovo.TabIndex = 58
        Me.ButtonNovo.Text = "Novo"
        Me.ButtonNovo.UseVisualStyleBackColor = True
        '
        'ButtonAnterior
        '
        Me.ButtonAnterior.Location = New System.Drawing.Point(20, 358)
        Me.ButtonAnterior.Name = "ButtonAnterior"
        Me.ButtonAnterior.Size = New System.Drawing.Size(93, 33)
        Me.ButtonAnterior.TabIndex = 57
        Me.ButtonAnterior.Text = "Anterior"
        Me.ButtonAnterior.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(334, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Equipamentos"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Khaki
        Me.GroupBox1.Controls.Add(NrLabel)
        Me.GroupBox1.Controls.Add(Me.NrTextBox)
        Me.GroupBox1.Controls.Add(DescriçãoLabel)
        Me.GroupBox1.Controls.Add(Me.DescriçãoTextBox)
        Me.GroupBox1.Controls.Add(Nr_TipoLabel)
        Me.GroupBox1.Controls.Add(Me.Nr_TipoTextBox)
        Me.GroupBox1.Controls.Add(DataLabel)
        Me.GroupBox1.Controls.Add(Me.DataDateTimePicker)
        Me.GroupBox1.Location = New System.Drawing.Point(175, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(455, 256)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Equipamentos"
        '
        'BD_YoutubeDataSet
        '
        Me.BD_YoutubeDataSet.DataSetName = "BD_YoutubeDataSet"
        Me.BD_YoutubeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EquipamentosBindingSource
        '
        Me.EquipamentosBindingSource.DataMember = "Equipamentos"
        Me.EquipamentosBindingSource.DataSource = Me.BD_YoutubeDataSet
        '
        'EquipamentosTableAdapter
        '
        Me.EquipamentosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EquipamentosTableAdapter = Me.EquipamentosTableAdapter
        Me.TableAdapterManager.TiposTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Bd_youtube.BD_YoutubeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EquipamentosBindingNavigator
        '
        Me.EquipamentosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EquipamentosBindingNavigator.BindingSource = Me.EquipamentosBindingSource
        Me.EquipamentosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EquipamentosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EquipamentosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EquipamentosBindingNavigatorSaveItem})
        Me.EquipamentosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EquipamentosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EquipamentosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EquipamentosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EquipamentosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EquipamentosBindingNavigator.Name = "EquipamentosBindingNavigator"
        Me.EquipamentosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EquipamentosBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.EquipamentosBindingNavigator.TabIndex = 64
        Me.EquipamentosBindingNavigator.Text = "BindingNavigator1"
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
        'EquipamentosBindingNavigatorSaveItem
        '
        Me.EquipamentosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EquipamentosBindingNavigatorSaveItem.Image = CType(resources.GetObject("EquipamentosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EquipamentosBindingNavigatorSaveItem.Name = "EquipamentosBindingNavigatorSaveItem"
        Me.EquipamentosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.EquipamentosBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'NrLabel
        '
        NrLabel.AutoSize = True
        NrLabel.Location = New System.Drawing.Point(86, 68)
        NrLabel.Name = "NrLabel"
        NrLabel.Size = New System.Drawing.Size(21, 13)
        NrLabel.TabIndex = 0
        NrLabel.Text = "Nr:"
        '
        'NrTextBox
        '
        Me.NrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipamentosBindingSource, "Nr", True))
        Me.NrTextBox.Location = New System.Drawing.Point(150, 65)
        Me.NrTextBox.Name = "NrTextBox"
        Me.NrTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NrTextBox.TabIndex = 1
        '
        'DescriçãoLabel
        '
        DescriçãoLabel.AutoSize = True
        DescriçãoLabel.Location = New System.Drawing.Point(86, 94)
        DescriçãoLabel.Name = "DescriçãoLabel"
        DescriçãoLabel.Size = New System.Drawing.Size(58, 13)
        DescriçãoLabel.TabIndex = 2
        DescriçãoLabel.Text = "Descrição:"
        '
        'DescriçãoTextBox
        '
        Me.DescriçãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipamentosBindingSource, "Descrição", True))
        Me.DescriçãoTextBox.Location = New System.Drawing.Point(150, 91)
        Me.DescriçãoTextBox.Name = "DescriçãoTextBox"
        Me.DescriçãoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DescriçãoTextBox.TabIndex = 3
        '
        'Nr_TipoLabel
        '
        Nr_TipoLabel.AutoSize = True
        Nr_TipoLabel.Location = New System.Drawing.Point(86, 120)
        Nr_TipoLabel.Name = "Nr_TipoLabel"
        Nr_TipoLabel.Size = New System.Drawing.Size(45, 13)
        Nr_TipoLabel.TabIndex = 4
        Nr_TipoLabel.Text = "Nr Tipo:"
        '
        'Nr_TipoTextBox
        '
        Me.Nr_TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipamentosBindingSource, "Nr Tipo", True))
        Me.Nr_TipoTextBox.Location = New System.Drawing.Point(150, 117)
        Me.Nr_TipoTextBox.Name = "Nr_TipoTextBox"
        Me.Nr_TipoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Nr_TipoTextBox.TabIndex = 5
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Location = New System.Drawing.Point(86, 147)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(33, 13)
        DataLabel.TabIndex = 6
        DataLabel.Text = "Data:"
        '
        'DataDateTimePicker
        '
        Me.DataDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EquipamentosBindingSource, "Data", True))
        Me.DataDateTimePicker.Location = New System.Drawing.Point(150, 143)
        Me.DataDateTimePicker.Name = "DataDateTimePicker"
        Me.DataDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DataDateTimePicker.TabIndex = 7
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.EquipamentosBindingNavigator)
        Me.Controls.Add(Me.ButtonSeguinte)
        Me.Controls.Add(Me.ButtonSair)
        Me.Controls.Add(Me.ButtonFechar)
        Me.Controls.Add(Me.ButtonGravar)
        Me.Controls.Add(Me.ButtonRemover)
        Me.Controls.Add(Me.ButtonNovo)
        Me.Controls.Add(Me.ButtonAnterior)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BD_YoutubeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipamentosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EquipamentosBindingNavigator.ResumeLayout(False)
        Me.EquipamentosBindingNavigator.PerformLayout()
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
    Friend WithEvents EquipamentosBindingSource As BindingSource
    Friend WithEvents EquipamentosTableAdapter As BD_YoutubeDataSetTableAdapters.EquipamentosTableAdapter
    Friend WithEvents TableAdapterManager As BD_YoutubeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EquipamentosBindingNavigator As BindingNavigator
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
    Friend WithEvents EquipamentosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NrTextBox As TextBox
    Friend WithEvents DescriçãoTextBox As TextBox
    Friend WithEvents Nr_TipoTextBox As TextBox
    Friend WithEvents DataDateTimePicker As DateTimePicker
End Class
