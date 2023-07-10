Imports System.Xml.XPath

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim msginicial1 As String = "Tenta acertar no número escondido !!"
        Dim msginicial2 As String = "Clica em Novo Jogo Escolhe um número,"
        Dim msginicial3 As String = "e Verifica se o teu número foi o sorteado!"
        MsgBox(msginicial1 & vbCrLf & msginicial2 & vbCrLf & msginicial3)
        Me.Show()

        BtnNovoJogo.Enabled = True
        BtnVerificar.Enabled = False
        NudNum.Enabled = False
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Close()
    End Sub

    Private Sub BtnVerificar_Click(sender As Object, e As EventArgs) Handles BtnVerificar.Click
        Dim NumSorteado As New Random()
        Dim NudMun As Integer = CInt(NudNum.Value) 'Maneira que consegui arranjar para extrair os numeros
        Dim contador As Integer = 8 'Contador de Tentativas'
        Dim parabens As Boolean = False 'Variavel booleana para verificar se acertou no número
        Dim resultado As String = ""

        For i As Integer = 1 To NudMun
            Dim num As Integer = NumSorteado.Next(1, 101)
            resultado = num.ToString() & " "

            If num = NudMun Then 'Estrutura If simples para a condição de acerto
                parabens = True
            End If 'Fim de If também podiamos usar o Exit For
        Next

        If parabens Then 'Estrutura If para condição de acerto ou falha do número sorteado
            LblMensagem.Text = "Parabéns!" & vbCrLf & " Acertas-te no número sorteado!" 'Mensagem de congrats
        Else
            contador -= 1 'Diminuir o número de tentativas no contador
            LblMensagem.Text = "Falhas-te!" & vbCrLf & "Tens mais" & contador & "tentativas!" ' Mensagem de fail
        End If

        LblNumeroSorteado.Text = resultado

        BtnVerificar.Enabled = False
        BtnNovoJogo.Enabled = True
        BtnSair.Enabled = True
    End Sub

    Private Sub BtnNovoJogo_Click(sender As Object, e As EventArgs) Handles BtnNovoJogo.Click
        BtnNovoJogo.Enabled = False
        BtnVerificar.Enabled = True
        NudNum.Enabled = True
        LblNumeroSorteado.Text = ""
    End Sub
End Class
