Public Class menuemp

    Private Sub ListarToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub OperaçõesToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub OperaçõesToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub OperaçõesToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        op_encomendasvb.Show()
        op_encomendasvb.MdiParent = Me
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        list_cli.Show()
        list_cli.MdiParent = Me
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        op_cli.Show()
        op_cli.MdiParent = Me
    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        op_pagv2.Show()
        op_pagv2.MdiParent = Me
    End Sub

    Private Sub GestãoDeStocksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestãoDeStocksToolStripMenuItem.Click
        geststock.Show()
        geststock.MdiParent = Me
    End Sub

    Private Sub ListarToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListarToolStripMenuItem3.Click
        list_gest_stock.Show()
        list_gest_stock.MdiParent = Me

    End Sub
End Class