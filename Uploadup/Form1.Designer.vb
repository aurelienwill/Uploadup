<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PerplexTheme1 = New Uploadup.PerplexTheme()
        Me.PerplexGroupBox2 = New Uploadup.PerplexGroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PerplexControlBox1 = New Uploadup.PerplexControlBox()
        Me.PerplexGroupBox1 = New Uploadup.PerplexGroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PerplexProgressBar1 = New Uploadup.PerplexProgressBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PerplexLabel1 = New Uploadup.PerplexLabel()
        Me.PerplexTheme1.SuspendLayout()
        Me.PerplexGroupBox2.SuspendLayout()
        Me.PerplexGroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackgroundWorker1
        '
        '
        'PerplexTheme1
        '
        Me.PerplexTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.PerplexTheme1.Controls.Add(Me.PerplexGroupBox2)
        Me.PerplexTheme1.Controls.Add(Me.PerplexControlBox1)
        Me.PerplexTheme1.Controls.Add(Me.PerplexGroupBox1)
        Me.PerplexTheme1.Controls.Add(Me.PerplexProgressBar1)
        Me.PerplexTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PerplexTheme1.Location = New System.Drawing.Point(0, 0)
        Me.PerplexTheme1.Name = "PerplexTheme1"
        Me.PerplexTheme1.Size = New System.Drawing.Size(284, 262)
        Me.PerplexTheme1.TabIndex = 0
        Me.PerplexTheme1.Text = "FastUpload"
        '
        'PerplexGroupBox2
        '
        Me.PerplexGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.PerplexGroupBox2.Controls.Add(Me.PerplexLabel1)
        Me.PerplexGroupBox2.Controls.Add(Me.Button1)
        Me.PerplexGroupBox2.Controls.Add(Me.TextBox4)
        Me.PerplexGroupBox2.Controls.Add(Me.TextBox3)
        Me.PerplexGroupBox2.Controls.Add(Me.TextBox2)
        Me.PerplexGroupBox2.Controls.Add(Me.TextBox1)
        Me.PerplexGroupBox2.Location = New System.Drawing.Point(29, 155)
        Me.PerplexGroupBox2.Name = "PerplexGroupBox2"
        Me.PerplexGroupBox2.Size = New System.Drawing.Size(227, 98)
        Me.PerplexGroupBox2.TabIndex = 10
        Me.PerplexGroupBox2.Text = "                          Config"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(141, 55)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(76, 20)
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.Text = "RépertoireFTP"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(141, 33)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(76, 20)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = "Motdepasse"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(19, 56)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(76, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "User"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(18, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(76, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Hôte"
        '
        'PerplexControlBox1
        '
        Me.PerplexControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.PerplexControlBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.PerplexControlBox1.Location = New System.Drawing.Point(221, 3)
        Me.PerplexControlBox1.Name = "PerplexControlBox1"
        Me.PerplexControlBox1.Size = New System.Drawing.Size(51, 25)
        Me.PerplexControlBox1.TabIndex = 9
        Me.PerplexControlBox1.Text = "PerplexControlBox1"
        '
        'PerplexGroupBox1
        '
        Me.PerplexGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.PerplexGroupBox1.Controls.Add(Me.Label2)
        Me.PerplexGroupBox1.Controls.Add(Me.PictureBox1)
        Me.PerplexGroupBox1.Controls.Add(Me.Label1)
        Me.PerplexGroupBox1.Location = New System.Drawing.Point(29, 62)
        Me.PerplexGroupBox1.Name = "PerplexGroupBox1"
        Me.PerplexGroupBox1.Size = New System.Drawing.Size(227, 90)
        Me.PerplexGroupBox1.TabIndex = 5
        Me.PerplexGroupBox1.Text = "                         Derniers fichier uploader"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(56, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(18, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(56, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'PerplexProgressBar1
        '
        Me.PerplexProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.PerplexProgressBar1.Location = New System.Drawing.Point(29, 34)
        Me.PerplexProgressBar1.Maximum = 100
        Me.PerplexProgressBar1.Name = "PerplexProgressBar1"
        Me.PerplexProgressBar1.ShowPercentage = False
        Me.PerplexProgressBar1.Size = New System.Drawing.Size(227, 25)
        Me.PerplexProgressBar1.TabIndex = 4
        Me.PerplexProgressBar1.Text = "PerplexProgressBar1"
        Me.PerplexProgressBar1.Value = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(99, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 51)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Valider"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PerplexLabel1
        '
        Me.PerplexLabel1.BackColor = System.Drawing.Color.Transparent
        Me.PerplexLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.PerplexLabel1.Location = New System.Drawing.Point(141, 79)
        Me.PerplexLabel1.Name = "PerplexLabel1"
        Me.PerplexLabel1.Size = New System.Drawing.Size(76, 13)
        Me.PerplexLabel1.TabIndex = 5
        Me.PerplexLabel1.Text = "Ex :/www/"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.PerplexTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.PerplexTheme1.ResumeLayout(False)
        Me.PerplexGroupBox2.ResumeLayout(False)
        Me.PerplexGroupBox2.PerformLayout()
        Me.PerplexGroupBox1.ResumeLayout(False)
        Me.PerplexGroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PerplexTheme1 As Uploadup.PerplexTheme
    Friend WithEvents PerplexProgressBar1 As Uploadup.PerplexProgressBar
    Friend WithEvents PerplexGroupBox1 As Uploadup.PerplexGroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PerplexControlBox1 As Uploadup.PerplexControlBox
    Friend WithEvents PerplexGroupBox2 As Uploadup.PerplexGroupBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PerplexLabel1 As Uploadup.PerplexLabel

End Class
