Public Class list_art_form_esp

    Private Sub Art_espBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Art_espBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Art_espBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Art_esp_dbDataSet)

    End Sub

    Private Sub list_art_form_esp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Art_esp_dbDataSet.art_esp' table. You can move, or remove it, as needed.
        Me.Art_espTableAdapter.Fill(Me.Art_esp_dbDataSet.art_esp)

    End Sub
End Class