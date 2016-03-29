using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem19 : EulerChallenge
    {
        private const string Desc = "How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?";
         public Problem19()
            : base(16, Desc)
        {
            Solve();
        }

        public void Solve()
        {
            var startDate = new DateTime(1901, 01, 01);
            var enddate = new DateTime(2000, 12, 31);
            var dateToTest = startDate;
            var count = 0;

            while (dateToTest < enddate)
            {
                if (dateToTest.Day == 1 && dateToTest.DayOfWeek == DayOfWeek.Sunday)
                {
                    count++;
                }
                dateToTest  = dateToTest.AddDays(1);
            }
            Console.WriteLine(count);
        }
    }
}
