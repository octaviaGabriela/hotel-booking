<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogareCont
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonAccesare = New System.Windows.Forms.Button()
        Me.ButtonCreareContNou = New System.Windows.Forms.Button()
        Me.TextBoxNumeLogare = New System.Windows.Forms.TextBox()
        Me.TextBoxPrenumeLogare = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxParolaLogare = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBoxParolaVizibila = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(22, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOGARE CONT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nume"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Prenume"
        '
        'ButtonAccesare
        '
        Me.ButtonAccesare.BackColor = System.Drawing.Color.LightBlue
        Me.ButtonAccesare.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonAccesare.ForeColor = System.Drawing.Color.Black
        Me.ButtonAccesare.Location = New System.Drawing.Point(26, 276)
        Me.ButtonAccesare.Name = "ButtonAccesare"
        Me.ButtonAccesare.Size = New System.Drawing.Size(198, 25)
        Me.ButtonAccesare.TabIndex = 3
        Me.ButtonAccesare.Text = "Accesare"
        Me.ButtonAccesare.UseVisualStyleBackColor = False
        '
        'ButtonCreareContNou
        '
        Me.ButtonCreareContNou.BackColor = System.Drawing.Color.LightBlue
        Me.ButtonCreareContNou.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonCreareContNou.Location = New System.Drawing.Point(97, 324)
        Me.ButtonCreareContNou.Name = "ButtonCreareContNou"
        Me.ButtonCreareContNou.Size = New System.Drawing.Size(127, 25)
        Me.ButtonCreareContNou.TabIndex = 4
        Me.ButtonCreareContNou.Text = "Creare cont nou"
        Me.ButtonCreareContNou.UseVisualStyleBackColor = False
        '
        'TextBoxNumeLogare
        '
        Me.TextBoxNumeLogare.Location = New System.Drawing.Point(26, 100)
        Me.TextBoxNumeLogare.Name = "TextBoxNumeLogare"
        Me.TextBoxNumeLogare.Size = New System.Drawing.Size(198, 20)
        Me.TextBoxNumeLogare.TabIndex = 5
        '
        'TextBoxPrenumeLogare
        '
        Me.TextBoxPrenumeLogare.Location = New System.Drawing.Point(26, 157)
        Me.TextBoxPrenumeLogare.Name = "TextBoxPrenumeLogare"
        Me.TextBoxPrenumeLogare.Size = New System.Drawing.Size(198, 20)
        Me.TextBoxPrenumeLogare.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Parola"
        '
        'TextBoxParolaLogare
        '
        Me.TextBoxParolaLogare.Location = New System.Drawing.Point(26, 218)
        Me.TextBoxParolaLogare.Name = "TextBoxParolaLogare"
        Me.TextBoxParolaLogare.Size = New System.Drawing.Size(198, 20)
        Me.TextBoxParolaLogare.TabIndex = 8
        Me.TextBoxParolaLogare.UseSystemPasswordChar = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(343, 25)
        Me.Panel1.TabIndex = 9
        '
        'CheckBoxParolaVizibila
        '
        Me.CheckBoxParolaVizibila.AutoSize = True
        Me.CheckBoxParolaVizibila.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CheckBoxParolaVizibila.Location = New System.Drawing.Point(26, 244)
        Me.CheckBoxParolaVizibila.Name = "CheckBoxParolaVizibila"
        Me.CheckBoxParolaVizibila.Size = New System.Drawing.Size(92, 17)
        Me.CheckBoxParolaVizibila.TabIndex = 10
        Me.CheckBoxParolaVizibila.Text = "Parolă vizibilă"
        Me.CheckBoxParolaVizibila.UseVisualStyleBackColor = True
        '
        'LogareCont
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(343, 386)
        Me.Controls.Add(Me.CheckBoxParolaVizibila)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBoxParolaLogare)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxPrenumeLogare)
        Me.Controls.Add(Me.TextBoxNumeLogare)
        Me.Controls.Add(Me.ButtonCreareContNou)
        Me.Controls.Add(Me.ButtonAccesare)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LogareCont"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LogareCont"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonAccesare As Button
    Friend WithEvents ButtonCreareContNou As Button
    Friend WithEvents TextBoxNumeLogare As TextBox
    Friend WithEvents TextBoxPrenumeLogare As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxParolaLogare As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBoxParolaVizibila As CheckBox
End Class
