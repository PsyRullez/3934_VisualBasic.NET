Imports System.Data.OleDb


Public Class Prog22DiogoDias

    Dim myconnect As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\TicTacToe_db.accdb")

    Private jogadoresDefinidos As Boolean = False
    Private jogador1 As String
    Private jogador2 As String
    Private pontuacaoJogador1 As Integer = 0
    Private pontuacaoJogador2 As Integer = 0
    Private turnoJogador1 As Boolean = True ' Começa com o jogador 1
    Private Jogo(10) As Integer
    Private somas(8) As Integer

    Private Function IsUsernameExists(text As Object) As Boolean
        Throw New NotImplementedException()
    End Function

    Private Sub Verificar()
        ' Verificar se algum jogador venceu
        ' Horizontal
        somas(1) = Jogo(1) + Jogo(2) + Jogo(3)
        somas(2) = Jogo(4) + Jogo(5) + Jogo(6)
        somas(3) = Jogo(7) + Jogo(8) + Jogo(9)
        ' Vertical
        somas(4) = Jogo(1) + Jogo(4) + Jogo(7)
        somas(5) = Jogo(2) + Jogo(5) + Jogo(8)
        somas(6) = Jogo(3) + Jogo(6) + Jogo(9)
        ' Obliquas
        somas(7) = Jogo(1) + Jogo(5) + Jogo(9)
        somas(8) = Jogo(3) + Jogo(5) + Jogo(7)

        For i = 1 To 8
            If somas(i) = 3 Then
                LblPlayer.Text = "Ganhou o jogador: " & jogador1
                terminar()
            End If
            If somas(i) = 30 Then
                LblPlayer.Text = "Ganhou o jogador: " & jogador2
                terminar()
            End If

        Next




        If pontuacaoJogador1 = 3 Then
            LblPlayer.Text = jogador1 & " venceu!"
        ElseIf pontuacaoJogador2 = 30 Then
            LblPlayer.Text = jogador2 & " venceu!"
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub terminar()
        Btn1.Enabled = False
        Btn2.Enabled = False
        Btn3.Enabled = False
        Btn4.Enabled = False
        Btn5.Enabled = False
        Btn6.Enabled = False
        Btn7.Enabled = False
        Btn8.Enabled = False
        Btn9.Enabled = False
    End Sub


    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        'Botoes TicTacToe ON
        Btn1.Enabled = True
        Btn2.Enabled = True
        Btn3.Enabled = True
        Btn4.Enabled = True
        Btn5.Enabled = True
        Btn6.Enabled = True
        Btn7.Enabled = True
        Btn8.Enabled = True
        Btn9.Enabled = True

        If Not jogadoresDefinidos Then
            ' Solicitar o nome do Jogador 1
            jogador1 = InputBox("Digite o nome do Jogador 1:", "Nome do Jogador 1")

            ' Solicitar o nome do Jogador 2
            jogador2 = InputBox("Digite o nome do Jogador 2:", "Nome do Jogador 2")

            ' Verificar se os nomes foram inseridos e exibir uma mensagem
            If Not String.IsNullOrWhiteSpace(jogador1) AndAlso Not String.IsNullOrWhiteSpace(jogador2) Then
                MessageBox.Show("Nomes dos jogadores foram definidos:" & vbCrLf &
                            "Jogador 1: " & jogador1 & vbCrLf &
                            "Jogador 2: " & jogador2, "Nomes dos Jogadores")

                ' Definir a flag jogadoresDefinidos como True para não pedir nomes novamente
                jogadoresDefinidos = True
            Else
                MessageBox.Show("Por favor, insira nomes válidos para ambos os jogadores.", "Erro")
            End If
        End If
    End Sub

    Private Sub Prog22DiogoDias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TicTacToe Botoes OFF
        Btn1.Enabled = False
        Btn2.Enabled = False
        Btn3.Enabled = False
        Btn4.Enabled = False
        Btn5.Enabled = False
        Btn6.Enabled = False
        Btn7.Enabled = False
        Btn8.Enabled = False
        Btn9.Enabled = False
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        If Btn1.Text = "" Then ' Verifica se o botão está vazio
            If turnoJogador1 Then
                Btn1.Text = "O"
                Jogo(1) = 1
            Else
                Btn1.Text = "X"
                Jogo(1) = 10
            End If

            ' Alternar o turno
            turnoJogador1 = Not turnoJogador1

            ' Desativar o botão após ser clicado
            Btn1.Enabled = False

            Verificar()
            LblPlayer.Focus()
        End If
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        If Btn2.Text = "" Then ' Verifica se o botão está vazio
            If turnoJogador1 Then
                Btn2.Text = "O"
                Jogo(2) = 1
            Else
                Btn2.Text = "X"
                Jogo(2) = 10
            End If

            ' Alternar o turno
            turnoJogador1 = Not turnoJogador1

            ' Desativar o botão após ser clicado
            Btn2.Enabled = False
            Verificar()
        End If

    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        If Btn3.Text = "" Then ' Verifica se o botão está vazio
            If turnoJogador1 Then
                Btn3.Text = "O"
                Jogo(3) = 1
            Else
                Btn3.Text = "X"
                Jogo(3) = 10
            End If

            ' Alternar o turno
            turnoJogador1 = Not turnoJogador1

            ' Desativar o botão após ser clicado
            Btn3.Enabled = False
            Verificar()
        End If
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        If Btn4.Text = "" Then ' Verifica se o botão está vazio
            If turnoJogador1 Then
                Btn4.Text = "O"
                Jogo(4) = 1
            Else
                Btn4.Text = "X"
                Jogo(4) = 10
            End If

            ' Alternar o turno
            turnoJogador1 = Not turnoJogador1

            ' Desativar o botão após ser clicado
            Btn4.Enabled = False
            Verificar()
        End If
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        If Btn5.Text = "" Then ' Verifica se o botão está vazio
            If turnoJogador1 Then
                Btn5.Text = "O"
                Jogo(5) = 1
            Else
                Btn5.Text = "X"
                Jogo(5) = 10
            End If

            ' Alternar o turno
            turnoJogador1 = Not turnoJogador1

            ' Desativar o botão após ser clicado
            Btn5.Enabled = False
            Verificar()
        End If
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        If Btn6.Text = "" Then ' Verifica se o botão está vazio
            If turnoJogador1 Then
                Btn6.Text = "O"
                Jogo(6) = 1
            Else
                Btn6.Text = "X"
                Jogo(6) = 10
            End If

            ' Alternar o turno
            turnoJogador1 = Not turnoJogador1

            ' Desativar o botão após ser clicado
            Btn6.Enabled = False
            Verificar()
        End If
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        If Btn7.Text = "" Then ' Verifica se o botão está vazio
            If turnoJogador1 Then
                Btn7.Text = "O"
                Jogo(7) = 1
            Else
                Btn7.Text = "X"
                Jogo(7) = 10
            End If

            ' Alternar o turno
            turnoJogador1 = Not turnoJogador1

            ' Desativar o botão após ser clicado
            Btn7.Enabled = False
            Verificar()
        End If
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        If Btn8.Text = "" Then ' Verifica se o botão está vazio
            If turnoJogador1 Then
                Btn8.Text = "O"
                Jogo(8) = 1
            Else
                Btn8.Text = "X"
                Jogo(8) = 10
            End If

            ' Alternar o turno
            turnoJogador1 = Not turnoJogador1

            ' Desativar o botão após ser clicado
            Btn8.Enabled = False
            Verificar()
        End If
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        If Btn9.Text = "" Then ' Verifica se o botão está vazio
            If turnoJogador1 Then
                Btn9.Text = "O"
                Jogo(9) = 1
            Else
                Btn9.Text = "X"
                Jogo(9) = 10
            End If

            ' Alternar o turno
            turnoJogador1 = Not turnoJogador1

            ' Desativar o botão após ser clicado
            Btn9.Enabled = False
            Verificar()
        End If


    End Sub
End Class
