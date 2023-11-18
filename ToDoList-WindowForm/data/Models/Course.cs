using System;
using System.Collections.Generic;

#nullable disable

namespace data.Models
{
    public partial class Course
    {
        public Course()
        {
            UserCourses = new HashSet<UserCourse>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<UserCourse> UserCourses { get; set; }
    }
}
