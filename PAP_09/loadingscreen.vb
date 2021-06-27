Public Class loadingscreen

    Private Sub loadingscreen_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Timer1.Start()

        Dim ofd As New OpenFileDialog()
        ofd.Filter = "bild offnen (*.png) |*.png |ALL Files|*.*"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            login.Show()
            Me.Hide()
            Timer1.Stop()

        End If
    End Sub
End Class