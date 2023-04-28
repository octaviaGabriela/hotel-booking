Imports System.Data.SqlClient
Public Class CamereAngajat
    Dim Con As New SqlConnection("Data Source=DESKTOP-A4RFJNL\SQLSERVEROCT;Initial Catalog=HOTELmanagement;Integrated Security=True")

    'COMBOBOX TIP CAMERA
    Private Sub FillTipCamera()
        Con.Open()
        Dim cmd As New SqlCommand("Select top 3 TipCamera From Camera group by TipCamera", Con)
        Dim ad As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        ad.Fill(tbl)
        ComboBoxTipCameraCaAng.DataSource = tbl
        ComboBoxTipCameraCaAng.DisplayMember = "TipCamera"
        ComboBoxTipCameraCaAng.ValueMember = "TipCamera"
        Con.Close()
    End Sub

    Private Sub CamereAngajat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillTipCamera()
        FillNrCamera()

    End Sub

    'COMBOBOX NR CAMERA 
    Private Sub FillNrCamera()
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If
        Dim cmd As New SqlCommand("Select NrCamera From Camera Where TipCamera='" & ComboBoxTipCameraCaAng.SelectedValue & "' and StatusCamera = 0 ", Con)
        Dim ad As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        ad.Fill(tbl)
        ComboBoxNRCameraCaAng.DataSource = tbl
        ComboBoxNRCameraCaAng.DisplayMember = "NrCamera"
        ComboBoxNRCameraCaAng.ValueMember = "NrCamera"
        Con.Close()

    End Sub


    'BUTON ARATA - LABEL TARIF TIP CAMERA
    Private Sub ButtonArataTCAng_Click(sender As Object, e As EventArgs) Handles ButtonArataTCAng.Click
        Con.Open()
        Dim cmd As New SqlCommand("Select TarifCameraNoapte From Camera Where TipCamera=" & ComboBoxTipCameraCaAng.SelectedValue, Con)
        cmd.Parameters.AddWithValue("TipCamera", ComboBoxTipCameraCaAng.SelectedValue)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        If dr.Read Then
            LabelTarifTipCameraAng.Text = dr("TarifCameraNoapte")
        End If

        Con.Close()

    End Sub

    'COMBOBOX TIP CAMERA - COMBOBOX NR CAMERA 

    Private Sub ComboBoxTipCameraCaAng_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBoxTipCameraCaAng.SelectionChangeCommitted
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If
        Dim x As String
        x = "Select NrCamera From Camera Where TipCamera=" & ComboBoxTipCameraCaAng.SelectedValue.ToString & " and StatusCamera=0"
        System.Diagnostics.Debug.WriteLine(x)

        Dim cmd As New SqlCommand(x, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()

        adapter.Fill(table)
        ComboBoxNRCameraCaAng.DataSource = table


        Con.Close()

    End Sub

    Private Sub ButtonCORNCaAng_Click(sender As Object, e As EventArgs) Handles ButtonCORNCaAng.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub ButtonRezervariCaAng_Click(sender As Object, e As EventArgs) Handles ButtonRezervariCaAng.Click
        Me.Close()
        RezervariAngajat.Show()
    End Sub

    Private Sub ButtonClientiCaAng_Click(sender As Object, e As EventArgs) Handles ButtonClientiCaAng.Click
        Me.Close()
        ClientiAngajat.Show()
    End Sub

    Private Sub ButtonDelogareCaAng_Click(sender As Object, e As EventArgs) Handles ButtonDelogareCaAng.Click
        Me.Close()
        LogareCont.Show()
    End Sub
End Class