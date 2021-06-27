<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class op_forn
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
        Dim ID_FornLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim NifLabel As System.Windows.Forms.Label
        Dim RuaLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim PaisLabel As System.Windows.Forms.Label
        Dim Cod_PostalLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim E_MailLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.update = New System.Windows.Forms.Button()
        Me.updatetext = New System.Windows.Forms.TextBox()
        Me.endsearch = New System.Windows.Forms.Button()
        Me.searchlayer = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtdelete = New System.Windows.Forms.RichTextBox()
        Me.deletenome = New System.Windows.Forms.Button()
        Me.deleteid = New System.Windows.Forms.Button()
        Me.layerdelete = New System.Windows.Forms.Button()
        Me.insertlayer = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PaisTextBox = New System.Windows.Forms.ComboBox()
        Me.ID_FornTextBox = New System.Windows.Forms.TextBox()
        Me.FornecedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_papDataSet = New PAP_09.db_papDataSet()
        Me.E_MailTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.TelefoneTextBox = New System.Windows.Forms.TextBox()
        Me.NifTextBox = New System.Windows.Forms.TextBox()
        Me.Cod_PostalTextBox = New System.Windows.Forms.TextBox()
        Me.RuaTextBox = New System.Windows.Forms.TextBox()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.save = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.numreg = New System.Windows.Forms.TextBox()
        Me.search = New System.Windows.Forms.Button()
        Me.insert = New System.Windows.Forms.Button()
        Me.FornecedorTableAdapter = New PAP_09.db_papDataSetTableAdapters.FornecedorTableAdapter()
        Me.TableAdapterManager = New PAP_09.db_papDataSetTableAdapters.TableAdapterManager()
        ID_FornLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        NifLabel = New System.Windows.Forms.Label()
        RuaLabel = New System.Windows.Forms.Label()
        CidadeLabel = New System.Windows.Forms.Label()
        PaisLabel = New System.Windows.Forms.Label()
        Cod_PostalLabel = New System.Windows.Forms.Label()
        TelefoneLabel = New System.Windows.Forms.Label()
        E_MailLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.FornecedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_papDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_FornLabel
        '
        ID_FornLabel.AutoSize = True
        ID_FornLabel.Location = New System.Drawing.Point(22, 42)
        ID_FornLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        ID_FornLabel.Name = "ID_FornLabel"
        ID_FornLabel.Size = New System.Drawing.Size(88, 25)
        ID_FornLabel.TabIndex = 77
        ID_FornLabel.Text = "ID Forn:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(22, 92)
        NomeLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(74, 25)
        NomeLabel.TabIndex = 79
        NomeLabel.Text = "Nome:"
        '
        'NifLabel
        '
        NifLabel.AutoSize = True
        NifLabel.Location = New System.Drawing.Point(22, 142)
        NifLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        NifLabel.Name = "NifLabel"
        NifLabel.Size = New System.Drawing.Size(44, 25)
        NifLabel.TabIndex = 81
        NifLabel.Text = "Nif:"
        '
        'RuaLabel
        '
        RuaLabel.AutoSize = True
        RuaLabel.Location = New System.Drawing.Point(22, 192)
        RuaLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        RuaLabel.Name = "RuaLabel"
        RuaLabel.Size = New System.Drawing.Size(57, 25)
        RuaLabel.TabIndex = 83
        RuaLabel.Text = "Rua:"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Location = New System.Drawing.Point(22, 242)
        CidadeLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(86, 25)
        CidadeLabel.TabIndex = 85
        CidadeLabel.Text = "Cidade:"
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.Location = New System.Drawing.Point(22, 292)
        PaisLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(60, 25)
        PaisLabel.TabIndex = 87
        PaisLabel.Text = "Pais:"
        '
        'Cod_PostalLabel
        '
        Cod_PostalLabel.AutoSize = True
        Cod_PostalLabel.Location = New System.Drawing.Point(22, 342)
        Cod_PostalLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Cod_PostalLabel.Name = "Cod_PostalLabel"
        Cod_PostalLabel.Size = New System.Drawing.Size(123, 25)
        Cod_PostalLabel.TabIndex = 89
        Cod_PostalLabel.Text = "Cod Postal:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Location = New System.Drawing.Point(22, 392)
        TelefoneLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(102, 25)
        TelefoneLabel.TabIndex = 91
        TelefoneLabel.Text = "Telefone:"
        '
        'E_MailLabel
        '
        E_MailLabel.AutoSize = True
        E_MailLabel.Location = New System.Drawing.Point(22, 442)
        E_MailLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        E_MailLabel.Name = "E_MailLabel"
        E_MailLabel.Size = New System.Drawing.Size(79, 25)
        E_MailLabel.TabIndex = 93
        E_MailLabel.Text = "E-Mail:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(21, 75)
        Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(74, 25)
        Label1.TabIndex = 80
        Label1.Text = "Nome:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Label1)
        Me.GroupBox3.Controls.Add(Me.update)
        Me.GroupBox3.Controls.Add(Me.updatetext)
        Me.GroupBox3.Location = New System.Drawing.Point(1134, 334)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox3.Size = New System.Drawing.Size(610, 167)
        Me.GroupBox3.TabIndex = 76
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Alterar"
        '
        'update
        '
        Me.update.Location = New System.Drawing.Point(368, 65)
        Me.update.Margin = New System.Windows.Forms.Padding(6)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(234, 44)
        Me.update.TabIndex = 39
        Me.update.Text = "Atualizar Dados"
        Me.update.UseVisualStyleBackColor = True
        '
        'updatetext
        '
        Me.updatetext.Location = New System.Drawing.Point(128, 69)
        Me.updatetext.Margin = New System.Windows.Forms.Padding(6)
        Me.updatetext.Name = "updatetext"
        Me.updatetext.Size = New System.Drawing.Size(196, 31)
        Me.updatetext.TabIndex = 40
        '
        'endsearch
        '
        Me.endsearch.Location = New System.Drawing.Point(196, 900)
        Me.endsearch.Margin = New System.Windows.Forms.Padding(6)
        Me.endsearch.Name = "endsearch"
        Me.endsearch.Size = New System.Drawing.Size(150, 44)
        Me.endsearch.TabIndex = 75
        Me.endsearch.Text = "Concluir"
        Me.endsearch.UseVisualStyleBackColor = True
        '
        'searchlayer
        '
        Me.searchlayer.Image = Global.PAP_09.My.Resources.Resources._585e4ae9cb11b227491c3394
        Me.searchlayer.Location = New System.Drawing.Point(1122, 23)
        Me.searchlayer.Margin = New System.Windows.Forms.Padding(6)
        Me.searchlayer.Name = "searchlayer"
        Me.searchlayer.Size = New System.Drawing.Size(508, 199)
        Me.searchlayer.TabIndex = 74
        Me.searchlayer.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtdelete)
        Me.GroupBox2.Controls.Add(Me.deletenome)
        Me.GroupBox2.Controls.Add(Me.deleteid)
        Me.GroupBox2.Location = New System.Drawing.Point(598, 323)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Size = New System.Drawing.Size(502, 342)
        Me.GroupBox2.TabIndex = 73
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Apagar"
        '
        'txtdelete
        '
        Me.txtdelete.Location = New System.Drawing.Point(12, 67)
        Me.txtdelete.Margin = New System.Windows.Forms.Padding(6)
        Me.txtdelete.Name = "txtdelete"
        Me.txtdelete.Size = New System.Drawing.Size(196, 108)
        Me.txtdelete.TabIndex = 41
        Me.txtdelete.Text = ""
        '
        'deletenome
        '
        Me.deletenome.Location = New System.Drawing.Point(242, 76)
        Me.deletenome.Margin = New System.Windows.Forms.Padding(6)
        Me.deletenome.Name = "deletenome"
        Me.deletenome.Size = New System.Drawing.Size(234, 44)
        Me.deletenome.TabIndex = 37
        Me.deletenome.Text = "Apagar p/ Nome"
        Me.deletenome.UseVisualStyleBackColor = True
        '
        'deleteid
        '
        Me.deleteid.Location = New System.Drawing.Point(242, 135)
        Me.deleteid.Margin = New System.Windows.Forms.Padding(6)
        Me.deleteid.Name = "deleteid"
        Me.deleteid.Size = New System.Drawing.Size(234, 44)
        Me.deleteid.TabIndex = 38
        Me.deleteid.Text = "Apagar p/ ID"
        Me.deleteid.UseVisualStyleBackColor = True
        '
        'layerdelete
        '
        Me.layerdelete.Image = Global.PAP_09.My.Resources.Resources._61848
        Me.layerdelete.Location = New System.Drawing.Point(598, 23)
        Me.layerdelete.Margin = New System.Windows.Forms.Padding(6)
        Me.layerdelete.Name = "layerdelete"
        Me.layerdelete.Size = New System.Drawing.Size(484, 199)
        Me.layerdelete.TabIndex = 72
        Me.layerdelete.UseVisualStyleBackColor = True
        '
        'insertlayer
        '
        Me.insertlayer.Image = Global.PAP_09.My.Resources.Resources.f3f305dd9e1
        Me.insertlayer.Location = New System.Drawing.Point(52, 23)
        Me.insertlayer.Margin = New System.Windows.Forms.Padding(6)
        Me.insertlayer.Name = "insertlayer"
        Me.insertlayer.Size = New System.Drawing.Size(492, 199)
        Me.insertlayer.TabIndex = 71
        Me.insertlayer.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PaisTextBox)
        Me.GroupBox1.Controls.Add(ID_FornLabel)
        Me.GroupBox1.Controls.Add(Me.ID_FornTextBox)
        Me.GroupBox1.Controls.Add(Me.E_MailTextBox)
        Me.GroupBox1.Controls.Add(NomeLabel)
        Me.GroupBox1.Controls.Add(E_MailLabel)
        Me.GroupBox1.Controls.Add(Me.NomeTextBox)
        Me.GroupBox1.Controls.Add(Me.TelefoneTextBox)
        Me.GroupBox1.Controls.Add(NifLabel)
        Me.GroupBox1.Controls.Add(TelefoneLabel)
        Me.GroupBox1.Controls.Add(Me.NifTextBox)
        Me.GroupBox1.Controls.Add(Me.Cod_PostalTextBox)
        Me.GroupBox1.Controls.Add(RuaLabel)
        Me.GroupBox1.Controls.Add(Cod_PostalLabel)
        Me.GroupBox1.Controls.Add(Me.RuaTextBox)
        Me.GroupBox1.Controls.Add(CidadeLabel)
        Me.GroupBox1.Controls.Add(PaisLabel)
        Me.GroupBox1.Controls.Add(Me.CidadeTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 298)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(570, 506)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados"
        '
        'PaisTextBox
        '
        Me.PaisTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PaisTextBox.FormattingEnabled = True
        Me.PaisTextBox.Items.AddRange(New Object() {"Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua & Deps", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Central African Rep", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo", "Congo {Democratic Rep}", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland {Republic}", "Israel", "Italy", "Ivory Coast", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea North", "Korea South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar, {Burma}", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russian Federation", "Rwanda", "St Kitts & Nevis", "St Lucia", "Saint Vincent & the Grenadines", "Samoa", "San Marino", "Sao Tome & Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Swaziland", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad & Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe"})
        Me.PaisTextBox.Location = New System.Drawing.Point(156, 285)
        Me.PaisTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.PaisTextBox.Name = "PaisTextBox"
        Me.PaisTextBox.Size = New System.Drawing.Size(360, 33)
        Me.PaisTextBox.TabIndex = 95
        '
        'ID_FornTextBox
        '
        Me.ID_FornTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "ID_Forn", True))
        Me.ID_FornTextBox.Location = New System.Drawing.Point(156, 37)
        Me.ID_FornTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.ID_FornTextBox.Name = "ID_FornTextBox"
        Me.ID_FornTextBox.Size = New System.Drawing.Size(360, 31)
        Me.ID_FornTextBox.TabIndex = 78
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
        'E_MailTextBox
        '
        Me.E_MailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "E-Mail", True))
        Me.E_MailTextBox.Location = New System.Drawing.Point(156, 437)
        Me.E_MailTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.E_MailTextBox.Name = "E_MailTextBox"
        Me.E_MailTextBox.Size = New System.Drawing.Size(360, 31)
        Me.E_MailTextBox.TabIndex = 94
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(156, 87)
        Me.NomeTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(360, 31)
        Me.NomeTextBox.TabIndex = 80
        '
        'TelefoneTextBox
        '
        Me.TelefoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "Telefone", True))
        Me.TelefoneTextBox.Location = New System.Drawing.Point(156, 387)
        Me.TelefoneTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.TelefoneTextBox.Name = "TelefoneTextBox"
        Me.TelefoneTextBox.Size = New System.Drawing.Size(360, 31)
        Me.TelefoneTextBox.TabIndex = 92
        '
        'NifTextBox
        '
        Me.NifTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "Nif", True))
        Me.NifTextBox.Location = New System.Drawing.Point(156, 137)
        Me.NifTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.NifTextBox.Name = "NifTextBox"
        Me.NifTextBox.Size = New System.Drawing.Size(360, 31)
        Me.NifTextBox.TabIndex = 82
        '
        'Cod_PostalTextBox
        '
        Me.Cod_PostalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "Cod_Postal", True))
        Me.Cod_PostalTextBox.Location = New System.Drawing.Point(156, 337)
        Me.Cod_PostalTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.Cod_PostalTextBox.Name = "Cod_PostalTextBox"
        Me.Cod_PostalTextBox.Size = New System.Drawing.Size(360, 31)
        Me.Cod_PostalTextBox.TabIndex = 90
        '
        'RuaTextBox
        '
        Me.RuaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "Rua", True))
        Me.RuaTextBox.Location = New System.Drawing.Point(156, 187)
        Me.RuaTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.RuaTextBox.Name = "RuaTextBox"
        Me.RuaTextBox.Size = New System.Drawing.Size(360, 31)
        Me.RuaTextBox.TabIndex = 84
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "Cidade", True))
        Me.CidadeTextBox.Location = New System.Drawing.Point(156, 237)
        Me.CidadeTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(360, 31)
        Me.CidadeTextBox.TabIndex = 86
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(16, 900)
        Me.save.Margin = New System.Windows.Forms.Padding(6)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(150, 44)
        Me.save.TabIndex = 69
        Me.save.Text = "Guardar atualização"
        Me.save.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 1044)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 44)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "Limpar CX"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'numreg
        '
        Me.numreg.Location = New System.Drawing.Point(16, 1100)
        Me.numreg.Margin = New System.Windows.Forms.Padding(6)
        Me.numreg.Name = "numreg"
        Me.numreg.ReadOnly = True
        Me.numreg.Size = New System.Drawing.Size(434, 31)
        Me.numreg.TabIndex = 67
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(196, 844)
        Me.search.Margin = New System.Windows.Forms.Padding(6)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(150, 44)
        Me.search.TabIndex = 66
        Me.search.Text = "Procurar"
        Me.search.UseVisualStyleBackColor = True
        '
        'insert
        '
        Me.insert.Location = New System.Drawing.Point(16, 844)
        Me.insert.Margin = New System.Windows.Forms.Padding(6)
        Me.insert.Name = "insert"
        Me.insert.Size = New System.Drawing.Size(150, 44)
        Me.insert.TabIndex = 65
        Me.insert.Text = "Inserir"
        Me.insert.UseVisualStyleBackColor = True
        '
        'FornecedorTableAdapter
        '
        Me.FornecedorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArtigosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriaTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.Encomenda_DetalhesTableAdapter = Nothing
        Me.TableAdapterManager.EncomendaTableAdapter = Nothing
        Me.TableAdapterManager.FornecedorTableAdapter = Me.FornecedorTableAdapter
        Me.TableAdapterManager.PagamentoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PAP_09.db_papDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'op_forn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1833, 1166)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.endsearch)
        Me.Controls.Add(Me.searchlayer)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.layerdelete)
        Me.Controls.Add(Me.insertlayer)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.numreg)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.insert)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "op_forn"
        Me.Text = "Forncedores"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.FornecedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_papDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents update As System.Windows.Forms.Button
    Friend WithEvents updatetext As System.Windows.Forms.TextBox
    Friend WithEvents endsearch As System.Windows.Forms.Button
    Friend WithEvents searchlayer As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdelete As System.Windows.Forms.RichTextBox
    Friend WithEvents deletenome As System.Windows.Forms.Button
    Friend WithEvents deleteid As System.Windows.Forms.Button
    Friend WithEvents layerdelete As System.Windows.Forms.Button
    Friend WithEvents insertlayer As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents numreg As System.Windows.Forms.TextBox
    Friend WithEvents search As System.Windows.Forms.Button
    Friend WithEvents insert As System.Windows.Forms.Button
    Friend WithEvents Db_papDataSet As PAP_09.db_papDataSet
    Friend WithEvents FornecedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FornecedorTableAdapter As PAP_09.db_papDataSetTableAdapters.FornecedorTableAdapter
    Friend WithEvents TableAdapterManager As PAP_09.db_papDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ID_FornTextBox As System.Windows.Forms.TextBox
    Friend WithEvents E_MailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NifTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cod_PostalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RuaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaisTextBox As System.Windows.Forms.ComboBox
End Class
