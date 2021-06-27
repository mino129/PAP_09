Public Class geststock

    Private Sub ArtigosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ArtigosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_papDataSet)

    End Sub

    Private Sub geststock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Art_esp_dbDataSet.armazens' table. You can move, or remove it, as needed.
        Me.ArmazensTableAdapter.Fill(Me.Art_esp_dbDataSet.armazens)
        'TODO: This line of code loads data into the 'Art_esp_dbDataSet.art_gest_stock' table. You can move, or remove it, as needed.
        Me.Art_gest_stockTableAdapter.Fill(Me.Art_esp_dbDataSet.art_gest_stock)
        'TODO: This line of code loads data into the 'Db_papDataSet.Artigos' table. You can move, or remove it, as needed.

        Me.ArtigosTableAdapter.FillBylowstock(Me.Db_papDataSet.Artigos)

        ID_ArtTextBox.SelectedIndex = -1
        TextBox1.Clear()
        ListBox1.Items.Add("Artigo com maior stock: " & Me.ArtigosTableAdapter.maxstock)
        ListBox1.Items.Add("Artigo com menor stock: " & Me.ArtigosTableAdapter.getminstock)
        Me.ArtigosTableAdapter.Fill(Me.Db_papDataSet.Artigos)
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (Id_armTextBox.SelectedIndex = -1) Then
            MsgBox("Selecione todas as opçoes")

        Else
            Dim a As Integer = Val(Stock_existTextBox.Text) + Val(TextBox1.Text)
            Dim b As String = CStr(a)
            Me.ArtigosTableAdapter.stockupdate(a, ID_ArtTextBox.SelectedValue)
            'Me.Art_gest_stockTableAdapter.updatein(b, Data_modDateTimePicker.Text, TextBox1.Text, ID_ArtTextBox.SelectedValue)
            Me.Art_gest_stockTableAdapter.insertin(ID_ArtTextBox.SelectedValue, b, Data_modDateTimePicker.Text, TextBox1.Text, Id_armTextBox.SelectedValue, ApontamentosTextBox.Text)

            TextBox1.Clear()
            Stock_existTextBox.Clear()
            ID_ArtTextBox.SelectedIndex = -1
        End If

       
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If (TextBox1.Text > Stock_existTextBox.Text) Then
            MsgBox("Nao existe stock suficiente")
            Return

        Else

            Dim a As Integer = Val(Stock_existTextBox.Text) - Val(TextBox1.Text)
            Dim b As String = CStr(a)
            Me.Art_gest_stockTableAdapter.insertout(ID_ArtTextBox.SelectedValue, b, Data_modDateTimePicker.Text, TextBox1.Text, Id_armTextBox.SelectedValue, ApontamentosTextBox.Text)
            'Me.Art_gest_stockTableAdapter.updateon(a, Data_modDateTimePicker.Text, TextBox1.Text, ID_ArtTextBox.SelectedValue)
            Me.ArtigosTableAdapter.stockupdate(b, ID_ArtTextBox.SelectedValue)
            TextBox1.Clear()
            Stock_existTextBox.Clear()
            ID_ArtTextBox.SelectedIndex = -1
        End If

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class