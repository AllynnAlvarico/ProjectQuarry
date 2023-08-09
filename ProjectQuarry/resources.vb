Public Class resources
    'Public logs As New logs
    'Level 1 Resources Name and Counter
    Private r1_Name As String() = {"Water", "Wood", "Coal", "Iron", "Copper"}
    Private r1_Counter As Integer() = {3, 5, 10, 10, 12}
    Public water_counter, wood_counter, coal_counter, iron_counter, copper_counter As Integer
    Public water, wood, coal, iron, copper As Integer
    'Level 2 Resources Name and Counter
    Private r2_Name As String() = {"Tin", "Silver", "Gold"}
    Private r2_Counter As Integer() = {15, 20, 30}
    Public tin, silver, gold As Integer
    Public tin_counter, silver_counter, gold_counter As Integer
    'Level 3 Resource Name and Counter
    Private r3_Name As String() = {"Aluminium", "Platinum", "Tungsten"}
    Private r3_Counter As Integer() = {45, 100, 120}
    Public aluminum, platinum, tungsten As Integer
    Public alum_counter, plat_counter, tungs_counter As Integer
    'Level 1 Resource Creation example wood, coal
    Public fire, temp As Integer ' not needed yet
    Public fire_counter, temp_counter As Integer ' not needed yet
    Public Sub New()
        'this sets the value of each counter
        'Level 1 Counters
        water_counter = r1_Counter(0)
        wood_counter = r1_Counter(1)
        coal_counter = r1_Counter(2)
        iron_counter = r1_Counter(3)
        copper_counter = r1_Counter(4)
        'Level 2 Counters
        tin_counter = r2_Counter(0)
        silver_counter = r2_Counter(1)
        gold_counter = r2_Counter(2)
        'Level 3 Counter
        alum_counter = r3_Counter(0)
        plat_counter = r3_Counter(1)
        tungs_counter = r3_Counter(2)
        'Level 1 Creation
        fire_counter = 10 ' not needed yet
        temp_counter = 10 ' not needed yet
    End Sub
    Public Sub getMinedOres(second As Double, counter As Integer, ByRef stockpile As Integer)
        If second Mod counter = 0 Then
            stockpile += 1
        End If
    End Sub
    'this section of code gets and returns the value of each stockpiles that had been extracted
    'Level 1 Resource Getters Methods
    Public Function getWater()
        Return water
    End Function
    Public Function getStrWater()
        Return r1_Name(0)
    End Function
    Public Function getWood()
        Return wood
    End Function
    Public Function getStrWood()
        Return r1_Name(1)
    End Function
    Public Function getCoal()
        Return coal
    End Function
    Public Function getStrCoal()
        Return r1_Name(2)
    End Function
    Public Function getIron()
        Return iron
    End Function
    Public Function getStrIron()
        Return r1_Name(3)
    End Function
    Public Function getCopper()
        Return copper
    End Function
    Public Function getStrCopper()
        Return r1_Name(4)
    End Function
    'Level 2 Resource Getter Methods







    'Public Function getGas()
    '    Return gas
    'End Function
    'Public Function getOil()
    '    Return oil
    'End Function
    'Public Function getFire()
    '    Return fire
    'End Function
    'Public Function getTemperature()
    '    Return temp
    'End Function
End Class
