using EFCoreEnigmaCamp.Cores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreEnigmaCamp.Database
{
    // Model dari object Student
    [Table("Students", Schema = "dbo")]
    public class Student
    {
        [Key] // Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto Increament
        [Display(Name = "Student Id")]
        public int StudentId { get; set; }

        [Required] // Not Null jika di SQL
        [Column(TypeName = "Nvarchar(20)")] // Length string sepanjang 20 karakter
        [Display(Name = "Student Code")]
        public string StudentCode { get; set; }

        [Required]
        [Column(TypeName = "Nvarchar(100)")]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        public DateTime? DoB { get; set; }

        [Column(TypeName="Nvarchar(6)")]
        public Gender Gender { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastUpdate { get; set; }

        public virtual StudentAddress StudentAddress { get; set; }
        public virtual ICollection<StudentCourses> StudentCourses { get; set; }
    }
}
