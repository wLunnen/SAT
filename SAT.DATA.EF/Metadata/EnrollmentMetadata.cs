using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SAT.DATA.EF
{
    public class EnrollmentMetadata
    {
        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Enrollment ID")]
        public int EnrollmentId { get; set; }

        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Student ID")]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Scheduled Class ID")]
        public int ScheduledClassId { get; set; }

        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Enrollment Date")]
        public System.DateTime EnrollmentDate { get; set; }

        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Instructor Name")]
        public virtual ScheduledClass ScheduledClass { get; set; }

        [Required(ErrorMessage = "*Required")]
        [Display(Name = "First Name")]
        public virtual Student Student { get; set; }



    }

    [MetadataType(typeof(EnrollmentMetadata))]
    public partial class Enrollment
    {

    }
    //public class ScheduledClasses
    //{
    
    //public string InstructorName { get; set; }
    //}
    //[MetadataType(typeof(EnrollmentMetadata))]
    //public partial class ScheduledClass
    //{

    //}
    //public class Students
    //{

    //    public string FirstName { get; set; }
    //}
    //[MetadataType(typeof(EnrollmentMetadata))]
    //public partial class Student
    //{

    //}
}
