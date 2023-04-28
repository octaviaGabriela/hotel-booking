<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CamereAngajat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBoxTipCameraCaAng = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonCORNCaAng = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonDelogareCaAng = New System.Windows.Forms.Button()
        Me.ButtonClientiCaAng = New System.Windows.Forms.Button()
        Me.ButtonRezervariCaAng = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxNRCameraCaAng = New System.Windows.Forms.ComboBox()
        Me.LabelTarifTipCameraAng = New System.Windows.Forms.Label()
        Me.ButtonArataTCAng = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(201, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 23)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Camere"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(528, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 18)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Tarif tip cameră"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label14.Location = New System.Drawing.Point(187, 107)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 18)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Tip cameră"
        '
        'ComboBoxTipCameraCaAng
        '
        Me.ComboBoxTipCameraCaAng.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTipCameraCaAng.FormattingEnabled = True
        Me.ComboBoxTipCameraCaAng.Location = New System.Drawing.Point(190, 140)
        Me.ComboBoxTipCameraCaAng.Name = "ComboBoxTipCameraCaAng"
        Me.ComboBoxTipCameraCaAng.Size = New System.Drawing.Size(72, 21)
        Me.ComboBoxTipCameraCaAng.TabIndex = 39
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ButtonCORNCaAng)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.ButtonDelogareCaAng)
        Me.Panel1.Controls.Add(Me.ButtonClientiCaAng)
        Me.Panel1.Controls.Add(Me.ButtonRezervariCaAng)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(132, 324)
        Me.Panel1.TabIndex = 43
        '
        'ButtonCORNCaAng
        '
        Me.ButtonCORNCaAng.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonCORNCaAng.Location = New System.Drawing.Point(23, 55)
        Me.ButtonCORNCaAng.Name = "ButtonCORNCaAng"
        Me.ButtonCORNCaAng.Size = New System.Drawing.Size(89, 68)
        Me.ButtonCORNCaAng.TabIndex = 48
        Me.ButtonCORNCaAng.Text = "Creează o rezervare nouă"
        Me.ButtonCORNCaAng.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 18)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "ANGAJAT"
        '
        'ButtonDelogareCaAng
        '
        Me.ButtonDelogareCaAng.BackColor = System.Drawing.Color.LightCoral
        Me.ButtonDelogareCaAng.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonDelogareCaAng.Location = New System.Drawing.Point(23, 279)
        Me.ButtonDelogareCaAng.Name = "ButtonDelogareCaAng"
        Me.ButtonDelogareCaAng.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDelogareCaAng.TabIndex = 14
        Me.ButtonDelogareCaAng.Text = "Delogare"
        Me.ButtonDelogareCaAng.UseVisualStyleBackColor = False
        '
        'ButtonClientiCaAng
        '
        Me.ButtonClientiCaAng.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonClientiCaAng.Location = New System.Drawing.Point(23, 192)
        Me.ButtonClientiCaAng.Name = "ButtonClientiCaAng"
        Me.ButtonClientiCaAng.Size = New System.Drawing.Size(89, 23)
        Me.ButtonClientiCaAng.TabIndex = 14
        Me.ButtonClientiCaAng.Text = "Clienți"
        Me.ButtonClientiCaAng.UseVisualStyleBackColor = True
        '
        'ButtonRezervariCaAng
        '
        Me.ButtonRezervariCaAng.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonRezervariCaAng.Location = New System.Drawing.Point(23, 149)
        Me.ButtonRezervariCaAng.Name = "ButtonRezervariCaAng"
        Me.ButtonRezervariCaAng.Size = New System.Drawing.Size(89, 23)
        Me.ButtonRezervariCaAng.TabIndex = 14
        Me.ButtonRezervariCaAng.Text = "Rezervări"
        Me.ButtonRezervariCaAng.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(357, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 18)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Număr cameră"
        '
        'ComboBoxNRCameraCaAng
        '
        Me.ComboBoxNRCameraCaAng.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxNRCameraCaAng.FormattingEnabled = True
        Me.ComboBoxNRCameraCaAng.Location = New System.Drawing.Point(360, 140)
        Me.ComboBoxNRCameraCaAng.Name = "ComboBoxNRCameraCaAng"
        Me.ComboBoxNRCameraCaAng.Size = New System.Drawing.Size(90, 21)
        Me.ComboBoxNRCameraCaAng.TabIndex = 45
        '
        'LabelTarifTipCameraAng
        '
        Me.LabelTarifTipCameraAng.AutoSize = True
        Me.LabelTarifTipCameraAng.BackColor = System.Drawing.SystemColors.Control
        Me.LabelTarifTipCameraAng.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelTarifTipCameraAng.Location = New System.Drawing.Point(528, 142)
        Me.LabelTarifTipCameraAng.Name = "LabelTarifTipCameraAng"
        Me.LabelTarifTipCameraAng.Size = New System.Drawing.Size(102, 18)
        Me.LabelTarifTipCameraAng.TabIndex = 174
        Me.LabelTarifTipCameraAng.Text = "Tarif tip cameră"
        '
        'ButtonArataTCAng
        '
        Me.ButtonArataTCAng.BackColor = System.Drawing.Color.LightBlue
        Me.ButtonArataTCAng.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonArataTCAng.Location = New System.Drawing.Point(350, 204)
        Me.ButtonArataTCAng.Name = "ButtonArataTCAng"
        Me.ButtonArataTCAng.Size = New System.Drawing.Size(119, 23)
        Me.ButtonArataTCAng.TabIndex = 177
        Me.ButtonArataTCAng.Text = "Arată tarif"
        Me.ButtonArataTCAng.UseVisualStyleBackColor = False
        '
        'CamereAngajat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(695, 326)
        Me.Controls.Add(Me.ButtonArataTCAng)
        Me.Controls.Add(Me.LabelTarifTipCameraAng)
        Me.Controls.Add(Me.ComboBoxNRCameraCaAng)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ComboBoxTipCameraCaAng)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CamereAngajat"
        Me.Text = "CamereAngajat"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents ComboBoxTipCameraCaAng As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents ButtonDelogareCaAng As Button
    Friend WithEvents ButtonClientiCaAng As Button
    Friend WithEvents ButtonRezervariCaAng As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxNRCameraCaAng As ComboBox
    Friend WithEvents ButtonCORNCaAng As Button
    Friend WithEvents LabelTarifTipCameraAng As Label
    Friend WithEvents ButtonArataTCAng As Button
End Class
