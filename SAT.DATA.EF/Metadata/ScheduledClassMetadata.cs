using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SAT.DATA.EF
{
    public class ScheduledClassMetadata
    {
        [Required(ErrorMessage = "*Required")]
        public int ScheduledClassId { get; set; }

        [Required(ErrorMessage = "*Required")]
        public int CourseId { get; set; }

        [Required(ErrorMessage = "*Required")]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        [Display(Name = "Start Date")]
        public System.DateTime StartDate { get; set; }

        [Required(ErrorMessage = "*Required")]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        [Display(Name = "End Date")]
        public System.DateTime EndDate { get; set; }

        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Instructor Name")]
        public string InstructorName { get; set; }

        [Required(ErrorMessage = "*Required")]
        public string Location { get; set; }

        [Required(ErrorMessage = "*Required")]
        public int SCSID { get; set; }

        //public virtual Course Cours { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Enrollment> Enrollments { get; set; }
        //public virtual ScheduledClassStatus ScheduledClassStatus { get; set; }
    }
    [MetadataType(typeof(ScheduledClassMetadata))]
    public partial class ScheduledClass
    {

    }
}
