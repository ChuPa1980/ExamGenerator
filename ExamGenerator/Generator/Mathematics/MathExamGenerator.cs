using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGenerator.Generator.Mathematics
{
    public class MathExamGenerator : IGenerator
    {
        public Exam Generate(IExamSettings settings)
        {
            Exam mathExam = new Exam();
            mathExam.Name = settings.GetExamName();
            mathExam.Questions = this.CreateQuestions(settings.GetNumOfQuestions(), settings.GetMaxOperand());

            return mathExam;
        }

        private IList<IQuestion> CreateQuestions(int number, int max)
        {
            IList<IQuestion> questions = new List<IQuestion>();
            for (int i = 0; i < number; i++)
            {
                questions.Add(MathQuestionFactory.Create(max));
            }

            return questions;
        }
    }
}
