Imports System.Data.SqlClient
Public Class LogareCont
    Dim Con As New SqlConnection("Data Source=DESKTOP-A4RFJNL\SQLSERVEROCT;Initial Catalog=HOTELmanagement;Integrated Security=True")


    Private Sub ButtonAccesare_Click(sender As Object, e As EventArgs) Handles ButtonAccesare.Click
        If TextBoxNumeLogare.Text = "" Or TextBoxPrenumeLogare.Text = "" Or TextBoxParolaLogare.Text = "" Then
            MsgBox("Un câmp nu a fost completat")
        Else
            Try

                If Con.State = ConnectionState.Closed Then
                    Con.Open()
                End If
                Dim cmd As New SqlCommand("select * from Utilizator where NumeUtilizator='" & TextBoxNumeLogare.Text & "' and PrenumeUtilizator='" & TextBoxPrenumeLogare.Text & "'and ParolaUtilizator='" & TextBoxParolaLogare.Text & "'", Con)
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader
                If dr.Read = True Then

                End If
                Con.Close()

                Con.Open()
                Dim ad As New SqlDataAdapter("select * from Utilizator where NumeUtilizator='" & TextBoxNumeLogare.Text & "' and PrenumeUtilizator='" & TextBoxPrenumeLogare.Text & "'and ParolaUtilizator='" & TextBoxParolaLogare.Text & "'", Con)
                Dim ds As New DataSet
                ds.Clear()
                ad.Fill(ds)

                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(0)(5).ToString.Trim = TextBoxParolaLogare.Text Then
                        If ds.Tables(0).Rows(0)(6).ToString.Trim = "Admin" Then
                            MsgBox("Cont admin")
                            TextBoxNumeLogare.Text = ""
                            TextBoxPrenumeLogare.Text = ""
                            TextBoxParolaLogare.Text = ""
                            Me.Close()
                            Utilizatori.Show()
                        Else

                            MsgBox("Cont angajat")
                            TextBoxNumeLogare.Text = ""
                            TextBoxPrenumeLogare.Text = ""
                            TextBoxParolaLogare.Text = ""
                            Me.Close()
                            Form1.Show()
                        End If

                    Else
                        MsgBox("Cont inexistent")
                        TextBoxNumeLogare.Text = ""
                        TextBoxPrenumeLogare.Text = ""
                        TextBoxParolaLogare.Text = ""
                    End If
                Else
                    MsgBox("Cont inexistent")
                    TextBoxNumeLogare.Text = ""
                    TextBoxPrenumeLogare.Text = ""
                    TextBoxParolaLogare.Text = ""
                End If

                    Con.Close()




            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    'AFISARE PAROLA **********
    Private Sub CheckBoxParolaVizibila_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxParolaVizibila.CheckedChanged
        If CheckBoxParolaVizibila.Checked = True Then
            TextBoxParolaLogare.UseSystemPasswordChar = False
        Else
            TextBoxParolaLogare.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub ButtonCreareContNou_Click(sender As Object, e As EventArgs) Handles ButtonCreareContNou.Click
        Me.Close()
        CreareContNou.Show()
    End Sub
End Class
