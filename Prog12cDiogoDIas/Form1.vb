Public Class Form1
    Private Sub BtnSortear_Click(sender As Object, e As EventArgs) Handles BtnSortearNumeros.Click
        Dim NumSorteado As New Random()
        Dim ValorMax As Integer = Integer.Parse(TxtValorMax.Text)
        Dim NumeroDeValores As Integer = Integer.Parse(TxtNúmeroDeValores.Text)
        Dim result As String = ""

        For i = 1 To NumeroDeValores
            Dim num As Integer = NumSorteado.Next(ValorMax) + 1
            result &= num & " - "
        Next

        result = result.TrimEnd(" - ".ToCharArray())
        TxtNúmerosSorteados.Text = result
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Close()
    End Sub
End Class
