Public Class FormLogo
    Private Sub FormLogo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim xPos As Integer = (Me.Width - Label1.Width) / 2
        ' Menghitung posisi tengah vertikal
        Dim yPos As Integer = ((Me.Height - Label1.Height) / 2) - 100

        ' Menetapkan posisi Label
        Label1.Location = New Point(xPos, yPos)
    End Sub
End Class