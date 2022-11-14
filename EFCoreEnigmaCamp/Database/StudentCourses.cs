using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreEnigmaCamp.Database
{
    [Table("StudentCourses", Schema = "dbo")]
    public class StudentCourses
    {
        public int StudentId { get; set; } // FK
        public virtual Student Students { get; set; }
        public int CourseId { get; set; } // FK
        public virtual Courses Courses { get; set; }
    }
}
