using data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data
{
    public class QuestionRepository : RepositoryBase<Question>
    {
        databasePrnContext databasePrnContext = new databasePrnContext();
        CourseRepository courseRepository = new CourseRepository();
        public QuestionRepository() : base()
        {

        }
        public List<Question> FindQuestionsByCourseId(string courseId)
        {
            return databasePrnContext.Questions
                .Where(q => q.CourseId == courseId)
                .ToList();
        }
        public string GetCorrectAnswerForCourse(string courseId)
        {
            var question = databasePrnContext.Questions
                .Where(q => q.CourseId == courseId)
                .FirstOrDefault(); 

            if (question != null)
            {
                return question.CorrectAnswer;
            }

            return null;
        }
    }
}
