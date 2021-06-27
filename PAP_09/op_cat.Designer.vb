<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class op_cat
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
        Dim DescricaoLabel As System.Windows.Forms.Label
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
        Me.ID_CatTextBox = New System.Windows.Forms.TextBox()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_papDataSet = New PAP_09.db_papDataSet()
        Me.DescricaoTextBox = New System.Windows.Forms.TextBox()
        Me.save = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.numreg = New System.Windows.Forms.TextBox()
        Me.search = New System.Windows.Forms.Button()
        Me.insert = New System.Windows.Forms.Button()
        Me.CategoriaTableAdapter = New PAP_09.db_papDataSetTableAdapters.CategoriaTableAdapter()
        Me.TableAdapterManager = New PAP_09.db_papDataSetTableAdapters.TableAdapterManager()
        ID_CatLabel = New System.Windows.Forms.Label()
        DescricaoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_papDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_CatLabel
        '
        ID_CatLabel.AutoSize = True
        ID_CatLabel.Location = New System.Drawing.Point(28, 42)
        ID_CatLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        ID_CatLabel.Name = "ID_CatLabel"
        ID_CatLabel.Size = New System.Drawing.Size(77, 25)
        ID_CatLabel.TabIndex = 77
        ID_CatLabel.Text = "ID Cat:"
        '
        'DescricaoLabel
        '
        DescricaoLabel.AutoSize = True
        DescricaoLabel.Location = New System.Drawing.Point(28, 92)
        DescricaoLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        DescricaoLabel.Name = "DescricaoLabel"
        DescricaoLabel.Size = New System.Drawing.Size(114, 25)
        DescricaoLabel.TabIndex = 79
        DescricaoLabel.Text = "Descrição:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(2, 69)
        Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(113, 25)
        Label1.TabIndex = 78
        Label1.Text = "Nome Cat:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Label1)
        Me.GroupBox3.Controls.Add(Me.update)
        Me.GroupBox3.Controls.Add(Me.updatetext)
        Me.GroupBox3.Location = New System.Drawing.Point(1142, 165)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox3.Size = New System.Drawing.Size(589, 167)
        Me.GroupBox3.TabIndex = 76
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Alterar"
        '
        'update
        '
        Me.update.Location = New System.Drawing.Point(335, 62)
        Me.update.Margin = New System.Windows.Forms.Padding(6)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(234, 44)
        Me.update.TabIndex = 39
        Me.update.Text = "Atualizar Dados"
        Me.update.UseVisualStyleBackColor = True
        '
        'updatetext
        '
        Me.updatetext.Location = New System.Drawing.Point(127, 69)
        Me.updatetext.Margin = New System.Windows.Forms.Padding(6)
        Me.updatetext.Name = "updatetext"
        Me.updatetext.Size = New System.Drawing.Size(196, 31)
        Me.updatetext.TabIndex = 40
        '
        'endsearch
        '
        Me.endsearch.Location = New System.Drawing.Point(230, 398)
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
        Me.searchlayer.Location = New System.Drawing.Point(790, 23)
        Me.searchlayer.Margin = New System.Windows.Forms.Padding(6)
        Me.searchlayer.Name = "searchlayer"
        Me.searchlayer.Size = New System.Drawing.Size(345, 130)
        Me.searchlayer.TabIndex = 74
        Me.searchlayer.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtdelete)
        Me.GroupBox2.Controls.Add(Me.deletenome)
        Me.GroupBox2.Controls.Add(Me.deleteid)
        Me.GroupBox2.Location = New System.Drawing.Point(606, 154)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Size = New System.Drawing.Size(502, 212)
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
        Me.deletenome.Location = New System.Drawing.Point(242, 67)
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
        Me.layerdelete.Location = New System.Drawing.Point(382, 23)
        Me.layerdelete.Margin = New System.Windows.Forms.Padding(6)
        Me.layerdelete.Name = "layerdelete"
        Me.layerdelete.Size = New System.Drawing.Size(378, 130)
        Me.layerdelete.TabIndex = 72
        Me.layerdelete.UseVisualStyleBackColor = True
        '
        'insertlayer
        '
        Me.insertlayer.Image = Global.PAP_09.My.Resources.Resources.f3f305dd9e1
        Me.insertlayer.Location = New System.Drawing.Point(50, 23)
        Me.insertlayer.Margin = New System.Windows.Forms.Padding(6)
        Me.insertlayer.Name = "insertlayer"
        Me.insertlayer.Size = New System.Drawing.Size(309, 130)
        Me.insertlayer.TabIndex = 71
        Me.insertlayer.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(ID_CatLabel)
        Me.GroupBox1.Controls.Add(Me.ID_CatTextBox)
        Me.GroupBox1.Controls.Add(Me.DescricaoTextBox)
        Me.GroupBox1.Controls.Add(DescricaoLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 165)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(538, 138)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados"
        '
        'ID_CatTextBox
        '
        Me.ID_CatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriaBindingSource, "ID_Cat", True))
        Me.ID_CatTextBox.Location = New System.Drawing.Point(156, 37)
        Me.ID_CatTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.ID_CatTextBox.Name = "ID_CatTextBox"
        Me.ID_CatTextBox.Size = New System.Drawing.Size(196, 31)
        Me.ID_CatTextBox.TabIndex = 78
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "Categoria"
        Me.CategoriaBindingSource.DataSource = Me.Db_papDataSet
        '
        'Db_papDataSet
        '
        Me.Db_papDataSet.DataSetName = "db_papDataSet"
        Me.Db_papDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DescricaoTextBox
        '
        Me.DescricaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriaBindingSource, "Descricao", True))
        Me.DescricaoTextBox.Location = New System.Drawing.Point(156, 87)
        Me.DescricaoTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.DescricaoTextBox.Name = "DescricaoTextBox"
        Me.DescricaoTextBox.Size = New System.Drawing.Size(196, 31)
        Me.DescricaoTextBox.TabIndex = 80
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(50, 398)
        Me.save.Margin = New System.Windows.Forms.Padding(6)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(150, 44)
        Me.save.TabIndex = 69
        Me.save.Text = "Guardar atualização"
        Me.save.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 537)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 44)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "Limpar CX"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'numreg
        '
        Me.numreg.Location = New System.Drawing.Point(24, 592)
        Me.numreg.Margin = New System.Windows.Forms.Padding(6)
        Me.numreg.Name = "numreg"
        Me.numreg.ReadOnly = True
        Me.numreg.Size = New System.Drawing.Size(434, 31)
        Me.numreg.TabIndex = 67
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(230, 342)
        Me.search.Margin = New System.Windows.Forms.Padding(6)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(150, 44)
        Me.search.TabIndex = 66
        Me.search.Text = "Procurar"
        Me.search.UseVisualStyleBackColor = True
        '
        'insert
        '
        Me.insert.Location = New System.Drawing.Point(50, 342)
        Me.insert.Margin = New System.Windows.Forms.Padding(6)
        Me.insert.Name = "insert"
        Me.insert.Size = New System.Drawing.Size(150, 44)
        Me.insert.TabIndex = 65
        Me.insert.Text = "Inserir"
        Me.insert.UseVisualStyleBackColor = True
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArtigosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriaTableAdapter = Me.CategoriaTableAdapter
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.Encomenda_DetalhesTableAdapter = Nothing
        Me.TableAdapterManager.EncomendaTableAdapter = Nothing
        Me.TableAdapterManager.FornecedorTableAdapter = Nothing
        Me.TableAdapterManager.PagamentoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PAP_09.db_papDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'op_cat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1799, 697)
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
        Me.Name = "op_cat"
        Me.Text = "Categorias"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CategoriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriaTableAdapter As PAP_09.db_papDataSetTableAdapters.CategoriaTableAdapter
    Friend WithEvents TableAdapterManager As PAP_09.db_papDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ID_CatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescricaoTextBox As System.Windows.Forms.TextBox
End Class
