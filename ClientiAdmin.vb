Imports System.Data.SqlClient
Public Class ClientiAdmin
    Dim Con As New SqlConnection("Data Source=DESKTOP-A4RFJNL\SQLSERVEROCT;Initial Catalog=HOTELmanagement;Integrated Security=True")


    'BUTON ADAUGA
    Private Sub ButtonAdaugaCA_Click(sender As Object, e As EventArgs) Handles ButtonAdaugaCA.Click
        If TextBoxNumeCA.Text = "" Or TextBoxPrenumeCA.Text = "" Or TextBoxTelCA.Text = "" Or TextBoxSexCA.Text = "" Or TextBoxProvenientaCA.Text = "" Then
            MsgBox("Un câmp nu a fost completat")
        Else
            Try

                If Con.State = ConnectionState.Closed Then
                    Con.Open()
                End If
                Dim query As String
                query = "insert into Client values('" & TextBoxNumeCA.Text & "','" & TextBoxPrenumeCA.Text & "', '" & TextBoxTelCA.Text & "' , '" & TextBoxSexCA.Text & "' ,'" & TextBoxProvenientaCA.Text & "'  ) "
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Clientul a fost adăugat")
                Con.Close()
                Populate()

                Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub



    Private Sub Populate()
        Con.Open()
        Dim sql = "Select* From Client"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DGVClientiA.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub ClientiAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub



    Private Sub Clear()
        TextBoxNumeCA.Clear()
        TextBoxPrenumeCA.Clear()
        TextBoxTelCA.Clear()
        TextBoxSexCA.Clear()
        TextBoxProvenientaCA.Clear()

    End Sub


    'BUTON RESETEAZA
    Private Sub ButtonReseteazaCA_Click(sender As Object, e As EventArgs) Handles ButtonReseteazaCA.Click
        Clear()
    End Sub





    Dim key = 0


    'BUTON STERGE


    Private Sub ButtonStergeCA_Click(sender As Object, e As EventArgs) Handles ButtonStergeCA.Click
        If key = 0 Then
            MsgBox("Clientul nu există")
        Else
            Try
                Dim query As String
                query = "Delete From Client Where IdClient = " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                If Con.State = ConnectionState.Closed Then
                    Con.Open()
                End If
                cmd.ExecuteNonQuery()
                MsgBox("Clientul a fost șters")
                Con.Close()
                Populate()


                Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub



    'BUTON MODIFICA

    Private Sub ButtonModificaCA_Click(sender As Object, e As EventArgs) Handles ButtonModificaCA.Click
        If TextBoxNumeCA.Text = "" Or TextBoxPrenumeCA.Text = "" Or TextBoxTelCA.Text = "" Or TextBoxSexCA.Text = "" Or TextBoxProvenientaCA.Text = "" Then
            MsgBox("Un câmp nu a fost completat")
        Else
            Try
                Con.Open()
                Dim query As String
                query = "Update Client Set NumeClient='" & TextBoxNumeCA.Text & "',PrenumeClient='" & TextBoxPrenumeCA.Text & "', NrTelClient='" & TextBoxTelCA.Text & "' ,SexClient= '" & TextBoxSexCA.Text & "' ,ProvenientaClient='" & TextBoxProvenientaCA.Text & "'  Where IdClient= " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Clientul a fost modificat")
                Con.Close()
                Populate()

                Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    'DISPLAY IN  DGV CLIENTI


    Private Sub DGVClientiA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVClientiA.CellContentClick
        Dim row As DataGridViewRow = DGVClientiA.Rows(e.RowIndex)
        TextBoxNumeCA.Text = row.Cells(1).Value.ToString
        TextBoxPrenumeCA.Text = row.Cells(2).Value.ToString
        TextBoxTelCA.Text = row.Cells(3).Value.ToString
        TextBoxSexCA.Text = row.Cells(4).Value.ToString
        TextBoxProvenientaCA.Text = row.Cells(5).Value.ToString
        If TextBoxNumeCA.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub


    'BUTON CAUTA CLIENTI

    Private Sub ButtonCautaClA_Click(sender As Object, e As EventArgs) Handles ButtonCautaClA.Click
        If TextBoxCautaNumeClientiClA.Text <> "" Then
            TryCast(DGVClientiA.DataSource, DataTable).DefaultView.RowFilter =
        String.Format("NumeClient Like '%" & TextBoxCautaNumeClientiClA.Text & "%'")
        Else
            TryCast(DGVClientiA.DataSource, DataTable).DefaultView.RowFilter =
            String.Format("PrenumeClient Like '%" & TextBoxCautaPrenumeClientiClA.Text & "%'")
        End If

    End Sub

    Private Sub ButtonUtilizatoriCA_Click(sender As Object, e As EventArgs) Handles ButtonUtilizatoriCA.Click
        Me.Close()
        Utilizatori.Show()
    End Sub

    Private Sub ButtonHartaCamereCA_Click(sender As Object, e As EventArgs) Handles ButtonHartaCamereCA.Click
        Me.Close()
        HartaCamerelorAdmin.Show()
    End Sub

    Private Sub ButtonCORNCA_Click(sender As Object, e As EventArgs) Handles ButtonCORNCA.Click
        Me.Close()
        CreeazaORezervareNouaAdmin.Show()
    End Sub

    Private Sub ButtonRezervareCA_Click(sender As Object, e As EventArgs) Handles ButtonRezervareCA.Click
        Me.Close()
        FormRezervariAdmin.Show()
    End Sub

    Private Sub ButtonTarifCamereCA_Click(sender As Object, e As EventArgs) Handles ButtonTarifCamereCA.Click
        Me.Close()
        TarifCamereAdmin.Show()
    End Sub

    Private Sub ButtonTarifDinamicCA_Click(sender As Object, e As EventArgs) Handles ButtonTarifDinamicCA.Click
        Me.Close()
        TarifDinamicAdmin.Show()
    End Sub

    Private Sub ButtonDelogareCA_Click(sender As Object, e As EventArgs) Handles ButtonDelogareCA.Click
        Me.Close()
        LogareCont.Show()
    End Sub
End Class