Public Class Form1


    Private Sub FecharToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharToolStripMenuItem1.Click
        Me.Close()

    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        list_cli.Show()
        list_cli.MdiParent = Me
    End Sub

    Private Sub ListarToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        listforn.Show()
        listforn.MdiParent = Me
    End Sub

    Private Sub OperaçõesToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        op_forn.Show()
        op_forn.MdiParent = Me
    End Sub

    Private Sub ListarToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        list_cat.Show()
        list_cat.MdiParent = Me

    End Sub

    Private Sub OperaçoesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        op_cat.Show()
        op_cat.MdiParent = Me

    End Sub

    Private Sub EncomendaGeralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        list_encgeral.Show()
        list_encgeral.MdiParent = Me


    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        list_encdetalhes.Show()
        list_encdetalhes.MdiParent = Me

    End Sub

    Private Sub OperaçõesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        op_cli.Show()
        op_cli.MdiParent = Me

    End Sub

    Private Sub OperaçõesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        op_encomendasvb.Show()
        op_encomendasvb.MdiParent = Me

    End Sub

    Private Sub ListarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        list_form.Show()
        list_form.MdiParent = Me


    End Sub

    Private Sub OperaçõesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        art_op.MdiParent = Me
        art_op.Show()

    End Sub

    Private Sub ListarToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        list_pag.Show()
        list_pag.MdiParent = Me
    End Sub

    Private Sub OperaçoesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        op_pagv2.Show()
        op_pagv2.MdiParent = Me

    End Sub

    Private Sub RelátorioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        relenc.Show()
        relenc.MdiParent = Me

    End Sub

    Private Sub ConsularEncomendasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        searchvendas.Show()
        searchvendas.MdiParent = Me
    End Sub

    Private Sub EliminarEncomendasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        deleteenc.Show()
        deleteenc.MdiParent = Me

    End Sub

    Private Sub RelatórioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelatórioToolStripMenuItem.Click
        relenc.Show()
        relenc.MdiParent = Me
    End Sub

    Private Sub ListarToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListarToolStripMenuItem5.Click
        list_cli.Show()
        list_cli.MdiParent = Me
    End Sub

    Private Sub OperaçõesToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OperaçõesToolStripMenuItem4.Click

        op_cli.Show()
        op_cli.MdiParent = Me

    End Sub

    Private Sub ListarToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListarToolStripMenuItem6.Click
        listforn.Show()
        listforn.MdiParent = Me
    End Sub

    Private Sub OperaçõesToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OperaçõesToolStripMenuItem5.Click
        op_forn.Show()
        op_forn.MdiParent = Me
    End Sub

    Private Sub ListarToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListarToolStripMenuItem7.Click
        list_cat.Show()
        list_cat.MdiParent = Me

    End Sub

    Private Sub OperaçõesToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OperaçõesToolStripMenuItem6.Click
        op_cat.Show()
        op_cat.MdiParent = Me

    End Sub

    Private Sub ListarToolStripMenuItem8_Click(sender As System.Object, e As System.EventArgs) Handles ListarToolStripMenuItem8.Click
        list_form.Show()
        list_form.MdiParent = Me

    End Sub

    Private Sub OperaçõesToolStripMenuItem7_Click(sender As System.Object, e As System.EventArgs) Handles OperaçõesToolStripMenuItem7.Click
        art_op.MdiParent = Me
        art_op.Show()

    End Sub

    Private Sub ListarToolStripMenuItem10_Click(sender As System.Object, e As System.EventArgs) Handles ListarToolStripMenuItem10.Click
        list_pag.Show()
        list_pag.MdiParent = Me
    End Sub

    Private Sub OperaçõesToolStripMenuItem9_Click(sender As System.Object, e As System.EventArgs) Handles OperaçõesToolStripMenuItem9.Click
        op_pagv2.Show()
        op_pagv2.MdiParent = Me
    End Sub

    Private Sub GeralToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GeralToolStripMenuItem.Click
        list_encgeral.Show()
        list_encgeral.MdiParent = Me
    End Sub

    Private Sub DetalhesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DetalhesToolStripMenuItem.Click
        list_encdetalhes.Show()
        list_encdetalhes.MdiParent = Me
    End Sub

    Private Sub OperaçõesToolStripMenuItem8_Click(sender As System.Object, e As System.EventArgs) Handles OperaçõesToolStripMenuItem8.Click
        op_encomendasvb.Show()
        op_encomendasvb.MdiParent = Me

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        deleteenc.Show()
        deleteenc.MdiParent = Me
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click
        searchvendas.Show()
        searchvendas.MdiParent = Me

    End Sub

    Private Sub OperaçoesToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OperaçoesToolStripMenuItem.Click
        op_emp.Show()
        op_emp.MdiParent = Me

    End Sub

    Private Sub ListarToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListarToolStripMenuItem.Click
        list_emp.Show()
        list_emp.MdiParent = Me

    End Sub

    Private Sub ListarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListarToolStripMenuItem1.Click
        list_dep.Show()
        list_dep.MdiParent = Me

    End Sub

    Private Sub OperaçõesToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OperaçõesToolStripMenuItem.Click
        op_dep.Show()
        op_dep.MdiParent = Me

    End Sub

    Private Sub ArtigosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArtigosToolStripMenuItem1.Click

    End Sub

    Private Sub GestãoDeStocksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestãoDeStocksToolStripMenuItem.Click
        geststock.Show()
        geststock.MdiParent = Me

    End Sub

    Private Sub EspecificaçoesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EspecificaçoesToolStripMenuItem.Click
        list_art_form_esp.Show()
        list_art_form_esp.MdiParent = Me
    End Sub

    Private Sub ListarToolStripMenuItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListarToolStripMenuItem2.Click
        list_arm.Show()
        list_arm.MdiParent = Me

    End Sub

    Private Sub OperaçõesToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OperaçõesToolStripMenuItem1.Click
        op_arm.Show()
        op_arm.MdiParent = Me

    End Sub

    Private Sub ListarToolStripMenuItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListarToolStripMenuItem3.Click
        list_gest_stock.Show()
        list_gest_stock.MdiParent = Me

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim today = Date.Today
        Dim month = today.Month
        Dim year = today.Year
        Dim hoje = today.Day

        TextBox1.Text = hoje & " / " & month & " / " & year
    End Sub
End Class
