<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deleteenc
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtdelete = New System.Windows.Forms.TextBox()
        Me.deleteid = New System.Windows.Forms.Button()
        Me.Db_papDataSet = New PAP_09.db_papDataSet()
        Me.EncomendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EncomendaTableAdapter = New PAP_09.db_papDataSetTableAdapters.EncomendaTableAdapter()
        Me.TableAdapterManager = New PAP_09.db_papDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Db_papDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EncomendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(129, 170)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 68)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "Fechar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtdelete)
        Me.GroupBox2.Controls.Add(Me.deleteid)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(251, 142)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Apagar"
        '
        'txtdelete
        '
        Me.txtdelete.Location = New System.Drawing.Point(6, 48)
        Me.txtdelete.Name = "txtdelete"
        Me.txtdelete.Size = New System.Drawing.Size(100, 20)
        Me.txtdelete.TabIndex = 51
        '
        'deleteid
        '
        Me.deleteid.Location = New System.Drawing.Point(112, 31)
        Me.deleteid.Name = "deleteid"
        Me.deleteid.Size = New System.Drawing.Size(133, 52)
        Me.deleteid.TabIndex = 38
        Me.deleteid.Text = "Apagar Encomenda"
        Me.deleteid.UseVisualStyleBackColor = True
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
        'deleteenc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 280)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "deleteenc"
        Me.Text = "deleteenc"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Db_papDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EncomendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdelete As System.Windows.Forms.TextBox
    Friend WithEvents deleteid As System.Windows.Forms.Button
    Friend WithEvents Db_papDataSet As PAP_09.db_papDataSet
    Friend WithEvents EncomendaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EncomendaTableAdapter As PAP_09.db_papDataSetTableAdapters.EncomendaTableAdapter
    Friend WithEvents TableAdapterManager As PAP_09.db_papDataSetTableAdapters.TableAdapterManager
End Class
