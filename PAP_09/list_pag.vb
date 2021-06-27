Public Class list_pag

    Private Sub PagamentoBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles PagamentoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PagamentoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_papDataSet)

    End Sub

    Private Sub list_pag_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_papDataSet.Pagamento' table. You can move, or remove it, as needed.
        Me.PagamentoTableAdapter.Fill(Me.Db_papDataSet.Pagamento)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Me.PagamentoTableAdapter.FillByidpag(Me.Db_papDataSet.Pagamento, TextBox1.Text)
        ElseIf RadioButton2.Checked = True Then
            Me.PagamentoTableAdapter.FillBytrans(Me.Db_papDataSet.Pagamento, TextBox1.Text)
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If RadioButton1.Checked = True Or RadioButton2.Checked = True Then
            If Asc(e.KeyChar) <> 8 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub
End Class