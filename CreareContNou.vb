Imports System.Data.SqlClient
Public Class CreareContNou
    Dim Con As New SqlConnection("Data Source=DESKTOP-A4RFJNL\SQLSERVEROCT;Initial Catalog=HOTELmanagement;Integrated Security=True")

    'BUTON SALVEAZA
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonSalveaza.Click
        If TextBoxNumeCCN.Text = "" Or TextBoxPrenumeCCN.Text = "" Or TextBoxNrTelCCN.Text = "" Or ComboBoxSexCCN.Text = "" Or TextBoxParolaCCN.Text = "" Or ComboBoxTipUtilizatorCCN.Text = "" Then
            MsgBox("Un câmp nu a fost completat")
        Else
            Try

                If Con.State = ConnectionState.Closed Then
                    Con.Open()
                End If
                Dim query As String
                query = "insert into Utilizator values('" & TextBoxNumeCCN.Text & "','" & TextBoxPrenumeCCN.Text & "', '" & TextBoxNrTelCCN.Text & "' , '" & ComboBoxSexCCN.SelectedItem & "' ,'" & TextBoxParolaCCN.Text & "','" & ComboBoxTipUtilizatorCCN.SelectedItem & "'  ) "
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Utilizatorul a fost adăugat")
                Con.Close()


                Clear()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Clear()
        TextBoxNumeCCN.Clear()
        TextBoxPrenumeCCN.Clear()
        TextBoxNrTelCCN.Clear()
        ComboBoxSexCCN.SelectedIndex = -1
        TextBoxParolaCCN.Clear()
        ComboBoxTipUtilizatorCCN.SelectedIndex = -1

    End Sub



    'BUTON RESETEAZA
    Private Sub ButtonReseteaza_Click(sender As Object, e As EventArgs) Handles ButtonReseteaza.Click
        Clear()

    End Sub

    Private Sub ButtonAnuleazaCCN_Click(sender As Object, e As EventArgs) Handles ButtonAnuleazaCCN.Click
        Me.Close()
        LogareCont.Show()
    End Sub
End Class