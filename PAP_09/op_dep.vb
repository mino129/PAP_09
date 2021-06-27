Public Class op_dep

    Private Sub DepBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.DepBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Employeedb_papDataSet)

    End Sub

    Private Sub op_dep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Employeedb_papDataSet.dep' table. You can move, or remove it, as needed.
        '   Me.DepTableAdapter.Fill(Me.Employeedb_papDataSet.dep)
        search.Visible = False
        endsearch.Visible = False
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        ID_depTextBox.Clear()
        NomeTextBox.Clear()

        numreg.Text = "Numero de Departamentos: " + CStr(Me.DepTableAdapter.numregdep())
        save.Visible = False
        insert.Visible = False
    End Sub

    Private Sub insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insert.Click
        If (NomeTextBox.Text = "") Then
            MsgBox("Por favor preencha as caixas de texto")
        Else
            Me.DepTableAdapter.insertdep(NomeTextBox.Text)
            numreg.Text = "Numero de Departamentos: " + CStr(Me.DepTableAdapter.numregdep())
            GroupBox1.Visible = False
            insert.Visible = False
            ID_depTextBox.Clear()
            NomeTextBox.Clear()
        End If
    End Sub

    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.Click
        Me.DepTableAdapter.FillBynome(Me.Employeedb_papDataSet.dep, NomeTextBox.Text)

    End Sub
    Private Sub deletenome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deletenome.Click
        Dim answer As Integer = MsgBox("Tem a certeza que quer apagar este registo?", MsgBoxStyle.YesNo)

        If answer = DialogResult.Yes Then
            Dim x As Integer = Me.DepTableAdapter.deletepernome(txtdelete.Text)
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
            Dim a As Integer = Me.DepTableAdapter.deleteperid(txtdelete.Text)
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


        save.Visible = True
        ID_depTextBox.Visible = False
        Me.DepTableAdapter.FillBynome(Me.Employeedb_papDataSet.dep, updatetext.Text)
        ID_depTextBox.Visible = False
        updatetext.Clear()


    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        Me.DepTableAdapter.updatedep(NomeTextBox.Text, ID_depTextBox.Text)

        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        ID_depTextBox.Visible = True
        save.Visible = False
        ID_depTextBox.Clear()
        NomeTextBox.Clear()



        ID_depTextBox.ReadOnly = False
        NomeTextBox.ReadOnly = False


        search.Visible = False
        endsearch.Visible = False
    End Sub

    Private Sub deletelayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        deletenome.Visible = True
        deleteid.Visible = True
        txtdelete.Visible = True
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        NomeTextBox.Clear()

        updatetext.Clear()
        txtdelete.Clear()



    End Sub

    Private Sub insertlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insertlayer.Click
        ID_depTextBox.Visible = True
        NomeTextBox.ReadOnly = False


        If Me.DepTableAdapter.numregdep() = 0 Then
            ID_depTextBox.Text = 1

        Else
            Dim x As String = Me.DepTableAdapter.maxid()
            Dim max As Integer = Val(x) + 1
            ID_depTextBox.Text = max
        End If

        ID_depTextBox.ReadOnly = True
        NomeTextBox.Clear()
        updatetext.Clear()
        txtdelete.Clear()
        GroupBox3.Visible = False
        GroupBox2.Visible = False
        GroupBox1.Visible = True
        insert.Visible = True
        search.Visible = False
        endsearch.Visible = False



    End Sub

    Private Sub searchlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchlayer.Click
        ID_depTextBox.Clear()
        insert.Visible = False
        GroupBox2.Visible = False
        search.Visible = True
        endsearch.Visible = True
        GroupBox1.Visible = True
        GroupBox3.Visible = True
        ID_depTextBox.ReadOnly = True
        NomeTextBox.ReadOnly = True
    End Sub

    Private Sub endsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles endsearch.Click
        GroupBox1.Visible = False
        GroupBox3.Visible = False
        search.Visible = False
        endsearch.Visible = False
        save.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        insert.Visible = False
        GroupBox3.Visible = False
        search.Visible = False
        endsearch.Visible = False
        GroupBox2.Visible = True
        GroupBox1.Visible = False
        insert.Visible = False
    End Sub
End Class