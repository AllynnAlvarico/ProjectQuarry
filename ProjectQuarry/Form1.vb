Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    Public appTimer As New game_timer
    Public animation As New animation
    Public conlog As New logs

    Public waterObj = New Resource("Water", 1)
    Public woodObj = New Resource("Wood", 5)
    Public coalObj = New Resource("Coal", 10)
    Public ironObj = New Resource("Iron", 10)
    Public copperObj = New Resource("Copper", 8)
    Public maxResource As Integer = 10

    Public Sub New()
        InitializeComponent()
        'on this intializer, the code here is to make it easier to adjust the counter
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
        animation.pickaxe_frame_animation(pickaxe_animation, pickaxe_img, animationTimer)
    End Sub
    Private Sub addLogs_Click(sender As Object, e As EventArgs) Handles addLogs.Click
    End Sub
    Private Sub clear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        conlog.clear_logs(gamelog, btnclear)
    End Sub
    Public Sub level1Resource()
        ExtractResource()
        Extractlogs()
    End Sub
    Public Sub ExtractResource()
        minedMinerals(appTimer.second, waterObj)
        minedMinerals(appTimer.second, woodObj)
        minedMinerals(appTimer.second, coalObj)
        minedMinerals(appTimer.second, ironObj)
        minedMinerals(appTimer.second, copperObj)
    End Sub
    Public Sub Extractlogs()
        conlog.time_logs(gamelog, appTimer.getHour, appTimer.getMinute, appTimer.getSecond, waterObj)
        conlog.time_logs(gamelog, appTimer.getHour, appTimer.getMinute, appTimer.getSecond, woodObj)
        conlog.time_logs(gamelog, appTimer.getHour, appTimer.getMinute, appTimer.getSecond, coalObj)
        conlog.time_logs(gamelog, appTimer.getHour, appTimer.getMinute, appTimer.getSecond, ironObj)
        conlog.time_logs(gamelog, appTimer.getHour, appTimer.getMinute, appTimer.getSecond, copperObj)
    End Sub
    Public Sub minedMinerals(second As Double, resourceOBJ As Resource)
        If second Mod resourceOBJ.getProdutionTime = 0 Then
            If resourceOBJ.getProdStockpile < maxResource Then
                resourceOBJ.setStockpile(1)
            ElseIf resourceOBJ.getProdStockpile >= maxResource Then
                conlog.time_logs(gamelog, appTimer.getHour, appTimer.getMinute, appTimer.getSecond, resourceOBJ)
            End If
        End If
    End Sub

End Class
