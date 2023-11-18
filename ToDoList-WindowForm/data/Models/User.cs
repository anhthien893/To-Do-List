using System;
using System.Collections.Generic;

#nullable disable

namespace data.Models
{
    public partial class User
    {
        public User()
        {
            QuestionTests = new HashSet<QuestionTest>();
            UserCourses = new HashSet<UserCourse>();
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<QuestionTest> QuestionTests { get; set; }
        public virtual ICollection<UserCourse> UserCourses { get; set; }
    }
}
