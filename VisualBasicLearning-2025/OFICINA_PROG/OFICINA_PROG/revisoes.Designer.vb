<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class revisoes
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim IdCarroLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim ProblemaLabel As System.Windows.Forms.Label
        Dim ResolucaoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(revisoes))
        Me.ButtonSeguinte = New System.Windows.Forms.Button()
        Me.ButtonSair = New System.Windows.Forms.Button()
        Me.ButtonFechar = New System.Windows.Forms.Button()
        Me.ButtonGravar = New System.Windows.Forms.Button()
        Me.ButtonRemover = New System.Windows.Forms.Button()
        Me.ButtonNovo = New System.Windows.Forms.Button()
        Me.ButtonAnterior = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.REVISOESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransportesDataSet = New OFICINA_PROG.transportesDataSet()
        Me.DataDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ProblemaTextBox = New System.Windows.Forms.TextBox()
        Me.ResolucaoTextBox = New System.Windows.Forms.TextBox()
        Me.REVISOESTableAdapter = New OFICINA_PROG.transportesDataSetTableAdapters.REVISOESTableAdapter()
        Me.TableAdapterManager = New OFICINA_PROG.transportesDataSetTableAdapters.TableAdapterManager()
        Me.REVISOESBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.REVISOESBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdCarroTextBox = New System.Windows.Forms.ComboBox()
        Me.CARROSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CARROSTableAdapter = New OFICINA_PROG.transportesDataSetTableAdapters.CARROSTableAdapter()
        IdLabel = New System.Windows.Forms.Label()
        IdCarroLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        ProblemaLabel = New System.Windows.Forms.Label()
        ResolucaoLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.REVISOESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransportesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REVISOESBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.REVISOESBindingNavigator.SuspendLayout()
        CType(Me.CARROSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(81, 64)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 0
        IdLabel.Text = "id:"
        '
        'IdCarroLabel
        '
        IdCarroLabel.AutoSize = True
        IdCarroLabel.Location = New System.Drawing.Point(81, 90)
        IdCarroLabel.Name = "IdCarroLabel"
        IdCarroLabel.Size = New System.Drawing.Size(46, 13)
        IdCarroLabel.TabIndex = 2
        IdCarroLabel.Text = "id Carro:"
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Location = New System.Drawing.Point(81, 117)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(31, 13)
        DataLabel.TabIndex = 4
        DataLabel.Text = "data:"
        '
        'ProblemaLabel
        '
        ProblemaLabel.AutoSize = True
        ProblemaLabel.Location = New System.Drawing.Point(81, 142)
        ProblemaLabel.Name = "ProblemaLabel"
        ProblemaLabel.Size = New System.Drawing.Size(53, 13)
        ProblemaLabel.TabIndex = 6
        ProblemaLabel.Text = "problema:"
        '
        'ResolucaoLabel
        '
        ResolucaoLabel.AutoSize = True
        ResolucaoLabel.Location = New System.Drawing.Point(81, 168)
        ResolucaoLabel.Name = "ResolucaoLabel"
        ResolucaoLabel.Size = New System.Drawing.Size(56, 13)
        ResolucaoLabel.TabIndex = 8
        ResolucaoLabel.Text = "resolucao:"
        '
        'ButtonSeguinte
        '
        Me.ButtonSeguinte.Location = New System.Drawing.Point(131, 358)
        Me.ButtonSeguinte.Name = "ButtonSeguinte"
        Me.ButtonSeguinte.Size = New System.Drawing.Size(93, 33)
        Me.ButtonSeguinte.TabIndex = 72
        Me.ButtonSeguinte.Text = "Seguinte"
        Me.ButtonSeguinte.UseVisualStyleBackColor = True
        '
        'ButtonSair
        '
        Me.ButtonSair.Location = New System.Drawing.Point(687, 358)
        Me.ButtonSair.Name = "ButtonSair"
        Me.ButtonSair.Size = New System.Drawing.Size(93, 33)
        Me.ButtonSair.TabIndex = 71
        Me.ButtonSair.Text = "Sair"
        Me.ButtonSair.UseVisualStyleBackColor = True
        '
        'ButtonFechar
        '
        Me.ButtonFechar.Location = New System.Drawing.Point(578, 358)
        Me.ButtonFechar.Name = "ButtonFechar"
        Me.ButtonFechar.Size = New System.Drawing.Size(93, 33)
        Me.ButtonFechar.TabIndex = 70
        Me.ButtonFechar.Text = "Fechar"
        Me.ButtonFechar.UseVisualStyleBackColor = True
        '
        'ButtonGravar
        '
        Me.ButtonGravar.Location = New System.Drawing.Point(352, 358)
        Me.ButtonGravar.Name = "ButtonGravar"
        Me.ButtonGravar.Size = New System.Drawing.Size(93, 33)
        Me.ButtonGravar.TabIndex = 69
        Me.ButtonGravar.Text = "Gravar"
        Me.ButtonGravar.UseVisualStyleBackColor = True
        '
        'ButtonRemover
        '
        Me.ButtonRemover.Location = New System.Drawing.Point(463, 358)
        Me.ButtonRemover.Name = "ButtonRemover"
        Me.ButtonRemover.Size = New System.Drawing.Size(93, 33)
        Me.ButtonRemover.TabIndex = 68
        Me.ButtonRemover.Text = "Remover"
        Me.ButtonRemover.UseVisualStyleBackColor = True
        '
        'ButtonNovo
        '
        Me.ButtonNovo.Location = New System.Drawing.Point(242, 358)
        Me.ButtonNovo.Name = "ButtonNovo"
        Me.ButtonNovo.Size = New System.Drawing.Size(93, 33)
        Me.ButtonNovo.TabIndex = 67
        Me.ButtonNovo.Text = "Novo"
        Me.ButtonNovo.UseVisualStyleBackColor = True
        '
        'ButtonAnterior
        '
        Me.ButtonAnterior.Location = New System.Drawing.Point(20, 358)
        Me.ButtonAnterior.Name = "ButtonAnterior"
        Me.ButtonAnterior.Size = New System.Drawing.Size(93, 33)
        Me.ButtonAnterior.TabIndex = 66
        Me.ButtonAnterior.Text = "Anterior"
        Me.ButtonAnterior.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(394, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Revisões"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Khaki
        Me.GroupBox1.Controls.Add(Me.IdCarroTextBox)
        Me.GroupBox1.Controls.Add(IdLabel)
        Me.GroupBox1.Controls.Add(Me.IdTextBox)
        Me.GroupBox1.Controls.Add(IdCarroLabel)
        Me.GroupBox1.Controls.Add(DataLabel)
        Me.GroupBox1.Controls.Add(Me.DataDateTimePicker)
        Me.GroupBox1.Controls.Add(ProblemaLabel)
        Me.GroupBox1.Controls.Add(Me.ProblemaTextBox)
        Me.GroupBox1.Controls.Add(ResolucaoLabel)
        Me.GroupBox1.Controls.Add(Me.ResolucaoTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(192, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 268)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Revisões"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REVISOESBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(143, 61)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdTextBox.TabIndex = 1
        '
        'REVISOESBindingSource
        '
        Me.REVISOESBindingSource.DataMember = "REVISOES"
        Me.REVISOESBindingSource.DataSource = Me.TransportesDataSet
        '
        'TransportesDataSet
        '
        Me.TransportesDataSet.DataSetName = "transportesDataSet"
        Me.TransportesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataDateTimePicker
        '
        Me.DataDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.REVISOESBindingSource, "data", True))
        Me.DataDateTimePicker.Location = New System.Drawing.Point(143, 113)
        Me.DataDateTimePicker.Name = "DataDateTimePicker"
        Me.DataDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DataDateTimePicker.TabIndex = 5
        '
        'ProblemaTextBox
        '
        Me.ProblemaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REVISOESBindingSource, "problema", True))
        Me.ProblemaTextBox.Location = New System.Drawing.Point(143, 139)
        Me.ProblemaTextBox.Name = "ProblemaTextBox"
        Me.ProblemaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ProblemaTextBox.TabIndex = 7
        '
        'ResolucaoTextBox
        '
        Me.ResolucaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REVISOESBindingSource, "resolucao", True))
        Me.ResolucaoTextBox.Location = New System.Drawing.Point(143, 165)
        Me.ResolucaoTextBox.Name = "ResolucaoTextBox"
        Me.ResolucaoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ResolucaoTextBox.TabIndex = 9
        '
        'REVISOESTableAdapter
        '
        Me.REVISOESTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CARROSTableAdapter = Nothing
        Me.TableAdapterManager.COMBUSTIVEISTableAdapter = Nothing
        Me.TableAdapterManager.MARCASTableAdapter = Nothing
        Me.TableAdapterManager.REVISOESTableAdapter = Me.REVISOESTableAdapter
        Me.TableAdapterManager.UpdateOrder = OFICINA_PROG.transportesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'REVISOESBindingNavigator
        '
        Me.REVISOESBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.REVISOESBindingNavigator.BindingSource = Me.REVISOESBindingSource
        Me.REVISOESBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.REVISOESBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.REVISOESBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.REVISOESBindingNavigatorSaveItem})
        Me.REVISOESBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.REVISOESBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.REVISOESBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.REVISOESBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.REVISOESBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.REVISOESBindingNavigator.Name = "REVISOESBindingNavigator"
        Me.REVISOESBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.REVISOESBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.REVISOESBindingNavigator.TabIndex = 73
        Me.REVISOESBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posição actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover seguinte"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'REVISOESBindingNavigatorSaveItem
        '
        Me.REVISOESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.REVISOESBindingNavigatorSaveItem.Image = CType(resources.GetObject("REVISOESBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.REVISOESBindingNavigatorSaveItem.Name = "REVISOESBindingNavigatorSaveItem"
        Me.REVISOESBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.REVISOESBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'IdCarroTextBox
        '
        Me.IdCarroTextBox.DataSource = Me.CARROSBindingSource
        Me.IdCarroTextBox.DisplayMember = "matricula"
        Me.IdCarroTextBox.FormattingEnabled = True
        Me.IdCarroTextBox.Location = New System.Drawing.Point(143, 86)
        Me.IdCarroTextBox.Name = "IdCarroTextBox"
        Me.IdCarroTextBox.Size = New System.Drawing.Size(200, 21)
        Me.IdCarroTextBox.TabIndex = 48
        Me.IdCarroTextBox.ValueMember = "id"
        '
        'CARROSBindingSource
        '
        Me.CARROSBindingSource.DataMember = "CARROS"
        Me.CARROSBindingSource.DataSource = Me.TransportesDataSet
        '
        'CARROSTableAdapter
        '
        Me.CARROSTableAdapter.ClearBeforeFill = True
        '
        'revisoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.REVISOESBindingNavigator)
        Me.Controls.Add(Me.ButtonSeguinte)
        Me.Controls.Add(Me.ButtonSair)
        Me.Controls.Add(Me.ButtonFechar)
        Me.Controls.Add(Me.ButtonGravar)
        Me.Controls.Add(Me.ButtonRemover)
        Me.Controls.Add(Me.ButtonNovo)
        Me.Controls.Add(Me.ButtonAnterior)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "revisoes"
        Me.Text = "revisoes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.REVISOESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransportesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REVISOESBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.REVISOESBindingNavigator.ResumeLayout(False)
        Me.REVISOESBindingNavigator.PerformLayout()
        CType(Me.CARROSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TransportesDataSet As transportesDataSet
    Friend WithEvents REVISOESBindingSource As BindingSource
    Friend WithEvents REVISOESTableAdapter As transportesDataSetTableAdapters.REVISOESTableAdapter
    Friend WithEvents TableAdapterManager As transportesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents REVISOESBindingNavigator As BindingNavigator
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
    Friend WithEvents REVISOESBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents DataDateTimePicker As DateTimePicker
    Friend WithEvents ProblemaTextBox As TextBox
    Friend WithEvents ResolucaoTextBox As TextBox
    Friend WithEvents IdCarroTextBox As ComboBox
    Friend WithEvents CARROSBindingSource As BindingSource
    Friend WithEvents CARROSTableAdapter As transportesDataSetTableAdapters.CARROSTableAdapter
End Class
