Public Class listdep

    Private Sub DepBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DepBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Employeedb_papDataSet)

    End Sub

    Private Sub listdep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Employeedb_papDataSet.dep' table. You can move, or remove it, as needed.
        Me.DepTableAdapter.Fill(Me.Employeedb_papDataSet.dep)

    End Sub
End Class