<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class op_pag
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
        Me.ID_PagamentoTextBox = New System.Windows.Forms.TextBox()
        Me.PagamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_papDataSet = New PAP_09.db_papDataSet()
        Me.Data_PagamentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.N_TransicaoTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PagamentoTableAdapter = New PAP_09.db_papDataSetTableAdapters.PagamentoTableAdapter()
        Me.TableAdapterManager = New PAP_09.db_papDataSetTableAdapters.TableAdapterManager()
        Me.TipoTextBox = New System.Windows.Forms.ComboBox()
        Me.EncomendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EncomendaTableAdapter = New PAP_09.db_papDataSetTableAdapters.EncomendaTableAdapter()
        ID_PagamentoLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        Data_PagamentoLabel = New System.Windows.Forms.Label()
        N_TransicaoLabel = New System.Windows.Forms.Label()
        CType(Me.PagamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_papDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EncomendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_PagamentoLabel
        '
        ID_PagamentoLabel.AutoSize = True
        ID_PagamentoLabel.Location = New System.Drawing.Point(22, 44)
        ID_PagamentoLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        ID_PagamentoLabel.Name = "ID_PagamentoLabel"
        ID_PagamentoLabel.Size = New System.Drawing.Size(153, 25)
        ID_PagamentoLabel.TabIndex = 1
        ID_PagamentoLabel.Text = "ID Pagamento:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Location = New System.Drawing.Point(22, 94)
        TipoLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(60, 25)
        TipoLabel.TabIndex = 3
        TipoLabel.Text = "Tipo:"
        '
        'Data_PagamentoLabel
        '
        Data_PagamentoLabel.AutoSize = True
        Data_PagamentoLabel.Location = New System.Drawing.Point(22, 146)
        Data_PagamentoLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Data_PagamentoLabel.Name = "Data_PagamentoLabel"
        Data_PagamentoLabel.Size = New System.Drawing.Size(178, 25)
        Data_PagamentoLabel.TabIndex = 5
        Data_PagamentoLabel.Text = "Data Pagamento:"
        '
        'N_TransicaoLabel
        '
        N_TransicaoLabel.AutoSize = True
        N_TransicaoLabel.Location = New System.Drawing.Point(22, 194)
        N_TransicaoLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        N_TransicaoLabel.Name = "N_TransicaoLabel"
        N_TransicaoLabel.Size = New System.Drawing.Size(209, 25)
        N_TransicaoLabel.TabIndex = 7
        N_TransicaoLabel.Text = "N Transicao/ ID Enc:"
        '
        'ID_PagamentoTextBox
        '
        Me.ID_PagamentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagamentoBindingSource, "ID_Pagamento", True))
        Me.ID_PagamentoTextBox.Location = New System.Drawing.Point(236, 44)
        Me.ID_PagamentoTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.ID_PagamentoTextBox.Name = "ID_PagamentoTextBox"
        Me.ID_PagamentoTextBox.Size = New System.Drawing.Size(396, 31)
        Me.ID_PagamentoTextBox.TabIndex = 2
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
        'Data_PagamentoDateTimePicker
        '
        Me.Data_PagamentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PagamentoBindingSource, "Data_Pagamento", True))
        Me.Data_PagamentoDateTimePicker.Location = New System.Drawing.Point(236, 144)
        Me.Data_PagamentoDateTimePicker.Margin = New System.Windows.Forms.Padding(6)
        Me.Data_PagamentoDateTimePicker.Name = "Data_PagamentoDateTimePicker"
        Me.Data_PagamentoDateTimePicker.Size = New System.Drawing.Size(396, 31)
        Me.Data_PagamentoDateTimePicker.TabIndex = 6
        '
        'N_TransicaoTextBox
        '
        Me.N_TransicaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagamentoBindingSource, "N_Transicao", True))
        Me.N_TransicaoTextBox.Location = New System.Drawing.Point(236, 194)
        Me.N_TransicaoTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.N_TransicaoTextBox.MaxLength = 20
        Me.N_TransicaoTextBox.Name = "N_TransicaoTextBox"
        Me.N_TransicaoTextBox.ReadOnly = True
        Me.N_TransicaoTextBox.Size = New System.Drawing.Size(396, 31)
        Me.N_TransicaoTextBox.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(2, 263)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(627, 121)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Inserir Pagamento"
        Me.Button1.UseVisualStyleBackColor = True
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
        'TipoTextBox
        '
        Me.TipoTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TipoTextBox.FormattingEnabled = True
        Me.TipoTextBox.Items.AddRange(New Object() {"TRANSFERÊNCIA BANCÁRIA" & Global.Microsoft.VisualBasic.ChrW(9), "MB WAY", "PAYPAL", "CARTÃO DE CRÉDITO/ CARTÃO DE DÉBITO", "APPLE PAY", "CHEQUE BANCÁRIO ", "MONETÁRIO"})
        Me.TipoTextBox.Location = New System.Drawing.Point(236, 94)
        Me.TipoTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(396, 33)
        Me.TipoTextBox.TabIndex = 75
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
        'op_pag
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 414)
        Me.Controls.Add(Me.TipoTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ID_PagamentoLabel)
        Me.Controls.Add(Me.ID_PagamentoTextBox)
        Me.Controls.Add(TipoLabel)
        Me.Controls.Add(Data_PagamentoLabel)
        Me.Controls.Add(Me.Data_PagamentoDateTimePicker)
        Me.Controls.Add(N_TransicaoLabel)
        Me.Controls.Add(Me.N_TransicaoTextBox)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "op_pag"
        Me.Text = "Pagamento da Encomenda"
        CType(Me.PagamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_papDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EncomendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Db_papDataSet As PAP_09.db_papDataSet
    Friend WithEvents PagamentoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PagamentoTableAdapter As PAP_09.db_papDataSetTableAdapters.PagamentoTableAdapter
    Friend WithEvents TableAdapterManager As PAP_09.db_papDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ID_PagamentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Data_PagamentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents N_TransicaoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TipoTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents EncomendaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EncomendaTableAdapter As PAP_09.db_papDataSetTableAdapters.EncomendaTableAdapter
End Class
