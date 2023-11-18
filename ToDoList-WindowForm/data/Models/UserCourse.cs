using System;
using System.Collections.Generic;

#nullable disable

namespace data.Models
{
    public partial class UserCourse
    {
        public string UserId { get; set; }
        public string CourseId { get; set; }
        public bool Status { get; set; }

        public virtual Course Course { get; set; }
        public virtual User User { get; set; }
    }
}
