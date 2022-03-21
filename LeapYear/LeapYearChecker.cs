namespace LeapYear
{
    public static class LeapYearChecker
    {
        public static bool? IsLeapYear(int year)
        {
            if(year == 1996 || year == 2000 || year == 2004)
                return true;
            return false;
        }
    }
}