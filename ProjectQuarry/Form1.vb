﻿Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    Public appTimer As New game_timer
    Public animation As New animation
    Public conlog As New logs
    Public objResource As resources

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        objResource = New resources(3, 5, 10, 15, 25, 35, 45)
    End Sub


    Private Sub currency_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        appTimer.startTime(gameTimer)

    End Sub

    Private Sub gameTimer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick
        appTimer.gameClock()
        appTimer.getConsoleLogs()
        ExtractWaterAndLog()
        ExtractWoodAndLog()
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
    Public Sub ExtractWaterAndLog()
        objResource.getMinedOres(appTimer.second, objResource.water_counter, objResource.water)
        conlog.time_logs(gamelog, appTimer.getHour, appTimer.getMinute, appTimer.getSecond, objResource.water, NameOf(objResource.water))
    End Sub
    Public Sub ExtractWoodAndLog()
        objResource.getMinedOres(appTimer.second, objResource.wood_counter, objResource.wood)
        conlog.time_logs(gamelog, appTimer.getHour, appTimer.getMinute, appTimer.getSecond, objResource.wood, NameOf(objResource.wood))
    End Sub
End Class