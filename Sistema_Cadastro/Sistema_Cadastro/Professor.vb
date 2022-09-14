Public Class Professor
    Inherits Pessoa
    'Comando para que Aluno herde caracteristicas de Pessoa

    Private titulo As String

    Public Sub New(nome As String, titulo As String)
        MyBase.New(nome)
        'MyBase informa que essa informação pertence a classe Pai
        Me.titulo = titulo
    End Sub

    Public Property pTitulo As String
        Get
            Return titulo
        End Get
        Set(value As String)
            titulo = value
        End Set
    End Property
End Class
