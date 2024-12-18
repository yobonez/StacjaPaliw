namespace StacjaPaliwUI
{
    internal static class DateTimeUtils
    {
        public static DateTime StartOfDay( DateTime theDate, bool _isPrevious)
        {
            if (_isPrevious) return theDate.Date.AddDays(-1);
            return theDate.Date;
        }

        public static DateTime EndOfDay( DateTime theDate, bool _isPrevious)
        {
            DateTime endOfDay = theDate.Date.AddDays(1).AddTicks(-1);

            if (_isPrevious) return endOfDay.AddDays(-1);
            return endOfDay;
        }

        public static DateTime StartOfWeek( DateTime theDate, bool _isPrevious)
        {
            DayOfWeek startDayOfWeek = DayOfWeek.Monday;
            int diff = theDate.DayOfWeek - startDayOfWeek;
            if (diff == -1) diff = 6;

            if (_isPrevious)
                return StartOfDay(theDate.AddDays(-1 * (diff + 7)), false);

            return StartOfDay(theDate.AddDays(-1 * diff), false);
        }

        public static DateTime StartOfMonth( DateTime theDate, bool _isPrevious)
        {
            if (_isPrevious) return theDate.AddDays(-theDate.Day + 1).AddMonths(-1);
            return theDate.AddDays(-theDate.Day + 1);
        }
        public static DateTime EndOfMonth( DateTime theDate, bool _isPrevious)
        {
            if (_isPrevious)
            {
                // 1. of prev month
                DateTime prevMonth = theDate.AddDays(-theDate.Day + 1)
                                            .AddMonths(-1);

                int daysInPrevMonth = DateTime.DaysInMonth(prevMonth.Year, prevMonth.Month);
                return prevMonth.AddDays(daysInPrevMonth - 1);
            }

            int daysInMonth = DateTime.DaysInMonth(theDate.Year, theDate.Month);
            return theDate.AddDays(daysInMonth - theDate.Day);
        }
        public static DateTime StartOfYear( DateTime theDate, bool _isPrevious)
        {
            DateTime firstDayOfYear = StartOfDay(theDate.AddDays(-theDate.DayOfYear + 1), false);
            if (_isPrevious) return firstDayOfYear.AddYears(-1);
            return firstDayOfYear;
        }
        public static DateTime EndOfYear( DateTime theDate, bool _isPrevious)
        {
            int year = theDate.Year;
            DateTime date = DateTime.ParseExact($"12-31-{year}", "MM-dd-yyyy", System.Globalization.CultureInfo.InvariantCulture);

            if (_isPrevious) return EndOfDay(date.AddYears(-1), false);
            return EndOfDay(date, false);
        }
    }
}
