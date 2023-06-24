Public Class Form1
    Private Sub BtnSortear_Click(sender As Object, e As EventArgs) Handles BtnSortear.Click
        Dim NumSorteado As New Random
        Dim num As Integer
        Dim result As String = ""

        For i = 1 To 7
            num = NumSorteado.Next(50) + 1
            result &= num & " - "
        Next

        result = result.TrimEnd(" - ".ToCharArray())
        LblNumerosSorteados.Text = result
    End Sub


    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Close()
    End Sub
End Class
