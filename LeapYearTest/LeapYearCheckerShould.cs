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

        [Test]
        public void consider_2000_a_leap_year()
        {
            var isALeapYear = LeapYearChecker.IsLeapYear(2000);

            Assert.IsTrue(isALeapYear);
        }

        [Test]
        public void consider_2004_a_leap_year()
        {
            var isALeapYear = LeapYearChecker.IsLeapYear(2004);

            Assert.IsTrue(isALeapYear);
        }

        [Test]
        public void not_consider_2100_a_leap_year()
        {
            var isALeapYear = LeapYearChecker.IsLeapYear(2100);

            Assert.IsFalse(isALeapYear);
        }

        [Test]
        public void not_consider_2200_a_leap_year()
        {
            var isALeapYear = LeapYearChecker.IsLeapYear(2200);

            Assert.IsFalse(isALeapYear);
        }
    }
}