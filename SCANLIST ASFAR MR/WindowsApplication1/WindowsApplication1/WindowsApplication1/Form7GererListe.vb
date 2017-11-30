Public Class Form7GererListe

    Private Sub Form7GererListe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New System.Drawing.Size(360, 680)
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub

    Public Sub InitialiserListbox()
        If MesListesVide() = True Then
            lstVosListes.Items.Add("Aucune liste, veuillez en créer une !")
        Else
            For Each Liste In Form6Maps.MesListes
                lstVosListes.Items.Add(Liste.Item(0))
                If Liste.Count > 2 Then
                    For i = 1 To Liste.Count
                        lstProduits.Items.Add(Liste.Item(i))
                    Next
                End If
            Next
        End If
    End Sub

    Public Function MesListesVide()
        If Form6Maps.MesListes.Count = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnAjoutProduit_Click(sender As Object, e As EventArgs) Handles btnAjoutProduit.Click
        Dim prod As String
        Dim numListe = 0

        prod = InputBox("Indiquez le nom de votre produit", vbOKCancel)
        If prod <> "" And prod <> " " Then
            lstProduits.Items.Add(prod)

        End If
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        If lstProduits.SelectedItem Is Nothing Then
            MsgBox("Sélectionnez tout d'abord un produit.")
        Else
            lstProduits.Items.Remove(lstProduits.SelectedItem)
        End If
    End Sub

    Private Sub btnAccueil_Click(sender As Object, e As EventArgs) Handles btnAccueil.Click
        Form6Maps.Show()
        Me.Hide()

    End Sub

    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        Form10Scanner.Show()

        Me.Hide()

    End Sub

    Private Sub btnFinaliser_Click(sender As Object, e As EventArgs) Handles btnFinaliser.Click
        Form11QRcode.Show()
        Me.Hide()

    End Sub
End Class