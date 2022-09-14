Public Class Aluno
    Inherits Pessoa
    'Comando para que Aluno herde caracteristicas de Pessoa

    Private rgm As String

    Public Sub New(nome As String, rgm As String)
        MyBase.New(nome)
        'MyBase informa que essa informação pertence a classe Pai
        Me.rgm = rgm
    End Sub

    Public Property pRgm As String
        Get
            Return rgm
        End Get
        Set(value As String)
            rgm = value
        End Set
    End Property
End Class
