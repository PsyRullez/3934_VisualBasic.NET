Imports System.Data.OleDb
Public Class Signin
    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|DB_CarlosBastos.accdb")
    Private Sub BtnSignIn_Click(sender As Object, e As EventArgs) Handles BtnSignIn.Click
        mycon.Open()
        Dim mycmd As New OleDbCommand("Insert into Users(Uname,Passw,Email,Num) Values ('" & TxtRUser.Text & "','" & TxtRPW.Text & "','" & TxtREmail.Text & "','" & TxtRPNumber.Text & "')", mycon)
        Try
            mycmd.ExecuteNonQuery()
            mycon.Close()
            TxtRUser.Clear()
            TxtRPW.Clear()
            TxtRPNumber.Clear()
            TxtRPNumber.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Me.Close()
        Login.Show()
    End Sub
End Class