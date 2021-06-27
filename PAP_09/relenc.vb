Public Class relenc

    Private Sub cv1_Click(sender As System.Object, e As System.EventArgs) Handles cv1.Click
        ListBox1.Items.Add("Vendas Totais : " & Me.EncomendaTableAdapter.valorvendas())
        ' ListBox1.Items.Add("Vendas Ano Currente : " & Me.EncomendaTableAdapter.ano(Today.Year))
        'ListBox1.Items.Add("Vendas Mes : " & Me.EncomendaTableAdapter.mes(Today.Month))
        ' ListBox1.Items.Add("Vendas Hoje: " & Me.EncomendaTableAdapter.dia(Today.Day))
        ListBox1.Items.Add("Cliente Mais Frequente: " & Me.EncomendaTableAdapter.maxcli())
        ListBox1.Items.Add("Artigo mais vendido: " & Me.Encomenda_DetalhesTableAdapter.maxart())

    End Sub

    Private Sub EncomendaBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.EncomendaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_papDataSet)

    End Sub

    Private Sub relenc_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_papDataSet.Encomenda_Detalhes' table. You can move, or remove it, as needed.
        Me.Encomenda_DetalhesTableAdapter.Fill(Me.Db_papDataSet.Encomenda_Detalhes)
        'TODO: This line of code loads data into the 'Db_papDataSet.Encomenda' table. You can move, or remove it, as needed.
        Me.EncomendaTableAdapter.Fill(Me.Db_papDataSet.Encomenda)

    End Sub
End Class