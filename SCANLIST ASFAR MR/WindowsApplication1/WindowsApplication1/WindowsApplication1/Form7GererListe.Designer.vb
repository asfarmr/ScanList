<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form7GererListe
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
        Me.lstVosListes = New System.Windows.Forms.ListBox()
        Me.lstProduits = New System.Windows.Forms.ListBox()
        Me.lblVosListes = New System.Windows.Forms.Label()
        Me.lblProduits = New System.Windows.Forms.Label()
        Me.btnScan = New System.Windows.Forms.Button()
        Me.btnFinaliser = New System.Windows.Forms.Button()
        Me.btnAccueil = New System.Windows.Forms.Button()
        Me.btnAjoutProduit = New System.Windows.Forms.Button()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstVosListes
        '
        Me.lstVosListes.FormattingEnabled = True
        Me.lstVosListes.ItemHeight = 16
        Me.lstVosListes.Location = New System.Drawing.Point(12, 78)
        Me.lstVosListes.Name = "lstVosListes"
        Me.lstVosListes.Size = New System.Drawing.Size(437, 212)
        Me.lstVosListes.TabIndex = 3
        '
        'lstProduits
        '
        Me.lstProduits.FormattingEnabled = True
        Me.lstProduits.ItemHeight = 16
        Me.lstProduits.Location = New System.Drawing.Point(12, 344)
        Me.lstProduits.Name = "lstProduits"
        Me.lstProduits.Size = New System.Drawing.Size(437, 212)
        Me.lstProduits.TabIndex = 4
        '
        'lblVosListes
        '
        Me.lblVosListes.AutoSize = True
        Me.lblVosListes.Location = New System.Drawing.Point(206, 19)
        Me.lblVosListes.Name = "lblVosListes"
        Me.lblVosListes.Size = New System.Drawing.Size(68, 17)
        Me.lblVosListes.TabIndex = 5
        Me.lblVosListes.Text = "Vos listes"
        '
        'lblProduits
        '
        Me.lblProduits.AutoSize = True
        Me.lblProduits.Location = New System.Drawing.Point(206, 306)
        Me.lblProduits.Name = "lblProduits"
        Me.lblProduits.Size = New System.Drawing.Size(60, 17)
        Me.lblProduits.TabIndex = 6
        Me.lblProduits.Text = "Produits"
        '
        'btnScan
        '
        Me.btnScan.Location = New System.Drawing.Point(156, 687)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(184, 40)
        Me.btnScan.TabIndex = 7
        Me.btnScan.Text = "Scanner"
        Me.btnScan.UseVisualStyleBackColor = True
        '
        'btnFinaliser
        '
        Me.btnFinaliser.Location = New System.Drawing.Point(156, 735)
        Me.btnFinaliser.Name = "btnFinaliser"
        Me.btnFinaliser.Size = New System.Drawing.Size(184, 42)
        Me.btnFinaliser.TabIndex = 8
        Me.btnFinaliser.Text = "Finaliser la commande"
        Me.btnFinaliser.UseVisualStyleBackColor = True
        '
        'btnAccueil
        '
        Me.btnAccueil.Location = New System.Drawing.Point(12, 754)
        Me.btnAccueil.Name = "btnAccueil"
        Me.btnAccueil.Size = New System.Drawing.Size(75, 23)
        Me.btnAccueil.TabIndex = 9
        Me.btnAccueil.Text = "Retour"
        Me.btnAccueil.UseVisualStyleBackColor = True
        '
        'btnAjoutProduit
        '
        Me.btnAjoutProduit.Location = New System.Drawing.Point(156, 591)
        Me.btnAjoutProduit.Name = "btnAjoutProduit"
        Me.btnAjoutProduit.Size = New System.Drawing.Size(184, 42)
        Me.btnAjoutProduit.TabIndex = 10
        Me.btnAjoutProduit.Text = "Ajouter un produit"
        Me.btnAjoutProduit.UseVisualStyleBackColor = True
        '
        'btnSupprimer
        '
        Me.btnSupprimer.Location = New System.Drawing.Point(156, 639)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(184, 42)
        Me.btnSupprimer.TabIndex = 11
        Me.btnSupprimer.Text = "Supprimer un produit"
        Me.btnSupprimer.UseVisualStyleBackColor = True
        '
        'Form7GererListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 834)
        Me.Controls.Add(Me.btnSupprimer)
        Me.Controls.Add(Me.btnAjoutProduit)
        Me.Controls.Add(Me.btnAccueil)
        Me.Controls.Add(Me.btnFinaliser)
        Me.Controls.Add(Me.btnScan)
        Me.Controls.Add(Me.lblProduits)
        Me.Controls.Add(Me.lblVosListes)
        Me.Controls.Add(Me.lstProduits)
        Me.Controls.Add(Me.lstVosListes)
        Me.Name = "Form7GererListe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form7GererListe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstVosListes As ListBox
    Friend WithEvents lstProduits As ListBox
    Friend WithEvents lblVosListes As Label
    Friend WithEvents lblProduits As Label
    Friend WithEvents btnScan As Button
    Friend WithEvents btnFinaliser As Button
    Friend WithEvents btnAccueil As Button
    Friend WithEvents btnAjoutProduit As Button
    Friend WithEvents btnSupprimer As Button
End Class
