using System;
using System.ComponentModel.DataAnnotations;

namespace GIT_MVC.Models
{
    public class StudentMetadata
    {
        [Required]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstName;

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate;
    }

    public class EnrollmentMetadata
    {
        [Display(Name = "Grade Percentage")]
        public Nullable<decimal> GradePercentage;
        [Display(Name = "Letter Grade")]
        public string LetterGrade;
    }

    public class CourseMetadata
    {
        [Display(Name = "Course")]
        public string Title;
        
    }
}