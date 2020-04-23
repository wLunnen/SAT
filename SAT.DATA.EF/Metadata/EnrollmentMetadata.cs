using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SAT.DATA.EF.Metadata
{
    public class EnrollmentMetadata
    {
        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Enrollment ID")]
        public int EnrollmentID { get; set; }

        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Student ID")]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Scheduled Class ID")]
        public int ScheduleClassId { get; set; }

        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Enrollment Date")]
        public System.DateTime EnrollmentDate { get; set; }
        

        //public virtual ScheduledClass ScheduledClass { get; set; }
        //public virtual Student Student { get; set; }
    }
}
