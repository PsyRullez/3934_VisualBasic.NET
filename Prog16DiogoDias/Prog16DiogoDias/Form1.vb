Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub BtnSortear_Click(sender As Object, e As EventArgs) Handles BtnSortear.Click
        Dim numerosSorteados As New List(Of Integer)
        Dim estrelasSorteadas As New List(Of Integer)
        Dim random As New Random()

        ' Sorteio dos números
        While numerosSorteados.Count < 5
            Dim num As Integer = random.Next(1, 51)
            If Not numerosSorteados.Contains(num) Then
                numerosSorteados.Add(num)
            End If
        End While

        'Ordena os numeros sorteados
        numerosSorteados.Sort()

        ' Sorteio das estrelas
        While estrelasSorteadas.Count < 2
            Dim estrela As Integer = random.Next(1, 13)
            If Not estrelasSorteadas.Contains(estrela) Then
                estrelasSorteadas.Add(estrela)
            End If
        End While

        'Ordena os estrelas sorteados
        estrelasSorteadas.Sort()

        ' Adiciona os números sorteados na caixa de lista de números
        For Each numero As Integer In numerosSorteados
            LstNumeros.Items.Add(numero)
        Next

        ' Adiciona as estrelas sorteadas na caixa de lista de estrelas
        For Each estrela As Integer In estrelasSorteadas
            LstEstrelas.Items.Add(estrela)
        Next
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        LstEstrelas.Items.Clear()
        LstNumeros.Items.Clear()
    End Sub
End Class
