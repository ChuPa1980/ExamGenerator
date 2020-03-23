using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGenerator.Generator.Mathematics
{
    public static class MathQuestionFactory
    {
        public static MathQuestion Create(int max)
        {
            MathQuestion question = new MathQuestion();

            int a = Utils.RandomInt(1, max);
            int b = Utils.RandomInt(1, max);

            question.text = $"{a}+{b}=".PadRight(8, '_');
            question.answer = (a + b).ToString();

            return question;
        }
    }
}
