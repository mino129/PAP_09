Public Class list_emp

    Private Sub EMPBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMPBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EMPBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Employeedb_papDataSet)

    End Sub

    Private Sub list_emp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Employeedb_papDataSet.EMP' table. You can move, or remove it, as needed.
        Me.EMPTableAdapter.Fill(Me.Employeedb_papDataSet.EMP)

    End Sub
End Class