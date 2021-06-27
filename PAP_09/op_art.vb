Public Class op_art

    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_papDataSet)

    End Sub

    Private Sub op_art_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_papDataSet.Clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.Db_papDataSet.Clientes)

        GroupBox3.Visible = False
        GroupBox1.Visible = False
        deletenome.Visible = False
        deleteid.Visible = False
        numreg.Text = "Numero de Clientes : " + CStr(Me.ClientesTableAdapter.numregcli())
        ID_CliTextBox.Clear()
        NifTextBox.Clear()

        NomeTextBox.Clear()
        RuaTextBox.Clear()
        CidadeTextBox.Clear()
        Cod_PostalTextBox.Clear()
        PaisTextBox.Clear()

        TelefoneTextBox.Clear()
        E_MailTextBox.Clear()
        TelefoneTextBox.MaxLength = 9
        Cod_PostalTextBox.MaxLength = 9

        save.Visible = False
        GroupBox1.Visible = False

        GroupBox2.Visible = False
        insert.Visible = False
        search.Visible = False
        Button3.Visible = False
    End Sub

    Private Sub insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insert.Click
        If (NomeTextBox.Text = "" Or RuaTextBox.Text = "" Or CidadeTextBox.Text = "" Or Cod_PostalTextBox.Text = "" Or TelefoneTextBox.Text = "" Or E_MailTextBox.Text = "" Or NifTextBox.Text = "" Or PaisTextBox.Text = "") Then
            MsgBox("Por favor preencha todas as caixas de texto")
        Else
            Me.ClientesTableAdapter.insertcli(ID_CliTextBox.Text, NomeTextBox.Text, NifTextBox.Text, RuaTextBox.Text, CidadeTextBox.Text, PaisTextBox.Text, Cod_PostalTextBox.Text, TelefoneTextBox.Text, E_MailTextBox.Text)
            numreg.Text = "Numero de Clientes : " + CStr(Me.ClientesTableAdapter.numregcli())
            GroupBox1.Visible = False
            ID_CliTextBox.Clear()
            NifTextBox.Clear()

            NomeTextBox.Clear()
            RuaTextBox.Clear()
            CidadeTextBox.Clear()
            Cod_PostalTextBox.Clear()
            PaisTextBox.Clear()

            TelefoneTextBox.Clear()
            E_MailTextBox.Clear()
            insert.Visible = False
        End If



    End Sub

    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.Click
        Me.ClientesTableAdapter.FillBysearchcli(Me.Db_papDataSet.Clientes, NomeTextBox.Text)
    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        deletenome.Visible = True
        deleteid.Visible = True
    End Sub


    Private Sub deletenome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deletenome.Click
        Dim answer As Integer = MsgBox("Tem a certeza que quer apagar este registo?", MsgBoxStyle.YesNo)

        If answer = DialogResult.Yes Then
            Dim a As Integer = Me.ClientesTableAdapter.deleteclibynome(txtdelete.Text)
            If a = 1 Then
                MsgBox("O registo foi eliminado com sucesso")
            Else
                MsgBox("Nao existe registos com esse nome")
            End If


            txtdelete.Clear()
            GroupBox2.Visible = False

        Else
            MsgBox("Cancelado")
        End If

    End Sub

    Private Sub deleteid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteid.Click

        Dim answer As Integer = MsgBox("Tem a certeza que quer apagar este registo?", MsgBoxStyle.YesNo)

        If answer = DialogResult.Yes Then
            Dim x As Integer = Me.ClientesTableAdapter.deleteclibyid(txtdelete.Text)
            If x = 1 Then
                MsgBox("O registo foi eliminado com sucesso")
            Else
                MsgBox("Nao existe registos com esse ID")
            End If
            txtdelete.Clear()
            GroupBox2.Visible = False
        Else
            MsgBox("Cancelado")
        End If




    End Sub

    Private Sub update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update.Click
        save.Visible = True
        ID_ClienteTextBox.Visible = False

        ID_ClienteTextBox.ReadOnly = False
        RuaTextBox.ReadOnly = False
        CidadeTextBox.ReadOnly = False
        Cod_PostalTextBox.ReadOnly = False
        TelefoneTextBox.ReadOnly = False
        E_MailTextBox.ReadOnly = False
        Me.ClientesTableAdapter.FillBysearchcli(Me.Loja_DBDataSet.Clientes, NomeTextBox.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        NomeTextBox.Clear()
        RuaTextBox.Clear()
        CidadeTextBox.Clear()
        Cod_PostalTextBox.Clear()
        TelefoneTextBox.Clear()
        E_MailTextBox.Clear()
    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click

        If (NomeTextBox.Text = "" Or RuaTextBox.Text = "" Or CidadeTextBox.Text = "" Or Cod_PostalTextBox.Text = "" Or TelefoneTextBox.Text = "" Or E_MailTextBox.Text = "") Then
            MsgBox("Por favor preencha todas as caixas de texto")
        Else
            Me.ClientesTableAdapter.updatecli(NomeTextBox.Text, RuaTextBox.Text, CidadeTextBox.Text, Cod_PostalTextBox.Text, TelefoneTextBox.Text, E_MailTextBox.Text, Val(updatetext.Text))
            ID_ClienteTextBox.Visible = True
            save.Visible = False
            ID_ClienteTextBox.Clear()
            NomeTextBox.Clear()
            RuaTextBox.Clear()
            CidadeTextBox.Clear()
            Cod_PostalTextBox.Clear()
            TelefoneTextBox.Clear()
            E_MailTextBox.Clear()
        End If

    End Sub

    Private Sub insertlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insertlayer.Click
        ID_ClienteTextBox.Visible = True

        RuaTextBox.ReadOnly = False
        CidadeTextBox.ReadOnly = False
        Cod_PostalTextBox.ReadOnly = False
        TelefoneTextBox.ReadOnly = False
        E_MailTextBox.ReadOnly = False



        If Me.ClientesTableAdapter.numregcli() = 0 Then
            ID_ClienteTextBox.Text = 1

        Else
            Dim m As String = Me.ClientesTableAdapter.maxid()
            Dim max = Val(m) + 1
            ID_ClienteTextBox.Text = max
        End If

        ID_ClienteTextBox.ReadOnly = True
        search.Visible = False
        Button3.Visible = False
        GroupBox3.Visible = False
        insert.Visible = True
        GroupBox1.Visible = True
        GroupBox2.Visible = False

    End Sub

    Private Sub saveb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GroupBox1.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        search.Visible = False
        Button3.Visible = False
        insert.Visible = False
        GroupBox1.Visible = False
        GroupBox2.Visible = True
        deletenome.Visible = True
        deleteid.Visible = True
        GroupBox3.Visible = False
    End Sub

    Private Sub searchlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchlayer.Click
        ID_ClienteTextBox.Clear()
        insert.Visible = False
        GroupBox2.Visible = False
        search.Visible = True
        GroupBox3.Visible = True
        GroupBox1.Visible = True
        Button3.Visible = True
        ID_ClienteTextBox.ReadOnly = True
        RuaTextBox.ReadOnly = True
        CidadeTextBox.ReadOnly = True
        Cod_PostalTextBox.ReadOnly = True
        TelefoneTextBox.ReadOnly = True
        E_MailTextBox.ReadOnly = True

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        save.Visible = False
        GroupBox1.Visible = False
        GroupBox3.Visible = False
        search.Visible = False
        Button3.Visible = False
    End Sub

    Private Sub ClientesBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Loja_DBDataSet)

    End Sub

    Private Sub TelefoneTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TelefoneTextBox.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

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
End Class