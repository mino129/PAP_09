Public Class login

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If RadioButton1.Checked = True Then
          

            If (TextBox1.Text = "Admin" Or TextBox1.Text = "admin" Or TextBox1.Text = "ADMIN") And (TextBox2.Text = "pass123") Then
                Form1.Show()
                'Tirar comentario antes de dar publish e ao mesmo tempo por loading screen como formulario que da boot da aplicaçao
                ' Me.Hide()

            Else
                MsgBox("Credenciais Erradas!")
            End If

        ElseIf RadioButton2.Checked = True Then
            If (TextBox1.Text = "emp" Or TextBox1.Text = "Emp" Or TextBox1.Text = "EMP") And (TextBox2.Text = "emp123") Then
                menuemp.Show()
            Else
                MsgBox("Credenciais Erradas!")
            End If
        End If


     
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        RadioButton1.Checked = True

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            TextBox2.PasswordChar = "*"
        Else
            TextBox2.PasswordChar = ""
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
End Class