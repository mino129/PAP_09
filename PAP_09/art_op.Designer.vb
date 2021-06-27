<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class art_op
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
        Dim ID_CatLabel As System.Windows.Forms.Label
        Dim ID_FornLabel As System.Windows.Forms.Label
        Dim ID_ArtLabel As System.Windows.Forms.Label
        Dim DescricaoLabel As System.Windows.Forms.Label
        Dim SKU_EAN13Label As System.Windows.Forms.Label
        Dim PreçoLabel As System.Windows.Forms.Label
        Dim Quant_p_cxLabel As System.Windows.Forms.Label
        Dim Stock_existLabel As System.Windows.Forms.Label
        Dim AlturaLabel As System.Windows.Forms.Label
        Dim LarguraLabel As System.Windows.Forms.Label
        Dim Referencia_internaLabel As System.Windows.Forms.Label
        Dim Informacoes_adLabel As System.Windows.Forms.Label
        Dim Material_fabLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Data_modLabel As System.Windows.Forms.Label
        Dim Id_armLabel As System.Windows.Forms.Label
        Dim Preco_custoLabel As System.Windows.Forms.Label
        Me.Search = New System.Windows.Forms.Button()
        Me.deletelayer = New System.Windows.Forms.Button()
        Me.Insert = New System.Windows.Forms.Button()
        Me.alter = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.update = New System.Windows.Forms.Button()
        Me.updatetext = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.deleteid = New System.Windows.Forms.Button()
        Me.txtdelete = New System.Windows.Forms.RichTextBox()
        Me.endsearch = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.id_arm = New System.Windows.Forms.ComboBox()
        Me.ArmazensBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Art_esp_dbDataSet = New PAP_09.art_esp_dbDataSet()
        Me.Data_modDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Art_gest_stockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Informacoes_adTextBox = New System.Windows.Forms.RichTextBox()
        Me.AlturaTextBox = New System.Windows.Forms.TextBox()
        Me.Art_espBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_FornTextBox = New System.Windows.Forms.ComboBox()
        Me.FornecedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_papDataSet = New PAP_09.db_papDataSet()
        Me.Preco_custoTextBox = New System.Windows.Forms.TextBox()
        Me.LarguraTextBox = New System.Windows.Forms.TextBox()
        Me.ID_CatTextBox = New System.Windows.Forms.ComboBox()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_ArtTextBox = New System.Windows.Forms.TextBox()
        Me.ArtigosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Referencia_internaTextBox = New System.Windows.Forms.TextBox()
        Me.DescricaoTextBox = New System.Windows.Forms.TextBox()
        Me.Material_fabTextBox = New System.Windows.Forms.TextBox()
        Me.Stock_existTextBox = New System.Windows.Forms.TextBox()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.SKU_EAN13TextBox = New System.Windows.Forms.TextBox()
        Me.Quant_p_cxTextBox = New System.Windows.Forms.TextBox()
        Me.PreçoTextBox = New System.Windows.Forms.TextBox()
        Me.save = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.numreg = New System.Windows.Forms.TextBox()
        Me.ArtigosTableAdapter = New PAP_09.db_papDataSetTableAdapters.ArtigosTableAdapter()
        Me.TableAdapterManager = New PAP_09.db_papDataSetTableAdapters.TableAdapterManager()
        Me.FornecedorTableAdapter = New PAP_09.db_papDataSetTableAdapters.FornecedorTableAdapter()
        Me.CategoriaTableAdapter = New PAP_09.db_papDataSetTableAdapters.CategoriaTableAdapter()
        Me.Art_espTableAdapter = New PAP_09.art_esp_dbDataSetTableAdapters.art_espTableAdapter()
        Me.TableAdapterManager1 = New PAP_09.art_esp_dbDataSetTableAdapters.TableAdapterManager()
        Me.Art_gest_stockTableAdapter = New PAP_09.art_esp_dbDataSetTableAdapters.art_gest_stockTableAdapter()
        Me.In_quantTextBox = New System.Windows.Forms.TextBox()
        Me.Out_quantTextBox = New System.Windows.Forms.TextBox()
        Me.ArmazensTableAdapter = New PAP_09.art_esp_dbDataSetTableAdapters.armazensTableAdapter()
        ID_CatLabel = New System.Windows.Forms.Label()
        ID_FornLabel = New System.Windows.Forms.Label()
        ID_ArtLabel = New System.Windows.Forms.Label()
        DescricaoLabel = New System.Windows.Forms.Label()
        SKU_EAN13Label = New System.Windows.Forms.Label()
        PreçoLabel = New System.Windows.Forms.Label()
        Quant_p_cxLabel = New System.Windows.Forms.Label()
        Stock_existLabel = New System.Windows.Forms.Label()
        AlturaLabel = New System.Windows.Forms.Label()
        LarguraLabel = New System.Windows.Forms.Label()
        Referencia_internaLabel = New System.Windows.Forms.Label()
        Informacoes_adLabel = New System.Windows.Forms.Label()
        Material_fabLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Data_modLabel = New System.Windows.Forms.Label()
        Id_armLabel = New System.Windows.Forms.Label()
        Preco_custoLabel = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ArmazensBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Art_esp_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Art_gest_stockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Art_espBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FornecedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_papDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtigosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_CatLabel
        '
        ID_CatLabel.AutoSize = True
        ID_CatLabel.Location = New System.Drawing.Point(10, 215)
        ID_CatLabel.Name = "ID_CatLabel"
        ID_CatLabel.Size = New System.Drawing.Size(55, 13)
        ID_CatLabel.TabIndex = 70
        ID_CatLabel.Text = "Categoria:"
        '
        'ID_FornLabel
        '
        ID_FornLabel.AutoSize = True
        ID_FornLabel.Location = New System.Drawing.Point(9, 188)
        ID_FornLabel.Name = "ID_FornLabel"
        ID_FornLabel.Size = New System.Drawing.Size(64, 13)
        ID_FornLabel.TabIndex = 13
        ID_FornLabel.Text = "Fornecedor:"
        '
        'ID_ArtLabel
        '
        ID_ArtLabel.AutoSize = True
        ID_ArtLabel.Location = New System.Drawing.Point(13, 28)
        ID_ArtLabel.Name = "ID_ArtLabel"
        ID_ArtLabel.Size = New System.Drawing.Size(37, 13)
        ID_ArtLabel.TabIndex = 82
        ID_ArtLabel.Text = "ID Art:"
        '
        'DescricaoLabel
        '
        DescricaoLabel.AutoSize = True
        DescricaoLabel.Location = New System.Drawing.Point(13, 54)
        DescricaoLabel.Name = "DescricaoLabel"
        DescricaoLabel.Size = New System.Drawing.Size(58, 13)
        DescricaoLabel.TabIndex = 84
        DescricaoLabel.Text = "Descricao:"
        '
        'SKU_EAN13Label
        '
        SKU_EAN13Label.AutoSize = True
        SKU_EAN13Label.Location = New System.Drawing.Point(13, 80)
        SKU_EAN13Label.Name = "SKU_EAN13Label"
        SKU_EAN13Label.Size = New System.Drawing.Size(71, 13)
        SKU_EAN13Label.TabIndex = 86
        SKU_EAN13Label.Text = "SKU/EAN13:"
        '
        'PreçoLabel
        '
        PreçoLabel.AutoSize = True
        PreçoLabel.Location = New System.Drawing.Point(13, 106)
        PreçoLabel.Name = "PreçoLabel"
        PreçoLabel.Size = New System.Drawing.Size(38, 13)
        PreçoLabel.TabIndex = 88
        PreçoLabel.Text = "Preço:"
        '
        'Quant_p_cxLabel
        '
        Quant_p_cxLabel.AutoSize = True
        Quant_p_cxLabel.Location = New System.Drawing.Point(1, 132)
        Quant_p_cxLabel.Name = "Quant_p_cxLabel"
        Quant_p_cxLabel.Size = New System.Drawing.Size(83, 13)
        Quant_p_cxLabel.TabIndex = 90
        Quant_p_cxLabel.Text = "Quant P/ Caixa:"
        '
        'Stock_existLabel
        '
        Stock_existLabel.AutoSize = True
        Stock_existLabel.Location = New System.Drawing.Point(13, 158)
        Stock_existLabel.Name = "Stock_existLabel"
        Stock_existLabel.Size = New System.Drawing.Size(62, 13)
        Stock_existLabel.TabIndex = 92
        Stock_existLabel.Text = "Stock exist:"
        '
        'AlturaLabel
        '
        AlturaLabel.AutoSize = True
        AlturaLabel.Location = New System.Drawing.Point(13, 238)
        AlturaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        AlturaLabel.Name = "AlturaLabel"
        AlturaLabel.Size = New System.Drawing.Size(37, 13)
        AlturaLabel.TabIndex = 84
        AlturaLabel.Text = "Altura:"
        '
        'LarguraLabel
        '
        LarguraLabel.AutoSize = True
        LarguraLabel.Location = New System.Drawing.Point(13, 257)
        LarguraLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        LarguraLabel.Name = "LarguraLabel"
        LarguraLabel.Size = New System.Drawing.Size(46, 13)
        LarguraLabel.TabIndex = 86
        LarguraLabel.Text = "Largura:"
        '
        'Referencia_internaLabel
        '
        Referencia_internaLabel.AutoSize = True
        Referencia_internaLabel.Location = New System.Drawing.Point(0, 278)
        Referencia_internaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Referencia_internaLabel.Name = "Referencia_internaLabel"
        Referencia_internaLabel.Size = New System.Drawing.Size(66, 13)
        Referencia_internaLabel.TabIndex = 88
        Referencia_internaLabel.Text = "Ref. Interna:"
        '
        'Informacoes_adLabel
        '
        Informacoes_adLabel.AutoSize = True
        Informacoes_adLabel.Location = New System.Drawing.Point(4, 312)
        Informacoes_adLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Informacoes_adLabel.Name = "Informacoes_adLabel"
        Informacoes_adLabel.Size = New System.Drawing.Size(75, 13)
        Informacoes_adLabel.TabIndex = 90
        Informacoes_adLabel.Text = "Inf. adicionais:"
        '
        'Material_fabLabel
        '
        Material_fabLabel.AutoSize = True
        Material_fabLabel.Location = New System.Drawing.Point(10, 347)
        Material_fabLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Material_fabLabel.Name = "Material_fabLabel"
        Material_fabLabel.Size = New System.Drawing.Size(47, 13)
        Material_fabLabel.TabIndex = 92
        Material_fabLabel.Text = "Material:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Location = New System.Drawing.Point(11, 365)
        MarcaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(40, 13)
        MarcaLabel.TabIndex = 94
        MarcaLabel.Text = "Marca:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(2, 71)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(37, 13)
        Label1.TabIndex = 83
        Label1.Text = "ID Art:"
        '
        'Data_modLabel
        '
        Data_modLabel.AutoSize = True
        Data_modLabel.Location = New System.Drawing.Point(10, 424)
        Data_modLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Data_modLabel.Name = "Data_modLabel"
        Data_modLabel.Size = New System.Drawing.Size(64, 13)
        Data_modLabel.TabIndex = 86
        Data_modLabel.Text = "Inserido em:"
        '
        'Id_armLabel
        '
        Id_armLabel.AutoSize = True
        Id_armLabel.Location = New System.Drawing.Point(10, 384)
        Id_armLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Id_armLabel.Name = "Id_armLabel"
        Id_armLabel.Size = New System.Drawing.Size(53, 13)
        Id_armLabel.TabIndex = 92
        Id_armLabel.Text = "Armazem:"
        '
        'Preco_custoLabel
        '
        Preco_custoLabel.AutoSize = True
        Preco_custoLabel.Location = New System.Drawing.Point(10, 405)
        Preco_custoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Preco_custoLabel.Name = "Preco_custoLabel"
        Preco_custoLabel.Size = New System.Drawing.Size(68, 13)
        Preco_custoLabel.TabIndex = 96
        Preco_custoLabel.Text = "Preco Custo:"
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(596, 8)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(232, 53)
        Me.Search.TabIndex = 82
        Me.Search.Text = "Alterar/ Procurar"
        Me.Search.UseVisualStyleBackColor = True
        '
        'deletelayer
        '
        Me.deletelayer.Location = New System.Drawing.Point(310, 8)
        Me.deletelayer.Name = "deletelayer"
        Me.deletelayer.Size = New System.Drawing.Size(245, 53)
        Me.deletelayer.TabIndex = 81
        Me.deletelayer.Text = "Apagar"
        Me.deletelayer.UseVisualStyleBackColor = True
        '
        'Insert
        '
        Me.Insert.Location = New System.Drawing.Point(7, 8)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(282, 53)
        Me.Insert.TabIndex = 80
        Me.Insert.Text = "Inserir"
        Me.Insert.UseVisualStyleBackColor = True
        '
        'alter
        '
        Me.alter.Location = New System.Drawing.Point(6, 567)
        Me.alter.Name = "alter"
        Me.alter.Size = New System.Drawing.Size(75, 23)
        Me.alter.TabIndex = 79
        Me.alter.Text = "Alterar"
        Me.alter.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Label1)
        Me.GroupBox3.Controls.Add(Me.update)
        Me.GroupBox3.Controls.Add(Me.updatetext)
        Me.GroupBox3.Location = New System.Drawing.Point(596, 85)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(272, 157)
        Me.GroupBox3.TabIndex = 78
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Atualizar"
        '
        'update
        '
        Me.update.Location = New System.Drawing.Point(149, 66)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(117, 23)
        Me.update.TabIndex = 32
        Me.update.Text = "Atualizar Dados"
        Me.update.UseVisualStyleBackColor = True
        '
        'updatetext
        '
        Me.updatetext.Location = New System.Drawing.Point(43, 68)
        Me.updatetext.Name = "updatetext"
        Me.updatetext.Size = New System.Drawing.Size(100, 20)
        Me.updatetext.TabIndex = 33
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.deleteid)
        Me.GroupBox2.Controls.Add(Me.txtdelete)
        Me.GroupBox2.Location = New System.Drawing.Point(296, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(271, 105)
        Me.GroupBox2.TabIndex = 77
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Apagar"
        '
        'deleteid
        '
        Me.deleteid.Location = New System.Drawing.Point(132, 30)
        Me.deleteid.Name = "deleteid"
        Me.deleteid.Size = New System.Drawing.Size(117, 49)
        Me.deleteid.TabIndex = 31
        Me.deleteid.Text = "Apagar p/ ID"
        Me.deleteid.UseVisualStyleBackColor = True
        '
        'txtdelete
        '
        Me.txtdelete.Location = New System.Drawing.Point(9, 30)
        Me.txtdelete.Name = "txtdelete"
        Me.txtdelete.Size = New System.Drawing.Size(100, 58)
        Me.txtdelete.TabIndex = 34
        Me.txtdelete.Text = ""
        '
        'endsearch
        '
        Me.endsearch.Location = New System.Drawing.Point(92, 535)
        Me.endsearch.Name = "endsearch"
        Me.endsearch.Size = New System.Drawing.Size(75, 24)
        Me.endsearch.TabIndex = 76
        Me.endsearch.Text = "Concluir"
        Me.endsearch.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Data_modLabel)
        Me.GroupBox1.Controls.Add(Me.id_arm)
        Me.GroupBox1.Controls.Add(Me.Data_modDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.Informacoes_adTextBox)
        Me.GroupBox1.Controls.Add(AlturaLabel)
        Me.GroupBox1.Controls.Add(Me.AlturaTextBox)
        Me.GroupBox1.Controls.Add(Me.ID_FornTextBox)
        Me.GroupBox1.Controls.Add(Id_armLabel)
        Me.GroupBox1.Controls.Add(LarguraLabel)
        Me.GroupBox1.Controls.Add(Preco_custoLabel)
        Me.GroupBox1.Controls.Add(ID_ArtLabel)
        Me.GroupBox1.Controls.Add(Me.Preco_custoTextBox)
        Me.GroupBox1.Controls.Add(Me.LarguraTextBox)
        Me.GroupBox1.Controls.Add(Me.ID_CatTextBox)
        Me.GroupBox1.Controls.Add(Referencia_internaLabel)
        Me.GroupBox1.Controls.Add(Me.ID_ArtTextBox)
        Me.GroupBox1.Controls.Add(Me.Referencia_internaTextBox)
        Me.GroupBox1.Controls.Add(ID_CatLabel)
        Me.GroupBox1.Controls.Add(Informacoes_adLabel)
        Me.GroupBox1.Controls.Add(DescricaoLabel)
        Me.GroupBox1.Controls.Add(Me.DescricaoTextBox)
        Me.GroupBox1.Controls.Add(Material_fabLabel)
        Me.GroupBox1.Controls.Add(ID_FornLabel)
        Me.GroupBox1.Controls.Add(Me.Material_fabTextBox)
        Me.GroupBox1.Controls.Add(SKU_EAN13Label)
        Me.GroupBox1.Controls.Add(MarcaLabel)
        Me.GroupBox1.Controls.Add(Me.Stock_existTextBox)
        Me.GroupBox1.Controls.Add(Me.MarcaTextBox)
        Me.GroupBox1.Controls.Add(Me.SKU_EAN13TextBox)
        Me.GroupBox1.Controls.Add(Stock_existLabel)
        Me.GroupBox1.Controls.Add(PreçoLabel)
        Me.GroupBox1.Controls.Add(Me.Quant_p_cxTextBox)
        Me.GroupBox1.Controls.Add(Me.PreçoTextBox)
        Me.GroupBox1.Controls.Add(Quant_p_cxLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 454)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados"
        '
        'id_arm
        '
        Me.id_arm.DataSource = Me.ArmazensBindingSource
        Me.id_arm.DisplayMember = "Outros"
        Me.id_arm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.id_arm.FormattingEnabled = True
        Me.id_arm.Location = New System.Drawing.Point(90, 383)
        Me.id_arm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.id_arm.Name = "id_arm"
        Me.id_arm.Size = New System.Drawing.Size(178, 21)
        Me.id_arm.TabIndex = 98
        Me.id_arm.ValueMember = "id_arm"
        '
        'ArmazensBindingSource
        '
        Me.ArmazensBindingSource.DataMember = "armazens"
        Me.ArmazensBindingSource.DataSource = Me.Art_esp_dbDataSet
        '
        'Art_esp_dbDataSet
        '
        Me.Art_esp_dbDataSet.DataSetName = "art_esp_dbDataSet"
        Me.Art_esp_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Data_modDateTimePicker
        '
        Me.Data_modDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Art_gest_stockBindingSource, "data_mod", True))
        Me.Data_modDateTimePicker.Location = New System.Drawing.Point(90, 422)
        Me.Data_modDateTimePicker.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Data_modDateTimePicker.Name = "Data_modDateTimePicker"
        Me.Data_modDateTimePicker.Size = New System.Drawing.Size(178, 20)
        Me.Data_modDateTimePicker.TabIndex = 87
        '
        'Art_gest_stockBindingSource
        '
        Me.Art_gest_stockBindingSource.DataMember = "art_gest_stock"
        Me.Art_gest_stockBindingSource.DataSource = Me.Art_esp_dbDataSet
        '
        'Informacoes_adTextBox
        '
        Me.Informacoes_adTextBox.Location = New System.Drawing.Point(90, 296)
        Me.Informacoes_adTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Informacoes_adTextBox.Name = "Informacoes_adTextBox"
        Me.Informacoes_adTextBox.Size = New System.Drawing.Size(175, 47)
        Me.Informacoes_adTextBox.TabIndex = 83
        Me.Informacoes_adTextBox.Text = ""
        '
        'AlturaTextBox
        '
        Me.AlturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Art_espBindingSource, "Altura", True))
        Me.AlturaTextBox.Location = New System.Drawing.Point(90, 237)
        Me.AlturaTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AlturaTextBox.Name = "AlturaTextBox"
        Me.AlturaTextBox.Size = New System.Drawing.Size(175, 20)
        Me.AlturaTextBox.TabIndex = 85
        '
        'Art_espBindingSource
        '
        Me.Art_espBindingSource.DataMember = "art_esp"
        Me.Art_espBindingSource.DataSource = Me.Art_esp_dbDataSet
        '
        'ID_FornTextBox
        '
        Me.ID_FornTextBox.DataSource = Me.FornecedorBindingSource
        Me.ID_FornTextBox.DisplayMember = "Nome"
        Me.ID_FornTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ID_FornTextBox.FormattingEnabled = True
        Me.ID_FornTextBox.Location = New System.Drawing.Point(90, 187)
        Me.ID_FornTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ID_FornTextBox.Name = "ID_FornTextBox"
        Me.ID_FornTextBox.Size = New System.Drawing.Size(175, 21)
        Me.ID_FornTextBox.TabIndex = 83
        Me.ID_FornTextBox.ValueMember = "ID_Forn"
        '
        'FornecedorBindingSource
        '
        Me.FornecedorBindingSource.DataMember = "Fornecedor"
        Me.FornecedorBindingSource.DataSource = Me.Db_papDataSet
        '
        'Db_papDataSet
        '
        Me.Db_papDataSet.DataSetName = "db_papDataSet"
        Me.Db_papDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Preco_custoTextBox
        '
        Me.Preco_custoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Art_gest_stockBindingSource, "preco_custo", True))
        Me.Preco_custoTextBox.Location = New System.Drawing.Point(90, 403)
        Me.Preco_custoTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Preco_custoTextBox.Name = "Preco_custoTextBox"
        Me.Preco_custoTextBox.Size = New System.Drawing.Size(178, 20)
        Me.Preco_custoTextBox.TabIndex = 97
        '
        'LarguraTextBox
        '
        Me.LarguraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Art_espBindingSource, "Largura", True))
        Me.LarguraTextBox.Location = New System.Drawing.Point(90, 256)
        Me.LarguraTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LarguraTextBox.Name = "LarguraTextBox"
        Me.LarguraTextBox.Size = New System.Drawing.Size(175, 20)
        Me.LarguraTextBox.TabIndex = 87
        '
        'ID_CatTextBox
        '
        Me.ID_CatTextBox.DataSource = Me.CategoriaBindingSource
        Me.ID_CatTextBox.DisplayMember = "Descricao"
        Me.ID_CatTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ID_CatTextBox.FormattingEnabled = True
        Me.ID_CatTextBox.Location = New System.Drawing.Point(90, 212)
        Me.ID_CatTextBox.Name = "ID_CatTextBox"
        Me.ID_CatTextBox.Size = New System.Drawing.Size(175, 21)
        Me.ID_CatTextBox.TabIndex = 71
        Me.ID_CatTextBox.ValueMember = "ID_Cat"
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "Categoria"
        Me.CategoriaBindingSource.DataSource = Me.Db_papDataSet
        '
        'ID_ArtTextBox
        '
        Me.ID_ArtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtigosBindingSource, "ID_Art", True))
        Me.ID_ArtTextBox.Location = New System.Drawing.Point(90, 25)
        Me.ID_ArtTextBox.Name = "ID_ArtTextBox"
        Me.ID_ArtTextBox.Size = New System.Drawing.Size(175, 20)
        Me.ID_ArtTextBox.TabIndex = 83
        '
        'ArtigosBindingSource
        '
        Me.ArtigosBindingSource.DataMember = "Artigos"
        Me.ArtigosBindingSource.DataSource = Me.Db_papDataSet
        '
        'Referencia_internaTextBox
        '
        Me.Referencia_internaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Art_espBindingSource, "referencia_interna", True))
        Me.Referencia_internaTextBox.Location = New System.Drawing.Point(90, 275)
        Me.Referencia_internaTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Referencia_internaTextBox.Name = "Referencia_internaTextBox"
        Me.Referencia_internaTextBox.Size = New System.Drawing.Size(175, 20)
        Me.Referencia_internaTextBox.TabIndex = 89
        '
        'DescricaoTextBox
        '
        Me.DescricaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtigosBindingSource, "Descricao", True))
        Me.DescricaoTextBox.Location = New System.Drawing.Point(90, 51)
        Me.DescricaoTextBox.Name = "DescricaoTextBox"
        Me.DescricaoTextBox.Size = New System.Drawing.Size(175, 20)
        Me.DescricaoTextBox.TabIndex = 85
        '
        'Material_fabTextBox
        '
        Me.Material_fabTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Art_espBindingSource, "material_fab", True))
        Me.Material_fabTextBox.Location = New System.Drawing.Point(90, 344)
        Me.Material_fabTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Material_fabTextBox.Name = "Material_fabTextBox"
        Me.Material_fabTextBox.Size = New System.Drawing.Size(175, 20)
        Me.Material_fabTextBox.TabIndex = 93
        '
        'Stock_existTextBox
        '
        Me.Stock_existTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtigosBindingSource, "Stock_exist", True))
        Me.Stock_existTextBox.Location = New System.Drawing.Point(90, 155)
        Me.Stock_existTextBox.Name = "Stock_existTextBox"
        Me.Stock_existTextBox.Size = New System.Drawing.Size(175, 20)
        Me.Stock_existTextBox.TabIndex = 93
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Art_espBindingSource, "Marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(90, 363)
        Me.MarcaTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(178, 20)
        Me.MarcaTextBox.TabIndex = 95
        '
        'SKU_EAN13TextBox
        '
        Me.SKU_EAN13TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtigosBindingSource, "SKU/EAN13", True))
        Me.SKU_EAN13TextBox.Location = New System.Drawing.Point(90, 77)
        Me.SKU_EAN13TextBox.Name = "SKU_EAN13TextBox"
        Me.SKU_EAN13TextBox.Size = New System.Drawing.Size(175, 20)
        Me.SKU_EAN13TextBox.TabIndex = 87
        '
        'Quant_p_cxTextBox
        '
        Me.Quant_p_cxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtigosBindingSource, "Quant_p_cx", True))
        Me.Quant_p_cxTextBox.Location = New System.Drawing.Point(90, 132)
        Me.Quant_p_cxTextBox.Name = "Quant_p_cxTextBox"
        Me.Quant_p_cxTextBox.Size = New System.Drawing.Size(175, 20)
        Me.Quant_p_cxTextBox.TabIndex = 91
        '
        'PreçoTextBox
        '
        Me.PreçoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtigosBindingSource, "Preço", True))
        Me.PreçoTextBox.Location = New System.Drawing.Point(90, 103)
        Me.PreçoTextBox.Name = "PreçoTextBox"
        Me.PreçoTextBox.Size = New System.Drawing.Size(175, 20)
        Me.PreçoTextBox.TabIndex = 89
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(7, 538)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(75, 23)
        Me.save.TabIndex = 73
        Me.save.Text = "Inserir"
        Me.save.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 623)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 72
        Me.Button1.Text = "Limpar CX"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'numreg
        '
        Me.numreg.Location = New System.Drawing.Point(3, 652)
        Me.numreg.Name = "numreg"
        Me.numreg.ReadOnly = True
        Me.numreg.Size = New System.Drawing.Size(219, 20)
        Me.numreg.TabIndex = 71
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
        'FornecedorTableAdapter
        '
        Me.FornecedorTableAdapter.ClearBeforeFill = True
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'Art_espTableAdapter
        '
        Me.Art_espTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.armazensTableAdapter = Nothing
        Me.TableAdapterManager1.art_espTableAdapter = Me.Art_espTableAdapter
        Me.TableAdapterManager1.art_gest_stockTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.UpdateOrder = PAP_09.art_esp_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Art_gest_stockTableAdapter
        '
        Me.Art_gest_stockTableAdapter.ClearBeforeFill = True
        '
        'In_quantTextBox
        '
        Me.In_quantTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Art_gest_stockBindingSource, "in_quant", True))
        Me.In_quantTextBox.Location = New System.Drawing.Point(484, 334)
        Me.In_quantTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.In_quantTextBox.Name = "In_quantTextBox"
        Me.In_quantTextBox.Size = New System.Drawing.Size(102, 20)
        Me.In_quantTextBox.TabIndex = 89
        Me.In_quantTextBox.Visible = False
        '
        'Out_quantTextBox
        '
        Me.Out_quantTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Art_gest_stockBindingSource, "out_quant", True))
        Me.Out_quantTextBox.Location = New System.Drawing.Point(484, 353)
        Me.Out_quantTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Out_quantTextBox.Name = "Out_quantTextBox"
        Me.Out_quantTextBox.Size = New System.Drawing.Size(102, 20)
        Me.Out_quantTextBox.TabIndex = 91
        Me.Out_quantTextBox.Visible = False
        '
        'ArmazensTableAdapter
        '
        Me.ArmazensTableAdapter.ClearBeforeFill = True
        '
        'art_op
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 650)
        Me.Controls.Add(Me.In_quantTextBox)
        Me.Controls.Add(Me.Out_quantTextBox)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.deletelayer)
        Me.Controls.Add(Me.Insert)
        Me.Controls.Add(Me.alter)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.endsearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.numreg)
        Me.Name = "art_op"
        Me.Text = "Artigos"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ArmazensBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Art_esp_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Art_gest_stockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Art_espBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FornecedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_papDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtigosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Search As System.Windows.Forms.Button
    Friend WithEvents deletelayer As System.Windows.Forms.Button
    Friend WithEvents Insert As System.Windows.Forms.Button
    Friend WithEvents alter As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents update As System.Windows.Forms.Button
    Friend WithEvents updatetext As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents deleteid As System.Windows.Forms.Button
    Friend WithEvents txtdelete As System.Windows.Forms.RichTextBox
    Friend WithEvents endsearch As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ID_CatTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents numreg As System.Windows.Forms.TextBox
    Friend WithEvents Db_papDataSet As PAP_09.db_papDataSet
    Friend WithEvents ArtigosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArtigosTableAdapter As PAP_09.db_papDataSetTableAdapters.ArtigosTableAdapter
    Friend WithEvents TableAdapterManager As PAP_09.db_papDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FornecedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FornecedorTableAdapter As PAP_09.db_papDataSetTableAdapters.FornecedorTableAdapter
    Friend WithEvents CategoriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriaTableAdapter As PAP_09.db_papDataSetTableAdapters.CategoriaTableAdapter
    Friend WithEvents ID_ArtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescricaoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Stock_existTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SKU_EAN13TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Quant_p_cxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PreçoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_FornTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents Art_esp_dbDataSet As PAP_09.art_esp_dbDataSet
    Friend WithEvents Art_espBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Art_espTableAdapter As PAP_09.art_esp_dbDataSetTableAdapters.art_espTableAdapter
    Friend WithEvents TableAdapterManager1 As PAP_09.art_esp_dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Informacoes_adTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents AlturaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LarguraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Referencia_internaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Material_fabTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MarcaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Art_gest_stockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Art_gest_stockTableAdapter As PAP_09.art_esp_dbDataSetTableAdapters.art_gest_stockTableAdapter
    Friend WithEvents Data_modDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents In_quantTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Preco_custoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Out_quantTextBox As System.Windows.Forms.TextBox
    Friend WithEvents id_arm As System.Windows.Forms.ComboBox
    Friend WithEvents ArmazensBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArmazensTableAdapter As PAP_09.art_esp_dbDataSetTableAdapters.armazensTableAdapter
End Class
