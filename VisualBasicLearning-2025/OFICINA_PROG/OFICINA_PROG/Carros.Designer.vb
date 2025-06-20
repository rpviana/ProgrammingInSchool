<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Carros
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
        Dim IdMarcaLabel As System.Windows.Forms.Label
        Dim IdCombustivelLabel As System.Windows.Forms.Label
        Dim MatriculaLabel As System.Windows.Forms.Label
        Dim ModeloLabel As System.Windows.Forms.Label
        Dim AnoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Carros))
        Me.ButtonSeguinte = New System.Windows.Forms.Button()
        Me.ButtonSair = New System.Windows.Forms.Button()
        Me.ButtonFechar = New System.Windows.Forms.Button()
        Me.ButtonGravar = New System.Windows.Forms.Button()
        Me.ButtonRemover = New System.Windows.Forms.Button()
        Me.ButtonNovo = New System.Windows.Forms.Button()
        Me.ButtonAnterior = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CARROSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransportesDataSet = New OFICINA_PROG.transportesDataSet()
        Me.MARCASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.IdCombustivelTextBox = New System.Windows.Forms.TextBox()
        Me.MatriculaTextBox = New System.Windows.Forms.TextBox()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.AnoTextBox = New System.Windows.Forms.TextBox()
        Me.CARROSTableAdapter = New OFICINA_PROG.transportesDataSetTableAdapters.CARROSTableAdapter()
        Me.TableAdapterManager = New OFICINA_PROG.transportesDataSetTableAdapters.TableAdapterManager()
        Me.CARROSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CARROSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MARCASTableAdapter = New OFICINA_PROG.transportesDataSetTableAdapters.MARCASTableAdapter()
        Me.IdMarcaTextBoxx = New System.Windows.Forms.TextBox()
        Me.MARCASCARROSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MARCASBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdMarcaTextBox = New System.Windows.Forms.ComboBox()
        Me.MARCASBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        IdLabel = New System.Windows.Forms.Label()
        IdMarcaLabel = New System.Windows.Forms.Label()
        IdCombustivelLabel = New System.Windows.Forms.Label()
        MatriculaLabel = New System.Windows.Forms.Label()
        ModeloLabel = New System.Windows.Forms.Label()
        AnoLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CARROSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransportesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MARCASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CARROSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CARROSBindingNavigator.SuspendLayout()
        CType(Me.MARCASCARROSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MARCASBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MARCASBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(93, 53)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 0
        IdLabel.Text = "id:"
        '
        'IdMarcaLabel
        '
        IdMarcaLabel.AutoSize = True
        IdMarcaLabel.Location = New System.Drawing.Point(93, 79)
        IdMarcaLabel.Name = "IdMarcaLabel"
        IdMarcaLabel.Size = New System.Drawing.Size(51, 13)
        IdMarcaLabel.TabIndex = 2
        IdMarcaLabel.Text = "id Marca:"
        '
        'IdCombustivelLabel
        '
        IdCombustivelLabel.AutoSize = True
        IdCombustivelLabel.Location = New System.Drawing.Point(93, 105)
        IdCombustivelLabel.Name = "IdCombustivelLabel"
        IdCombustivelLabel.Size = New System.Drawing.Size(78, 13)
        IdCombustivelLabel.TabIndex = 4
        IdCombustivelLabel.Text = "id Combustivel:"
        '
        'MatriculaLabel
        '
        MatriculaLabel.AutoSize = True
        MatriculaLabel.Location = New System.Drawing.Point(93, 131)
        MatriculaLabel.Name = "MatriculaLabel"
        MatriculaLabel.Size = New System.Drawing.Size(52, 13)
        MatriculaLabel.TabIndex = 6
        MatriculaLabel.Text = "matricula:"
        '
        'ModeloLabel
        '
        ModeloLabel.AutoSize = True
        ModeloLabel.Location = New System.Drawing.Point(93, 157)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(44, 13)
        ModeloLabel.TabIndex = 8
        ModeloLabel.Text = "modelo:"
        '
        'AnoLabel
        '
        AnoLabel.AutoSize = True
        AnoLabel.Location = New System.Drawing.Point(93, 183)
        AnoLabel.Name = "AnoLabel"
        AnoLabel.Size = New System.Drawing.Size(28, 13)
        AnoLabel.TabIndex = 10
        AnoLabel.Text = "ano:"
        '
        'ButtonSeguinte
        '
        Me.ButtonSeguinte.Location = New System.Drawing.Point(131, 358)
        Me.ButtonSeguinte.Name = "ButtonSeguinte"
        Me.ButtonSeguinte.Size = New System.Drawing.Size(93, 33)
        Me.ButtonSeguinte.TabIndex = 54
        Me.ButtonSeguinte.Text = "Seguinte"
        Me.ButtonSeguinte.UseVisualStyleBackColor = True
        '
        'ButtonSair
        '
        Me.ButtonSair.Location = New System.Drawing.Point(687, 358)
        Me.ButtonSair.Name = "ButtonSair"
        Me.ButtonSair.Size = New System.Drawing.Size(93, 33)
        Me.ButtonSair.TabIndex = 53
        Me.ButtonSair.Text = "Sair"
        Me.ButtonSair.UseVisualStyleBackColor = True
        '
        'ButtonFechar
        '
        Me.ButtonFechar.Location = New System.Drawing.Point(578, 358)
        Me.ButtonFechar.Name = "ButtonFechar"
        Me.ButtonFechar.Size = New System.Drawing.Size(93, 33)
        Me.ButtonFechar.TabIndex = 52
        Me.ButtonFechar.Text = "Fechar"
        Me.ButtonFechar.UseVisualStyleBackColor = True
        '
        'ButtonGravar
        '
        Me.ButtonGravar.Location = New System.Drawing.Point(352, 358)
        Me.ButtonGravar.Name = "ButtonGravar"
        Me.ButtonGravar.Size = New System.Drawing.Size(93, 33)
        Me.ButtonGravar.TabIndex = 51
        Me.ButtonGravar.Text = "Gravar"
        Me.ButtonGravar.UseVisualStyleBackColor = True
        '
        'ButtonRemover
        '
        Me.ButtonRemover.Location = New System.Drawing.Point(463, 358)
        Me.ButtonRemover.Name = "ButtonRemover"
        Me.ButtonRemover.Size = New System.Drawing.Size(93, 33)
        Me.ButtonRemover.TabIndex = 50
        Me.ButtonRemover.Text = "Remover"
        Me.ButtonRemover.UseVisualStyleBackColor = True
        '
        'ButtonNovo
        '
        Me.ButtonNovo.Location = New System.Drawing.Point(242, 358)
        Me.ButtonNovo.Name = "ButtonNovo"
        Me.ButtonNovo.Size = New System.Drawing.Size(93, 33)
        Me.ButtonNovo.TabIndex = 49
        Me.ButtonNovo.Text = "Novo"
        Me.ButtonNovo.UseVisualStyleBackColor = True
        '
        'ButtonAnterior
        '
        Me.ButtonAnterior.Location = New System.Drawing.Point(20, 358)
        Me.ButtonAnterior.Name = "ButtonAnterior"
        Me.ButtonAnterior.Size = New System.Drawing.Size(93, 33)
        Me.ButtonAnterior.TabIndex = 48
        Me.ButtonAnterior.Text = "Anterior"
        Me.ButtonAnterior.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(387, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Carros"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Khaki
        Me.GroupBox1.Controls.Add(Me.IdMarcaTextBox)
        Me.GroupBox1.Controls.Add(Me.IdMarcaTextBoxx)
        Me.GroupBox1.Controls.Add(IdLabel)
        Me.GroupBox1.Controls.Add(Me.IdTextBox)
        Me.GroupBox1.Controls.Add(IdMarcaLabel)
        Me.GroupBox1.Controls.Add(IdCombustivelLabel)
        Me.GroupBox1.Controls.Add(Me.IdCombustivelTextBox)
        Me.GroupBox1.Controls.Add(MatriculaLabel)
        Me.GroupBox1.Controls.Add(Me.MatriculaTextBox)
        Me.GroupBox1.Controls.Add(ModeloLabel)
        Me.GroupBox1.Controls.Add(Me.ModeloTextBox)
        Me.GroupBox1.Controls.Add(AnoLabel)
        Me.GroupBox1.Controls.Add(Me.AnoTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(228, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 256)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " carro"
        '
        'CARROSBindingSource
        '
        Me.CARROSBindingSource.DataMember = "CARROS"
        Me.CARROSBindingSource.DataSource = Me.TransportesDataSet
        '
        'TransportesDataSet
        '
        Me.TransportesDataSet.DataSetName = "transportesDataSet"
        Me.TransportesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MARCASBindingSource
        '
        Me.MARCASBindingSource.DataMember = "MARCAS"
        Me.MARCASBindingSource.DataSource = Me.TransportesDataSet
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARROSBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(177, 50)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 1
        '
        'IdCombustivelTextBox
        '
        Me.IdCombustivelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARROSBindingSource, "idCombustivel", True))
        Me.IdCombustivelTextBox.Location = New System.Drawing.Point(177, 102)
        Me.IdCombustivelTextBox.Name = "IdCombustivelTextBox"
        Me.IdCombustivelTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdCombustivelTextBox.TabIndex = 5
        '
        'MatriculaTextBox
        '
        Me.MatriculaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARROSBindingSource, "matricula", True))
        Me.MatriculaTextBox.Location = New System.Drawing.Point(177, 128)
        Me.MatriculaTextBox.Name = "MatriculaTextBox"
        Me.MatriculaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MatriculaTextBox.TabIndex = 7
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARROSBindingSource, "modelo", True))
        Me.ModeloTextBox.Location = New System.Drawing.Point(177, 154)
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ModeloTextBox.TabIndex = 9
        '
        'AnoTextBox
        '
        Me.AnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARROSBindingSource, "ano", True))
        Me.AnoTextBox.Location = New System.Drawing.Point(177, 180)
        Me.AnoTextBox.Name = "AnoTextBox"
        Me.AnoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AnoTextBox.TabIndex = 11
        '
        'CARROSTableAdapter
        '
        Me.CARROSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CARROSTableAdapter = Me.CARROSTableAdapter
        Me.TableAdapterManager.COMBUSTIVEISTableAdapter = Nothing
        Me.TableAdapterManager.MARCASTableAdapter = Nothing
        Me.TableAdapterManager.REVISOESTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = OFICINA_PROG.transportesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CARROSBindingNavigator
        '
        Me.CARROSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CARROSBindingNavigator.BindingSource = Me.CARROSBindingSource
        Me.CARROSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CARROSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CARROSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CARROSBindingNavigatorSaveItem})
        Me.CARROSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CARROSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CARROSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CARROSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CARROSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CARROSBindingNavigator.Name = "CARROSBindingNavigator"
        Me.CARROSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CARROSBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.CARROSBindingNavigator.TabIndex = 55
        Me.CARROSBindingNavigator.Text = "BindingNavigator1"
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
        'CARROSBindingNavigatorSaveItem
        '
        Me.CARROSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CARROSBindingNavigatorSaveItem.Image = CType(resources.GetObject("CARROSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CARROSBindingNavigatorSaveItem.Name = "CARROSBindingNavigatorSaveItem"
        Me.CARROSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CARROSBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'MARCASTableAdapter
        '
        Me.MARCASTableAdapter.ClearBeforeFill = True
        '
        'IdMarcaTextBoxx
        '
        Me.IdMarcaTextBoxx.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARROSBindingSource, "idMarca", True))
        Me.IdMarcaTextBoxx.Location = New System.Drawing.Point(309, 72)
        Me.IdMarcaTextBoxx.Name = "IdMarcaTextBoxx"
        Me.IdMarcaTextBoxx.Size = New System.Drawing.Size(100, 20)
        Me.IdMarcaTextBoxx.TabIndex = 12
        '
        'MARCASCARROSBindingSource
        '
        Me.MARCASCARROSBindingSource.DataMember = "MARCASCARROS"
        Me.MARCASCARROSBindingSource.DataSource = Me.MARCASBindingSource
        '
        'MARCASBindingSource1
        '
        Me.MARCASBindingSource1.DataMember = "MARCAS"
        Me.MARCASBindingSource1.DataSource = Me.TransportesDataSet
        '
        'IdMarcaTextBox
        '
        Me.IdMarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CARROSBindingSource, "idMarca", True))
        Me.IdMarcaTextBox.DataSource = Me.MARCASBindingSource2
        Me.IdMarcaTextBox.DisplayMember = "marca"
        Me.IdMarcaTextBox.FormattingEnabled = True
        Me.IdMarcaTextBox.Location = New System.Drawing.Point(177, 76)
        Me.IdMarcaTextBox.Name = "IdMarcaTextBox"
        Me.IdMarcaTextBox.Size = New System.Drawing.Size(100, 21)
        Me.IdMarcaTextBox.TabIndex = 13
        Me.IdMarcaTextBox.ValueMember = "id"
        '
        'MARCASBindingSource2
        '
        Me.MARCASBindingSource2.DataMember = "MARCAS"
        Me.MARCASBindingSource2.DataSource = Me.TransportesDataSet
        '
        'Carros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CARROSBindingNavigator)
        Me.Controls.Add(Me.ButtonSeguinte)
        Me.Controls.Add(Me.ButtonSair)
        Me.Controls.Add(Me.ButtonFechar)
        Me.Controls.Add(Me.ButtonGravar)
        Me.Controls.Add(Me.ButtonRemover)
        Me.Controls.Add(Me.ButtonNovo)
        Me.Controls.Add(Me.ButtonAnterior)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Carros"
        Me.Text = "Form3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CARROSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransportesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MARCASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CARROSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CARROSBindingNavigator.ResumeLayout(False)
        Me.CARROSBindingNavigator.PerformLayout()
        CType(Me.MARCASCARROSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MARCASBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MARCASBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CARROSBindingSource As BindingSource
    Friend WithEvents CARROSTableAdapter As transportesDataSetTableAdapters.CARROSTableAdapter
    Friend WithEvents TableAdapterManager As transportesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CARROSBindingNavigator As BindingNavigator
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
    Friend WithEvents CARROSBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents IdCombustivelTextBox As TextBox
    Friend WithEvents MatriculaTextBox As TextBox
    Friend WithEvents ModeloTextBox As TextBox
    Friend WithEvents AnoTextBox As TextBox
    Friend WithEvents MARCASBindingSource As BindingSource
    Friend WithEvents MARCASTableAdapter As transportesDataSetTableAdapters.MARCASTableAdapter
    Friend WithEvents IdMarcaTextBoxx As TextBox
    Friend WithEvents MARCASBindingSource1 As BindingSource
    Friend WithEvents MARCASCARROSBindingSource As BindingSource
    Friend WithEvents IdMarcaTextBox As ComboBox
    Friend WithEvents MARCASBindingSource2 As BindingSource
End Class
