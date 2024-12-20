﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SAT.DATA.EF
{
    public class StudentMetadata
    {
        [Required(ErrorMessage = "*Required")]
        public int StudentId { get; set; }
        [Required(ErrorMessage = "*Required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Major { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        [Display(Name = "State Code")]
        [StringLength(2, ErrorMessage = "*Please use 2-character state code.")]
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        [Required(ErrorMessage = "*Required")]
        public string Email { get; set; }
        public string PhotoUrl { get; set; }
        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Status")]
        public int SSID { get; set; }
        //[Required(ErrorMessage = "*Required")]


        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {
        [Display(Name = "Student Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        [Display(Name = "Full Address")]
        public string FullAddress
        {
            get
            {
                return Address + ", " + City + ", " + State + " " + ZipCode;
            }
        }
    }

}
