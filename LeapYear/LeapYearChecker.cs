namespace LeapYear
{
    public static class LeapYearChecker
    {
        public static bool? IsLeapYear(int year)
        {
            return year % 4 == 0;
        }
    }
}