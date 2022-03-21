using LeapYear;
using NUnit.Framework;

namespace LeapYearTest
{
    public class LeapYearCheckerShould
    {
        [Test]
        public void consider_1996_a_leap_year()
        {
            var isALeapYear = LeapYearChecker.IsLeapYear(1996);

            Assert.IsTrue(isALeapYear);
        }
    }
}