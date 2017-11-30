<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10Scanner
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DomainUpDown1 = New System.Windows.Forms.DomainUpDown()
        Me.lblPrix = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(2, 723)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(233, 64)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Retour"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(241, 723)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(221, 64)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Valider"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.eferferg
        Me.PictureBox2.Location = New System.Drawing.Point(2, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(460, 787)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomainUpDown1.Items.Add("1")
        Me.DomainUpDown1.Items.Add("2")
        Me.DomainUpDown1.Items.Add("3")
        Me.DomainUpDown1.Items.Add("4")
        Me.DomainUpDown1.Items.Add("5")
        Me.DomainUpDown1.Items.Add("6")
        Me.DomainUpDown1.Items.Add("7")
        Me.DomainUpDown1.Items.Add("8")
        Me.DomainUpDown1.Items.Add("9")
        Me.DomainUpDown1.Items.Add("10")
        Me.DomainUpDown1.Items.Add("11")
        Me.DomainUpDown1.Items.Add("12")
        Me.DomainUpDown1.Items.Add("13")
        Me.DomainUpDown1.Items.Add("14")
        Me.DomainUpDown1.Items.Add("15")
        Me.DomainUpDown1.Items.Add("16")
        Me.DomainUpDown1.Items.Add("17")
        Me.DomainUpDown1.Items.Add("18")
        Me.DomainUpDown1.Items.Add("19")
        Me.DomainUpDown1.Items.Add("20")
        Me.DomainUpDown1.Location = New System.Drawing.Point(115, 551)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(120, 25)
        Me.DomainUpDown1.TabIndex = 7
        Me.DomainUpDown1.Text = "Quantité"
        '
        'lblPrix
        '
        Me.lblPrix.AutoSize = True
        Me.lblPrix.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrix.Location = New System.Drawing.Point(150, 590)
        Me.lblPrix.Name = "lblPrix"
        Me.lblPrix.Size = New System.Drawing.Size(54, 28)
        Me.lblPrix.TabIndex = 8
        Me.lblPrix.Text = "0,0 €"
        '
        'Form10Scanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 789)
        Me.Controls.Add(Me.lblPrix)
        Me.Controls.Add(Me.DomainUpDown1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Form10Scanner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form10Scanner"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DomainUpDown1 As DomainUpDown
    Friend WithEvents lblPrix As Label
End Class
