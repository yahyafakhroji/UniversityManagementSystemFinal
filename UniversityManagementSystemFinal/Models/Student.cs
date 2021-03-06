//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace UniversityManagementSystemFinal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public Student()
        {
            this.EnrollCourses = new HashSet<EnrollCourse>();
            this.ResultEntries = new HashSet<ResultEntry>();
        }
    
        public int StudentId { get; set; }
        [Display(Name = "Student Name")]
        [Required(ErrorMessage = "You have to enter Student Name")]
        public string StudentName { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "You have to enter Email Address")]
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", ErrorMessage = "E-mail is not valid")]
        [Remote("CheckEmail", "Student", HttpMethod = "POST", ErrorMessage = "This Student already Exists")]
        public string StudentEmail { get; set; }
        [Display(Name = "Contact Number")]
        [Required(ErrorMessage = "You have to enter Contact Number ")]
        [Remote("CheckPhone", "Student", HttpMethod = "POST", ErrorMessage = "This Contact Number already Exists")]
        public string StudentContact { get; set; }
        [Display(Name = "Date")]
        [Required(ErrorMessage = "You Have to select a Date")]
        [DataType(DataType.Date)]
        public System.DateTime Date { get; set; }
        [Display(Name = "Address")]
        [Required(ErrorMessage = "You have to enter Address for Student")]
        public string StudentAddress { get; set; }
        public string RegistrationId { get; set; }
        [Display(Name = "Department")]
        [Required(ErrorMessage = "You have to select departmemnt for Student ")]
        public int DepartmentId { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual ICollection<EnrollCourse> EnrollCourses { get; set; }
        public virtual ICollection<ResultEntry> ResultEntries { get; set; }
    }
}
