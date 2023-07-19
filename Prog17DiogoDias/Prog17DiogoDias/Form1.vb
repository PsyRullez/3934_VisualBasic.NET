Public Class Form1

    Private Sub Listar()
        Dim numeros As New List(Of Integer)

        LstNumeros.Items.Clear()
        For i = 0 To 9
            LstNumeros.Items.Add(numeros(i))
        Next
    End Sub

    Private Function Repetidos() As Boolean
        Dim Temp As Integer
        Dim VectorNumeros(9) As Integer

        For i = 9 To 0 Step -1
            If i >= 1 Then
                If VectorNumeros(i) < VectorNumeros(i - 1) Then
                    Temp = VectorNumeros(i)
                    VectorNumeros(i) = VectorNumeros(i - 1)
                    VectorNumeros(i - 1) = Temp
                    i = 10
                End If
            End If
        Next
    End Function

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        LstNumeros.Items.Clear()
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Close()
    End Sub

    Private Sub BtnSortear_Click(sender As Object, e As EventArgs) Handles BtnSortear.Click
        Dim random As New Random()
        Dim numeros As New List(Of Integer)

        ' Sorteio dos números
        While numeros.Count < 10
            Dim num As Integer = random.Next(1, 51)
            If Not numeros.Contains(num) Then
                numeros.Add(num)
                LstNumeros.Items.Add(num)
            End If
        End While

    End Sub

    Private Sub BtnOrdenar_Click(sender As Object, e As EventArgs) Handles BtnOrdenar.Click
        Dim numerosOrdenados As New List(Of Integer)

        For Each item As Integer In LstNumeros.Items
            numerosOrdenados.Add(item)
        Next

        numerosOrdenados.Sort()

        LstNumeros.Items.Clear()

        For Each numero As Integer In numerosOrdenados
            LstNumeros.Items.Add(numero)
        Next
    End Sub
End Class
