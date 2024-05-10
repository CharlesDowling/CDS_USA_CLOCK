Imports System.Windows.Threading.DispatcherTimer
Imports System
Imports System.Windows.Threading

Class MainWindow

    Public Sub Main()
        Dim dispatcherTimer As DispatcherTimer = New System.Windows.Threading.DispatcherTimer()
        AddHandler dispatcherTimer.Tick, AddressOf clock_update
        dispatcherTimer.Interval = New TimeSpan(0, 0, 1)
        dispatcherTimer.Start()
    End Sub

    Sub clock_update()
        Dim TimeZoneEST As TimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time")
        Dim TimeZoneCST As TimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time")
        Dim TimeZoneMST As TimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Mountain Standard Time")
        Dim TimeZonePST As TimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time")
        EST.Content = TimeString
        CST.Content = (TimeZoneInfo.ConvertTime(TimeString, TimeZoneInfo.Local, TimeZoneCST).Hour.ToString("D2") & ":" & TimeZoneInfo.ConvertTime(TimeString, TimeZoneInfo.Local, TimeZoneCST).Minute.ToString("D2") & ":" & TimeZoneInfo.ConvertTime(TimeString, TimeZoneInfo.Local, TimeZoneCST).Second.ToString("D2"))
        MST.Content = (TimeZoneInfo.ConvertTime(TimeString, TimeZoneInfo.Local, TimeZoneMST).Hour.ToString("D2") & ":" & TimeZoneInfo.ConvertTime(TimeString, TimeZoneInfo.Local, TimeZoneMST).Minute.ToString("D2") & ":" & TimeZoneInfo.ConvertTime(TimeString, TimeZoneInfo.Local, TimeZoneMST).Second.ToString("D2"))
        PST.Content = (TimeZoneInfo.ConvertTime(TimeString, TimeZoneInfo.Local, TimeZonePST).Hour.ToString("D2") & ":" & TimeZoneInfo.ConvertTime(TimeString, TimeZoneInfo.Local, TimeZonePST).Minute.ToString("D2") & ":" & TimeZoneInfo.ConvertTime(TimeString, TimeZoneInfo.Local, TimeZonePST).Second.ToString("D2"))
    End Sub


End Class
