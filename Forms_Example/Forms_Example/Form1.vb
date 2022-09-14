Public Class Form1
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        'revisão da aula anterior
        MessageBox.Show("Olá " & txtNome.Text & " ,bem-vindo a nossa aula!", "Mensagem ao usuário")
    End Sub
End Class
