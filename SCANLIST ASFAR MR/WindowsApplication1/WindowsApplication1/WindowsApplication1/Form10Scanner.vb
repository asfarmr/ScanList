Public Class Form10Scanner
    Private Sub Form10Scanner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New System.Drawing.Size(360, 680)
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form7GererListe.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form7GererListe.Show()
        Me.Hide()

    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs) Handles DomainUpDown1.SelectedItemChanged
        If IsNumeric(DomainUpDown1.Text) Then
            Dim qte As Integer
            qte = DomainUpDown1.Text
            lblPrix.Text = qte * 5
            lblPrix.Text += " €"
        End If
    End Sub
End Class