Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()>
Public Class UnitTestLeitura

    <TestMethod()>
    Public Sub GetQTDPalavrasCenario001()

        'Teste
        Dim qtd = New Leitura().GetQuantidadePalavras("Gelson Gilmar")
        Assert.AreEqual(qtd, 2)

    End Sub

End Class