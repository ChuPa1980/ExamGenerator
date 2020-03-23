using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGenerator.Generator.Mathematics
{
    public class MathExamSettings : IExamSettings
    {
        internal int numOfQuestions;
        internal int maxOperand; // Max operand
        internal string examName;

        public string GetExamName()
        {
            return this.examName;
        }

        public int GetNumOfQuestions()
        {
            return this.numOfQuestions;
        }

        public int GetMaxOperand()
        {
            return this.maxOperand;
        }
    }
}
