<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class op_arm
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Id_armLabel As System.Windows.Forms.Label
        Dim RuaLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim Cod_PostalLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim PaisLabel As System.Windows.Forms.Label
        Dim OutrosLabel As System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.update = New System.Windows.Forms.Button()
        Me.updatetext = New System.Windows.Forms.TextBox()
        Me.endsearch = New System.Windows.Forms.Button()
        Me.searchlayer = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtdelete = New System.Windows.Forms.RichTextBox()
        Me.deleteid = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PaisTextBox = New System.Windows.Forms.ComboBox()
        Me.Id_armTextBox = New System.Windows.Forms.TextBox()
        Me.ArmazensBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Art_esp_dbDataSet = New PAP_09.art_esp_dbDataSet()
        Me.OutrosTextBox = New System.Windows.Forms.TextBox()
        Me.RuaTextBox = New System.Windows.Forms.TextBox()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.TelefoneTextBox = New System.Windows.Forms.TextBox()
        Me.Cod_PostalTextBox = New System.Windows.Forms.TextBox()
        Me.save = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.numreg = New System.Windows.Forms.TextBox()
        Me.search = New System.Windows.Forms.Button()
        Me.insert = New System.Windows.Forms.Button()
        Me.ArmazensTableAdapter = New PAP_09.art_esp_dbDataSetTableAdapters.armazensTableAdapter()
        Me.TableAdapterManager = New PAP_09.art_esp_dbDataSetTableAdapters.TableAdapterManager()
        Me.layerdelete = New System.Windows.Forms.Button()
        Me.insertlayer = New System.Windows.Forms.Button()
        Label1 = New System.Windows.Forms.Label()
        Id_armLabel = New System.Windows.Forms.Label()
        RuaLabel = New System.Windows.Forms.Label()
        CidadeLabel = New System.Windows.Forms.Label()
        Cod_PostalLabel = New System.Windows.Forms.Label()
        TelefoneLabel = New System.Windows.Forms.Label()
        PaisLabel = New System.Windows.Forms.Label()
        OutrosLabel = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ArmazensBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Art_esp_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(2, 69)
        Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(74, 25)
        Label1.TabIndex = 78
        Label1.Text = "Nome:"
        '
        'Id_armLabel
        '
        Id_armLabel.AutoSize = True
        Id_armLabel.Location = New System.Drawing.Point(24, 45)
        Id_armLabel.Name = "Id_armLabel"
        Id_armLabel.Size = New System.Drawing.Size(82, 25)
        Id_armLabel.TabIndex = 88
        Id_armLabel.Text = "ID Arm:"
        '
        'RuaLabel
        '
        RuaLabel.AutoSize = True
        RuaLabel.Location = New System.Drawing.Point(24, 82)
        RuaLabel.Name = "RuaLabel"
        RuaLabel.Size = New System.Drawing.Size(57, 25)
        RuaLabel.TabIndex = 90
        RuaLabel.Text = "Rua:"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Location = New System.Drawing.Point(24, 119)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(86, 25)
        CidadeLabel.TabIndex = 92
        CidadeLabel.Text = "Cidade:"
        '
        'Cod_PostalLabel
        '
        Cod_PostalLabel.AutoSize = True
        Cod_PostalLabel.Location = New System.Drawing.Point(24, 156)
        Cod_PostalLabel.Name = "Cod_PostalLabel"
        Cod_PostalLabel.Size = New System.Drawing.Size(123, 25)
        Cod_PostalLabel.TabIndex = 94
        Cod_PostalLabel.Text = "Cod Postal:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Location = New System.Drawing.Point(24, 193)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(102, 25)
        TelefoneLabel.TabIndex = 96
        TelefoneLabel.Text = "Telefone:"
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.Location = New System.Drawing.Point(24, 230)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(60, 25)
        PaisLabel.TabIndex = 98
        PaisLabel.Text = "Pais:"
        '
        'OutrosLabel
        '
        OutrosLabel.AutoSize = True
        OutrosLabel.Location = New System.Drawing.Point(24, 267)
        OutrosLabel.Name = "OutrosLabel"
        OutrosLabel.Size = New System.Drawing.Size(74, 25)
        OutrosLabel.TabIndex = 100
        OutrosLabel.Text = "Nome:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Label1)
        Me.GroupBox3.Controls.Add(Me.update)
        Me.GroupBox3.Controls.Add(Me.updatetext)
        Me.GroupBox3.Location = New System.Drawing.Point(1119, 171)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox3.Size = New System.Drawing.Size(676, 167)
        Me.GroupBox3.TabIndex = 88
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Alterar"
        '
        'update
        '
        Me.update.Location = New System.Drawing.Point(376, 66)
        Me.update.Margin = New System.Windows.Forms.Padding(6)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(234, 44)
        Me.update.TabIndex = 39
        Me.update.Text = "Atualizar Dados"
        Me.update.UseVisualStyleBackColor = True
        '
        'updatetext
        '
        Me.updatetext.Location = New System.Drawing.Point(154, 69)
        Me.updatetext.Margin = New System.Windows.Forms.Padding(6)
        Me.updatetext.Name = "updatetext"
        Me.updatetext.Size = New System.Drawing.Size(196, 31)
        Me.updatetext.TabIndex = 40
        '
        'endsearch
        '
        Me.endsearch.Location = New System.Drawing.Point(214, 626)
        Me.endsearch.Margin = New System.Windows.Forms.Padding(6)
        Me.endsearch.Name = "endsearch"
        Me.endsearch.Size = New System.Drawing.Size(150, 44)
        Me.endsearch.TabIndex = 87
        Me.endsearch.Text = "Concluir"
        Me.endsearch.UseVisualStyleBackColor = True
        '
        'searchlayer
        '
        Me.searchlayer.Image = Global.PAP_09.My.Resources.Resources._585e4ae9cb11b227491c3394
        Me.searchlayer.Location = New System.Drawing.Point(671, 29)
        Me.searchlayer.Margin = New System.Windows.Forms.Padding(6)
        Me.searchlayer.Name = "searchlayer"
        Me.searchlayer.Size = New System.Drawing.Size(338, 130)
        Me.searchlayer.TabIndex = 86
        Me.searchlayer.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtdelete)
        Me.GroupBox2.Controls.Add(Me.deleteid)
        Me.GroupBox2.Location = New System.Drawing.Point(583, 160)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Size = New System.Drawing.Size(502, 212)
        Me.GroupBox2.TabIndex = 85
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
        'deleteid
        '
        Me.deleteid.Location = New System.Drawing.Point(242, 67)
        Me.deleteid.Margin = New System.Windows.Forms.Padding(6)
        Me.deleteid.Name = "deleteid"
        Me.deleteid.Size = New System.Drawing.Size(234, 112)
        Me.deleteid.TabIndex = 38
        Me.deleteid.Text = "Apagar p/ ID"
        Me.deleteid.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PaisTextBox)
        Me.GroupBox1.Controls.Add(Id_armLabel)
        Me.GroupBox1.Controls.Add(Me.Id_armTextBox)
        Me.GroupBox1.Controls.Add(Me.OutrosTextBox)
        Me.GroupBox1.Controls.Add(RuaLabel)
        Me.GroupBox1.Controls.Add(OutrosLabel)
        Me.GroupBox1.Controls.Add(Me.RuaTextBox)
        Me.GroupBox1.Controls.Add(CidadeLabel)
        Me.GroupBox1.Controls.Add(PaisLabel)
        Me.GroupBox1.Controls.Add(Me.CidadeTextBox)
        Me.GroupBox1.Controls.Add(Me.TelefoneTextBox)
        Me.GroupBox1.Controls.Add(Cod_PostalLabel)
        Me.GroupBox1.Controls.Add(TelefoneLabel)
        Me.GroupBox1.Controls.Add(Me.Cod_PostalTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 171)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(538, 370)
        Me.GroupBox1.TabIndex = 82
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados"
        '
        'PaisTextBox
        '
        Me.PaisTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PaisTextBox.FormattingEnabled = True
        Me.PaisTextBox.Items.AddRange(New Object() {"Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua & Deps", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Central African Rep", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo", "Congo {Democratic Rep}", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland {Republic}", "Israel", "Italy", "Ivory Coast", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea North", "Korea South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar, {Burma}", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russian Federation", "Rwanda", "St Kitts & Nevis", "St Lucia", "Saint Vincent & the Grenadines", "Samoa", "San Marino", "Sao Tome & Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Swaziland", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad & Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe"})
        Me.PaisTextBox.Location = New System.Drawing.Point(153, 222)
        Me.PaisTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.PaisTextBox.Name = "PaisTextBox"
        Me.PaisTextBox.Size = New System.Drawing.Size(210, 33)
        Me.PaisTextBox.TabIndex = 102
        '
        'Id_armTextBox
        '
        Me.Id_armTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArmazensBindingSource, "id_arm", True))
        Me.Id_armTextBox.Location = New System.Drawing.Point(153, 42)
        Me.Id_armTextBox.Name = "Id_armTextBox"
        Me.Id_armTextBox.Size = New System.Drawing.Size(210, 31)
        Me.Id_armTextBox.TabIndex = 89
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
        'OutrosTextBox
        '
        Me.OutrosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArmazensBindingSource, "Outros", True))
        Me.OutrosTextBox.Location = New System.Drawing.Point(153, 264)
        Me.OutrosTextBox.Name = "OutrosTextBox"
        Me.OutrosTextBox.Size = New System.Drawing.Size(210, 31)
        Me.OutrosTextBox.TabIndex = 101
        '
        'RuaTextBox
        '
        Me.RuaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArmazensBindingSource, "Rua", True))
        Me.RuaTextBox.Location = New System.Drawing.Point(153, 79)
        Me.RuaTextBox.Name = "RuaTextBox"
        Me.RuaTextBox.Size = New System.Drawing.Size(210, 31)
        Me.RuaTextBox.TabIndex = 91
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArmazensBindingSource, "Cidade", True))
        Me.CidadeTextBox.Location = New System.Drawing.Point(153, 116)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(210, 31)
        Me.CidadeTextBox.TabIndex = 93
        '
        'TelefoneTextBox
        '
        Me.TelefoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArmazensBindingSource, "Telefone", True))
        Me.TelefoneTextBox.Location = New System.Drawing.Point(153, 190)
        Me.TelefoneTextBox.Name = "TelefoneTextBox"
        Me.TelefoneTextBox.Size = New System.Drawing.Size(210, 31)
        Me.TelefoneTextBox.TabIndex = 97
        '
        'Cod_PostalTextBox
        '
        Me.Cod_PostalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArmazensBindingSource, "Cod_Postal", True))
        Me.Cod_PostalTextBox.Location = New System.Drawing.Point(153, 153)
        Me.Cod_PostalTextBox.Name = "Cod_PostalTextBox"
        Me.Cod_PostalTextBox.Size = New System.Drawing.Size(210, 31)
        Me.Cod_PostalTextBox.TabIndex = 95
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(34, 626)
        Me.save.Margin = New System.Windows.Forms.Padding(6)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(150, 44)
        Me.save.TabIndex = 81
        Me.save.Text = "Guardar atualização"
        Me.save.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 765)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 44)
        Me.Button1.TabIndex = 80
        Me.Button1.Text = "Limpar CX"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'numreg
        '
        Me.numreg.Location = New System.Drawing.Point(8, 820)
        Me.numreg.Margin = New System.Windows.Forms.Padding(6)
        Me.numreg.Name = "numreg"
        Me.numreg.ReadOnly = True
        Me.numreg.Size = New System.Drawing.Size(434, 31)
        Me.numreg.TabIndex = 79
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(214, 570)
        Me.search.Margin = New System.Windows.Forms.Padding(6)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(150, 44)
        Me.search.TabIndex = 78
        Me.search.Text = "Procurar"
        Me.search.UseVisualStyleBackColor = True
        '
        'insert
        '
        Me.insert.Location = New System.Drawing.Point(34, 570)
        Me.insert.Margin = New System.Windows.Forms.Padding(6)
        Me.insert.Name = "insert"
        Me.insert.Size = New System.Drawing.Size(150, 44)
        Me.insert.TabIndex = 77
        Me.insert.Text = "Inserir"
        Me.insert.UseVisualStyleBackColor = True
        '
        'ArmazensTableAdapter
        '
        Me.ArmazensTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.armazensTableAdapter = Me.ArmazensTableAdapter
        Me.TableAdapterManager.art_espTableAdapter = Nothing
        Me.TableAdapterManager.art_gest_stockTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = PAP_09.art_esp_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'layerdelete
        '
        Me.layerdelete.Image = Global.PAP_09.My.Resources.Resources._61848
        Me.layerdelete.Location = New System.Drawing.Point(359, 29)
        Me.layerdelete.Margin = New System.Windows.Forms.Padding(6)
        Me.layerdelete.Name = "layerdelete"
        Me.layerdelete.Size = New System.Drawing.Size(300, 130)
        Me.layerdelete.TabIndex = 84
        Me.layerdelete.UseVisualStyleBackColor = True
        '
        'insertlayer
        '
        Me.insertlayer.Image = Global.PAP_09.My.Resources.Resources.f3f305dd9e1
        Me.insertlayer.Location = New System.Drawing.Point(27, 29)
        Me.insertlayer.Margin = New System.Windows.Forms.Padding(6)
        Me.insertlayer.Name = "insertlayer"
        Me.insertlayer.Size = New System.Drawing.Size(320, 139)
        Me.insertlayer.TabIndex = 83
        Me.insertlayer.UseVisualStyleBackColor = True
        '
        'op_arm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1951, 875)
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
        Me.Name = "op_arm"
        Me.Text = "Armazen"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ArmazensBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Art_esp_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents deleteid As System.Windows.Forms.Button
    Friend WithEvents layerdelete As System.Windows.Forms.Button
    Friend WithEvents insertlayer As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents numreg As System.Windows.Forms.TextBox
    Friend WithEvents search As System.Windows.Forms.Button
    Friend WithEvents insert As System.Windows.Forms.Button
    Friend WithEvents Art_esp_dbDataSet As PAP_09.art_esp_dbDataSet
    Friend WithEvents ArmazensBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArmazensTableAdapter As PAP_09.art_esp_dbDataSetTableAdapters.armazensTableAdapter
    Friend WithEvents TableAdapterManager As PAP_09.art_esp_dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Id_armTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OutrosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RuaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cod_PostalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaisTextBox As System.Windows.Forms.ComboBox
End Class
