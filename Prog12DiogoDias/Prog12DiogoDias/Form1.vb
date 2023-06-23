Public Class Form1
    Private Sub BtnSortear_Click(sender As Object, e As EventArgs) Handles BtnSortear.Click
        Dim NumSorteado As New Random
        Dim num As Integer = NumSorteado.Next(50) + 1
        Randomize()
        LblNumeroSorteado.Text = num.ToString()
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Close()
    End Sub
End Class
