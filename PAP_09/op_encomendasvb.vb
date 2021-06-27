Public Class op_encomendasvb

    Private Sub EncomendaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.EncomendaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_papDataSet)

    End Sub

    Private Sub op_encomendasvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Art_esp_dbDataSet.art_gest_stock' table. You can move, or remove it, as needed.
        Me.Art_gest_stockTableAdapter.Fill(Me.Art_esp_dbDataSet.art_gest_stock)
        'TODO: This line of code loads data into the 'Db_papDataSet.Categoria' table. You can move, or remove it, as needed.
        Me.CategoriaTableAdapter.Fill(Me.Db_papDataSet.Categoria)
        'TODO: This line of code loads data into the 'Db_papDataSet.Pagamento' table. You can move, or remove it, as needed.
        Me.PagamentoTableAdapter.Fill(Me.Db_papDataSet.Pagamento)
        'TODO: This line of code loads data into the 'Db_papDataSet.Artigos' table. You can move, or remove it, as needed.
        Me.ArtigosTableAdapter.Fill(Me.Db_papDataSet.Artigos)
        'TODO: This line of code loads data into the 'Db_papDataSet.Clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.Db_papDataSet.Clientes)
        'TODO: This line of code loads data into the 'Db_papDataSet.Encomenda_Detalhes' table. You can move, or remove it, as needed.
        Me.Encomenda_DetalhesTableAdapter.Fill(Me.Db_papDataSet.Encomenda_Detalhes)
        'TODO: This line of code loads data into the 'Db_papDataSet.Encomenda' table. You can move, or remove it, as needed.
        '   Me.EncomendaTableAdapter.Fill(Me.Db_papDataSet.Encomenda)

        ID_EncTextBox.ReadOnly = True

        endsale.Enabled = False
        ComboBox1.Enabled = False

        If Me.EncomendaTableAdapter.numregencomendas = 0 Then
            ID_EncTextBox.Text = 1
        Else
            ID_EncTextBox.Text = Me.EncomendaTableAdapter.maxid() + 1
        End If


        ListBox1.Items.Add("Detalhes da Venda: ")
        txtendpricefalse.Visible = True
        ID_PagamentoTextBox.Visible = False

        insertprod.Visible = False
        cb1.Enabled = False
        DescontoTextBox.Enabled = False

        PreçoTextBox.ReadOnly = True
        ' = True
        QuantTextBox.ReadOnly = True
        'TextBox1.ReadOnly = True
        TextBox2.Text = "Vendas Totais: " & Me.EncomendaTableAdapter.valorvendas()
        TextBox1.Text = "Numero de Vendas existentes: " & Me.EncomendaTableAdapter.numregencomendas()
        TextBox3.Text = "Ultima venda em: " & Me.EncomendaTableAdapter.dataultvenda()

        ID_CliTextBox.Select()
        '
        '  MsgBox(ID_EncTextBox.Text)
        ' MsgBox(ID_PagamentoTextBox.Text)

        If Me.PagamentoTableAdapter.numregpag() = 0 Then
            ID_PagamentoTextBox.Text = 1
        Else
            ID_PagamentoTextBox.Text = Me.PagamentoTableAdapter.maxid() + 1
        End If


        endsale.Enabled = False
        pagclick.Enabled = False


    End Sub

    Private Sub insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insert.Click
        ComboBox1.Enabled = True

        If (ID_CliTextBox.Text = "") Then
            MsgBox("Por favor indique o cliente. Se necessitar prima F5 para visualizar os clientes existentes")
        Else
            'endsale.Enabled = True
            DescontoTextBox.SelectedIndex = 0
            ComboBox1.SelectedIndex = 2
            pagclick.Enabled = True
            Me.PagamentoTableAdapter.insertpaguwu(ID_PagamentoTextBox.Text)
            '  MsgBox("ola mundo: " & ID_CompraTextBox.Text)
            insertprod.Visible = True
            ' If ID_CliTextBox.Text = "" Then
            'MsgBox("Insira um cliente! F5 para ver a lista dos mesmos")

            ' Else
            ' MsgBox(ID_EncTextBox.Text)
            txtendpricefalse.Text = 0
            'Dim a As Integer = ID_EncTextBox.Text + 1

            '  If CheckBox1.Checked = True Then
            ' Me.EncomendaTableAdapter.insertencomenda(ID_EncTextBox.Text, Data_EncDateTimePicker.Text, comentariostextbox.Text, Data_EnvioDateTimePicker.Text, txtendpricefalse.Text, 1, ID_PagamentoTextBox.Text)
            'End If
            Me.EncomendaTableAdapter.insertencomenda(ID_EncTextBox.Text, Data_EncDateTimePicker.Text, comentariostextbox.Text, Data_EnvioDateTimePicker.Text, txtendpricefalse.Text, ID_CliTextBox.Text, ID_PagamentoTextBox.Text)

            ID_EncTextBox.ReadOnly = True

            PreçoTextBox.ReadOnly = True
            ID_CliTextBox.ReadOnly = True
            DescontoTextBox.Enabled = True

            cb1.Enabled = True
            PreçoTextBox.ReadOnly = False
            ' = False
            QuantTextBox.ReadOnly = False
            cb1.SelectedIndex = -1


        End If

        '  End If




    End Sub

    Private Sub insertprod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insertprod.Click
        If (QuantTextBox.Text = "" Or PreçoTextBox.Text = "" Or DescontoTextBox.Text = "") Then
            MsgBox("Por favor indique as nome/caractristicas do produto")
        Else


            Dim stock As Integer = Me.ArtigosTableAdapter.stockqueryid(cb1.SelectedValue)

            If (QuantTextBox.Text > stock) Then
                MsgBox("Nao existe stock suficiente")
                Return
            Else

                Dim quantpcx As Integer = Me.ArtigosTableAdapter.qtpcxquery(cb1.SelectedValue)
                Dim desc As Decimal = Val(DescontoTextBox.Text) / 100
                Dim iva As Decimal = Val(ComboBox1.Text) / 100
                Dim prec As Decimal = Val(PreçoTextBox.Text)
                Dim precfi As Decimal = Val(QuantTextBox.Text) * ((prec - (prec * desc)) * quantpcx)
                Dim precfin As Integer = (precfi * iva) + precfi
                '   MsgBox(precfin)
                Dim stockupdate = stock - QuantTextBox.Text
                txtendpricefalse.Text = Val(txtendpricefalse.Text) + precfin

                ' MsgBox(txtendpricefalse.Text)
                Me.ArtigosTableAdapter.updatestock(stockupdate, cb1.SelectedValue)
                Me.Art_gest_stockTableAdapter.updatestock(stockupdate, cb1.SelectedValue)
                '  MsgBox("Quantidade por caixa: " & quantpcx & " Preço Final : " & precfin)
                Me.Encomenda_DetalhesTableAdapter.insertencdetalhes(ID_EncTextBox.Text, cb1.SelectedValue, Val(QuantTextBox.Text), precfin, Val(DescontoTextBox.Text))
                ListBox1.Items.Add("Item: " & cb1.Text & " Quantidade: " & QuantTextBox.Text & " Quantidade por caixa: " & quantpcx & " IVA : " & ComboBox1.Text & " Preço sem IVA: " & precfi & " Preço com IVA : " & precfin & " Desconto: " & DescontoTextBox.Text)
            End If
        End If

    End Sub


    Private Sub endsale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles endsale.Click
        ComboBox1.Enabled = False

        endsale.Enabled = False

        pagclick.Enabled = False
        insertprod.Visible = False
        ' MsgBox(txtendpricefalse.Text)
        Me.EncomendaTableAdapter.updaprecfinalenc(comentariostextbox.Text, PreçoTextBox.Text, ID_EncTextBox.Text)
        '  MsgBox(" ID Compra: >" & ID_CompraTextBox.Text & "<")

        TextBox1.Text = "Numero de Vendas existentes: " & Me.EncomendaTableAdapter.numregencomendas()


        ID_EncTextBox.Clear()
        ID_CliTextBox.Clear()
        QuantTextBox.Clear()
        PreçoTextBox.Clear()
        ' DescontoTextBox.Clear()
        comentariostextbox.Clear()

        comentariostextbox.ReadOnly = False
        PreçoTextBox.ReadOnly = False
        ID_CliTextBox.ReadOnly = False
        DescontoTextBox.Enabled = False

        cb1.Enabled = False
        PreçoTextBox.ReadOnly = True
        '  DescontoTextBox.ReadOnly = True
        QuantTextBox.ReadOnly = True

        ListBox1.Items.Clear()


        Dim a As Integer = Me.EncomendaTableAdapter.maxid
        ID_EncTextBox.Text = a + 1

        ID_PagamentoTextBox.Text = Me.PagamentoTableAdapter.maxid() + 1



    End Sub

    Private Sub cb1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb1.SelectedIndexChanged

        If cb1.Text <> "" Then
            PreçoTextBox.Text = Me.ArtigosTableAdapter.searchquery(cb1.SelectedValue)
            'Label1.Text = Me.ArtigosTableAdapter.nomeart(cb1.Text)

        End If

    End Sub

    Private Sub ID_CliTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ID_CliTextBox.KeyDown
        If e.KeyCode = Keys.F5 Then

            list_cli.Show()

        End If
    End Sub


    Private Sub pagclick_Click(sender As System.Object, e As System.EventArgs) Handles pagclick.Click
        endsale.Enabled = True
        pagclick.Enabled = False
        op_pag.Show()
    End Sub

    Private Sub ID_CliTextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles ID_CliTextBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        ID_CliTextBox.Text = 1
    End Sub

    Private Sub ID_CliTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ID_CliTextBox.TextChanged

    End Sub
End Class