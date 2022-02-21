using OnlineRegisterClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRegisterWebService.Models
{
    public class StudentDetailDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Classroom Classroom { get; set; }
        public string ClassShort { get; set; }
    }
}
