using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace studentBARapp.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
