<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class op_encomendasvb
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
        Dim DescontoLabel As System.Windows.Forms.Label
        Dim PreçoLabel As System.Windows.Forms.Label
        Dim QuantLabel As System.Windows.Forms.Label
        Dim ID_ArtLabel As System.Windows.Forms.Label
        Dim ComentariosLabel As System.Windows.Forms.Label
        Dim ID_CliLabel As System.Windows.Forms.Label
        Dim Data_EncLabel As System.Windows.Forms.Label
        Dim Data_EnvioLabel As System.Windows.Forms.Label
        Dim ID_EncLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DescontoTextBox = New System.Windows.Forms.ComboBox()
        Me.PreçoTextBox = New System.Windows.Forms.TextBox()
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.ArtigosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_papDataSet = New PAP_09.db_papDataSet()
        Me.QuantTextBox = New System.Windows.Forms.TextBox()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.txtendpricefalse = New System.Windows.Forms.TextBox()
        Me.endsale = New System.Windows.Forms.Button()
        Me.insertprod = New System.Windows.Forms.Button()
        Me.insert = New System.Windows.Forms.Button()
        Me.comentariostextbox = New System.Windows.Forms.RichTextBox()
        Me.ID_CliTextBox = New System.Windows.Forms.TextBox()
        Me.EncomendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EncomendaTableAdapter = New PAP_09.db_papDataSetTableAdapters.EncomendaTableAdapter()
        Me.TableAdapterManager = New PAP_09.db_papDataSetTableAdapters.TableAdapterManager()
        Me.ArtigosTableAdapter = New PAP_09.db_papDataSetTableAdapters.ArtigosTableAdapter()
        Me.ClientesTableAdapter = New PAP_09.db_papDataSetTableAdapters.ClientesTableAdapter()
        Me.Encomenda_DetalhesTableAdapter = New PAP_09.db_papDataSetTableAdapters.Encomenda_DetalhesTableAdapter()
        Me.PagamentoTableAdapter = New PAP_09.db_papDataSetTableAdapters.PagamentoTableAdapter()
        Me.Data_EncDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Data_EnvioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ID_PagamentoTextBox = New System.Windows.Forms.TextBox()
        Me.Encomenda_DetalhesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pagclick = New System.Windows.Forms.Button()
        Me.ID_EncTextBox = New System.Windows.Forms.TextBox()
        Me.CategoriaTableAdapter = New PAP_09.db_papDataSetTableAdapters.CategoriaTableAdapter()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Art_esp_dbDataSet = New PAP_09.art_esp_dbDataSet()
        Me.Art_gest_stockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Art_gest_stockTableAdapter = New PAP_09.art_esp_dbDataSetTableAdapters.art_gest_stockTableAdapter()
        Me.TableAdapterManager1 = New PAP_09.art_esp_dbDataSetTableAdapters.TableAdapterManager()
        Me.Label2 = New System.Windows.Forms.Label()
        DescontoLabel = New System.Windows.Forms.Label()
        PreçoLabel = New System.Windows.Forms.Label()
        QuantLabel = New System.Windows.Forms.Label()
        ID_ArtLabel = New System.Windows.Forms.Label()
        ComentariosLabel = New System.Windows.Forms.Label()
        ID_CliLabel = New System.Windows.Forms.Label()
        Data_EncLabel = New System.Windows.Forms.Label()
        Data_EnvioLabel = New System.Windows.Forms.Label()
        ID_EncLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ArtigosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_papDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EncomendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Encomenda_DetalhesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Art_esp_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Art_gest_stockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescontoLabel
        '
        DescontoLabel.AutoSize = True
        DescontoLabel.Location = New System.Drawing.Point(10, 215)
        DescontoLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        DescontoLabel.Name = "DescontoLabel"
        DescontoLabel.Size = New System.Drawing.Size(109, 25)
        DescontoLabel.TabIndex = 19
        DescontoLabel.Text = "Desconto:"
        '
        'PreçoLabel
        '
        PreçoLabel.AutoSize = True
        PreçoLabel.Location = New System.Drawing.Point(10, 165)
        PreçoLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        PreçoLabel.Name = "PreçoLabel"
        PreçoLabel.Size = New System.Drawing.Size(74, 25)
        PreçoLabel.TabIndex = 17
        PreçoLabel.Text = "Preço:"
        '
        'QuantLabel
        '
        QuantLabel.AutoSize = True
        QuantLabel.Location = New System.Drawing.Point(10, 115)
        QuantLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        QuantLabel.Name = "QuantLabel"
        QuantLabel.Size = New System.Drawing.Size(76, 25)
        QuantLabel.TabIndex = 15
        QuantLabel.Text = "Quant:"
        '
        'ID_ArtLabel
        '
        ID_ArtLabel.AutoSize = True
        ID_ArtLabel.Location = New System.Drawing.Point(10, 65)
        ID_ArtLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        ID_ArtLabel.Name = "ID_ArtLabel"
        ID_ArtLabel.Size = New System.Drawing.Size(74, 25)
        ID_ArtLabel.TabIndex = 13
        ID_ArtLabel.Text = "Artigo:"
        '
        'ComentariosLabel
        '
        ComentariosLabel.AutoSize = True
        ComentariosLabel.Location = New System.Drawing.Point(40, 910)
        ComentariosLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        ComentariosLabel.Name = "ComentariosLabel"
        ComentariosLabel.Size = New System.Drawing.Size(139, 25)
        ComentariosLabel.TabIndex = 58
        ComentariosLabel.Text = "Comentarios:"
        '
        'ID_CliLabel
        '
        ID_CliLabel.AutoSize = True
        ID_CliLabel.Location = New System.Drawing.Point(452, 42)
        ID_CliLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        ID_CliLabel.Name = "ID_CliLabel"
        ID_CliLabel.Size = New System.Drawing.Size(69, 25)
        ID_CliLabel.TabIndex = 59
        ID_CliLabel.Text = "ID Cli:"
        '
        'Data_EncLabel
        '
        Data_EncLabel.AutoSize = True
        Data_EncLabel.Location = New System.Drawing.Point(762, 48)
        Data_EncLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Data_EncLabel.Name = "Data_EncLabel"
        Data_EncLabel.Size = New System.Drawing.Size(106, 25)
        Data_EncLabel.TabIndex = 71
        Data_EncLabel.Text = "Data Enc:"
        '
        'Data_EnvioLabel
        '
        Data_EnvioLabel.AutoSize = True
        Data_EnvioLabel.Location = New System.Drawing.Point(570, 904)
        Data_EnvioLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Data_EnvioLabel.Name = "Data_EnvioLabel"
        Data_EnvioLabel.Size = New System.Drawing.Size(123, 25)
        Data_EnvioLabel.TabIndex = 75
        Data_EnvioLabel.Text = "Data Envio:"
        '
        'ID_EncLabel
        '
        ID_EncLabel.AutoSize = True
        ID_EncLabel.Location = New System.Drawing.Point(34, 42)
        ID_EncLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        ID_EncLabel.Name = "ID_EncLabel"
        ID_EncLabel.Size = New System.Drawing.Size(81, 25)
        ID_EncLabel.TabIndex = 83
        ID_EncLabel.Text = "ID Enc:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DescontoTextBox)
        Me.GroupBox1.Controls.Add(DescontoLabel)
        Me.GroupBox1.Controls.Add(Me.PreçoTextBox)
        Me.GroupBox1.Controls.Add(PreçoLabel)
        Me.GroupBox1.Controls.Add(Me.cb1)
        Me.GroupBox1.Controls.Add(Me.QuantTextBox)
        Me.GroupBox1.Controls.Add(QuantLabel)
        Me.GroupBox1.Controls.Add(ID_ArtLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 254)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(772, 335)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Produto"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"6", "13", "23"})
        Me.ComboBox1.Location = New System.Drawing.Point(142, 261)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(576, 33)
        Me.ComboBox1.TabIndex = 85
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 261)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 25)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "IVA:"
        '
        'DescontoTextBox
        '
        Me.DescontoTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DescontoTextBox.FormattingEnabled = True
        Me.DescontoTextBox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100"})
        Me.DescontoTextBox.Location = New System.Drawing.Point(144, 209)
        Me.DescontoTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.DescontoTextBox.Name = "DescontoTextBox"
        Me.DescontoTextBox.Size = New System.Drawing.Size(574, 33)
        Me.DescontoTextBox.TabIndex = 85
        '
        'PreçoTextBox
        '
        Me.PreçoTextBox.Location = New System.Drawing.Point(142, 159)
        Me.PreçoTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.PreçoTextBox.Name = "PreçoTextBox"
        Me.PreçoTextBox.Size = New System.Drawing.Size(576, 31)
        Me.PreçoTextBox.TabIndex = 18
        '
        'cb1
        '
        Me.cb1.DataSource = Me.ArtigosBindingSource
        Me.cb1.DisplayMember = "Descricao"
        Me.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb1.FormattingEnabled = True
        Me.cb1.Location = New System.Drawing.Point(142, 58)
        Me.cb1.Margin = New System.Windows.Forms.Padding(6)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(576, 33)
        Me.cb1.TabIndex = 32
        Me.cb1.ValueMember = "ID_Art"
        '
        'ArtigosBindingSource
        '
        Me.ArtigosBindingSource.DataMember = "Artigos"
        Me.ArtigosBindingSource.DataSource = Me.Db_papDataSet
        '
        'Db_papDataSet
        '
        Me.Db_papDataSet.DataSetName = "db_papDataSet"
        Me.Db_papDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QuantTextBox
        '
        Me.QuantTextBox.Location = New System.Drawing.Point(142, 109)
        Me.QuantTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.QuantTextBox.Name = "QuantTextBox"
        Me.QuantTextBox.Size = New System.Drawing.Size(576, 31)
        Me.QuantTextBox.TabIndex = 16
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "Categoria"
        Me.CategoriaBindingSource.DataSource = Me.Db_papDataSet
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(1060, 254)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(1310, 529)
        Me.ListBox1.TabIndex = 67
        '
        'txtendpricefalse
        '
        Me.txtendpricefalse.Location = New System.Drawing.Point(1312, 795)
        Me.txtendpricefalse.Margin = New System.Windows.Forms.Padding(6)
        Me.txtendpricefalse.Name = "txtendpricefalse"
        Me.txtendpricefalse.ReadOnly = True
        Me.txtendpricefalse.Size = New System.Drawing.Size(196, 31)
        Me.txtendpricefalse.TabIndex = 66
        '
        'endsale
        '
        Me.endsale.Location = New System.Drawing.Point(1712, 881)
        Me.endsale.Margin = New System.Windows.Forms.Padding(6)
        Me.endsale.Name = "endsale"
        Me.endsale.Size = New System.Drawing.Size(268, 81)
        Me.endsale.TabIndex = 64
        Me.endsale.Text = "Concluir Venda"
        Me.endsale.UseVisualStyleBackColor = True
        '
        'insertprod
        '
        Me.insertprod.Location = New System.Drawing.Point(830, 323)
        Me.insertprod.Margin = New System.Windows.Forms.Padding(6)
        Me.insertprod.Name = "insertprod"
        Me.insertprod.Size = New System.Drawing.Size(218, 133)
        Me.insertprod.TabIndex = 63
        Me.insertprod.Text = "Inserir Produto"
        Me.insertprod.UseVisualStyleBackColor = True
        '
        'insert
        '
        Me.insert.Location = New System.Drawing.Point(1334, 27)
        Me.insert.Margin = New System.Windows.Forms.Padding(6)
        Me.insert.Name = "insert"
        Me.insert.Size = New System.Drawing.Size(268, 67)
        Me.insert.TabIndex = 62
        Me.insert.Text = "Iniciar  Venda"
        Me.insert.UseVisualStyleBackColor = True
        '
        'comentariostextbox
        '
        Me.comentariostextbox.Location = New System.Drawing.Point(198, 852)
        Me.comentariostextbox.Margin = New System.Windows.Forms.Padding(6)
        Me.comentariostextbox.Name = "comentariostextbox"
        Me.comentariostextbox.Size = New System.Drawing.Size(320, 137)
        Me.comentariostextbox.TabIndex = 61
        Me.comentariostextbox.Text = ""
        '
        'ID_CliTextBox
        '
        Me.ID_CliTextBox.Location = New System.Drawing.Point(534, 35)
        Me.ID_CliTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.ID_CliTextBox.Name = "ID_CliTextBox"
        Me.ID_CliTextBox.Size = New System.Drawing.Size(158, 31)
        Me.ID_CliTextBox.TabIndex = 60
        '
        'EncomendaBindingSource
        '
        Me.EncomendaBindingSource.DataMember = "Encomenda"
        Me.EncomendaBindingSource.DataSource = Me.Db_papDataSet
        '
        'EncomendaTableAdapter
        '
        Me.EncomendaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArtigosTableAdapter = Me.ArtigosTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriaTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.Encomenda_DetalhesTableAdapter = Me.Encomenda_DetalhesTableAdapter
        Me.TableAdapterManager.EncomendaTableAdapter = Me.EncomendaTableAdapter
        Me.TableAdapterManager.FornecedorTableAdapter = Nothing
        Me.TableAdapterManager.PagamentoTableAdapter = Me.PagamentoTableAdapter
        Me.TableAdapterManager.UpdateOrder = PAP_09.db_papDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ArtigosTableAdapter
        '
        Me.ArtigosTableAdapter.ClearBeforeFill = True
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'Encomenda_DetalhesTableAdapter
        '
        Me.Encomenda_DetalhesTableAdapter.ClearBeforeFill = True
        '
        'PagamentoTableAdapter
        '
        Me.PagamentoTableAdapter.ClearBeforeFill = True
        '
        'Data_EncDateTimePicker
        '
        Me.Data_EncDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EncomendaBindingSource, "Data_Enc", True))
        Me.Data_EncDateTimePicker.Location = New System.Drawing.Point(922, 42)
        Me.Data_EncDateTimePicker.Margin = New System.Windows.Forms.Padding(6)
        Me.Data_EncDateTimePicker.Name = "Data_EncDateTimePicker"
        Me.Data_EncDateTimePicker.Size = New System.Drawing.Size(396, 31)
        Me.Data_EncDateTimePicker.TabIndex = 72
        '
        'Data_EnvioDateTimePicker
        '
        Me.Data_EnvioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EncomendaBindingSource, "Data_Envio", True))
        Me.Data_EnvioDateTimePicker.Location = New System.Drawing.Point(738, 896)
        Me.Data_EnvioDateTimePicker.Margin = New System.Windows.Forms.Padding(6)
        Me.Data_EnvioDateTimePicker.Name = "Data_EnvioDateTimePicker"
        Me.Data_EnvioDateTimePicker.Size = New System.Drawing.Size(396, 31)
        Me.Data_EnvioDateTimePicker.TabIndex = 76
        '
        'ID_PagamentoTextBox
        '
        Me.ID_PagamentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EncomendaBindingSource, "ID_Pagamento", True))
        Me.ID_PagamentoTextBox.Location = New System.Drawing.Point(802, 1044)
        Me.ID_PagamentoTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.ID_PagamentoTextBox.Name = "ID_PagamentoTextBox"
        Me.ID_PagamentoTextBox.Size = New System.Drawing.Size(396, 31)
        Me.ID_PagamentoTextBox.TabIndex = 82
        '
        'Encomenda_DetalhesBindingSource
        '
        Me.Encomenda_DetalhesBindingSource.DataMember = "Encomenda_Detalhes"
        Me.Encomenda_DetalhesBindingSource.DataSource = Me.Db_papDataSet
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.Db_papDataSet
        '
        'PagamentoBindingSource
        '
        Me.PagamentoBindingSource.DataMember = "Pagamento"
        Me.PagamentoBindingSource.DataSource = Me.Db_papDataSet
        '
        'pagclick
        '
        Me.pagclick.Location = New System.Drawing.Point(1396, 881)
        Me.pagclick.Margin = New System.Windows.Forms.Padding(6)
        Me.pagclick.Name = "pagclick"
        Me.pagclick.Size = New System.Drawing.Size(274, 81)
        Me.pagclick.TabIndex = 83
        Me.pagclick.Text = "Pagamento"
        Me.pagclick.UseVisualStyleBackColor = True
        '
        'ID_EncTextBox
        '
        Me.ID_EncTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EncomendaBindingSource, "ID_Enc", True))
        Me.ID_EncTextBox.Location = New System.Drawing.Point(132, 37)
        Me.ID_EncTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.ID_EncTextBox.Name = "ID_EncTextBox"
        Me.ID_EncTextBox.ReadOnly = True
        Me.ID_EncTextBox.Size = New System.Drawing.Size(122, 31)
        Me.ID_EncTextBox.TabIndex = 84
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(534, 75)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(224, 29)
        Me.CheckBox1.TabIndex = 85
        Me.CheckBox1.Text = "Consumidor Final?"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(24, 1058)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(424, 31)
        Me.TextBox1.TabIndex = 65
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(469, 1058)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(424, 31)
        Me.TextBox2.TabIndex = 86
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(934, 1058)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(424, 31)
        Me.TextBox3.TabIndex = 87
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1176, 801)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 25)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Preço Final:"
        '
        'op_encomendasvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2398, 1135)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(ID_EncLabel)
        Me.Controls.Add(Me.ID_EncTextBox)
        Me.Controls.Add(Me.pagclick)
        Me.Controls.Add(Data_EncLabel)
        Me.Controls.Add(Me.Data_EncDateTimePicker)
        Me.Controls.Add(Data_EnvioLabel)
        Me.Controls.Add(Me.Data_EnvioDateTimePicker)
        Me.Controls.Add(Me.ID_PagamentoTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.txtendpricefalse)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.endsale)
        Me.Controls.Add(Me.insertprod)
        Me.Controls.Add(Me.insert)
        Me.Controls.Add(Me.comentariostextbox)
        Me.Controls.Add(ComentariosLabel)
        Me.Controls.Add(ID_CliLabel)
        Me.Controls.Add(Me.ID_CliTextBox)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "op_encomendasvb"
        Me.Text = "Encomendas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ArtigosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_papDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EncomendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Encomenda_DetalhesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Art_esp_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Art_gest_stockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PreçoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cb1 As System.Windows.Forms.ComboBox
    Friend WithEvents QuantTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents txtendpricefalse As System.Windows.Forms.TextBox
    Friend WithEvents endsale As System.Windows.Forms.Button
    Friend WithEvents insertprod As System.Windows.Forms.Button
    Friend WithEvents insert As System.Windows.Forms.Button
    Friend WithEvents comentariostextbox As System.Windows.Forms.RichTextBox
    Friend WithEvents ID_CliTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Db_papDataSet As PAP_09.db_papDataSet
    Friend WithEvents EncomendaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EncomendaTableAdapter As PAP_09.db_papDataSetTableAdapters.EncomendaTableAdapter
    Friend WithEvents TableAdapterManager As PAP_09.db_papDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Data_EncDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Data_EnvioDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ID_PagamentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Encomenda_DetalhesTableAdapter As PAP_09.db_papDataSetTableAdapters.Encomenda_DetalhesTableAdapter
    Friend WithEvents Encomenda_DetalhesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As PAP_09.db_papDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArtigosTableAdapter As PAP_09.db_papDataSetTableAdapters.ArtigosTableAdapter
    Friend WithEvents ArtigosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PagamentoTableAdapter As PAP_09.db_papDataSetTableAdapters.PagamentoTableAdapter
    Friend WithEvents PagamentoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents pagclick As System.Windows.Forms.Button
    Friend WithEvents ID_EncTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescontoTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CategoriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriaTableAdapter As PAP_09.db_papDataSetTableAdapters.CategoriaTableAdapter
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Art_esp_dbDataSet As PAP_09.art_esp_dbDataSet
    Friend WithEvents Art_gest_stockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Art_gest_stockTableAdapter As PAP_09.art_esp_dbDataSetTableAdapters.art_gest_stockTableAdapter
    Friend WithEvents TableAdapterManager1 As PAP_09.art_esp_dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
