Public Class list_cat

    Private Sub CategoriaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoriaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CategoriaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_papDataSet)

    End Sub

    Private Sub list_cat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_papDataSet.Categoria' table. You can move, or remove it, as needed.
        Me.CategoriaTableAdapter.Fill(Me.Db_papDataSet.Categoria)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Me.CategoriaTableAdapter.FillByid(Me.Db_papDataSet.Categoria, TextBox1.Text)
        ElseIf RadioButton2.Checked = True Then
            Me.CategoriaTableAdapter.FillBysearchcat(Me.Db_papDataSet.Categoria, TextBox1.Text)

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.Clear()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If RadioButton1.Checked = True Then
            If Asc(e.KeyChar) <> 8 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub
End Class