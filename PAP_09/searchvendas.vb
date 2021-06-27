Public Class searchvendas

    Private Sub EncomendaBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles EncomendaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EncomendaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_papDataSet)

    End Sub

    Private Sub searchvendas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_papDataSet.Encomenda_Detalhes' table. You can move, or remove it, as needed.
        Me.Encomenda_DetalhesTableAdapter.Fill(Me.Db_papDataSet.Encomenda_Detalhes)
        'TODO: This line of code loads data into the 'Db_papDataSet.Encomenda' table. You can move, or remove it, as needed.
        Me.EncomendaTableAdapter.Fill(Me.Db_papDataSet.Encomenda)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Me.EncomendaTableAdapter.FillByidenc(Me.Db_papDataSet.Encomenda, TextBox1.Text)
            Me.Encomenda_DetalhesTableAdapter.FillByidenc(Me.Db_papDataSet.Encomenda_Detalhes, TextBox1.Text)
        ElseIf RadioButton2.Checked = True Then
            Me.EncomendaTableAdapter.FillByidcli(Me.Db_papDataSet.Encomenda, TextBox1.Text)
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