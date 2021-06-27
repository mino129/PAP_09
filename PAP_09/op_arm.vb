Public Class op_arm

    Private Sub ArmazensBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ArmazensBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Art_esp_dbDataSet)

    End Sub

    Private Sub op_arm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Art_esp_dbDataSet.armazens' table. You can move, or remove it, as needed.
        '   Me.ArmazensTableAdapter.Fill(Me.Art_esp_dbDataSet.armazens)



        search.Visible = False
        endsearch.Visible = False
        GroupBox1.Visible = False

        GroupBox2.Visible = False
        GroupBox3.Visible = False
        RuaTextBox.Clear()
        CidadeTextBox.Clear()
        Cod_PostalTextBox.Clear()
        TelefoneTextBox.Clear()
        '  PaisTextBox.Clear()
        OutrosTextBox.Clear()

        numreg.Text = "Numero de Armazens: " + CStr(Me.ArmazensTableAdapter.numregarm)
        save.Visible = False
        insert.Visible = False
    End Sub

    Private Sub insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insert.Click
        If (OutrosTextBox.Text = "") Then
            MsgBox("Por favor preencha as caixas de texto")
        Else
            Me.ArmazensTableAdapter.insertarm(Id_armTextBox.Text, RuaTextBox.Text, CidadeTextBox.Text, Cod_PostalTextBox.Text, TelefoneTextBox.Text, PaisTextBox.Text, OutrosTextBox.Text)
            numreg.Text = "Numero de Armazens: " + CStr(Me.ArmazensTableAdapter.numregarm)
            GroupBox1.Visible = False
            insert.Visible = False
            RuaTextBox.Clear()
            CidadeTextBox.Clear()
            Cod_PostalTextBox.Clear()
            TelefoneTextBox.Clear()
            '  PaisTextBox.Clear()
            OutrosTextBox.Clear()

        End If
    End Sub

    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.Click
        Me.ArmazensTableAdapter.FillBynome(Me.Art_esp_dbDataSet.armazens, OutrosTextBox.Text)

    End Sub

    Private Sub deleteid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteid.Click
        Dim answer As Integer = MsgBox("Tem a certeza que quer apagar este registo?", MsgBoxStyle.YesNo)

        If answer = DialogResult.Yes Then
            Dim a As Integer = Me.ArmazensTableAdapter.deleteperid(txtdelete.Text)
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
        OutrosTextBox.ReadOnly = False


        save.Visible = True
        Id_armTextBox.Visible = False
        Me.ArmazensTableAdapter.FillBynome(Me.Art_esp_dbDataSet.armazens, updatetext.Text)
        Id_armTextBox.Visible = False
        updatetext.Clear()


    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        Me.ArmazensTableAdapter.updatearm(RuaTextBox.Text, CidadeTextBox.Text, Cod_PostalTextBox.Text, TelefoneTextBox.Text, PaisTextBox.Text, OutrosTextBox.Text, Id_armTextBox.Text)


        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        Id_armTextBox.Visible = True
        save.Visible = False
        Id_armTextBox.Clear()
        RuaTextBox.Clear()
        CidadeTextBox.Clear()
        Cod_PostalTextBox.Clear()
        TelefoneTextBox.Clear()
        ' PaisTextBox.Clear()
        OutrosTextBox.Clear()



        Id_armTextBox.ReadOnly = False
        OutrosTextBox.ReadOnly = False
        RuaTextBox.ReadOnly = False
        CidadeTextBox.ReadOnly = False
        Cod_PostalTextBox.ReadOnly = False
        TelefoneTextBox.ReadOnly = False
        '  PaisTextBox.ReadOnly = False


        search.Visible = False
        endsearch.Visible = False
    End Sub

    Private Sub deletelayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        deleteid.Visible = True
        txtdelete.Visible = True
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Id_armTextBox.Clear()
        RuaTextBox.Clear()
        CidadeTextBox.Clear()
        Cod_PostalTextBox.Clear()
        TelefoneTextBox.Clear()
        '  PaisTextBox.Clear()
        OutrosTextBox.Clear()


        updatetext.Clear()
        txtdelete.Clear()



    End Sub

    Private Sub insertlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insertlayer.Click
        Id_armTextBox.Visible = True
        OutrosTextBox.ReadOnly = False


        If Me.ArmazensTableAdapter.numregarm = 0 Then
            Id_armTextBox.Text = 1

        Else
            Dim x As String = Me.ArmazensTableAdapter.maxid
            Dim max As Integer = Val(x) + 1
            Id_armTextBox.Text = max
        End If

        Id_armTextBox.ReadOnly = True
        RuaTextBox.Clear()
        CidadeTextBox.Clear()
        Cod_PostalTextBox.Clear()
        TelefoneTextBox.Clear()
        'PaisTextBox.Clear()
        OutrosTextBox.Clear()

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
        Id_armTextBox.Clear()
        insert.Visible = False
        GroupBox2.Visible = False
        search.Visible = True
        endsearch.Visible = True
        GroupBox1.Visible = True
        GroupBox3.Visible = True
        Id_armTextBox.ReadOnly = True
        OutrosTextBox.ReadOnly = True
    End Sub

    Private Sub endsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles endsearch.Click
        GroupBox1.Visible = False
        GroupBox3.Visible = False
        search.Visible = False
        endsearch.Visible = False
        save.Visible = False
    End Sub

End Class
