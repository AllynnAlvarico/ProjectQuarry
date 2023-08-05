Public Class game_timer
    Public second As Integer
    Public minute, elapse_minute As Integer
    Public hour, elapse_hour As Integer
    Public day, elapse_day As Integer
    Public year, elapse_year As Integer
    'Public strSecond, strMinute, strHour, strDay, strYear As String
    'this is the constructor of this app making this method to initialised when the app is running
    Public Sub New()
        second = 0
        minute = 60
        elapse_minute = 0
        hour = 60
        elapse_hour = 0
        day = 24
        elapse_day = 0
        year = 365
        elapse_year = 0
    End Sub
    'this starts the time when app is starts
    Public Sub startTime(time As Timer)
        time.Start()
    End Sub
    Public Sub elapseSeconds()
        second += 1
    End Sub
    'this converts the seconds to minutes, mins to hours, hours to days and days to years
    Public Sub gameMinutes()
        If getSecond() = minute Then
            second = 0
            elapse_minute += 1
        End If
    End Sub
    Public Sub gameHour()
        If getMinute() = hour Then
            elapse_minute = 0
            elapse_hour += 1
        End If
    End Sub
    Public Sub gameDay()
        If getHour() = day Then
            elapse_hour = 0
            elapse_day += 1
        End If
    End Sub
    Public Sub gameYear()
        If getDay() = year Then
            elapse_day = 0
            elapse_year += 1
        End If
    End Sub
    Public Sub gameClock()
        elapseSeconds()
        gameMinutes()
        gameHour()
        gameDay()
        gameYear()
        getYear()
    End Sub
    Public Sub getConsoleLogs()
        Console.WriteLine("Seconds: " & second)
        Console.WriteLine("Minutes: " & elapse_minute)
        Console.WriteLine("Hours: " & elapse_hour)
        Console.WriteLine("Days: " & elapse_day)
        Console.WriteLine("Years: " & elapse_year)
    End Sub
    'this section of code are the getter and returns the data
    Public Function getSecond()
        Return second
    End Function
    Public Function getMinute()
        Return elapse_minute
    End Function
    Public Function getHour()
        Return elapse_hour
    End Function
    Public Function getDay()
        Return elapse_day
    End Function
    Public Function getYear()
        Return elapse_year
    End Function

End Class
