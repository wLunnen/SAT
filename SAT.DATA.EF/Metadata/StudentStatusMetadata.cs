using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SAT.DATA.EF
{
    public class StudentStatusMetadata
    {
        [Required(ErrorMessage = "*Required")]
        public int SSID { get; set; }

        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Status")]
        public string SSName { get; set; }

        public string SSDescription { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Student> Students { get; set; }
    }
    [MetadataType(typeof(StudentStatusMetadata))]
    public partial class StudentStatus
    {

    }
}