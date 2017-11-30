Public Class Form2menuConnexion
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New System.Drawing.Size(360, 680)
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox1.Text = "") Then
            MessageBox.Show("Veuillez entrez un nom d'utilisateur.")

        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Veuillez entrez un mot de passe.")
        ElseIf Not TextBox1.Text = "Batman" And Not TextBox1.Text = "batman" Then
            MessageBox.Show("Votre nom d'utilisateur est incorrect.")
        ElseIf Not TextBox2.Text = "batman" Then
            MessageBox.Show("Votre mot de passe est incorrect.")
        Else
            MessageBox.Show("Vous êtes connecté")
            Me.Hide()
            Form5.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1menu.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class