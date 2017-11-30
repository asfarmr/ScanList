Public Class Form8ChargerListe


    Private Sub Form8ChargerListe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New System.Drawing.Size(360, 680)
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form7GererListe.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form7GererListe.InitialiserListbox()
        Form7GererListe.Show()

        Me.Hide()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Public Sub AfficherLesListes()
        If Form7GererListe.MesListesVide() = False Then
            For Each Liste In Form6Maps.MesListes
                lstMesListes.Items.Add(Liste.Item(0))

            Next
        End If
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        If lstMesListes.SelectedItem Is Nothing Then
            MsgBox("Sélectionnez d'abord une liste.")
        Else
            lstMesListes.Items.Remove(lstMesListes.SelectedItem)
            '    For Each Liste In Form6Maps.MesListes
            '        If Liste.Item(0) = lstMesListes.SelectedIndex Then
            '            Form6Maps.MesListes.Remove(Liste)
            '        End If
            '    Next
        End If
    End Sub
End Class