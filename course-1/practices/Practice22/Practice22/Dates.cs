using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice22
{
    internal class Dates
    {
        public int Year {  get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public Dates(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
    }
}
