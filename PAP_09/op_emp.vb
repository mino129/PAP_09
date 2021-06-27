Public Class op_emp

    Private Sub EMPBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.EMPBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Employeedb_papDataSet)

    End Sub

    Private Sub op_emp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Employeedb_papDataSet.dep' table. You can move, or remove it, as needed.
        Me.DepTableAdapter.Fill(Me.Employeedb_papDataSet.dep)
        'TODO: This line of code loads data into the 'Employeedb_papDataSet.EMP' table. You can move, or remove it, as needed.
        '   Me.EMPTableAdapter.Fill(Me.Employeedb_papDataSet.EMP)
        GroupBox3.Visible = False
        GroupBox1.Visible = False
        deletenome.Visible = False
        deleteid.Visible = False
        numreg.Text = "Numero de Empregados: " + CStr(Me.EMPTableAdapter.numregemp())
        ID_empTextBox.Clear()
        NomeTextBox.Clear()
        E_mailTextBox.Clear()
        MoradaTextBox.Clear()
        Cod_PostalTextBox.Clear()
        CidadeTextBox.Clear()
        Job_nameTextBox.Clear()
        Manager_idTextBox.Clear()
        SalaryTextBox.Clear()
        ' Dep_idTextBox.Clear()


        save.Visible = False
        GroupBox1.Visible = False

        GroupBox2.Visible = False
        insert.Visible = False
        search.Visible = False
        Button3.Visible = False
    End Sub



    Private Sub insertlayer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insertlayer.Click
        ID_empTextBox.Visible = True

        ID_empTextBox.ReadOnly = False
        Emp_nomeTextBox.ReadOnly = False

        NomeTextBox.ReadOnly = False
        E_mailTextBox.ReadOnly = False
        MoradaTextBox.ReadOnly = False
        Cod_PostalTextBox.ReadOnly = False
        CidadeTextBox.ReadOnly = False
        Job_nameTextBox.ReadOnly = False
        Manager_idTextBox.ReadOnly = False
        SalaryTextBox.ReadOnly = False
        '   Dep_idTextBox.ReadOnly = False


        If Me.EMPTableAdapter.numregemp = 0 Then
            ID_empTextBox.Text = 1

        Else
            Dim m As String = Me.EMPTableAdapter.maxid()
            Dim max = Val(m) + 1
            ID_empTextBox.Text = max
        End If

        ID_empTextBox.ReadOnly = True
        search.Visible = False
        Button3.Visible = False
        GroupBox3.Visible = False
        insert.Visible = True
        GroupBox1.Visible = True
        GroupBox2.Visible = False



    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        search.Visible = False
        Button3.Visible = False
        insert.Visible = False
        GroupBox1.Visible = False
        GroupBox2.Visible = True
        deletenome.Visible = True
        deleteid.Visible = True
        GroupBox3.Visible = False
    End Sub

    Private Sub searchlayer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchlayer.Click
        ID_empTextBox.Clear()
        insert.Visible = False
        GroupBox2.Visible = False
        search.Visible = True
        GroupBox3.Visible = True
        GroupBox1.Visible = True
        Button3.Visible = True
        ID_empTextBox.ReadOnly = True
        NomeTextBox.ReadOnly = True
        Emp_nomeTextBox.ReadOnly = True
        E_mailTextBox.ReadOnly = True
        MoradaTextBox.ReadOnly = True
        Cod_PostalTextBox.ReadOnly = True
        CidadeTextBox.ReadOnly = True
        Job_nameTextBox.ReadOnly = True
        Manager_idTextBox.ReadOnly = True
        SalaryTextBox.ReadOnly = True
        '   Dep_idTextBox.ReadOnly = True
    End Sub

    Private Sub save_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        GroupBox1.Visible = False

        Me.EMPTableAdapter.updatempu(Emp_nomeTextBox.Text, NomeTextBox.Text, E_mailTextBox.Text, MoradaTextBox.Text, CidadeTextBox.Text, Cod_PostalTextBox.Text, PaisTextBox.Text, Job_nameTextBox.Text, Hire_dateDateTimePicker.Text, SalaryTextBox.Text, Dep_idTextBox.SelectedValue, ID_empTextBox.Text)
        ID_empTextBox.Visible = True
        save.Visible = False
       


        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False

        save.Visible = False




        ID_empTextBox.ReadOnly = False


        search.Visible = False
        Button3.Visible = False

    End Sub

    Private Sub search_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.Click
        Me.EMPTableAdapter.FillBynome(Me.Employeedb_papDataSet.EMP, updatetext.Text)
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ID_empTextBox.Visible = True
        ID_empTextBox.Clear()
        NomeTextBox.Clear()
        E_mailTextBox.Clear()
        MoradaTextBox.Clear()
        Cod_PostalTextBox.Clear()
        CidadeTextBox.Clear()
        Job_nameTextBox.Clear()
        Manager_idTextBox.Clear()
        SalaryTextBox.Clear()
        '  Dep_idTextBox.Clear()
        save.Visible = False
        GroupBox1.Visible = False
        GroupBox3.Visible = False
        search.Visible = False
        Button3.Visible = False
    End Sub

    Private Sub deletenome_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deletenome.Click
        Dim answer As Integer = MsgBox("Tem a certeza que quer apagar este registo?", MsgBoxStyle.YesNo)

        If answer = DialogResult.Yes Then
            Dim a As Integer = Me.EMPTableAdapter.deletepernome(txtdelete.Text)
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

    Private Sub deleteid_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteid.Click
        Dim answer As Integer = MsgBox("Tem a certeza que quer apagar este registo?", MsgBoxStyle.YesNo)

        If answer = DialogResult.Yes Then
            Dim x As Integer = Me.EMPTableAdapter.deleteperid(txtdelete.Text)
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

    Private Sub update_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update.Click
        save.Visible = True
        ID_empTextBox.ReadOnly = False
        NomeTextBox.ReadOnly = False
        E_mailTextBox.ReadOnly = False
        MoradaTextBox.ReadOnly = False
        Cod_PostalTextBox.ReadOnly = False
        CidadeTextBox.ReadOnly = False
        Job_nameTextBox.ReadOnly = False
        Manager_idTextBox.ReadOnly = False
        SalaryTextBox.ReadOnly = False
        ' Dep_idTextBox.ReadOnly = False
        Me.EMPTableAdapter.FillBynome(Me.Employeedb_papDataSet.EMP, updatetext.Text)
    End Sub

    Private Sub insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insert.Click
        If (NomeTextBox.Text = "" Or CidadeTextBox.Text = "" Or Cod_PostalTextBox.Text = "" Or E_mailTextBox.Text = "" Or PaisTextBox.Text = "" Or Dep_idTextBox.SelectedIndex = -1) Then
            MsgBox("Por favor preencha todas as caixas de texto")
        Else
            'Para testar criar outro formulario

            Me.EMPTableAdapter.insertemp(ID_empTextBox.Text, Emp_nomeTextBox.Text, NomeTextBox.Text, E_mailTextBox.Text, MoradaTextBox.Text, CidadeTextBox.Text, Cod_PostalTextBox.Text, PaisTextBox.Text, Job_nameTextBox.Text, Val(Manager_idTextBox.Text), Hire_dateDateTimePicker.Text, Val(SalaryTextBox.Text), Dep_idTextBox.SelectedValue)

            numreg.Text = "Numero de Empregados : " + CStr(Me.EMPTableAdapter.numregemp())
            GroupBox1.Visible = False
            ID_empTextBox.Clear()
            NomeTextBox.Clear()
            E_mailTextBox.Clear()
            MoradaTextBox.Clear()
            Cod_PostalTextBox.Clear()
            CidadeTextBox.Clear()
            Job_nameTextBox.Clear()
            Manager_idTextBox.Clear()
            SalaryTextBox.Clear()
            '   Dep_idTextBox.Clear()
            insert.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ID_empTextBox.Clear()
        NomeTextBox.Clear()
        E_mailTextBox.Clear()
        MoradaTextBox.Clear()
        Cod_PostalTextBox.Clear()
        CidadeTextBox.Clear()
        Job_nameTextBox.Clear()
        Manager_idTextBox.Clear()
        SalaryTextBox.Clear()
        '  Dep_idTextBox.Clear()
    End Sub
End Class