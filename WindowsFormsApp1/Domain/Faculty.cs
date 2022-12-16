using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Domain
{
    public class Faculty
    {
        public int FacultyId { get; set; }
        public int FullName { get; set; }
        ICollection<Course> Courses { get; set; }
    }
}
