using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreEnigmaCamp.Database
{
    [Table("Teacher", Schema = "dbo")]
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Teacher Id")]
        public int TeacherId { get; set; }

        [Required]
        [Column(TypeName = "NVarchar(100)")]
        [Display(Name ="First Name")]
        public string FirtName { get; set; }

        [Column(TypeName ="NVarchar(100)")]
        [Display(Name ="Last Name")]
        public string? LastName { get; set; }
        public virtual ICollection<Courses> Courses { get; set; }
    }
}
