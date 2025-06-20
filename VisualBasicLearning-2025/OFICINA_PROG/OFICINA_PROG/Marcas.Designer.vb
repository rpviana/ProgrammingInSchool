<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Marcas
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Marcas))
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
        Me.MARCASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransportesDataSet = New OFICINA_PROG.transportesDataSet()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.MARCASBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MARCASBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MARCASTableAdapter = New OFICINA_PROG.transportesDataSetTableAdapters.MARCASTableAdapter()
        Me.TableAdapterManager = New OFICINA_PROG.transportesDataSetTableAdapters.TableAdapterManager()
        IdLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MARCASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransportesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MARCASBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MARCASBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(65, 72)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 0
        IdLabel.Text = "id:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Location = New System.Drawing.Point(65, 98)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(39, 13)
        MarcaLabel.TabIndex = 2
        MarcaLabel.Text = "marca:"
        '
        'ButtonSeguinte
        '
        Me.ButtonSeguinte.Location = New System.Drawing.Point(131, 348)
        Me.ButtonSeguinte.Name = "ButtonSeguinte"
        Me.ButtonSeguinte.Size = New System.Drawing.Size(93, 33)
        Me.ButtonSeguinte.TabIndex = 41
        Me.ButtonSeguinte.Text = "Seguinte"
        Me.ButtonSeguinte.UseVisualStyleBackColor = True
        '
        'ButtonSair
        '
        Me.ButtonSair.Location = New System.Drawing.Point(687, 348)
        Me.ButtonSair.Name = "ButtonSair"
        Me.ButtonSair.Size = New System.Drawing.Size(93, 33)
        Me.ButtonSair.TabIndex = 40
        Me.ButtonSair.Text = "Sair"
        Me.ButtonSair.UseVisualStyleBackColor = True
        '
        'ButtonFechar
        '
        Me.ButtonFechar.Location = New System.Drawing.Point(578, 348)
        Me.ButtonFechar.Name = "ButtonFechar"
        Me.ButtonFechar.Size = New System.Drawing.Size(93, 33)
        Me.ButtonFechar.TabIndex = 39
        Me.ButtonFechar.Text = "Fechar"
        Me.ButtonFechar.UseVisualStyleBackColor = True
        '
        'ButtonGravar
        '
        Me.ButtonGravar.Location = New System.Drawing.Point(352, 348)
        Me.ButtonGravar.Name = "ButtonGravar"
        Me.ButtonGravar.Size = New System.Drawing.Size(93, 33)
        Me.ButtonGravar.TabIndex = 38
        Me.ButtonGravar.Text = "Gravar"
        Me.ButtonGravar.UseVisualStyleBackColor = True
        '
        'ButtonRemover
        '
        Me.ButtonRemover.Location = New System.Drawing.Point(463, 348)
        Me.ButtonRemover.Name = "ButtonRemover"
        Me.ButtonRemover.Size = New System.Drawing.Size(93, 33)
        Me.ButtonRemover.TabIndex = 37
        Me.ButtonRemover.Text = "Remover"
        Me.ButtonRemover.UseVisualStyleBackColor = True
        '
        'ButtonNovo
        '
        Me.ButtonNovo.Location = New System.Drawing.Point(242, 348)
        Me.ButtonNovo.Name = "ButtonNovo"
        Me.ButtonNovo.Size = New System.Drawing.Size(93, 33)
        Me.ButtonNovo.TabIndex = 36
        Me.ButtonNovo.Text = "Novo"
        Me.ButtonNovo.UseVisualStyleBackColor = True
        '
        'ButtonAnterior
        '
        Me.ButtonAnterior.Location = New System.Drawing.Point(20, 348)
        Me.ButtonAnterior.Name = "ButtonAnterior"
        Me.ButtonAnterior.Size = New System.Drawing.Size(93, 33)
        Me.ButtonAnterior.TabIndex = 35
        Me.ButtonAnterior.Text = "Anterior"
        Me.ButtonAnterior.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(382, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Marcas"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Khaki
        Me.GroupBox1.Controls.Add(IdLabel)
        Me.GroupBox1.Controls.Add(Me.IdTextBox)
        Me.GroupBox1.Controls.Add(MarcaLabel)
        Me.GroupBox1.Controls.Add(Me.MarcaTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(242, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 180)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "marcas carros"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MARCASBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(110, 69)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 1
        '
        'MARCASBindingSource
        '
        Me.MARCASBindingSource.DataMember = "MARCAS"
        Me.MARCASBindingSource.DataSource = Me.TransportesDataSet
        '
        'TransportesDataSet
        '
        Me.TransportesDataSet.DataSetName = "transportesDataSet"
        Me.TransportesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MARCASBindingSource, "marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(110, 95)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MarcaTextBox.TabIndex = 3
        '
        'MARCASBindingNavigator
        '
        Me.MARCASBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MARCASBindingNavigator.BindingSource = Me.MARCASBindingSource
        Me.MARCASBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MARCASBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MARCASBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MARCASBindingNavigatorSaveItem})
        Me.MARCASBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MARCASBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MARCASBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MARCASBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MARCASBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MARCASBindingNavigator.Name = "MARCASBindingNavigator"
        Me.MARCASBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MARCASBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.MARCASBindingNavigator.TabIndex = 42
        Me.MARCASBindingNavigator.Text = "BindingNavigator1"
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
        'MARCASBindingNavigatorSaveItem
        '
        Me.MARCASBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MARCASBindingNavigatorSaveItem.Image = CType(resources.GetObject("MARCASBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MARCASBindingNavigatorSaveItem.Name = "MARCASBindingNavigatorSaveItem"
        Me.MARCASBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MARCASBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'MARCASTableAdapter
        '
        Me.MARCASTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CARROSTableAdapter = Nothing
        Me.TableAdapterManager.COMBUSTIVEISTableAdapter = Nothing
        Me.TableAdapterManager.MARCASTableAdapter = Me.MARCASTableAdapter
        Me.TableAdapterManager.REVISOESTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = OFICINA_PROG.transportesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MARCASBindingNavigator)
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
        CType(Me.MARCASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransportesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MARCASBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MARCASBindingNavigator.ResumeLayout(False)
        Me.MARCASBindingNavigator.PerformLayout()
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
    Friend WithEvents MARCASBindingSource As BindingSource
    Friend WithEvents MARCASTableAdapter As transportesDataSetTableAdapters.MARCASTableAdapter
    Friend WithEvents TableAdapterManager As transportesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MARCASBindingNavigator As BindingNavigator
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
    Friend WithEvents MARCASBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents MarcaTextBox As TextBox
End Class
