using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimePersons.Models
{
    public class ChosenYears
    {
        public int StartYear { get; set; }
        public int EndYear { get; set; }

        public ChosenYears(int startYear, int endYear)
        {
            StartYear = startYear;
            EndYear = endYear;
        }

        public ChosenYears() { }
    }
}
