using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGenerator.Generator
{
    public class Exam
    {
        public string Name;
        public string Description;
        public string Type;
        public DateTime CreateDate;
        public TimeSpan TimeLimit;
        public IList<IQuestion> Questions;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Name);
            foreach (var q in Questions)
            {
                sb.AppendLine(q.GetText());
            }
            return sb.ToString();
        }
    }
}
