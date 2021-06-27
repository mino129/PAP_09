<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class relenc
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.cv1 = New System.Windows.Forms.Button()
        Me.Db_papDataSet = New PAP_09.db_papDataSet()
        Me.EncomendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EncomendaTableAdapter = New PAP_09.db_papDataSetTableAdapters.EncomendaTableAdapter()
        Me.TableAdapterManager = New PAP_09.db_papDataSetTableAdapters.TableAdapterManager()
        Me.Encomenda_DetalhesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Encomenda_DetalhesTableAdapter = New PAP_09.db_papDataSetTableAdapters.Encomenda_DetalhesTableAdapter()
        CType(Me.Db_papDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EncomendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Encomenda_DetalhesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1568, 23)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(340, 140)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Fechar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(1778, 210)
        Me.clear.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(130, 73)
        Me.clear.TabIndex = 6
        Me.clear.Text = "Limpar"
        Me.clear.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(20, 210)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(1736, 729)
        Me.ListBox1.TabIndex = 5
        '
        'cv1
        '
        Me.cv1.Location = New System.Drawing.Point(64, 23)
        Me.cv1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cv1.Name = "cv1"
        Me.cv1.Size = New System.Drawing.Size(340, 140)
        Me.cv1.TabIndex = 4
        Me.cv1.Text = "Consultar Vendas"
        Me.cv1.UseVisualStyleBackColor = True
        '
        'Db_papDataSet
        '
        Me.Db_papDataSet.DataSetName = "db_papDataSet"
        Me.Db_papDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.ArtigosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriaTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.Encomenda_DetalhesTableAdapter = Nothing
        Me.TableAdapterManager.EncomendaTableAdapter = Me.EncomendaTableAdapter
        Me.TableAdapterManager.FornecedorTableAdapter = Nothing
        Me.TableAdapterManager.PagamentoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PAP_09.db_papDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Encomenda_DetalhesBindingSource
        '
        Me.Encomenda_DetalhesBindingSource.DataMember = "Encomenda_Detalhes"
        Me.Encomenda_DetalhesBindingSource.DataSource = Me.Db_papDataSet
        '
        'Encomenda_DetalhesTableAdapter
        '
        Me.Encomenda_DetalhesTableAdapter.ClearBeforeFill = True
        '
        'relenc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2148, 1023)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.cv1)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "relenc"
        Me.Text = "Relatorio"
        CType(Me.Db_papDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EncomendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Encomenda_DetalhesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents clear As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents cv1 As System.Windows.Forms.Button
    Friend WithEvents Db_papDataSet As PAP_09.db_papDataSet
    Friend WithEvents EncomendaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EncomendaTableAdapter As PAP_09.db_papDataSetTableAdapters.EncomendaTableAdapter
    Friend WithEvents TableAdapterManager As PAP_09.db_papDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Encomenda_DetalhesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Encomenda_DetalhesTableAdapter As PAP_09.db_papDataSetTableAdapters.Encomenda_DetalhesTableAdapter
End Class
