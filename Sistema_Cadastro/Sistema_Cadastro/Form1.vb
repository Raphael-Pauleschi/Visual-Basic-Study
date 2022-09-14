Public Class Form1
    Private Sub btnExibirAluno_Click(sender As Object, e As EventArgs) Handles btnExibirAluno.Click
        Dim obj_aluno As New Aluno("Fulano de Tal", "666666")
        tbtNomeAluno.Text = obj_aluno.PNome
        tbtRgmAluno.Text = obj_aluno.pRgm

    End Sub

    Private Sub lblExibirProfessor_Click(sender As Object, e As EventArgs) Handles lblExibirProfessor.Click
        Dim obj_professor As New Professor("Cicrano da Silva", "Matematica")
        tbtNomeProfessor.Text = obj_professor.PNome
        tbtTituloProfessor.Text = obj_professor.pTitulo
    End Sub
End Class
