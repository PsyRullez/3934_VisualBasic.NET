Public Class Form1
    Private Sub BtnSortear_Click(sender As Object, e As EventArgs) Handles BtnSortear.Click
        Dim NumSorteado As New Random()
        Dim numeros As New List(Of Integer)

        ' Sorteio dos números
        While numeros.Count < 5
            Dim num As Integer = NumSorteado.Next(1, 51)
            If Not numeros.Contains(num) Then
                numeros.Add(num)
            End If
        End While

        ' Sorteio das estrelas
        Dim estrelas As New List(Of Integer)
        While estrelas.Count < 2
            Dim estrela As Integer = NumSorteado.Next(1, 13)
            If Not estrelas.Contains(estrela) Then
                estrelas.Add(estrela)
            End If
        End While

        ' Exibição dos números e estrelas sorteados
        TxtNumeros.Text = String.Join(Environment.NewLine, numeros)
        TxtEstrelas.Text = String.Join(Environment.NewLine, estrelas)
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Close()
    End Sub
End Class
