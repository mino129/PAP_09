<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class op_dep
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
        Dim ID_depLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.endsearch = New System.Windows.Forms.Button()
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
        Me.ID_depTextBox = New System.Windows.Forms.TextBox()
        Me.DepBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Employeedb_papDataSet = New PAP_09.employeedb_papDataSet()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.save = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.numreg = New System.Windows.Forms.TextBox()
        Me.search = New System.Windows.Forms.Button()
        Me.insert = New System.Windows.Forms.Button()
        Me.DepTableAdapter = New PAP_09.employeedb_papDataSetTableAdapters.depTableAdapter()
        Me.TableAdapterManager = New PAP_09.employeedb_papDataSetTableAdapters.TableAdapterManager()
        Me.Button3 = New System.Windows.Forms.Button()
        ID_depLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DepBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Employeedb_papDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_depLabel
        '
        ID_depLabel.AutoSize = True
        ID_depLabel.Location = New System.Drawing.Point(8, 49)
        ID_depLabel.Name = "ID_depLabel"
        ID_depLabel.Size = New System.Drawing.Size(80, 25)
        ID_depLabel.TabIndex = 84
        ID_depLabel.Text = "ID dep:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(9, 103)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(74, 25)
        NomeLabel.TabIndex = 86
        NomeLabel.Text = "Nome:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(13, 87)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(74, 25)
        Label1.TabIndex = 87
        Label1.Text = "Nome:"
        '
        'endsearch
        '
        Me.endsearch.Location = New System.Drawing.Point(245, 613)
        Me.endsearch.Margin = New System.Windows.Forms.Padding(6)
        Me.endsearch.Name = "endsearch"
        Me.endsearch.Size = New System.Drawing.Size(150, 44)
        Me.endsearch.TabIndex = 83
        Me.endsearch.Text = "Concluir"
        Me.endsearch.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Label1)
        Me.GroupBox3.Controls.Add(Me.update)
        Me.GroupBox3.Controls.Add(Me.updatetext)
        Me.GroupBox3.Location = New System.Drawing.Point(1048, 331)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox3.Size = New System.Drawing.Size(572, 180)
        Me.GroupBox3.TabIndex = 82
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Atualizar"
        '
        'update
        '
        Me.update.Location = New System.Drawing.Point(326, 83)
        Me.update.Margin = New System.Windows.Forms.Padding(6)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(234, 44)
        Me.update.TabIndex = 22
        Me.update.Text = "Atualizar Dados"
        Me.update.UseVisualStyleBackColor = True
        '
        'updatetext
        '
        Me.updatetext.Location = New System.Drawing.Point(96, 87)
        Me.updatetext.Margin = New System.Windows.Forms.Padding(6)
        Me.updatetext.Name = "updatetext"
        Me.updatetext.Size = New System.Drawing.Size(196, 31)
        Me.updatetext.TabIndex = 23
        '
        'searchlayer
        '
        Me.searchlayer.Image = Global.PAP_09.My.Resources.Resources._585e4ae9cb11b227491c3394
        Me.searchlayer.Location = New System.Drawing.Point(1158, 41)
        Me.searchlayer.Margin = New System.Windows.Forms.Padding(6)
        Me.searchlayer.Name = "searchlayer"
        Me.searchlayer.Size = New System.Drawing.Size(456, 203)
        Me.searchlayer.TabIndex = 81
        Me.searchlayer.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.deletenome)
        Me.GroupBox2.Controls.Add(Me.deleteid)
        Me.GroupBox2.Controls.Add(Me.txtdelete)
        Me.GroupBox2.Location = New System.Drawing.Point(500, 327)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Size = New System.Drawing.Size(502, 202)
        Me.GroupBox2.TabIndex = 80
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
        Me.Button2.Location = New System.Drawing.Point(554, 41)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(520, 203)
        Me.Button2.TabIndex = 79
        Me.Button2.UseVisualStyleBackColor = True
        '
        'insertlayer
        '
        Me.insertlayer.Image = Global.PAP_09.My.Resources.Resources.f3f305dd9e1
        Me.insertlayer.Location = New System.Drawing.Point(16, 41)
        Me.insertlayer.Margin = New System.Windows.Forms.Padding(6)
        Me.insertlayer.Name = "insertlayer"
        Me.insertlayer.Size = New System.Drawing.Size(502, 203)
        Me.insertlayer.TabIndex = 78
        Me.insertlayer.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(ID_depLabel)
        Me.GroupBox1.Controls.Add(Me.ID_depTextBox)
        Me.GroupBox1.Controls.Add(Me.NomeTextBox)
        Me.GroupBox1.Controls.Add(NomeLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 321)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(466, 208)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados"
        '
        'ID_depTextBox
        '
        Me.ID_depTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DepBindingSource, "ID_dep", True))
        Me.ID_depTextBox.Location = New System.Drawing.Point(94, 46)
        Me.ID_depTextBox.Name = "ID_depTextBox"
        Me.ID_depTextBox.Size = New System.Drawing.Size(280, 31)
        Me.ID_depTextBox.TabIndex = 85
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
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DepBindingSource, "nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(94, 100)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(280, 31)
        Me.NomeTextBox.TabIndex = 87
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(47, 613)
        Me.save.Margin = New System.Windows.Forms.Padding(6)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(150, 44)
        Me.save.TabIndex = 76
        Me.save.Text = "Atualizar"
        Me.save.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(41, 678)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 44)
        Me.Button1.TabIndex = 75
        Me.Button1.Text = "Limpar CX"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'numreg
        '
        Me.numreg.Location = New System.Drawing.Point(35, 734)
        Me.numreg.Margin = New System.Windows.Forms.Padding(6)
        Me.numreg.Name = "numreg"
        Me.numreg.ReadOnly = True
        Me.numreg.Size = New System.Drawing.Size(434, 31)
        Me.numreg.TabIndex = 74
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(245, 557)
        Me.search.Margin = New System.Windows.Forms.Padding(6)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(150, 44)
        Me.search.TabIndex = 73
        Me.search.Text = "Procurar"
        Me.search.UseVisualStyleBackColor = True
        '
        'insert
        '
        Me.insert.Location = New System.Drawing.Point(47, 557)
        Me.insert.Margin = New System.Windows.Forms.Padding(6)
        Me.insert.Name = "insert"
        Me.insert.Size = New System.Drawing.Size(150, 44)
        Me.insert.TabIndex = 72
        Me.insert.Text = "Inserir"
        Me.insert.UseVisualStyleBackColor = True
        '
        'DepTableAdapter
        '
        Me.DepTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.depTableAdapter = Me.DepTableAdapter
        Me.TableAdapterManager.EMPTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PAP_09.employeedb_papDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(239, 427)
        Me.Button3.Margin = New System.Windows.Forms.Padding(6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 44)
        Me.Button3.TabIndex = 83
        Me.Button3.Text = "Concluir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'op_dep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1699, 786)
        Me.Controls.Add(Me.endsearch)
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
        Me.Name = "op_dep"
        Me.Text = "Departamentos"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DepBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Employeedb_papDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents endsearch As System.Windows.Forms.Button
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
    Friend WithEvents DepBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepTableAdapter As PAP_09.employeedb_papDataSetTableAdapters.depTableAdapter
    Friend WithEvents TableAdapterManager As PAP_09.employeedb_papDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ID_depTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
