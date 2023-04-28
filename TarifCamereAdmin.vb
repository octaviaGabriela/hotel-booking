Imports System.Data.SqlClient
Public Class TarifCamereAdmin
    Dim Con As New SqlConnection("Data Source=DESKTOP-A4RFJNL\SQLSERVEROCT;Initial Catalog=HOTELmanagement;Integrated Security=True")

    'COMBOBOX TIP CAMERA
    Private Sub FillTipCamera()
        Con.Open()
        Dim cmd As New SqlCommand("Select top 3 TipCamera From Camera group by TipCamera", Con)
        Dim ad As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        ad.Fill(tbl)
        ComboBoxTipCameraTCA.DataSource = tbl
        ComboBoxTipCameraTCA.DisplayMember = "TipCamera"
        ComboBoxTipCameraTCA.ValueMember = "TipCamera"
        Con.Close()
    End Sub

    Private Sub TarifCamereAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillTipCamera()
        FillTipCamera1()
    End Sub



    'BUTON ARATA - LABEL TARIF TIP CAMERA
    Private Sub ButtonArataTarif_Click(sender As Object, e As EventArgs) Handles ButtonArataTarif.Click
        Con.Open()
        Dim cmd As New SqlCommand("Select TarifCameraNoapte From Camera Where TipCamera='" & ComboBoxTipCameraTCA.SelectedValue & "'", Con)
        cmd.Parameters.AddWithValue("TipCamera", ComboBoxTipCameraTCA.SelectedValue)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        If dr.Read Then
            LabelTarifTipCameraTCA.Text = dr("TarifCameraNoapte")
        End If


        Con.Close()
    End Sub



    'COMBOBOX TIP CAMERA (schimba tarif)
    Private Sub FillTipCamera1()
        Con.Open()
        Dim cmd As New SqlCommand("Select top 3 TipCamera From Camera group by TipCamera", Con)
        Dim ad As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        ad.Fill(tbl)
        ComboBoxTipCameraSTCA.DataSource = tbl
        ComboBoxTipCameraSTCA.DisplayMember = "TipCamera"
        ComboBoxTipCameraSTCA.ValueMember = "TipCamera"
        Con.Close()
    End Sub




    'BUTON MODIFICA TARIF - LABEL TARIF TIP CAMERA
    Private Sub ButtonModificaTarifTCA_Click(sender As Object, e As EventArgs) Handles ButtonModificaTarifTCA.Click
        If TextBoxTarifTipCameraSTCA.Text = "" Then
            MsgBox("Un câmp nu a fost completat")
        Else

            Con.Open()
            Dim query As String
            query = "Update Camera Set TarifCameraNoapte='" & TextBoxTarifTipCameraSTCA.Text & "' Where TipCamera='" & ComboBoxTipCameraSTCA.SelectedValue & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Tariful a fost modificat")
            Con.Close()
        End If
    End Sub

    Private Sub ButtonUtilizatoriTCA_Click(sender As Object, e As EventArgs) Handles ButtonUtilizatoriTCA.Click
        Me.Close()
        Utilizatori.Show()
    End Sub

    Private Sub ButtonHartaCamereTCA_Click(sender As Object, e As EventArgs) Handles ButtonHartaCamereTCA.Click
        Me.Close()
        HartaCamerelorAdmin.Show()
    End Sub

    Private Sub ButtonCORNCTCA_Click(sender As Object, e As EventArgs) Handles ButtonCORNCTCA.Click
        Me.Close()
        CreeazaORezervareNouaAdmin.Show()
    End Sub

    Private Sub ButtonRezervariTCA_Click(sender As Object, e As EventArgs) Handles ButtonRezervariTCA.Click
        Me.Close()
        FormRezervariAdmin.Show()
    End Sub

    Private Sub ButtonTarifDinamicTCA_Click(sender As Object, e As EventArgs) Handles ButtonTarifDinamicTCA.Click
        Me.Close()
        TarifDinamicAdmin.Show()
    End Sub

    Private Sub ButtonClientiTCA_Click(sender As Object, e As EventArgs) Handles ButtonClientiTCA.Click
        Me.Close()
        ClientiAdmin.Show()
    End Sub

    Private Sub ButtonDelogareTCA_Click(sender As Object, e As EventArgs) Handles ButtonDelogareTCA.Click
        Me.Close()
        LogareCont.Show()
    End Sub
End Class