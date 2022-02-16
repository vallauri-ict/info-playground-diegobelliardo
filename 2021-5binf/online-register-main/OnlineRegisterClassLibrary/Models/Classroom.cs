using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRegisterClassLibrary.Models
{
    public class Classroom
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Section { get; set; }
        public string Specialization { get; set; }

        public Classroom(int id, int year, string section, string specialization)
        {
            Id = id;
            Year = year;
            Section = section;
            Specialization = specialization;
        }

        public Classroom()
        {
        }
    }
}
