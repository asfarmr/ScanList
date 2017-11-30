Imports System.Text


Public Class Form6Maps

    Public MesListes As New List(Of List(Of String))
    Public MaListe As List(Of String)

    Private Sub Form6Maps_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New System.Drawing.Size(360, 680)
        Me.FormBorderStyle = FormBorderStyle.None

    End Sub

    Private Sub Chercher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chercher.Click
        Dim adresse As String = TextBox_adresse.Text
        Try
            Dim queryAdresse As New StringBuilder
            queryAdresse.Append("http://maps.google.com/maps?q=")
            If TextBox_adresse.Text <> String.Empty Then
                queryAdresse.Append(adresse + "," & "+")
            End If
            Me.WebBrowser1.Navigate(queryAdresse.ToString)

        Catch ex As Exception
            MessageBox.Show("Erreur lors de la récupération")
        End Try

    End Sub

    Private Sub btnCreerListe_Click(sender As Object, e As EventArgs) Handles btnCreerListe.Click
        Dim f7 As New Form7GererListe
        Dim nomL As String
        nomL = InputBox("Indiquez un nom pour la liste : ", vbOKCancel)
        If nomL = " " Or nomL = "" Then
            MsgBox("Veuillez indiquer un nom valide !", MsgBoxStyle.Critical)
            Return
        Else
            MaListe = New List(Of String)
            MaListe.Add(nomL) ' Réserve la première case au nom de la liste
            MesListes.Add(MaListe)
            f7.InitialiserListbox()
            f7.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub btnModifierListe_Click(sender As Object, e As EventArgs) Handles btnModifierListe.Click
        Dim f8 As New Form8ChargerListe
        f8.AfficherLesListes()
        f8.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class