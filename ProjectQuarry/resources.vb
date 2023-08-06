Public Class resources
    Public logs As New logs


    'Basic Resource Name and Resource Counter
    Public basic_ResourceNameAndCounter As Dictionary(Of String, Integer)()

    Public water, wood, coal, gas, oil As Integer
    Public water_counter, wood_counter, coal_counter, gas_counter, oil_counter As Integer
    Public fire, temp As Integer
    Public fire_counter, temp_counter As Integer
    Public iron, copper, silicon, silver, gold As Integer
    Public iron_counter, copper_counter, silicon_counter, silver_counter, gold_counter As Integer

    Public Sub New(water_req, wood_req, coal_req, gas_req, oil_req, fire_req, temp_req)
        'this adds the strings and value of the counter for the "basicResName
        water = 0
        wood = 0
        coal = 0
        gas = 0
        oil = 0
        fire = 0
        temp = 0
        iron = 0
        copper = 0
        silicon = 0
        silver = 0
        gold = 0
        'this sets the value of each counter
        water_counter = water_req
        wood_counter = wood_req
        coal_counter = coal_req
        gas_counter = gas_req
        oil_counter = oil_req
        fire_counter = fire_req
        temp_counter = temp_req
    End Sub
    'Need to figure this out
    Public Class extractedResource
        Public resource1Names As String() = {"water", "wood", "coal", "gas", "oil"}
        Public resource1Counter As Integer() = {3, 5, 10, 15, 20}
    End Class
    Public lvl1Resource As New List(Of extractedResource)
    '============================================================================================


    Public Sub getMinedOres(second As Double, counter As Integer, ByRef stockpile As Integer)
            If second Mod counter = 0 Then
                stockpile += 1
            End If
            'getWater()

        End Sub
    'this section of code gets and returns the value of each stockpiles that had been extracted
    Public Function getWater()
        Return water
    End Function
    Public Function getWood()
        Return wood
    End Function
    Public Function getCoal()
        Return coal
    End Function
    Public Function getGas()
        Return gas
    End Function
    Public Function getOil()
        Return oil
    End Function
    Public Function getFire()
            Return fire
        End Function
    Public Function getTemperature()
        Return temp
    End Function
End Class
