Public Class Form4Inscription
    Private Sub Form4Inscription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New System.Drawing.Size(360, 680)
        Me.FormBorderStyle = FormBorderStyle.None

    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If (TextBox8.Text = "") Then
            MessageBox.Show("Veuillez saisir un identifiant.")
        ElseIf TextBox7.Text = "" Then
            MessageBox.Show("Veuillez entrez un mot de passe.")

        ElseIf (TextBox6.Text = "") Then
            MessageBox.Show("Veuillez confirmez votre mot de passe.")
        ElseIf TextBox5.Text = "" Then
            MessageBox.Show("Veuillez entrez une adresse mail valide.")

        Else
            MsgBox(" compte crée", MsgBoxStyle.Information, "Create")
            Form2menuConnexion.Show()
            Me.Hide()
        End If


    End Sub
End Class



