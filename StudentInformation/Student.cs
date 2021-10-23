using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformation
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }

        public int StudentId { get; set; }

        public string Faculty { get; set; }

        public string Group { get; set; }

        public bool IsActive { get; set; }
    }
}
