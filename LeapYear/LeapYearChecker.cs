namespace LeapYear
{
    public static class LeapYearChecker
    {
        public static bool? IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year == 2100)
                {
                    return false;
                }

                return true;
            }

            return false;
        }
    }
}