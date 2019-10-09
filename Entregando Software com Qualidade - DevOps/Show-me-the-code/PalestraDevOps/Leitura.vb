Public Class Leitura

    Public Function GetQuantidadePalavras(ByVal pTexto As String) As Integer
        Dim _qtd As Integer

        _qtd = pTexto.Split(" ").Length

        Return _qtd
    End Function

End Class
