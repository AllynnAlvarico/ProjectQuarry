Public Class Resource

    Private productionName As String = ""
    Private productionTime As Integer = 0
    Private prodStockpile As Integer = 0
    Private formerStock As Integer = 0
    Public Sub New(t_productName As String, t_productTime As Integer)
        productionName = t_productName
        productionTime = t_productTime
    End Sub
    Public Function getProdutionTime()
        Return productionTime
    End Function
    Public Function getProdutionName()
        Return productionName
    End Function
    Public Sub setStockpile(stock As Integer)
        prodStockpile += stock
    End Sub
    Public Function getProdStockpile()
        Return prodStockpile
    End Function
    Public Function getFormerStockpile()
        Return formerStock
    End Function
    Public Sub setFormerStockpile(stock As Integer)
        formerStock = stock
    End Sub
End Class
