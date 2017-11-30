<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form8ChargerListe
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lstMesListes = New System.Windows.Forms.ListBox()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.base1
        Me.PictureBox1.Location = New System.Drawing.Point(-6, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(459, 704)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(337, 185)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Retour"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnInfo
        '
        Me.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInfo.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfo.Location = New System.Drawing.Point(-6, 185)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(347, 33)
        Me.btnInfo.TabIndex = 2
        Me.btnInfo.Text = "Sélectionner la liste à modifier"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(3, 670)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(338, 34)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Charger"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lstMesListes
        '
        Me.lstMesListes.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMesListes.FormattingEnabled = True
        Me.lstMesListes.ItemHeight = 23
        Me.lstMesListes.Location = New System.Drawing.Point(12, 224)
        Me.lstMesListes.Name = "lstMesListes"
        Me.lstMesListes.Size = New System.Drawing.Size(329, 372)
        Me.lstMesListes.TabIndex = 12
        '
        'btnSupprimer
        '
        Me.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupprimer.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupprimer.Location = New System.Drawing.Point(337, 670)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(116, 34)
        Me.btnSupprimer.TabIndex = 13
        Me.btnSupprimer.Text = "Supprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = True
        '
        'Form8ChargerListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 744)
        Me.Controls.Add(Me.btnSupprimer)
        Me.Controls.Add(Me.lstMesListes)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form8ChargerListe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form8ChargerListe"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnInfo As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents lstMesListes As ListBox
    Friend WithEvents btnSupprimer As Button
End Class
