<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class geststock
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ID_ArtLabel As System.Windows.Forms.Label
        Dim Stock_existLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Data_modLabel As System.Windows.Forms.Label
        Dim Id_armLabel As System.Windows.Forms.Label
        Dim ApontamentosLabel As System.Windows.Forms.Label
        Me.Db_papDataSet = New PAP_09.db_papDataSet()
        Me.ArtigosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArtigosTableAdapter = New PAP_09.db_papDataSetTableAdapters.ArtigosTableAdapter()
        Me.TableAdapterManager = New PAP_09.db_papDataSetTableAdapters.TableAdapterManager()
        Me.Stock_existTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Art_esp_dbDataSet = New PAP_09.art_esp_dbDataSet()
        Me.Art_gest_stockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Art_gest_stockTableAdapter = New PAP_09.art_esp_dbDataSetTableAdapters.art_gest_stockTableAdapter()
        Me.TableAdapterManager1 = New PAP_09.art_esp_dbDataSetTableAdapters.TableAdapterManager()
        Me.Data_modDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Art_gest_stockDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ID_ArtTextBox = New System.Windows.Forms.ComboBox()
        Me.Id_armTextBox = New System.Windows.Forms.ComboBox()
        Me.ArmazensBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArmazensTableAdapter = New PAP_09.art_esp_dbDataSetTableAdapters.armazensTableAdapter()
        Me.ApontamentosTextBox = New System.Windows.Forms.RichTextBox()
        ID_ArtLabel = New System.Windows.Forms.Label()
        Stock_existLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Data_modLabel = New System.Windows.Forms.Label()
        Id_armLabel = New System.Windows.Forms.Label()
        ApontamentosLabel = New System.Windows.Forms.Label()
        CType(Me.Db_papDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtigosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Art_esp_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Art_gest_stockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Art_gest_stockDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArmazensBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_ArtLabel
        '
        ID_ArtLabel.AutoSize = True
        ID_ArtLabel.Location = New System.Drawing.Point(18, 48)
        ID_ArtLabel.Name = "ID_ArtLabel"
        ID_ArtLabel.Size = New System.Drawing.Size(71, 25)
        ID_ArtLabel.TabIndex = 1
        ID_ArtLabel.Text = "ID Art:"
        '
        'Stock_existLabel
        '
        Stock_existLabel.AutoSize = True
        Stock_existLabel.Location = New System.Drawing.Point(12, 112)
        Stock_existLabel.Name = "Stock_existLabel"
        Stock_existLabel.Size = New System.Drawing.Size(123, 25)
        Stock_existLabel.TabIndex = 11
        Stock_existLabel.Text = "Stock exist:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(7, 164)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(157, 25)
        Label1.TabIndex = 19
        Label1.Text = "Stock a alterar:"
        '
        'Data_modLabel
        '
        Data_modLabel.AutoSize = True
        Data_modLabel.Location = New System.Drawing.Point(12, 216)
        Data_modLabel.Name = "Data_modLabel"
        Data_modLabel.Size = New System.Drawing.Size(184, 25)
        Data_modLabel.TabIndex = 27
        Data_modLabel.Text = "Data modificaçao:"
        '
        'Id_armLabel
        '
        Id_armLabel.AutoSize = True
        Id_armLabel.Location = New System.Drawing.Point(33, 270)
        Id_armLabel.Name = "Id_armLabel"
        Id_armLabel.Size = New System.Drawing.Size(108, 25)
        Id_armLabel.TabIndex = 41
        Id_armLabel.Text = "Armazem:"
        '
        'ApontamentosLabel
        '
        ApontamentosLabel.AutoSize = True
        ApontamentosLabel.Location = New System.Drawing.Point(1112, 527)
        ApontamentosLabel.Name = "ApontamentosLabel"
        ApontamentosLabel.Size = New System.Drawing.Size(156, 25)
        ApontamentosLabel.TabIndex = 42
        ApontamentosLabel.Text = "Apontamentos:"
        '
        'Db_papDataSet
        '
        Me.Db_papDataSet.DataSetName = "db_papDataSet"
        Me.Db_papDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArtigosBindingSource
        '
        Me.ArtigosBindingSource.DataMember = "Artigos"
        Me.ArtigosBindingSource.DataSource = Me.Db_papDataSet
        '
        'ArtigosTableAdapter
        '
        Me.ArtigosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArtigosTableAdapter = Me.ArtigosTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriaTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.Encomenda_DetalhesTableAdapter = Nothing
        Me.TableAdapterManager.EncomendaTableAdapter = Nothing
        Me.TableAdapterManager.FornecedorTableAdapter = Nothing
        Me.TableAdapterManager.PagamentoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PAP_09.db_papDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Stock_existTextBox
        '
        Me.Stock_existTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtigosBindingSource, "Stock_exist", True))
        Me.Stock_existTextBox.Location = New System.Drawing.Point(152, 109)
        Me.Stock_existTextBox.Name = "Stock_existTextBox"
        Me.Stock_existTextBox.ReadOnly = True
        Me.Stock_existTextBox.Size = New System.Drawing.Size(153, 31)
        Me.Stock_existTextBox.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(17, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(241, 51)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Adicionar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtigosBindingSource, "Stock_exist", True))
        Me.TextBox1.Location = New System.Drawing.Point(170, 158)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(153, 31)
        Me.TextBox1.TabIndex = 20
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(281, 315)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(241, 51)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Apagar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(12, 388)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(827, 104)
        Me.ListBox1.TabIndex = 22
        '
        'Art_esp_dbDataSet
        '
        Me.Art_esp_dbDataSet.DataSetName = "art_esp_dbDataSet"
        Me.Art_esp_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Art_gest_stockBindingSource
        '
        Me.Art_gest_stockBindingSource.DataMember = "art_gest_stock"
        Me.Art_gest_stockBindingSource.DataSource = Me.Art_esp_dbDataSet
        '
        'Art_gest_stockTableAdapter
        '
        Me.Art_gest_stockTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.armazensTableAdapter = Nothing
        Me.TableAdapterManager1.art_espTableAdapter = Nothing
        Me.TableAdapterManager1.art_gest_stockTableAdapter = Me.Art_gest_stockTableAdapter
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.UpdateOrder = PAP_09.art_esp_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Data_modDateTimePicker
        '
        Me.Data_modDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Art_gest_stockBindingSource, "data_mod", True))
        Me.Data_modDateTimePicker.Location = New System.Drawing.Point(202, 216)
        Me.Data_modDateTimePicker.Name = "Data_modDateTimePicker"
        Me.Data_modDateTimePicker.Size = New System.Drawing.Size(200, 31)
        Me.Data_modDateTimePicker.TabIndex = 28
        '
        'Art_gest_stockDataGridView
        '
        Me.Art_gest_stockDataGridView.AutoGenerateColumns = False
        Me.Art_gest_stockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Art_gest_stockDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.Art_gest_stockDataGridView.DataSource = Me.Art_gest_stockBindingSource
        Me.Art_gest_stockDataGridView.Location = New System.Drawing.Point(23, 564)
        Me.Art_gest_stockDataGridView.Name = "Art_gest_stockDataGridView"
        Me.Art_gest_stockDataGridView.RowTemplate.Height = 33
        Me.Art_gest_stockDataGridView.Size = New System.Drawing.Size(1062, 220)
        Me.Art_gest_stockDataGridView.TabIndex = 28
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "id_art"
        Me.DataGridViewTextBoxColumn9.HeaderText = "id_art"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "stock_exist"
        Me.DataGridViewTextBoxColumn10.HeaderText = "stock_exist"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "data_mod"
        Me.DataGridViewTextBoxColumn11.HeaderText = "data_mod"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "in_quant"
        Me.DataGridViewTextBoxColumn12.HeaderText = "in_quant"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "out_quant"
        Me.DataGridViewTextBoxColumn13.HeaderText = "out_quant"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "id_arm"
        Me.DataGridViewTextBoxColumn14.HeaderText = "id_arm"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "apontamentos"
        Me.DataGridViewTextBoxColumn15.HeaderText = "apontamentos"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "preco_custo"
        Me.DataGridViewTextBoxColumn16.HeaderText = "preco_custo"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 527)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 25)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Gestão de stocks:"
        '
        'ID_ArtTextBox
        '
        Me.ID_ArtTextBox.DataSource = Me.ArtigosBindingSource
        Me.ID_ArtTextBox.DisplayMember = "Descricao"
        Me.ID_ArtTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ID_ArtTextBox.FormattingEnabled = True
        Me.ID_ArtTextBox.Location = New System.Drawing.Point(152, 48)
        Me.ID_ArtTextBox.Name = "ID_ArtTextBox"
        Me.ID_ArtTextBox.Size = New System.Drawing.Size(147, 33)
        Me.ID_ArtTextBox.TabIndex = 31
        Me.ID_ArtTextBox.ValueMember = "ID_Art"
        '
        'Id_armTextBox
        '
        Me.Id_armTextBox.DataSource = Me.ArmazensBindingSource
        Me.Id_armTextBox.DisplayMember = "Outros"
        Me.Id_armTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Id_armTextBox.FormattingEnabled = True
        Me.Id_armTextBox.Location = New System.Drawing.Point(202, 270)
        Me.Id_armTextBox.Name = "Id_armTextBox"
        Me.Id_armTextBox.Size = New System.Drawing.Size(200, 33)
        Me.Id_armTextBox.TabIndex = 42
        Me.Id_armTextBox.ValueMember = "id_arm"
        '
        'ArmazensBindingSource
        '
        Me.ArmazensBindingSource.DataMember = "armazens"
        Me.ArmazensBindingSource.DataSource = Me.Art_esp_dbDataSet
        '
        'ArmazensTableAdapter
        '
        Me.ArmazensTableAdapter.ClearBeforeFill = True
        '
        'ApontamentosTextBox
        '
        Me.ApontamentosTextBox.Location = New System.Drawing.Point(1117, 564)
        Me.ApontamentosTextBox.Name = "ApontamentosTextBox"
        Me.ApontamentosTextBox.Size = New System.Drawing.Size(516, 220)
        Me.ApontamentosTextBox.TabIndex = 43
        Me.ApontamentosTextBox.Text = ""
        '
        'geststock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1988, 796)
        Me.Controls.Add(Me.ApontamentosTextBox)
        Me.Controls.Add(ApontamentosLabel)
        Me.Controls.Add(Me.Id_armTextBox)
        Me.Controls.Add(Id_armLabel)
        Me.Controls.Add(Me.ID_ArtTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Art_gest_stockDataGridView)
        Me.Controls.Add(Data_modLabel)
        Me.Controls.Add(Me.Data_modDateTimePicker)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ID_ArtLabel)
        Me.Controls.Add(Stock_existLabel)
        Me.Controls.Add(Me.Stock_existTextBox)
        Me.Name = "geststock"
        Me.Text = "Gestão de Stocks"
        CType(Me.Db_papDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtigosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Art_esp_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Art_gest_stockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Art_gest_stockDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArmazensBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Db_papDataSet As PAP_09.db_papDataSet
    Friend WithEvents ArtigosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArtigosTableAdapter As PAP_09.db_papDataSetTableAdapters.ArtigosTableAdapter
    Friend WithEvents TableAdapterManager As PAP_09.db_papDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Stock_existTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Art_esp_dbDataSet As PAP_09.art_esp_dbDataSet
    Friend WithEvents Art_gest_stockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Art_gest_stockTableAdapter As PAP_09.art_esp_dbDataSetTableAdapters.art_gest_stockTableAdapter
    Friend WithEvents TableAdapterManager1 As PAP_09.art_esp_dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Data_modDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Art_gest_stockDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ID_ArtTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents Id_armTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents ArmazensBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArmazensTableAdapter As PAP_09.art_esp_dbDataSetTableAdapters.armazensTableAdapter
    Friend WithEvents ApontamentosTextBox As System.Windows.Forms.RichTextBox
End Class
