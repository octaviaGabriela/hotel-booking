Imports System.Data.SqlClient

Public Class HartaCamerelorAdmin

    Private Sub Buttonactualizeaza_Click(sender As Object, e As EventArgs) Handles ButtonActualizeaza.Click
        Dim Con As New SqlConnection("Data Source=DESKTOP-A4RFJNL\SQLSERVEROCT;Initial Catalog=HOTELmanagement;Integrated Security=True")


        Try

            Con.Open()

            Dim query As String
            query = "select NrCamera from Camera where StatusCamera=1"
            Dim reader As SqlDataReader
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Am executat camerele ")
            reader = cmd.ExecuteReader()
            While reader.Read()
                System.Diagnostics.Debug.WriteLine(String.Format("{0}", reader(0)))

                Dim numeButon As String = "Button"
                Dim readerStr As String = CStr(reader(0))
                numeButon = numeButon + readerStr + "HC"
                System.Diagnostics.Debug.WriteLine(numeButon)
                Controls(numeButon).BackColor = Color.Gray

            End While
            Con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub ButtonUtilizatoriHCA_Click(sender As Object, e As EventArgs) Handles ButtonUtilizatoriHCA.Click
        Me.Close()
        Utilizatori.Show()
    End Sub

    Private Sub ButtonCORNHCA_Click(sender As Object, e As EventArgs) Handles ButtonCORNHCA.Click
        Me.Close()
        CreeazaORezervareNouaAdmin.Show()
    End Sub

    Private Sub ButtonRezervariHCA_Click(sender As Object, e As EventArgs) Handles ButtonRezervariHCA.Click
        Me.Close()
        FormRezervariAdmin.Show()
    End Sub

    Private Sub ButtonTarifCamereHCA_Click(sender As Object, e As EventArgs) Handles ButtonTarifCamereHCA.Click
        Me.Close()
        TarifCamereAdmin.Show()
    End Sub

    Private Sub ButtonTarifDinamicHCA_Click(sender As Object, e As EventArgs) Handles ButtonTarifDinamicHCA.Click
        Me.Close()
        TarifDinamicAdmin.Show()
    End Sub

    Private Sub ButtonClientiHCA_Click(sender As Object, e As EventArgs) Handles ButtonClientiHCA.Click
        Me.Close()
        ClientiAdmin.Show()
    End Sub

    Private Sub ButtonDelogareHCA_Click(sender As Object, e As EventArgs) Handles ButtonDelogareHCA.Click
        Me.Close()
        LogareCont.Show()
    End Sub
End Class