Imports System.Data.SqlClient
Public Class TarifDinamicAdmin
    Dim Con As New SqlConnection("Data Source=DESKTOP-A4RFJNL\SQLSERVEROCT;Initial Catalog=HOTELmanagement;Integrated Security=True")


    'BUTON ARATA (EXPONENT + DATI EXPONRNT) TARIF DINAMIC CURENT
    Private Sub ButtonArataEA_Click(sender As Object, e As EventArgs) Handles ButtonArataEA.Click
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If
        Dim cmd As New SqlCommand("select* from TarifSezon Where DataInceputTarifSezon<=GETDATE() And GETDATE()>= DataInceputTarifSezon And DataSfarsitTarifSezon>=GETDATE() And GETDATE()<= DataSfarsitTarifSezon

 ", Con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            LabelDataInceput.Text = dr("DataInceputTarifSezon")
            LabelDtataSTarifSezTDA.Text = dr("DataSfarsitTarifSezon")
            LabelExponentTDA.Text = dr("Exponent")
        End If
        Con.Close()


    End Sub





    Private Sub TarifDinamicAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub


    'BUTON ADAUGA TARIF
    Private Sub ButtonAdaugaTDA_Click(sender As Object, e As EventArgs) Handles ButtonAdaugaTDA.Click
        If DateTimePickerEditDataITDA.Text = "" Or DateTimePickerEditDataSTDA.Text = "" Or TextBoxExponentETDA.Text = "" Then
            MsgBox("Un câmp nu a fost completat")
        Else
            Try


                If Con.State = ConnectionState.Closed Then
                    Con.Open()
                End If
                Dim query As String
                query = "insert into TarifSezon values('" & DateTimePickerEditDataITDA.Text & "','" & DateTimePickerEditDataSTDA.Text & "', '" & TextBoxExponentETDA.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Tariful dinamic a fost adăugat")
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
        Dim sql = "Select* From TarifSezon"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DGVTarifDinamicA.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub Clear()
        TextBoxExponentETDA.Clear()
    End Sub

    'BUTON RESETEAZA
    Private Sub ButtonReseteazaTDA_Click(sender As Object, e As EventArgs) Handles ButtonReseteazaTDA.Click
        Clear()
    End Sub

    Dim key = 0


    'BUTON STERGE
    Private Sub ButtonStergeTDA_Click(sender As Object, e As EventArgs) Handles ButtonStergeTDA.Click
        If key = 0 Then
            MsgBox("Tariful dinamic nu există")
        Else
            Try
                Dim query As String
                query = "Delete From TarifSezon Where IdTarif = " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                If Con.State = ConnectionState.Closed Then
                    Con.Open()
                End If
                cmd.ExecuteNonQuery()
                MsgBox("Tariful dinamic a fost șters")
                Con.Close()
                Populate()


                Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub


    'BUTON MODIFICA TARIF DINAMIC
    Private Sub ButtonModificaTDA_Click(sender As Object, e As EventArgs) Handles ButtonModificaTDA.Click
        If DateTimePickerEditDataITDA.Text = "" Or DateTimePickerEditDataSTDA.Text = "" Or TextBoxExponentETDA.Text = "" Then
            MsgBox("Un câmp nu a fost completat")
        Else
            Try
                Con.Open()
                Dim query As String
                query = "Update TarifSezon Set DataInceputTarifSezon='" & DateTimePickerEditDataITDA.Text & "',DataSfarsitTarifSezon='" & DateTimePickerEditDataSTDA.Text & "', Exponent='" & TextBoxExponentETDA.Text & "' Where IdTarif= " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Tariful Dinamic a fost modificat")
                Con.Close()
                Populate()

                Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub



    'DISPLAY IN  DGV admini
    Private Sub DGVTarifDinamicA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVTarifDinamicA.CellContentClick
        Dim row As DataGridViewRow = DGVTarifDinamicA.Rows(e.RowIndex)
        DateTimePickerEditDataITDA.Text = row.Cells(1).Value.ToString
        DateTimePickerEditDataSTDA.Text = row.Cells(2).Value.ToString
        TextBoxExponentETDA.Text = row.Cells(3).Value.ToString

        If DateTimePickerEditDataITDA.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub ButtonUtilizatoriTDA_Click(sender As Object, e As EventArgs) Handles ButtonUtilizatoriTDA.Click
        Me.Close()
        Utilizatori.Show()
    End Sub

    Private Sub ButtonHartaCamereTDA_Click(sender As Object, e As EventArgs) Handles ButtonHartaCamereTDA.Click
        Me.Close()
        HartaCamerelorAdmin.Show()
    End Sub

    Private Sub ButtonCORNTDA_Click(sender As Object, e As EventArgs) Handles ButtonCORNTDA.Click
        Me.Close()
        CreeazaORezervareNouaAdmin.Show()
    End Sub

    Private Sub ButtonRezervariTDA_Click(sender As Object, e As EventArgs) Handles ButtonRezervariTDA.Click
        Me.Close()
        FormRezervariAdmin.Show()
    End Sub

    Private Sub ButtonTarifCamereTDA_Click(sender As Object, e As EventArgs) Handles ButtonTarifCamereTDA.Click
        Me.Close()
        TarifCamereAdmin.Show()
    End Sub

    Private Sub ButtonClientiTDA_Click(sender As Object, e As EventArgs) Handles ButtonClientiTDA.Click
        Me.Close()
        ClientiAdmin.Show()
    End Sub

    Private Sub ButtonDelogareTDA_Click(sender As Object, e As EventArgs) Handles ButtonDelogareTDA.Click
        Me.Close()
        LogareCont.Show()
    End Sub
End Class