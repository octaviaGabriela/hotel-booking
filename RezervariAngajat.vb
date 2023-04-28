Imports System.Data.SqlClient
Public Class RezervariAngajat


    Dim Con As New SqlConnection("Data Source=DESKTOP-A4RFJNL\SQLSERVEROCT;Initial Catalog=HOTELmanagement;Integrated Security=True")


    Private Sub Populate()
        Con.Open()
        Dim sql = "Select IdRezervare, NumeClient, PrenumeClient, NrTelClient, SexClient, ProvenientaClient, DataInceputRezervare, DataSfarsitRezervare, TipCamera, NrCamera, Realizata, Avans, TotalPlata, RestDePlata  From Rezervare,Client,Camera Where Rezervare.IdClient= Client.IdClient and Rezervare.IdCamera=Camera.IdCamera"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DGVRA.DataSource = ds.Tables(0)
        Con.Close()
    End Sub


    Private Sub Clear()
        LabelNumeRA.Text = ""
        LabelPrenumeRA.Text = ""
        LabelTelefonRA.Text = ""
        LabelSexRA.Text = ""
        LabelProvenientaRA.Text = ""
        LabelTipCameraRA.Text = ""
        LabelNumarCameraRA.Text = ""
        LabelAvansRA.Text = ""
        LabelTotalDePlataRA.Text = ""
        LabelRestDePlataRA.Text = ""
        TextBoxNumeClientCRA.Text = ""
        ComboBoxTipCameraCRA.SelectedIndex = -1
        LabelStatusRezervareRA.Text = ""
        LabelDIRA.Text = ""
        LabelDSRA.Text = ""


    End Sub



    Private Sub RezervariAngajat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub

    'BUTON CAUTA CLIENTI
    Private Sub ButtonCautaCRA_Click(sender As Object, e As EventArgs) Handles ButtonCautaCRA.Click
        If Len(TextBoxNumeClientCRA.Text) <> 0 Then
            'If TextBoxNumeClientCRA.Text <> " " Then
            Dim dt As DataTable
            dt = TryCast(DGVRA.DataSource, DataTable)
            dt.DefaultView.RowFilter = String.Format("NumeClient Like '%{0}%'", TextBoxNumeClientCRA.Text)
        End If
        If TextBox1.Text <> " " Then
            Dim filterDate As DateTime
            If DateTime.TryParse(TextBox1.Text, filterDate) Then
                Dim dv As DataView = TryCast(DGVRA.DataSource, DataTable).DefaultView
                dv.RowFilter = "DataInceputRezervare = #" + filterDate.ToString("yyyy/MM/dd") + "#"
                DGVRA.DataSource = dv
            End If
        End If
        If ComboBoxTipCameraCRA.SelectedIndex <> -1 Then
            Dim dt As DataTable = TryCast(DGVRA.DataSource, DataTable)
            dt.DefaultView.RowFilter = String.Format("Convert(TipCamera, 'System.String') Like '%{0}%'", ComboBoxTipCameraCRA.SelectedItem)
        End If


    End Sub




    'BUTON RESETEAZA
    Private Sub ButtonReseteazaRA_Click(sender As Object, e As EventArgs) Handles ButtonReseteazaRA.Click
        Clear()
    End Sub




    'BUTON ANULEAZA REZERVAREA



    Private Sub ButtonAnuleazaRezRA_Click(sender As Object, e As EventArgs) Handles ButtonAnuleazaRezRA.Click



        If LabelNumeRA.Text = "" And LabelPrenumeRA.Text = "" And LabelTelefonRA.Text = "" And LabelSexRA.Text = "" And LabelProvenientaRA.Text = "" And LabelTipCameraRA.Text = "" And LabelNumarCameraRA.Text = "" And LabelAvansRA.Text = "" And LabelTotalDePlataRA.Text = "" And LabelRestDePlataRA.Text = "" And LabelStatusRezervareRA.Text = "" And LabelDIRA.Text = "" And LabelDSRA.Text = "" Then
            MsgBox("Nu a fost selectată nicio rezervare ")



        Else

            '(1) schimbare status camera in 0
            Con.Open()
            Dim query As String
            query = "Update Camera Set StatusCamera=0 Where TipCamera='" & LabelTipCameraRA.Text & "' and NrCamera='" & LabelNumarCameraRA.Text & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Statusul camerei a fost schimbat în : 0")
            Con.Close()


            '(2) schimbare status rezervare ----- in anulata
            Con.Open()
            Dim query1 As String
            query1 = "Update Rezervare Set Realizata='Anulată' Where IdCamera in (select NrCamera from Camera where NrCamera='" & LabelNumarCameraRA.Text & "')"
            Dim cmd1 As SqlCommand
            cmd1 = New SqlCommand(query1, Con)
            cmd1.ExecuteNonQuery()
            MsgBox("Statusul rezervării a fost schimbat în : Anulată")
            Con.Close()


            Populate()
            Clear()
        End If

    End Sub




    Dim key = 0


    'DISPLAY IN  DGV REZERVARE

    Private Sub DGVRA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVRA.CellContentClick
        Dim row As DataGridViewRow = DGVRA.Rows(e.RowIndex)
        LabelNumeRA.Text = row.Cells(1).Value.ToString
        LabelPrenumeRA.Text = row.Cells(2).Value.ToString
        LabelTelefonRA.Text = row.Cells(3).Value.ToString
        LabelSexRA.Text = row.Cells(4).Value.ToString
        LabelProvenientaRA.Text = row.Cells(5).Value.ToString
        LabelDIRA.Text = row.Cells(6).Value.ToString
        LabelDSRA.Text = row.Cells(7).Value.ToString
        LabelTipCameraRA.Text = row.Cells(8).Value.ToString
        LabelNumarCameraRA.Text = row.Cells(9).Value.ToString
        LabelStatusRezervareRA.Text = row.Cells(10).Value.ToString
        LabelAvansRA.Text = row.Cells(11).Value.ToString
        LabelTotalDePlataRA.Text = row.Cells(12).Value.ToString
        LabelRestDePlataRA.Text = row.Cells(13).Value.ToString
        If LabelNumeRA.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Dim Con1 As New SqlConnection("Data Source=DESKTOP-A4RFJNL\SQLSERVEROCT;Initial Catalog=HOTELmanagement;Integrated Security=True;MultipleActiveResultSets=True")

    Dim Con2 As New SqlConnection("Data Source=DESKTOP-A4RFJNL\SQLSERVEROCT;Initial Catalog=HOTELmanagement;Integrated Security=True")

    Dim Con3 As New SqlConnection("Data Source=DESKTOP-A4RFJNL\SQLSERVEROCT;Initial Catalog=HOTELmanagement;Integrated Security=True;MultipleActiveResultSets=True")

    'BUTON CONFIRMA REZERVAREA

    Private Sub ButtonConfirmaRezRA_Click(sender As Object, e As EventArgs) Handles ButtonConfirmaRezRA.Click
        If LabelNumeRA.Text = "" And LabelPrenumeRA.Text = "" And LabelTelefonRA.Text = "" And LabelSexRA.Text = "" And LabelProvenientaRA.Text = "" And LabelTipCameraRA.Text = "" And LabelNumarCameraRA.Text = "" And LabelAvansRA.Text = "" And LabelTotalDePlataRA.Text = "" And LabelRestDePlataRA.Text = "" And LabelStatusRezervareRA.Text = "" And LabelDIRA.Text = "" And LabelDSRA.Text = "" Then
            MsgBox("Nu a fost selectată nicio rezervare ")

        Else
            If LabelStatusRezervareRA.Text = "Înregistrată" Then

                'verificare daca status rezervare (realizata) e 'inregistrata' 
                If Con1.State = ConnectionState.Closed Then
                    Con1.Open()
                End If

                Dim query4 As String
                query4 = "select* From Rezervare where Realizata='Înregistrată' "
                Dim cmd4 As New SqlCommand("select* From Rezervare where Realizata='Înregistrată' ", Con1)
                Dim dr4 As SqlDataReader
                dr4 = cmd4.ExecuteReader

                If dr4.Read Then


                    If dr4.HasRows Then

                        'SCHIMBARE STATUS CAMERA IN OCUPATA (1) 
                        Con2.Open()
                        Dim query22 As String
                        query22 = "update Camera set StatusCamera=1 where TipCamera='" & LabelTipCameraRA.Text & "' and NrCamera='" & LabelNumarCameraRA.Text & "'"
                        Dim cmd2 As SqlCommand
                        cmd2 = New SqlCommand(query22, Con2)
                        cmd2.ExecuteNonQuery()
                        MsgBox("Statusul camerei a fost schimbat în : 1")
                        Con2.Close()


                        'schimbare status rezervare ----- din inregistrata in confirmata
                        Con.Open()
                        Dim query1 As String
                        query1 = "Update Rezervare Set Realizata='Confirmată' Where Realizata='Înregistrată'and IdCamera in (select NrCamera from Camera where NrCamera='" & LabelNumarCameraRA.Text & "')"
                        Dim cmd1 As SqlCommand
                        cmd1 = New SqlCommand(query1, Con)
                        cmd1.ExecuteNonQuery()
                        MsgBox("Statusul rezervării a fost schimbat în : Confirmată")
                        Con.Close()
                        MsgBox("Rezervarea avea statusul inițial : Înregistrată")
                        Populate()
                        Clear()




                    End If
                End If




            Else




                'verificare daca status rezervare (realizata) e 'anulata'

                If Con3.State = ConnectionState.Closed Then
                    Con3.Open()
                End If

                Dim query33 As String
                query33 = "select* From Rezervare where Anulată' "
                Dim cmd33 As New SqlCommand("select* From Rezervare where Realizata='Anulată' ", Con3)
                Dim dr33 As SqlDataReader
                dr33 = cmd33.ExecuteReader

                If dr33.Read Then


                    If dr33.HasRows Then


                        'schimbare status rezervare ----- din anulata in confirmata


                        '(1) Status camera in ocupata
                        Con.Open()
                        Dim query3 As String
                        query3 = " Update Camera set StatusCamera=1 from Camera inner join Rezervare on Camera.IdCamera = Rezervare.IdCamera where Realizata='Anulată' and NrCamera='" & LabelNumarCameraRA.Text & "'"
                        Dim cmd3 As SqlCommand
                        cmd3 = New SqlCommand(query3, Con)
                        cmd3.ExecuteNonQuery()
                        MsgBox("Statusul camerei a fost schimbat în : 1")
                        Con.Close()




                        '(2) status rezervare
                        Con.Open()
                        Dim query2 As String
                        query2 = "Update Rezervare Set Realizata='Confirmată' Where Realizata='Anulată'and IdCamera in (select NrCamera from Camera where NrCamera='" & LabelNumarCameraRA.Text & "')"
                        Dim cmd2 As SqlCommand
                        cmd2 = New SqlCommand(query2, Con)
                        cmd2.ExecuteNonQuery()
                        MsgBox("Statusul rezervării a fost schimbat în : Confirmată")
                        Con.Close()
                        MsgBox("Rezervarea avea statusul inițial : Anulată")
                        Populate()
                        Clear()

                    End If
                End If
            End If
        End If
    End Sub


    'BUTON STERGE REZERVAREA
    Private Sub ButtonStergeRA_Click(sender As Object, e As EventArgs) Handles ButtonStergeRA.Click
        'schimbare status camera in 0
        Con2.Open()
        Dim query22 As String
        query22 = "update Camera set StatusCamera=0 where TipCamera='" & LabelTipCameraRA.Text & "' and NrCamera='" & LabelNumarCameraRA.Text & "'"
        Dim cmd2 As SqlCommand
        cmd2 = New SqlCommand(query22, Con2)
        cmd2.ExecuteNonQuery()
        MsgBox("Statusul camerei a fost schimbat în : 0")
        Con2.Close()



        'stergere rez
        Dim query As String
        query = "Delete from Rezervare Where IdRezervare = " & key & ""
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If
        cmd.ExecuteNonQuery()
        MsgBox("Rezervarea a fost ștersă")
        Con.Close()
        Populate()


        Clear()
    End Sub

    Private Sub ButtonCORNRAng_Click(sender As Object, e As EventArgs) Handles ButtonCORNRAng.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub ButtonCamereRAng_Click(sender As Object, e As EventArgs) Handles ButtonCamereRAng.Click
        Me.Close()
        CamereAngajat.Show()
    End Sub

    Private Sub ButtonClientiRAng_Click(sender As Object, e As EventArgs) Handles ButtonClientiRAng.Click
        Me.Close()
        ClientiAngajat.Show()
    End Sub

    Private Sub ButtonDelogareRAng_Click(sender As Object, e As EventArgs) Handles ButtonDelogareRAng.Click
        Me.Close()
        LogareCont.Show()
    End Sub


    'buton efectuata
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If LabelNumeRA.Text = "" And LabelPrenumeRA.Text = "" And LabelTelefonRA.Text = "" And LabelSexRA.Text = "" And LabelProvenientaRA.Text = "" And LabelTipCameraRA.Text = "" And LabelNumarCameraRA.Text = "" And LabelAvansRA.Text = "" And LabelTotalDePlataRA.Text = "" And LabelRestDePlataRA.Text = "" And LabelStatusRezervareRA.Text = "" And LabelDIRA.Text = "" And LabelDSRA.Text = "" Then
            MsgBox("Nu a fost selectată nicio rezervare ")



        Else

            '(1) schimbare status camera in 0
            Con.Open()
            Dim query As String
            query = "Update Camera Set StatusCamera=0 Where TipCamera='" & LabelTipCameraRA.Text & "' and NrCamera='" & LabelNumarCameraRA.Text & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Statusul camerei a fost schimbat în : 0")
            Con.Close()


            '(2) schimbare status rezervare ----- in efectuata
            Con.Open()
            Dim query1 As String
            query1 = "Update Rezervare Set Realizata='Efectuată' Where IdCamera in (select NrCamera from Camera where NrCamera='" & LabelNumarCameraRA.Text & "')"
            Dim cmd1 As SqlCommand
            cmd1 = New SqlCommand(query1, Con)
            cmd1.ExecuteNonQuery()
            MsgBox("Statusul rezervării a fost schimbat în : Efectuată")
            Con.Close()


            Populate()
            Clear()
        End If
    End Sub
End Class