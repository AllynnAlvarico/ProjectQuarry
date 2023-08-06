Public Class logs
    Public showLog As resources
    'making a class called "LogEntry" is to encapsulate and organise the related data into a more structured format.
    Public Class LogEntry
        Public Property LogStock As Integer
        Public Property TimeStamp As String
    End Class
    Private logEntries As New List(Of LogEntry)
    Private resourceLogs As New Dictionary(Of String, Integer)()
    Public Sub time_logs(game_log As Label, hour As Integer, minute As Integer, second As Integer, stockpile As Integer, name As String)
        Dim oldStockpile As Integer = 0
        'this (remainingSeconds) variable is converted into an integer type
        'the "Mod" also known as modulo operation that calculates the remainder and gets the remainder
        'this section is for seconds, minutes and hours.
        Dim formattedSeconds As String = CInt(second Mod 60).ToString("00")
        Dim formattedMinute As String = CInt(minute Mod 60).ToString("00")
        Dim formattedHours As String = CInt(hour Mod 60).ToString("00")
        '"formattedTime" is assigned to be much shorter and ($) or dollar sign is an interpolation to insert formatted string by "{myVariable)"
        'the {} segregate and makes the code maintainable
        Dim formattedTime As String = $"[{formattedHours}:{formattedMinute}:{formattedSeconds}]: "
        Dim formattedLogs As String = $"{name}: {stockpile}"
        '====================================================================
        Dim oldStock As Integer = If(logEntries.Count > 0, logEntries.Last().LogStock, 0)

        If stockpile > oldStockpile Then
            'this if statement goes as if resource value is greater than the old resource value then the resource becomes the old resource
            oldStockpile = stockpile
            Dim text_stamp = formattedTime & formattedLogs
            Dim existingEntry = logEntries.FirstOrDefault(Function(entry) entry.LogStock = stockpile)
            If existingEntry Is Nothing Then
                ' If not, add the new entry to logEntries and append the time stamp to the game_log label
                logEntries.Add(New LogEntry With {.LogStock = stockpile, .TimeStamp = text_stamp})
                'assigned the "time_stamp" to this label known as game_log
                game_log.Text += text_stamp & Environment.NewLine
            End If
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
