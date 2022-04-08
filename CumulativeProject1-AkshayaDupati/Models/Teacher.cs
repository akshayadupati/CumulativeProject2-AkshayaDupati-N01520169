 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CumulativeProject1_AkshayaDupati.Models
{
    /// <summary>
    /// Blueprint of the Teacher datatype
    /// </summary>
    public class Teacher
    {
        [Required(ErrorMessage = "Name is Required")]
        public int TeacherId { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        public string TeacherFName { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        public string TeacherLName { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        public int TeacherSalary{ get; set; }

    }
}