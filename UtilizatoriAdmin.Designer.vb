<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Utilizatori
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonCORNUA = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonDelogareUA = New System.Windows.Forms.Button()
        Me.ButtonClientiUA = New System.Windows.Forms.Button()
        Me.ButtonRezervariUA = New System.Windows.Forms.Button()
        Me.ButtonHartaCamereUA = New System.Windows.Forms.Button()
        Me.ButtonTarifCamereUA = New System.Windows.Forms.Button()
        Me.ButtonTarifDinamicUA = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ButtonAdaugaUA = New System.Windows.Forms.Button()
        Me.ButtonStergeUA = New System.Windows.Forms.Button()
        Me.ButtonModificaUA = New System.Windows.Forms.Button()
        Me.ButtonReseteazaUA = New System.Windows.Forms.Button()
        Me.TextBoxNumeUA = New System.Windows.Forms.TextBox()
        Me.TextBoxPrenumeUA = New System.Windows.Forms.TextBox()
        Me.TextBoxParolaUA = New System.Windows.Forms.TextBox()
        Me.TextBoxSexUA = New System.Windows.Forms.TextBox()
        Me.TextBoxTelUA = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxTipUA = New System.Windows.Forms.TextBox()
        Me.DGVAngajati = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DGVAdmini = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVAngajati, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVAdmini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ButtonCORNUA)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.ButtonDelogareUA)
        Me.Panel1.Controls.Add(Me.ButtonClientiUA)
        Me.Panel1.Controls.Add(Me.ButtonRezervariUA)
        Me.Panel1.Controls.Add(Me.ButtonHartaCamereUA)
        Me.Panel1.Controls.Add(Me.ButtonTarifCamereUA)
        Me.Panel1.Controls.Add(Me.ButtonTarifDinamicUA)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(131, 619)
        Me.Panel1.TabIndex = 0
        '
        'ButtonCORNUA
        '
        Me.ButtonCORNUA.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonCORNUA.Location = New System.Drawing.Point(23, 64)
        Me.ButtonCORNUA.Name = "ButtonCORNUA"
        Me.ButtonCORNUA.Size = New System.Drawing.Size(89, 68)
        Me.ButtonCORNUA.TabIndex = 49
        Me.ButtonCORNUA.Text = "Creează o rezervare nouă"
        Me.ButtonCORNUA.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 18)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "ADMIN"
        '
        'ButtonDelogareUA
        '
        Me.ButtonDelogareUA.BackColor = System.Drawing.Color.LightCoral
        Me.ButtonDelogareUA.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonDelogareUA.Location = New System.Drawing.Point(23, 554)
        Me.ButtonDelogareUA.Name = "ButtonDelogareUA"
        Me.ButtonDelogareUA.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDelogareUA.TabIndex = 14
        Me.ButtonDelogareUA.Text = "Delogare"
        Me.ButtonDelogareUA.UseVisualStyleBackColor = False
        '
        'ButtonClientiUA
        '
        Me.ButtonClientiUA.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonClientiUA.Location = New System.Drawing.Point(23, 354)
        Me.ButtonClientiUA.Name = "ButtonClientiUA"
        Me.ButtonClientiUA.Size = New System.Drawing.Size(89, 23)
        Me.ButtonClientiUA.TabIndex = 14
        Me.ButtonClientiUA.Text = "Clienți"
        Me.ButtonClientiUA.UseVisualStyleBackColor = True
        '
        'ButtonRezervariUA
        '
        Me.ButtonRezervariUA.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonRezervariUA.Location = New System.Drawing.Point(23, 155)
        Me.ButtonRezervariUA.Name = "ButtonRezervariUA"
        Me.ButtonRezervariUA.Size = New System.Drawing.Size(89, 23)
        Me.ButtonRezervariUA.TabIndex = 14
        Me.ButtonRezervariUA.Text = "Rezervări"
        Me.ButtonRezervariUA.UseVisualStyleBackColor = True
        '
        'ButtonHartaCamereUA
        '
        Me.ButtonHartaCamereUA.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonHartaCamereUA.Location = New System.Drawing.Point(23, 201)
        Me.ButtonHartaCamereUA.Name = "ButtonHartaCamereUA"
        Me.ButtonHartaCamereUA.Size = New System.Drawing.Size(89, 23)
        Me.ButtonHartaCamereUA.TabIndex = 14
        Me.ButtonHartaCamereUA.Text = "HartăCamere"
        Me.ButtonHartaCamereUA.UseVisualStyleBackColor = True
        '
        'ButtonTarifCamereUA
        '
        Me.ButtonTarifCamereUA.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonTarifCamereUA.Location = New System.Drawing.Point(23, 251)
        Me.ButtonTarifCamereUA.Name = "ButtonTarifCamereUA"
        Me.ButtonTarifCamereUA.Size = New System.Drawing.Size(89, 23)
        Me.ButtonTarifCamereUA.TabIndex = 14
        Me.ButtonTarifCamereUA.Text = "TarifCamere"
        Me.ButtonTarifCamereUA.UseVisualStyleBackColor = True
        '
        'ButtonTarifDinamicUA
        '
        Me.ButtonTarifDinamicUA.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonTarifDinamicUA.Location = New System.Drawing.Point(23, 303)
        Me.ButtonTarifDinamicUA.Name = "ButtonTarifDinamicUA"
        Me.ButtonTarifDinamicUA.Size = New System.Drawing.Size(89, 23)
        Me.ButtonTarifDinamicUA.TabIndex = 14
        Me.ButtonTarifDinamicUA.Text = "TarifDinamic"
        Me.ButtonTarifDinamicUA.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(174, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Utilizatori"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(147, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nume"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(273, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Prenume"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(400, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Telefon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(529, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Sex"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.Location = New System.Drawing.Point(659, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Parola"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.Location = New System.Drawing.Point(469, 460)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 19)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Listă Angajați "
        '
        'ButtonAdaugaUA
        '
        Me.ButtonAdaugaUA.BackColor = System.Drawing.Color.LightBlue
        Me.ButtonAdaugaUA.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonAdaugaUA.Location = New System.Drawing.Point(276, 204)
        Me.ButtonAdaugaUA.Name = "ButtonAdaugaUA"
        Me.ButtonAdaugaUA.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAdaugaUA.TabIndex = 9
        Me.ButtonAdaugaUA.Text = "Adaugă"
        Me.ButtonAdaugaUA.UseVisualStyleBackColor = False
        '
        'ButtonStergeUA
        '
        Me.ButtonStergeUA.BackColor = System.Drawing.Color.LightBlue
        Me.ButtonStergeUA.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonStergeUA.Location = New System.Drawing.Point(691, 204)
        Me.ButtonStergeUA.Name = "ButtonStergeUA"
        Me.ButtonStergeUA.Size = New System.Drawing.Size(75, 23)
        Me.ButtonStergeUA.TabIndex = 11
        Me.ButtonStergeUA.Text = "Șterge"
        Me.ButtonStergeUA.UseVisualStyleBackColor = False
        '
        'ButtonModificaUA
        '
        Me.ButtonModificaUA.BackColor = System.Drawing.Color.LightBlue
        Me.ButtonModificaUA.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonModificaUA.Location = New System.Drawing.Point(416, 204)
        Me.ButtonModificaUA.Name = "ButtonModificaUA"
        Me.ButtonModificaUA.Size = New System.Drawing.Size(75, 23)
        Me.ButtonModificaUA.TabIndex = 12
        Me.ButtonModificaUA.Text = "Modifică"
        Me.ButtonModificaUA.UseVisualStyleBackColor = False
        '
        'ButtonReseteazaUA
        '
        Me.ButtonReseteazaUA.BackColor = System.Drawing.Color.LightBlue
        Me.ButtonReseteazaUA.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonReseteazaUA.Location = New System.Drawing.Point(554, 204)
        Me.ButtonReseteazaUA.Name = "ButtonReseteazaUA"
        Me.ButtonReseteazaUA.Size = New System.Drawing.Size(75, 23)
        Me.ButtonReseteazaUA.TabIndex = 13
        Me.ButtonReseteazaUA.Text = "Resetează"
        Me.ButtonReseteazaUA.UseVisualStyleBackColor = False
        '
        'TextBoxNumeUA
        '
        Me.TextBoxNumeUA.Location = New System.Drawing.Point(150, 138)
        Me.TextBoxNumeUA.Name = "TextBoxNumeUA"
        Me.TextBoxNumeUA.Size = New System.Drawing.Size(89, 20)
        Me.TextBoxNumeUA.TabIndex = 14
        '
        'TextBoxPrenumeUA
        '
        Me.TextBoxPrenumeUA.Location = New System.Drawing.Point(276, 138)
        Me.TextBoxPrenumeUA.Name = "TextBoxPrenumeUA"
        Me.TextBoxPrenumeUA.Size = New System.Drawing.Size(90, 20)
        Me.TextBoxPrenumeUA.TabIndex = 15
        '
        'TextBoxParolaUA
        '
        Me.TextBoxParolaUA.Location = New System.Drawing.Point(662, 138)
        Me.TextBoxParolaUA.Name = "TextBoxParolaUA"
        Me.TextBoxParolaUA.Size = New System.Drawing.Size(83, 20)
        Me.TextBoxParolaUA.TabIndex = 16
        '
        'TextBoxSexUA
        '
        Me.TextBoxSexUA.Location = New System.Drawing.Point(532, 138)
        Me.TextBoxSexUA.Name = "TextBoxSexUA"
        Me.TextBoxSexUA.Size = New System.Drawing.Size(86, 20)
        Me.TextBoxSexUA.TabIndex = 17
        '
        'TextBoxTelUA
        '
        Me.TextBoxTelUA.Location = New System.Drawing.Point(403, 138)
        Me.TextBoxTelUA.Name = "TextBoxTelUA"
        Me.TextBoxTelUA.Size = New System.Drawing.Size(88, 20)
        Me.TextBoxTelUA.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label10.Location = New System.Drawing.Point(792, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 18)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Tip"
        '
        'TextBoxTipUA
        '
        Me.TextBoxTipUA.Location = New System.Drawing.Point(795, 138)
        Me.TextBoxTipUA.Name = "TextBoxTipUA"
        Me.TextBoxTipUA.Size = New System.Drawing.Size(83, 20)
        Me.TextBoxTipUA.TabIndex = 20
        '
        'DGVAngajati
        '
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.SlateGray
        Me.DGVAngajati.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle15
        Me.DGVAngajati.BackgroundColor = System.Drawing.Color.White
        Me.DGVAngajati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAngajati.GridColor = System.Drawing.Color.LightBlue
        Me.DGVAngajati.Location = New System.Drawing.Point(150, 496)
        Me.DGVAngajati.Name = "DGVAngajati"
        Me.DGVAngajati.Size = New System.Drawing.Size(738, 111)
        Me.DGVAngajati.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.Location = New System.Drawing.Point(469, 291)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 19)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Listă Admini "
        '
        'DGVAdmini
        '
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.SlateGray
        Me.DGVAdmini.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.DGVAdmini.BackgroundColor = System.Drawing.Color.White
        Me.DGVAdmini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAdmini.GridColor = System.Drawing.Color.LightBlue
        Me.DGVAdmini.Location = New System.Drawing.Point(150, 325)
        Me.DGVAdmini.Name = "DGVAdmini"
        Me.DGVAdmini.Size = New System.Drawing.Size(738, 104)
        Me.DGVAdmini.TabIndex = 23
        '
        'Utilizatori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(900, 619)
        Me.Controls.Add(Me.DGVAdmini)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DGVAngajati)
        Me.Controls.Add(Me.TextBoxTipUA)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBoxTelUA)
        Me.Controls.Add(Me.TextBoxSexUA)
        Me.Controls.Add(Me.TextBoxParolaUA)
        Me.Controls.Add(Me.TextBoxPrenumeUA)
        Me.Controls.Add(Me.TextBoxNumeUA)
        Me.Controls.Add(Me.ButtonReseteazaUA)
        Me.Controls.Add(Me.ButtonModificaUA)
        Me.Controls.Add(Me.ButtonStergeUA)
        Me.Controls.Add(Me.ButtonAdaugaUA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Utilizatori"
        Me.Text = "Utilizatori"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGVAngajati, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVAdmini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents ButtonDelogareUA As Button
    Friend WithEvents ButtonClientiUA As Button
    Friend WithEvents ButtonRezervariUA As Button
    Friend WithEvents ButtonHartaCamereUA As Button
    Friend WithEvents ButtonTarifCamereUA As Button
    Friend WithEvents ButtonTarifDinamicUA As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ButtonAdaugaUA As Button
    Friend WithEvents ButtonStergeUA As Button
    Friend WithEvents ButtonModificaUA As Button
    Friend WithEvents ButtonReseteazaUA As Button
    Friend WithEvents TextBoxNumeUA As TextBox
    Friend WithEvents TextBoxPrenumeUA As TextBox
    Friend WithEvents TextBoxParolaUA As TextBox
    Friend WithEvents TextBoxSexUA As TextBox
    Friend WithEvents TextBoxTelUA As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxTipUA As TextBox
    Friend WithEvents DGVAngajati As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents DGVAdmini As DataGridView
    Friend WithEvents ButtonCORNUA As Button
End Class
