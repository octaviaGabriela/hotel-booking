Imports System.Data.SqlClient
Public Class Form1
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
        DGVCORNAng.DataSource = ds.Tables(0)
        Con.Close()
    End Sub


    Private Sub Clear()
        TextBoxNumeCORNAng.Text = ""
        TextBoxPrenumeCORNAng.Text = ""
        TextBoxTelCORNAng.Text = ""
        TextBoxSexCORNAng.Text = ""
        TextBoxProvenientaCORNAng.Text = ""
        ComboBoxTipCameraCORNAng.SelectedIndex = -1
        ComboBoxNrCameraCORNAng.SelectedIndex = -1
        TextBoxAvansCORNAng.Text = ""
        LabelTotalDePlataRezervareNouaRAng.Text = ""
        LabelRestDePlataRezervareNouaRAng.Text = ""
        TextBoxCautaNumeClientiCORNAng.Text = ""
        TextBoxCautaPrenumeClientiCORNAng.Text = ""


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
        FillNrCamera()
        FillTipCamera()
    End Sub


    Dim key = 0


    'DISPLAY IN  DGV CLIENTI

    Private Sub DGVCORNAng_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCORNAng.CellContentClick
        Dim row As DataGridViewRow = DGVCORNAng.Rows(e.RowIndex)
        TextBoxNumeCORNAng.Text = row.Cells(1).Value.ToString
        TextBoxPrenumeCORNAng.Text = row.Cells(2).Value.ToString
        TextBoxTelCORNAng.Text = row.Cells(3).Value.ToString
        TextBoxSexCORNAng.Text = row.Cells(4).Value.ToString
        TextBoxProvenientaCORNAng.Text = row.Cells(5).Value.ToString
        If TextBoxNumeCORNAng.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    'BUTON CAUTA CLIENTI
    Private Sub ButtonCautaCORNAng_Click(sender As Object, e As EventArgs) Handles ButtonCautaCORNAng.Click
        If TextBoxCautaNumeClientiCORNAng.Text <> "" Then
            TryCast(DGVCORNAng.DataSource, DataTable).DefaultView.RowFilter =
        String.Format("NumeClient Like '%" & TextBoxCautaNumeClientiCORNAng.Text & "%'")
        Else
            TryCast(DGVCORNAng.DataSource, DataTable).DefaultView.RowFilter =
            String.Format("PrenumeClient Like '%" & TextBoxCautaPrenumeClientiCORNAng.Text & "%'")
        End If
    End Sub

    'COMBOBOX TIP CAMERA
    Private Sub FillTipCamera()
        Con.Open()
        Dim cmd As New SqlCommand("Select top 3 TipCamera From Camera group by TipCamera", Con)
        Dim ad As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        ad.Fill(tbl)
        ComboBoxTipCameraCORNAng.DataSource = tbl
        ComboBoxTipCameraCORNAng.DisplayMember = "TipCamera"
        ComboBoxTipCameraCORNAng.ValueMember = "TipCamera"
        Con.Close()
    End Sub


    'COMBOBOX NR CAMERA 
    Private Sub FillNrCamera()
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If
        Dim cmd As New SqlCommand("Select NrCamera From Camera Where TipCamera='" & ComboBoxTipCameraCORNAng.SelectedValue & "' and StatusCamera = 0 ", Con)
        Dim ad As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        ad.Fill(tbl)
        ComboBoxNrCameraCORNAng.DataSource = tbl
        ComboBoxNrCameraCORNAng.DisplayMember = "NrCamera"
        ComboBoxNrCameraCORNAng.ValueMember = "NrCamera"
        Con.Close()

    End Sub



    'COMBOBOX TIP CAMERA - COMBOBOX NR CAMERA 

    Private Sub ComboBoxTipCameraCaAng_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBoxTipCameraCORNAng.SelectionChangeCommitted
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If
        Dim x As String
        x = "Select NrCamera From Camera Where TipCamera=" & ComboBoxTipCameraCORNAng.SelectedValue.ToString & "  And IdCamera Not in (select IdCamera from Rezervare where 
                                                                      ((( '" & DateTimePickerDataICORNAng.Text & "'<= DataInceputRezervare and DataInceputRezervare <='" & DateTimePickerDataSCORNAng.Text & "' )
                                                                     Or( '" & DateTimePickerDataICORNAng.Text & "'<= DataSfarsitRezervare and DataSfarsitRezervare <='" & DateTimePickerDataSCORNAng.Text & "' )
                                                                     Or( '" & DateTimePickerDataICORNAng.Text & "'>= DataInceputRezervare and '" & DateTimePickerDataSCORNAng.Text & "'<= DataSfarsitRezervare )
                                                                     Or ('" & DateTimePickerDataICORNAng.Text & "'= DataInceputRezervare and '" & DateTimePickerDataSCORNAng.Text & "'= DataSfarsitRezervare) )
																	 And ( Realizata='Confirmată' or Realizata='Înregistrată'))) "

        System.Diagnostics.Debug.WriteLine(x)

        Dim cmd As New SqlCommand(x, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()

        adapter.Fill(table)
        ComboBoxNrCameraCORNAng.DataSource = table


        Con.Close()

    End Sub


    'BUTON REZETEAZA
    Private Sub ButtonReseteazaCORNAng_Click(sender As Object, e As EventArgs) Handles ButtonReseteazaCORNAng.Click
        Clear()
    End Sub



    'AVANS SI PLATA
    Private Sub TextBoxAvansCORNAng_TextChanged(sender As Object, e As EventArgs) Handles TextBoxAvansCORNAng.TextChanged
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If
        If Con4.State = ConnectionState.Closed Then
            Con4.Open()
        End If


        If DateTimePickerDataICORNAng.Text IsNot "" And DateTimePickerDataSCORNAng.Text IsNot "" Then
            Dim sumaTotala As Single = 0
            Dim tipCamera As Integer = ComboBoxTipCameraCORNAng.SelectedValue
            Dim query As String = "select top 1 TarifCameraNoapte from Camera where TipCamera = @TipCamera"


            Using cmd As New SqlCommand(query, Con)
                cmd.Parameters.Add("@TipCamera", SqlDbType.Int).Value = tipCamera

                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim pretCamera As Single = reader.GetValue(0)
                    Dim startDate As Date = DateTimePickerDataICORNAng.Value
                    Dim endDate As Date = DateTimePickerDataSCORNAng.Value


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
                                    LabelTotalDePlataRezervareNouaRAng.Text = sumaTotala.ToString
                                End If

                            Next



                        End While
                        Console.WriteLine(numDays - nopti)
                        If numDays - nopti <> 0 Then
                            sumaTotala = sumaTotala + pretCamera * (numDays - nopti)
                            LabelTotalDePlataRezervareNouaRAng.Text = sumaTotala.ToString
                        End If
                        If LabelRestDePlataRezervareNouaRAng.Text Is "" Or LabelRestDePlataRezervareNouaRAng.Text IsNot "" Then
                            LabelRestDePlataRezervareNouaRAng.Text = LabelTotalDePlataRezervareNouaRAng.Text - TextBoxAvansCORNAng.Text
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
    Private Sub ButtonAdaugaCORNAng_Click(sender As Object, e As EventArgs) Handles ButtonAdaugaCORNAng.Click
        Dim idClient As Integer
        Dim idCamera As Integer

        If TextBoxNumeCORNAng.Text = "" Or TextBoxPrenumeCORNAng.Text = "" Or TextBoxTelCORNAng.Text = "" Or TextBoxSexCORNAng.Text = "" Or TextBoxProvenientaCORNAng.Text = "" Or ComboBoxTipCameraCORNAng.SelectedIndex = -1 Or ComboBoxNrCameraCORNAng.SelectedIndex = -1 Or TextBoxAvansCORNAng.Text = "" Then
            MsgBox("un câmp nu a fost completat")
        Else


            'ADAUGARE IN TABEL CLIENT -> DOAR CLIENTII NOI si obtinere idClient

            'client vechi

            Con3.Open()
            Dim query3 As String
            query3 = "select IdClient From Client where NrTelClient = '" & TextBoxTelCORNAng.Text & "'"
            Dim cmd3 As New SqlCommand("select IdClient From Client where NrTelClient = '" & TextBoxTelCORNAng.Text & "'", Con3)
            Dim dr3 As SqlDataReader
            dr3 = cmd3.ExecuteReader
            If dr3.Read Then
                If dr3.HasRows Then
                    MsgBox("A fost creată o rezervare nouă pentru un client vechi")
                End If
            Else


                'client nou

                Dim q3 As String
                q3 = "insert into Client values( '" & TextBoxNumeCORNAng.Text & "' ,'" & TextBoxPrenumeCORNAng.Text & "' , '" & TextBoxTelCORNAng.Text & "' , '" & TextBoxSexCORNAng.Text & "',  '" & TextBoxProvenientaCORNAng.Text & "' ) "
                Dim c3 As SqlCommand
                c3 = New SqlCommand(q3, Con3)
                c3.ExecuteNonQuery()
                MsgBox("A fost creată o rezervare nouă pentru un client nou")
            End If

            Con3.Close()




            'obt id client nou

            Con3.Open()
            Dim qy3 As String
            qy3 = "select IdClient from dbo.Client where NrTelClient = '" & TextBoxTelCORNAng.Text & "'"

            Dim cd3 As New SqlCommand("select IdClient from dbo.Client where NrTelClient = '" & TextBoxTelCORNAng.Text & "'", Con3)
            Dim sdr3 As SqlDataReader
            sdr3 = cd3.ExecuteReader
            If sdr3.Read Then
                idClient = sdr3("IdClient")
            End If
            Con3.Close()





            'obtinere idCamera
            Con2.Open()
            Dim qy2 As String
            qy2 = "select IdCamera From Camera Where TipCamera='" & ComboBoxTipCameraCORNAng.SelectedValue.ToString & "' and NrCamera='" & ComboBoxNrCameraCORNAng.SelectedValue.ToString & "'"

            Dim cd2 As New SqlCommand("select IdCamera From Camera Where TipCamera='" & ComboBoxTipCameraCORNAng.SelectedValue.ToString & "' and NrCamera='" & ComboBoxNrCameraCORNAng.SelectedValue.ToString & "'", Con2)
            Dim sdr2 As SqlDataReader
            sdr2 = cd2.ExecuteReader
            If sdr2.Read Then
                idCamera = sdr2("IdCamera")
            End If
            Con2.Close()





            'INSERT IN REZERVARE
            Con1.Open()
            Dim query1 As String
            query1 = "insert into Rezervare values( " & idClient & " ," & idCamera & " , '" & DateTimePickerDataICORNAng.Text & "' ,'" & DateTimePickerDataSCORNAng.Text & "' ,'Înregistrată', " & TextBoxAvansCORNAng.Text & ",  " & LabelTotalDePlataRezervareNouaRAng.Text & ",  " & LabelRestDePlataRezervareNouaRAng.Text & " ) "
            Dim cmd1 As SqlCommand
            cmd1 = New SqlCommand(query1, Con1)
            cmd1.ExecuteNonQuery()
            MsgBox("rezervarea a fost înregistrată")
            Con1.Close()


        End If


        Populate()
        Clear()

    End Sub

    Private Sub ButtonRezervăriCORNAng_Click(sender As Object, e As EventArgs) Handles ButtonRezervăriCORNAng.Click
        Me.Close()
        RezervariAngajat.Show()
    End Sub

    Private Sub ButtonCamereCORNAng_Click(sender As Object, e As EventArgs) Handles ButtonCamereCORNAng.Click
        Me.Close()
        CamereAngajat.Show()
    End Sub

    Private Sub ButtonClientiCORNAng_Click(sender As Object, e As EventArgs) Handles ButtonClientiCORNAng.Click
        Me.Close()
        ClientiAngajat.Show()
    End Sub

    Private Sub ButtonDelogareCORNAng_Click(sender As Object, e As EventArgs) Handles ButtonDelogareCORNAng.Click
        Me.Close()
        LogareCont.Show()
    End Sub
End Class