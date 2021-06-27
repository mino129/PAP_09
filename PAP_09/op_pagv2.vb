Public Class op_pagv2

    Private Sub PagamentoBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.PagamentoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_papDataSet)

    End Sub

    Private Sub op_pagv2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_papDataSet.Pagamento' table. You can move, or remove it, as needed.
        ' Me.PagamentoTableAdapter.Fill(Me.Db_papDataSet.Pagamento)
        GroupBox3.Visible = False
        GroupBox1.Visible = False
        deletenome.Visible = False
        deleteid.Visible = False
        numreg.Text = "Numero de Pagamentos : " + CStr(Me.PagamentoTableAdapter.numregpag())
        ID_PagamentoTextBox.Clear()
        '()
        N_TransicaoTextBox.Clear()
        Button4.Visible = False
        tipopag.Visible = False



        save.Visible = False
        GroupBox1.Visible = False

        GroupBox2.Visible = False
        insert.Visible = False
        search.Visible = False
        Button3.Visible = False
    End Sub

    Private Sub insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insert.Click
        If (TipoTextBox.Text = "" Or N_TransicaoTextBox.Text = "") Then
            MsgBox("Por favor preencha todas as caixas de texto")
        Else
            Me.PagamentoTableAdapter.insertpag(ID_PagamentoTextBox.Text, TipoTextBox.Text, Data_PagamentoDateTimePicker.Text, N_TransicaoTextBox.Text)
            numreg.Text = "Numero de Pagamentos : " + CStr(Me.PagamentoTableAdapter.numregpag)
            GroupBox1.Visible = False
          ID_PagamentoTextBox.Clear()
            'TipoTextBox.Clear()
            N_TransicaoTextBox.Clear()
            insert.Visible = False
        End If



    End Sub

    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.Click
        Me.PagamentoTableAdapter.FillBytrans(Me.Db_papDataSet.Pagamento, N_TransicaoTextBox.Text)
    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        deletenome.Visible = True
        deleteid.Visible = True
    End Sub


    Private Sub deletenome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deletenome.Click
        Dim answer As Integer = MsgBox("Tem a certeza que quer apagar este registo?", MsgBoxStyle.YesNo)

        If answer = DialogResult.Yes Then
            Dim a As Integer = Me.PagamentoTableAdapter.deletebyntrans(txtdelete.Text)
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
            Dim x As Integer = Me.PagamentoTableAdapter.deletepagbyid(txtdelete.Text)
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

        ID_PagamentoTextBox.Visible = False


        '   ID_PagamentoTextBox.ReadOnly = True

        ' TipoTextBox.ReadOnly = True
        '  N_TransicaoTextBox.ReadOnly = True
        Me.PagamentoTableAdapter.FillByidpag(Me.Db_papDataSet.Pagamento, updatetext.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ID_PagamentoTextBox.Clear()
        TipoTextBox.SelectedIndex = -1
        N_TransicaoTextBox.Clear()


    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click

        ' If (N_TransicaoTextBox.Text = "" Or TipoTextBox.Text = "") Then
        '    MsgBox("Por favor preencha todas as caixas de texto")
        '       Else

        Me.PagamentoTableAdapter.updateid(TipoTextBox.Text, Data_PagamentoDateTimePicker.Text, Val(N_TransicaoTextBox.Text), ID_PagamentoTextBox.Text)
        ID_PagamentoTextBox.Visible = True
        save.Visible = False
        ID_PagamentoTextBox.Clear()
        ' TipoTextBox.Clear()
        N_TransicaoTextBox.Clear()


        '    End If

        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        ID_PagamentoTextBox.Visible = True
        save.Visible = False
        ID_PagamentoTextBox.Clear()
        N_TransicaoTextBox.Clear()



        ID_PagamentoTextBox.ReadOnly = False
        N_TransicaoTextBox.ReadOnly = False


        search.Visible = False
        Button3.Visible = False





    End Sub

    Private Sub insertlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insertlayer.Click
        Button4.Visible = True
        tipopag.Visible = True
        ID_PagamentoTextBox.Visible = True
        ID_PagamentoTextBox.ReadOnly = False
        'TipoTextBox.ReadOnly = False
        N_TransicaoTextBox.ReadOnly = False

        TipoTextBox.SelectedIndex = 6




        If Me.PagamentoTableAdapter.numregpag = 0 Then
            ID_PagamentoTextBox.Text = 1

        Else
            Dim m As String = Me.PagamentoTableAdapter.maxid()
            Dim max = Val(m) + 1
            ID_PagamentoTextBox.Text = max
        End If

        ID_PagamentoTextBox.ReadOnly = True
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
        Button4.Visible = False
        tipopag.Visible = False
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
        ID_PagamentoTextBox.Clear()
        Button4.Visible = False
        tipopag.Visible = False
        insert.Visible = False
        GroupBox2.Visible = False
        search.Visible = True
        GroupBox3.Visible = True
        GroupBox1.Visible = True
        Button3.Visible = True
        ID_PagamentoTextBox.ReadOnly = True

        ' TipoTextBox.ReadOnly = True
        '   N_TransicaoTextBox.ReadOnly = True


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        save.Visible = False
        GroupBox1.Visible = False
        GroupBox3.Visible = False
        search.Visible = False
        Button3.Visible = False
    End Sub

    Private Sub N_TransicaoTextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles N_TransicaoTextBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TipoTextBox.Items.Add(tipopag.Text)
        Button4.Visible = False
        tipopag.Visible = False
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
End Class