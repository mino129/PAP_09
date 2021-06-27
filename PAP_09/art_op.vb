Public Class art_op

    Private Sub ArtigosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.ArtigosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_papDataSet)

    End Sub

    Private Sub op_art_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Art_esp_dbDataSet.armazens' table. You can move, or remove it, as needed.
        Me.ArmazensTableAdapter.Fill(Me.Art_esp_dbDataSet.armazens)
        'TODO: This line of code loads data into the 'Art_esp_dbDataSet.art_gest_stock' table. You can move, or remove it, as needed.
        Me.Art_gest_stockTableAdapter.Fill(Me.Art_esp_dbDataSet.art_gest_stock)
        'TODO: This line of code loads data into the 'Art_esp_dbDataSet.art_esp' table. You can move, or remove it, as needed.
        Me.Art_espTableAdapter.Fill(Me.Art_esp_dbDataSet.art_esp)
        'TODO: This line of code loads data into the 'Db_papDataSet.Categoria' table. You can move, or remove it, as needed.
        Me.CategoriaTableAdapter.Fill(Me.Db_papDataSet.Categoria)
        'TODO: This line of code loads data into the 'Db_papDataSet.Fornecedor' table. You can move, or remove it, as needed.
        Me.FornecedorTableAdapter.Fill(Me.Db_papDataSet.Fornecedor)
        'TODO: This line of code loads data into the 'Db_papDataSet.Categoria' table. You can move, or remove it, as needed.
        Me.CategoriaTableAdapter.Fill(Me.Db_papDataSet.Categoria)
        'TODO: This line of code loads data into the 'Db_papDataSet.Fornecedor' table. You can move, or remove it, as needed.
        Me.FornecedorTableAdapter.Fill(Me.Db_papDataSet.Fornecedor)
        'TODO: This line of code loads data into the 'Db_papDataSet.Artigos' table. You can move, or remove it, as needed.
        '   Me.ArtigosTableAdapter.Fill(Me.Db_papDataSet.Artigos)

        save.Visible = False
        numreg.Text = "Numero de artigos: " & Me.ArtigosTableAdapter.numregart
        GroupBox1.Visible = False
        endsearch.Visible = False
        'id_arm.SelectedIndex = -1
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        alter.Visible = False
    End Sub

    Private Sub insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Insert.Click
        ID_ArtTextBox.Visible = True

        SKU_EAN13TextBox.ReadOnly = False
        PreçoTextBox.ReadOnly = False
        Quant_p_cxTextBox.ReadOnly = False
        Stock_ExistTextBox.ReadOnly = False


        If Me.ArtigosTableAdapter.numregart() = 0 Then
            ID_ArtTextBox.Text = 1
        Else
            Dim y As String = Me.ArtigosTableAdapter.maxid
            Dim max = Val(y) + 1
            ID_ArtTextBox.Text = max
        End If

        ID_ArtTextBox.ReadOnly = True
        alter.Visible = False
        endsearch.Visible = False

        'Me.ArtigosTableAdapter.insertart(ID_ArtTextBox.Text, DescricaoTextBox.Text, Val(SKUTextBox.Text), PreçoTextBox.Text, Val(Quant_p_cxTextBox.Text), Val(Stock_ExistTextBox.Text), Val(ID_FornTextBox.Text))
        ' ID_ArtTextBox.Clear()
        ' DescricaoTextBox.Clear()
        ' SKUTextBox.Clear()
        ' PreçoTextBox.Clear()
        ' Quant_p_cxTextBox.Clear()
        '  Stock_ExistTextBox.Clear()
        ' ID_FornTextBox.Clear()
        SKU_EAN13TextBox.MaxLength = 255
        GroupBox2.Visible = False
        GroupBox1.Visible = True
        save.Visible = True
        GroupBox3.Visible = False

    End Sub

    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Search.Click
        '  ID_FornTextBox.Visible = False
        ID_ArtTextBox.Visible = False
        '   ID_FornTextBox.Visible = False
        ID_ArtTextBox.Clear()
        endsearch.Visible = False
        save.Visible = False
        GroupBox2.Visible = False
        endsearch.Visible = True

        ID_ArtTextBox.ReadOnly = True
        SKU_EAN13TextBox.ReadOnly = True
        PreçoTextBox.ReadOnly = True
        Quant_p_cxTextBox.ReadOnly = True
        Stock_ExistTextBox.ReadOnly = True
        '   Label1.Visible = False
        GroupBox1.Visible = True
        GroupBox3.Visible = True
        '  Me.ArtigosTableAdapter.FillBysearchart(Me.Loja_DBDataSet.Artigos, DescriçaoTextBox.Text)



    End Sub

    Private Sub deletelayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deletelayer.Click

        GroupBox3.Visible = False
        alter.Visible = False
        txtdelete.Visible = True
        deleteid.Visible = True
        GroupBox1.Visible = False
        GroupBox2.Visible = True
        save.Visible = False


    End Sub

    Private Sub deletenome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        Dim answer As Integer = MsgBox("Tem a certeza que quer apagar este registo?", MsgBoxStyle.YesNo)

        If answer = DialogResult.Yes Then
            Dim x As Integer = Me.ArtigosTableAdapter.deletebynome(txtdelete.Text)
            If x = 1 Then
                MsgBox("O registo foi eliminado com sucesso")
            Else
                MsgBox("Nao existe registos com esse nome")
            End If
           
            txtdelete.Visible = False
            txtdelete.Clear()
            GroupBox2.Visible = False
        Else
            MsgBox("Cancelado")
        End If




    End Sub

    Private Sub deleteid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteid.Click
        Dim answer As Integer = MsgBox("Tem a certeza que quer apagar este registo?", MsgBoxStyle.YesNo)
        If answer = DialogResult.Yes Then
            Dim a As Integer = Me.ArtigosTableAdapter.deletebyid(txtdelete.Text)
            Dim b As Integer = Me.Art_espTableAdapter.deleteperid(txtdelete.Text)
            If a = 1 And b = 1 Then
                MsgBox("O registo foi eliminado com sucesso")
            Else
                MsgBox("Nao existe registos com esse ID")
            End If

            deleteid.Visible = False
            txtdelete.Visible = False
            txtdelete.Clear()
            GroupBox2.Visible = False
        Else
            MsgBox("Cancelado")
        End If

    End Sub

    Private Sub update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update.Click
        Me.Art_espTableAdapter.FillByidart(Me.Art_esp_dbDataSet.art_esp, updatetext.Text)
        Me.ArtigosTableAdapter.FillBysearchart(Me.Db_papDataSet.Artigos, updatetext.Text)
        Me.Art_gest_stockTableAdapter.FillByartformart(Me.Art_esp_dbDataSet.art_gest_stock, updatetext.Text)
        '  MsgBox(Me.ArtigosTableAdapter.precquery(DescricaoTextBox.Text))
        '  Me.ArtigosTableAdapter.quantquery(DescricaoTextBox.Text)
        '  Me.ArtigosTableAdapter.stockquery(DescricaoTextBox.Text)
        PreçoTextBox.ReadOnly = False
        Quant_p_cxTextBox.ReadOnly = False
        Stock_ExistTextBox.ReadOnly = False
        save.Visible = False

        alter.Visible = True

    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
      
        '   If (DescricaoTextBox.Text = "" Or SKUTextBox.Text = "" Or PreçoTextBox.Text = "" OrQuant_p_cxTextBox.Text = "" Or Stock_ExistTextBox.Text = "") Then
        'MsgBox("Por favor preencha todas as caixas de texto")
        '  Else
        'Me.ArtigosTableAdapter.updateart(ID_ArtTextBox.Text, DescricaoTextBox.Text, SKUTextBox.Text, PreçoTextBox.Text,Quant_p_cxTextBox.Text, Stock_ExistTextBox.Text, ID_FornTextBox.Text, updatetext.Text)
        ' ID_ArtTextBox.Visible = True
        ' ID_FornTextBox.Visible = True

        If (id_arm.SelectedIndex = -1 Or ID_FornTextBox.SelectedIndex = -1 Or ID_CatTextBox.SelectedIndex = -1) Then
            MsgBox("Selecione todas as opçoes disponiveis!")
        Else

            Me.ArtigosTableAdapter.insertart(ID_ArtTextBox.Text, DescricaoTextBox.Text, SKU_EAN13TextBox.Text, PreçoTextBox.Text, Quant_p_cxTextBox.Text, Stock_existTextBox.Text, ID_FornTextBox.SelectedValue, ID_CatTextBox.SelectedValue)
            Me.Art_espTableAdapter.insertart(ID_ArtTextBox.Text, AlturaTextBox.Text, LarguraTextBox.Text, Referencia_internaTextBox.Text, Informacoes_adTextBox.Text, Material_fabTextBox.Text, MarcaTextBox.Text)
            Me.Art_gest_stockTableAdapter.insertart(ID_ArtTextBox.Text, Stock_existTextBox.Text, Data_modDateTimePicker.Text, "0", "0", id_arm.SelectedValue, Informacoes_adTextBox.Text, Preco_custoTextBox.Text)

            save.Visible = False
            GroupBox1.Visible = False
            numreg.Text = "Numero de artigos: " & Me.ArtigosTableAdapter.numregart()
        End If



        ' ID_ArtTextBox.Clear()
        '  DescricaoTextBox.Clear()
        ' SKUTextBox.Clear()
        '  PreçoTextBox.Clear()
        'Quant_p_cxTextBox.Clear()
        ' Stock_ExistTextBox.Clear()
        '  ID_FornTextBox.Clear()
        '   End If




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        DescricaoTextBox.Clear()
        SKU_EAN13TextBox.Clear()
        PreçoTextBox.Clear()
        Quant_p_cxTextBox.Clear()
        Stock_ExistTextBox.Clear()

    End Sub

    Private Sub searchafterlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ID_FornTextBox.Visible = False
        ID_ArtTextBox.ReadOnly = True
        SKU_EAN13TextBox.ReadOnly = True
        PreçoTextBox.ReadOnly = True
        Quant_p_cxTextBox.ReadOnly = True
        Stock_existTextBox.ReadOnly = True
        MsgBox(ID_ArtTextBox.Text)

        '  Label1.Text = Me.FornecedorTableAdapter.nomeforn(ID_FornTextBox.Text)
        '    ID_FornTextBox.Visible = False
        Me.ArtigosTableAdapter.FillBysearchart(Me.Db_papDataSet.Artigos, DescricaoTextBox.Text)

    End Sub

    Private Sub endsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles endsearch.Click
        ID_ArtTextBox.Visible = True
        GroupBox3.Visible = False
        alter.Visible = False
        save.Visible = False
        ID_ArtTextBox.ReadOnly = False
        SKU_EAN13TextBox.ReadOnly = False
        PreçoTextBox.ReadOnly = False
        Quant_p_cxTextBox.ReadOnly = False
        Stock_ExistTextBox.ReadOnly = False
        ID_FornTextBox.Visible = True
        endsearch.Visible = False

        'Label1.Text = ""
        GroupBox1.Visible = False

    End Sub

    Private Sub alter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alter.Click
        '  If (DescricaoTextBox.Text = "" Or SKUTextBox.Text = "" Or PreçoTextBox.Text = "" OrQuant_p_cxTextBox.Text = "" Or Stock_ExistTextBox.Text = "") Then
        'MsgBox("Por favor preencha todas as caixas de texto")
        ' Else
        Me.ArtigosTableAdapter.updateart(ID_ArtTextBox.Text, DescricaoTextBox.Text, SKU_EAN13TextBox.Text, PreçoTextBox.Text, Quant_p_cxTextBox.Text, Stock_existTextBox.Text, ID_FornTextBox.SelectedValue, ID_CatTextBox.SelectedValue, updatetext.Text)
        Me.Art_espTableAdapter.updateart(ID_ArtTextBox.Text, AlturaTextBox.Text, LarguraTextBox.Text, Referencia_internaTextBox.Text, Informacoes_adTextBox.Text, Material_fabTextBox.Text, MarcaTextBox.Text, ID_ArtTextBox.Text)
        '   Me.Art_gest_stockTableAdapter.updateartformart(id_arm.SelectedValue, Informacoes_adTextBox.Text, Preco_custoTextBox.Text, ID_ArtTextBox.Text)
        Me.Art_gest_stockTableAdapter.updateartformart1(Stock_existTextBox.Text, Data_modDateTimePicker.Text, id_arm.SelectedValue, Informacoes_adTextBox.Text, Preco_custoTextBox.Text, ID_ArtTextBox.Text)
        alter.Visible = False
        '  End If
        ID_ArtTextBox.Visible = True
        GroupBox3.Visible = False
        alter.Visible = False
        save.Visible = False
        ID_ArtTextBox.ReadOnly = False
        SKU_EAN13TextBox.ReadOnly = False
        PreçoTextBox.ReadOnly = False
        Quant_p_cxTextBox.ReadOnly = False
        Stock_existTextBox.ReadOnly = False
        ID_FornTextBox.Visible = True
        endsearch.Visible = False

        'Label1.Text = ""
        GroupBox1.Visible = False

    End Sub

    Private Sub ArtigosBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ArtigosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_papDataSet)

    End Sub

    Private Sub ID_FornTextBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '   If ID_FornTextBox.Text <> "" Then
        '  Label1.Text = Me.FornecedorTableAdapter.nomeforn(ID_FornTextBox.Text)


        ' End If
    End Sub

    Private Sub SKUTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub Quant_p_cxTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub Stock_ExistTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub


    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub


End Class