using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SAT.DATA.EF.Metadata
{
    public class ScheduledClassStatusMetadata
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public ScheduledClassStatus()
        //{
        //    this.ScheduledClasses = new HashSet<ScheduledClass>();
        //}

        [Required(ErrorMessage = "*Required")]
        public int SCSID { get; set; }

        [Required(ErrorMessage = "*Required")]
        public string SCSName { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ScheduledClass> ScheduledClasses { get; set; }
    }
}
