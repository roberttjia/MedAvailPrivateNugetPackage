using System;

namespace MedAvail.Utilities;

public static class DateTimeExtensions
{
    public static string ToIso8601(this DateTime dateTime)
    {
        return dateTime.ToString("yyyy-MM-ddTHH:mm:ssZ");
    }

    public static bool IsWeekend(this DateTime dateTime)
    {
        return dateTime.DayOfWeek == DayOfWeek.Saturday
            || dateTime.DayOfWeek == DayOfWeek.Sunday;
    }

    public static DateTime StartOfDay(this DateTime dateTime)
    {
        return dateTime.Date;
    }

    public static DateTime EndOfDay(this DateTime dateTime)
    {
        return dateTime.Date.AddDays(1).AddTicks(-1);
    }
}
