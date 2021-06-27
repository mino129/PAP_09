Partial Class art_esp_dbDataSet
    
    Partial Class art_gest_stockDataTable

        Private Sub art_gest_stockDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.id_artColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class


End Class
