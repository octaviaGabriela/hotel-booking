Imports System.Data.SqlClient
Public Class CreeazaORezervareNouaAdmin
    Dim Con As New SqlConnection("Data Source=DESKTOP-A4RFJNL\SQLSERVEROCT;Initial Catalog=HOTELmanagement;Integrated Security=True")
    Dim Con4 As New SqlConnection("Data Source=DESKTOP-A4RFJNL\SQLSERVEROCT;Initial Catalog=HOTELmanagement;Integrated Security=True")



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
        DGVCORNA.DataSource = ds.Tables(0)
        Con.Close()
    End Sub


    Private Sub Clear()
        TextBoxNumeCORNA.Text = ""
        TextBoxPrenumeCORNA.Text = ""
        TextBoxTelCORNA.Text = ""
        TextBoxSexCORNA.Text = ""
        TextBoxProvenientaCORNA.Text = ""
        ComboBoxTipCameraCORNA.SelectedIndex = -1
        ComboBoxNrCameraCORNA.SelectedIndex = -1
        TextBoxAvansCORNA.Text = ""
        LabelTotalDePlataRezervareNouaRA.Text = ""
        LabelRestDePlataRezervareNouaRA.Text = ""
        TextBoxCautaNumeClientiCORNA.Text = ""
        TextBoxCautaPrenumeClientiCORNA.Text = ""


    End Sub

    Private Sub CreeazaORezervareNouaAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
        FillNrCamera()
        FillTipCamera()
    End Sub


    Dim key = 0


    'DISPLAY IN  DGV CLIENTI

    Private Sub DGVCORNA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCORNA.CellContentClick
        Dim row As DataGridViewRow = DGVCORNA.Rows(e.RowIndex)
        TextBoxNumeCORNA.Text = row.Cells(1).Value.ToString
        TextBoxPrenumeCORNA.Text = row.Cells(2).Value.ToString
        TextBoxTelCORNA.Text = row.Cells(3).Value.ToString
        TextBoxSexCORNA.Text = row.Cells(4).Value.ToString
        TextBoxProvenientaCORNA.Text = row.Cells(5).Value.ToString
        If TextBoxNumeCORNA.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub


    'BUTON CAUTA CLIENTI
    Private Sub ButtonCautaCORNA_Click(sender As Object, e As EventArgs) Handles ButtonCautaCORNA.Click
        If TextBoxCautaNumeClientiCORNA.Text <> "" Then
            TryCast(DGVCORNA.DataSource, DataTable).DefaultView.RowFilter =
        String.Format("NumeClient Like '%" & TextBoxCautaNumeClientiCORNA.Text & "%'")
        Else
            TryCast(DGVCORNA.DataSource, DataTable).DefaultView.RowFilter =
            String.Format("PrenumeClient Like '%" & TextBoxCautaPrenumeClientiCORNA.Text & "%'")
        End If
    End Sub

    'COMBOBOX TIP CAMERA
    Private Sub FillTipCamera()
        Con.Open()
        Dim cmd As New SqlCommand("Select top 3 TipCamera From Camera group by TipCamera", Con)
        Dim ad As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        ad.Fill(tbl)
        ComboBoxTipCameraCORNA.DataSource = tbl
        ComboBoxTipCameraCORNA.DisplayMember = "TipCamera"
        ComboBoxTipCameraCORNA.ValueMember = "TipCamera"
        Con.Close()
    End Sub


    'COMBOBOX NR CAMERA 
    Private Sub FillNrCamera()
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If
        Dim cmd As New SqlCommand("Select NrCamera From Camera Where TipCamera='" & ComboBoxTipCameraCORNA.SelectedValue & "' and StatusCamera = 0 ", Con)
        Dim ad As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        ad.Fill(tbl)
        ComboBoxNrCameraCORNA.DataSource = tbl
        ComboBoxNrCameraCORNA.DisplayMember = "NrCamera"
        ComboBoxNrCameraCORNA.ValueMember = "NrCamera"
        Con.Close()

    End Sub



    'COMBOBOX TIP CAMERA - COMBOBOX NR CAMERA 

    Private Sub ComboBoxTipCameraCaAng_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBoxTipCameraCORNA.SelectionChangeCommitted
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If
        Dim x As String
        x = "Select NrCamera From Camera Where TipCamera=" & ComboBoxTipCameraCORNA.SelectedValue.ToString & "  And IdCamera Not in (select IdCamera from Rezervare where 
                                                                      ((( '" & DateTimePickerDataICORNA.Text & "'<= DataInceputRezervare and DataInceputRezervare <='" & DateTimePickerDataSCORNA.Text & "' )
                                                                     Or( '" & DateTimePickerDataICORNA.Text & "'<= DataSfarsitRezervare and DataSfarsitRezervare <='" & DateTimePickerDataSCORNA.Text & "' )
                                                                     Or( '" & DateTimePickerDataICORNA.Text & "'>= DataInceputRezervare and '" & DateTimePickerDataSCORNA.Text & "'<= DataSfarsitRezervare )
                                                                     Or ('" & DateTimePickerDataICORNA.Text & "'= DataInceputRezervare and '" & DateTimePickerDataSCORNA.Text & "'= DataSfarsitRezervare)) 
																	 And ( Realizata='Confirmată' or Realizata='Înregistrată'))) "

        System.Diagnostics.Debug.WriteLine(x)

        Dim cmd As New SqlCommand(x, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()

        adapter.Fill(table)
        ComboBoxNrCameraCORNA.DataSource = table


        Con.Close()

    End Sub




    'BUTON REZETEAZA

    Private Sub ButtonReseteazaCORNA_Click(sender As Object, e As EventArgs) Handles ButtonReseteazaCORNA.Click
        Clear()
    End Sub





    'AVANS SI PLATA
    Private Sub TextBoxAvansCORNA_TextChanged(sender As Object, e As EventArgs) Handles TextBoxAvansCORNA.TextChanged
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If
        If Con4.State = ConnectionState.Closed Then
            Con4.Open()
        End If


        If DateTimePickerDataICORNA.Text IsNot "" And DateTimePickerDataSCORNA.Text IsNot "" Then
            Dim sumaTotala As Single = 0
            Dim tipCamera As Integer = ComboBoxTipCameraCORNA.SelectedValue
            Dim query As String = "select top 1 TarifCameraNoapte from Camera where TipCamera = @TipCamera"


            Using cmd As New SqlCommand(query, Con)
                cmd.Parameters.Add("@TipCamera", SqlDbType.Int).Value = tipCamera

                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim pretCamera As Single = reader.GetValue(0)
                    Dim startDate As Date = DateTimePickerDataICORNA.Value
                    Dim endDate As Date = DateTimePickerDataSCORNA.Value


                    Dim numDays As Integer = CInt((endDate - startDate).TotalDays)
                    Dim nopti As Integer = 0

                    Using command As New SqlCommand("SELECT * FROM TarifSezon", Con4)
                        Dim reader1 As SqlDataReader = command.ExecuteReader()


                        While reader1.Read()

                            Dim inceput As Date = reader1.GetDateTime(1)
                            Dim sfarsit As Date = reader1.GetDateTime(2)
                            Dim exponent As Single = reader1.GetValue(3)




                            For i As Integer = 0 To (numDays - 1)
                                Dim d As Date = startDate.AddDays(i)



                                If d >= inceput And d <= sfarsit Then
                                    nopti = nopti + 1
                                    sumaTotala = sumaTotala + pretCamera * exponent
                                    Console.WriteLine("AM intrat")
                                    LabelTotalDePlataRezervareNouaRA.Text = sumaTotala.ToString
                                End If

                            Next



                        End While
                        Console.WriteLine(numDays - nopti)
                        If numDays - nopti <> 0 Then
                            sumaTotala = sumaTotala + pretCamera * (numDays - nopti)
                            LabelTotalDePlataRezervareNouaRA.Text = sumaTotala.ToString
                        End If
                        If LabelRestDePlataRezervareNouaRA.Text Is "" Or LabelRestDePlataRezervareNouaRA.Text IsNot "" Then
                            LabelRestDePlataRezervareNouaRA.Text = LabelTotalDePlataRezervareNouaRA.Text - TextBoxAvansCORNA.Text
                        End If
                    End Using


                End While
            End Using

            Con.Close()
            Con4.Close()


        End If



        Con.Close()





    End Sub

    Dim Con1 As New SqlConnection("Data Source=DESKTOP-A4RFJNL\SQLSERVEROCT;Initial Catalog=HOTELmanagement;Integrated Security=True")
    Dim Con2 As New SqlConnection("Data Source=DESKTOP-A4RFJNL\SQLSERVEROCT;Initial Catalog=HOTELmanagement;Integrated Security=True")
    Dim Con3 As New SqlConnection("Data Source=DESKTOP-A4RFJNL\SQLSERVEROCT;Initial Catalog=HOTELmanagement;Integrated Security=True;MultipleActiveResultSets=True")


    'BUTON ADAUGA REZERVARE

    Private Sub ButtonAdaugaCORNA_Click(sender As Object, e As EventArgs) Handles ButtonAdaugaCORNA.Click

        Dim idClient As Integer
        Dim idCamera As Integer

        If TextBoxNumeCORNA.Text = "" Or TextBoxPrenumeCORNA.Text = "" Or TextBoxTelCORNA.Text = "" Or TextBoxSexCORNA.Text = "" Or TextBoxProvenientaCORNA.Text = "" Or ComboBoxTipCameraCORNA.SelectedIndex = -1 Or ComboBoxNrCameraCORNA.SelectedIndex = -1 Or TextBoxAvansCORNA.Text = "" Then
            MsgBox("un câmp nu a fost completat")
        Else


            'ADAUGARE IN TABEL CLIENT -> DOAR CLIENTII NOI si obtinere idClient

            'client vechi

            Con3.Open()
            Dim query3 As String
            query3 = "select IdClient From Client where NrTelClient = '" & TextBoxTelCORNA.Text & "'"
            Dim cmd3 As New SqlCommand("select IdClient From Client where NrTelClient = '" & TextBoxTelCORNA.Text & "'", Con3)
            Dim dr3 As SqlDataReader
            dr3 = cmd3.ExecuteReader
            If dr3.Read Then
                If dr3.HasRows Then
                    MsgBox("A fost creată o rezervare nouă pentru un client vechi")
                End If
            Else
                'client nou

                Dim q3 As String
                q3 = "insert into Client values( '" & TextBoxNumeCORNA.Text & "' ,'" & TextBoxPrenumeCORNA.Text & "' , '" & TextBoxTelCORNA.Text & "' , '" & TextBoxSexCORNA.Text & "',  '" & TextBoxProvenientaCORNA.Text & "' ) "
                Dim c3 As SqlCommand
                c3 = New SqlCommand(q3, Con3)
                c3.ExecuteNonQuery()
                MsgBox("A fost creată o rezervare nouă pentru un client nou")
            End If

            Con3.Close()




            'obt id client nou

            Con3.Open()
            Dim qy3 As String
            qy3 = "select IdClient from dbo.Client where NrTelClient = '" & TextBoxTelCORNA.Text & "'"

            Dim cd3 As New SqlCommand("select IdClient from dbo.Client where NrTelClient = '" & TextBoxTelCORNA.Text & "'", Con3)
            Dim sdr3 As SqlDataReader
            sdr3 = cd3.ExecuteReader
            If sdr3.Read Then
                idClient = sdr3("IdClient")
            End If
            Con3.Close()



            'SCHIMBARE STATUS CAMERA IN OCUPATA (1) si obtinere idCamera

            'status camera ocupata
            'Con2.Open()
            'Dim query2 As String
            'query2 = "Update Camera Set StatusCamera=1 Where TipCamera='" & ComboBoxTipCameraCORNA.SelectedValue.ToString & "' and NrCamera='" & ComboBoxNrCameraCORNA.SelectedValue.ToString & "'"
            'Dim cmd2 As SqlCommand
            'cmd2 = New SqlCommand(query2, Con2)
            'cmd2.ExecuteNonQuery()
            'MsgBox("Statusul camerei a fost schimbat în : 1")
            'Con2.Close()



            'obtinere idCamera
            Con2.Open()
            Dim qy2 As String
            qy2 = "select IdCamera From Camera Where TipCamera='" & ComboBoxTipCameraCORNA.SelectedValue.ToString & "' and NrCamera='" & ComboBoxNrCameraCORNA.SelectedValue.ToString & "'"

            Dim cd2 As New SqlCommand("select IdCamera From Camera Where TipCamera='" & ComboBoxTipCameraCORNA.SelectedValue.ToString & "' and NrCamera='" & ComboBoxNrCameraCORNA.SelectedValue.ToString & "'", Con2)
            Dim sdr2 As SqlDataReader
            sdr2 = cd2.ExecuteReader
            If sdr2.Read Then
                idCamera = sdr2("IdCamera")
            End If
            Con2.Close()










            'INSERT IN REZERVARE
            Con1.Open()
            Dim query1 As String
            query1 = "insert into Rezervare values( " & idClient & " ," & idCamera & " , '" & DateTimePickerDataICORNA.Text & "' ,'" & DateTimePickerDataSCORNA.Text & "' ,'Înregistrată', " & TextBoxAvansCORNA.Text & ",  " & LabelTotalDePlataRezervareNouaRA.Text & ",  " & LabelRestDePlataRezervareNouaRA.Text & " ) "
            Dim cmd1 As SqlCommand
            cmd1 = New SqlCommand(query1, Con1)
            cmd1.ExecuteNonQuery()
            MsgBox("rezervarea a fost înregistrată")
            Con1.Close()






            'SCHIMBARE STATUS CAMERA IN OCUPATA (1) si obtinere idCamera








            'SCHIMBARE STATUS Rezervare IN---- EFECTUATA 


            'Con2.Open()
            'Dim query21 As String
            'query21 = "Update Rezervare Set Realizata='Efectuată' Where IdCamera in (select NrCamera from Camera where NrCamera='" & ComboBoxNrCameraCORNA.SelectedValue & "')"
            'Dim cmd21 As SqlCommand
            'cmd21 = New SqlCommand(query21, Con2)
            'cmd21.ExecuteNonQuery()
            'MsgBox("Statusul rezervării a fost schimbat în : Efectuată")
            'Con2.Close()





            'ADAUGARE IN TABEL CLIENT -> DOAR CLIENTII NOI si obtinere idClient


        End If


        Populate()
        Clear()

    End Sub

    Private Sub ButtonUtilizatoriCORNA_Click(sender As Object, e As EventArgs) Handles ButtonUtilizatoriCORNA.Click
        Me.Close()
        Utilizatori.Show()
    End Sub

    Private Sub ButtonHartaCamereCORNA_Click(sender As Object, e As EventArgs) Handles ButtonHartaCamereCORNA.Click
        Me.Close()
        HartaCamerelorAdmin.Show()
    End Sub

    Private Sub ButtonRezervariCORNA_Click(sender As Object, e As EventArgs) Handles ButtonRezervariCORNA.Click
        Me.Close()
        FormRezervariAdmin.Show()
    End Sub

    Private Sub ButtonTarifCamereCORNA_Click(sender As Object, e As EventArgs) Handles ButtonTarifCamereCORNA.Click
        Me.Close()
        TarifCamereAdmin.Show()
    End Sub

    Private Sub ButtonTarifDinamicCORNA_Click(sender As Object, e As EventArgs) Handles ButtonTarifDinamicCORNA.Click
        Me.Close()
        TarifDinamicAdmin.Show()
    End Sub

    Private Sub ButtonClientiCORNA_Click(sender As Object, e As EventArgs) Handles ButtonClientiCORNA.Click
        Me.Close()
        ClientiAdmin.Show()
    End Sub

    Private Sub ButtonDelogareCORNA_Click(sender As Object, e As EventArgs) Handles ButtonDelogareCORNA.Click
        Me.Close()
        LogareCont.Show()
    End Sub

    Private Sub TextBoxPrenumeCORNA_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPrenumeCORNA.TextChanged

    End Sub
End Class