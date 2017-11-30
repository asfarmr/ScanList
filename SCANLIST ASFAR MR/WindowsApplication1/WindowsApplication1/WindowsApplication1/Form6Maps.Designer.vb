<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6Maps
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6Maps))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Chercher = New System.Windows.Forms.Button()
        Me.adresse = New System.Windows.Forms.Label()
        Me.TextBox_adresse = New System.Windows.Forms.TextBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCreerListe = New System.Windows.Forms.Button()
        Me.btnModifierListe = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, -5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(553, 732)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 317)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Panel1.Controls.Add(Me.Chercher)
        Me.SplitContainer1.Panel1.Controls.Add(Me.adresse)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox_adresse)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.WebBrowser1)
        Me.SplitContainer1.Size = New System.Drawing.Size(530, 314)
        Me.SplitContainer1.SplitterDistance = 176
        Me.SplitContainer1.TabIndex = 10
        '
        'Chercher
        '
        Me.Chercher.Location = New System.Drawing.Point(0, 178)
        Me.Chercher.Name = "Chercher"
        Me.Chercher.Size = New System.Drawing.Size(109, 23)
        Me.Chercher.TabIndex = 11
        Me.Chercher.Text = "Chercher"
        Me.Chercher.UseVisualStyleBackColor = True
        '
        'adresse
        '
        Me.adresse.AutoSize = True
        Me.adresse.Location = New System.Drawing.Point(3, 54)
        Me.adresse.Name = "adresse"
        Me.adresse.Size = New System.Drawing.Size(68, 17)
        Me.adresse.TabIndex = 1
        Me.adresse.Text = "Adresse :"
        '
        'TextBox_adresse
        '
        Me.TextBox_adresse.Location = New System.Drawing.Point(6, 91)
        Me.TextBox_adresse.Name = "TextBox_adresse"
        Me.TextBox_adresse.Size = New System.Drawing.Size(124, 22)
        Me.TextBox_adresse.TabIndex = 0
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(350, 314)
        Me.WebBrowser1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(24, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(414, 34)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Rechercher les magasins à proximité de chez vous en saisissant" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                 " &
    "                  votre adresse postale"
        '
        'btnCreerListe
        '
        Me.btnCreerListe.BackColor = System.Drawing.Color.Transparent
        Me.btnCreerListe.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreerListe.Location = New System.Drawing.Point(4, 700)
        Me.btnCreerListe.Name = "btnCreerListe"
        Me.btnCreerListe.Size = New System.Drawing.Size(226, 83)
        Me.btnCreerListe.TabIndex = 12
        Me.btnCreerListe.Text = "Créer une liste"
        Me.btnCreerListe.UseVisualStyleBackColor = False
        '
        'btnModifierListe
        '
        Me.btnModifierListe.BackColor = System.Drawing.Color.Transparent
        Me.btnModifierListe.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifierListe.Location = New System.Drawing.Point(236, 700)
        Me.btnModifierListe.Name = "btnModifierListe"
        Me.btnModifierListe.Size = New System.Drawing.Size(218, 83)
        Me.btnModifierListe.TabIndex = 13
        Me.btnModifierListe.Text = "Modifier une liste"
        Me.btnModifierListe.UseVisualStyleBackColor = False
        '
        'Form6Maps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(565, 828)
        Me.Controls.Add(Me.btnModifierListe)
        Me.Controls.Add(Me.btnCreerListe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Form6Maps"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form6Maps"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents adresse As Label
    Friend WithEvents TextBox_adresse As TextBox
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Chercher As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCreerListe As Button
    Friend WithEvents btnModifierListe As Button
End Class
