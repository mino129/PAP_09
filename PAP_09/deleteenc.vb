Public Class deleteenc

    Private Sub deleteid_Click(sender As System.Object, e As System.EventArgs) Handles deleteid.Click
        Dim answer As Integer = MsgBox("Tem a certeza que quer apagar este registo?", MsgBoxStyle.YesNo)

        If answer = DialogResult.Yes Then
            Dim x As Integer = Me.EncomendaTableAdapter.deleteenc(txtdelete.Text)

            If x = 1 Then
                MsgBox("Encomenda apagada com sucesso")
            Else
                MsgBox("Não existe encomendas com esse ID")
            End If
        Else
            MsgBox("Cancelado")
        End If

    End Sub

    Private Sub EncomendaBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.EncomendaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_papDataSet)

    End Sub


    Private Sub EncomendaBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.EncomendaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_papDataSet)

    End Sub

    Private Sub deleteenc_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_papDataSet.Encomenda' table. You can move, or remove it, as needed.
        Me.EncomendaTableAdapter.Fill(Me.Db_papDataSet.Encomenda)

    End Sub
End Class