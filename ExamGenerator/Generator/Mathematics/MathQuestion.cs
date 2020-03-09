using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGenerator.Generator.Mathematics
{
    public class MathQuestion : IQuestion
    {
        public string Level;
        internal string text;
        internal string answer;

        public string GetAnswer()
        {
            return this.answer;
        }

        public string GetScore()
        {
            throw new NotImplementedException();
        }

        public string GetText()
        {
            return this.text;
        }
    }
}
