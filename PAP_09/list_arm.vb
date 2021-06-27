Public Class list_arm

    Private Sub ArmazensBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArmazensBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ArmazensBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Art_esp_dbDataSet)

    End Sub

    Private Sub list_arm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Art_esp_dbDataSet.armazens' table. You can move, or remove it, as needed.
        Me.ArmazensTableAdapter.Fill(Me.Art_esp_dbDataSet.armazens)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Me.ArmazensTableAdapter.FillByidarm(Me.Art_esp_dbDataSet.armazens, TextBox1.Text)
        ElseIf RadioButton2.Checked = True Then
            Me.ArmazensTableAdapter.FillBycidade(Me.Art_esp_dbDataSet.armazens, TextBox1.Text)
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        TextBox1.Clear()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.Clear()
    End Sub
End Class