Public Class list_encdetalhes

    Private Sub Encomenda_DetalhesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Encomenda_DetalhesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Encomenda_DetalhesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_papDataSet)

    End Sub

    Private Sub list_encdetalhes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_papDataSet.Encomenda_Detalhes' table. You can move, or remove it, as needed.
        Me.Encomenda_DetalhesTableAdapter.Fill(Me.Db_papDataSet.Encomenda_Detalhes)

    End Sub
End Class