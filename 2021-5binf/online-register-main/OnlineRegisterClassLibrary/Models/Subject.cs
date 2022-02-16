using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRegisterClassLibrary.Models
{
    public class Subject
    {
        public int Id { set; get; }
        public string Description { set; get; }
        public bool IsPeculiar { set; get; }

        public Subject(int id, string description, bool isPeculiar)
        {
            Id = id;
            Description = description;
            IsPeculiar = isPeculiar;
        }
    }
}
