

Public Class Form1
    Dim Stand(10) As Carro 'instancia para guardar os carros'array
    Dim contador As Integer
    Dim Erro As Integer
    Private Sub ValidarCarro()
        Erro = 0
        If TxtMarca.Text = "" Then
            MsgBox("Tem de Inserir a Marca do Carro")
            Erro = 1
        End If

        Erro = 0
        If TxtModelo.Text = "" Then
            MsgBox("Tem que inserir o Modelo do Carro")
            Erro = 1
        End If

        Erro = 0
        If TxtCombustivel.Text = "" Then
            MsgBox("Tem que inserir o combustivel")
            Erro = 1
        End If

        Erro = 0
        If TxtPreco.Text = "" Then
            MsgBox("Tem que inserir o Preço")
            Erro = 1
        End If
    End Sub

    Private Sub Limpar()
        TxtMarca.Text = ""
        TxtModelo.Text = ""
        TxtCombustivel.Text = ""
        TxtPreco.Text = ""

        LstMarca.Items.Clear()
        LstModelo.Items.Clear()
        LstCombustivel.Items.Clear()
        LstPreco.Items.Clear()
    End Sub

    Private Sub Listar()
        Limpar()
        For i = 0 To contador - 1
            LstMarca.Items.Add(Stand(i).Marca)
            LstModelo.Items.Add(Stand(i).Modelo)
            LstCombustivel.Items.Add(Stand(i).Combustivel)
            LstPreco.Items.Add(Stand(i).Preco)
        Next
    End Sub

    Private Structure Carro
        Public Marca As String
        Public Modelo As String
        Public Combustivel As String
        Public Preco As Single
    End Structure





    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Close()
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        TxtMarca.Text = ""
        TxtModelo.Text = ""
        TxtCombustivel.Text = ""
        TxtPreco.Text = ""

        LstMarca.Items.Clear()
        LstModelo.Items.Clear()
        LstCombustivel.Items.Clear()
        LstPreco.Items.Clear()
    End Sub

    Private Sub BtnListar_Click(sender As Object, e As EventArgs) Handles BtnListar.Click
        Listar()
    End Sub

    Private Sub BtnInserir_Click(sender As Object, e As EventArgs) Handles BtnInserir.Click
        ValidarCarro()
        If Erro = 0 Then
            Stand(contador).Marca = TxtMarca.Text
            Stand(contador).Modelo = TxtModelo.Text
            Stand(contador).Combustivel = TxtCombustivel.Text
            Stand(contador).Preco = CSng(TxtPreco.Text)

            contador += 1
            Listar()
        End If
    End Sub
End Class
