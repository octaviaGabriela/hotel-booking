Public Class ImagineDeInceput


    Private Sub ImagineDeInceput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        Label2.Text = Convert.ToString(ProgressBar1.Value) + "%"
        If ProgressBar1.Value = 100 Then
            Me.Hide()
            Dim log = New LogareCont
            log.Show()
            Timer1.Enabled = False
        End If
    End Sub


End Class