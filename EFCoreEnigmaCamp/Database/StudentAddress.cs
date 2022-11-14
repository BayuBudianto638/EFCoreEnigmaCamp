﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreEnigmaCamp.Database
{
    [Table("StudentAddresses", Schema ="dbo")]
    public class StudentAddress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name ="Student Address Id")]
        public int StudentAddressId { get; set; }

        [Column(TypeName ="NVarchar(200)")]
        [Display(Name ="Address 1")]
        public string? Address1 { get; set; }

        [Column(TypeName = "NVarchar(200)")]
        [Display(Name = "Address 2")]
        public string? Address2 { get; set; }

        public string? Mobile { get; set; }

        public string? Email { get; set; }

        public int StudentId { get; set; } // Foreign Key dari table Student

        public virtual Student Student { get; set; } // Relation ke Table Student
    }
}
