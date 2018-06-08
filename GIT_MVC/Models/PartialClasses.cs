using System.ComponentModel.DataAnnotations;
using System;

namespace GIT_MVC.Models
{
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {

    }


    [MetadataType(typeof(EnrollmentMetadata))]
    public partial class Enrollment
    {

    }
}