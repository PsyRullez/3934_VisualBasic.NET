Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles

Public Class Login
    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DB_CarlosBastos.accdb")

    Private Sub LblSignin_Click(sender As Object, e As EventArgs) Handles LblSignin.Click
        Signin.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        mycon.Open()
        Dim mycmd As New OleDbCommand("SELECT * FROM Users WHERE Uname ='" & TextBox1.Text & "' And Passw= '" & TextBox2.Text & "'", mycon)
        Dim myread As OleDbDataReader = mycmd.ExecuteReader
        If myread.Read Then
            MsgBox("Login efetuado com sucesso!")
            TextBox1.Clear()
            TextBox2.Clear()
        Else
            MsgBox("ID ou PW errada ")
        End If
        mycon.Close()
    End Sub
End Class
