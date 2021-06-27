Public Class list_gest_stock

    Private Sub Art_gest_stockBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Art_gest_stockBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Art_gest_stockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Art_esp_dbDataSet)

    End Sub

    Private Sub list_gest_stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Art_esp_dbDataSet.art_gest_stock' table. You can move, or remove it, as needed.
        Me.Art_gest_stockTableAdapter.Fill(Me.Art_esp_dbDataSet.art_gest_stock)

    End Sub
End Class