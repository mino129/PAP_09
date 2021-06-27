<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class op_pagv2
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
        Dim ID_PagamentoLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim Data_PagamentoLabel As System.Windows.Forms.Label
        Dim N_TransicaoLabel As System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.TipoTextBox = New System.Windows.Forms.ComboBox()
        Me.ID_PagamentoTextBox = New System.Windows.Forms.TextBox()
        Me.PagamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_papDataSet = New PAP_09.db_papDataSet()
        Me.N_TransicaoTextBox = New System.Windows.Forms.TextBox()
        Me.Data_PagamentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.save = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.numreg = New System.Windows.Forms.TextBox()
        Me.search = New System.Windows.Forms.Button()
        Me.insert = New System.Windows.Forms.Button()
        Me.PagamentoTableAdapter = New PAP_09.db_papDataSetTableAdapters.PagamentoTableAdapter()
        Me.TableAdapterManager = New PAP_09.db_papDataSetTableAdapters.TableAdapterManager()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.tipopag = New System.Windows.Forms.TextBox()
        ID_PagamentoLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        Data_PagamentoLabel = New System.Windows.Forms.Label()
        N_TransicaoLabel = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PagamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_papDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_PagamentoLabel
        '
        ID_PagamentoLabel.AutoSize = True
        ID_PagamentoLabel.Location = New System.Drawing.Point(0, 69)
        ID_PagamentoLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        ID_PagamentoLabel.Name = "ID_PagamentoLabel"
        ID_PagamentoLabel.Size = New System.Drawing.Size(153, 25)
        ID_PagamentoLabel.TabIndex = 72
        ID_PagamentoLabel.Text = "ID Pagamento:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Location = New System.Drawing.Point(0, 123)
        TipoLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(60, 25)
        TipoLabel.TabIndex = 74
        TipoLabel.Text = "Tipo:"
        '
        'Data_PagamentoLabel
        '
        Data_PagamentoLabel.AutoSize = True
        Data_PagamentoLabel.Location = New System.Drawing.Point(0, 171)
        Data_PagamentoLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Data_PagamentoLabel.Name = "Data_PagamentoLabel"
        Data_PagamentoLabel.Size = New System.Drawing.Size(178, 25)
        Data_PagamentoLabel.TabIndex = 76
        Data_PagamentoLabel.Text = "Data Pagamento:"
        '
        'N_TransicaoLabel
        '
        N_TransicaoLabel.AutoSize = True
        N_TransicaoLabel.Location = New System.Drawing.Point(0, 219)
        N_TransicaoLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        N_TransicaoLabel.Name = "N_TransicaoLabel"
        N_TransicaoLabel.Size = New System.Drawing.Size(134, 25)
        N_TransicaoLabel.TabIndex = 78
        N_TransicaoLabel.Text = "N Transicao:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(252, 676)
        Me.Button3.Margin = New System.Windows.Forms.Padding(6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 44)
        Me.Button3.TabIndex = 71
        Me.Button3.Text = "Concluir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.update)
        Me.GroupBox3.Controls.Add(Me.updatetext)
        Me.GroupBox3.Location = New System.Drawing.Point(1236, 289)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox3.Size = New System.Drawing.Size(572, 277)
        Me.GroupBox3.TabIndex = 70
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Alterar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 25)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "ID Pag:"
        '
        'update
        '
        Me.update.Location = New System.Drawing.Point(313, 80)
        Me.update.Margin = New System.Windows.Forms.Padding(6)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(234, 44)
        Me.update.TabIndex = 22
        Me.update.Text = "Atualizar Dados"
        Me.update.UseVisualStyleBackColor = True
        '
        'updatetext
        '
        Me.updatetext.Location = New System.Drawing.Point(105, 83)
        Me.updatetext.Margin = New System.Windows.Forms.Padding(6)
        Me.updatetext.Name = "updatetext"
        Me.updatetext.Size = New System.Drawing.Size(196, 31)
        Me.updatetext.TabIndex = 23
        '
        'searchlayer
        '
        Me.searchlayer.Image = Global.PAP_09.My.Resources.Resources._585e4ae9cb11b227491c3394
        Me.searchlayer.Location = New System.Drawing.Point(672, 40)
        Me.searchlayer.Margin = New System.Windows.Forms.Padding(6)
        Me.searchlayer.Name = "searchlayer"
        Me.searchlayer.Size = New System.Drawing.Size(264, 184)
        Me.searchlayer.TabIndex = 69
        Me.searchlayer.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.deletenome)
        Me.GroupBox2.Controls.Add(Me.deleteid)
        Me.GroupBox2.Controls.Add(Me.txtdelete)
        Me.GroupBox2.Location = New System.Drawing.Point(688, 286)
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
        Me.Button2.Location = New System.Drawing.Point(352, 40)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(264, 184)
        Me.Button2.TabIndex = 67
        Me.Button2.UseVisualStyleBackColor = True
        '
        'insertlayer
        '
        Me.insertlayer.Image = Global.PAP_09.My.Resources.Resources.f3f305dd9e1
        Me.insertlayer.Location = New System.Drawing.Point(44, 40)
        Me.insertlayer.Margin = New System.Windows.Forms.Padding(6)
        Me.insertlayer.Name = "insertlayer"
        Me.insertlayer.Size = New System.Drawing.Size(264, 184)
        Me.insertlayer.TabIndex = 66
        Me.insertlayer.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TipoTextBox)
        Me.GroupBox1.Controls.Add(ID_PagamentoLabel)
        Me.GroupBox1.Controls.Add(Me.ID_PagamentoTextBox)
        Me.GroupBox1.Controls.Add(Me.N_TransicaoTextBox)
        Me.GroupBox1.Controls.Add(TipoLabel)
        Me.GroupBox1.Controls.Add(N_TransicaoLabel)
        Me.GroupBox1.Controls.Add(Me.Data_PagamentoDateTimePicker)
        Me.GroupBox1.Controls.Add(Data_PagamentoLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 259)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(650, 308)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados"
        '
        'TipoTextBox
        '
        Me.TipoTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TipoTextBox.FormattingEnabled = True
        Me.TipoTextBox.Items.AddRange(New Object() {"TRANSFERÊNCIA BANCÁRIA" & Global.Microsoft.VisualBasic.ChrW(9), "MB WAY", "PAYPAL", "CARTÃO DE CRÉDITO/ CARTÃO DE DÉBITO", "APPLE PAY", "CHEQUE BANCÁRIO ", "MONETÁRIO"})
        Me.TipoTextBox.Location = New System.Drawing.Point(192, 113)
        Me.TipoTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(396, 33)
        Me.TipoTextBox.TabIndex = 72
        '
        'ID_PagamentoTextBox
        '
        Me.ID_PagamentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagamentoBindingSource, "ID_Pagamento", True))
        Me.ID_PagamentoTextBox.Location = New System.Drawing.Point(192, 63)
        Me.ID_PagamentoTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.ID_PagamentoTextBox.Name = "ID_PagamentoTextBox"
        Me.ID_PagamentoTextBox.Size = New System.Drawing.Size(396, 31)
        Me.ID_PagamentoTextBox.TabIndex = 73
        '
        'PagamentoBindingSource
        '
        Me.PagamentoBindingSource.DataMember = "Pagamento"
        Me.PagamentoBindingSource.DataSource = Me.Db_papDataSet
        '
        'Db_papDataSet
        '
        Me.Db_papDataSet.DataSetName = "db_papDataSet"
        Me.Db_papDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'N_TransicaoTextBox
        '
        Me.N_TransicaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagamentoBindingSource, "N_Transicao", True))
        Me.N_TransicaoTextBox.Location = New System.Drawing.Point(192, 213)
        Me.N_TransicaoTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.N_TransicaoTextBox.Name = "N_TransicaoTextBox"
        Me.N_TransicaoTextBox.Size = New System.Drawing.Size(396, 31)
        Me.N_TransicaoTextBox.TabIndex = 79
        '
        'Data_PagamentoDateTimePicker
        '
        Me.Data_PagamentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PagamentoBindingSource, "Data_Pagamento", True))
        Me.Data_PagamentoDateTimePicker.Location = New System.Drawing.Point(192, 163)
        Me.Data_PagamentoDateTimePicker.Margin = New System.Windows.Forms.Padding(6)
        Me.Data_PagamentoDateTimePicker.Name = "Data_PagamentoDateTimePicker"
        Me.Data_PagamentoDateTimePicker.Size = New System.Drawing.Size(396, 31)
        Me.Data_PagamentoDateTimePicker.TabIndex = 77
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(54, 676)
        Me.save.Margin = New System.Windows.Forms.Padding(6)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(150, 44)
        Me.save.TabIndex = 64
        Me.save.Text = "Atualizar"
        Me.save.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(48, 741)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 44)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "Limpar CX"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'numreg
        '
        Me.numreg.Location = New System.Drawing.Point(42, 797)
        Me.numreg.Margin = New System.Windows.Forms.Padding(6)
        Me.numreg.Name = "numreg"
        Me.numreg.ReadOnly = True
        Me.numreg.Size = New System.Drawing.Size(434, 31)
        Me.numreg.TabIndex = 62
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(252, 620)
        Me.search.Margin = New System.Windows.Forms.Padding(6)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(150, 44)
        Me.search.TabIndex = 61
        Me.search.Text = "Procurar"
        Me.search.UseVisualStyleBackColor = True
        '
        'insert
        '
        Me.insert.Location = New System.Drawing.Point(54, 620)
        Me.insert.Margin = New System.Windows.Forms.Padding(6)
        Me.insert.Name = "insert"
        Me.insert.Size = New System.Drawing.Size(150, 44)
        Me.insert.TabIndex = 60
        Me.insert.Text = "Inserir"
        Me.insert.UseVisualStyleBackColor = True
        '
        'PagamentoTableAdapter
        '
        Me.PagamentoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArtigosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriaTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.Encomenda_DetalhesTableAdapter = Nothing
        Me.TableAdapterManager.EncomendaTableAdapter = Nothing
        Me.TableAdapterManager.FornecedorTableAdapter = Nothing
        Me.TableAdapterManager.PagamentoTableAdapter = Me.PagamentoTableAdapter
        Me.TableAdapterManager.UpdateOrder = PAP_09.db_papDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(910, 497)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(197, 58)
        Me.Button4.TabIndex = 72
        Me.Button4.Text = "Inserir tipo de pag"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'tipopag
        '
        Me.tipopag.Location = New System.Drawing.Point(688, 497)
        Me.tipopag.Name = "tipopag"
        Me.tipopag.Size = New System.Drawing.Size(194, 31)
        Me.tipopag.TabIndex = 73
        '
        'op_pagv2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1844, 817)
        Me.Controls.Add(Me.tipopag)
        Me.Controls.Add(Me.Button4)
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
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "op_pagv2"
        Me.Text = "Pagamentos"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PagamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_papDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Db_papDataSet As PAP_09.db_papDataSet
    Friend WithEvents PagamentoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PagamentoTableAdapter As PAP_09.db_papDataSetTableAdapters.PagamentoTableAdapter
    Friend WithEvents TableAdapterManager As PAP_09.db_papDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ID_PagamentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents N_TransicaoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Data_PagamentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TipoTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents tipopag As System.Windows.Forms.TextBox
End Class
