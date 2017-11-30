Public Class Acceuil

    Dim f1 As New Form1menu
    Dim MesListes As New List(Of List(Of String))
    Dim MaListe As New List(Of String)

    Private Sub Acceuil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Size = New System.Drawing.Size(360, 680)
        FormBorderStyle = FormBorderStyle.None
        StartPosition = FormStartPosition.CenterScreen
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Hide()
            f1.Show()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class