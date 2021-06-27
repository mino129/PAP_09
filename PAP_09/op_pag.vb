Public Class op_pag

    Private Sub PagamentoBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.PagamentoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_papDataSet)

    End Sub

    Private Sub op_pag_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_papDataSet.Encomenda' table. You can move, or remove it, as needed.
        Me.EncomendaTableAdapter.Fill(Me.Db_papDataSet.Encomenda)
        'TODO: This line of code loads data into the 'Db_papDataSet.Pagamento' table. You can move, or remove it, as needed.
        '   Me.PagamentoTableAdapter.Fill(Me.Db_papDataSet.Pagamento)
        ID_PagamentoTextBox.Text = Me.PagamentoTableAdapter.numregpag
        ID_PagamentoTextBox.ReadOnly = True
        TipoTextBox.SelectedIndex = 6
        N_TransicaoTextBox.Text = Me.EncomendaTableAdapter.maxid()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click


        Dim answer As Integer = MsgBox("Inserir Dados de Pagamento?", MsgBoxStyle.YesNo)

        If answer = DialogResult.Yes Then
            Dim a As Integer = Me.PagamentoTableAdapter.updatepag(TipoTextBox.Text, Data_PagamentoDateTimePicker.Text, N_TransicaoTextBox.Text, ID_PagamentoTextBox.Text)
            If a = 1 Then
                MsgBox("Pagamento Inserido com Sucesso")
                Me.Close()


            End If
        Else
            MsgBox("Cancelado")
        End If

    End Sub
End Class