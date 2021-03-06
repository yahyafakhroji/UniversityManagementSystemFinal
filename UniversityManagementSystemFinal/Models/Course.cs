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
    
    public partial class Course
    {
        public Course()
        {
            this.AssignCourses = new HashSet<AssignCourse>();
            this.EnrollCourses = new HashSet<EnrollCourse>();
            this.ResultEntries = new HashSet<ResultEntry>();
            this.RoomAllocations = new HashSet<RoomAllocation>();
            this.Teachers = new HashSet<Teacher>();
        }
    
        public int CourseId { get; set; }
        [Display(Name = "Course Code")]
        [Required(ErrorMessage = "You have to enter Course Code\nSample: CSE-***")]
        [StringLength(int.MaxValue, MinimumLength = 5, ErrorMessage = "Course Code Must be at least 5 Character long.")]
        [Remote("CheckCode", "Course", HttpMethod = "POST", ErrorMessage = "This Course code already Exists")]
        public string CourseCode { get; set; }
        [Display(Name = "Course Name")]
        [Required(ErrorMessage = "You have to enter a Course Name")]
        [Remote("CheckName", "Course", HttpMethod = "POST", ErrorMessage = "This Course Name already Exists")]
        public string CourseName { get; set; }
        [Display(Name = "Course Credit")]
        [Required(ErrorMessage = "You have to enter the Course Credit.")]
        [Range(0.5, 5.0, ErrorMessage = "Credit Range must have to be .5 to 5.0")]
        public float CourseCradit { get; set; }
        [Display(Name = "Course Description")]
        [Required(ErrorMessage = "You have to enter the Course Description.")]
        public string CourseDescription { get; set; }
        [Display(Name = "Semester No")]
        [Required(ErrorMessage = "You have to enter the Semester No.")]
        public int SemesterId { get; set; }
        [Display(Name = "Department Name")]
        [Required(ErrorMessage = "You have to enter the Department Code.")]
        public int DepartmentId { get; set; }
        public string AssignTo { get; set; }
        public bool CourseStatus { get; set; }
    
        public virtual ICollection<AssignCourse> AssignCourses { get; set; }
        public virtual Department Department { get; set; }
        public virtual Semester Semester { get; set; }
        public virtual ICollection<EnrollCourse> EnrollCourses { get; set; }
        public virtual ICollection<ResultEntry> ResultEntries { get; set; }
        public virtual ICollection<RoomAllocation> RoomAllocations { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
