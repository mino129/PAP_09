Public Class op_cat

    Private Sub CategoriaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CategoriaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_papDataSet)

    End Sub

    Private Sub op_cat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_papDataSet.Categoria' table. You can move, or remove it, as needed.
        ' Me.CategoriaTableAdapter.Fill(Me.Db_papDataSet.Categoria)

        search.Visible = False
        endsearch.Visible = False
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        ID_CatTextBox.Clear()
        DescricaoTextBox.Clear()

        numreg.Text = "Numero de Categorias: " + CStr(Me.CategoriaTableAdapter.numcat)
        save.Visible = False
        insert.Visible = False
    End Sub

    Private Sub insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insert.Click
        If (DescricaoTextBox.Text = "") Then
            MsgBox("Por favor preencha as caixas de texto")
        Else
            Me.CategoriaTableAdapter.Insert(ID_CatTextBox.Text, DescricaoTextBox.Text)
            numreg.Text = "Numero de Categorias: " + CStr(Me.CategoriaTableAdapter.numcat)
            GroupBox1.Visible = False
            insert.Visible = False
            ID_CatTextBox.Clear()
            DescricaoTextBox.Clear()
        End If
    End Sub

    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.Click
        Me.CategoriaTableAdapter.FillBysearchcat(Me.Db_papDataSet.Categoria, DescricaoTextBox.Text)

    End Sub
    Private Sub deletenome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deletenome.Click
        Dim answer As Integer = MsgBox("Tem a certeza que quer apagar este registo?", MsgBoxStyle.YesNo)

        If answer = DialogResult.Yes Then
            Dim x As Integer = Me.CategoriaTableAdapter.deletebynome(txtdelete.Text)
            If x = 1 Then
                MsgBox("O registo foi eliminado com sucesso")
            Else
                MsgBox("Nao existe registos com esse nome")
            End If
            GroupBox2.Visible = False
            GroupBox3.Visible = False
            deletenome.Visible = False
        Else
            MsgBox("Cancelado")
        End If



    End Sub

    Private Sub deleteid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteid.Click
        Dim answer As Integer = MsgBox("Tem a certeza que quer apagar este registo?", MsgBoxStyle.YesNo)

        If answer = DialogResult.Yes Then
            Dim a As Integer = Me.CategoriaTableAdapter.deletecatbyid(txtdelete.Text)
            If a = 1 Then
                MsgBox("O registo foi eliminado com sucesso")
            Else
                MsgBox("Nao existe registos com esse ID")
            End If
            txtdelete.Clear()
            GroupBox2.Visible = False
            GroupBox3.Visible = False
        Else
            MsgBox("Cancelado")
        End If


    End Sub

    Private Sub update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update.Click
        DescricaoTextBox.ReadOnly = False


        save.Visible = True
        ID_CatTextBox.Visible = False
        Me.CategoriaTableAdapter.FillBysearchcat(Me.Db_papDataSet.Categoria, updatetext.Text)
        ID_CatTextBox.Visible = False
        updatetext.Clear()


    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        Me.CategoriaTableAdapter.updatecat(DescricaoTextBox.Text, Val(ID_CatTextBox.Text))

        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        ID_CatTextBox.Visible = True
        save.Visible = False
        ID_CatTextBox.Clear()
        DescricaoTextBox.Clear()



        ID_CatTextBox.ReadOnly = False
        DescricaoTextBox.ReadOnly = False


        search.Visible = False
        endsearch.Visible = False
    End Sub

    Private Sub deletelayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        deletenome.Visible = True
        deleteid.Visible = True
        txtdelete.Visible = True
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        DescricaoTextBox.Clear()

        updatetext.Clear()
        txtdelete.Clear()



    End Sub

    Private Sub insertlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insertlayer.Click
        ID_CatTextBox.Visible = True
        DescricaoTextBox.ReadOnly = False


        If Me.CategoriaTableAdapter.numcat() = 0 Then
            ID_CatTextBox.Text = 1

        Else
            Dim x As String = Me.CategoriaTableAdapter.maxid()
            Dim max As Integer = Val(x) + 1
            ID_CatTextBox.Text = max
        End If

        ID_CatTextBox.ReadOnly = True
        DescricaoTextBox.Clear()
        updatetext.Clear()
        txtdelete.Clear()
        GroupBox3.Visible = False
        GroupBox2.Visible = False
        GroupBox1.Visible = True
        insert.Visible = True
        search.Visible = False
        endsearch.Visible = False



    End Sub

    Private Sub layerdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles layerdelete.Click
        insert.Visible = False
        GroupBox3.Visible = False
        search.Visible = False
        endsearch.Visible = False
        GroupBox2.Visible = True
        GroupBox1.Visible = False
        insert.Visible = False

    End Sub
    Private Sub searchlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchlayer.Click
        ID_CatTextBox.Clear()
        insert.Visible = False
        GroupBox2.Visible = False
        search.Visible = True
        endsearch.Visible = True
        GroupBox1.Visible = True
        GroupBox3.Visible = True
        ID_CatTextBox.ReadOnly = True
        '   DescricaoTextBox.ReadOnly = True
    End Sub

    Private Sub endsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles endsearch.Click
        GroupBox1.Visible = False
        GroupBox3.Visible = False
        search.Visible = False
        endsearch.Visible = False
        save.Visible = False
    End Sub



End Class