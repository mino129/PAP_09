Public Class list_form

    Private Sub ArtigosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ArtigosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ArtigosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_papDataSet)

    End Sub

    Private Sub list_form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Art_esp_dbDataSet.art_esp' table. You can move, or remove it, as needed.
        Me.Art_espTableAdapter.Fill(Me.Art_esp_dbDataSet.art_esp)
        'TODO: This line of code loads data into the 'Db_papDataSet.Artigos' table. You can move, or remove it, as needed.
        Me.ArtigosTableAdapter.Fill(Me.Db_papDataSet.Artigos)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Me.ArtigosTableAdapter.FillByidart(Me.Db_papDataSet.Artigos, TextBox1.Text)

        ElseIf RadioButton3.Checked = True Then
            Me.ArtigosTableAdapter.FillByfornid(Me.Db_papDataSet.Artigos, TextBox1.Text)
        ElseIf RadioButton4.Checked = True Then
            Me.ArtigosTableAdapter.FillBycatid(Me.Db_papDataSet.Artigos, TextBox1.Text)

        End If
    End Sub

 
    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If RadioButton1.Checked = True Or RadioButton3.Checked = True Or RadioButton4.Checked = True Then
            If Asc(e.KeyChar) <> 8 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged
        TextBox1.Clear()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged
        TextBox1.Clear()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.Clear()

    End Sub
End Class