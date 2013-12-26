<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class config
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PerplexTheme1 = New Uploadup.PerplexTheme()
        Me.PerplexGroupBox2 = New Uploadup.PerplexGroupBox()
        Me.PerplexLabel1 = New Uploadup.PerplexLabel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.PerplexLabel3 = New Uploadup.PerplexLabel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PerplexLabel2 = New Uploadup.PerplexLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PerplexButton1 = New Uploadup.PerplexButton()
        Me.PerplexControlBox1 = New Uploadup.PerplexControlBox()
        Me.PerplexTheme1.SuspendLayout()
        Me.PerplexGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(87, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Utilisateur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(130, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mot de passe"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(42, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Hote"
        '
        'PerplexTheme1
        '
        Me.PerplexTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.PerplexTheme1.Controls.Add(Me.PerplexControlBox1)
        Me.PerplexTheme1.Controls.Add(Me.PerplexGroupBox2)
        Me.PerplexTheme1.Controls.Add(Me.PerplexButton1)
        Me.PerplexTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PerplexTheme1.Location = New System.Drawing.Point(0, 0)
        Me.PerplexTheme1.Name = "PerplexTheme1"
        Me.PerplexTheme1.Size = New System.Drawing.Size(292, 273)
        Me.PerplexTheme1.TabIndex = 0
        Me.PerplexTheme1.Text = "Configuration"
        '
        'PerplexGroupBox2
        '
        Me.PerplexGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.PerplexGroupBox2.Controls.Add(Me.PerplexLabel1)
        Me.PerplexGroupBox2.Controls.Add(Me.TextBox3)
        Me.PerplexGroupBox2.Controls.Add(Me.PerplexLabel3)
        Me.PerplexGroupBox2.Controls.Add(Me.TextBox2)
        Me.PerplexGroupBox2.Controls.Add(Me.PerplexLabel2)
        Me.PerplexGroupBox2.Controls.Add(Me.TextBox1)
        Me.PerplexGroupBox2.Location = New System.Drawing.Point(24, 48)
        Me.PerplexGroupBox2.Name = "PerplexGroupBox2"
        Me.PerplexGroupBox2.Size = New System.Drawing.Size(243, 134)
        Me.PerplexGroupBox2.TabIndex = 11
        Me.PerplexGroupBox2.Text = "                             Configuration "
        '
        'PerplexLabel1
        '
        Me.PerplexLabel1.BackColor = System.Drawing.Color.Transparent
        Me.PerplexLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.PerplexLabel1.Location = New System.Drawing.Point(35, 30)
        Me.PerplexLabel1.Name = "PerplexLabel1"
        Me.PerplexLabel1.Size = New System.Drawing.Size(90, 13)
        Me.PerplexLabel1.TabIndex = 11
        Me.PerplexLabel1.Text = "Host"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(79, 92)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(81, 20)
        Me.TextBox3.TabIndex = 10
        '
        'PerplexLabel3
        '
        Me.PerplexLabel3.BackColor = System.Drawing.Color.Transparent
        Me.PerplexLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.PerplexLabel3.Location = New System.Drawing.Point(85, 79)
        Me.PerplexLabel3.Name = "PerplexLabel3"
        Me.PerplexLabel3.Size = New System.Drawing.Size(76, 13)
        Me.PerplexLabel3.TabIndex = 9
        Me.PerplexLabel3.Text = "Utilisateur"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(149, 43)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(81, 20)
        Me.TextBox2.TabIndex = 8
        '
        'PerplexLabel2
        '
        Me.PerplexLabel2.BackColor = System.Drawing.Color.Transparent
        Me.PerplexLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.PerplexLabel2.Location = New System.Drawing.Point(148, 30)
        Me.PerplexLabel2.Name = "PerplexLabel2"
        Me.PerplexLabel2.Size = New System.Drawing.Size(90, 13)
        Me.PerplexLabel2.TabIndex = 7
        Me.PerplexLabel2.Text = "Mot de passe"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 43)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(81, 20)
        Me.TextBox1.TabIndex = 6
        '
        'PerplexButton1
        '
        Me.PerplexButton1.BackColor = System.Drawing.Color.Transparent
        Me.PerplexButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.PerplexButton1.Location = New System.Drawing.Point(102, 198)
        Me.PerplexButton1.Name = "PerplexButton1"
        Me.PerplexButton1.Size = New System.Drawing.Size(91, 43)
        Me.PerplexButton1.TabIndex = 0
        Me.PerplexButton1.Text = "Valider"
        '
        'PerplexControlBox1
        '
        Me.PerplexControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.PerplexControlBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.PerplexControlBox1.Location = New System.Drawing.Point(238, 3)
        Me.PerplexControlBox1.Name = "PerplexControlBox1"
        Me.PerplexControlBox1.Size = New System.Drawing.Size(51, 24)
        Me.PerplexControlBox1.TabIndex = 12
        Me.PerplexControlBox1.Text = "PerplexControlBox1"
        '
        'config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.PerplexTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "config"
        Me.Text = "config"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.PerplexTheme1.ResumeLayout(False)
        Me.PerplexGroupBox2.ResumeLayout(False)
        Me.PerplexGroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PerplexTheme1 As Uploadup.PerplexTheme
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PerplexButton1 As Uploadup.PerplexButton
    Friend WithEvents PerplexGroupBox2 As Uploadup.PerplexGroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents PerplexLabel3 As Uploadup.PerplexLabel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents PerplexLabel2 As Uploadup.PerplexLabel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PerplexLabel1 As Uploadup.PerplexLabel
    Friend WithEvents PerplexControlBox1 As Uploadup.PerplexControlBox
End Class
