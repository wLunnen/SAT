using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SAT.DATA.EF//.Metadata
{
    public class CourseMetadata
    {
        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Course ID")]
        public int CourseId { get; set; }

        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Course Description")]
        public string CourseDescription { get; set; }

        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Credit Hours")]
        public byte CreditHours { get; set; }

        public string Curriculum { get; set; }

        public string Notes { get; set; }

        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Is Active?")]
        public bool IsActive { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ScheduledClass> ScheduledClasses { get; set; }
    }
    [MetadataType(typeof(CourseMetadata))]
    public partial class Course
    {
    }
}
