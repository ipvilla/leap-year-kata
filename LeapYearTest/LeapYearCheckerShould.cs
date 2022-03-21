using LeapYear;
using NUnit.Framework;

namespace LeapYearTest
{
    public class LeapYearCheckerShould
    {
        [TestCase(1996)]
        [TestCase(2004)]
        public void consider_leap_years_those_divisible_by_4_and_not_by_100(int year)
        {
            var isALeapYear = LeapYearChecker.IsLeapYear(year);

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

        [TestCase(2100)]
        [TestCase(2200)]
        [TestCase(2300)]
        public void not_consider_leap_years_those_divisible_by_4_and_100_but_not_by_400(int year)
        {
            var isALeapYear = LeapYearChecker.IsLeapYear(year);

            Assert.IsFalse(isALeapYear);
        }
    }
}