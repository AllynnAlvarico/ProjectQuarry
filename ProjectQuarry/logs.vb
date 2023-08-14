Public Class logs
    'Public showLog As Resource
    Public Stock As List(Of Integer) = New List(Of Integer)
    ''making a class called "LogEntry" is to encapsulate and organise the related data into a more structured format.
    Public Class LogEntry
        Public Property LogStock As Integer
        Public Property TimeStamp As String
    End Class
    Public logEntries As New List(Of LogEntry)
    Public Sub time_logs(game_log As Label, hour As Integer, minute As Integer, second As Integer, logShow As Resource)
        'the "Mod" also known as modulo operation that calculates the remainder and gets the remainder
        'this section is for seconds, minutes and hours.
        Dim formattedSeconds As String = CInt(second Mod 60).ToString("00")
        Dim formattedMinute As String = CInt(minute Mod 60).ToString("00")
        Dim formattedHours As String = CInt(hour Mod 24).ToString("00")
        '"formattedTime" is assigned to be much shorter and ($) or dollar sign is an interpolation to insert formatted string by "{myVariable)"
        'the {} segregate and makes the code maintainable
        Dim formattedTime As String = $"[{formattedHours}:{formattedMinute}:{formattedSeconds}]: "
        Dim formattedLogs As String = $"{logShow.getProdutionName}: +{logShow.getProdStockpile}"
        '====================================================================
        'assigned the "time_stamp" to this label known as game_log
        Dim text_stamp = formattedTime & formattedLogs

        If logShow.getProdStockpile > logShow.getFormerStockpile Then
            logShow.setFormerStockpile(logShow.getProdStockpile())
            logEntries.Add(New LogEntry With {.LogStock = logShow.getProdStockpile(), .TimeStamp = text_stamp})
            game_log.Text += text_stamp & Environment.NewLine
        End If
        If second = 40 Then
            game_log.Text = ""
        End If
    End Sub
    'this method/funtion is to pass parameters and adding a handler to perform a "clear" on the label when the button is clicked
    Public Sub clear_logs(game_log As Label, btnClear As Button)
            AddHandler btnClear.Click,
            Sub(sender As Object, e As EventArgs)
                game_log.Text = ""
            End Sub
        End Sub
    End Class
