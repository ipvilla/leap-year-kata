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

        [Test]
        public void not_consider_1997_a_leap_year()
        {
            var isALeapYear = LeapYearChecker.IsLeapYear(1997);

            Assert.IsFalse(isALeapYear);
        }
    }
}