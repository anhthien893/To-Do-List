using System;
using System.Collections.Generic;

#nullable disable

namespace data.Models
{
    public partial class Question
    {
        public Question()
        {
            QuestionTests = new HashSet<QuestionTest>();
            QuestionId=Guid.NewGuid().ToString();
        }

        public string QuestionId { get; set; }
        public string CourseId { get; set; }
        public string Title { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string CorrectAnswer { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<QuestionTest> QuestionTests { get; set; }
    }
}
