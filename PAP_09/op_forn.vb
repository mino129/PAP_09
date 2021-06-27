Public Class op_forn

    Private Sub FornecedorBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.FornecedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_papDataSet)

    End Sub

    Private Sub op_forn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_papDataSet.Fornecedor' table. You can move, or remove it, as needed.
        ' Me.FornecedorTableAdapter.Fill(Me.Db_papDataSet.Fornecedor)

        search.Visible = False
        endsearch.Visible = False
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        ID_FornTextBox.Clear()
        NomeTextBox.Clear()
        RuaTextBox.Clear()
        CidadeTextBox.Clear()
        Cod_PostalTextBox.Clear()

        TelefoneTextBox.Clear()
        E_MailTextBox.Clear()
        TelefoneTextBox.MaxLength = 9
        Cod_PostalTextBox.MaxLength = 9
        'PaisTextBox.SelectedIndex = -1
        numreg.Text = "Numero de Fornecedores: " + CStr(Me.FornecedorTableAdapter.numforn)
        save.Visible = False
        insert.Visible = False

    End Sub

    Private Sub insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insert.Click
        If (NomeTextBox.Text = "" Or RuaTextBox.Text = "" Or CidadeTextBox.Text = "" Or Cod_PostalTextBox.Text = "") Then
            MsgBox("Por favor preencha as caixas de texto")
        Else
            Me.FornecedorTableAdapter.insertforn(ID_FornTextBox.Text, NomeTextBox.Text, NifTextBox.Text, RuaTextBox.Text, CidadeTextBox.Text, PaisTextBox.Text, Cod_PostalTextBox.Text, TelefoneTextBox.Text, E_MailTextBox.Text)

            numreg.Text = "Numero de Fornecedores: " + CStr(Me.FornecedorTableAdapter.numforn)
            GroupBox1.Visible = False
            insert.Visible = False
            ID_FornTextBox.Clear()
            NomeTextBox.Clear()
            RuaTextBox.Clear()
            CidadeTextBox.Clear()
            Cod_PostalTextBox.Clear()

            TelefoneTextBox.Clear()
            E_MailTextBox.Clear()
        End If
    End Sub

    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.Click
        Me.FornecedorTableAdapter.FillBysearchforn(Me.Db_papDataSet.Fornecedor, NomeTextBox.Text)

    End Sub

    Private Sub deletenome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deletenome.Click
        Dim answer As Integer = MsgBox("Tem a certeza que quer apagar este registo?", MsgBoxStyle.YesNo)

        If answer = DialogResult.Yes Then
            Dim x As Integer = Me.FornecedorTableAdapter.deletebynome(txtdelete.Text)
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
            Dim a As Integer = Me.FornecedorTableAdapter.deletebyid(txtdelete.Text)
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
        NomeTextBox.ReadOnly = False
        RuaTextBox.ReadOnly = False
        CidadeTextBox.ReadOnly = False
        Cod_PostalTextBox.ReadOnly = False
        NifTextBox.ReadOnly = False

        TelefoneTextBox.ReadOnly = False
        E_MailTextBox.ReadOnly = False

        save.Visible = True
        ID_FornTextBox.Visible = False
        Me.FornecedorTableAdapter.FillBysearchforn(Me.Db_papDataSet.Fornecedor, updatetext.Text)
        ID_FornTextBox.Visible = False
        updatetext.Clear()
        PaisTextBox.Enabled = True


    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        Me.FornecedorTableAdapter.updateforn(ID_FornTextBox.Text, NomeTextBox.Text, NifTextBox.Text, RuaTextBox.Text, CidadeTextBox.Text, PaisTextBox.Text, Cod_PostalTextBox.Text, TelefoneTextBox.Text, E_MailTextBox.Text, ID_FornTextBox.Text)

        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        ID_FornTextBox.Visible = True
        save.Visible = False
        ID_FornTextBox.Clear()
        NomeTextBox.Clear()
        RuaTextBox.Clear()
        CidadeTextBox.Clear()
        Cod_PostalTextBox.Clear()
        TelefoneTextBox.Clear()
        E_MailTextBox.Clear()


        ID_FornTextBox.ReadOnly = False
        NomeTextBox.ReadOnly = False
        RuaTextBox.ReadOnly = False
        CidadeTextBox.ReadOnly = False
        Cod_PostalTextBox.ReadOnly = False
        TelefoneTextBox.ReadOnly = False
        E_MailTextBox.ReadOnly = False
        PaisTextBox.Enabled = True
        search.Visible = False
        endsearch.Visible = False


    End Sub

    Private Sub deletelayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        deletenome.Visible = True
        deleteid.Visible = True
        txtdelete.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PaisTextBox.SelectedIndex = -1
        NifTextBox.Clear()

        NomeTextBox.Clear()
        RuaTextBox.Clear()
        CidadeTextBox.Clear()
        Cod_PostalTextBox.Clear()

        TelefoneTextBox.Clear()
        E_MailTextBox.Clear()
        updatetext.Clear()
        txtdelete.Clear()



    End Sub

    Private Sub insertlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insertlayer.Click
        PaisTextBox.Enabled = True
        NifTextBox.ReadOnly = False

        ID_FornTextBox.Visible = True
        NomeTextBox.ReadOnly = False
        RuaTextBox.ReadOnly = False
        CidadeTextBox.ReadOnly = False
        Cod_PostalTextBox.ReadOnly = False

        TelefoneTextBox.ReadOnly = False
        E_MailTextBox.ReadOnly = False


        If Me.FornecedorTableAdapter.numforn() = 0 Then
            ID_FornTextBox.Text = 1

        Else
            Dim x As String = Me.FornecedorTableAdapter.maxid()
            Dim max As Integer = Val(x) + 1
            ID_FornTextBox.Text = max
        End If

        ID_FornTextBox.ReadOnly = True
        NomeTextBox.Clear()
        RuaTextBox.Clear()
        CidadeTextBox.Clear()
        Cod_PostalTextBox.Clear()

        TelefoneTextBox.Clear()
        E_MailTextBox.Clear()
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
        NifTextBox.ReadOnly = True
        ID_FornTextBox.Visible = False

        ID_FornTextBox.Clear()
        insert.Visible = False
        GroupBox2.Visible = False
        search.Visible = True
        endsearch.Visible = True
        GroupBox1.Visible = True
        GroupBox3.Visible = True
        ID_FornTextBox.ReadOnly = True
        RuaTextBox.ReadOnly = True
        CidadeTextBox.ReadOnly = True
        Cod_PostalTextBox.ReadOnly = True
        PaisTextBox.Enabled = False
        TelefoneTextBox.ReadOnly = True
        E_MailTextBox.ReadOnly = True
        PaisTextBox.Enabled = False


    End Sub

    Private Sub endsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles endsearch.Click
        ID_FornTextBox.Visible = True

        GroupBox1.Visible = False
        GroupBox3.Visible = False
        search.Visible = False
        endsearch.Visible = False
        save.Visible = False
        PaisTextBox.Enabled = True
        PaisTextBox.SelectedIndex = -1
        NifTextBox.Clear()

        NomeTextBox.Clear()
        RuaTextBox.Clear()
        CidadeTextBox.Clear()
        Cod_PostalTextBox.Clear()

        TelefoneTextBox.Clear()
        E_MailTextBox.Clear()
        updatetext.Clear()
        txtdelete.Clear()
    End Sub

    Private Sub FornecedorBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.FornecedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_papDataSet)

    End Sub

    Private Sub TelefoneTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TelefoneTextBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub Cod_PostalTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cod_PostalTextBox.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub NifTextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles NifTextBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class