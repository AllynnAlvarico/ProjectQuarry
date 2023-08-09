Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    Public appTimer As New game_timer
    Public animation As New animation
    Public conlog As New logs
    Public objResource As resources
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        'on this intializer, the code here is to make it easier to adjust the counter
        '(water, wood, coal, gas, oil, fire and temperature) this are the format when inserting a value on a counter/interval to produce resource
        objResource = New resources()
    End Sub
    'this is when the program is open or run the app timer start [appTimer.startTime(gameTimer)]
    Private Sub currency_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        appTimer.startTime(gameTimer)
    End Sub
    Private Sub gameTimer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick
        appTimer.gameClock()
        'appTimer.getConsoleLogs()
        level1Resource()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        animation.pickaxe_frame_animation(pickaxe_animation, pickaxe_img, Timer1)
    End Sub
    Private Sub addLogs_Click(sender As Object, e As EventArgs) Handles addLogs.Click
        objResource.getWater()
    End Sub
    Private Sub clear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        conlog.clear_logs(gamelog, btnclear)
    End Sub
    'this section of methods are the extracted resource, by doing this makes the code a bit cleaner, segregated and easier to maintain and adjust if needed
    'Level 1 Resource
    Public Sub level1Resource()
        ExtractWaterAndLog()
        ExtractWoodAndLog()
        ExtractCoalAndLog()
        ExtractIronAndLog()
        ExtractCopperAndLog()
    End Sub
    Public Sub ExtractWaterAndLog()
        objResource.getMinedOres(appTimer.second, objResource.water_counter, objResource.water)
        conlog.time_logs(gamelog, appTimer.getHour, appTimer.getMinute, appTimer.getSecond, objResource.water, objResource.getStrWater)
    End Sub
    Public Sub ExtractWoodAndLog()
        objResource.getMinedOres(appTimer.second, objResource.wood_counter, objResource.wood)
        conlog.time_logs(gamelog, appTimer.getHour, appTimer.getMinute, appTimer.getSecond, objResource.wood, objResource.getStrWood)
    End Sub
    Public Sub ExtractCoalAndLog()
        objResource.getMinedOres(appTimer.second, objResource.coal_counter, objResource.coal)
        conlog.time_logs(gamelog, appTimer.getHour, appTimer.getMinute, appTimer.getSecond, objResource.coal, objResource.getStrCoal)
    End Sub
    Public Sub ExtractIronAndLog()
        objResource.getMinedOres(appTimer.second, objResource.iron_counter, objResource.iron)
        conlog.time_logs(gamelog, appTimer.getHour, appTimer.getMinute, appTimer.getSecond, objResource.iron, objResource.getStrIron)
    End Sub
    Public Sub ExtractCopperAndLog()
        objResource.getMinedOres(appTimer.second, objResource.copper_counter, objResource.copper)
        conlog.time_logs(gamelog, appTimer.getHour, appTimer.getMinute, appTimer.getSecond, objResource.copper, objResource.getStrCopper)
    End Sub
    Private Sub openIntventory_Click(sender As Object, e As EventArgs) Handles openIntventory.Click
        inventoryWindow.Show()
        openIntventory.Enabled = False
    End Sub

End Class
