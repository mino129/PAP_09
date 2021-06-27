Public Class list_encgeral

    Private Sub EncomendaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EncomendaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EncomendaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_papDataSet)

    End Sub

    Private Sub list_encgeral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_papDataSet.Encomenda' table. You can move, or remove it, as needed.
        Me.EncomendaTableAdapter.Fill(Me.Db_papDataSet.Encomenda)

    End Sub
End Class