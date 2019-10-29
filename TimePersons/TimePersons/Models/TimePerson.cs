using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TimePersons.Models
{
    public class TimePerson
    {
        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }

        public TimePerson() { }
        public TimePerson(int year, string honor, string name, string country,
            int birthYear, int deathYear, string title, string category, string context)
        {
            Year = year;
            Honor = honor;
            Name = name;
            Country = country;
            BirthYear = birthYear;
            DeathYear = deathYear;
            Title = title;
            Category = category;
            Context = context;
        }

        public List<TimePerson> GetPersons(ChosenYears years)
        {
            List<TimePerson> timePeople = new List<TimePerson>();
            string[] parse = File.ReadAllLines("wwwroot/personOfTheYear.csv");
            for (int i = 1; i < parse.Length; i++)
            {
                string[] line = parse[i].Split(',');
                int birthYear = line[4] == "" ? 0 : Convert.ToInt32(line[4]);
                int deathYear = line[5] == "" ? 0 : Convert.ToInt32(line[4]);
                


                TimePerson timePerson = new TimePerson(Convert.ToInt32(line[0]), line[1], line[2], line[3],
                    birthYear, deathYear, line[6], line[7], line[8]);
                if (timePerson.Year >= years.StartYear && timePerson.Year <= years.EndYear)
                {
                    timePeople.Add(timePerson);
                }
            }
            return timePeople;

        }
    }
}
