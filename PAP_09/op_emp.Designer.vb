<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class op_emp
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
        Dim ID_empLabel As System.Windows.Forms.Label
        Dim Emp_nomeLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim E_mailLabel As System.Windows.Forms.Label
        Dim MoradaLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim Cod_PostalLabel As System.Windows.Forms.Label
        Dim PaisLabel As System.Windows.Forms.Label
        Dim Job_nameLabel As System.Windows.Forms.Label
        Dim Manager_idLabel As System.Windows.Forms.Label
        Dim Hire_dateLabel As System.Windows.Forms.Label
        Dim SalaryLabel As System.Windows.Forms.Label
        Dim Dep_idLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.update = New System.Windows.Forms.Button()
        Me.updatetext = New System.Windows.Forms.TextBox()
        Me.searchlayer = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.deletenome = New System.Windows.Forms.Button()
        Me.deleteid = New System.Windows.Forms.Button()
        Me.txtdelete = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.insertlayer = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Dep_idTextBox = New System.Windows.Forms.ComboBox()
        Me.DepBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Employeedb_papDataSet = New PAP_09.employeedb_papDataSet()
        Me.PaisTextBox = New System.Windows.Forms.ComboBox()
        Me.ID_empTextBox = New System.Windows.Forms.TextBox()
        Me.EMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Emp_nomeTextBox = New System.Windows.Forms.TextBox()
        Me.SalaryTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.Hire_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.E_mailTextBox = New System.Windows.Forms.TextBox()
        Me.Manager_idTextBox = New System.Windows.Forms.TextBox()
        Me.MoradaTextBox = New System.Windows.Forms.TextBox()
        Me.Job_nameTextBox = New System.Windows.Forms.TextBox()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.Cod_PostalTextBox = New System.Windows.Forms.TextBox()
        Me.save = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.numreg = New System.Windows.Forms.TextBox()
        Me.search = New System.Windows.Forms.Button()
        Me.insert = New System.Windows.Forms.Button()
        Me.EMPTableAdapter = New PAP_09.employeedb_papDataSetTableAdapters.EMPTableAdapter()
        Me.TableAdapterManager = New PAP_09.employeedb_papDataSetTableAdapters.TableAdapterManager()
        Me.DepTableAdapter = New PAP_09.employeedb_papDataSetTableAdapters.depTableAdapter()
        ID_empLabel = New System.Windows.Forms.Label()
        Emp_nomeLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        E_mailLabel = New System.Windows.Forms.Label()
        MoradaLabel = New System.Windows.Forms.Label()
        CidadeLabel = New System.Windows.Forms.Label()
        Cod_PostalLabel = New System.Windows.Forms.Label()
        PaisLabel = New System.Windows.Forms.Label()
        Job_nameLabel = New System.Windows.Forms.Label()
        Manager_idLabel = New System.Windows.Forms.Label()
        Hire_dateLabel = New System.Windows.Forms.Label()
        SalaryLabel = New System.Windows.Forms.Label()
        Dep_idLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DepBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Employeedb_papDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_empLabel
        '
        ID_empLabel.AutoSize = True
        ID_empLabel.Location = New System.Drawing.Point(17, 36)
        ID_empLabel.Name = "ID_empLabel"
        ID_empLabel.Size = New System.Drawing.Size(85, 25)
        ID_empLabel.TabIndex = 72
        ID_empLabel.Text = "ID emp:"
        '
        'Emp_nomeLabel
        '
        Emp_nomeLabel.AutoSize = True
        Emp_nomeLabel.Location = New System.Drawing.Point(17, 73)
        Emp_nomeLabel.Name = "Emp_nomeLabel"
        Emp_nomeLabel.Size = New System.Drawing.Size(160, 25)
        Emp_nomeLabel.TabIndex = 74
        Emp_nomeLabel.Text = "Nome(Alcunha)"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(17, 110)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(171, 25)
        NomeLabel.TabIndex = 76
        NomeLabel.Text = "Nome Completo:"
        '
        'E_mailLabel
        '
        E_mailLabel.AutoSize = True
        E_mailLabel.Location = New System.Drawing.Point(17, 147)
        E_mailLabel.Name = "E_mailLabel"
        E_mailLabel.Size = New System.Drawing.Size(78, 25)
        E_mailLabel.TabIndex = 78
        E_mailLabel.Text = "E-mail:"
        '
        'MoradaLabel
        '
        MoradaLabel.AutoSize = True
        MoradaLabel.Location = New System.Drawing.Point(17, 184)
        MoradaLabel.Name = "MoradaLabel"
        MoradaLabel.Size = New System.Drawing.Size(91, 25)
        MoradaLabel.TabIndex = 80
        MoradaLabel.Text = "Morada:"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Location = New System.Drawing.Point(17, 221)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(86, 25)
        CidadeLabel.TabIndex = 82
        CidadeLabel.Text = "Cidade:"
        '
        'Cod_PostalLabel
        '
        Cod_PostalLabel.AutoSize = True
        Cod_PostalLabel.Location = New System.Drawing.Point(17, 258)
        Cod_PostalLabel.Name = "Cod_PostalLabel"
        Cod_PostalLabel.Size = New System.Drawing.Size(123, 25)
        Cod_PostalLabel.TabIndex = 84
        Cod_PostalLabel.Text = "Cod Postal:"
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.Location = New System.Drawing.Point(17, 295)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(60, 25)
        PaisLabel.TabIndex = 86
        PaisLabel.Text = "Pais:"
        '
        'Job_nameLabel
        '
        Job_nameLabel.AutoSize = True
        Job_nameLabel.Location = New System.Drawing.Point(17, 332)
        Job_nameLabel.Name = "Job_nameLabel"
        Job_nameLabel.Size = New System.Drawing.Size(178, 25)
        Job_nameLabel.TabIndex = 88
        Job_nameLabel.Text = "Descriçao Cargo:"
        '
        'Manager_idLabel
        '
        Manager_idLabel.AutoSize = True
        Manager_idLabel.Location = New System.Drawing.Point(17, 369)
        Manager_idLabel.Name = "Manager_idLabel"
        Manager_idLabel.Size = New System.Drawing.Size(125, 25)
        Manager_idLabel.TabIndex = 90
        Manager_idLabel.Text = "manager id:"
        Manager_idLabel.Visible = False
        '
        'Hire_dateLabel
        '
        Hire_dateLabel.AutoSize = True
        Hire_dateLabel.Location = New System.Drawing.Point(17, 370)
        Hire_dateLabel.Name = "Hire_dateLabel"
        Hire_dateLabel.Size = New System.Drawing.Size(182, 25)
        Hire_dateLabel.TabIndex = 92
        Hire_dateLabel.Text = "Data contratação:"
        '
        'SalaryLabel
        '
        SalaryLabel.AutoSize = True
        SalaryLabel.Location = New System.Drawing.Point(17, 406)
        SalaryLabel.Name = "SalaryLabel"
        SalaryLabel.Size = New System.Drawing.Size(85, 25)
        SalaryLabel.TabIndex = 94
        SalaryLabel.Text = "Salario:"
        '
        'Dep_idLabel
        '
        Dep_idLabel.AutoSize = True
        Dep_idLabel.Location = New System.Drawing.Point(17, 443)
        Dep_idLabel.Name = "Dep_idLabel"
        Dep_idLabel.Size = New System.Drawing.Size(147, 25)
        Dep_idLabel.TabIndex = 96
        Dep_idLabel.Text = "Departamento"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(9, 82)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(166, 25)
        Label1.TabIndex = 75
        Label1.Text = "Nome(Alcunha):"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(215, 834)
        Me.Button3.Margin = New System.Windows.Forms.Padding(6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 44)
        Me.Button3.TabIndex = 71
        Me.Button3.Text = "Concluir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Label1)
        Me.GroupBox3.Controls.Add(Me.update)
        Me.GroupBox3.Controls.Add(Me.updatetext)
        Me.GroupBox3.Location = New System.Drawing.Point(1043, 283)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox3.Size = New System.Drawing.Size(640, 162)
        Me.GroupBox3.TabIndex = 70
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Alterar"
        '
        'update
        '
        Me.update.Location = New System.Drawing.Point(393, 66)
        Me.update.Margin = New System.Windows.Forms.Padding(6)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(234, 44)
        Me.update.TabIndex = 22
        Me.update.Text = "Atualizar Dados"
        Me.update.UseVisualStyleBackColor = True
        '
        'updatetext
        '
        Me.updatetext.Location = New System.Drawing.Point(185, 79)
        Me.updatetext.Margin = New System.Windows.Forms.Padding(6)
        Me.updatetext.Name = "updatetext"
        Me.updatetext.Size = New System.Drawing.Size(196, 31)
        Me.updatetext.TabIndex = 23
        '
        'searchlayer
        '
        Me.searchlayer.Image = Global.PAP_09.My.Resources.Resources._585e4ae9cb11b227491c3394
        Me.searchlayer.Location = New System.Drawing.Point(1160, 26)
        Me.searchlayer.Margin = New System.Windows.Forms.Padding(6)
        Me.searchlayer.Name = "searchlayer"
        Me.searchlayer.Size = New System.Drawing.Size(456, 201)
        Me.searchlayer.TabIndex = 69
        Me.searchlayer.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.deletenome)
        Me.GroupBox2.Controls.Add(Me.deleteid)
        Me.GroupBox2.Controls.Add(Me.txtdelete)
        Me.GroupBox2.Location = New System.Drawing.Point(495, 279)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Size = New System.Drawing.Size(502, 202)
        Me.GroupBox2.TabIndex = 68
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Apagar"
        '
        'deletenome
        '
        Me.deletenome.Location = New System.Drawing.Point(242, 54)
        Me.deletenome.Margin = New System.Windows.Forms.Padding(6)
        Me.deletenome.Name = "deletenome"
        Me.deletenome.Size = New System.Drawing.Size(234, 44)
        Me.deletenome.TabIndex = 20
        Me.deletenome.Text = "Apagar p/ Nome"
        Me.deletenome.UseVisualStyleBackColor = True
        '
        'deleteid
        '
        Me.deleteid.Location = New System.Drawing.Point(242, 121)
        Me.deleteid.Margin = New System.Windows.Forms.Padding(6)
        Me.deleteid.Name = "deleteid"
        Me.deleteid.Size = New System.Drawing.Size(234, 44)
        Me.deleteid.TabIndex = 21
        Me.deleteid.Text = "Apagar p/ ID"
        Me.deleteid.UseVisualStyleBackColor = True
        '
        'txtdelete
        '
        Me.txtdelete.Location = New System.Drawing.Point(12, 54)
        Me.txtdelete.Margin = New System.Windows.Forms.Padding(6)
        Me.txtdelete.Name = "txtdelete"
        Me.txtdelete.Size = New System.Drawing.Size(196, 108)
        Me.txtdelete.TabIndex = 25
        Me.txtdelete.Text = ""
        '
        'Button2
        '
        Me.Button2.Image = Global.PAP_09.My.Resources.Resources._61848
        Me.Button2.Location = New System.Drawing.Point(556, 26)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(520, 201)
        Me.Button2.TabIndex = 67
        Me.Button2.UseVisualStyleBackColor = True
        '
        'insertlayer
        '
        Me.insertlayer.Image = Global.PAP_09.My.Resources.Resources.f3f305dd9e1
        Me.insertlayer.Location = New System.Drawing.Point(17, 26)
        Me.insertlayer.Margin = New System.Windows.Forms.Padding(6)
        Me.insertlayer.Name = "insertlayer"
        Me.insertlayer.Size = New System.Drawing.Size(502, 201)
        Me.insertlayer.TabIndex = 66
        Me.insertlayer.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Dep_idTextBox)
        Me.GroupBox1.Controls.Add(Me.PaisTextBox)
        Me.GroupBox1.Controls.Add(ID_empLabel)
        Me.GroupBox1.Controls.Add(Me.ID_empTextBox)
        Me.GroupBox1.Controls.Add(Emp_nomeLabel)
        Me.GroupBox1.Controls.Add(Dep_idLabel)
        Me.GroupBox1.Controls.Add(Me.Emp_nomeTextBox)
        Me.GroupBox1.Controls.Add(Me.SalaryTextBox)
        Me.GroupBox1.Controls.Add(NomeLabel)
        Me.GroupBox1.Controls.Add(SalaryLabel)
        Me.GroupBox1.Controls.Add(Me.NomeTextBox)
        Me.GroupBox1.Controls.Add(Me.Hire_dateDateTimePicker)
        Me.GroupBox1.Controls.Add(E_mailLabel)
        Me.GroupBox1.Controls.Add(Hire_dateLabel)
        Me.GroupBox1.Controls.Add(Me.E_mailTextBox)
        Me.GroupBox1.Controls.Add(Me.Manager_idTextBox)
        Me.GroupBox1.Controls.Add(MoradaLabel)
        Me.GroupBox1.Controls.Add(Manager_idLabel)
        Me.GroupBox1.Controls.Add(Me.MoradaTextBox)
        Me.GroupBox1.Controls.Add(Me.Job_nameTextBox)
        Me.GroupBox1.Controls.Add(CidadeLabel)
        Me.GroupBox1.Controls.Add(Job_nameLabel)
        Me.GroupBox1.Controls.Add(Me.CidadeTextBox)
        Me.GroupBox1.Controls.Add(Cod_PostalLabel)
        Me.GroupBox1.Controls.Add(PaisLabel)
        Me.GroupBox1.Controls.Add(Me.Cod_PostalTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 273)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(466, 493)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados"
        '
        'Dep_idTextBox
        '
        Me.Dep_idTextBox.DataSource = Me.DepBindingSource
        Me.Dep_idTextBox.DisplayMember = "nome"
        Me.Dep_idTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Dep_idTextBox.FormattingEnabled = True
        Me.Dep_idTextBox.Location = New System.Drawing.Point(198, 435)
        Me.Dep_idTextBox.Name = "Dep_idTextBox"
        Me.Dep_idTextBox.Size = New System.Drawing.Size(250, 33)
        Me.Dep_idTextBox.TabIndex = 98
        Me.Dep_idTextBox.ValueMember = "ID_dep"
        '
        'DepBindingSource
        '
        Me.DepBindingSource.DataMember = "dep"
        Me.DepBindingSource.DataSource = Me.Employeedb_papDataSet
        '
        'Employeedb_papDataSet
        '
        Me.Employeedb_papDataSet.DataSetName = "employeedb_papDataSet"
        Me.Employeedb_papDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaisTextBox
        '
        Me.PaisTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PaisTextBox.FormattingEnabled = True
        Me.PaisTextBox.Items.AddRange(New Object() {"Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua & Deps", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Central African Rep", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo", "Congo {Democratic Rep}", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland {Republic}", "Israel", "Italy", "Ivory Coast", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea North", "Korea South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar, {Burma}", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russian Federation", "Rwanda", "St Kitts & Nevis", "St Lucia", "Saint Vincent & the Grenadines", "Samoa", "San Marino", "Sao Tome & Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Swaziland", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad & Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe"})
        Me.PaisTextBox.Location = New System.Drawing.Point(198, 287)
        Me.PaisTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.PaisTextBox.Name = "PaisTextBox"
        Me.PaisTextBox.Size = New System.Drawing.Size(250, 33)
        Me.PaisTextBox.TabIndex = 72
        '
        'ID_empTextBox
        '
        Me.ID_empTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPBindingSource, "ID_emp", True))
        Me.ID_empTextBox.Location = New System.Drawing.Point(198, 28)
        Me.ID_empTextBox.Name = "ID_empTextBox"
        Me.ID_empTextBox.Size = New System.Drawing.Size(250, 31)
        Me.ID_empTextBox.TabIndex = 73
        '
        'EMPBindingSource
        '
        Me.EMPBindingSource.DataMember = "EMP"
        Me.EMPBindingSource.DataSource = Me.Employeedb_papDataSet
        '
        'Emp_nomeTextBox
        '
        Me.Emp_nomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPBindingSource, "emp_nome", True))
        Me.Emp_nomeTextBox.Location = New System.Drawing.Point(198, 65)
        Me.Emp_nomeTextBox.Name = "Emp_nomeTextBox"
        Me.Emp_nomeTextBox.Size = New System.Drawing.Size(250, 31)
        Me.Emp_nomeTextBox.TabIndex = 75
        '
        'SalaryTextBox
        '
        Me.SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPBindingSource, "salary", True))
        Me.SalaryTextBox.Location = New System.Drawing.Point(198, 398)
        Me.SalaryTextBox.Name = "SalaryTextBox"
        Me.SalaryTextBox.Size = New System.Drawing.Size(250, 31)
        Me.SalaryTextBox.TabIndex = 95
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(198, 102)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(250, 31)
        Me.NomeTextBox.TabIndex = 77
        '
        'Hire_dateDateTimePicker
        '
        Me.Hire_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EMPBindingSource, "hire_date", True))
        Me.Hire_dateDateTimePicker.Location = New System.Drawing.Point(198, 361)
        Me.Hire_dateDateTimePicker.Name = "Hire_dateDateTimePicker"
        Me.Hire_dateDateTimePicker.Size = New System.Drawing.Size(250, 31)
        Me.Hire_dateDateTimePicker.TabIndex = 93
        '
        'E_mailTextBox
        '
        Me.E_mailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPBindingSource, "E-mail", True))
        Me.E_mailTextBox.Location = New System.Drawing.Point(198, 139)
        Me.E_mailTextBox.Name = "E_mailTextBox"
        Me.E_mailTextBox.Size = New System.Drawing.Size(250, 31)
        Me.E_mailTextBox.TabIndex = 79
        '
        'Manager_idTextBox
        '
        Me.Manager_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPBindingSource, "manager_id", True))
        Me.Manager_idTextBox.Location = New System.Drawing.Point(198, 361)
        Me.Manager_idTextBox.Name = "Manager_idTextBox"
        Me.Manager_idTextBox.Size = New System.Drawing.Size(200, 31)
        Me.Manager_idTextBox.TabIndex = 91
        Me.Manager_idTextBox.Visible = False
        '
        'MoradaTextBox
        '
        Me.MoradaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPBindingSource, "Morada", True))
        Me.MoradaTextBox.Location = New System.Drawing.Point(198, 176)
        Me.MoradaTextBox.Name = "MoradaTextBox"
        Me.MoradaTextBox.Size = New System.Drawing.Size(250, 31)
        Me.MoradaTextBox.TabIndex = 81
        '
        'Job_nameTextBox
        '
        Me.Job_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPBindingSource, "job_name", True))
        Me.Job_nameTextBox.Location = New System.Drawing.Point(198, 326)
        Me.Job_nameTextBox.Name = "Job_nameTextBox"
        Me.Job_nameTextBox.Size = New System.Drawing.Size(250, 31)
        Me.Job_nameTextBox.TabIndex = 89
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPBindingSource, "Cidade", True))
        Me.CidadeTextBox.Location = New System.Drawing.Point(198, 213)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(250, 31)
        Me.CidadeTextBox.TabIndex = 83
        '
        'Cod_PostalTextBox
        '
        Me.Cod_PostalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPBindingSource, "Cod_Postal", True))
        Me.Cod_PostalTextBox.Location = New System.Drawing.Point(198, 250)
        Me.Cod_PostalTextBox.Name = "Cod_PostalTextBox"
        Me.Cod_PostalTextBox.Size = New System.Drawing.Size(250, 31)
        Me.Cod_PostalTextBox.TabIndex = 85
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(17, 834)
        Me.save.Margin = New System.Windows.Forms.Padding(6)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(150, 44)
        Me.save.TabIndex = 64
        Me.save.Text = "Atualizar"
        Me.save.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 899)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 44)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "Limpar CX"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'numreg
        '
        Me.numreg.Location = New System.Drawing.Point(5, 955)
        Me.numreg.Margin = New System.Windows.Forms.Padding(6)
        Me.numreg.Name = "numreg"
        Me.numreg.ReadOnly = True
        Me.numreg.Size = New System.Drawing.Size(434, 31)
        Me.numreg.TabIndex = 62
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(215, 778)
        Me.search.Margin = New System.Windows.Forms.Padding(6)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(150, 44)
        Me.search.TabIndex = 61
        Me.search.Text = "Procurar"
        Me.search.UseVisualStyleBackColor = True
        '
        'insert
        '
        Me.insert.Location = New System.Drawing.Point(17, 778)
        Me.insert.Margin = New System.Windows.Forms.Padding(6)
        Me.insert.Name = "insert"
        Me.insert.Size = New System.Drawing.Size(150, 44)
        Me.insert.TabIndex = 60
        Me.insert.Text = "Inserir"
        Me.insert.UseVisualStyleBackColor = True
        '
        'EMPTableAdapter
        '
        Me.EMPTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.depTableAdapter = Nothing
        Me.TableAdapterManager.EMPTableAdapter = Me.EMPTableAdapter
        Me.TableAdapterManager.UpdateOrder = PAP_09.employeedb_papDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DepTableAdapter
        '
        Me.DepTableAdapter.ClearBeforeFill = True
        '
        'op_emp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1932, 1024)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.searchlayer)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.insertlayer)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.numreg)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.insert)
        Me.Name = "op_emp"
        Me.Text = "Empregados"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DepBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Employeedb_papDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents update As System.Windows.Forms.Button
    Friend WithEvents updatetext As System.Windows.Forms.TextBox
    Friend WithEvents searchlayer As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents deletenome As System.Windows.Forms.Button
    Friend WithEvents deleteid As System.Windows.Forms.Button
    Friend WithEvents txtdelete As System.Windows.Forms.RichTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents insertlayer As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents numreg As System.Windows.Forms.TextBox
    Friend WithEvents search As System.Windows.Forms.Button
    Friend WithEvents insert As System.Windows.Forms.Button
    Friend WithEvents Employeedb_papDataSet As PAP_09.employeedb_papDataSet
    Friend WithEvents EMPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPTableAdapter As PAP_09.employeedb_papDataSetTableAdapters.EMPTableAdapter
    Friend WithEvents TableAdapterManager As PAP_09.employeedb_papDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ID_empTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Emp_nomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SalaryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Hire_dateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents E_mailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Manager_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MoradaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Job_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cod_PostalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaisTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents Dep_idTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents DepBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepTableAdapter As PAP_09.employeedb_papDataSetTableAdapters.depTableAdapter
End Class
