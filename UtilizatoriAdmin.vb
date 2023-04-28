Imports System.Data.SqlClient
Public Class Utilizatori
    Dim Con As New SqlConnection("Data Source=DESKTOP-A4RFJNL\SQLSERVEROCT;Initial Catalog=HOTELmanagement;Integrated Security=True")

    'BUTON ADAUGA
    Private Sub ButtonAdaugaUA_Click(sender As Object, e As EventArgs) Handles ButtonAdaugaUA.Click
        If TextBoxNumeUA.Text = "" Or TextBoxPrenumeUA.Text = "" Or TextBoxTelUA.Text = "" Or TextBoxSexUA.Text = "" Or TextBoxParolaUA.Text = "" Or TextBoxTipUA.Text = "" Then
            MsgBox("Un câmp nu a fost completat")
        Else
            Try

                Con.Open()
                Dim query As String
                query = "insert into Utilizator values('" & TextBoxNumeUA.Text & "','" & TextBoxPrenumeUA.Text & "', '" & TextBoxTelUA.Text & "' , '" & TextBoxSexUA.Text & "' ,'" & TextBoxParolaUA.Text & "' , '" & TextBoxTipUA.Text & "' ) "
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Utilizatorul a fost adăugat")
                Con.Close()
                Populate()
                Populate1()
                Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub



    Private Sub Populate()
        Con.Open()
        Dim sql = "Select* From Utilizator where TipUtilizator= 'Angajat'"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DGVAngajati.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub Populate1()
        Con.Open()
        Dim sql = "Select* From Utilizator where TipUtilizator= 'Admin'"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DGVAdmini.DataSource = ds.Tables(0)
        Con.Close()
    End Sub



    Private Sub Utilizatori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
        Populate1()
    End Sub



    Private Sub Clear()
        TextBoxNumeUA.Clear()
        TextBoxPrenumeUA.Clear()
        TextBoxTelUA.Clear()
        TextBoxSexUA.Clear()
        TextBoxParolaUA.Clear()
        TextBoxTipUA.Clear()

    End Sub







    'BUTON RESETEAZA
    Private Sub ButtonReseteazaUA_Click(sender As Object, e As EventArgs) Handles ButtonReseteazaUA.Click
        Clear()
    End Sub




    Dim key = 0


    'BUTON STERGE
    Private Sub ButtonStergeUA_Click(sender As Object, e As EventArgs) Handles ButtonStergeUA.Click
        If key = 0 Then
            MsgBox("Utilizatorul nu există")
        Else
            Try
                Dim query As String
                query = "Delete from Utilizator Where IdUtilizator = " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                If Con.State = ConnectionState.Closed Then
                    Con.Open()
                End If
                cmd.ExecuteNonQuery()
                MsgBox("Utilizatorul a fost șters")
                Con.Close()
                Populate()
                Populate1()

                Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub




    'BUTON MODIFICA
    Private Sub ButtonModificaUA_Click(sender As Object, e As EventArgs) Handles ButtonModificaUA.Click
        If TextBoxNumeUA.Text = "" Or TextBoxPrenumeUA.Text = "" Or TextBoxTelUA.Text = "" Or TextBoxSexUA.Text = "" Or TextBoxParolaUA.Text = "" Or TextBoxTipUA.Text = "" Then
            MsgBox("Un câmp nu a fost completat")
        Else
            Try
                Con.Open()
                Dim query As String
                query = "Update Utilizator Set NumeUtilizator='" & TextBoxNumeUA.Text & "',PrenumeUtilizator='" & TextBoxPrenumeUA.Text & "', NrTelUtilizator='" & TextBoxTelUA.Text & "' ,SexUtilizator= '" & TextBoxSexUA.Text & "' ,ParolaUtilizator='" & TextBoxParolaUA.Text & "' ,TipUtilizator='" & TextBoxTipUA.Text & "' Where IdUtilizator= " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Utilizatorul a fost modificat")
                Con.Close()
                Populate()
                Populate1()
                Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub



    'DISPLAY IN  DGV admini


    Private Sub DGVAngajati_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVAngajati.CellContentClick
        Dim row As DataGridViewRow = DGVAngajati.Rows(e.RowIndex)
        TextBoxNumeUA.Text = row.Cells(1).Value.ToString
        TextBoxPrenumeUA.Text = row.Cells(2).Value.ToString
        TextBoxTelUA.Text = row.Cells(3).Value.ToString
        TextBoxSexUA.Text = row.Cells(4).Value.ToString
        TextBoxParolaUA.Text = row.Cells(5).Value.ToString
        TextBoxTipUA.Text = row.Cells(6).Value.ToString
        If TextBoxNumeUA.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub DGVAdmini_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVAdmini.CellContentClick
        Dim row As DataGridViewRow = DGVAdmini.Rows(e.RowIndex)
        TextBoxNumeUA.Text = row.Cells(1).Value.ToString
        TextBoxPrenumeUA.Text = row.Cells(2).Value.ToString
        TextBoxTelUA.Text = row.Cells(3).Value.ToString
        TextBoxSexUA.Text = row.Cells(4).Value.ToString
        TextBoxParolaUA.Text = row.Cells(5).Value.ToString
        TextBoxTipUA.Text = row.Cells(6).Value.ToString
        If TextBoxNumeUA.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub ButtonCORNUA_Click(sender As Object, e As EventArgs) Handles ButtonCORNUA.Click
        Me.Close()
        CreeazaORezervareNouaAdmin.Show()
    End Sub

    Private Sub ButtonRezervariUA_Click(sender As Object, e As EventArgs) Handles ButtonRezervariUA.Click
        Me.Close()
        FormRezervariAdmin.Show()
    End Sub

    Private Sub ButtonHartaCamereUA_Click(sender As Object, e As EventArgs) Handles ButtonHartaCamereUA.Click
        Me.Close()
        HartaCamerelorAdmin.Show()
    End Sub

    Private Sub ButtonTarifCamereUA_Click(sender As Object, e As EventArgs) Handles ButtonTarifCamereUA.Click
        Me.Close()
        TarifCamereAdmin.Show()
    End Sub

    Private Sub ButtonTarifDinamicUA_Click(sender As Object, e As EventArgs) Handles ButtonTarifDinamicUA.Click
        Me.Close()
        TarifDinamicAdmin.Show()
    End Sub

    Private Sub ButtonClientiUA_Click(sender As Object, e As EventArgs) Handles ButtonClientiUA.Click
        Me.Close()
        ClientiAdmin.Show()
    End Sub

    Private Sub ButtonDelogareUA_Click(sender As Object, e As EventArgs) Handles ButtonDelogareUA.Click
        Me.Close()
        LogareCont.Show()
    End Sub
End Class