Imports System.Data.SqlClient
Public Class ClientiAngajat
    Dim Con As New SqlConnection("Data Source=DESKTOP-A4RFJNL\SQLSERVEROCT;Initial Catalog=HOTELmanagement;Integrated Security=True")


    'BUTON ADAUGA
    Private Sub ButtonAdaugaClAng_Click(sender As Object, e As EventArgs) Handles ButtonAdaugaClAng.Click
        If TextBoxNumeClAng.Text = "" Or TextBoxPrenumeClAng.Text = "" Or TextBoxTelClAng.Text = "" Or TextBoxSexClAng.Text = "" Or TextBoxProvenientaClAng.Text = "" Then
            MsgBox("Un câmp nu a fost completat")
        Else
            Try

                If Con.State = ConnectionState.Closed Then
                    Con.Open()
                End If
                Dim query As String
                query = "insert into Client values('" & TextBoxNumeClAng.Text & "','" & TextBoxPrenumeClAng.Text & "', '" & TextBoxTelClAng.Text & "' , '" & TextBoxSexClAng.Text & "' ,'" & TextBoxProvenientaClAng.Text & "'  ) "
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
        DGVClientiAng.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub ClientiAngajat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub



    Private Sub Clear()
        TextBoxNumeClAng.Clear()
        TextBoxPrenumeClAng.Clear()
        TextBoxTelClAng.Clear()
        TextBoxSexClAng.Clear()
        TextBoxProvenientaClAng.Clear()

    End Sub


    'BUTON RESETEAZA
    Private Sub ButtonReseteazaClAng_Click(sender As Object, e As EventArgs) Handles ButtonReseteazaClAng.Click
        Clear()
    End Sub





    Dim key = 0


    'BUTON STERGE


    Private Sub ButtonStergeClAng_Click(sender As Object, e As EventArgs) Handles ButtonStergeClAng.Click
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

    Private Sub ButtonModificaClAng_Click(sender As Object, e As EventArgs) Handles ButtonModificaClAng.Click
        If TextBoxNumeClAng.Text = "" Or TextBoxPrenumeClAng.Text = "" Or TextBoxTelClAng.Text = "" Or TextBoxSexClAng.Text = "" Or TextBoxProvenientaClAng.Text = "" Then
            MsgBox("Un câmp nu a fost completat")
        Else
            Try
                Con.Open()
                Dim query As String
                query = "Update Client Set NumeClient='" & TextBoxNumeClAng.Text & "',PrenumeClient='" & TextBoxPrenumeClAng.Text & "', NrTelClient='" & TextBoxTelClAng.Text & "' ,SexClient= '" & TextBoxSexClAng.Text & "' ,ProvenientaClient='" & TextBoxProvenientaClAng.Text & "'  Where IdClient= " & key & ""
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


    'DISPLAY IN  DGV admini


    Private Sub DGVClientiAng_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVClientiAng.CellContentClick
        Dim row As DataGridViewRow = DGVClientiAng.Rows(e.RowIndex)
        TextBoxNumeClAng.Text = row.Cells(1).Value.ToString
        TextBoxPrenumeClAng.Text = row.Cells(2).Value.ToString
        TextBoxTelClAng.Text = row.Cells(3).Value.ToString
        TextBoxSexClAng.Text = row.Cells(4).Value.ToString
        TextBoxProvenientaClAng.Text = row.Cells(5).Value.ToString
        If TextBoxNumeClAng.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub


    'BUTON CAUTA CLIENTI

    Private Sub ButtonCautaClA_Click(sender As Object, e As EventArgs) Handles ButtonCautaClAng.Click
        If TextBoxCautaNumeClientiClAng.Text <> "" Then
            TryCast(DGVClientiAng.DataSource, DataTable).DefaultView.RowFilter =
        String.Format("NumeClient Like '%" & TextBoxCautaNumeClientiClAng.Text & "%'")
        Else
            TryCast(DGVClientiAng.DataSource, DataTable).DefaultView.RowFilter =
            String.Format("PrenumeClient Like '%" & TextBoxCautaPrenumeClientiClAng.Text & "%'")
        End If

    End Sub

    Private Sub ButtonCORNRClAng_Click(sender As Object, e As EventArgs) Handles ButtonCORNRClAng.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub ButtonRezervariClAng_Click(sender As Object, e As EventArgs) Handles ButtonRezervariClAng.Click
        Me.Close()
        RezervariAngajat.Show()
    End Sub

    Private Sub ButtonCamereClAng_Click(sender As Object, e As EventArgs) Handles ButtonCamereClAng.Click
        Me.Close()
        CamereAngajat.Show()
    End Sub

    Private Sub ButtonDelogareClAng_Click(sender As Object, e As EventArgs) Handles ButtonDelogareClAng.Click
        Me.Close()
        LogareCont.Show()
    End Sub
End Class
